#define DEBUG
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Server.My;

namespace Server;

[DesignerGenerated]
public class Explorer1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	[AccessedThroughProperty("ToolStripContainer")]
	private ToolStripContainer _ToolStripContainer;

	[AccessedThroughProperty("TreeNodeImageList")]
	private ImageList _TreeNodeImageList;

	[AccessedThroughProperty("ToolStripSeparator7")]
	private ToolStripSeparator _ToolStripSeparator7;

	[AccessedThroughProperty("ToolStripSeparator8")]
	private ToolStripSeparator _ToolStripSeparator8;

	[AccessedThroughProperty("ToolStrip")]
	private ToolStrip _ToolStrip;

	[AccessedThroughProperty("BackToolStripButton")]
	private ToolStripButton _BackToolStripButton;

	[AccessedThroughProperty("ForwardToolStripButton")]
	private ToolStripButton _ForwardToolStripButton;

	[AccessedThroughProperty("FoldersToolStripButton")]
	private ToolStripButton _FoldersToolStripButton;

	[AccessedThroughProperty("ListViewToolStripButton")]
	private ToolStripDropDownButton _ListViewToolStripButton;

	[AccessedThroughProperty("ListToolStripMenuItem")]
	private ToolStripMenuItem _ListToolStripMenuItem;

	[AccessedThroughProperty("DetailsToolStripMenuItem")]
	private ToolStripMenuItem _DetailsToolStripMenuItem;

	[AccessedThroughProperty("LargeIconsToolStripMenuItem")]
	private ToolStripMenuItem _LargeIconsToolStripMenuItem;

	[AccessedThroughProperty("SmallIconsToolStripMenuItem")]
	private ToolStripMenuItem _SmallIconsToolStripMenuItem;

	[AccessedThroughProperty("TileToolStripMenuItem")]
	private ToolStripMenuItem _TileToolStripMenuItem;

	[AccessedThroughProperty("MenuStrip")]
	private MenuStrip _MenuStrip;

	[AccessedThroughProperty("FileToolStripMenuItem")]
	private ToolStripMenuItem _FileToolStripMenuItem;

	[AccessedThroughProperty("NewToolStripMenuItem")]
	private ToolStripMenuItem _NewToolStripMenuItem;

	[AccessedThroughProperty("OpenToolStripMenuItem")]
	private ToolStripMenuItem _OpenToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator1")]
	private ToolStripSeparator _ToolStripSeparator1;

	[AccessedThroughProperty("SaveToolStripMenuItem")]
	private ToolStripMenuItem _SaveToolStripMenuItem;

	[AccessedThroughProperty("SaveAsToolStripMenuItem")]
	private ToolStripMenuItem _SaveAsToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator2")]
	private ToolStripSeparator _ToolStripSeparator2;

	[AccessedThroughProperty("PrintToolStripMenuItem")]
	private ToolStripMenuItem _PrintToolStripMenuItem;

	[AccessedThroughProperty("PrintPreviewToolStripMenuItem")]
	private ToolStripMenuItem _PrintPreviewToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator3")]
	private ToolStripSeparator _ToolStripSeparator3;

	[AccessedThroughProperty("ExitToolStripMenuItem")]
	private ToolStripMenuItem _ExitToolStripMenuItem;

	[AccessedThroughProperty("EditToolStripMenuItem")]
	private ToolStripMenuItem _EditToolStripMenuItem;

	[AccessedThroughProperty("UndoToolStripMenuItem")]
	private ToolStripMenuItem _UndoToolStripMenuItem;

	[AccessedThroughProperty("RedoToolStripMenuItem")]
	private ToolStripMenuItem _RedoToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator4")]
	private ToolStripSeparator _ToolStripSeparator4;

	[AccessedThroughProperty("CutToolStripMenuItem")]
	private ToolStripMenuItem _CutToolStripMenuItem;

	[AccessedThroughProperty("CopyToolStripMenuItem")]
	private ToolStripMenuItem _CopyToolStripMenuItem;

	[AccessedThroughProperty("PasteToolStripMenuItem")]
	private ToolStripMenuItem _PasteToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator5")]
	private ToolStripSeparator _ToolStripSeparator5;

	[AccessedThroughProperty("SelectAllToolStripMenuItem")]
	private ToolStripMenuItem _SelectAllToolStripMenuItem;

	[AccessedThroughProperty("ViewToolStripMenuItem")]
	private ToolStripMenuItem _ViewToolStripMenuItem;

	[AccessedThroughProperty("ToolBarToolStripMenuItem")]
	private ToolStripMenuItem _ToolBarToolStripMenuItem;

	[AccessedThroughProperty("StatusBarToolStripMenuItem")]
	private ToolStripMenuItem _StatusBarToolStripMenuItem;

	[AccessedThroughProperty("FoldersToolStripMenuItem")]
	private ToolStripMenuItem _FoldersToolStripMenuItem;

	[AccessedThroughProperty("ToolsToolStripMenuItem")]
	private ToolStripMenuItem _ToolsToolStripMenuItem;

	[AccessedThroughProperty("OptionsToolStripMenuItem")]
	private ToolStripMenuItem _OptionsToolStripMenuItem;

	[AccessedThroughProperty("HelpToolStripMenuItem")]
	private ToolStripMenuItem _HelpToolStripMenuItem;

	[AccessedThroughProperty("ContentsToolStripMenuItem")]
	private ToolStripMenuItem _ContentsToolStripMenuItem;

	[AccessedThroughProperty("IndexToolStripMenuItem")]
	private ToolStripMenuItem _IndexToolStripMenuItem;

	[AccessedThroughProperty("SearchToolStripMenuItem")]
	private ToolStripMenuItem _SearchToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator6")]
	private ToolStripSeparator _ToolStripSeparator6;

	[AccessedThroughProperty("AboutToolStripMenuItem")]
	private ToolStripMenuItem _AboutToolStripMenuItem;

	[AccessedThroughProperty("SplitContainer")]
	private SplitContainer _SplitContainer;

	[AccessedThroughProperty("TreeView")]
	private TreeView _TreeView;

	[AccessedThroughProperty("ListView")]
	private ListView _ListView;

	[AccessedThroughProperty("StatusStrip")]
	private StatusStrip _StatusStrip;

	[AccessedThroughProperty("ToolStripStatusLabel")]
	private ToolStripStatusLabel _ToolStripStatusLabel;

	[AccessedThroughProperty("ToolTip")]
	private ToolTip _ToolTip;

	[AccessedThroughProperty("ListViewLargeImageList")]
	private ImageList _ListViewLargeImageList;

	[AccessedThroughProperty("ListViewSmallImageList")]
	private ImageList _ListViewSmallImageList;

	private IContainer components;

	internal virtual ToolStripContainer ToolStripContainer
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripContainer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripContainer = value;
		}
	}

	internal virtual ImageList TreeNodeImageList
	{
		[DebuggerNonUserCode]
		get
		{
			return _TreeNodeImageList;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TreeNodeImageList = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator7
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator7 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator8
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator8 = value;
		}
	}

	internal virtual ToolStrip ToolStrip
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStrip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStrip = value;
		}
	}

	internal virtual ToolStripButton BackToolStripButton
	{
		[DebuggerNonUserCode]
		get
		{
			return _BackToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BackToolStripButton = value;
		}
	}

	internal virtual ToolStripButton ForwardToolStripButton
	{
		[DebuggerNonUserCode]
		get
		{
			return _ForwardToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ForwardToolStripButton = value;
		}
	}

	internal virtual ToolStripButton FoldersToolStripButton
	{
		[DebuggerNonUserCode]
		get
		{
			return _FoldersToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = FoldersToolStripButton_Click;
			bool flag;
			if (flag = _FoldersToolStripButton != null)
			{
				((ToolStripItem)_FoldersToolStripButton).remove_Click(eventHandler);
			}
			_FoldersToolStripButton = value;
			if (flag = _FoldersToolStripButton != null)
			{
				((ToolStripItem)_FoldersToolStripButton).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripDropDownButton ListViewToolStripButton
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListViewToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListViewToolStripButton = value;
		}
	}

	internal virtual ToolStripMenuItem ListToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ListToolStripMenuItem_Click;
			bool flag;
			if (flag = _ListToolStripMenuItem != null)
			{
				((ToolStripItem)_ListToolStripMenuItem).remove_Click(eventHandler);
			}
			_ListToolStripMenuItem = value;
			if (flag = _ListToolStripMenuItem != null)
			{
				((ToolStripItem)_ListToolStripMenuItem).add_Click(eventHandler);
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
			bool flag;
			if (flag = _DetailsToolStripMenuItem != null)
			{
				((ToolStripItem)_DetailsToolStripMenuItem).remove_Click(eventHandler);
			}
			_DetailsToolStripMenuItem = value;
			if (flag = _DetailsToolStripMenuItem != null)
			{
				((ToolStripItem)_DetailsToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem LargeIconsToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _LargeIconsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = LargeIconsToolStripMenuItem_Click;
			bool flag;
			if (flag = _LargeIconsToolStripMenuItem != null)
			{
				((ToolStripItem)_LargeIconsToolStripMenuItem).remove_Click(eventHandler);
			}
			_LargeIconsToolStripMenuItem = value;
			if (flag = _LargeIconsToolStripMenuItem != null)
			{
				((ToolStripItem)_LargeIconsToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem SmallIconsToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _SmallIconsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = SmallIconsToolStripMenuItem_Click;
			bool flag;
			if (flag = _SmallIconsToolStripMenuItem != null)
			{
				((ToolStripItem)_SmallIconsToolStripMenuItem).remove_Click(eventHandler);
			}
			_SmallIconsToolStripMenuItem = value;
			if (flag = _SmallIconsToolStripMenuItem != null)
			{
				((ToolStripItem)_SmallIconsToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem TileToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _TileToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TileToolStripMenuItem_Click;
			bool flag;
			if (flag = _TileToolStripMenuItem != null)
			{
				((ToolStripItem)_TileToolStripMenuItem).remove_Click(eventHandler);
			}
			_TileToolStripMenuItem = value;
			if (flag = _TileToolStripMenuItem != null)
			{
				((ToolStripItem)_TileToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual MenuStrip MenuStrip
	{
		[DebuggerNonUserCode]
		get
		{
			return _MenuStrip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MenuStrip = value;
		}
	}

	internal virtual ToolStripMenuItem FileToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _FileToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FileToolStripMenuItem = value;
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

	internal virtual ToolStripMenuItem OpenToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _OpenToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = OpenToolStripMenuItem_Click;
			bool flag;
			if (flag = _OpenToolStripMenuItem != null)
			{
				((ToolStripItem)_OpenToolStripMenuItem).remove_Click(eventHandler);
			}
			_OpenToolStripMenuItem = value;
			if (flag = _OpenToolStripMenuItem != null)
			{
				((ToolStripItem)_OpenToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator1 = value;
		}
	}

	internal virtual ToolStripMenuItem SaveToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _SaveToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SaveToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem SaveAsToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _SaveAsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = SaveAsToolStripMenuItem_Click;
			bool flag;
			if (flag = _SaveAsToolStripMenuItem != null)
			{
				((ToolStripItem)_SaveAsToolStripMenuItem).remove_Click(eventHandler);
			}
			_SaveAsToolStripMenuItem = value;
			if (flag = _SaveAsToolStripMenuItem != null)
			{
				((ToolStripItem)_SaveAsToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator2 = value;
		}
	}

	internal virtual ToolStripMenuItem PrintToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem PrintPreviewToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator3 = value;
		}
	}

	internal virtual ToolStripMenuItem ExitToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ExitToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ExitToolStripMenuItem_Click;
			bool flag;
			if (flag = _ExitToolStripMenuItem != null)
			{
				((ToolStripItem)_ExitToolStripMenuItem).remove_Click(eventHandler);
			}
			_ExitToolStripMenuItem = value;
			if (flag = _ExitToolStripMenuItem != null)
			{
				((ToolStripItem)_ExitToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem EditToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _EditToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_EditToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem UndoToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _UndoToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UndoToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem RedoToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _RedoToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RedoToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator4
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator4 = value;
		}
	}

	internal virtual ToolStripMenuItem CutToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _CutToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CutToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem CopyToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _CopyToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CopyToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem PasteToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _PasteToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PasteToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator5
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator5 = value;
		}
	}

	internal virtual ToolStripMenuItem SelectAllToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _SelectAllToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SelectAllToolStripMenuItem = value;
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

	internal virtual ToolStripMenuItem ToolBarToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolBarToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ToolBarToolStripMenuItem_Click;
			bool flag;
			if (flag = _ToolBarToolStripMenuItem != null)
			{
				((ToolStripItem)_ToolBarToolStripMenuItem).remove_Click(eventHandler);
			}
			_ToolBarToolStripMenuItem = value;
			if (flag = _ToolBarToolStripMenuItem != null)
			{
				((ToolStripItem)_ToolBarToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem StatusBarToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusBarToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = StatusBarToolStripMenuItem_Click;
			bool flag;
			if (flag = _StatusBarToolStripMenuItem != null)
			{
				((ToolStripItem)_StatusBarToolStripMenuItem).remove_Click(eventHandler);
			}
			_StatusBarToolStripMenuItem = value;
			if (flag = _StatusBarToolStripMenuItem != null)
			{
				((ToolStripItem)_StatusBarToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem FoldersToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _FoldersToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = FoldersToolStripMenuItem_Click;
			bool flag;
			if (flag = _FoldersToolStripMenuItem != null)
			{
				((ToolStripItem)_FoldersToolStripMenuItem).remove_Click(eventHandler);
			}
			_FoldersToolStripMenuItem = value;
			if (flag = _FoldersToolStripMenuItem != null)
			{
				((ToolStripItem)_FoldersToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ToolsToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolsToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem OptionsToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _OptionsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_OptionsToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem HelpToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _HelpToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_HelpToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem ContentsToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ContentsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ContentsToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem IndexToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _IndexToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_IndexToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem SearchToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _SearchToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SearchToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator6
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator6 = value;
		}
	}

	internal virtual ToolStripMenuItem AboutToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _AboutToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_AboutToolStripMenuItem = value;
		}
	}

	internal virtual SplitContainer SplitContainer
	{
		[DebuggerNonUserCode]
		get
		{
			return _SplitContainer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SplitContainer = value;
		}
	}

	internal virtual TreeView TreeView
	{
		[DebuggerNonUserCode]
		get
		{
			return _TreeView;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			TreeViewEventHandler val = new TreeViewEventHandler(TreeView_AfterSelect);
			bool flag;
			if (flag = _TreeView != null)
			{
				_TreeView.remove_AfterSelect(val);
			}
			_TreeView = value;
			if (flag = _TreeView != null)
			{
				_TreeView.add_AfterSelect(val);
			}
		}
	}

	internal virtual ListView ListView
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListView;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListView = value;
		}
	}

	internal virtual StatusStrip StatusStrip
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusStrip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_StatusStrip = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabel = value;
		}
	}

	internal virtual ToolTip ToolTip
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolTip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolTip = value;
		}
	}

	internal virtual ImageList ListViewLargeImageList
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListViewLargeImageList;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListViewLargeImageList = value;
		}
	}

	internal virtual ImageList ListViewSmallImageList
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListViewSmallImageList;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListViewSmallImageList = value;
		}
	}

	[DebuggerNonUserCode]
	public Explorer1()
	{
		((Form)this).add_Load((EventHandler)Explorer1_Load);
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
				bool flag;
				if (flag = __ENCList.Count == __ENCList.Capacity)
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
						if (flag = weakReference.IsAlive)
						{
							bool flag2;
							if (flag2 = num3 != num)
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
			bool flag;
			if (flag = ((disposing && components != null) ? true : false))
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
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
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected O, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected O, but got Unknown
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Expected O, but got Unknown
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Expected O, but got Unknown
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Expected O, but got Unknown
		//IL_0731: Unknown result type (might be due to invalid IL or missing references)
		//IL_073b: Expected O, but got Unknown
		//IL_0a2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a36: Expected O, but got Unknown
		//IL_0aa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aac: Expected O, but got Unknown
		//IL_0b42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4c: Expected O, but got Unknown
		//IL_0c1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c27: Expected O, but got Unknown
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9d: Expected O, but got Unknown
		//IL_0df6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e00: Expected O, but got Unknown
		//IL_0e6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e76: Expected O, but got Unknown
		//IL_0f0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f16: Expected O, but got Unknown
		//IL_0f82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8c: Expected O, but got Unknown
		//IL_0ff8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1002: Expected O, but got Unknown
		//IL_1397: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a1: Expected O, but got Unknown
		//IL_13fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1407: Expected O, but got Unknown
		//IL_178c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1796: Expected O, but got Unknown
		//IL_17f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1803: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Explorer1));
		StatusStrip = new StatusStrip();
		ToolStripStatusLabel = new ToolStripStatusLabel();
		TreeNodeImageList = new ImageList(components);
		ToolStrip = new ToolStrip();
		BackToolStripButton = new ToolStripButton();
		ForwardToolStripButton = new ToolStripButton();
		ToolStripSeparator7 = new ToolStripSeparator();
		FoldersToolStripButton = new ToolStripButton();
		ToolStripSeparator8 = new ToolStripSeparator();
		ListViewToolStripButton = new ToolStripDropDownButton();
		ListToolStripMenuItem = new ToolStripMenuItem();
		DetailsToolStripMenuItem = new ToolStripMenuItem();
		LargeIconsToolStripMenuItem = new ToolStripMenuItem();
		SmallIconsToolStripMenuItem = new ToolStripMenuItem();
		TileToolStripMenuItem = new ToolStripMenuItem();
		MenuStrip = new MenuStrip();
		FileToolStripMenuItem = new ToolStripMenuItem();
		NewToolStripMenuItem = new ToolStripMenuItem();
		OpenToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator1 = new ToolStripSeparator();
		SaveToolStripMenuItem = new ToolStripMenuItem();
		SaveAsToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator2 = new ToolStripSeparator();
		PrintToolStripMenuItem = new ToolStripMenuItem();
		PrintPreviewToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator3 = new ToolStripSeparator();
		ExitToolStripMenuItem = new ToolStripMenuItem();
		EditToolStripMenuItem = new ToolStripMenuItem();
		UndoToolStripMenuItem = new ToolStripMenuItem();
		RedoToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator4 = new ToolStripSeparator();
		CutToolStripMenuItem = new ToolStripMenuItem();
		CopyToolStripMenuItem = new ToolStripMenuItem();
		PasteToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator5 = new ToolStripSeparator();
		SelectAllToolStripMenuItem = new ToolStripMenuItem();
		ViewToolStripMenuItem = new ToolStripMenuItem();
		ToolBarToolStripMenuItem = new ToolStripMenuItem();
		StatusBarToolStripMenuItem = new ToolStripMenuItem();
		FoldersToolStripMenuItem = new ToolStripMenuItem();
		ToolsToolStripMenuItem = new ToolStripMenuItem();
		OptionsToolStripMenuItem = new ToolStripMenuItem();
		HelpToolStripMenuItem = new ToolStripMenuItem();
		ContentsToolStripMenuItem = new ToolStripMenuItem();
		IndexToolStripMenuItem = new ToolStripMenuItem();
		SearchToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator6 = new ToolStripSeparator();
		AboutToolStripMenuItem = new ToolStripMenuItem();
		ToolTip = new ToolTip(components);
		ToolStripContainer = new ToolStripContainer();
		SplitContainer = new SplitContainer();
		TreeView = new TreeView();
		ListView = new ListView();
		ListViewLargeImageList = new ImageList(components);
		ListViewSmallImageList = new ImageList(components);
		((Control)StatusStrip).SuspendLayout();
		((Control)ToolStrip).SuspendLayout();
		((Control)MenuStrip).SuspendLayout();
		((Control)ToolStripContainer.get_BottomToolStripPanel()).SuspendLayout();
		((Control)ToolStripContainer.get_ContentPanel()).SuspendLayout();
		((Control)ToolStripContainer.get_TopToolStripPanel()).SuspendLayout();
		((Control)ToolStripContainer).SuspendLayout();
		((Control)SplitContainer.get_Panel1()).SuspendLayout();
		((Control)SplitContainer.get_Panel2()).SuspendLayout();
		((Control)SplitContainer).SuspendLayout();
		((Control)this).SuspendLayout();
		StatusStrip.set_Dock((DockStyle)0);
		((ToolStrip)StatusStrip).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel });
		StatusStrip statusStrip = StatusStrip;
		Point location = new Point(0, 0);
		((Control)statusStrip).set_Location(location);
		((Control)StatusStrip).set_Name("StatusStrip");
		StatusStrip statusStrip2 = StatusStrip;
		Size size = new Size(632, 22);
		((Control)statusStrip2).set_Size(size);
		((Control)StatusStrip).set_TabIndex(6);
		((Control)StatusStrip).set_Text("StatusStrip");
		((ToolStripItem)ToolStripStatusLabel).set_Name("ToolStripStatusLabel");
		ToolStripStatusLabel toolStripStatusLabel = ToolStripStatusLabel;
		size = new Size(38, 17);
		((ToolStripItem)toolStripStatusLabel).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel).set_Text("Status");
		TreeNodeImageList.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("TreeNodeImageList.ImageStream"));
		TreeNodeImageList.set_TransparentColor(Color.Transparent);
		TreeNodeImageList.get_Images().SetKeyName(0, "ClosedFolder");
		TreeNodeImageList.get_Images().SetKeyName(1, "OpenFolder");
		ToolStrip.set_Anchor((AnchorStyles)8);
		ToolStrip.set_Dock((DockStyle)0);
		ToolStrip.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)BackToolStripButton,
			(ToolStripItem)ForwardToolStripButton,
			(ToolStripItem)ToolStripSeparator7,
			(ToolStripItem)FoldersToolStripButton,
			(ToolStripItem)ToolStripSeparator8,
			(ToolStripItem)ListViewToolStripButton
		});
		ToolStrip toolStrip = ToolStrip;
		location = new Point(3, 24);
		((Control)toolStrip).set_Location(location);
		((Control)ToolStrip).set_Name("ToolStrip");
		ToolStrip toolStrip2 = ToolStrip;
		size = new Size(231, 25);
		((Control)toolStrip2).set_Size(size);
		((Control)ToolStrip).set_TabIndex(0);
		((Control)ToolStrip).set_Text("ToolStrip1");
		((ToolStripItem)BackToolStripButton).set_Enabled(false);
		((ToolStripItem)BackToolStripButton).set_Image((Image)componentResourceManager.GetObject("BackToolStripButton.Image"));
		((ToolStripItem)BackToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)BackToolStripButton).set_Name("BackToolStripButton");
		ToolStripButton backToolStripButton = BackToolStripButton;
		size = new Size(49, 22);
		((ToolStripItem)backToolStripButton).set_Size(size);
		((ToolStripItem)BackToolStripButton).set_Text("Back");
		((ToolStripItem)BackToolStripButton).set_ToolTipText("Back to the previous item");
		((ToolStripItem)ForwardToolStripButton).set_Enabled(false);
		((ToolStripItem)ForwardToolStripButton).set_Image((Image)componentResourceManager.GetObject("ForwardToolStripButton.Image"));
		((ToolStripItem)ForwardToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ForwardToolStripButton).set_Name("ForwardToolStripButton");
		ToolStripButton forwardToolStripButton = ForwardToolStripButton;
		size = new Size(67, 22);
		((ToolStripItem)forwardToolStripButton).set_Size(size);
		((ToolStripItem)ForwardToolStripButton).set_Text("Forward");
		((ToolStripItem)ForwardToolStripButton).set_ToolTipText("Move forward to the next item");
		((ToolStripItem)ToolStripSeparator7).set_Name("ToolStripSeparator7");
		ToolStripSeparator toolStripSeparator = ToolStripSeparator7;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator).set_Size(size);
		FoldersToolStripButton.set_Checked(true);
		FoldersToolStripButton.set_CheckState((CheckState)1);
		((ToolStripItem)FoldersToolStripButton).set_Image((Image)componentResourceManager.GetObject("FoldersToolStripButton.Image"));
		((ToolStripItem)FoldersToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)FoldersToolStripButton).set_Name("FoldersToolStripButton");
		ToolStripButton foldersToolStripButton = FoldersToolStripButton;
		size = new Size(62, 22);
		((ToolStripItem)foldersToolStripButton).set_Size(size);
		((ToolStripItem)FoldersToolStripButton).set_Text("Folders");
		((ToolStripItem)FoldersToolStripButton).set_ToolTipText("Toggle Folders View");
		((ToolStripItem)ToolStripSeparator8).set_Name("ToolStripSeparator8");
		ToolStripSeparator toolStripSeparator2 = ToolStripSeparator8;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator2).set_Size(size);
		((ToolStripItem)ListViewToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripDropDownItem)ListViewToolStripButton).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)ListToolStripMenuItem,
			(ToolStripItem)DetailsToolStripMenuItem,
			(ToolStripItem)LargeIconsToolStripMenuItem,
			(ToolStripItem)SmallIconsToolStripMenuItem,
			(ToolStripItem)TileToolStripMenuItem
		});
		((ToolStripItem)ListViewToolStripButton).set_Image((Image)componentResourceManager.GetObject("ListViewToolStripButton.Image"));
		((ToolStripItem)ListViewToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ListViewToolStripButton).set_Name("ListViewToolStripButton");
		ToolStripDropDownButton listViewToolStripButton = ListViewToolStripButton;
		size = new Size(29, 22);
		((ToolStripItem)listViewToolStripButton).set_Size(size);
		((ToolStripItem)ListViewToolStripButton).set_Text("Views");
		((ToolStripItem)ListToolStripMenuItem).set_Name("ListToolStripMenuItem");
		ToolStripMenuItem listToolStripMenuItem = ListToolStripMenuItem;
		size = new Size(130, 22);
		((ToolStripItem)listToolStripMenuItem).set_Size(size);
		((ToolStripItem)ListToolStripMenuItem).set_Text("List");
		DetailsToolStripMenuItem.set_Checked(true);
		DetailsToolStripMenuItem.set_CheckState((CheckState)1);
		((ToolStripItem)DetailsToolStripMenuItem).set_Name("DetailsToolStripMenuItem");
		ToolStripMenuItem detailsToolStripMenuItem = DetailsToolStripMenuItem;
		size = new Size(130, 22);
		((ToolStripItem)detailsToolStripMenuItem).set_Size(size);
		((ToolStripItem)DetailsToolStripMenuItem).set_Text("Details");
		((ToolStripItem)LargeIconsToolStripMenuItem).set_Name("LargeIconsToolStripMenuItem");
		ToolStripMenuItem largeIconsToolStripMenuItem = LargeIconsToolStripMenuItem;
		size = new Size(130, 22);
		((ToolStripItem)largeIconsToolStripMenuItem).set_Size(size);
		((ToolStripItem)LargeIconsToolStripMenuItem).set_Text("Large Icons");
		((ToolStripItem)SmallIconsToolStripMenuItem).set_Name("SmallIconsToolStripMenuItem");
		ToolStripMenuItem smallIconsToolStripMenuItem = SmallIconsToolStripMenuItem;
		size = new Size(130, 22);
		((ToolStripItem)smallIconsToolStripMenuItem).set_Size(size);
		((ToolStripItem)SmallIconsToolStripMenuItem).set_Text("Small Icons");
		((ToolStripItem)TileToolStripMenuItem).set_Name("TileToolStripMenuItem");
		ToolStripMenuItem tileToolStripMenuItem = TileToolStripMenuItem;
		size = new Size(130, 22);
		((ToolStripItem)tileToolStripMenuItem).set_Size(size);
		((ToolStripItem)TileToolStripMenuItem).set_Text("Tile");
		((ToolStrip)MenuStrip).set_Dock((DockStyle)0);
		((ToolStrip)MenuStrip).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)FileToolStripMenuItem,
			(ToolStripItem)EditToolStripMenuItem,
			(ToolStripItem)ViewToolStripMenuItem,
			(ToolStripItem)ToolsToolStripMenuItem,
			(ToolStripItem)HelpToolStripMenuItem
		});
		MenuStrip menuStrip = MenuStrip;
		location = new Point(0, 0);
		((Control)menuStrip).set_Location(location);
		((Control)MenuStrip).set_Name("MenuStrip");
		MenuStrip menuStrip2 = MenuStrip;
		size = new Size(632, 24);
		((Control)menuStrip2).set_Size(size);
		((Control)MenuStrip).set_TabIndex(0);
		((Control)MenuStrip).set_Text("MenuStrip1");
		((ToolStripDropDownItem)FileToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[10]
		{
			(ToolStripItem)NewToolStripMenuItem,
			(ToolStripItem)OpenToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator1,
			(ToolStripItem)SaveToolStripMenuItem,
			(ToolStripItem)SaveAsToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator2,
			(ToolStripItem)PrintToolStripMenuItem,
			(ToolStripItem)PrintPreviewToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator3,
			(ToolStripItem)ExitToolStripMenuItem
		});
		((ToolStripItem)FileToolStripMenuItem).set_Name("FileToolStripMenuItem");
		ToolStripMenuItem fileToolStripMenuItem = FileToolStripMenuItem;
		size = new Size(35, 20);
		((ToolStripItem)fileToolStripMenuItem).set_Size(size);
		((ToolStripItem)FileToolStripMenuItem).set_Text("&File");
		((ToolStripItem)NewToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("NewToolStripMenuItem.Image"));
		((ToolStripItem)NewToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)NewToolStripMenuItem).set_Name("NewToolStripMenuItem");
		NewToolStripMenuItem.set_ShortcutKeys((Keys)131150);
		ToolStripMenuItem newToolStripMenuItem = NewToolStripMenuItem;
		size = new Size(140, 22);
		((ToolStripItem)newToolStripMenuItem).set_Size(size);
		((ToolStripItem)NewToolStripMenuItem).set_Text("&New");
		((ToolStripItem)OpenToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("OpenToolStripMenuItem.Image"));
		((ToolStripItem)OpenToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)OpenToolStripMenuItem).set_Name("OpenToolStripMenuItem");
		OpenToolStripMenuItem.set_ShortcutKeys((Keys)131151);
		ToolStripMenuItem openToolStripMenuItem = OpenToolStripMenuItem;
		size = new Size(140, 22);
		((ToolStripItem)openToolStripMenuItem).set_Size(size);
		((ToolStripItem)OpenToolStripMenuItem).set_Text("&Open");
		((ToolStripItem)ToolStripSeparator1).set_Name("ToolStripSeparator1");
		ToolStripSeparator toolStripSeparator3 = ToolStripSeparator1;
		size = new Size(137, 6);
		((ToolStripItem)toolStripSeparator3).set_Size(size);
		((ToolStripItem)SaveToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("SaveToolStripMenuItem.Image"));
		((ToolStripItem)SaveToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)SaveToolStripMenuItem).set_Name("SaveToolStripMenuItem");
		SaveToolStripMenuItem.set_ShortcutKeys((Keys)131155);
		ToolStripMenuItem saveToolStripMenuItem = SaveToolStripMenuItem;
		size = new Size(140, 22);
		((ToolStripItem)saveToolStripMenuItem).set_Size(size);
		((ToolStripItem)SaveToolStripMenuItem).set_Text("&Save");
		((ToolStripItem)SaveAsToolStripMenuItem).set_Name("SaveAsToolStripMenuItem");
		ToolStripMenuItem saveAsToolStripMenuItem = SaveAsToolStripMenuItem;
		size = new Size(140, 22);
		((ToolStripItem)saveAsToolStripMenuItem).set_Size(size);
		((ToolStripItem)SaveAsToolStripMenuItem).set_Text("Save &As");
		((ToolStripItem)ToolStripSeparator2).set_Name("ToolStripSeparator2");
		ToolStripSeparator toolStripSeparator4 = ToolStripSeparator2;
		size = new Size(137, 6);
		((ToolStripItem)toolStripSeparator4).set_Size(size);
		((ToolStripItem)PrintToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("PrintToolStripMenuItem.Image"));
		((ToolStripItem)PrintToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)PrintToolStripMenuItem).set_Name("PrintToolStripMenuItem");
		PrintToolStripMenuItem.set_ShortcutKeys((Keys)131152);
		ToolStripMenuItem printToolStripMenuItem = PrintToolStripMenuItem;
		size = new Size(140, 22);
		((ToolStripItem)printToolStripMenuItem).set_Size(size);
		((ToolStripItem)PrintToolStripMenuItem).set_Text("&Print");
		((ToolStripItem)PrintPreviewToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("PrintPreviewToolStripMenuItem.Image"));
		((ToolStripItem)PrintPreviewToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)PrintPreviewToolStripMenuItem).set_Name("PrintPreviewToolStripMenuItem");
		ToolStripMenuItem printPreviewToolStripMenuItem = PrintPreviewToolStripMenuItem;
		size = new Size(140, 22);
		((ToolStripItem)printPreviewToolStripMenuItem).set_Size(size);
		((ToolStripItem)PrintPreviewToolStripMenuItem).set_Text("Print Pre&view");
		((ToolStripItem)ToolStripSeparator3).set_Name("ToolStripSeparator3");
		ToolStripSeparator toolStripSeparator5 = ToolStripSeparator3;
		size = new Size(137, 6);
		((ToolStripItem)toolStripSeparator5).set_Size(size);
		((ToolStripItem)ExitToolStripMenuItem).set_Name("ExitToolStripMenuItem");
		ToolStripMenuItem exitToolStripMenuItem = ExitToolStripMenuItem;
		size = new Size(140, 22);
		((ToolStripItem)exitToolStripMenuItem).set_Size(size);
		((ToolStripItem)ExitToolStripMenuItem).set_Text("E&xit");
		((ToolStripDropDownItem)EditToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)UndoToolStripMenuItem,
			(ToolStripItem)RedoToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator4,
			(ToolStripItem)CutToolStripMenuItem,
			(ToolStripItem)CopyToolStripMenuItem,
			(ToolStripItem)PasteToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator5,
			(ToolStripItem)SelectAllToolStripMenuItem
		});
		((ToolStripItem)EditToolStripMenuItem).set_Name("EditToolStripMenuItem");
		ToolStripMenuItem editToolStripMenuItem = EditToolStripMenuItem;
		size = new Size(37, 20);
		((ToolStripItem)editToolStripMenuItem).set_Size(size);
		((ToolStripItem)EditToolStripMenuItem).set_Text("&Edit");
		((ToolStripItem)UndoToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("UndoToolStripMenuItem.Image"));
		((ToolStripItem)UndoToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)UndoToolStripMenuItem).set_Name("UndoToolStripMenuItem");
		UndoToolStripMenuItem.set_ShortcutKeys((Keys)131162);
		ToolStripMenuItem undoToolStripMenuItem = UndoToolStripMenuItem;
		size = new Size(156, 22);
		((ToolStripItem)undoToolStripMenuItem).set_Size(size);
		((ToolStripItem)UndoToolStripMenuItem).set_Text("&Undo");
		((ToolStripItem)RedoToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("RedoToolStripMenuItem.Image"));
		((ToolStripItem)RedoToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)RedoToolStripMenuItem).set_Name("RedoToolStripMenuItem");
		RedoToolStripMenuItem.set_ShortcutKeys((Keys)131161);
		ToolStripMenuItem redoToolStripMenuItem = RedoToolStripMenuItem;
		size = new Size(156, 22);
		((ToolStripItem)redoToolStripMenuItem).set_Size(size);
		((ToolStripItem)RedoToolStripMenuItem).set_Text("&Redo");
		((ToolStripItem)ToolStripSeparator4).set_Name("ToolStripSeparator4");
		ToolStripSeparator toolStripSeparator6 = ToolStripSeparator4;
		size = new Size(153, 6);
		((ToolStripItem)toolStripSeparator6).set_Size(size);
		((ToolStripItem)CutToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("CutToolStripMenuItem.Image"));
		((ToolStripItem)CutToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)CutToolStripMenuItem).set_Name("CutToolStripMenuItem");
		CutToolStripMenuItem.set_ShortcutKeys((Keys)131160);
		ToolStripMenuItem cutToolStripMenuItem = CutToolStripMenuItem;
		size = new Size(156, 22);
		((ToolStripItem)cutToolStripMenuItem).set_Size(size);
		((ToolStripItem)CutToolStripMenuItem).set_Text("Cu&t");
		((ToolStripItem)CopyToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("CopyToolStripMenuItem.Image"));
		((ToolStripItem)CopyToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)CopyToolStripMenuItem).set_Name("CopyToolStripMenuItem");
		CopyToolStripMenuItem.set_ShortcutKeys((Keys)131139);
		ToolStripMenuItem copyToolStripMenuItem = CopyToolStripMenuItem;
		size = new Size(156, 22);
		((ToolStripItem)copyToolStripMenuItem).set_Size(size);
		((ToolStripItem)CopyToolStripMenuItem).set_Text("&Copy");
		((ToolStripItem)PasteToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("PasteToolStripMenuItem.Image"));
		((ToolStripItem)PasteToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)PasteToolStripMenuItem).set_Name("PasteToolStripMenuItem");
		PasteToolStripMenuItem.set_ShortcutKeys((Keys)131158);
		ToolStripMenuItem pasteToolStripMenuItem = PasteToolStripMenuItem;
		size = new Size(156, 22);
		((ToolStripItem)pasteToolStripMenuItem).set_Size(size);
		((ToolStripItem)PasteToolStripMenuItem).set_Text("&Paste");
		((ToolStripItem)ToolStripSeparator5).set_Name("ToolStripSeparator5");
		ToolStripSeparator toolStripSeparator7 = ToolStripSeparator5;
		size = new Size(153, 6);
		((ToolStripItem)toolStripSeparator7).set_Size(size);
		((ToolStripItem)SelectAllToolStripMenuItem).set_Name("SelectAllToolStripMenuItem");
		SelectAllToolStripMenuItem.set_ShortcutKeys((Keys)131137);
		ToolStripMenuItem selectAllToolStripMenuItem = SelectAllToolStripMenuItem;
		size = new Size(156, 22);
		((ToolStripItem)selectAllToolStripMenuItem).set_Size(size);
		((ToolStripItem)SelectAllToolStripMenuItem).set_Text("Select &All");
		((ToolStripDropDownItem)ViewToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)ToolBarToolStripMenuItem,
			(ToolStripItem)StatusBarToolStripMenuItem,
			(ToolStripItem)FoldersToolStripMenuItem
		});
		((ToolStripItem)ViewToolStripMenuItem).set_Name("ViewToolStripMenuItem");
		ToolStripMenuItem viewToolStripMenuItem = ViewToolStripMenuItem;
		size = new Size(41, 20);
		((ToolStripItem)viewToolStripMenuItem).set_Size(size);
		((ToolStripItem)ViewToolStripMenuItem).set_Text("&View");
		ToolBarToolStripMenuItem.set_Checked(true);
		ToolBarToolStripMenuItem.set_CheckState((CheckState)1);
		((ToolStripItem)ToolBarToolStripMenuItem).set_Name("ToolBarToolStripMenuItem");
		ToolStripMenuItem toolBarToolStripMenuItem = ToolBarToolStripMenuItem;
		size = new Size(124, 22);
		((ToolStripItem)toolBarToolStripMenuItem).set_Size(size);
		((ToolStripItem)ToolBarToolStripMenuItem).set_Text("&Toolbar");
		StatusBarToolStripMenuItem.set_Checked(true);
		StatusBarToolStripMenuItem.set_CheckState((CheckState)1);
		((ToolStripItem)StatusBarToolStripMenuItem).set_Name("StatusBarToolStripMenuItem");
		ToolStripMenuItem statusBarToolStripMenuItem = StatusBarToolStripMenuItem;
		size = new Size(124, 22);
		((ToolStripItem)statusBarToolStripMenuItem).set_Size(size);
		((ToolStripItem)StatusBarToolStripMenuItem).set_Text("&Status Bar");
		FoldersToolStripMenuItem.set_Checked(true);
		FoldersToolStripMenuItem.set_CheckState((CheckState)1);
		((ToolStripItem)FoldersToolStripMenuItem).set_Name("FoldersToolStripMenuItem");
		ToolStripMenuItem foldersToolStripMenuItem = FoldersToolStripMenuItem;
		size = new Size(124, 22);
		((ToolStripItem)foldersToolStripMenuItem).set_Size(size);
		((ToolStripItem)FoldersToolStripMenuItem).set_Text("&Folders");
		((ToolStripDropDownItem)ToolsToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)OptionsToolStripMenuItem });
		((ToolStripItem)ToolsToolStripMenuItem).set_Name("ToolsToolStripMenuItem");
		ToolStripMenuItem toolsToolStripMenuItem = ToolsToolStripMenuItem;
		size = new Size(44, 20);
		((ToolStripItem)toolsToolStripMenuItem).set_Size(size);
		((ToolStripItem)ToolsToolStripMenuItem).set_Text("&Tools");
		((ToolStripItem)OptionsToolStripMenuItem).set_Name("OptionsToolStripMenuItem");
		ToolStripMenuItem optionsToolStripMenuItem = OptionsToolStripMenuItem;
		size = new Size(111, 22);
		((ToolStripItem)optionsToolStripMenuItem).set_Size(size);
		((ToolStripItem)OptionsToolStripMenuItem).set_Text("&Options");
		((ToolStripDropDownItem)HelpToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)ContentsToolStripMenuItem,
			(ToolStripItem)IndexToolStripMenuItem,
			(ToolStripItem)SearchToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator6,
			(ToolStripItem)AboutToolStripMenuItem
		});
		((ToolStripItem)HelpToolStripMenuItem).set_Name("HelpToolStripMenuItem");
		ToolStripMenuItem helpToolStripMenuItem = HelpToolStripMenuItem;
		size = new Size(40, 20);
		((ToolStripItem)helpToolStripMenuItem).set_Size(size);
		((ToolStripItem)HelpToolStripMenuItem).set_Text("&Help");
		((ToolStripItem)ContentsToolStripMenuItem).set_Name("ContentsToolStripMenuItem");
		ContentsToolStripMenuItem.set_ShortcutKeys((Keys)131184);
		ToolStripMenuItem contentsToolStripMenuItem = ContentsToolStripMenuItem;
		size = new Size(162, 22);
		((ToolStripItem)contentsToolStripMenuItem).set_Size(size);
		((ToolStripItem)ContentsToolStripMenuItem).set_Text("&Contents");
		((ToolStripItem)IndexToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("IndexToolStripMenuItem.Image"));
		((ToolStripItem)IndexToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)IndexToolStripMenuItem).set_Name("IndexToolStripMenuItem");
		ToolStripMenuItem indexToolStripMenuItem = IndexToolStripMenuItem;
		size = new Size(162, 22);
		((ToolStripItem)indexToolStripMenuItem).set_Size(size);
		((ToolStripItem)IndexToolStripMenuItem).set_Text("&Index");
		((ToolStripItem)SearchToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("SearchToolStripMenuItem.Image"));
		((ToolStripItem)SearchToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)SearchToolStripMenuItem).set_Name("SearchToolStripMenuItem");
		ToolStripMenuItem searchToolStripMenuItem = SearchToolStripMenuItem;
		size = new Size(162, 22);
		((ToolStripItem)searchToolStripMenuItem).set_Size(size);
		((ToolStripItem)SearchToolStripMenuItem).set_Text("&Search");
		((ToolStripItem)ToolStripSeparator6).set_Name("ToolStripSeparator6");
		ToolStripSeparator toolStripSeparator8 = ToolStripSeparator6;
		size = new Size(159, 6);
		((ToolStripItem)toolStripSeparator8).set_Size(size);
		((ToolStripItem)AboutToolStripMenuItem).set_Name("AboutToolStripMenuItem");
		ToolStripMenuItem aboutToolStripMenuItem = AboutToolStripMenuItem;
		size = new Size(162, 22);
		((ToolStripItem)aboutToolStripMenuItem).set_Size(size);
		((ToolStripItem)AboutToolStripMenuItem).set_Text("&About ...");
		((Control)ToolStripContainer.get_BottomToolStripPanel()).get_Controls().Add((Control)(object)StatusStrip);
		((Control)ToolStripContainer.get_ContentPanel()).get_Controls().Add((Control)(object)SplitContainer);
		ToolStripContentPanel contentPanel = ToolStripContainer.get_ContentPanel();
		size = new Size(632, 382);
		((Control)contentPanel).set_Size(size);
		((Control)ToolStripContainer).set_Dock((DockStyle)5);
		ToolStripContainer toolStripContainer = ToolStripContainer;
		location = new Point(0, 0);
		((Control)toolStripContainer).set_Location(location);
		((Control)ToolStripContainer).set_Name("ToolStripContainer");
		ToolStripContainer toolStripContainer2 = ToolStripContainer;
		size = new Size(632, 453);
		((Control)toolStripContainer2).set_Size(size);
		((Control)ToolStripContainer).set_TabIndex(7);
		((Control)ToolStripContainer).set_Text("ToolStripContainer1");
		((Control)ToolStripContainer.get_TopToolStripPanel()).get_Controls().Add((Control)(object)MenuStrip);
		((Control)ToolStripContainer.get_TopToolStripPanel()).get_Controls().Add((Control)(object)ToolStrip);
		SplitContainer.set_Dock((DockStyle)5);
		SplitContainer splitContainer = SplitContainer;
		location = new Point(0, 0);
		((Control)splitContainer).set_Location(location);
		((Control)SplitContainer).set_Name("SplitContainer");
		((Control)SplitContainer.get_Panel1()).get_Controls().Add((Control)(object)TreeView);
		((Control)SplitContainer.get_Panel2()).get_Controls().Add((Control)(object)ListView);
		SplitContainer splitContainer2 = SplitContainer;
		size = new Size(632, 382);
		((Control)splitContainer2).set_Size(size);
		SplitContainer.set_SplitterDistance(211);
		((Control)SplitContainer).set_TabIndex(0);
		SplitContainer.set_Text("SplitContainer1");
		((Control)TreeView).set_Dock((DockStyle)5);
		TreeView.set_ImageIndex(0);
		TreeView.set_ImageList(TreeNodeImageList);
		TreeView treeView = TreeView;
		location = new Point(0, 0);
		((Control)treeView).set_Location(location);
		((Control)TreeView).set_Name("TreeView");
		TreeView.set_SelectedImageIndex(1);
		TreeView.set_ShowLines(false);
		TreeView treeView2 = TreeView;
		size = new Size(211, 382);
		((Control)treeView2).set_Size(size);
		((Control)TreeView).set_TabIndex(0);
		((Control)ListView).set_Dock((DockStyle)5);
		ListView.set_LargeImageList(ListViewLargeImageList);
		ListView listView = ListView;
		location = new Point(0, 0);
		((Control)listView).set_Location(location);
		((Control)ListView).set_Name("ListView");
		ListView listView2 = ListView;
		size = new Size(417, 382);
		((Control)listView2).set_Size(size);
		ListView.set_SmallImageList(ListViewSmallImageList);
		((Control)ListView).set_TabIndex(0);
		ListView.set_UseCompatibleStateImageBehavior(false);
		ListViewLargeImageList.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ListViewLargeImageList.ImageStream"));
		ListViewLargeImageList.set_TransparentColor(Color.Transparent);
		ListViewLargeImageList.get_Images().SetKeyName(0, "Graph1");
		ListViewLargeImageList.get_Images().SetKeyName(1, "Graph2");
		ListViewLargeImageList.get_Images().SetKeyName(2, "Graph3");
		ListViewSmallImageList.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ListViewSmallImageList.ImageStream"));
		ListViewSmallImageList.set_TransparentColor(Color.Transparent);
		ListViewSmallImageList.get_Images().SetKeyName(0, "Graph1");
		ListViewSmallImageList.get_Images().SetKeyName(1, "Graph2");
		ListViewSmallImageList.get_Images().SetKeyName(2, "Graph3");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(632, 453);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ToolStripContainer);
		((Control)this).set_Name("Explorer1");
		((Form)this).set_Text("Explorer1");
		((Control)StatusStrip).ResumeLayout(false);
		((Control)StatusStrip).PerformLayout();
		((Control)ToolStrip).ResumeLayout(false);
		((Control)ToolStrip).PerformLayout();
		((Control)MenuStrip).ResumeLayout(false);
		((Control)MenuStrip).PerformLayout();
		((Control)ToolStripContainer.get_BottomToolStripPanel()).ResumeLayout(false);
		((Control)ToolStripContainer.get_BottomToolStripPanel()).PerformLayout();
		((Control)ToolStripContainer.get_ContentPanel()).ResumeLayout(false);
		((Control)ToolStripContainer.get_TopToolStripPanel()).ResumeLayout(false);
		((Control)ToolStripContainer.get_TopToolStripPanel()).PerformLayout();
		((Control)ToolStripContainer).ResumeLayout(false);
		((Control)ToolStripContainer).PerformLayout();
		((Control)SplitContainer.get_Panel1()).ResumeLayout(false);
		((Control)SplitContainer.get_Panel2()).ResumeLayout(false);
		((Control)SplitContainer).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void Explorer1_Load(object sender, EventArgs e)
	{
		SetUpListViewColumns();
		LoadTree();
	}

	private void LoadTree()
	{
		TreeNode val = TreeView.get_Nodes().Add("Root");
		TreeNode val2 = val.get_Nodes().Add("TreeItem1");
		val2 = val.get_Nodes().Add("TreeItem2");
		val2 = val.get_Nodes().Add("TreeItem3");
	}

	private void LoadListView()
	{
		ListView.get_Items().Clear();
		ListViewItem val = ListView.get_Items().Add("ListViewItem1");
		val.set_ImageKey("Graph1");
		val.get_SubItems().AddRange(new string[2] { "Column2", "Column3" });
		val = ListView.get_Items().Add("ListViewItem2");
		val.set_ImageKey("Graph2");
		val.get_SubItems().AddRange(new string[2] { "Column2", "Column3" });
		val = ListView.get_Items().Add("ListViewItem3");
		val.set_ImageKey("Graph3");
		val.get_SubItems().AddRange(new string[2] { "Column2", "Column3" });
	}

	private void SetUpListViewColumns()
	{
		SetView((View)2);
		ColumnHeader val = ListView.get_Columns().Add("Column1");
		val.set_Width(90);
		SetView((View)1);
		val.set_Width(100);
		val = ListView.get_Columns().Add("Column2");
		val.set_Width(70);
		val = ListView.get_Columns().Add("Column3");
		val.set_Width(70);
	}

	private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
	{
		ToolBarToolStripMenuItem.set_Checked(!ToolBarToolStripMenuItem.get_Checked());
		((Control)ToolStrip).set_Visible(ToolBarToolStripMenuItem.get_Checked());
	}

	private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
	{
		StatusBarToolStripMenuItem.set_Checked(!StatusBarToolStripMenuItem.get_Checked());
		((Control)StatusStrip).set_Visible(StatusBarToolStripMenuItem.get_Checked());
	}

	private void ToggleFoldersVisible()
	{
		FoldersToolStripMenuItem.set_Checked(!FoldersToolStripMenuItem.get_Checked());
		FoldersToolStripButton.set_Checked(FoldersToolStripMenuItem.get_Checked());
		SplitContainer.set_Panel1Collapsed(!FoldersToolStripMenuItem.get_Checked());
	}

	private void FoldersToolStripMenuItem_Click(object sender, EventArgs e)
	{
		ToggleFoldersVisible();
	}

	private void FoldersToolStripButton_Click(object sender, EventArgs e)
	{
		ToggleFoldersVisible();
	}

	private void SetView(View View)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Expected I4, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		ToolStripMenuItem val = null;
		switch ((int)View)
		{
		default:
			Debug.Fail("Unexpected View");
			View = (View)1;
			val = DetailsToolStripMenuItem;
			break;
		case 0:
			val = LargeIconsToolStripMenuItem;
			break;
		case 1:
			val = DetailsToolStripMenuItem;
			break;
		case 2:
			val = SmallIconsToolStripMenuItem;
			break;
		case 3:
			val = ListToolStripMenuItem;
			break;
		case 4:
			val = TileToolStripMenuItem;
			break;
		}
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((ArrangedElementCollection)((ToolStripDropDownItem)ListViewToolStripButton).get_DropDownItems()).GetEnumerator();
			bool flag;
			while (flag = enumerator.MoveNext())
			{
				ToolStripMenuItem val2 = (ToolStripMenuItem)enumerator.Current;
				if (flag = val2 == val)
				{
					val2.set_Checked(true);
				}
				else
				{
					val2.set_Checked(false);
				}
			}
		}
		finally
		{
			bool flag;
			if (flag = enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		ListView.set_View(View);
	}

	private void ListToolStripMenuItem_Click(object sender, EventArgs e)
	{
		SetView((View)3);
	}

	private void DetailsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		SetView((View)1);
	}

	private void LargeIconsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		SetView((View)0);
	}

	private void SmallIconsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		SetView((View)2);
	}

	private void TileToolStripMenuItem_Click(object sender, EventArgs e)
	{
		SetView((View)4);
	}

	private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_InitialDirectory(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments());
		((FileDialog)val).set_Filter("Text Files (*.txt)|*.txt");
		((CommonDialog)val).ShowDialog((IWin32Window)(object)this);
		string fileName = ((FileDialog)val).get_FileName();
	}

	private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).set_InitialDirectory(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments());
		((FileDialog)val).set_Filter("Text Files (*.txt)|*.txt");
		((CommonDialog)val).ShowDialog((IWin32Window)(object)this);
		string fileName = ((FileDialog)val).get_FileName();
	}

	private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
	{
		LoadListView();
	}
}
