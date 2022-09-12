using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using WindowsApplication5.My;

namespace WindowsApplication5;

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

	[AccessedThroughProperty("BindingNavigator1")]
	private BindingNavigator _BindingNavigator1;

	[AccessedThroughProperty("BindingNavigatorAddNewItem")]
	private ToolStripButton _BindingNavigatorAddNewItem;

	[AccessedThroughProperty("BindingNavigatorCountItem")]
	private ToolStripLabel _BindingNavigatorCountItem;

	[AccessedThroughProperty("BindingNavigatorDeleteItem")]
	private ToolStripButton _BindingNavigatorDeleteItem;

	[AccessedThroughProperty("BindingNavigatorMoveFirstItem")]
	private ToolStripButton _BindingNavigatorMoveFirstItem;

	[AccessedThroughProperty("BindingNavigatorMovePreviousItem")]
	private ToolStripButton _BindingNavigatorMovePreviousItem;

	[AccessedThroughProperty("BindingNavigatorSeparator")]
	private ToolStripSeparator _BindingNavigatorSeparator;

	[AccessedThroughProperty("BindingNavigatorPositionItem")]
	private ToolStripTextBox _BindingNavigatorPositionItem;

	[AccessedThroughProperty("BindingNavigatorSeparator1")]
	private ToolStripSeparator _BindingNavigatorSeparator1;

	[AccessedThroughProperty("BindingNavigatorMoveNextItem")]
	private ToolStripButton _BindingNavigatorMoveNextItem;

	[AccessedThroughProperty("BindingNavigatorMoveLastItem")]
	private ToolStripButton _BindingNavigatorMoveLastItem;

	[AccessedThroughProperty("BindingNavigatorSeparator2")]
	private ToolStripSeparator _BindingNavigatorSeparator2;

	[AccessedThroughProperty("BindingNavigator2")]
	private BindingNavigator _BindingNavigator2;

	[AccessedThroughProperty("BindingNavigatorAddNewItem1")]
	private ToolStripButton _BindingNavigatorAddNewItem1;

	[AccessedThroughProperty("BindingNavigatorCountItem1")]
	private ToolStripLabel _BindingNavigatorCountItem1;

	[AccessedThroughProperty("BindingNavigatorDeleteItem1")]
	private ToolStripButton _BindingNavigatorDeleteItem1;

	[AccessedThroughProperty("BindingNavigatorMoveFirstItem1")]
	private ToolStripButton _BindingNavigatorMoveFirstItem1;

	[AccessedThroughProperty("BindingNavigatorMovePreviousItem1")]
	private ToolStripButton _BindingNavigatorMovePreviousItem1;

	[AccessedThroughProperty("BindingNavigatorSeparator3")]
	private ToolStripSeparator _BindingNavigatorSeparator3;

	[AccessedThroughProperty("BindingNavigatorPositionItem1")]
	private ToolStripTextBox _BindingNavigatorPositionItem1;

	[AccessedThroughProperty("BindingNavigatorSeparator4")]
	private ToolStripSeparator _BindingNavigatorSeparator4;

	[AccessedThroughProperty("BindingNavigatorMoveNextItem1")]
	private ToolStripButton _BindingNavigatorMoveNextItem1;

	[AccessedThroughProperty("BindingNavigatorMoveLastItem1")]
	private ToolStripButton _BindingNavigatorMoveLastItem1;

	[AccessedThroughProperty("BindingNavigatorSeparator5")]
	private ToolStripSeparator _BindingNavigatorSeparator5;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[AccessedThroughProperty("CheckBox2")]
	private CheckBox _CheckBox2;

	[AccessedThroughProperty("CheckedListBox1")]
	private CheckedListBox _CheckedListBox1;

	[AccessedThroughProperty("CheckedListBox2")]
	private CheckedListBox _CheckedListBox2;

	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

	[AccessedThroughProperty("ComboBox2")]
	private ComboBox _ComboBox2;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("DataGridView2")]
	private DataGridView _DataGridView2;

	[AccessedThroughProperty("DataGridView3")]
	private DataGridView _DataGridView3;

	[AccessedThroughProperty("DataGridView4")]
	private DataGridView _DataGridView4;

	[AccessedThroughProperty("DataGridView5")]
	private DataGridView _DataGridView5;

	[AccessedThroughProperty("ErrorProvider1")]
	private ErrorProvider _ErrorProvider1;

	[AccessedThroughProperty("WebBrowser7")]
	private WebBrowser _WebBrowser7;

	[AccessedThroughProperty("WebBrowser6")]
	private WebBrowser _WebBrowser6;

	[AccessedThroughProperty("WebBrowser5")]
	private WebBrowser _WebBrowser5;

	[AccessedThroughProperty("WebBrowser4")]
	private WebBrowser _WebBrowser4;

	[AccessedThroughProperty("WebBrowser3")]
	private WebBrowser _WebBrowser3;

	[AccessedThroughProperty("WebBrowser2")]
	private WebBrowser _WebBrowser2;

	[AccessedThroughProperty("WebBrowser1")]
	private WebBrowser _WebBrowser1;

	[AccessedThroughProperty("RadioButton5")]
	private RadioButton _RadioButton5;

	[AccessedThroughProperty("RadioButton4")]
	private RadioButton _RadioButton4;

	[AccessedThroughProperty("RadioButton3")]
	private RadioButton _RadioButton3;

	[AccessedThroughProperty("RadioButton2")]
	private RadioButton _RadioButton2;

	[AccessedThroughProperty("RadioButton1")]
	private RadioButton _RadioButton1;

	[AccessedThroughProperty("ProgressBar3")]
	private ProgressBar _ProgressBar3;

	[AccessedThroughProperty("ProgressBar2")]
	private ProgressBar _ProgressBar2;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("ErrorProvider2")]
	private ErrorProvider _ErrorProvider2;

	[AccessedThroughProperty("ErrorProvider3")]
	private ErrorProvider _ErrorProvider3;

	[AccessedThroughProperty("PrintPreviewDialog1")]
	private PrintPreviewDialog _PrintPreviewDialog1;

	[AccessedThroughProperty("Process1")]
	private Process _Process1;

	[AccessedThroughProperty("Process2")]
	private Process _Process2;

	[AccessedThroughProperty("Process3")]
	private Process _Process3;

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

	internal virtual BindingNavigator BindingNavigator1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigator1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigator1 = value;
		}
	}

	internal virtual ToolStripButton BindingNavigatorAddNewItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorAddNewItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorAddNewItem = value;
		}
	}

	internal virtual ToolStripLabel BindingNavigatorCountItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorCountItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorCountItem = value;
		}
	}

	internal virtual ToolStripButton BindingNavigatorDeleteItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorDeleteItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorDeleteItem = value;
		}
	}

	internal virtual ToolStripButton BindingNavigatorMoveFirstItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorMoveFirstItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorMoveFirstItem = value;
		}
	}

	internal virtual ToolStripButton BindingNavigatorMovePreviousItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorMovePreviousItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorMovePreviousItem = value;
		}
	}

	internal virtual ToolStripSeparator BindingNavigatorSeparator
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorSeparator;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorSeparator = value;
		}
	}

	internal virtual ToolStripTextBox BindingNavigatorPositionItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorPositionItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorPositionItem = value;
		}
	}

	internal virtual ToolStripSeparator BindingNavigatorSeparator1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorSeparator1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorSeparator1 = value;
		}
	}

	internal virtual ToolStripButton BindingNavigatorMoveNextItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorMoveNextItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorMoveNextItem = value;
		}
	}

	internal virtual ToolStripButton BindingNavigatorMoveLastItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorMoveLastItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorMoveLastItem = value;
		}
	}

	internal virtual ToolStripSeparator BindingNavigatorSeparator2
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorSeparator2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorSeparator2 = value;
		}
	}

	internal virtual BindingNavigator BindingNavigator2
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigator2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigator2 = value;
		}
	}

	internal virtual ToolStripButton BindingNavigatorAddNewItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorAddNewItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorAddNewItem1 = value;
		}
	}

	internal virtual ToolStripLabel BindingNavigatorCountItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorCountItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorCountItem1 = value;
		}
	}

	internal virtual ToolStripButton BindingNavigatorDeleteItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorDeleteItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorDeleteItem1 = value;
		}
	}

	internal virtual ToolStripButton BindingNavigatorMoveFirstItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorMoveFirstItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorMoveFirstItem1 = value;
		}
	}

	internal virtual ToolStripButton BindingNavigatorMovePreviousItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorMovePreviousItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorMovePreviousItem1 = value;
		}
	}

	internal virtual ToolStripSeparator BindingNavigatorSeparator3
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorSeparator3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorSeparator3 = value;
		}
	}

	internal virtual ToolStripTextBox BindingNavigatorPositionItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorPositionItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorPositionItem1 = value;
		}
	}

	internal virtual ToolStripSeparator BindingNavigatorSeparator4
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorSeparator4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorSeparator4 = value;
		}
	}

	internal virtual ToolStripButton BindingNavigatorMoveNextItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorMoveNextItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorMoveNextItem1 = value;
		}
	}

	internal virtual ToolStripButton BindingNavigatorMoveLastItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorMoveLastItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorMoveLastItem1 = value;
		}
	}

	internal virtual ToolStripSeparator BindingNavigatorSeparator5
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorSeparator5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorSeparator5 = value;
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
			_Button1 = value;
		}
	}

	internal virtual Button Button2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button2 = value;
		}
	}

	internal virtual Button Button3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button3 = value;
		}
	}

	internal virtual Button Button4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button4 = value;
		}
	}

	internal virtual CheckBox CheckBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox1 = value;
		}
	}

	internal virtual CheckBox CheckBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox2 = value;
		}
	}

	internal virtual CheckedListBox CheckedListBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckedListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckedListBox1 = value;
		}
	}

	internal virtual CheckedListBox CheckedListBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckedListBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckedListBox2 = value;
		}
	}

	internal virtual ComboBox ComboBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ComboBox1 = value;
		}
	}

	internal virtual ComboBox ComboBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ComboBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ComboBox2 = value;
		}
	}

	internal virtual DataGridView DataGridView1
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridView1 = value;
		}
	}

	internal virtual DataGridView DataGridView2
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridView2 = value;
		}
	}

	internal virtual DataGridView DataGridView3
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridView3 = value;
		}
	}

	internal virtual DataGridView DataGridView4
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridView4 = value;
		}
	}

	internal virtual DataGridView DataGridView5
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridView5 = value;
		}
	}

	internal virtual ErrorProvider ErrorProvider1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ErrorProvider1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ErrorProvider1 = value;
		}
	}

	internal virtual WebBrowser WebBrowser7
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WebBrowser7 = value;
		}
	}

	internal virtual WebBrowser WebBrowser6
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WebBrowser6 = value;
		}
	}

	internal virtual WebBrowser WebBrowser5
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WebBrowser5 = value;
		}
	}

	internal virtual WebBrowser WebBrowser4
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WebBrowser4 = value;
		}
	}

	internal virtual WebBrowser WebBrowser3
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WebBrowser3 = value;
		}
	}

	internal virtual WebBrowser WebBrowser2
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WebBrowser2 = value;
		}
	}

	internal virtual WebBrowser WebBrowser1
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WebBrowser1 = value;
		}
	}

	internal virtual RadioButton RadioButton5
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RadioButton5 = value;
		}
	}

	internal virtual RadioButton RadioButton4
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RadioButton4 = value;
		}
	}

	internal virtual RadioButton RadioButton3
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RadioButton3 = value;
		}
	}

	internal virtual RadioButton RadioButton2
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RadioButton2 = value;
		}
	}

	internal virtual RadioButton RadioButton1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RadioButton1 = value;
		}
	}

	internal virtual ProgressBar ProgressBar3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ProgressBar3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ProgressBar3 = value;
		}
	}

	internal virtual ProgressBar ProgressBar2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ProgressBar2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ProgressBar2 = value;
		}
	}

	internal virtual ProgressBar ProgressBar1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ProgressBar1 = value;
		}
	}

	internal virtual PictureBox PictureBox5
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox5 = value;
		}
	}

	internal virtual PictureBox PictureBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox4 = value;
		}
	}

	internal virtual PictureBox PictureBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox3 = value;
		}
	}

	internal virtual PictureBox PictureBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox2 = value;
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

	internal virtual ErrorProvider ErrorProvider2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ErrorProvider2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ErrorProvider2 = value;
		}
	}

	internal virtual ErrorProvider ErrorProvider3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ErrorProvider3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ErrorProvider3 = value;
		}
	}

	internal virtual PrintPreviewDialog PrintPreviewDialog1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewDialog1 = value;
		}
	}

	internal virtual Process Process1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Process1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Process1 = value;
		}
	}

	internal virtual Process Process2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Process2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Process2 = value;
		}
	}

	internal virtual Process Process3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Process3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Process3 = value;
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
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected O, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected O, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected O, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected O, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected O, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected O, but got Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected O, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected O, but got Unknown
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected O, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected O, but got Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected O, but got Unknown
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected O, but got Unknown
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected O, but got Unknown
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected O, but got Unknown
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected O, but got Unknown
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Expected O, but got Unknown
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected O, but got Unknown
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected O, but got Unknown
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected O, but got Unknown
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected O, but got Unknown
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected O, but got Unknown
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected O, but got Unknown
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected O, but got Unknown
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected O, but got Unknown
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected O, but got Unknown
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected O, but got Unknown
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Expected O, but got Unknown
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected O, but got Unknown
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected O, but got Unknown
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected O, but got Unknown
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected O, but got Unknown
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected O, but got Unknown
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Expected O, but got Unknown
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected O, but got Unknown
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected O, but got Unknown
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Expected O, but got Unknown
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected O, but got Unknown
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected O, but got Unknown
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected O, but got Unknown
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected O, but got Unknown
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected O, but got Unknown
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Expected O, but got Unknown
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Expected O, but got Unknown
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Expected O, but got Unknown
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Expected O, but got Unknown
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected O, but got Unknown
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Expected O, but got Unknown
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Expected O, but got Unknown
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Expected O, but got Unknown
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Expected O, but got Unknown
		//IL_07c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cf: Expected O, but got Unknown
		//IL_083b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0845: Expected O, but got Unknown
		//IL_08db: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e5: Expected O, but got Unknown
		//IL_09b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c0: Expected O, but got Unknown
		//IL_0a2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a36: Expected O, but got Unknown
		//IL_0bca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd4: Expected O, but got Unknown
		//IL_0c40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4a: Expected O, but got Unknown
		//IL_0ce0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cea: Expected O, but got Unknown
		//IL_0d56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d60: Expected O, but got Unknown
		//IL_0dcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd6: Expected O, but got Unknown
		//IL_1312: Unknown result type (might be due to invalid IL or missing references)
		//IL_131c: Expected O, but got Unknown
		//IL_1378: Unknown result type (might be due to invalid IL or missing references)
		//IL_1382: Expected O, but got Unknown
		//IL_150c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1516: Expected O, but got Unknown
		//IL_157b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1585: Expected O, but got Unknown
		//IL_15ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f4: Expected O, but got Unknown
		//IL_1680: Unknown result type (might be due to invalid IL or missing references)
		//IL_168a: Expected O, but got Unknown
		//IL_16ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f9: Expected O, but got Unknown
		//IL_1785: Unknown result type (might be due to invalid IL or missing references)
		//IL_178f: Expected O, but got Unknown
		//IL_1a11: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a1b: Expected O, but got Unknown
		//IL_1a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a86: Expected O, but got Unknown
		//IL_1be1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1beb: Expected O, but got Unknown
		//IL_1c4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c56: Expected O, but got Unknown
		//IL_1cde: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce8: Expected O, but got Unknown
		//IL_1d49: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d53: Expected O, but got Unknown
		//IL_1f18: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f22: Expected O, but got Unknown
		//IL_1f83: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f8d: Expected O, but got Unknown
		//IL_20e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_20f2: Expected O, but got Unknown
		//IL_2153: Unknown result type (might be due to invalid IL or missing references)
		//IL_215d: Expected O, but got Unknown
		//IL_21e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ef: Expected O, but got Unknown
		//IL_2250: Unknown result type (might be due to invalid IL or missing references)
		//IL_225a: Expected O, but got Unknown
		//IL_2ab5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2abf: Expected O, but got Unknown
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
		BindingNavigator1 = new BindingNavigator(components);
		BindingNavigatorMoveFirstItem = new ToolStripButton();
		BindingNavigatorMovePreviousItem = new ToolStripButton();
		BindingNavigatorSeparator = new ToolStripSeparator();
		BindingNavigatorPositionItem = new ToolStripTextBox();
		BindingNavigatorCountItem = new ToolStripLabel();
		BindingNavigatorSeparator1 = new ToolStripSeparator();
		BindingNavigatorMoveNextItem = new ToolStripButton();
		BindingNavigatorMoveLastItem = new ToolStripButton();
		BindingNavigatorSeparator2 = new ToolStripSeparator();
		BindingNavigatorAddNewItem = new ToolStripButton();
		BindingNavigatorDeleteItem = new ToolStripButton();
		BindingNavigator2 = new BindingNavigator(components);
		BindingNavigatorMoveFirstItem1 = new ToolStripButton();
		BindingNavigatorMovePreviousItem1 = new ToolStripButton();
		BindingNavigatorSeparator3 = new ToolStripSeparator();
		BindingNavigatorPositionItem1 = new ToolStripTextBox();
		BindingNavigatorCountItem1 = new ToolStripLabel();
		BindingNavigatorSeparator4 = new ToolStripSeparator();
		BindingNavigatorMoveNextItem1 = new ToolStripButton();
		BindingNavigatorMoveLastItem1 = new ToolStripButton();
		BindingNavigatorSeparator5 = new ToolStripSeparator();
		BindingNavigatorAddNewItem1 = new ToolStripButton();
		BindingNavigatorDeleteItem1 = new ToolStripButton();
		Button1 = new Button();
		Button2 = new Button();
		Button3 = new Button();
		Button4 = new Button();
		CheckBox1 = new CheckBox();
		CheckBox2 = new CheckBox();
		CheckedListBox1 = new CheckedListBox();
		CheckedListBox2 = new CheckedListBox();
		ComboBox1 = new ComboBox();
		ComboBox2 = new ComboBox();
		DataGridView1 = new DataGridView();
		DataGridView2 = new DataGridView();
		DataGridView3 = new DataGridView();
		DataGridView4 = new DataGridView();
		DataGridView5 = new DataGridView();
		ErrorProvider1 = new ErrorProvider(components);
		ErrorProvider2 = new ErrorProvider(components);
		ErrorProvider3 = new ErrorProvider(components);
		PictureBox1 = new PictureBox();
		PictureBox2 = new PictureBox();
		PictureBox3 = new PictureBox();
		PictureBox4 = new PictureBox();
		PictureBox5 = new PictureBox();
		PrintPreviewDialog1 = new PrintPreviewDialog();
		Process1 = new Process();
		Process2 = new Process();
		Process3 = new Process();
		ProgressBar1 = new ProgressBar();
		ProgressBar2 = new ProgressBar();
		ProgressBar3 = new ProgressBar();
		RadioButton1 = new RadioButton();
		RadioButton2 = new RadioButton();
		RadioButton3 = new RadioButton();
		RadioButton4 = new RadioButton();
		RadioButton5 = new RadioButton();
		WebBrowser1 = new WebBrowser();
		WebBrowser2 = new WebBrowser();
		WebBrowser3 = new WebBrowser();
		WebBrowser4 = new WebBrowser();
		WebBrowser5 = new WebBrowser();
		WebBrowser6 = new WebBrowser();
		WebBrowser7 = new WebBrowser();
		((Control)MenuStrip).SuspendLayout();
		((Control)ToolStrip).SuspendLayout();
		((Control)StatusStrip).SuspendLayout();
		((ISupportInitialize)BindingNavigator1).BeginInit();
		((Control)BindingNavigator1).SuspendLayout();
		((ISupportInitialize)BindingNavigator2).BeginInit();
		((Control)BindingNavigator2).SuspendLayout();
		((ISupportInitialize)DataGridView1).BeginInit();
		((ISupportInitialize)DataGridView2).BeginInit();
		((ISupportInitialize)DataGridView3).BeginInit();
		((ISupportInitialize)DataGridView4).BeginInit();
		((ISupportInitialize)DataGridView5).BeginInit();
		((ISupportInitialize)ErrorProvider1).BeginInit();
		((ISupportInitialize)ErrorProvider2).BeginInit();
		((ISupportInitialize)ErrorProvider3).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox4).BeginInit();
		((ISupportInitialize)PictureBox5).BeginInit();
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
		BindingNavigator1.set_AddNewItem((ToolStripItem)(object)BindingNavigatorAddNewItem);
		BindingNavigator1.set_CountItem((ToolStripItem)(object)BindingNavigatorCountItem);
		BindingNavigator1.set_DeleteItem((ToolStripItem)(object)BindingNavigatorDeleteItem);
		((ToolStrip)BindingNavigator1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)BindingNavigatorMoveFirstItem,
			(ToolStripItem)BindingNavigatorMovePreviousItem,
			(ToolStripItem)BindingNavigatorSeparator,
			(ToolStripItem)BindingNavigatorPositionItem,
			(ToolStripItem)BindingNavigatorCountItem,
			(ToolStripItem)BindingNavigatorSeparator1,
			(ToolStripItem)BindingNavigatorMoveNextItem,
			(ToolStripItem)BindingNavigatorMoveLastItem,
			(ToolStripItem)BindingNavigatorSeparator2,
			(ToolStripItem)BindingNavigatorAddNewItem,
			(ToolStripItem)BindingNavigatorDeleteItem
		});
		BindingNavigator bindingNavigator = BindingNavigator1;
		location = new Point(0, 49);
		((Control)bindingNavigator).set_Location(location);
		BindingNavigator1.set_MoveFirstItem((ToolStripItem)(object)BindingNavigatorMoveFirstItem);
		BindingNavigator1.set_MoveLastItem((ToolStripItem)(object)BindingNavigatorMoveLastItem);
		BindingNavigator1.set_MoveNextItem((ToolStripItem)(object)BindingNavigatorMoveNextItem);
		BindingNavigator1.set_MovePreviousItem((ToolStripItem)(object)BindingNavigatorMovePreviousItem);
		((Control)BindingNavigator1).set_Name("BindingNavigator1");
		BindingNavigator1.set_PositionItem((ToolStripItem)(object)BindingNavigatorPositionItem);
		BindingNavigator bindingNavigator2 = BindingNavigator1;
		size = new Size(632, 25);
		((Control)bindingNavigator2).set_Size(size);
		((Control)BindingNavigator1).set_TabIndex(9);
		((Control)BindingNavigator1).set_Text("BindingNavigator1");
		((ToolStripItem)BindingNavigatorMoveFirstItem).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)BindingNavigatorMoveFirstItem).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveFirstItem.Image"));
		((ToolStripItem)BindingNavigatorMoveFirstItem).set_Name("BindingNavigatorMoveFirstItem");
		((ToolStripItem)BindingNavigatorMoveFirstItem).set_RightToLeftAutoMirrorImage(true);
		ToolStripButton bindingNavigatorMoveFirstItem = BindingNavigatorMoveFirstItem;
		size = new Size(23, 22);
		((ToolStripItem)bindingNavigatorMoveFirstItem).set_Size(size);
		((ToolStripItem)BindingNavigatorMoveFirstItem).set_Text("Move first");
		((ToolStripItem)BindingNavigatorMovePreviousItem).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)BindingNavigatorMovePreviousItem).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMovePreviousItem.Image"));
		((ToolStripItem)BindingNavigatorMovePreviousItem).set_Name("BindingNavigatorMovePreviousItem");
		((ToolStripItem)BindingNavigatorMovePreviousItem).set_RightToLeftAutoMirrorImage(true);
		ToolStripButton bindingNavigatorMovePreviousItem = BindingNavigatorMovePreviousItem;
		size = new Size(23, 22);
		((ToolStripItem)bindingNavigatorMovePreviousItem).set_Size(size);
		((ToolStripItem)BindingNavigatorMovePreviousItem).set_Text("Move previous");
		((ToolStripItem)BindingNavigatorSeparator).set_Name("BindingNavigatorSeparator");
		ToolStripSeparator bindingNavigatorSeparator = BindingNavigatorSeparator;
		size = new Size(6, 25);
		((ToolStripItem)bindingNavigatorSeparator).set_Size(size);
		((ToolStripItem)BindingNavigatorPositionItem).set_AccessibleName("Position");
		((ToolStripItem)BindingNavigatorPositionItem).set_AutoSize(false);
		((ToolStripItem)BindingNavigatorPositionItem).set_Name("BindingNavigatorPositionItem");
		ToolStripTextBox bindingNavigatorPositionItem = BindingNavigatorPositionItem;
		size = new Size(50, 23);
		((ToolStripControlHost)bindingNavigatorPositionItem).set_Size(size);
		((ToolStripControlHost)BindingNavigatorPositionItem).set_Text("0");
		((ToolStripItem)BindingNavigatorPositionItem).set_ToolTipText("Current position");
		((ToolStripItem)BindingNavigatorCountItem).set_Name("BindingNavigatorCountItem");
		ToolStripLabel bindingNavigatorCountItem = BindingNavigatorCountItem;
		size = new Size(35, 22);
		((ToolStripItem)bindingNavigatorCountItem).set_Size(size);
		((ToolStripItem)BindingNavigatorCountItem).set_Text("of {0}");
		((ToolStripItem)BindingNavigatorCountItem).set_ToolTipText("Total number of items");
		((ToolStripItem)BindingNavigatorSeparator1).set_Name("BindingNavigatorSeparator");
		ToolStripSeparator bindingNavigatorSeparator2 = BindingNavigatorSeparator1;
		size = new Size(6, 25);
		((ToolStripItem)bindingNavigatorSeparator2).set_Size(size);
		((ToolStripItem)BindingNavigatorMoveNextItem).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)BindingNavigatorMoveNextItem).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveNextItem.Image"));
		((ToolStripItem)BindingNavigatorMoveNextItem).set_Name("BindingNavigatorMoveNextItem");
		((ToolStripItem)BindingNavigatorMoveNextItem).set_RightToLeftAutoMirrorImage(true);
		ToolStripButton bindingNavigatorMoveNextItem = BindingNavigatorMoveNextItem;
		size = new Size(23, 22);
		((ToolStripItem)bindingNavigatorMoveNextItem).set_Size(size);
		((ToolStripItem)BindingNavigatorMoveNextItem).set_Text("Move next");
		((ToolStripItem)BindingNavigatorMoveLastItem).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)BindingNavigatorMoveLastItem).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveLastItem.Image"));
		((ToolStripItem)BindingNavigatorMoveLastItem).set_Name("BindingNavigatorMoveLastItem");
		((ToolStripItem)BindingNavigatorMoveLastItem).set_RightToLeftAutoMirrorImage(true);
		ToolStripButton bindingNavigatorMoveLastItem = BindingNavigatorMoveLastItem;
		size = new Size(23, 22);
		((ToolStripItem)bindingNavigatorMoveLastItem).set_Size(size);
		((ToolStripItem)BindingNavigatorMoveLastItem).set_Text("Move last");
		((ToolStripItem)BindingNavigatorSeparator2).set_Name("BindingNavigatorSeparator");
		ToolStripSeparator bindingNavigatorSeparator3 = BindingNavigatorSeparator2;
		size = new Size(6, 25);
		((ToolStripItem)bindingNavigatorSeparator3).set_Size(size);
		((ToolStripItem)BindingNavigatorAddNewItem).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)BindingNavigatorAddNewItem).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorAddNewItem.Image"));
		((ToolStripItem)BindingNavigatorAddNewItem).set_Name("BindingNavigatorAddNewItem");
		((ToolStripItem)BindingNavigatorAddNewItem).set_RightToLeftAutoMirrorImage(true);
		ToolStripButton bindingNavigatorAddNewItem = BindingNavigatorAddNewItem;
		size = new Size(23, 22);
		((ToolStripItem)bindingNavigatorAddNewItem).set_Size(size);
		((ToolStripItem)BindingNavigatorAddNewItem).set_Text("Add new");
		((ToolStripItem)BindingNavigatorDeleteItem).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)BindingNavigatorDeleteItem).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorDeleteItem.Image"));
		((ToolStripItem)BindingNavigatorDeleteItem).set_Name("BindingNavigatorDeleteItem");
		((ToolStripItem)BindingNavigatorDeleteItem).set_RightToLeftAutoMirrorImage(true);
		ToolStripButton bindingNavigatorDeleteItem = BindingNavigatorDeleteItem;
		size = new Size(23, 22);
		((ToolStripItem)bindingNavigatorDeleteItem).set_Size(size);
		((ToolStripItem)BindingNavigatorDeleteItem).set_Text("Delete");
		BindingNavigator2.set_AddNewItem((ToolStripItem)(object)BindingNavigatorAddNewItem1);
		BindingNavigator2.set_CountItem((ToolStripItem)(object)BindingNavigatorCountItem1);
		BindingNavigator2.set_DeleteItem((ToolStripItem)(object)BindingNavigatorDeleteItem1);
		((ToolStrip)BindingNavigator2).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)BindingNavigatorMoveFirstItem1,
			(ToolStripItem)BindingNavigatorMovePreviousItem1,
			(ToolStripItem)BindingNavigatorSeparator3,
			(ToolStripItem)BindingNavigatorPositionItem1,
			(ToolStripItem)BindingNavigatorCountItem1,
			(ToolStripItem)BindingNavigatorSeparator4,
			(ToolStripItem)BindingNavigatorMoveNextItem1,
			(ToolStripItem)BindingNavigatorMoveLastItem1,
			(ToolStripItem)BindingNavigatorSeparator5,
			(ToolStripItem)BindingNavigatorAddNewItem1,
			(ToolStripItem)BindingNavigatorDeleteItem1
		});
		BindingNavigator bindingNavigator3 = BindingNavigator2;
		location = new Point(0, 74);
		((Control)bindingNavigator3).set_Location(location);
		BindingNavigator2.set_MoveFirstItem((ToolStripItem)(object)BindingNavigatorMoveFirstItem1);
		BindingNavigator2.set_MoveLastItem((ToolStripItem)(object)BindingNavigatorMoveLastItem1);
		BindingNavigator2.set_MoveNextItem((ToolStripItem)(object)BindingNavigatorMoveNextItem1);
		BindingNavigator2.set_MovePreviousItem((ToolStripItem)(object)BindingNavigatorMovePreviousItem1);
		((Control)BindingNavigator2).set_Name("BindingNavigator2");
		BindingNavigator2.set_PositionItem((ToolStripItem)(object)BindingNavigatorPositionItem1);
		BindingNavigator bindingNavigator4 = BindingNavigator2;
		size = new Size(632, 25);
		((Control)bindingNavigator4).set_Size(size);
		((Control)BindingNavigator2).set_TabIndex(10);
		((Control)BindingNavigator2).set_Text("BindingNavigator2");
		((ToolStripItem)BindingNavigatorMoveFirstItem1).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)BindingNavigatorMoveFirstItem1).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveFirstItem1.Image"));
		((ToolStripItem)BindingNavigatorMoveFirstItem1).set_Name("BindingNavigatorMoveFirstItem");
		((ToolStripItem)BindingNavigatorMoveFirstItem1).set_RightToLeftAutoMirrorImage(true);
		ToolStripButton bindingNavigatorMoveFirstItem2 = BindingNavigatorMoveFirstItem1;
		size = new Size(23, 22);
		((ToolStripItem)bindingNavigatorMoveFirstItem2).set_Size(size);
		((ToolStripItem)BindingNavigatorMoveFirstItem1).set_Text("Move first");
		((ToolStripItem)BindingNavigatorMovePreviousItem1).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)BindingNavigatorMovePreviousItem1).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMovePreviousItem1.Image"));
		((ToolStripItem)BindingNavigatorMovePreviousItem1).set_Name("BindingNavigatorMovePreviousItem");
		((ToolStripItem)BindingNavigatorMovePreviousItem1).set_RightToLeftAutoMirrorImage(true);
		ToolStripButton bindingNavigatorMovePreviousItem2 = BindingNavigatorMovePreviousItem1;
		size = new Size(23, 22);
		((ToolStripItem)bindingNavigatorMovePreviousItem2).set_Size(size);
		((ToolStripItem)BindingNavigatorMovePreviousItem1).set_Text("Move previous");
		((ToolStripItem)BindingNavigatorSeparator3).set_Name("BindingNavigatorSeparator");
		ToolStripSeparator bindingNavigatorSeparator4 = BindingNavigatorSeparator3;
		size = new Size(6, 25);
		((ToolStripItem)bindingNavigatorSeparator4).set_Size(size);
		((ToolStripItem)BindingNavigatorPositionItem1).set_AccessibleName("Position");
		((ToolStripItem)BindingNavigatorPositionItem1).set_AutoSize(false);
		((ToolStripItem)BindingNavigatorPositionItem1).set_Name("BindingNavigatorPositionItem");
		ToolStripTextBox bindingNavigatorPositionItem2 = BindingNavigatorPositionItem1;
		size = new Size(50, 23);
		((ToolStripControlHost)bindingNavigatorPositionItem2).set_Size(size);
		((ToolStripControlHost)BindingNavigatorPositionItem1).set_Text("0");
		((ToolStripItem)BindingNavigatorPositionItem1).set_ToolTipText("Current position");
		((ToolStripItem)BindingNavigatorCountItem1).set_Name("BindingNavigatorCountItem");
		ToolStripLabel bindingNavigatorCountItem2 = BindingNavigatorCountItem1;
		size = new Size(35, 22);
		((ToolStripItem)bindingNavigatorCountItem2).set_Size(size);
		((ToolStripItem)BindingNavigatorCountItem1).set_Text("of {0}");
		((ToolStripItem)BindingNavigatorCountItem1).set_ToolTipText("Total number of items");
		((ToolStripItem)BindingNavigatorSeparator4).set_Name("BindingNavigatorSeparator");
		ToolStripSeparator bindingNavigatorSeparator5 = BindingNavigatorSeparator4;
		size = new Size(6, 25);
		((ToolStripItem)bindingNavigatorSeparator5).set_Size(size);
		((ToolStripItem)BindingNavigatorMoveNextItem1).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)BindingNavigatorMoveNextItem1).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveNextItem1.Image"));
		((ToolStripItem)BindingNavigatorMoveNextItem1).set_Name("BindingNavigatorMoveNextItem");
		((ToolStripItem)BindingNavigatorMoveNextItem1).set_RightToLeftAutoMirrorImage(true);
		ToolStripButton bindingNavigatorMoveNextItem2 = BindingNavigatorMoveNextItem1;
		size = new Size(23, 22);
		((ToolStripItem)bindingNavigatorMoveNextItem2).set_Size(size);
		((ToolStripItem)BindingNavigatorMoveNextItem1).set_Text("Move next");
		((ToolStripItem)BindingNavigatorMoveLastItem1).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)BindingNavigatorMoveLastItem1).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveLastItem1.Image"));
		((ToolStripItem)BindingNavigatorMoveLastItem1).set_Name("BindingNavigatorMoveLastItem");
		((ToolStripItem)BindingNavigatorMoveLastItem1).set_RightToLeftAutoMirrorImage(true);
		ToolStripButton bindingNavigatorMoveLastItem2 = BindingNavigatorMoveLastItem1;
		size = new Size(23, 22);
		((ToolStripItem)bindingNavigatorMoveLastItem2).set_Size(size);
		((ToolStripItem)BindingNavigatorMoveLastItem1).set_Text("Move last");
		((ToolStripItem)BindingNavigatorSeparator5).set_Name("BindingNavigatorSeparator");
		ToolStripSeparator bindingNavigatorSeparator6 = BindingNavigatorSeparator5;
		size = new Size(6, 25);
		((ToolStripItem)bindingNavigatorSeparator6).set_Size(size);
		((ToolStripItem)BindingNavigatorAddNewItem1).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)BindingNavigatorAddNewItem1).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorAddNewItem1.Image"));
		((ToolStripItem)BindingNavigatorAddNewItem1).set_Name("BindingNavigatorAddNewItem");
		((ToolStripItem)BindingNavigatorAddNewItem1).set_RightToLeftAutoMirrorImage(true);
		ToolStripButton bindingNavigatorAddNewItem2 = BindingNavigatorAddNewItem1;
		size = new Size(23, 22);
		((ToolStripItem)bindingNavigatorAddNewItem2).set_Size(size);
		((ToolStripItem)BindingNavigatorAddNewItem1).set_Text("Add new");
		((ToolStripItem)BindingNavigatorDeleteItem1).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)BindingNavigatorDeleteItem1).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorDeleteItem1.Image"));
		((ToolStripItem)BindingNavigatorDeleteItem1).set_Name("BindingNavigatorDeleteItem");
		((ToolStripItem)BindingNavigatorDeleteItem1).set_RightToLeftAutoMirrorImage(true);
		ToolStripButton bindingNavigatorDeleteItem2 = BindingNavigatorDeleteItem1;
		size = new Size(23, 22);
		((ToolStripItem)bindingNavigatorDeleteItem2).set_Size(size);
		((ToolStripItem)BindingNavigatorDeleteItem1).set_Text("Delete");
		Button button = Button1;
		location = new Point(8, 82);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(11);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Button button3 = Button2;
		location = new Point(16, 90);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(75, 23);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(12);
		((ButtonBase)Button2).set_Text("Button2");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		Button button5 = Button3;
		location = new Point(24, 98);
		((Control)button5).set_Location(location);
		((Control)Button3).set_Name("Button3");
		Button button6 = Button3;
		size = new Size(75, 23);
		((Control)button6).set_Size(size);
		((Control)Button3).set_TabIndex(13);
		((ButtonBase)Button3).set_Text("Button3");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		Button button7 = Button4;
		location = new Point(32, 106);
		((Control)button7).set_Location(location);
		((Control)Button4).set_Name("Button4");
		Button button8 = Button4;
		size = new Size(75, 23);
		((Control)button8).set_Size(size);
		((Control)Button4).set_TabIndex(14);
		((ButtonBase)Button4).set_Text("Button4");
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox1).set_AutoSize(true);
		CheckBox checkBox = CheckBox1;
		location = new Point(40, 114);
		((Control)checkBox).set_Location(location);
		((Control)CheckBox1).set_Name("CheckBox1");
		CheckBox checkBox2 = CheckBox1;
		size = new Size(79, 17);
		((Control)checkBox2).set_Size(size);
		((Control)CheckBox1).set_TabIndex(15);
		((ButtonBase)CheckBox1).set_Text("CheckBox1");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox2).set_AutoSize(true);
		CheckBox checkBox3 = CheckBox2;
		location = new Point(48, 122);
		((Control)checkBox3).set_Location(location);
		((Control)CheckBox2).set_Name("CheckBox2");
		CheckBox checkBox4 = CheckBox2;
		size = new Size(79, 17);
		((Control)checkBox4).set_Size(size);
		((Control)CheckBox2).set_TabIndex(16);
		((ButtonBase)CheckBox2).set_Text("CheckBox2");
		((ButtonBase)CheckBox2).set_UseVisualStyleBackColor(true);
		((ListControl)CheckedListBox1).set_FormattingEnabled(true);
		CheckedListBox checkedListBox = CheckedListBox1;
		location = new Point(56, 130);
		((Control)checkedListBox).set_Location(location);
		((Control)CheckedListBox1).set_Name("CheckedListBox1");
		CheckedListBox checkedListBox2 = CheckedListBox1;
		size = new Size(120, 94);
		((Control)checkedListBox2).set_Size(size);
		((Control)CheckedListBox1).set_TabIndex(17);
		((ListControl)CheckedListBox2).set_FormattingEnabled(true);
		CheckedListBox checkedListBox3 = CheckedListBox2;
		location = new Point(64, 138);
		((Control)checkedListBox3).set_Location(location);
		((Control)CheckedListBox2).set_Name("CheckedListBox2");
		CheckedListBox checkedListBox4 = CheckedListBox2;
		size = new Size(120, 94);
		((Control)checkedListBox4).set_Size(size);
		((Control)CheckedListBox2).set_TabIndex(18);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		ComboBox comboBox = ComboBox1;
		location = new Point(72, 146);
		((Control)comboBox).set_Location(location);
		((Control)ComboBox1).set_Name("ComboBox1");
		ComboBox comboBox2 = ComboBox1;
		size = new Size(121, 21);
		((Control)comboBox2).set_Size(size);
		((Control)ComboBox1).set_TabIndex(19);
		((ListControl)ComboBox2).set_FormattingEnabled(true);
		ComboBox comboBox3 = ComboBox2;
		location = new Point(80, 154);
		((Control)comboBox3).set_Location(location);
		((Control)ComboBox2).set_Name("ComboBox2");
		ComboBox comboBox4 = ComboBox2;
		size = new Size(121, 21);
		((Control)comboBox4).set_Size(size);
		((Control)ComboBox2).set_TabIndex(20);
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		DataGridView dataGridView = DataGridView1;
		location = new Point(88, 162);
		((Control)dataGridView).set_Location(location);
		((Control)DataGridView1).set_Name("DataGridView1");
		DataGridView dataGridView2 = DataGridView1;
		size = new Size(240, 150);
		((Control)dataGridView2).set_Size(size);
		((Control)DataGridView1).set_TabIndex(21);
		DataGridView2.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		DataGridView dataGridView3 = DataGridView2;
		location = new Point(96, 170);
		((Control)dataGridView3).set_Location(location);
		((Control)DataGridView2).set_Name("DataGridView2");
		DataGridView dataGridView4 = DataGridView2;
		size = new Size(240, 150);
		((Control)dataGridView4).set_Size(size);
		((Control)DataGridView2).set_TabIndex(22);
		DataGridView3.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		DataGridView dataGridView5 = DataGridView3;
		location = new Point(104, 178);
		((Control)dataGridView5).set_Location(location);
		((Control)DataGridView3).set_Name("DataGridView3");
		DataGridView dataGridView6 = DataGridView3;
		size = new Size(240, 150);
		((Control)dataGridView6).set_Size(size);
		((Control)DataGridView3).set_TabIndex(23);
		DataGridView4.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		DataGridView dataGridView7 = DataGridView4;
		location = new Point(112, 186);
		((Control)dataGridView7).set_Location(location);
		((Control)DataGridView4).set_Name("DataGridView4");
		DataGridView dataGridView8 = DataGridView4;
		size = new Size(240, 150);
		((Control)dataGridView8).set_Size(size);
		((Control)DataGridView4).set_TabIndex(24);
		DataGridView5.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		DataGridView dataGridView9 = DataGridView5;
		location = new Point(120, 194);
		((Control)dataGridView9).set_Location(location);
		((Control)DataGridView5).set_Name("DataGridView5");
		DataGridView dataGridView10 = DataGridView5;
		size = new Size(240, 150);
		((Control)dataGridView10).set_Size(size);
		((Control)DataGridView5).set_TabIndex(25);
		ErrorProvider1.set_ContainerControl((ContainerControl)(object)this);
		ErrorProvider2.set_ContainerControl((ContainerControl)(object)this);
		ErrorProvider3.set_ContainerControl((ContainerControl)(object)this);
		PictureBox pictureBox = PictureBox1;
		location = new Point(0, 0);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(100, 50);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_TabIndex(26);
		PictureBox1.set_TabStop(false);
		PictureBox pictureBox3 = PictureBox2;
		location = new Point(8, 8);
		((Control)pictureBox3).set_Location(location);
		((Control)PictureBox2).set_Name("PictureBox2");
		PictureBox pictureBox4 = PictureBox2;
		size = new Size(100, 50);
		((Control)pictureBox4).set_Size(size);
		PictureBox2.set_TabIndex(27);
		PictureBox2.set_TabStop(false);
		PictureBox pictureBox5 = PictureBox3;
		location = new Point(16, 16);
		((Control)pictureBox5).set_Location(location);
		((Control)PictureBox3).set_Name("PictureBox3");
		PictureBox pictureBox6 = PictureBox3;
		size = new Size(100, 50);
		((Control)pictureBox6).set_Size(size);
		PictureBox3.set_TabIndex(28);
		PictureBox3.set_TabStop(false);
		PictureBox pictureBox7 = PictureBox4;
		location = new Point(24, 24);
		((Control)pictureBox7).set_Location(location);
		((Control)PictureBox4).set_Name("PictureBox4");
		PictureBox pictureBox8 = PictureBox4;
		size = new Size(100, 50);
		((Control)pictureBox8).set_Size(size);
		PictureBox4.set_TabIndex(29);
		PictureBox4.set_TabStop(false);
		PictureBox pictureBox9 = PictureBox5;
		location = new Point(32, 32);
		((Control)pictureBox9).set_Location(location);
		((Control)PictureBox5).set_Name("PictureBox5");
		PictureBox pictureBox10 = PictureBox5;
		size = new Size(100, 50);
		((Control)pictureBox10).set_Size(size);
		PictureBox5.set_TabIndex(30);
		PictureBox5.set_TabStop(false);
		PrintPreviewDialog printPreviewDialog = PrintPreviewDialog1;
		size = new Size(0, 0);
		printPreviewDialog.set_AutoScrollMargin(size);
		PrintPreviewDialog printPreviewDialog2 = PrintPreviewDialog1;
		size = new Size(0, 0);
		printPreviewDialog2.set_AutoScrollMinSize(size);
		PrintPreviewDialog printPreviewDialog3 = PrintPreviewDialog1;
		size = new Size(400, 300);
		((Form)printPreviewDialog3).set_ClientSize(size);
		PrintPreviewDialog1.set_Enabled(true);
		PrintPreviewDialog1.set_Icon((Icon)componentResourceManager.GetObject("PrintPreviewDialog1.Icon"));
		((Control)PrintPreviewDialog1).set_Name("PrintPreviewDialog1");
		PrintPreviewDialog1.set_Visible(false);
		Process1.StartInfo.Domain = "";
		Process1.StartInfo.LoadUserProfile = false;
		Process1.StartInfo.Password = null;
		Process1.StartInfo.StandardErrorEncoding = null;
		Process1.StartInfo.StandardOutputEncoding = null;
		Process1.StartInfo.UserName = "";
		Process1.SynchronizingObject = (ISynchronizeInvoke?)this;
		Process2.StartInfo.Domain = "";
		Process2.StartInfo.LoadUserProfile = false;
		Process2.StartInfo.Password = null;
		Process2.StartInfo.StandardErrorEncoding = null;
		Process2.StartInfo.StandardOutputEncoding = null;
		Process2.StartInfo.UserName = "";
		Process2.SynchronizingObject = (ISynchronizeInvoke?)this;
		Process3.StartInfo.Domain = "";
		Process3.StartInfo.LoadUserProfile = false;
		Process3.StartInfo.Password = null;
		Process3.StartInfo.StandardErrorEncoding = null;
		Process3.StartInfo.StandardOutputEncoding = null;
		Process3.StartInfo.UserName = "";
		Process3.SynchronizingObject = (ISynchronizeInvoke?)this;
		ProgressBar progressBar = ProgressBar1;
		location = new Point(0, 0);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar2 = ProgressBar1;
		size = new Size(100, 23);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(31);
		ProgressBar progressBar3 = ProgressBar2;
		location = new Point(8, 8);
		((Control)progressBar3).set_Location(location);
		((Control)ProgressBar2).set_Name("ProgressBar2");
		ProgressBar progressBar4 = ProgressBar2;
		size = new Size(100, 23);
		((Control)progressBar4).set_Size(size);
		((Control)ProgressBar2).set_TabIndex(32);
		ProgressBar progressBar5 = ProgressBar3;
		location = new Point(16, 16);
		((Control)progressBar5).set_Location(location);
		((Control)ProgressBar3).set_Name("ProgressBar3");
		ProgressBar progressBar6 = ProgressBar3;
		size = new Size(100, 23);
		((Control)progressBar6).set_Size(size);
		((Control)ProgressBar3).set_TabIndex(33);
		((ButtonBase)RadioButton1).set_AutoSize(true);
		RadioButton radioButton = RadioButton1;
		location = new Point(24, 24);
		((Control)radioButton).set_Location(location);
		((Control)RadioButton1).set_Name("RadioButton1");
		RadioButton radioButton2 = RadioButton1;
		size = new Size(90, 17);
		((Control)radioButton2).set_Size(size);
		((Control)RadioButton1).set_TabIndex(34);
		RadioButton1.set_TabStop(true);
		((ButtonBase)RadioButton1).set_Text("RadioButton1");
		((ButtonBase)RadioButton1).set_UseVisualStyleBackColor(true);
		((ButtonBase)RadioButton2).set_AutoSize(true);
		RadioButton radioButton3 = RadioButton2;
		location = new Point(32, 32);
		((Control)radioButton3).set_Location(location);
		((Control)RadioButton2).set_Name("RadioButton2");
		RadioButton radioButton4 = RadioButton2;
		size = new Size(90, 17);
		((Control)radioButton4).set_Size(size);
		((Control)RadioButton2).set_TabIndex(35);
		RadioButton2.set_TabStop(true);
		((ButtonBase)RadioButton2).set_Text("RadioButton2");
		((ButtonBase)RadioButton2).set_UseVisualStyleBackColor(true);
		((ButtonBase)RadioButton3).set_AutoSize(true);
		RadioButton radioButton5 = RadioButton3;
		location = new Point(40, 40);
		((Control)radioButton5).set_Location(location);
		((Control)RadioButton3).set_Name("RadioButton3");
		RadioButton radioButton6 = RadioButton3;
		size = new Size(90, 17);
		((Control)radioButton6).set_Size(size);
		((Control)RadioButton3).set_TabIndex(36);
		RadioButton3.set_TabStop(true);
		((ButtonBase)RadioButton3).set_Text("RadioButton3");
		((ButtonBase)RadioButton3).set_UseVisualStyleBackColor(true);
		((ButtonBase)RadioButton4).set_AutoSize(true);
		RadioButton radioButton7 = RadioButton4;
		location = new Point(48, 48);
		((Control)radioButton7).set_Location(location);
		((Control)RadioButton4).set_Name("RadioButton4");
		RadioButton radioButton8 = RadioButton4;
		size = new Size(90, 17);
		((Control)radioButton8).set_Size(size);
		((Control)RadioButton4).set_TabIndex(37);
		RadioButton4.set_TabStop(true);
		((ButtonBase)RadioButton4).set_Text("RadioButton4");
		((ButtonBase)RadioButton4).set_UseVisualStyleBackColor(true);
		((ButtonBase)RadioButton5).set_AutoSize(true);
		RadioButton radioButton9 = RadioButton5;
		location = new Point(56, 56);
		((Control)radioButton9).set_Location(location);
		((Control)RadioButton5).set_Name("RadioButton5");
		RadioButton radioButton10 = RadioButton5;
		size = new Size(90, 17);
		((Control)radioButton10).set_Size(size);
		((Control)RadioButton5).set_TabIndex(38);
		RadioButton5.set_TabStop(true);
		((ButtonBase)RadioButton5).set_Text("RadioButton5");
		((ButtonBase)RadioButton5).set_UseVisualStyleBackColor(true);
		WebBrowser webBrowser = WebBrowser1;
		location = new Point(64, 64);
		((Control)webBrowser).set_Location(location);
		WebBrowser webBrowser2 = WebBrowser1;
		size = new Size(20, 20);
		((Control)webBrowser2).set_MinimumSize(size);
		((Control)WebBrowser1).set_Name("WebBrowser1");
		WebBrowser webBrowser3 = WebBrowser1;
		size = new Size(250, 250);
		((Control)webBrowser3).set_Size(size);
		((Control)WebBrowser1).set_TabIndex(39);
		WebBrowser webBrowser4 = WebBrowser2;
		location = new Point(72, 72);
		((Control)webBrowser4).set_Location(location);
		WebBrowser webBrowser5 = WebBrowser2;
		size = new Size(20, 20);
		((Control)webBrowser5).set_MinimumSize(size);
		((Control)WebBrowser2).set_Name("WebBrowser2");
		WebBrowser webBrowser6 = WebBrowser2;
		size = new Size(250, 250);
		((Control)webBrowser6).set_Size(size);
		((Control)WebBrowser2).set_TabIndex(40);
		WebBrowser webBrowser7 = WebBrowser3;
		location = new Point(80, 80);
		((Control)webBrowser7).set_Location(location);
		WebBrowser webBrowser8 = WebBrowser3;
		size = new Size(20, 20);
		((Control)webBrowser8).set_MinimumSize(size);
		((Control)WebBrowser3).set_Name("WebBrowser3");
		WebBrowser webBrowser9 = WebBrowser3;
		size = new Size(250, 250);
		((Control)webBrowser9).set_Size(size);
		((Control)WebBrowser3).set_TabIndex(41);
		WebBrowser webBrowser10 = WebBrowser4;
		location = new Point(88, 88);
		((Control)webBrowser10).set_Location(location);
		WebBrowser webBrowser11 = WebBrowser4;
		size = new Size(20, 20);
		((Control)webBrowser11).set_MinimumSize(size);
		((Control)WebBrowser4).set_Name("WebBrowser4");
		WebBrowser webBrowser12 = WebBrowser4;
		size = new Size(250, 250);
		((Control)webBrowser12).set_Size(size);
		((Control)WebBrowser4).set_TabIndex(42);
		WebBrowser webBrowser13 = WebBrowser5;
		location = new Point(96, 96);
		((Control)webBrowser13).set_Location(location);
		WebBrowser webBrowser14 = WebBrowser5;
		size = new Size(20, 20);
		((Control)webBrowser14).set_MinimumSize(size);
		((Control)WebBrowser5).set_Name("WebBrowser5");
		WebBrowser webBrowser15 = WebBrowser5;
		size = new Size(250, 250);
		((Control)webBrowser15).set_Size(size);
		((Control)WebBrowser5).set_TabIndex(43);
		WebBrowser webBrowser16 = WebBrowser6;
		location = new Point(104, 104);
		((Control)webBrowser16).set_Location(location);
		WebBrowser webBrowser17 = WebBrowser6;
		size = new Size(20, 20);
		((Control)webBrowser17).set_MinimumSize(size);
		((Control)WebBrowser6).set_Name("WebBrowser6");
		WebBrowser webBrowser18 = WebBrowser6;
		size = new Size(250, 250);
		((Control)webBrowser18).set_Size(size);
		((Control)WebBrowser6).set_TabIndex(44);
		WebBrowser webBrowser19 = WebBrowser7;
		location = new Point(112, 112);
		((Control)webBrowser19).set_Location(location);
		WebBrowser webBrowser20 = WebBrowser7;
		size = new Size(20, 20);
		((Control)webBrowser20).set_MinimumSize(size);
		((Control)WebBrowser7).set_Name("WebBrowser7");
		WebBrowser webBrowser21 = WebBrowser7;
		size = new Size(250, 250);
		((Control)webBrowser21).set_Size(size);
		((Control)WebBrowser7).set_TabIndex(45);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(632, 453);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser7);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser6);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser5);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser4);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser3);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser2);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser1);
		((Control)this).get_Controls().Add((Control)(object)RadioButton5);
		((Control)this).get_Controls().Add((Control)(object)RadioButton4);
		((Control)this).get_Controls().Add((Control)(object)RadioButton3);
		((Control)this).get_Controls().Add((Control)(object)RadioButton2);
		((Control)this).get_Controls().Add((Control)(object)RadioButton1);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar3);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar2);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox5);
		((Control)this).get_Controls().Add((Control)(object)PictureBox4);
		((Control)this).get_Controls().Add((Control)(object)PictureBox3);
		((Control)this).get_Controls().Add((Control)(object)PictureBox2);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)DataGridView5);
		((Control)this).get_Controls().Add((Control)(object)DataGridView4);
		((Control)this).get_Controls().Add((Control)(object)DataGridView3);
		((Control)this).get_Controls().Add((Control)(object)DataGridView2);
		((Control)this).get_Controls().Add((Control)(object)DataGridView1);
		((Control)this).get_Controls().Add((Control)(object)ComboBox2);
		((Control)this).get_Controls().Add((Control)(object)ComboBox1);
		((Control)this).get_Controls().Add((Control)(object)CheckedListBox2);
		((Control)this).get_Controls().Add((Control)(object)CheckedListBox1);
		((Control)this).get_Controls().Add((Control)(object)CheckBox2);
		((Control)this).get_Controls().Add((Control)(object)CheckBox1);
		((Control)this).get_Controls().Add((Control)(object)Button4);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)BindingNavigator2);
		((Control)this).get_Controls().Add((Control)(object)BindingNavigator1);
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
		((ISupportInitialize)BindingNavigator1).EndInit();
		((Control)BindingNavigator1).ResumeLayout(false);
		((Control)BindingNavigator1).PerformLayout();
		((ISupportInitialize)BindingNavigator2).EndInit();
		((Control)BindingNavigator2).ResumeLayout(false);
		((Control)BindingNavigator2).PerformLayout();
		((ISupportInitialize)DataGridView1).EndInit();
		((ISupportInitialize)DataGridView2).EndInit();
		((ISupportInitialize)DataGridView3).EndInit();
		((ISupportInitialize)DataGridView4).EndInit();
		((ISupportInitialize)DataGridView5).EndInit();
		((ISupportInitialize)ErrorProvider1).EndInit();
		((ISupportInitialize)ErrorProvider2).EndInit();
		((ISupportInitialize)ErrorProvider3).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox4).EndInit();
		((ISupportInitialize)PictureBox5).EndInit();
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
