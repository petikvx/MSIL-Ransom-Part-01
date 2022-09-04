using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Server.My;

namespace Server;

[DesignerGenerated]
public class MDIParent1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("ContentsToolStripMenuItem")]
	private ToolStripMenuItem _ContentsToolStripMenuItem;

	[AccessedThroughProperty("HelpMenu")]
	private ToolStripMenuItem _HelpMenu;

	[AccessedThroughProperty("IndexToolStripMenuItem")]
	private ToolStripMenuItem _IndexToolStripMenuItem;

	[AccessedThroughProperty("SearchToolStripMenuItem")]
	private ToolStripMenuItem _SearchToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator8")]
	private ToolStripSeparator _ToolStripSeparator8;

	[AccessedThroughProperty("AboutToolStripMenuItem")]
	private ToolStripMenuItem _AboutToolStripMenuItem;

	[AccessedThroughProperty("ArrangeIconsToolStripMenuItem")]
	private ToolStripMenuItem _ArrangeIconsToolStripMenuItem;

	[AccessedThroughProperty("CloseAllToolStripMenuItem")]
	private ToolStripMenuItem _CloseAllToolStripMenuItem;

	[AccessedThroughProperty("NewWindowToolStripMenuItem")]
	private ToolStripMenuItem _NewWindowToolStripMenuItem;

	[AccessedThroughProperty("WindowsMenu")]
	private ToolStripMenuItem _WindowsMenu;

	[AccessedThroughProperty("CascadeToolStripMenuItem")]
	private ToolStripMenuItem _CascadeToolStripMenuItem;

	[AccessedThroughProperty("TileVerticalToolStripMenuItem")]
	private ToolStripMenuItem _TileVerticalToolStripMenuItem;

	[AccessedThroughProperty("TileHorizontalToolStripMenuItem")]
	private ToolStripMenuItem _TileHorizontalToolStripMenuItem;

	[AccessedThroughProperty("OptionsToolStripMenuItem")]
	private ToolStripMenuItem _OptionsToolStripMenuItem;

	[AccessedThroughProperty("HelpToolStripButton")]
	private ToolStripButton _HelpToolStripButton;

	[AccessedThroughProperty("ToolStripSeparator2")]
	private ToolStripSeparator _ToolStripSeparator2;

	[AccessedThroughProperty("PrintPreviewToolStripButton")]
	private ToolStripButton _PrintPreviewToolStripButton;

	[AccessedThroughProperty("ToolTip")]
	private ToolTip _ToolTip;

	[AccessedThroughProperty("ToolStripStatusLabel")]
	private ToolStripStatusLabel _ToolStripStatusLabel;

	[AccessedThroughProperty("StatusStrip")]
	private StatusStrip _StatusStrip;

	[AccessedThroughProperty("PrintToolStripButton")]
	private ToolStripButton _PrintToolStripButton;

	[AccessedThroughProperty("NewToolStripButton")]
	private ToolStripButton _NewToolStripButton;

	[AccessedThroughProperty("ToolStrip")]
	private ToolStrip _ToolStrip;

	[AccessedThroughProperty("OpenToolStripButton")]
	private ToolStripButton _OpenToolStripButton;

	[AccessedThroughProperty("SaveToolStripButton")]
	private ToolStripButton _SaveToolStripButton;

	[AccessedThroughProperty("ToolStripSeparator1")]
	private ToolStripSeparator _ToolStripSeparator1;

	[AccessedThroughProperty("PrintPreviewToolStripMenuItem")]
	private ToolStripMenuItem _PrintPreviewToolStripMenuItem;

	[AccessedThroughProperty("PrintToolStripMenuItem")]
	private ToolStripMenuItem _PrintToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator4")]
	private ToolStripSeparator _ToolStripSeparator4;

	[AccessedThroughProperty("ExitToolStripMenuItem")]
	private ToolStripMenuItem _ExitToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator5")]
	private ToolStripSeparator _ToolStripSeparator5;

	[AccessedThroughProperty("PrintSetupToolStripMenuItem")]
	private ToolStripMenuItem _PrintSetupToolStripMenuItem;

	[AccessedThroughProperty("SaveAsToolStripMenuItem")]
	private ToolStripMenuItem _SaveAsToolStripMenuItem;

	[AccessedThroughProperty("NewToolStripMenuItem")]
	private ToolStripMenuItem _NewToolStripMenuItem;

	[AccessedThroughProperty("FileMenu")]
	private ToolStripMenuItem _FileMenu;

	[AccessedThroughProperty("OpenToolStripMenuItem")]
	private ToolStripMenuItem _OpenToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator3")]
	private ToolStripSeparator _ToolStripSeparator3;

	[AccessedThroughProperty("SaveToolStripMenuItem")]
	private ToolStripMenuItem _SaveToolStripMenuItem;

	[AccessedThroughProperty("MenuStrip")]
	private MenuStrip _MenuStrip;

	[AccessedThroughProperty("EditMenu")]
	private ToolStripMenuItem _EditMenu;

	[AccessedThroughProperty("UndoToolStripMenuItem")]
	private ToolStripMenuItem _UndoToolStripMenuItem;

	[AccessedThroughProperty("RedoToolStripMenuItem")]
	private ToolStripMenuItem _RedoToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator6")]
	private ToolStripSeparator _ToolStripSeparator6;

	[AccessedThroughProperty("CutToolStripMenuItem")]
	private ToolStripMenuItem _CutToolStripMenuItem;

	[AccessedThroughProperty("CopyToolStripMenuItem")]
	private ToolStripMenuItem _CopyToolStripMenuItem;

	[AccessedThroughProperty("PasteToolStripMenuItem")]
	private ToolStripMenuItem _PasteToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator7")]
	private ToolStripSeparator _ToolStripSeparator7;

	[AccessedThroughProperty("SelectAllToolStripMenuItem")]
	private ToolStripMenuItem _SelectAllToolStripMenuItem;

	[AccessedThroughProperty("ViewMenu")]
	private ToolStripMenuItem _ViewMenu;

	[AccessedThroughProperty("ToolBarToolStripMenuItem")]
	private ToolStripMenuItem _ToolBarToolStripMenuItem;

	[AccessedThroughProperty("StatusBarToolStripMenuItem")]
	private ToolStripMenuItem _StatusBarToolStripMenuItem;

	[AccessedThroughProperty("ToolsMenu")]
	private ToolStripMenuItem _ToolsMenu;

	private int m_ChildFormNumber;

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

	internal virtual ToolStripMenuItem HelpMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _HelpMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_HelpMenu = value;
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

	internal virtual ToolStripMenuItem ArrangeIconsToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ArrangeIconsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ArrangeIconsToolStripMenuItem_Click;
			bool flag;
			if (flag = _ArrangeIconsToolStripMenuItem != null)
			{
				((ToolStripItem)_ArrangeIconsToolStripMenuItem).remove_Click(eventHandler);
			}
			_ArrangeIconsToolStripMenuItem = value;
			if (flag = _ArrangeIconsToolStripMenuItem != null)
			{
				((ToolStripItem)_ArrangeIconsToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem CloseAllToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _CloseAllToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CloseAllToolStripMenuItem_Click;
			bool flag;
			if (flag = _CloseAllToolStripMenuItem != null)
			{
				((ToolStripItem)_CloseAllToolStripMenuItem).remove_Click(eventHandler);
			}
			_CloseAllToolStripMenuItem = value;
			if (flag = _CloseAllToolStripMenuItem != null)
			{
				((ToolStripItem)_CloseAllToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem NewWindowToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _NewWindowToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ShowNewForm;
			bool flag;
			if (flag = _NewWindowToolStripMenuItem != null)
			{
				((ToolStripItem)_NewWindowToolStripMenuItem).remove_Click(eventHandler);
			}
			_NewWindowToolStripMenuItem = value;
			if (flag = _NewWindowToolStripMenuItem != null)
			{
				((ToolStripItem)_NewWindowToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem WindowsMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _WindowsMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WindowsMenu = value;
		}
	}

	internal virtual ToolStripMenuItem CascadeToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _CascadeToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CascadeToolStripMenuItem_Click;
			bool flag;
			if (flag = _CascadeToolStripMenuItem != null)
			{
				((ToolStripItem)_CascadeToolStripMenuItem).remove_Click(eventHandler);
			}
			_CascadeToolStripMenuItem = value;
			if (flag = _CascadeToolStripMenuItem != null)
			{
				((ToolStripItem)_CascadeToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem TileVerticalToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _TileVerticalToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TileVerticalToolStripMenuItem_Click;
			bool flag;
			if (flag = _TileVerticalToolStripMenuItem != null)
			{
				((ToolStripItem)_TileVerticalToolStripMenuItem).remove_Click(eventHandler);
			}
			_TileVerticalToolStripMenuItem = value;
			if (flag = _TileVerticalToolStripMenuItem != null)
			{
				((ToolStripItem)_TileVerticalToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem TileHorizontalToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _TileHorizontalToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TileHorizontalToolStripMenuItem_Click;
			bool flag;
			if (flag = _TileHorizontalToolStripMenuItem != null)
			{
				((ToolStripItem)_TileHorizontalToolStripMenuItem).remove_Click(eventHandler);
			}
			_TileHorizontalToolStripMenuItem = value;
			if (flag = _TileHorizontalToolStripMenuItem != null)
			{
				((ToolStripItem)_TileHorizontalToolStripMenuItem).add_Click(eventHandler);
			}
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

	internal virtual ToolStripButton HelpToolStripButton
	{
		[DebuggerNonUserCode]
		get
		{
			return _HelpToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_HelpToolStripButton = value;
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

	internal virtual ToolStripButton PrintPreviewToolStripButton
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewToolStripButton = value;
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

	internal virtual ToolStripButton PrintToolStripButton
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintToolStripButton = value;
		}
	}

	internal virtual ToolStripButton NewToolStripButton
	{
		[DebuggerNonUserCode]
		get
		{
			return _NewToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ShowNewForm;
			bool flag;
			if (flag = _NewToolStripButton != null)
			{
				((ToolStripItem)_NewToolStripButton).remove_Click(eventHandler);
			}
			_NewToolStripButton = value;
			if (flag = _NewToolStripButton != null)
			{
				((ToolStripItem)_NewToolStripButton).add_Click(eventHandler);
			}
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

	internal virtual ToolStripButton OpenToolStripButton
	{
		[DebuggerNonUserCode]
		get
		{
			return _OpenToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = OpenFile;
			bool flag;
			if (flag = _OpenToolStripButton != null)
			{
				((ToolStripItem)_OpenToolStripButton).remove_Click(eventHandler);
			}
			_OpenToolStripButton = value;
			if (flag = _OpenToolStripButton != null)
			{
				((ToolStripItem)_OpenToolStripButton).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripButton SaveToolStripButton
	{
		[DebuggerNonUserCode]
		get
		{
			return _SaveToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SaveToolStripButton = value;
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
			EventHandler eventHandler = ExitToolsStripMenuItem_Click;
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

	internal virtual ToolStripMenuItem PrintSetupToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintSetupToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintSetupToolStripMenuItem = value;
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
			EventHandler eventHandler = ShowNewForm;
			bool flag;
			if (flag = _NewToolStripMenuItem != null)
			{
				((ToolStripItem)_NewToolStripMenuItem).remove_Click(eventHandler);
			}
			_NewToolStripMenuItem = value;
			if (flag = _NewToolStripMenuItem != null)
			{
				((ToolStripItem)_NewToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem FileMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _FileMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FileMenu = value;
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
			EventHandler eventHandler = OpenFile;
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

	internal virtual ToolStripMenuItem EditMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _EditMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_EditMenu = value;
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
			EventHandler eventHandler = CutToolStripMenuItem_Click;
			bool flag;
			if (flag = _CutToolStripMenuItem != null)
			{
				((ToolStripItem)_CutToolStripMenuItem).remove_Click(eventHandler);
			}
			_CutToolStripMenuItem = value;
			if (flag = _CutToolStripMenuItem != null)
			{
				((ToolStripItem)_CutToolStripMenuItem).add_Click(eventHandler);
			}
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
			EventHandler eventHandler = CopyToolStripMenuItem_Click;
			bool flag;
			if (flag = _CopyToolStripMenuItem != null)
			{
				((ToolStripItem)_CopyToolStripMenuItem).remove_Click(eventHandler);
			}
			_CopyToolStripMenuItem = value;
			if (flag = _CopyToolStripMenuItem != null)
			{
				((ToolStripItem)_CopyToolStripMenuItem).add_Click(eventHandler);
			}
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
			EventHandler eventHandler = PasteToolStripMenuItem_Click;
			bool flag;
			if (flag = _PasteToolStripMenuItem != null)
			{
				((ToolStripItem)_PasteToolStripMenuItem).remove_Click(eventHandler);
			}
			_PasteToolStripMenuItem = value;
			if (flag = _PasteToolStripMenuItem != null)
			{
				((ToolStripItem)_PasteToolStripMenuItem).add_Click(eventHandler);
			}
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

	internal virtual ToolStripMenuItem ViewMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _ViewMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ViewMenu = value;
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

	internal virtual ToolStripMenuItem ToolsMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolsMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolsMenu = value;
		}
	}

	[DebuggerNonUserCode]
	public MDIParent1()
	{
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
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected O, but got Unknown
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected O, but got Unknown
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Expected O, but got Unknown
		//IL_06b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c0: Expected O, but got Unknown
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0717: Expected O, but got Unknown
		//IL_0822: Unknown result type (might be due to invalid IL or missing references)
		//IL_082c: Expected O, but got Unknown
		//IL_0879: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Expected O, but got Unknown
		//IL_08d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08de: Expected O, but got Unknown
		//IL_091f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0929: Expected O, but got Unknown
		//IL_09fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a04: Expected O, but got Unknown
		//IL_0b03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0d: Expected O, but got Unknown
		//IL_0b6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b78: Expected O, but got Unknown
		//IL_0d05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0f: Expected O, but got Unknown
		//IL_0d60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6a: Expected O, but got Unknown
		//IL_0dcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd5: Expected O, but got Unknown
		//IL_0e26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e30: Expected O, but got Unknown
		//IL_0e81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8b: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MDIParent1));
		MenuStrip = new MenuStrip();
		ToolStrip = new ToolStrip();
		StatusStrip = new StatusStrip();
		ContentsToolStripMenuItem = new ToolStripMenuItem();
		HelpMenu = new ToolStripMenuItem();
		IndexToolStripMenuItem = new ToolStripMenuItem();
		SearchToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator8 = new ToolStripSeparator();
		AboutToolStripMenuItem = new ToolStripMenuItem();
		ArrangeIconsToolStripMenuItem = new ToolStripMenuItem();
		CloseAllToolStripMenuItem = new ToolStripMenuItem();
		NewWindowToolStripMenuItem = new ToolStripMenuItem();
		WindowsMenu = new ToolStripMenuItem();
		CascadeToolStripMenuItem = new ToolStripMenuItem();
		TileVerticalToolStripMenuItem = new ToolStripMenuItem();
		TileHorizontalToolStripMenuItem = new ToolStripMenuItem();
		OptionsToolStripMenuItem = new ToolStripMenuItem();
		HelpToolStripButton = new ToolStripButton();
		ToolStripSeparator2 = new ToolStripSeparator();
		PrintPreviewToolStripButton = new ToolStripButton();
		ToolTip = new ToolTip(components);
		ToolStripStatusLabel = new ToolStripStatusLabel();
		PrintToolStripButton = new ToolStripButton();
		NewToolStripButton = new ToolStripButton();
		OpenToolStripButton = new ToolStripButton();
		SaveToolStripButton = new ToolStripButton();
		ToolStripSeparator1 = new ToolStripSeparator();
		PrintPreviewToolStripMenuItem = new ToolStripMenuItem();
		PrintToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator4 = new ToolStripSeparator();
		ExitToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator5 = new ToolStripSeparator();
		PrintSetupToolStripMenuItem = new ToolStripMenuItem();
		SaveAsToolStripMenuItem = new ToolStripMenuItem();
		NewToolStripMenuItem = new ToolStripMenuItem();
		FileMenu = new ToolStripMenuItem();
		OpenToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator3 = new ToolStripSeparator();
		SaveToolStripMenuItem = new ToolStripMenuItem();
		EditMenu = new ToolStripMenuItem();
		UndoToolStripMenuItem = new ToolStripMenuItem();
		RedoToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator6 = new ToolStripSeparator();
		CutToolStripMenuItem = new ToolStripMenuItem();
		CopyToolStripMenuItem = new ToolStripMenuItem();
		PasteToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator7 = new ToolStripSeparator();
		SelectAllToolStripMenuItem = new ToolStripMenuItem();
		ViewMenu = new ToolStripMenuItem();
		ToolBarToolStripMenuItem = new ToolStripMenuItem();
		StatusBarToolStripMenuItem = new ToolStripMenuItem();
		ToolsMenu = new ToolStripMenuItem();
		((Control)StatusStrip).SuspendLayout();
		((Control)ToolStrip).SuspendLayout();
		((Control)MenuStrip).SuspendLayout();
		((Control)this).SuspendLayout();
		((ToolStripItem)ContentsToolStripMenuItem).set_Name("ContentsToolStripMenuItem");
		ContentsToolStripMenuItem.set_ShortcutKeys((Keys)131184);
		((ToolStripItem)ContentsToolStripMenuItem).set_Text("&Contents");
		((ToolStripDropDownItem)HelpMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)ContentsToolStripMenuItem,
			(ToolStripItem)IndexToolStripMenuItem,
			(ToolStripItem)SearchToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator8,
			(ToolStripItem)AboutToolStripMenuItem
		});
		((ToolStripItem)HelpMenu).set_Name("HelpMenu");
		((ToolStripItem)HelpMenu).set_Text("&Help");
		((ToolStripItem)IndexToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("IndexToolStripMenuItem.Image"));
		((ToolStripItem)IndexToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)IndexToolStripMenuItem).set_Name("IndexToolStripMenuItem");
		((ToolStripItem)IndexToolStripMenuItem).set_Text("&Index");
		((ToolStripItem)SearchToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("SearchToolStripMenuItem.Image"));
		((ToolStripItem)SearchToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)SearchToolStripMenuItem).set_Name("SearchToolStripMenuItem");
		((ToolStripItem)SearchToolStripMenuItem).set_Text("&Search");
		((ToolStripItem)ToolStripSeparator8).set_Name("ToolStripSeparator8");
		((ToolStripItem)AboutToolStripMenuItem).set_Name("AboutToolStripMenuItem");
		((ToolStripItem)AboutToolStripMenuItem).set_Text("&About ...");
		((ToolStripItem)ArrangeIconsToolStripMenuItem).set_Name("ArrangeIconsToolStripMenuItem");
		((ToolStripItem)ArrangeIconsToolStripMenuItem).set_Text("&Arrange Icons");
		((ToolStripItem)CloseAllToolStripMenuItem).set_Name("CloseAllToolStripMenuItem");
		((ToolStripItem)CloseAllToolStripMenuItem).set_Text("C&lose All");
		((ToolStripItem)NewWindowToolStripMenuItem).set_Name("NewWindowToolStripMenuItem");
		((ToolStripItem)NewWindowToolStripMenuItem).set_Text("&New Window");
		((ToolStripDropDownItem)WindowsMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)NewWindowToolStripMenuItem,
			(ToolStripItem)CascadeToolStripMenuItem,
			(ToolStripItem)TileVerticalToolStripMenuItem,
			(ToolStripItem)TileHorizontalToolStripMenuItem,
			(ToolStripItem)CloseAllToolStripMenuItem,
			(ToolStripItem)ArrangeIconsToolStripMenuItem
		});
		((ToolStripItem)WindowsMenu).set_Name("WindowsMenu");
		((ToolStripItem)WindowsMenu).set_Text("&Windows");
		((ToolStripItem)CascadeToolStripMenuItem).set_Name("CascadeToolStripMenuItem");
		((ToolStripItem)CascadeToolStripMenuItem).set_Text("&Cascade");
		((ToolStripItem)TileVerticalToolStripMenuItem).set_Name("TileVerticalToolStripMenuItem");
		((ToolStripItem)TileVerticalToolStripMenuItem).set_Text("Tile &Vertical");
		((ToolStripItem)TileHorizontalToolStripMenuItem).set_Name("TileHorizontalToolStripMenuItem");
		((ToolStripItem)TileHorizontalToolStripMenuItem).set_Text("Tile &Horizontal");
		((ToolStripItem)OptionsToolStripMenuItem).set_Name("OptionsToolStripMenuItem");
		((ToolStripItem)OptionsToolStripMenuItem).set_Text("&Options");
		((ToolStripItem)HelpToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)HelpToolStripButton).set_Image((Image)componentResourceManager.GetObject("HelpToolStripButton.Image"));
		((ToolStripItem)HelpToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)HelpToolStripButton).set_Name("HelpToolStripButton");
		((ToolStripItem)HelpToolStripButton).set_Text("Help");
		((ToolStripItem)ToolStripSeparator2).set_Name("ToolStripSeparator2");
		((ToolStripItem)PrintPreviewToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)PrintPreviewToolStripButton).set_Image((Image)componentResourceManager.GetObject("PrintPreviewToolStripButton.Image"));
		((ToolStripItem)PrintPreviewToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)PrintPreviewToolStripButton).set_Name("PrintPreviewToolStripButton");
		((ToolStripItem)PrintPreviewToolStripButton).set_Text("Print Preview");
		((ToolStripItem)ToolStripStatusLabel).set_Name("ToolStripStatusLabel");
		((ToolStripItem)ToolStripStatusLabel).set_Text("Status");
		((ToolStrip)StatusStrip).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel });
		StatusStrip.set_LayoutStyle((ToolStripLayoutStyle)4);
		StatusStrip statusStrip = StatusStrip;
		Point location = new Point(0, 433);
		((Control)statusStrip).set_Location(location);
		((Control)StatusStrip).set_Name("StatusStrip");
		StatusStrip statusStrip2 = StatusStrip;
		Size size = new Size(632, 20);
		((Control)statusStrip2).set_Size(size);
		((Control)StatusStrip).set_TabIndex(7);
		((Control)StatusStrip).set_Text("StatusStrip");
		((ToolStripItem)PrintToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)PrintToolStripButton).set_Image((Image)componentResourceManager.GetObject("PrintToolStripButton.Image"));
		((ToolStripItem)PrintToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)PrintToolStripButton).set_Name("PrintToolStripButton");
		((ToolStripItem)PrintToolStripButton).set_Text("Print");
		((ToolStripItem)NewToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)NewToolStripButton).set_Image((Image)componentResourceManager.GetObject("NewToolStripButton.Image"));
		((ToolStripItem)NewToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)NewToolStripButton).set_Name("NewToolStripButton");
		((ToolStripItem)NewToolStripButton).set_Text("New");
		ToolStrip.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)NewToolStripButton,
			(ToolStripItem)OpenToolStripButton,
			(ToolStripItem)SaveToolStripButton,
			(ToolStripItem)ToolStripSeparator1,
			(ToolStripItem)PrintToolStripButton,
			(ToolStripItem)PrintPreviewToolStripButton,
			(ToolStripItem)ToolStripSeparator2,
			(ToolStripItem)HelpToolStripButton
		});
		ToolStrip toolStrip = ToolStrip;
		location = new Point(0, 24);
		((Control)toolStrip).set_Location(location);
		((Control)ToolStrip).set_Name("ToolStrip");
		ToolStrip toolStrip2 = ToolStrip;
		size = new Size(632, 25);
		((Control)toolStrip2).set_Size(size);
		((Control)ToolStrip).set_TabIndex(6);
		((Control)ToolStrip).set_Text("ToolStrip");
		((ToolStripItem)OpenToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)OpenToolStripButton).set_Image((Image)componentResourceManager.GetObject("OpenToolStripButton.Image"));
		((ToolStripItem)OpenToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)OpenToolStripButton).set_Name("OpenToolStripButton");
		((ToolStripItem)OpenToolStripButton).set_Text("Open");
		((ToolStripItem)SaveToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)SaveToolStripButton).set_Image((Image)componentResourceManager.GetObject("SaveToolStripButton.Image"));
		((ToolStripItem)SaveToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)SaveToolStripButton).set_Name("SaveToolStripButton");
		((ToolStripItem)SaveToolStripButton).set_Text("Save");
		((ToolStripItem)ToolStripSeparator1).set_Name("ToolStripSeparator1");
		((ToolStripItem)PrintPreviewToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("PrintPreviewToolStripMenuItem.Image"));
		((ToolStripItem)PrintPreviewToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)PrintPreviewToolStripMenuItem).set_Name("PrintPreviewToolStripMenuItem");
		((ToolStripItem)PrintPreviewToolStripMenuItem).set_Text("Print Pre&view");
		((ToolStripItem)PrintToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("PrintToolStripMenuItem.Image"));
		((ToolStripItem)PrintToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)PrintToolStripMenuItem).set_Name("PrintToolStripMenuItem");
		PrintToolStripMenuItem.set_ShortcutKeys((Keys)131152);
		((ToolStripItem)PrintToolStripMenuItem).set_Text("&Print");
		((ToolStripItem)ToolStripSeparator4).set_Name("ToolStripSeparator4");
		((ToolStripItem)ExitToolStripMenuItem).set_Name("ExitToolStripMenuItem");
		((ToolStripItem)ExitToolStripMenuItem).set_Text("E&xit");
		((ToolStripItem)ToolStripSeparator5).set_Name("ToolStripSeparator5");
		((ToolStripItem)PrintSetupToolStripMenuItem).set_Name("PrintSetupToolStripMenuItem");
		((ToolStripItem)PrintSetupToolStripMenuItem).set_Text("Print Setup");
		((ToolStripItem)SaveAsToolStripMenuItem).set_Name("SaveAsToolStripMenuItem");
		((ToolStripItem)SaveAsToolStripMenuItem).set_Text("Save &As");
		((ToolStripItem)NewToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("NewToolStripMenuItem.Image"));
		((ToolStripItem)NewToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)NewToolStripMenuItem).set_Name("NewToolStripMenuItem");
		NewToolStripMenuItem.set_ShortcutKeys((Keys)131150);
		((ToolStripItem)NewToolStripMenuItem).set_Text("&New");
		((ToolStripDropDownItem)FileMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)NewToolStripMenuItem,
			(ToolStripItem)OpenToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator3,
			(ToolStripItem)SaveToolStripMenuItem,
			(ToolStripItem)SaveAsToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator4,
			(ToolStripItem)PrintToolStripMenuItem,
			(ToolStripItem)PrintPreviewToolStripMenuItem,
			(ToolStripItem)PrintSetupToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator5,
			(ToolStripItem)ExitToolStripMenuItem
		});
		((ToolStripItem)FileMenu).set_ImageTransparentColor(SystemColors.ActiveBorder);
		((ToolStripItem)FileMenu).set_Name("FileMenu");
		((ToolStripItem)FileMenu).set_Text("&File");
		((ToolStripItem)OpenToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("OpenToolStripMenuItem.Image"));
		((ToolStripItem)OpenToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)OpenToolStripMenuItem).set_Name("OpenToolStripMenuItem");
		OpenToolStripMenuItem.set_ShortcutKeys((Keys)131151);
		((ToolStripItem)OpenToolStripMenuItem).set_Text("&Open");
		((ToolStripItem)ToolStripSeparator3).set_Name("ToolStripSeparator3");
		((ToolStripItem)SaveToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("SaveToolStripMenuItem.Image"));
		((ToolStripItem)SaveToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)SaveToolStripMenuItem).set_Name("SaveToolStripMenuItem");
		SaveToolStripMenuItem.set_ShortcutKeys((Keys)131155);
		((ToolStripItem)SaveToolStripMenuItem).set_Text("&Save");
		((ToolStrip)MenuStrip).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)FileMenu,
			(ToolStripItem)EditMenu,
			(ToolStripItem)ViewMenu,
			(ToolStripItem)ToolsMenu,
			(ToolStripItem)WindowsMenu,
			(ToolStripItem)HelpMenu
		});
		MenuStrip menuStrip = MenuStrip;
		location = new Point(0, 0);
		((Control)menuStrip).set_Location(location);
		MenuStrip.set_MdiWindowListItem(WindowsMenu);
		((Control)MenuStrip).set_Name("MenuStrip");
		MenuStrip menuStrip2 = MenuStrip;
		size = new Size(632, 24);
		((Control)menuStrip2).set_Size(size);
		((Control)MenuStrip).set_TabIndex(5);
		((Control)MenuStrip).set_Text("MenuStrip");
		((ToolStripDropDownItem)EditMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)UndoToolStripMenuItem,
			(ToolStripItem)RedoToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator6,
			(ToolStripItem)CutToolStripMenuItem,
			(ToolStripItem)CopyToolStripMenuItem,
			(ToolStripItem)PasteToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator7,
			(ToolStripItem)SelectAllToolStripMenuItem
		});
		((ToolStripItem)EditMenu).set_Name("EditMenu");
		((ToolStripItem)EditMenu).set_Text("&Edit");
		((ToolStripItem)UndoToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("UndoToolStripMenuItem.Image"));
		((ToolStripItem)UndoToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)UndoToolStripMenuItem).set_Name("UndoToolStripMenuItem");
		UndoToolStripMenuItem.set_ShortcutKeys((Keys)131162);
		((ToolStripItem)UndoToolStripMenuItem).set_Text("&Undo");
		((ToolStripItem)RedoToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("RedoToolStripMenuItem.Image"));
		((ToolStripItem)RedoToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)RedoToolStripMenuItem).set_Name("RedoToolStripMenuItem");
		RedoToolStripMenuItem.set_ShortcutKeys((Keys)131161);
		((ToolStripItem)RedoToolStripMenuItem).set_Text("&Redo");
		((ToolStripItem)ToolStripSeparator6).set_Name("ToolStripSeparator6");
		((ToolStripItem)CutToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("CutToolStripMenuItem.Image"));
		((ToolStripItem)CutToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)CutToolStripMenuItem).set_Name("CutToolStripMenuItem");
		CutToolStripMenuItem.set_ShortcutKeys((Keys)131160);
		((ToolStripItem)CutToolStripMenuItem).set_Text("Cu&t");
		((ToolStripItem)CopyToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("CopyToolStripMenuItem.Image"));
		((ToolStripItem)CopyToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)CopyToolStripMenuItem).set_Name("CopyToolStripMenuItem");
		CopyToolStripMenuItem.set_ShortcutKeys((Keys)131139);
		((ToolStripItem)CopyToolStripMenuItem).set_Text("&Copy");
		((ToolStripItem)PasteToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("PasteToolStripMenuItem.Image"));
		((ToolStripItem)PasteToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)PasteToolStripMenuItem).set_Name("PasteToolStripMenuItem");
		PasteToolStripMenuItem.set_ShortcutKeys((Keys)131158);
		((ToolStripItem)PasteToolStripMenuItem).set_Text("&Paste");
		((ToolStripItem)ToolStripSeparator7).set_Name("ToolStripSeparator7");
		((ToolStripItem)SelectAllToolStripMenuItem).set_Name("SelectAllToolStripMenuItem");
		SelectAllToolStripMenuItem.set_ShortcutKeys((Keys)131137);
		((ToolStripItem)SelectAllToolStripMenuItem).set_Text("Select &All");
		((ToolStripDropDownItem)ViewMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolBarToolStripMenuItem,
			(ToolStripItem)StatusBarToolStripMenuItem
		});
		((ToolStripItem)ViewMenu).set_Name("ViewMenu");
		((ToolStripItem)ViewMenu).set_Text("&View");
		ToolBarToolStripMenuItem.set_Checked(true);
		ToolBarToolStripMenuItem.set_CheckOnClick(true);
		ToolBarToolStripMenuItem.set_CheckState((CheckState)1);
		((ToolStripItem)ToolBarToolStripMenuItem).set_Name("ToolBarToolStripMenuItem");
		((ToolStripItem)ToolBarToolStripMenuItem).set_Text("&Toolbar");
		StatusBarToolStripMenuItem.set_Checked(true);
		StatusBarToolStripMenuItem.set_CheckOnClick(true);
		StatusBarToolStripMenuItem.set_CheckState((CheckState)1);
		((ToolStripItem)StatusBarToolStripMenuItem).set_Name("StatusBarToolStripMenuItem");
		((ToolStripItem)StatusBarToolStripMenuItem).set_Text("&Status Bar");
		((ToolStripDropDownItem)ToolsMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)OptionsToolStripMenuItem });
		((ToolStripItem)ToolsMenu).set_Name("ToolsMenu");
		((ToolStripItem)ToolsMenu).set_Text("&Tools");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(632, 453);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ToolStrip);
		((Control)this).get_Controls().Add((Control)(object)MenuStrip);
		((Control)this).get_Controls().Add((Control)(object)StatusStrip);
		((Form)this).set_IsMdiContainer(true);
		((Form)this).set_MainMenuStrip(MenuStrip);
		((Control)this).set_Name("MDIParent1");
		((Form)this).set_Text("MDIParent1");
		((Control)StatusStrip).ResumeLayout(false);
		((Control)ToolStrip).ResumeLayout(false);
		((Control)MenuStrip).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void ShowNewForm(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		Form val = new Form();
		val.set_MdiParent((Form)(object)this);
		checked
		{
			m_ChildFormNumber++;
			val.set_Text("Window " + Conversions.ToString(m_ChildFormNumber));
			((Control)val).Show();
		}
	}

	private void OpenFile(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_InitialDirectory(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments());
		((FileDialog)val).set_Filter("Text Files (*.txt)|*.txt|All Files (*.*)|*.*");
		bool flag;
		if (flag = (int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
		{
			string fileName = ((FileDialog)val).get_FileName();
		}
	}

	private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).set_InitialDirectory(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments());
		((FileDialog)val).set_Filter("Text Files (*.txt)|*.txt|All Files (*.*)|*.*");
		bool flag;
		if (flag = (int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
		{
			string fileName = ((FileDialog)val).get_FileName();
		}
	}

	private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void CutToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)ToolStrip).set_Visible(ToolBarToolStripMenuItem.get_Checked());
	}

	private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)StatusStrip).set_Visible(StatusBarToolStripMenuItem.get_Checked());
	}

	private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)0);
	}

	private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)2);
	}

	private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)1);
	}

	private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)3);
	}

	private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Form[] mdiChildren = ((Form)this).get_MdiChildren();
		int num = 0;
		bool flag;
		while (flag = num < mdiChildren.Length)
		{
			Form val = mdiChildren[num];
			val.Close();
			num = checked(num + 1);
		}
	}
}
