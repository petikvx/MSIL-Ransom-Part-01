using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using WindowsApplication1.My;

namespace WindowsApplication1;

[DesignerGenerated]
public class MDIParent1 : Form
{
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

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("TextBox5")]
	private TextBox _TextBox5;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("TextBox3")]
	private TextBox _TextBox3;

	[AccessedThroughProperty("TextBox6")]
	private TextBox _TextBox6;

	[AccessedThroughProperty("TextBox7")]
	private TextBox _TextBox7;

	[AccessedThroughProperty("TextBox4")]
	private TextBox _TextBox4;

	[AccessedThroughProperty("TextBox8")]
	private TextBox _TextBox8;

	[AccessedThroughProperty("TextBox9")]
	private TextBox _TextBox9;

	[AccessedThroughProperty("TextBox10")]
	private TextBox _TextBox10;

	[AccessedThroughProperty("TextBox11")]
	private TextBox _TextBox11;

	[AccessedThroughProperty("TextBox12")]
	private TextBox _TextBox12;

	[AccessedThroughProperty("TextBox13")]
	private TextBox _TextBox13;

	[AccessedThroughProperty("TextBox14")]
	private TextBox _TextBox14;

	[AccessedThroughProperty("TextBox15")]
	private TextBox _TextBox15;

	[AccessedThroughProperty("TextBox16")]
	private TextBox _TextBox16;

	[AccessedThroughProperty("TextBox17")]
	private TextBox _TextBox17;

	[AccessedThroughProperty("TextBox18")]
	private TextBox _TextBox18;

	private int m_ChildFormNumber;

	internal virtual ToolStripMenuItem ContentsToolStripMenuItem
	{
		get
		{
			return _ContentsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ContentsToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem HelpMenu
	{
		get
		{
			return _HelpMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_HelpMenu = value;
		}
	}

	internal virtual ToolStripMenuItem IndexToolStripMenuItem
	{
		get
		{
			return _IndexToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_IndexToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem SearchToolStripMenuItem
	{
		get
		{
			return _SearchToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_SearchToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator8
	{
		get
		{
			return _ToolStripSeparator8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator8 = value;
		}
	}

	internal virtual ToolStripMenuItem AboutToolStripMenuItem
	{
		get
		{
			return _AboutToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_AboutToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem ArrangeIconsToolStripMenuItem
	{
		get
		{
			return _ArrangeIconsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = ArrangeIconsToolStripMenuItem_Click;
			if (_ArrangeIconsToolStripMenuItem != null)
			{
				((ToolStripItem)_ArrangeIconsToolStripMenuItem).remove_Click(eventHandler);
			}
			_ArrangeIconsToolStripMenuItem = value;
			if (_ArrangeIconsToolStripMenuItem != null)
			{
				((ToolStripItem)_ArrangeIconsToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem CloseAllToolStripMenuItem
	{
		get
		{
			return _CloseAllToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = CloseAllToolStripMenuItem_Click;
			if (_CloseAllToolStripMenuItem != null)
			{
				((ToolStripItem)_CloseAllToolStripMenuItem).remove_Click(eventHandler);
			}
			_CloseAllToolStripMenuItem = value;
			if (_CloseAllToolStripMenuItem != null)
			{
				((ToolStripItem)_CloseAllToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem NewWindowToolStripMenuItem
	{
		get
		{
			return _NewWindowToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = ShowNewForm;
			if (_NewWindowToolStripMenuItem != null)
			{
				((ToolStripItem)_NewWindowToolStripMenuItem).remove_Click(eventHandler);
			}
			_NewWindowToolStripMenuItem = value;
			if (_NewWindowToolStripMenuItem != null)
			{
				((ToolStripItem)_NewWindowToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem WindowsMenu
	{
		get
		{
			return _WindowsMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_WindowsMenu = value;
		}
	}

	internal virtual ToolStripMenuItem CascadeToolStripMenuItem
	{
		get
		{
			return _CascadeToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = CascadeToolStripMenuItem_Click;
			if (_CascadeToolStripMenuItem != null)
			{
				((ToolStripItem)_CascadeToolStripMenuItem).remove_Click(eventHandler);
			}
			_CascadeToolStripMenuItem = value;
			if (_CascadeToolStripMenuItem != null)
			{
				((ToolStripItem)_CascadeToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem TileVerticalToolStripMenuItem
	{
		get
		{
			return _TileVerticalToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = TileVerticalToolStripMenuItem_Click;
			if (_TileVerticalToolStripMenuItem != null)
			{
				((ToolStripItem)_TileVerticalToolStripMenuItem).remove_Click(eventHandler);
			}
			_TileVerticalToolStripMenuItem = value;
			if (_TileVerticalToolStripMenuItem != null)
			{
				((ToolStripItem)_TileVerticalToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem TileHorizontalToolStripMenuItem
	{
		get
		{
			return _TileHorizontalToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = TileHorizontalToolStripMenuItem_Click;
			if (_TileHorizontalToolStripMenuItem != null)
			{
				((ToolStripItem)_TileHorizontalToolStripMenuItem).remove_Click(eventHandler);
			}
			_TileHorizontalToolStripMenuItem = value;
			if (_TileHorizontalToolStripMenuItem != null)
			{
				((ToolStripItem)_TileHorizontalToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem OptionsToolStripMenuItem
	{
		get
		{
			return _OptionsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_OptionsToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripButton HelpToolStripButton
	{
		get
		{
			return _HelpToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_HelpToolStripButton = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator2
	{
		get
		{
			return _ToolStripSeparator2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator2 = value;
		}
	}

	internal virtual ToolStripButton PrintPreviewToolStripButton
	{
		get
		{
			return _PrintPreviewToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PrintPreviewToolStripButton = value;
		}
	}

	internal virtual ToolTip ToolTip
	{
		get
		{
			return _ToolTip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolTip = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel
	{
		get
		{
			return _ToolStripStatusLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripStatusLabel = value;
		}
	}

	internal virtual StatusStrip StatusStrip
	{
		get
		{
			return _StatusStrip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_StatusStrip = value;
		}
	}

	internal virtual ToolStripButton PrintToolStripButton
	{
		get
		{
			return _PrintToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PrintToolStripButton = value;
		}
	}

	internal virtual ToolStripButton NewToolStripButton
	{
		get
		{
			return _NewToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = ShowNewForm;
			if (_NewToolStripButton != null)
			{
				((ToolStripItem)_NewToolStripButton).remove_Click(eventHandler);
			}
			_NewToolStripButton = value;
			if (_NewToolStripButton != null)
			{
				((ToolStripItem)_NewToolStripButton).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStrip ToolStrip
	{
		get
		{
			return _ToolStrip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStrip = value;
		}
	}

	internal virtual ToolStripButton OpenToolStripButton
	{
		get
		{
			return _OpenToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = OpenFile;
			if (_OpenToolStripButton != null)
			{
				((ToolStripItem)_OpenToolStripButton).remove_Click(eventHandler);
			}
			_OpenToolStripButton = value;
			if (_OpenToolStripButton != null)
			{
				((ToolStripItem)_OpenToolStripButton).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripButton SaveToolStripButton
	{
		get
		{
			return _SaveToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_SaveToolStripButton = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator1
	{
		get
		{
			return _ToolStripSeparator1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator1 = value;
		}
	}

	internal virtual ToolStripMenuItem PrintPreviewToolStripMenuItem
	{
		get
		{
			return _PrintPreviewToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PrintPreviewToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem PrintToolStripMenuItem
	{
		get
		{
			return _PrintToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PrintToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator4
	{
		get
		{
			return _ToolStripSeparator4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator4 = value;
		}
	}

	internal virtual ToolStripMenuItem ExitToolStripMenuItem
	{
		get
		{
			return _ExitToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = ExitToolsStripMenuItem_Click;
			if (_ExitToolStripMenuItem != null)
			{
				((ToolStripItem)_ExitToolStripMenuItem).remove_Click(eventHandler);
			}
			_ExitToolStripMenuItem = value;
			if (_ExitToolStripMenuItem != null)
			{
				((ToolStripItem)_ExitToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator5
	{
		get
		{
			return _ToolStripSeparator5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator5 = value;
		}
	}

	internal virtual ToolStripMenuItem PrintSetupToolStripMenuItem
	{
		get
		{
			return _PrintSetupToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PrintSetupToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem SaveAsToolStripMenuItem
	{
		get
		{
			return _SaveAsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = SaveAsToolStripMenuItem_Click;
			if (_SaveAsToolStripMenuItem != null)
			{
				((ToolStripItem)_SaveAsToolStripMenuItem).remove_Click(eventHandler);
			}
			_SaveAsToolStripMenuItem = value;
			if (_SaveAsToolStripMenuItem != null)
			{
				((ToolStripItem)_SaveAsToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem NewToolStripMenuItem
	{
		get
		{
			return _NewToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = ShowNewForm;
			if (_NewToolStripMenuItem != null)
			{
				((ToolStripItem)_NewToolStripMenuItem).remove_Click(eventHandler);
			}
			_NewToolStripMenuItem = value;
			if (_NewToolStripMenuItem != null)
			{
				((ToolStripItem)_NewToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem FileMenu
	{
		get
		{
			return _FileMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_FileMenu = value;
		}
	}

	internal virtual ToolStripMenuItem OpenToolStripMenuItem
	{
		get
		{
			return _OpenToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = OpenFile;
			if (_OpenToolStripMenuItem != null)
			{
				((ToolStripItem)_OpenToolStripMenuItem).remove_Click(eventHandler);
			}
			_OpenToolStripMenuItem = value;
			if (_OpenToolStripMenuItem != null)
			{
				((ToolStripItem)_OpenToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator3
	{
		get
		{
			return _ToolStripSeparator3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator3 = value;
		}
	}

	internal virtual ToolStripMenuItem SaveToolStripMenuItem
	{
		get
		{
			return _SaveToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_SaveToolStripMenuItem = value;
		}
	}

	internal virtual MenuStrip MenuStrip
	{
		get
		{
			return _MenuStrip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MenuStrip = value;
		}
	}

	internal virtual ToolStripMenuItem EditMenu
	{
		get
		{
			return _EditMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_EditMenu = value;
		}
	}

	internal virtual ToolStripMenuItem UndoToolStripMenuItem
	{
		get
		{
			return _UndoToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_UndoToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem RedoToolStripMenuItem
	{
		get
		{
			return _RedoToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RedoToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator6
	{
		get
		{
			return _ToolStripSeparator6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator6 = value;
		}
	}

	internal virtual ToolStripMenuItem CutToolStripMenuItem
	{
		get
		{
			return _CutToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = CutToolStripMenuItem_Click;
			if (_CutToolStripMenuItem != null)
			{
				((ToolStripItem)_CutToolStripMenuItem).remove_Click(eventHandler);
			}
			_CutToolStripMenuItem = value;
			if (_CutToolStripMenuItem != null)
			{
				((ToolStripItem)_CutToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem CopyToolStripMenuItem
	{
		get
		{
			return _CopyToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = CopyToolStripMenuItem_Click;
			if (_CopyToolStripMenuItem != null)
			{
				((ToolStripItem)_CopyToolStripMenuItem).remove_Click(eventHandler);
			}
			_CopyToolStripMenuItem = value;
			if (_CopyToolStripMenuItem != null)
			{
				((ToolStripItem)_CopyToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem PasteToolStripMenuItem
	{
		get
		{
			return _PasteToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = PasteToolStripMenuItem_Click;
			if (_PasteToolStripMenuItem != null)
			{
				((ToolStripItem)_PasteToolStripMenuItem).remove_Click(eventHandler);
			}
			_PasteToolStripMenuItem = value;
			if (_PasteToolStripMenuItem != null)
			{
				((ToolStripItem)_PasteToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator7
	{
		get
		{
			return _ToolStripSeparator7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator7 = value;
		}
	}

	internal virtual ToolStripMenuItem SelectAllToolStripMenuItem
	{
		get
		{
			return _SelectAllToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_SelectAllToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem ViewMenu
	{
		get
		{
			return _ViewMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ViewMenu = value;
		}
	}

	internal virtual ToolStripMenuItem ToolBarToolStripMenuItem
	{
		get
		{
			return _ToolBarToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = ToolBarToolStripMenuItem_Click;
			if (_ToolBarToolStripMenuItem != null)
			{
				((ToolStripItem)_ToolBarToolStripMenuItem).remove_Click(eventHandler);
			}
			_ToolBarToolStripMenuItem = value;
			if (_ToolBarToolStripMenuItem != null)
			{
				((ToolStripItem)_ToolBarToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem StatusBarToolStripMenuItem
	{
		get
		{
			return _StatusBarToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = StatusBarToolStripMenuItem_Click;
			if (_StatusBarToolStripMenuItem != null)
			{
				((ToolStripItem)_StatusBarToolStripMenuItem).remove_Click(eventHandler);
			}
			_StatusBarToolStripMenuItem = value;
			if (_StatusBarToolStripMenuItem != null)
			{
				((ToolStripItem)_StatusBarToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ToolsMenu
	{
		get
		{
			return _ToolsMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolsMenu = value;
		}
	}

	internal virtual TextBox TextBox1
	{
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual TextBox TextBox5
	{
		get
		{
			return _TextBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox5 = value;
		}
	}

	internal virtual TextBox TextBox2
	{
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox2 = value;
		}
	}

	internal virtual TextBox TextBox3
	{
		get
		{
			return _TextBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox3 = value;
		}
	}

	internal virtual TextBox TextBox6
	{
		get
		{
			return _TextBox6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox6 = value;
		}
	}

	internal virtual TextBox TextBox7
	{
		get
		{
			return _TextBox7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox7 = value;
		}
	}

	internal virtual TextBox TextBox4
	{
		get
		{
			return _TextBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox4 = value;
		}
	}

	internal virtual TextBox TextBox8
	{
		get
		{
			return _TextBox8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox8 = value;
		}
	}

	internal virtual TextBox TextBox9
	{
		get
		{
			return _TextBox9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox9 = value;
		}
	}

	internal virtual TextBox TextBox10
	{
		get
		{
			return _TextBox10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox10 = value;
		}
	}

	internal virtual TextBox TextBox11
	{
		get
		{
			return _TextBox11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox11 = value;
		}
	}

	internal virtual TextBox TextBox12
	{
		get
		{
			return _TextBox12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox12 = value;
		}
	}

	internal virtual TextBox TextBox13
	{
		get
		{
			return _TextBox13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox13 = value;
		}
	}

	internal virtual TextBox TextBox14
	{
		get
		{
			return _TextBox14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox14 = value;
		}
	}

	internal virtual TextBox TextBox15
	{
		get
		{
			return _TextBox15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox15 = value;
		}
	}

	internal virtual TextBox TextBox16
	{
		get
		{
			return _TextBox16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox16 = value;
		}
	}

	internal virtual TextBox TextBox17
	{
		get
		{
			return _TextBox17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox17 = value;
		}
	}

	internal virtual TextBox TextBox18
	{
		get
		{
			return _TextBox18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox18 = value;
		}
	}

	public MDIParent1()
	{
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
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
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
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected O, but got Unknown
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected O, but got Unknown
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Expected O, but got Unknown
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d7: Expected O, but got Unknown
		//IL_0743: Unknown result type (might be due to invalid IL or missing references)
		//IL_074d: Expected O, but got Unknown
		//IL_08e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08eb: Expected O, but got Unknown
		//IL_0957: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Expected O, but got Unknown
		//IL_09f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a01: Expected O, but got Unknown
		//IL_0a6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a77: Expected O, but got Unknown
		//IL_0ae3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aed: Expected O, but got Unknown
		//IL_1029: Unknown result type (might be due to invalid IL or missing references)
		//IL_1033: Expected O, but got Unknown
		//IL_108f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1099: Expected O, but got Unknown
		//IL_1223: Unknown result type (might be due to invalid IL or missing references)
		//IL_122d: Expected O, but got Unknown
		//IL_1292: Unknown result type (might be due to invalid IL or missing references)
		//IL_129c: Expected O, but got Unknown
		//IL_1301: Unknown result type (might be due to invalid IL or missing references)
		//IL_130b: Expected O, but got Unknown
		//IL_1397: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a1: Expected O, but got Unknown
		//IL_1406: Unknown result type (might be due to invalid IL or missing references)
		//IL_1410: Expected O, but got Unknown
		//IL_149c: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a6: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MDIParent1));
		MenuStrip = new MenuStrip();
		FileMenu = new ToolStripMenuItem();
		NewToolStripMenuItem = new ToolStripMenuItem();
		OpenToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator3 = new ToolStripSeparator();
		SaveToolStripMenuItem = new ToolStripMenuItem();
		SaveAsToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator4 = new ToolStripSeparator();
		PrintToolStripMenuItem = new ToolStripMenuItem();
		PrintPreviewToolStripMenuItem = new ToolStripMenuItem();
		PrintSetupToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator5 = new ToolStripSeparator();
		ExitToolStripMenuItem = new ToolStripMenuItem();
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
		OptionsToolStripMenuItem = new ToolStripMenuItem();
		WindowsMenu = new ToolStripMenuItem();
		NewWindowToolStripMenuItem = new ToolStripMenuItem();
		CascadeToolStripMenuItem = new ToolStripMenuItem();
		TileVerticalToolStripMenuItem = new ToolStripMenuItem();
		TileHorizontalToolStripMenuItem = new ToolStripMenuItem();
		CloseAllToolStripMenuItem = new ToolStripMenuItem();
		ArrangeIconsToolStripMenuItem = new ToolStripMenuItem();
		HelpMenu = new ToolStripMenuItem();
		ContentsToolStripMenuItem = new ToolStripMenuItem();
		IndexToolStripMenuItem = new ToolStripMenuItem();
		SearchToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator8 = new ToolStripSeparator();
		AboutToolStripMenuItem = new ToolStripMenuItem();
		ToolStrip = new ToolStrip();
		NewToolStripButton = new ToolStripButton();
		OpenToolStripButton = new ToolStripButton();
		SaveToolStripButton = new ToolStripButton();
		ToolStripSeparator1 = new ToolStripSeparator();
		PrintToolStripButton = new ToolStripButton();
		PrintPreviewToolStripButton = new ToolStripButton();
		ToolStripSeparator2 = new ToolStripSeparator();
		HelpToolStripButton = new ToolStripButton();
		StatusStrip = new StatusStrip();
		ToolStripStatusLabel = new ToolStripStatusLabel();
		ToolTip = new ToolTip(components);
		TextBox1 = new TextBox();
		TextBox5 = new TextBox();
		TextBox2 = new TextBox();
		TextBox3 = new TextBox();
		TextBox6 = new TextBox();
		TextBox7 = new TextBox();
		TextBox4 = new TextBox();
		TextBox8 = new TextBox();
		TextBox9 = new TextBox();
		TextBox10 = new TextBox();
		TextBox11 = new TextBox();
		TextBox12 = new TextBox();
		TextBox13 = new TextBox();
		TextBox14 = new TextBox();
		TextBox15 = new TextBox();
		TextBox16 = new TextBox();
		TextBox17 = new TextBox();
		TextBox18 = new TextBox();
		((Control)MenuStrip).SuspendLayout();
		((Control)ToolStrip).SuspendLayout();
		((Control)StatusStrip).SuspendLayout();
		((Control)this).SuspendLayout();
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
		Point location = new Point(0, 0);
		((Control)menuStrip).set_Location(location);
		MenuStrip.set_MdiWindowListItem(WindowsMenu);
		((Control)MenuStrip).set_Name("MenuStrip");
		MenuStrip menuStrip2 = MenuStrip;
		Size size = new Size(632, 24);
		((Control)menuStrip2).set_Size(size);
		((Control)MenuStrip).set_TabIndex(5);
		((Control)MenuStrip).set_Text("MenuStrip");
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
		ToolStripMenuItem fileMenu = FileMenu;
		size = new Size(37, 20);
		((ToolStripItem)fileMenu).set_Size(size);
		((ToolStripItem)FileMenu).set_Text("&File");
		((ToolStripItem)NewToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("NewToolStripMenuItem.Image"));
		((ToolStripItem)NewToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)NewToolStripMenuItem).set_Name("NewToolStripMenuItem");
		NewToolStripMenuItem.set_ShortcutKeys((Keys)131150);
		ToolStripMenuItem newToolStripMenuItem = NewToolStripMenuItem;
		size = new Size(146, 22);
		((ToolStripItem)newToolStripMenuItem).set_Size(size);
		((ToolStripItem)NewToolStripMenuItem).set_Text("&New");
		((ToolStripItem)OpenToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("OpenToolStripMenuItem.Image"));
		((ToolStripItem)OpenToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)OpenToolStripMenuItem).set_Name("OpenToolStripMenuItem");
		OpenToolStripMenuItem.set_ShortcutKeys((Keys)131151);
		ToolStripMenuItem openToolStripMenuItem = OpenToolStripMenuItem;
		size = new Size(146, 22);
		((ToolStripItem)openToolStripMenuItem).set_Size(size);
		((ToolStripItem)OpenToolStripMenuItem).set_Text("&Open");
		((ToolStripItem)ToolStripSeparator3).set_Name("ToolStripSeparator3");
		ToolStripSeparator toolStripSeparator = ToolStripSeparator3;
		size = new Size(143, 6);
		((ToolStripItem)toolStripSeparator).set_Size(size);
		((ToolStripItem)SaveToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("SaveToolStripMenuItem.Image"));
		((ToolStripItem)SaveToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)SaveToolStripMenuItem).set_Name("SaveToolStripMenuItem");
		SaveToolStripMenuItem.set_ShortcutKeys((Keys)131155);
		ToolStripMenuItem saveToolStripMenuItem = SaveToolStripMenuItem;
		size = new Size(146, 22);
		((ToolStripItem)saveToolStripMenuItem).set_Size(size);
		((ToolStripItem)SaveToolStripMenuItem).set_Text("&Save");
		((ToolStripItem)SaveAsToolStripMenuItem).set_Name("SaveAsToolStripMenuItem");
		ToolStripMenuItem saveAsToolStripMenuItem = SaveAsToolStripMenuItem;
		size = new Size(146, 22);
		((ToolStripItem)saveAsToolStripMenuItem).set_Size(size);
		((ToolStripItem)SaveAsToolStripMenuItem).set_Text("Save &As");
		((ToolStripItem)ToolStripSeparator4).set_Name("ToolStripSeparator4");
		ToolStripSeparator toolStripSeparator2 = ToolStripSeparator4;
		size = new Size(143, 6);
		((ToolStripItem)toolStripSeparator2).set_Size(size);
		((ToolStripItem)PrintToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("PrintToolStripMenuItem.Image"));
		((ToolStripItem)PrintToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)PrintToolStripMenuItem).set_Name("PrintToolStripMenuItem");
		PrintToolStripMenuItem.set_ShortcutKeys((Keys)131152);
		ToolStripMenuItem printToolStripMenuItem = PrintToolStripMenuItem;
		size = new Size(146, 22);
		((ToolStripItem)printToolStripMenuItem).set_Size(size);
		((ToolStripItem)PrintToolStripMenuItem).set_Text("&Print");
		((ToolStripItem)PrintPreviewToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("PrintPreviewToolStripMenuItem.Image"));
		((ToolStripItem)PrintPreviewToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)PrintPreviewToolStripMenuItem).set_Name("PrintPreviewToolStripMenuItem");
		ToolStripMenuItem printPreviewToolStripMenuItem = PrintPreviewToolStripMenuItem;
		size = new Size(146, 22);
		((ToolStripItem)printPreviewToolStripMenuItem).set_Size(size);
		((ToolStripItem)PrintPreviewToolStripMenuItem).set_Text("Print Pre&view");
		((ToolStripItem)PrintSetupToolStripMenuItem).set_Name("PrintSetupToolStripMenuItem");
		ToolStripMenuItem printSetupToolStripMenuItem = PrintSetupToolStripMenuItem;
		size = new Size(146, 22);
		((ToolStripItem)printSetupToolStripMenuItem).set_Size(size);
		((ToolStripItem)PrintSetupToolStripMenuItem).set_Text("Print Setup");
		((ToolStripItem)ToolStripSeparator5).set_Name("ToolStripSeparator5");
		ToolStripSeparator toolStripSeparator3 = ToolStripSeparator5;
		size = new Size(143, 6);
		((ToolStripItem)toolStripSeparator3).set_Size(size);
		((ToolStripItem)ExitToolStripMenuItem).set_Name("ExitToolStripMenuItem");
		ToolStripMenuItem exitToolStripMenuItem = ExitToolStripMenuItem;
		size = new Size(146, 22);
		((ToolStripItem)exitToolStripMenuItem).set_Size(size);
		((ToolStripItem)ExitToolStripMenuItem).set_Text("E&xit");
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
		ToolStripMenuItem editMenu = EditMenu;
		size = new Size(39, 20);
		((ToolStripItem)editMenu).set_Size(size);
		((ToolStripItem)EditMenu).set_Text("&Edit");
		((ToolStripItem)UndoToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("UndoToolStripMenuItem.Image"));
		((ToolStripItem)UndoToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)UndoToolStripMenuItem).set_Name("UndoToolStripMenuItem");
		UndoToolStripMenuItem.set_ShortcutKeys((Keys)131162);
		ToolStripMenuItem undoToolStripMenuItem = UndoToolStripMenuItem;
		size = new Size(164, 22);
		((ToolStripItem)undoToolStripMenuItem).set_Size(size);
		((ToolStripItem)UndoToolStripMenuItem).set_Text("&Undo");
		((ToolStripItem)RedoToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("RedoToolStripMenuItem.Image"));
		((ToolStripItem)RedoToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)RedoToolStripMenuItem).set_Name("RedoToolStripMenuItem");
		RedoToolStripMenuItem.set_ShortcutKeys((Keys)131161);
		ToolStripMenuItem redoToolStripMenuItem = RedoToolStripMenuItem;
		size = new Size(164, 22);
		((ToolStripItem)redoToolStripMenuItem).set_Size(size);
		((ToolStripItem)RedoToolStripMenuItem).set_Text("&Redo");
		((ToolStripItem)ToolStripSeparator6).set_Name("ToolStripSeparator6");
		ToolStripSeparator toolStripSeparator4 = ToolStripSeparator6;
		size = new Size(161, 6);
		((ToolStripItem)toolStripSeparator4).set_Size(size);
		((ToolStripItem)CutToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("CutToolStripMenuItem.Image"));
		((ToolStripItem)CutToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)CutToolStripMenuItem).set_Name("CutToolStripMenuItem");
		CutToolStripMenuItem.set_ShortcutKeys((Keys)131160);
		ToolStripMenuItem cutToolStripMenuItem = CutToolStripMenuItem;
		size = new Size(164, 22);
		((ToolStripItem)cutToolStripMenuItem).set_Size(size);
		((ToolStripItem)CutToolStripMenuItem).set_Text("Cu&t");
		((ToolStripItem)CopyToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("CopyToolStripMenuItem.Image"));
		((ToolStripItem)CopyToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)CopyToolStripMenuItem).set_Name("CopyToolStripMenuItem");
		CopyToolStripMenuItem.set_ShortcutKeys((Keys)131139);
		ToolStripMenuItem copyToolStripMenuItem = CopyToolStripMenuItem;
		size = new Size(164, 22);
		((ToolStripItem)copyToolStripMenuItem).set_Size(size);
		((ToolStripItem)CopyToolStripMenuItem).set_Text("&Copy");
		((ToolStripItem)PasteToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("PasteToolStripMenuItem.Image"));
		((ToolStripItem)PasteToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)PasteToolStripMenuItem).set_Name("PasteToolStripMenuItem");
		PasteToolStripMenuItem.set_ShortcutKeys((Keys)131158);
		ToolStripMenuItem pasteToolStripMenuItem = PasteToolStripMenuItem;
		size = new Size(164, 22);
		((ToolStripItem)pasteToolStripMenuItem).set_Size(size);
		((ToolStripItem)PasteToolStripMenuItem).set_Text("&Paste");
		((ToolStripItem)ToolStripSeparator7).set_Name("ToolStripSeparator7");
		ToolStripSeparator toolStripSeparator5 = ToolStripSeparator7;
		size = new Size(161, 6);
		((ToolStripItem)toolStripSeparator5).set_Size(size);
		((ToolStripItem)SelectAllToolStripMenuItem).set_Name("SelectAllToolStripMenuItem");
		SelectAllToolStripMenuItem.set_ShortcutKeys((Keys)131137);
		ToolStripMenuItem selectAllToolStripMenuItem = SelectAllToolStripMenuItem;
		size = new Size(164, 22);
		((ToolStripItem)selectAllToolStripMenuItem).set_Size(size);
		((ToolStripItem)SelectAllToolStripMenuItem).set_Text("Select &All");
		((ToolStripDropDownItem)ViewMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolBarToolStripMenuItem,
			(ToolStripItem)StatusBarToolStripMenuItem
		});
		((ToolStripItem)ViewMenu).set_Name("ViewMenu");
		ToolStripMenuItem viewMenu = ViewMenu;
		size = new Size(44, 20);
		((ToolStripItem)viewMenu).set_Size(size);
		((ToolStripItem)ViewMenu).set_Text("&View");
		ToolBarToolStripMenuItem.set_Checked(true);
		ToolBarToolStripMenuItem.set_CheckOnClick(true);
		ToolBarToolStripMenuItem.set_CheckState((CheckState)1);
		((ToolStripItem)ToolBarToolStripMenuItem).set_Name("ToolBarToolStripMenuItem");
		ToolStripMenuItem toolBarToolStripMenuItem = ToolBarToolStripMenuItem;
		size = new Size(126, 22);
		((ToolStripItem)toolBarToolStripMenuItem).set_Size(size);
		((ToolStripItem)ToolBarToolStripMenuItem).set_Text("&Toolbar");
		StatusBarToolStripMenuItem.set_Checked(true);
		StatusBarToolStripMenuItem.set_CheckOnClick(true);
		StatusBarToolStripMenuItem.set_CheckState((CheckState)1);
		((ToolStripItem)StatusBarToolStripMenuItem).set_Name("StatusBarToolStripMenuItem");
		ToolStripMenuItem statusBarToolStripMenuItem = StatusBarToolStripMenuItem;
		size = new Size(126, 22);
		((ToolStripItem)statusBarToolStripMenuItem).set_Size(size);
		((ToolStripItem)StatusBarToolStripMenuItem).set_Text("&Status Bar");
		((ToolStripDropDownItem)ToolsMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)OptionsToolStripMenuItem });
		((ToolStripItem)ToolsMenu).set_Name("ToolsMenu");
		ToolStripMenuItem toolsMenu = ToolsMenu;
		size = new Size(48, 20);
		((ToolStripItem)toolsMenu).set_Size(size);
		((ToolStripItem)ToolsMenu).set_Text("&Tools");
		((ToolStripItem)OptionsToolStripMenuItem).set_Name("OptionsToolStripMenuItem");
		ToolStripMenuItem optionsToolStripMenuItem = OptionsToolStripMenuItem;
		size = new Size(116, 22);
		((ToolStripItem)optionsToolStripMenuItem).set_Size(size);
		((ToolStripItem)OptionsToolStripMenuItem).set_Text("&Options");
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
		ToolStripMenuItem windowsMenu = WindowsMenu;
		size = new Size(68, 20);
		((ToolStripItem)windowsMenu).set_Size(size);
		((ToolStripItem)WindowsMenu).set_Text("&Windows");
		((ToolStripItem)NewWindowToolStripMenuItem).set_Name("NewWindowToolStripMenuItem");
		ToolStripMenuItem newWindowToolStripMenuItem = NewWindowToolStripMenuItem;
		size = new Size(151, 22);
		((ToolStripItem)newWindowToolStripMenuItem).set_Size(size);
		((ToolStripItem)NewWindowToolStripMenuItem).set_Text("&New Window");
		((ToolStripItem)CascadeToolStripMenuItem).set_Name("CascadeToolStripMenuItem");
		ToolStripMenuItem cascadeToolStripMenuItem = CascadeToolStripMenuItem;
		size = new Size(151, 22);
		((ToolStripItem)cascadeToolStripMenuItem).set_Size(size);
		((ToolStripItem)CascadeToolStripMenuItem).set_Text("&Cascade");
		((ToolStripItem)TileVerticalToolStripMenuItem).set_Name("TileVerticalToolStripMenuItem");
		ToolStripMenuItem tileVerticalToolStripMenuItem = TileVerticalToolStripMenuItem;
		size = new Size(151, 22);
		((ToolStripItem)tileVerticalToolStripMenuItem).set_Size(size);
		((ToolStripItem)TileVerticalToolStripMenuItem).set_Text("Tile &Vertical");
		((ToolStripItem)TileHorizontalToolStripMenuItem).set_Name("TileHorizontalToolStripMenuItem");
		ToolStripMenuItem tileHorizontalToolStripMenuItem = TileHorizontalToolStripMenuItem;
		size = new Size(151, 22);
		((ToolStripItem)tileHorizontalToolStripMenuItem).set_Size(size);
		((ToolStripItem)TileHorizontalToolStripMenuItem).set_Text("Tile &Horizontal");
		((ToolStripItem)CloseAllToolStripMenuItem).set_Name("CloseAllToolStripMenuItem");
		ToolStripMenuItem closeAllToolStripMenuItem = CloseAllToolStripMenuItem;
		size = new Size(151, 22);
		((ToolStripItem)closeAllToolStripMenuItem).set_Size(size);
		((ToolStripItem)CloseAllToolStripMenuItem).set_Text("C&lose All");
		((ToolStripItem)ArrangeIconsToolStripMenuItem).set_Name("ArrangeIconsToolStripMenuItem");
		ToolStripMenuItem arrangeIconsToolStripMenuItem = ArrangeIconsToolStripMenuItem;
		size = new Size(151, 22);
		((ToolStripItem)arrangeIconsToolStripMenuItem).set_Size(size);
		((ToolStripItem)ArrangeIconsToolStripMenuItem).set_Text("&Arrange Icons");
		((ToolStripDropDownItem)HelpMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)ContentsToolStripMenuItem,
			(ToolStripItem)IndexToolStripMenuItem,
			(ToolStripItem)SearchToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator8,
			(ToolStripItem)AboutToolStripMenuItem
		});
		((ToolStripItem)HelpMenu).set_Name("HelpMenu");
		ToolStripMenuItem helpMenu = HelpMenu;
		size = new Size(44, 20);
		((ToolStripItem)helpMenu).set_Size(size);
		((ToolStripItem)HelpMenu).set_Text("&Help");
		((ToolStripItem)ContentsToolStripMenuItem).set_Name("ContentsToolStripMenuItem");
		ContentsToolStripMenuItem.set_ShortcutKeys((Keys)131184);
		ToolStripMenuItem contentsToolStripMenuItem = ContentsToolStripMenuItem;
		size = new Size(168, 22);
		((ToolStripItem)contentsToolStripMenuItem).set_Size(size);
		((ToolStripItem)ContentsToolStripMenuItem).set_Text("&Contents");
		((ToolStripItem)IndexToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("IndexToolStripMenuItem.Image"));
		((ToolStripItem)IndexToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)IndexToolStripMenuItem).set_Name("IndexToolStripMenuItem");
		ToolStripMenuItem indexToolStripMenuItem = IndexToolStripMenuItem;
		size = new Size(168, 22);
		((ToolStripItem)indexToolStripMenuItem).set_Size(size);
		((ToolStripItem)IndexToolStripMenuItem).set_Text("&Index");
		((ToolStripItem)SearchToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("SearchToolStripMenuItem.Image"));
		((ToolStripItem)SearchToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)SearchToolStripMenuItem).set_Name("SearchToolStripMenuItem");
		ToolStripMenuItem searchToolStripMenuItem = SearchToolStripMenuItem;
		size = new Size(168, 22);
		((ToolStripItem)searchToolStripMenuItem).set_Size(size);
		((ToolStripItem)SearchToolStripMenuItem).set_Text("&Search");
		((ToolStripItem)ToolStripSeparator8).set_Name("ToolStripSeparator8");
		ToolStripSeparator toolStripSeparator6 = ToolStripSeparator8;
		size = new Size(165, 6);
		((ToolStripItem)toolStripSeparator6).set_Size(size);
		((ToolStripItem)AboutToolStripMenuItem).set_Name("AboutToolStripMenuItem");
		ToolStripMenuItem aboutToolStripMenuItem = AboutToolStripMenuItem;
		size = new Size(168, 22);
		((ToolStripItem)aboutToolStripMenuItem).set_Size(size);
		((ToolStripItem)AboutToolStripMenuItem).set_Text("&About ...");
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
		((ToolStripItem)NewToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)NewToolStripButton).set_Image((Image)componentResourceManager.GetObject("NewToolStripButton.Image"));
		((ToolStripItem)NewToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)NewToolStripButton).set_Name("NewToolStripButton");
		ToolStripButton newToolStripButton = NewToolStripButton;
		size = new Size(23, 22);
		((ToolStripItem)newToolStripButton).set_Size(size);
		((ToolStripItem)NewToolStripButton).set_Text("New");
		((ToolStripItem)OpenToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)OpenToolStripButton).set_Image((Image)componentResourceManager.GetObject("OpenToolStripButton.Image"));
		((ToolStripItem)OpenToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)OpenToolStripButton).set_Name("OpenToolStripButton");
		ToolStripButton openToolStripButton = OpenToolStripButton;
		size = new Size(23, 22);
		((ToolStripItem)openToolStripButton).set_Size(size);
		((ToolStripItem)OpenToolStripButton).set_Text("Open");
		((ToolStripItem)SaveToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)SaveToolStripButton).set_Image((Image)componentResourceManager.GetObject("SaveToolStripButton.Image"));
		((ToolStripItem)SaveToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)SaveToolStripButton).set_Name("SaveToolStripButton");
		ToolStripButton saveToolStripButton = SaveToolStripButton;
		size = new Size(23, 22);
		((ToolStripItem)saveToolStripButton).set_Size(size);
		((ToolStripItem)SaveToolStripButton).set_Text("Save");
		((ToolStripItem)ToolStripSeparator1).set_Name("ToolStripSeparator1");
		ToolStripSeparator toolStripSeparator7 = ToolStripSeparator1;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator7).set_Size(size);
		((ToolStripItem)PrintToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)PrintToolStripButton).set_Image((Image)componentResourceManager.GetObject("PrintToolStripButton.Image"));
		((ToolStripItem)PrintToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)PrintToolStripButton).set_Name("PrintToolStripButton");
		ToolStripButton printToolStripButton = PrintToolStripButton;
		size = new Size(23, 22);
		((ToolStripItem)printToolStripButton).set_Size(size);
		((ToolStripItem)PrintToolStripButton).set_Text("Print");
		((ToolStripItem)PrintPreviewToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)PrintPreviewToolStripButton).set_Image((Image)componentResourceManager.GetObject("PrintPreviewToolStripButton.Image"));
		((ToolStripItem)PrintPreviewToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)PrintPreviewToolStripButton).set_Name("PrintPreviewToolStripButton");
		ToolStripButton printPreviewToolStripButton = PrintPreviewToolStripButton;
		size = new Size(23, 22);
		((ToolStripItem)printPreviewToolStripButton).set_Size(size);
		((ToolStripItem)PrintPreviewToolStripButton).set_Text("Print Preview");
		((ToolStripItem)ToolStripSeparator2).set_Name("ToolStripSeparator2");
		ToolStripSeparator toolStripSeparator8 = ToolStripSeparator2;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator8).set_Size(size);
		((ToolStripItem)HelpToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)HelpToolStripButton).set_Image((Image)componentResourceManager.GetObject("HelpToolStripButton.Image"));
		((ToolStripItem)HelpToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)HelpToolStripButton).set_Name("HelpToolStripButton");
		ToolStripButton helpToolStripButton = HelpToolStripButton;
		size = new Size(23, 22);
		((ToolStripItem)helpToolStripButton).set_Size(size);
		((ToolStripItem)HelpToolStripButton).set_Text("Help");
		((ToolStrip)StatusStrip).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel });
		StatusStrip statusStrip = StatusStrip;
		location = new Point(0, 431);
		((Control)statusStrip).set_Location(location);
		((Control)StatusStrip).set_Name("StatusStrip");
		StatusStrip statusStrip2 = StatusStrip;
		size = new Size(632, 22);
		((Control)statusStrip2).set_Size(size);
		((Control)StatusStrip).set_TabIndex(7);
		((Control)StatusStrip).set_Text("StatusStrip");
		((ToolStripItem)ToolStripStatusLabel).set_Name("ToolStripStatusLabel");
		ToolStripStatusLabel toolStripStatusLabel = ToolStripStatusLabel;
		size = new Size(39, 17);
		((ToolStripItem)toolStripStatusLabel).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel).set_Text("Status");
		TextBox textBox = TextBox1;
		location = new Point(21, 70);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		size = new Size(114, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(9);
		TextBox1.set_Text("4D5A90000300000004000000FFFF0000B800000000000000400000000000000000000000000000000000000000000000000000000000000000000000800000000E1FBA0E00B409CD21B8014CCD21546869732070726F6772616D2063616E6E6F74206265");
		TextBox textBox3 = TextBox5;
		location = new Point(21, 174);
		((Control)textBox3).set_Location(location);
		((Control)TextBox5).set_Name("TextBox5");
		TextBox textBox4 = TextBox5;
		size = new Size(114, 20);
		((Control)textBox4).set_Size(size);
		((Control)TextBox5).set_TabIndex(10);
		TextBox5.set_Text("000000000000000000000000200000602E73646174610000B40000000060000000020000002C0000000000000000000000000000400000C02E72737263000000C80A000000800000000C0000002E0000000000000000000000000000400000402E72656C");
		TextBox textBox5 = TextBox2;
		location = new Point(21, 96);
		((Control)textBox5).set_Location(location);
		((Control)TextBox2).set_Name("TextBox2");
		TextBox textBox6 = TextBox2;
		size = new Size(114, 20);
		((Control)textBox6).set_Size(size);
		((Control)TextBox2).set_TabIndex(11);
		TextBox2.set_Text("2072756E20696E20444F53206D6F64652E0D0D0A2400000000000000504500004C010400AD52B7550000000000000000E00002010B010B00002800000010000000000000EE46000000200000006000000000400000200000000200000400000000000000");
		TextBox textBox7 = TextBox3;
		location = new Point(21, 122);
		((Control)textBox7).set_Location(location);
		((Control)TextBox3).set_Name("TextBox3");
		TextBox textBox8 = TextBox3;
		size = new Size(114, 20);
		((Control)textBox8).set_Size(size);
		((Control)TextBox3).set_TabIndex(12);
		TextBox3.set_Text("040000000000000000C0000000040000000000000200408500001000001000000000100000100000000000001000000000000000000000009C4600004F00000000800000C80A00000000000000000000000000000000000000A000000C00000000600000");
		TextBox textBox9 = TextBox6;
		location = new Point(21, 200);
		((Control)textBox9).set_Location(location);
		((Control)TextBox6).set_Name("TextBox6");
		TextBox textBox10 = TextBox6;
		size = new Size(114, 20);
		((Control)textBox10).set_Size(size);
		((Control)TextBox6).set_TabIndex(14);
		TextBox6.set_Text("6F6300000C00000000A0000000020000003A00000000000000000000000000004000004200000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
		TextBox textBox11 = TextBox7;
		location = new Point(21, 226);
		((Control)textBox11).set_Location(location);
		((Control)TextBox7).set_Name("TextBox7");
		TextBox textBox12 = TextBox7;
		size = new Size(114, 20);
		((Control)textBox12).set_Size(size);
		((Control)TextBox7).set_TabIndex(15);
		TextBox7.set_Text("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
		TextBox textBox13 = TextBox4;
		location = new Point(21, 148);
		((Control)textBox13).set_Location(location);
		((Control)TextBox4).set_Name("TextBox4");
		TextBox textBox14 = TextBox4;
		size = new Size(114, 20);
		((Control)textBox14).set_Size(size);
		((Control)TextBox4).set_TabIndex(16);
		TextBox4.set_Text("1C0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000200000080000000000000000000000082000004800000000000000000000002E74657874000000F4260000002000000028000000040000");
		TextBox textBox15 = TextBox8;
		location = new Point(21, 248);
		((Control)textBox15).set_Location(location);
		((Control)TextBox8).set_Name("TextBox8");
		TextBox textBox16 = TextBox8;
		size = new Size(114, 20);
		((Control)textBox16).set_Size(size);
		((Control)TextBox8).set_TabIndex(18);
		TextBox8.set_Text("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
		TextBox textBox17 = TextBox9;
		location = new Point(21, 274);
		((Control)textBox17).set_Location(location);
		((Control)TextBox9).set_Name("TextBox9");
		TextBox textBox18 = TextBox9;
		size = new Size(114, 20);
		((Control)textBox18).set_Size(size);
		((Control)TextBox9).set_TabIndex(19);
		TextBox9.set_Text("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
		TextBox textBox19 = TextBox10;
		location = new Point(21, 300);
		((Control)textBox19).set_Location(location);
		((Control)TextBox10).set_Name("TextBox10");
		TextBox textBox20 = TextBox10;
		size = new Size(114, 20);
		((Control)textBox20).set_Size(size);
		((Control)TextBox10).set_TabIndex(20);
		TextBox10.set_Text("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
		TextBox textBox21 = TextBox11;
		location = new Point(21, 326);
		((Control)textBox21).set_Location(location);
		((Control)TextBox11).set_Name("TextBox11");
		TextBox textBox22 = TextBox11;
		size = new Size(114, 20);
		((Control)textBox22).set_Size(size);
		((Control)TextBox11).set_TabIndex(21);
		TextBox11.set_Text("000000000000000000000000000000000000000000000000D0460000000000004800000002000500502700004C1F0000010000002100000696260000B8000000000000000000000000000000000000000000000000000000000000000000000000000000");
		TextBox textBox23 = TextBox12;
		location = new Point(141, 70);
		((Control)textBox23).set_Location(location);
		((Control)TextBox12).set_Name("TextBox12");
		TextBox textBox24 = TextBox12;
		size = new Size(114, 20);
		((Control)textBox24).set_Size(size);
		((Control)TextBox12).set_TabIndex(22);
		TextBox12.set_Text("000000001E02280100000A2A1E02280400000A2ACE730600000A8001000004730700000A8002000004730800000A8003000004730900000A8004000004730A00000A80050000042A133001000B000000010000117E010000046F0B00000A2A0013300100");
		TextBox textBox25 = TextBox13;
		location = new Point(141, 96);
		((Control)textBox25).set_Location(location);
		((Control)TextBox13).set_Name("TextBox13");
		TextBox textBox26 = TextBox13;
		size = new Size(114, 20);
		((Control)textBox26).set_Size(size);
		((Control)TextBox13).set_TabIndex(23);
		TextBox13.set_Text("0B000000020000117E020000046F0C00000A2A00133001000B000000030000117E030000046F0D00000A2A00133001000B000000040000117E040000046F0E00000A2A00133001000B000000050000117E050000046F0F00000A2A001B300400E2000000");
		TextBox textBox27 = TextBox14;
		location = new Point(141, 122);
		((Control)textBox27).set_Location(location);
		((Control)TextBox14).set_Name("TextBox14");
		TextBox textBox28 = TextBox14;
		size = new Size(114, 20);
		((Control)textBox28).set_Size(size);
		((Control)TextBox14).set_TabIndex(24);
		TextBox14.set_Text("06000011028C0100001B2C120F00FE160100001B6F1300000A39C40000007E060000042C2C7E06000004D00100001B281400000A6F1500000A2C207201000070168D15000001281600000A731700000A7A731800000A80060000047E06000004D0010000");
		TextBox textBox29 = TextBox15;
		location = new Point(141, 148);
		((Control)textBox29).set_Location(location);
		((Control)TextBox15).set_Name("TextBox15");
		TextBox textBox30 = TextBox15;
		size = new Size(114, 20);
		((Control)textBox30).set_Size(size);
		((Control)TextBox15).set_TabIndex(25);
		TextBox15.set_Text("1B281400000A146F1900000A280100002B0ADE6C7512000001252D0426162B16250C281B00000A086F1C00000A14FE0116FE0116FE03FE1126723B000070178D150000010D0916086F1C00000A6F1D00000AA209281600000A0B07086F1C00000A731E00");
		TextBox textBox31 = TextBox16;
		location = new Point(141, 174);
		((Control)textBox31).set_Location(location);
		((Control)TextBox16).set_Name("TextBox16");
		TextBox textBox32 = TextBox16;
		size = new Size(114, 20);
		((Control)textBox32).set_Size(size);
		((Control)TextBox16).set_TabIndex(26);
		TextBox16.set_Text("000A7A7E06000004D00100001B281400000A6F2000000ADC2B02022A062A0000011C000001006C000898002F7400000002006C005BC7001500000001133002001C0000000700001103FE160200001B6F2100000A031200FE150200001B06810200001B2A");
		TextBox textBox33 = TextBox17;
		location = new Point(141, 200);
		((Control)textBox33).set_Location(location);
		((Control)TextBox17).set_Name("TextBox17");
		TextBox textBox34 = TextBox17;
		size = new Size(114, 20);
		((Control)textBox34).set_Size(size);
		((Control)TextBox17).set_TabIndex(27);
		TextBox17.set_Text("1E02282200000A2A133002000D000000080000110203282300000A282400000A2A00000013300100070000000900001102282500000A2A00133001000B0000000A000011D005000002281400000A2A0013300100070000000B00001102282600000A2A00");
		TextBox textBox35 = TextBox18;
		location = new Point(141, 226);
		((Control)textBox35).set_Location(location);
		((Control)TextBox18).set_Name("TextBox18");
		TextBox textBox36 = TextBox18;
		size = new Size(114, 20);
		((Control)textBox36).set_Size(size);
		((Control)TextBox18).set_TabIndex(28);
		TextBox18.set_Text("133002000D0000000C0000110203282300000A282400000A2A00000013300100070000000D00001102282500000A2A00133001000B0000000E000011D006000002281400000A2A0013300100070000000F00001102282600000A2A001330010010000000");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(632, 453);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)TextBox18);
		((Control)this).get_Controls().Add((Control)(object)TextBox17);
		((Control)this).get_Controls().Add((Control)(object)TextBox16);
		((Control)this).get_Controls().Add((Control)(object)TextBox15);
		((Control)this).get_Controls().Add((Control)(object)TextBox14);
		((Control)this).get_Controls().Add((Control)(object)TextBox13);
		((Control)this).get_Controls().Add((Control)(object)TextBox12);
		((Control)this).get_Controls().Add((Control)(object)TextBox11);
		((Control)this).get_Controls().Add((Control)(object)TextBox10);
		((Control)this).get_Controls().Add((Control)(object)TextBox9);
		((Control)this).get_Controls().Add((Control)(object)TextBox8);
		((Control)this).get_Controls().Add((Control)(object)TextBox4);
		((Control)this).get_Controls().Add((Control)(object)TextBox7);
		((Control)this).get_Controls().Add((Control)(object)TextBox6);
		((Control)this).get_Controls().Add((Control)(object)TextBox3);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)TextBox5);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)ToolStrip);
		((Control)this).get_Controls().Add((Control)(object)MenuStrip);
		((Control)this).get_Controls().Add((Control)(object)StatusStrip);
		((Form)this).set_IsMdiContainer(true);
		((Form)this).set_MainMenuStrip(MenuStrip);
		((Control)this).set_Name("MDIParent1");
		((Form)this).set_Text("MDIParent1");
		((Control)MenuStrip).ResumeLayout(false);
		((Control)MenuStrip).PerformLayout();
		((Control)ToolStrip).ResumeLayout(false);
		((Control)ToolStrip).PerformLayout();
		((Control)StatusStrip).ResumeLayout(false);
		((Control)StatusStrip).PerformLayout();
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
		if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
		{
			((FileDialog)val).get_FileName();
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
		if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
		{
			((FileDialog)val).get_FileName();
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
		foreach (Form val in mdiChildren)
		{
			val.Close();
		}
	}
}
