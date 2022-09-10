using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Autodesk.ExpressTools.AliasEdit.Autodesk.ExpressTools.AliasEdit;

internal class frmAlias : Form
{
	public class ColumnSort : IComparer
	{
		private int colNum;

		public ColumnSort(int column_to_sort)
		{
			colNum = column_to_sort;
		}

		public int Compare(object x, object y)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Expected O, but got Unknown
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Invalid comparison between Unknown and I4
			ListViewItem val = (ListViewItem)x;
			ListViewItem val2 = (ListViewItem)y;
			if ((int)val.get_ListView().get_Sorting() == 1)
			{
				return checked(string.Compare(val.get_SubItems().get_Item(colNum).get_Text(), val2.get_SubItems().get_Item(colNum).get_Text()) * -1);
			}
			return string.Compare(val.get_SubItems().get_Item(colNum).get_Text(), val2.get_SubItems().get_Item(colNum).get_Text());
		}
	}

	public ResourceManager resManager;

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("cdgOpen")]
	private OpenFileDialog _cdgOpen;

	[AccessedThroughProperty("cmdOK")]
	private Button _cmdOK;

	[AccessedThroughProperty("chkConfirm")]
	private CheckBox _chkConfirm;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdApply")]
	private Button _cmdApply;

	[AccessedThroughProperty("_pctAlias_0")]
	private Panel __pctAlias_0;

	[AccessedThroughProperty("_cmdEdit_0")]
	private Button __cmdEdit_0;

	[AccessedThroughProperty("_cmdRemove_0")]
	private Button __cmdRemove_0;

	[AccessedThroughProperty("_cmdAdd_0")]
	private Button __cmdAdd_0;

	[AccessedThroughProperty("_fraMain_0")]
	private GroupBox __fraMain_0;

	[AccessedThroughProperty("_pctAlias_1")]
	private Panel __pctAlias_1;

	[AccessedThroughProperty("_cmdEdit_1")]
	private Button __cmdEdit_1;

	[AccessedThroughProperty("_cmdAdd_1")]
	private Button __cmdAdd_1;

	[AccessedThroughProperty("_cmdRemove_1")]
	private Button __cmdRemove_1;

	[AccessedThroughProperty("_fraMain_1")]
	private GroupBox __fraMain_1;

	[AccessedThroughProperty("tbsMain")]
	private TabControl _tbsMain;

	[AccessedThroughProperty("lblProgress")]
	private Label _lblProgress;

	public ArrayList cmdAdd;

	public ArrayList cmdEdit;

	public ArrayList cmdRemove;

	public ArrayList fraMain;

	public ArrayList pctAlias;

	[AccessedThroughProperty("mnuFileNew")]
	private MenuItem _mnuFileNew;

	[AccessedThroughProperty("mnuFileSep1")]
	private MenuItem _mnuFileSep1;

	[AccessedThroughProperty("mnuFileOpen")]
	private MenuItem _mnuFileOpen;

	[AccessedThroughProperty("mnuFileSave")]
	private MenuItem _mnuFileSave;

	[AccessedThroughProperty("mnuFileSep2")]
	private MenuItem _mnuFileSep2;

	[AccessedThroughProperty("mnuFileImport")]
	private MenuItem _mnuFileImport;

	[AccessedThroughProperty("mnuFileExport")]
	private MenuItem _mnuFileExport;

	[AccessedThroughProperty("mnuFileSep3")]
	private MenuItem _mnuFileSep3;

	[AccessedThroughProperty("mnuFileSetup")]
	private MenuItem _mnuFileSetup;

	[AccessedThroughProperty("mnuFilePrint")]
	private MenuItem _mnuFilePrint;

	[AccessedThroughProperty("mnuFileSep4")]
	private MenuItem _mnuFileSep4;

	[AccessedThroughProperty("mnuFileExit")]
	private MenuItem _mnuFileExit;

	[AccessedThroughProperty("mnuFile")]
	private MenuItem _mnuFile;

	[AccessedThroughProperty("mnuEditAdd")]
	private MenuItem _mnuEditAdd;

	[AccessedThroughProperty("mnuEditRemove")]
	private MenuItem _mnuEditRemove;

	[AccessedThroughProperty("mnuEditSep1")]
	private MenuItem _mnuEditSep1;

	[AccessedThroughProperty("mnuEditEdit")]
	private MenuItem _mnuEditEdit;

	[AccessedThroughProperty("mnuEdit")]
	private MenuItem _mnuEdit;

	[AccessedThroughProperty("mnuHelpSearch")]
	private MenuItem _mnuHelpSearch;

	[AccessedThroughProperty("mnuHelpSep1")]
	private MenuItem _mnuHelpSep1;

	[AccessedThroughProperty("mnuHelpAbout")]
	private MenuItem _mnuHelpAbout;

	[AccessedThroughProperty("mnuHelp")]
	private MenuItem _mnuHelp;

	public MainMenu MainMenu1;

	[AccessedThroughProperty("HelpProvider1")]
	private HelpProvider _HelpProvider1;

	public TabPage Tab0;

	public TabPage Tab1;

	public ArrayList lvwAlias;

	[AccessedThroughProperty("_lvwShell")]
	private ListView __lvwShell;

	[AccessedThroughProperty("_lvwAlias")]
	private ListView __lvwAlias;

	[AccessedThroughProperty("PageSetupDlg")]
	private PageSetupDialog _PageSetupDlg;

	[AccessedThroughProperty("cdgSave")]
	private SaveFileDialog _cdgSave;

	private static frmAlias m_vb6FormDefInstance;

	public virtual OpenFileDialog cdgOpen
	{
		get
		{
			return _cdgOpen;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_cdgOpen = value;
		}
	}

	public virtual Button cmdOK
	{
		get
		{
			return _cmdOK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmdOK != null)
			{
				((Control)_cmdOK).remove_Click((EventHandler)cmdOK_Click);
			}
			_cmdOK = value;
			if (_cmdOK != null)
			{
				((Control)_cmdOK).add_Click((EventHandler)cmdOK_Click);
			}
		}
	}

	public virtual CheckBox chkConfirm
	{
		get
		{
			return _chkConfirm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_chkConfirm = value;
		}
	}

	public virtual Button cmdCancel
	{
		get
		{
			return _cmdCancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmdCancel != null)
			{
				((Control)_cmdCancel).remove_Click((EventHandler)cmdCancel_Click);
			}
			_cmdCancel = value;
			if (_cmdCancel != null)
			{
				((Control)_cmdCancel).add_Click((EventHandler)cmdCancel_Click);
			}
		}
	}

	public virtual Button cmdApply
	{
		get
		{
			return _cmdApply;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmdApply != null)
			{
				((Control)_cmdApply).remove_Click((EventHandler)cmdApply_Click);
			}
			_cmdApply = value;
			if (_cmdApply != null)
			{
				((Control)_cmdApply).add_Click((EventHandler)cmdApply_Click);
			}
		}
	}

	public virtual Panel _pctAlias_0
	{
		get
		{
			return __pctAlias_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			__pctAlias_0 = value;
		}
	}

	public virtual Button _cmdEdit_0
	{
		get
		{
			return __cmdEdit_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (__cmdEdit_0 != null)
			{
				((Control)__cmdEdit_0).remove_Click((EventHandler)cmdEdit_Click);
			}
			__cmdEdit_0 = value;
			if (__cmdEdit_0 != null)
			{
				((Control)__cmdEdit_0).add_Click((EventHandler)cmdEdit_Click);
			}
		}
	}

	public virtual Button _cmdRemove_0
	{
		get
		{
			return __cmdRemove_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (__cmdRemove_0 != null)
			{
				((Control)__cmdRemove_0).remove_Click((EventHandler)cmdRemove_Click);
			}
			__cmdRemove_0 = value;
			if (__cmdRemove_0 != null)
			{
				((Control)__cmdRemove_0).add_Click((EventHandler)cmdRemove_Click);
			}
		}
	}

	public virtual Button _cmdAdd_0
	{
		get
		{
			return __cmdAdd_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (__cmdAdd_0 != null)
			{
				((Control)__cmdAdd_0).remove_Click((EventHandler)cmdAdd_Click);
			}
			__cmdAdd_0 = value;
			if (__cmdAdd_0 != null)
			{
				((Control)__cmdAdd_0).add_Click((EventHandler)cmdAdd_Click);
			}
		}
	}

	public virtual GroupBox _fraMain_0
	{
		get
		{
			return __fraMain_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			__fraMain_0 = value;
		}
	}

	public virtual Panel _pctAlias_1
	{
		get
		{
			return __pctAlias_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			__pctAlias_1 = value;
		}
	}

	public virtual Button _cmdEdit_1
	{
		get
		{
			return __cmdEdit_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (__cmdEdit_1 != null)
			{
				((Control)__cmdEdit_1).remove_Click((EventHandler)cmdEdit_Click);
			}
			__cmdEdit_1 = value;
			if (__cmdEdit_1 != null)
			{
				((Control)__cmdEdit_1).add_Click((EventHandler)cmdEdit_Click);
			}
		}
	}

	public virtual Button _cmdAdd_1
	{
		get
		{
			return __cmdAdd_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (__cmdAdd_1 != null)
			{
				((Control)__cmdAdd_1).remove_Click((EventHandler)cmdAdd_Click);
			}
			__cmdAdd_1 = value;
			if (__cmdAdd_1 != null)
			{
				((Control)__cmdAdd_1).add_Click((EventHandler)cmdAdd_Click);
			}
		}
	}

	public virtual Button _cmdRemove_1
	{
		get
		{
			return __cmdRemove_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (__cmdRemove_1 != null)
			{
				((Control)__cmdRemove_1).remove_Click((EventHandler)cmdRemove_Click);
			}
			__cmdRemove_1 = value;
			if (__cmdRemove_1 != null)
			{
				((Control)__cmdRemove_1).add_Click((EventHandler)cmdRemove_Click);
			}
		}
	}

	public virtual GroupBox _fraMain_1
	{
		get
		{
			return __fraMain_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			__fraMain_1 = value;
		}
	}

	public virtual TabControl tbsMain
	{
		get
		{
			return _tbsMain;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_tbsMain != null)
			{
				((Control)_tbsMain).remove_Click((EventHandler)tbsMain_ClickEvent);
			}
			_tbsMain = value;
			if (_tbsMain != null)
			{
				((Control)_tbsMain).add_Click((EventHandler)tbsMain_ClickEvent);
			}
		}
	}

	public virtual Label lblProgress
	{
		get
		{
			return _lblProgress;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblProgress = value;
		}
	}

	public virtual MenuItem mnuFileNew
	{
		get
		{
			return _mnuFileNew;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuFileNew != null)
			{
				_mnuFileNew.remove_Click((EventHandler)mnuFileNew_Click);
				_mnuFileNew.remove_Popup((EventHandler)mnuFileNew_Popup);
			}
			_mnuFileNew = value;
			if (_mnuFileNew != null)
			{
				_mnuFileNew.add_Click((EventHandler)mnuFileNew_Click);
				_mnuFileNew.add_Popup((EventHandler)mnuFileNew_Popup);
			}
		}
	}

	public virtual MenuItem mnuFileSep1
	{
		get
		{
			return _mnuFileSep1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_mnuFileSep1 = value;
		}
	}

	public virtual MenuItem mnuFileOpen
	{
		get
		{
			return _mnuFileOpen;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuFileOpen != null)
			{
				_mnuFileOpen.remove_Click((EventHandler)mnuFileOpen_Click);
				_mnuFileOpen.remove_Popup((EventHandler)mnuFileOpen_Popup);
			}
			_mnuFileOpen = value;
			if (_mnuFileOpen != null)
			{
				_mnuFileOpen.add_Click((EventHandler)mnuFileOpen_Click);
				_mnuFileOpen.add_Popup((EventHandler)mnuFileOpen_Popup);
			}
		}
	}

	public virtual MenuItem mnuFileSave
	{
		get
		{
			return _mnuFileSave;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuFileSave != null)
			{
				_mnuFileSave.remove_Click((EventHandler)mnuFileSave_Click);
				_mnuFileSave.remove_Popup((EventHandler)mnuFileSave_Popup);
			}
			_mnuFileSave = value;
			if (_mnuFileSave != null)
			{
				_mnuFileSave.add_Click((EventHandler)mnuFileSave_Click);
				_mnuFileSave.add_Popup((EventHandler)mnuFileSave_Popup);
			}
		}
	}

	public virtual MenuItem mnuFileSep2
	{
		get
		{
			return _mnuFileSep2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_mnuFileSep2 = value;
		}
	}

	public virtual MenuItem mnuFileImport
	{
		get
		{
			return _mnuFileImport;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuFileImport != null)
			{
				_mnuFileImport.remove_Click((EventHandler)mnuFileImport_Click);
				_mnuFileImport.remove_Popup((EventHandler)mnuFileImport_Popup);
			}
			_mnuFileImport = value;
			if (_mnuFileImport != null)
			{
				_mnuFileImport.add_Click((EventHandler)mnuFileImport_Click);
				_mnuFileImport.add_Popup((EventHandler)mnuFileImport_Popup);
			}
		}
	}

	public virtual MenuItem mnuFileExport
	{
		get
		{
			return _mnuFileExport;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuFileExport != null)
			{
				_mnuFileExport.remove_Click((EventHandler)mnuFileExport_Click);
				_mnuFileExport.remove_Popup((EventHandler)mnuFileExport_Popup);
			}
			_mnuFileExport = value;
			if (_mnuFileExport != null)
			{
				_mnuFileExport.add_Click((EventHandler)mnuFileExport_Click);
				_mnuFileExport.add_Popup((EventHandler)mnuFileExport_Popup);
			}
		}
	}

	public virtual MenuItem mnuFileSep3
	{
		get
		{
			return _mnuFileSep3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_mnuFileSep3 = value;
		}
	}

	public virtual MenuItem mnuFileSetup
	{
		get
		{
			return _mnuFileSetup;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuFileSetup != null)
			{
				_mnuFileSetup.remove_Click((EventHandler)mnuFileSetup_Click);
				_mnuFileSetup.remove_Popup((EventHandler)mnuFileSetup_Popup);
			}
			_mnuFileSetup = value;
			if (_mnuFileSetup != null)
			{
				_mnuFileSetup.add_Click((EventHandler)mnuFileSetup_Click);
				_mnuFileSetup.add_Popup((EventHandler)mnuFileSetup_Popup);
			}
		}
	}

	public virtual MenuItem mnuFilePrint
	{
		get
		{
			return _mnuFilePrint;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuFilePrint != null)
			{
				_mnuFilePrint.remove_Click((EventHandler)mnuFilePrint_Click);
				_mnuFilePrint.remove_Popup((EventHandler)mnuFilePrint_Popup);
			}
			_mnuFilePrint = value;
			if (_mnuFilePrint != null)
			{
				_mnuFilePrint.add_Click((EventHandler)mnuFilePrint_Click);
				_mnuFilePrint.add_Popup((EventHandler)mnuFilePrint_Popup);
			}
		}
	}

	public virtual MenuItem mnuFileSep4
	{
		get
		{
			return _mnuFileSep4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_mnuFileSep4 = value;
		}
	}

	public virtual MenuItem mnuFileExit
	{
		get
		{
			return _mnuFileExit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuFileExit != null)
			{
				_mnuFileExit.remove_Click((EventHandler)mnuFileExit_Click);
				_mnuFileExit.remove_Popup((EventHandler)mnuFileExit_Popup);
			}
			_mnuFileExit = value;
			if (_mnuFileExit != null)
			{
				_mnuFileExit.add_Click((EventHandler)mnuFileExit_Click);
				_mnuFileExit.add_Popup((EventHandler)mnuFileExit_Popup);
			}
		}
	}

	public virtual MenuItem mnuFile
	{
		get
		{
			return _mnuFile;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_mnuFile = value;
		}
	}

	public virtual MenuItem mnuEditAdd
	{
		get
		{
			return _mnuEditAdd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuEditAdd != null)
			{
				_mnuEditAdd.remove_Click((EventHandler)mnuEditAdd_Click);
				_mnuEditAdd.remove_Popup((EventHandler)mnuEditAdd_Popup);
			}
			_mnuEditAdd = value;
			if (_mnuEditAdd != null)
			{
				_mnuEditAdd.add_Click((EventHandler)mnuEditAdd_Click);
				_mnuEditAdd.add_Popup((EventHandler)mnuEditAdd_Popup);
			}
		}
	}

	public virtual MenuItem mnuEditRemove
	{
		get
		{
			return _mnuEditRemove;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuEditRemove != null)
			{
				_mnuEditRemove.remove_Click((EventHandler)mnuEditRemove_Click);
				_mnuEditRemove.remove_Popup((EventHandler)mnuEditRemove_Popup);
			}
			_mnuEditRemove = value;
			if (_mnuEditRemove != null)
			{
				_mnuEditRemove.add_Click((EventHandler)mnuEditRemove_Click);
				_mnuEditRemove.add_Popup((EventHandler)mnuEditRemove_Popup);
			}
		}
	}

	public virtual MenuItem mnuEditSep1
	{
		get
		{
			return _mnuEditSep1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_mnuEditSep1 = value;
		}
	}

	public virtual MenuItem mnuEditEdit
	{
		get
		{
			return _mnuEditEdit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuEditEdit != null)
			{
				_mnuEditEdit.remove_Click((EventHandler)mnuEditEdit_Click);
				_mnuEditEdit.remove_Popup((EventHandler)mnuEditEdit_Popup);
			}
			_mnuEditEdit = value;
			if (_mnuEditEdit != null)
			{
				_mnuEditEdit.add_Click((EventHandler)mnuEditEdit_Click);
				_mnuEditEdit.add_Popup((EventHandler)mnuEditEdit_Popup);
			}
		}
	}

	public virtual MenuItem mnuEdit
	{
		get
		{
			return _mnuEdit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_mnuEdit = value;
		}
	}

	public virtual MenuItem mnuHelpSearch
	{
		get
		{
			return _mnuHelpSearch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuHelpSearch != null)
			{
				_mnuHelpSearch.remove_Click((EventHandler)mnuHelpSearch_Click);
				_mnuHelpSearch.remove_Popup((EventHandler)mnuHelpSearch_Popup);
			}
			_mnuHelpSearch = value;
			if (_mnuHelpSearch != null)
			{
				_mnuHelpSearch.add_Click((EventHandler)mnuHelpSearch_Click);
				_mnuHelpSearch.add_Popup((EventHandler)mnuHelpSearch_Popup);
			}
		}
	}

	public virtual MenuItem mnuHelpSep1
	{
		get
		{
			return _mnuHelpSep1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_mnuHelpSep1 = value;
		}
	}

	public virtual MenuItem mnuHelpAbout
	{
		get
		{
			return _mnuHelpAbout;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuHelpAbout != null)
			{
				_mnuHelpAbout.remove_Click((EventHandler)mnuHelpAbout_Click);
				_mnuHelpAbout.remove_Popup((EventHandler)mnuHelpAbout_Popup);
			}
			_mnuHelpAbout = value;
			if (_mnuHelpAbout != null)
			{
				_mnuHelpAbout.add_Click((EventHandler)mnuHelpAbout_Click);
				_mnuHelpAbout.add_Popup((EventHandler)mnuHelpAbout_Popup);
			}
		}
	}

	public virtual MenuItem mnuHelp
	{
		get
		{
			return _mnuHelp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_mnuHelp = value;
		}
	}

	public virtual HelpProvider HelpProvider1
	{
		get
		{
			return _HelpProvider1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_HelpProvider1 = value;
		}
	}

	public virtual ListView _lvwShell
	{
		get
		{
			return __lvwShell;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected O, but got Unknown
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected O, but got Unknown
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Expected O, but got Unknown
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Expected O, but got Unknown
			//IL_0163: Unknown result type (might be due to invalid IL or missing references)
			//IL_016d: Expected O, but got Unknown
			if (__lvwShell != null)
			{
				((Control)__lvwShell).remove_Leave((EventHandler)lvwAlias_Leave);
				((Control)__lvwShell).remove_KeyDown(new KeyEventHandler(lvwAlias_KeyDownEvent));
				__lvwShell.remove_SelectedIndexChanged((EventHandler)lvwAlias_ItemClick);
				((Control)__lvwShell).remove_Enter((EventHandler)lvwAlias_Enter);
				((Control)__lvwShell).remove_DoubleClick((EventHandler)lvwAlias_DblClick);
				__lvwShell.remove_ColumnClick(new ColumnClickEventHandler(lvwAlias_ColumnClick));
				__lvwShell.remove_AfterLabelEdit(new LabelEditEventHandler(lvwAlias_AfterLabelEdit));
			}
			__lvwShell = value;
			if (__lvwShell != null)
			{
				((Control)__lvwShell).add_Leave((EventHandler)lvwAlias_Leave);
				((Control)__lvwShell).add_KeyDown(new KeyEventHandler(lvwAlias_KeyDownEvent));
				__lvwShell.add_SelectedIndexChanged((EventHandler)lvwAlias_ItemClick);
				((Control)__lvwShell).add_Enter((EventHandler)lvwAlias_Enter);
				((Control)__lvwShell).add_DoubleClick((EventHandler)lvwAlias_DblClick);
				__lvwShell.add_ColumnClick(new ColumnClickEventHandler(lvwAlias_ColumnClick));
				__lvwShell.add_AfterLabelEdit(new LabelEditEventHandler(lvwAlias_AfterLabelEdit));
			}
		}
	}

	public virtual ListView _lvwAlias
	{
		get
		{
			return __lvwAlias;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected O, but got Unknown
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected O, but got Unknown
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Expected O, but got Unknown
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Expected O, but got Unknown
			//IL_0163: Unknown result type (might be due to invalid IL or missing references)
			//IL_016d: Expected O, but got Unknown
			if (__lvwAlias != null)
			{
				((Control)__lvwAlias).remove_Leave((EventHandler)lvwAlias_Leave);
				((Control)__lvwAlias).remove_KeyDown(new KeyEventHandler(lvwAlias_KeyDownEvent));
				__lvwAlias.remove_SelectedIndexChanged((EventHandler)lvwAlias_ItemClick);
				((Control)__lvwAlias).remove_Enter((EventHandler)lvwAlias_Enter);
				((Control)__lvwAlias).remove_DoubleClick((EventHandler)lvwAlias_DblClick);
				__lvwAlias.remove_ColumnClick(new ColumnClickEventHandler(lvwAlias_ColumnClick));
				__lvwAlias.remove_AfterLabelEdit(new LabelEditEventHandler(lvwAlias_AfterLabelEdit));
			}
			__lvwAlias = value;
			if (__lvwAlias != null)
			{
				((Control)__lvwAlias).add_Leave((EventHandler)lvwAlias_Leave);
				((Control)__lvwAlias).add_KeyDown(new KeyEventHandler(lvwAlias_KeyDownEvent));
				__lvwAlias.add_SelectedIndexChanged((EventHandler)lvwAlias_ItemClick);
				((Control)__lvwAlias).add_Enter((EventHandler)lvwAlias_Enter);
				((Control)__lvwAlias).add_DoubleClick((EventHandler)lvwAlias_DblClick);
				__lvwAlias.add_ColumnClick(new ColumnClickEventHandler(lvwAlias_ColumnClick));
				__lvwAlias.add_AfterLabelEdit(new LabelEditEventHandler(lvwAlias_AfterLabelEdit));
			}
		}
	}

	internal virtual PageSetupDialog PageSetupDlg
	{
		get
		{
			return _PageSetupDlg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PageSetupDlg = value;
		}
	}

	internal virtual SaveFileDialog cdgSave
	{
		get
		{
			return _cdgSave;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_cdgSave = value;
		}
	}

	public static frmAlias DefInstance
	{
		get
		{
			return m_vb6FormDefInstance;
		}
		set
		{
			m_vb6FormDefInstance = value;
		}
	}

	public frmAlias()
	{
		((Form)this).add_Load((EventHandler)frmAlias_Load);
		((Form)this).add_Closed((EventHandler)frmAlias_Closed);
		resManager = new ResourceManager(typeof(frmAlias));
		cmdAdd = new ArrayList();
		cmdEdit = new ArrayList();
		cmdRemove = new ArrayList();
		fraMain = new ArrayList();
		pctAlias = new ArrayList();
		lvwAlias = new ArrayList();
		m_vb6FormDefInstance = this;
		InitializeComponent();
	}

	protected override void Dispose(bool Disposing)
	{
		if (Disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(Disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
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
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected O, but got Unknown
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected O, but got Unknown
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected O, but got Unknown
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Expected O, but got Unknown
		//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b5: Expected O, but got Unknown
		//IL_072f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0739: Expected O, but got Unknown
		//IL_090f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0919: Expected O, but got Unknown
		//IL_098b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0995: Expected O, but got Unknown
		//IL_0a0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a19: Expected O, but got Unknown
		//IL_0bff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c09: Expected O, but got Unknown
		//IL_0c7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c85: Expected O, but got Unknown
		//IL_0cff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d09: Expected O, but got Unknown
		//IL_0eef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef9: Expected O, but got Unknown
		//IL_0f98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa2: Expected O, but got Unknown
		//IL_1205: Unknown result type (might be due to invalid IL or missing references)
		//IL_120f: Expected O, but got Unknown
		//IL_1288: Unknown result type (might be due to invalid IL or missing references)
		//IL_1292: Expected O, but got Unknown
		//IL_14a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ad: Expected O, but got Unknown
		//IL_14f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_14fe: Expected O, but got Unknown
		//IL_171b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1725: Expected O, but got Unknown
		//IL_1797: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a1: Expected O, but got Unknown
		//IL_181b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1825: Expected O, but got Unknown
		//IL_1a07: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a11: Expected O, but got Unknown
		//IL_1a83: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a8d: Expected O, but got Unknown
		//IL_1b07: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b11: Expected O, but got Unknown
		//IL_1cf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cfd: Expected O, but got Unknown
		//IL_1d6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d79: Expected O, but got Unknown
		//IL_1df3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dfd: Expected O, but got Unknown
		//IL_1fd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fdd: Expected O, but got Unknown
		//IL_207c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2086: Expected O, but got Unknown
		//IL_22e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_22f3: Expected O, but got Unknown
		//IL_236c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2376: Expected O, but got Unknown
		//IL_2587: Unknown result type (might be due to invalid IL or missing references)
		//IL_2591: Expected O, but got Unknown
		//IL_25d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_25e2: Expected O, but got Unknown
		//IL_27ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_2809: Expected O, but got Unknown
		//IL_287b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2885: Expected O, but got Unknown
		//IL_28ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_2909: Expected O, but got Unknown
		//IL_2aef: Unknown result type (might be due to invalid IL or missing references)
		//IL_2af9: Expected O, but got Unknown
		//IL_2b6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b75: Expected O, but got Unknown
		//IL_2bef: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bf9: Expected O, but got Unknown
		//IL_2ddf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2de9: Expected O, but got Unknown
		//IL_2e5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e65: Expected O, but got Unknown
		//IL_2edf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ee9: Expected O, but got Unknown
		//IL_30f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_30ff: Expected O, but got Unknown
		//IL_3172: Unknown result type (might be due to invalid IL or missing references)
		//IL_317c: Expected O, but got Unknown
		//IL_3428: Unknown result type (might be due to invalid IL or missing references)
		//IL_3432: Expected O, but got Unknown
		//IL_348f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3499: Expected O, but got Unknown
		//IL_3701: Unknown result type (might be due to invalid IL or missing references)
		//IL_370b: Expected O, but got Unknown
		//IL_3768: Unknown result type (might be due to invalid IL or missing references)
		//IL_3772: Expected O, but got Unknown
		//IL_39e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_39ec: Expected O, but got Unknown
		//IL_3a66: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a70: Expected O, but got Unknown
		//IL_4a7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a87: Expected O, but got Unknown
		//IL_4b3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b46: Expected O, but got Unknown
		//IL_4ba3: Unknown result type (might be due to invalid IL or missing references)
		//IL_4bad: Expected O, but got Unknown
		Application.EnableVisualStyles();
		components = new Container();
		ResourceManager resourceManager = new ResourceManager(typeof(frmAlias));
		ToolTip1 = new ToolTip(components);
		cmdOK = new Button();
		chkConfirm = new CheckBox();
		cmdCancel = new Button();
		cmdApply = new Button();
		_fraMain_0 = new GroupBox();
		_pctAlias_0 = new Panel();
		_lvwAlias = new ListView();
		_cmdEdit_0 = new Button();
		_cmdRemove_0 = new Button();
		_cmdAdd_0 = new Button();
		_fraMain_1 = new GroupBox();
		_pctAlias_1 = new Panel();
		_lvwShell = new ListView();
		_cmdEdit_1 = new Button();
		_cmdAdd_1 = new Button();
		_cmdRemove_1 = new Button();
		tbsMain = new TabControl();
		Tab0 = new TabPage();
		Tab1 = new TabPage();
		lblProgress = new Label();
		cdgOpen = new OpenFileDialog();
		MainMenu1 = new MainMenu();
		mnuFile = new MenuItem();
		mnuFileNew = new MenuItem();
		mnuFileSep1 = new MenuItem();
		mnuFileOpen = new MenuItem();
		mnuFileSave = new MenuItem();
		mnuFileSep2 = new MenuItem();
		mnuFileImport = new MenuItem();
		mnuFileExport = new MenuItem();
		mnuFileSep3 = new MenuItem();
		mnuFileSetup = new MenuItem();
		mnuFilePrint = new MenuItem();
		mnuFileSep4 = new MenuItem();
		mnuFileExit = new MenuItem();
		mnuEdit = new MenuItem();
		mnuEditAdd = new MenuItem();
		mnuEditRemove = new MenuItem();
		mnuEditSep1 = new MenuItem();
		mnuEditEdit = new MenuItem();
		mnuHelp = new MenuItem();
		mnuHelpSearch = new MenuItem();
		mnuHelpSep1 = new MenuItem();
		mnuHelpAbout = new MenuItem();
		HelpProvider1 = new HelpProvider();
		PageSetupDlg = new PageSetupDialog();
		cdgSave = new SaveFileDialog();
		((Control)_fraMain_0).SuspendLayout();
		((Control)_pctAlias_0).SuspendLayout();
		((Control)_fraMain_1).SuspendLayout();
		((Control)_pctAlias_1).SuspendLayout();
		((Control)tbsMain).SuspendLayout();
		((Control)Tab0).SuspendLayout();
		((Control)Tab1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)cmdOK).set_AccessibleDescription(resourceManager.GetString("cmdOK.AccessibleDescription"));
		((Control)cmdOK).set_AccessibleName(resourceManager.GetString("cmdOK.AccessibleName"));
		((Control)cmdOK).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("cmdOK.Anchor")));
		((ButtonBase)cmdOK).set_BackColor(SystemColors.Control);
		((Control)cmdOK).set_BackgroundImage((Image)resourceManager.GetObject("cmdOK.BackgroundImage"));
		((Control)cmdOK).set_Cursor(Cursors.get_Default());
		((Control)cmdOK).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("cmdOK.Dock")));
		((Control)cmdOK).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("cmdOK.Enabled")));
		((ButtonBase)cmdOK).set_FlatStyle((FlatStyle)Conversions.ToInteger(resourceManager.GetObject("cmdOK.FlatStyle")));
		((Control)cmdOK).set_Font((Font)resourceManager.GetObject("cmdOK.Font"));
		((Control)cmdOK).set_ForeColor(SystemColors.ControlText);
		HelpProvider1.SetHelpKeyword((Control)(object)cmdOK, resourceManager.GetString("cmdOK.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)cmdOK, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("cmdOK.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)cmdOK, resourceManager.GetString("cmdOK.HelpString"));
		((ButtonBase)cmdOK).set_Image((Image)resourceManager.GetObject("cmdOK.Image"));
		((ButtonBase)cmdOK).set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("cmdOK.ImageAlign")));
		((ButtonBase)cmdOK).set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("cmdOK.ImageIndex")));
		((ButtonBase)cmdOK).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("cmdOK.ImeMode")));
		Button obj = cmdOK;
		object? @object = resourceManager.GetObject("cmdOK.Location");
		Point point = default(Point);
		((Control)obj).set_Location((@object != null) ? ((Point)@object) : point);
		((Control)cmdOK).set_Name("cmdOK");
		((Control)cmdOK).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("cmdOK.RightToLeft")));
		HelpProvider1.SetShowHelp((Control)(object)cmdOK, Conversions.ToBoolean(resourceManager.GetObject("cmdOK.ShowHelp")));
		Button obj2 = cmdOK;
		object? object2 = resourceManager.GetObject("cmdOK.Size");
		Size size = default(Size);
		((Control)obj2).set_Size((object2 != null) ? ((Size)object2) : size);
		((Control)cmdOK).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("cmdOK.TabIndex")));
		((Control)cmdOK).set_Tag((object)"ok and dismiss");
		((ButtonBase)cmdOK).set_Text(resourceManager.GetString("cmdOK.Text"));
		((ButtonBase)cmdOK).set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("cmdOK.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)cmdOK, resourceManager.GetString("cmdOK.ToolTip"));
		((Control)cmdOK).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("cmdOK.Visible")));
		((Control)chkConfirm).set_AccessibleDescription(resourceManager.GetString("chkConfirm.AccessibleDescription"));
		((Control)chkConfirm).set_AccessibleName(resourceManager.GetString("chkConfirm.AccessibleName"));
		((Control)chkConfirm).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("chkConfirm.Anchor")));
		chkConfirm.set_Appearance((Appearance)Conversions.ToInteger(resourceManager.GetObject("chkConfirm.Appearance")));
		((ButtonBase)chkConfirm).set_BackColor(SystemColors.ControlLight);
		((Control)chkConfirm).set_BackgroundImage((Image)resourceManager.GetObject("chkConfirm.BackgroundImage"));
		chkConfirm.set_CheckAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("chkConfirm.CheckAlign")));
		chkConfirm.set_Checked(true);
		chkConfirm.set_CheckState((CheckState)1);
		((Control)chkConfirm).set_Cursor(Cursors.get_Default());
		((Control)chkConfirm).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("chkConfirm.Dock")));
		((Control)chkConfirm).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("chkConfirm.Enabled")));
		((ButtonBase)chkConfirm).set_FlatStyle((FlatStyle)Conversions.ToInteger(resourceManager.GetObject("chkConfirm.FlatStyle")));
		((Control)chkConfirm).set_Font((Font)resourceManager.GetObject("chkConfirm.Font"));
		((Control)chkConfirm).set_ForeColor(SystemColors.ControlText);
		HelpProvider1.SetHelpKeyword((Control)(object)chkConfirm, resourceManager.GetString("chkConfirm.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)chkConfirm, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("chkConfirm.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)chkConfirm, resourceManager.GetString("chkConfirm.HelpString"));
		((ButtonBase)chkConfirm).set_Image((Image)resourceManager.GetObject("chkConfirm.Image"));
		((ButtonBase)chkConfirm).set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("chkConfirm.ImageAlign")));
		((ButtonBase)chkConfirm).set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("chkConfirm.ImageIndex")));
		((ButtonBase)chkConfirm).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("chkConfirm.ImeMode")));
		CheckBox obj3 = chkConfirm;
		object? object3 = resourceManager.GetObject("chkConfirm.Location");
		((Control)obj3).set_Location((object3 != null) ? ((Point)object3) : point);
		((Control)chkConfirm).set_Name("chkConfirm");
		((Control)chkConfirm).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("chkConfirm.RightToLeft")));
		HelpProvider1.SetShowHelp((Control)(object)chkConfirm, Conversions.ToBoolean(resourceManager.GetObject("chkConfirm.ShowHelp")));
		CheckBox obj4 = chkConfirm;
		object? object4 = resourceManager.GetObject("chkConfirm.Size");
		((Control)obj4).set_Size((object4 != null) ? ((Size)object4) : size);
		((Control)chkConfirm).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("chkConfirm.TabIndex")));
		((ButtonBase)chkConfirm).set_Text(resourceManager.GetString("chkConfirm.Text"));
		chkConfirm.set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("chkConfirm.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)chkConfirm, resourceManager.GetString("chkConfirm.ToolTip"));
		((Control)chkConfirm).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("chkConfirm.Visible")));
		((Control)cmdCancel).set_AccessibleDescription(resourceManager.GetString("cmdCancel.AccessibleDescription"));
		((Control)cmdCancel).set_AccessibleName(resourceManager.GetString("cmdCancel.AccessibleName"));
		((Control)cmdCancel).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("cmdCancel.Anchor")));
		((ButtonBase)cmdCancel).set_BackColor(SystemColors.Control);
		((Control)cmdCancel).set_BackgroundImage((Image)resourceManager.GetObject("cmdCancel.BackgroundImage"));
		((Control)cmdCancel).set_Cursor(Cursors.get_Default());
		((Control)cmdCancel).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("cmdCancel.Dock")));
		((Control)cmdCancel).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("cmdCancel.Enabled")));
		((ButtonBase)cmdCancel).set_FlatStyle((FlatStyle)Conversions.ToInteger(resourceManager.GetObject("cmdCancel.FlatStyle")));
		((Control)cmdCancel).set_Font((Font)resourceManager.GetObject("cmdCancel.Font"));
		((Control)cmdCancel).set_ForeColor(SystemColors.ControlText);
		HelpProvider1.SetHelpKeyword((Control)(object)cmdCancel, resourceManager.GetString("cmdCancel.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)cmdCancel, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("cmdCancel.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)cmdCancel, resourceManager.GetString("cmdCancel.HelpString"));
		((ButtonBase)cmdCancel).set_Image((Image)resourceManager.GetObject("cmdCancel.Image"));
		((ButtonBase)cmdCancel).set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("cmdCancel.ImageAlign")));
		((ButtonBase)cmdCancel).set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("cmdCancel.ImageIndex")));
		((ButtonBase)cmdCancel).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("cmdCancel.ImeMode")));
		Button obj5 = cmdCancel;
		object? object5 = resourceManager.GetObject("cmdCancel.Location");
		((Control)obj5).set_Location((object5 != null) ? ((Point)object5) : point);
		((Control)cmdCancel).set_Name("cmdCancel");
		((Control)cmdCancel).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("cmdCancel.RightToLeft")));
		HelpProvider1.SetShowHelp((Control)(object)cmdCancel, Conversions.ToBoolean(resourceManager.GetObject("cmdCancel.ShowHelp")));
		Button obj6 = cmdCancel;
		object? object6 = resourceManager.GetObject("cmdCancel.Size");
		((Control)obj6).set_Size((object6 != null) ? ((Size)object6) : size);
		((Control)cmdCancel).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("cmdCancel.TabIndex")));
		((Control)cmdCancel).set_Tag((object)"cancel and dismiss");
		((ButtonBase)cmdCancel).set_Text(resourceManager.GetString("cmdCancel.Text"));
		((ButtonBase)cmdCancel).set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("cmdCancel.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)cmdCancel, resourceManager.GetString("cmdCancel.ToolTip"));
		((Control)cmdCancel).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("cmdCancel.Visible")));
		((Control)cmdApply).set_AccessibleDescription(resourceManager.GetString("cmdApply.AccessibleDescription"));
		((Control)cmdApply).set_AccessibleName(resourceManager.GetString("cmdApply.AccessibleName"));
		((Control)cmdApply).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("cmdApply.Anchor")));
		((ButtonBase)cmdApply).set_BackColor(SystemColors.Control);
		((Control)cmdApply).set_BackgroundImage((Image)resourceManager.GetObject("cmdApply.BackgroundImage"));
		((Control)cmdApply).set_Cursor(Cursors.get_Default());
		((Control)cmdApply).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("cmdApply.Dock")));
		((Control)cmdApply).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("cmdApply.Enabled")));
		((ButtonBase)cmdApply).set_FlatStyle((FlatStyle)Conversions.ToInteger(resourceManager.GetObject("cmdApply.FlatStyle")));
		((Control)cmdApply).set_Font((Font)resourceManager.GetObject("cmdApply.Font"));
		((Control)cmdApply).set_ForeColor(SystemColors.ControlText);
		HelpProvider1.SetHelpKeyword((Control)(object)cmdApply, resourceManager.GetString("cmdApply.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)cmdApply, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("cmdApply.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)cmdApply, resourceManager.GetString("cmdApply.HelpString"));
		((ButtonBase)cmdApply).set_Image((Image)resourceManager.GetObject("cmdApply.Image"));
		((ButtonBase)cmdApply).set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("cmdApply.ImageAlign")));
		((ButtonBase)cmdApply).set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("cmdApply.ImageIndex")));
		((ButtonBase)cmdApply).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("cmdApply.ImeMode")));
		Button obj7 = cmdApply;
		object? object7 = resourceManager.GetObject("cmdApply.Location");
		((Control)obj7).set_Location((object7 != null) ? ((Point)object7) : point);
		((Control)cmdApply).set_Name("cmdApply");
		((Control)cmdApply).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("cmdApply.RightToLeft")));
		HelpProvider1.SetShowHelp((Control)(object)cmdApply, Conversions.ToBoolean(resourceManager.GetObject("cmdApply.ShowHelp")));
		Button obj8 = cmdApply;
		object? object8 = resourceManager.GetObject("cmdApply.Size");
		((Control)obj8).set_Size((object8 != null) ? ((Size)object8) : size);
		((Control)cmdApply).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("cmdApply.TabIndex")));
		((Control)cmdApply).set_Tag((object)"apply current changes");
		((ButtonBase)cmdApply).set_Text(resourceManager.GetString("cmdApply.Text"));
		((ButtonBase)cmdApply).set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("cmdApply.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)cmdApply, resourceManager.GetString("cmdApply.ToolTip"));
		((Control)cmdApply).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("cmdApply.Visible")));
		((Control)_fraMain_0).set_AccessibleDescription(resourceManager.GetString("_fraMain_0.AccessibleDescription"));
		((Control)_fraMain_0).set_AccessibleName(resourceManager.GetString("_fraMain_0.AccessibleName"));
		((Control)_fraMain_0).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("_fraMain_0.Anchor")));
		((Control)_fraMain_0).set_BackColor(SystemColors.Control);
		((Control)_fraMain_0).set_BackgroundImage((Image)resourceManager.GetObject("_fraMain_0.BackgroundImage"));
		((Control)_fraMain_0).get_Controls().Add((Control)(object)_pctAlias_0);
		((Control)_fraMain_0).get_Controls().Add((Control)(object)_cmdEdit_0);
		((Control)_fraMain_0).get_Controls().Add((Control)(object)_cmdRemove_0);
		((Control)_fraMain_0).get_Controls().Add((Control)(object)_cmdAdd_0);
		((Control)_fraMain_0).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("_fraMain_0.Dock")));
		((Control)_fraMain_0).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("_fraMain_0.Enabled")));
		((Control)_fraMain_0).set_Font((Font)resourceManager.GetObject("_fraMain_0.Font"));
		((Control)_fraMain_0).set_ForeColor(SystemColors.ControlText);
		HelpProvider1.SetHelpKeyword((Control)(object)_fraMain_0, resourceManager.GetString("_fraMain_0.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)_fraMain_0, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("_fraMain_0.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)_fraMain_0, resourceManager.GetString("_fraMain_0.HelpString"));
		((Control)_fraMain_0).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("_fraMain_0.ImeMode")));
		GroupBox fraMain_ = _fraMain_0;
		object? object9 = resourceManager.GetObject("_fraMain_0.Location");
		((Control)fraMain_).set_Location((object9 != null) ? ((Point)object9) : point);
		((Control)_fraMain_0).set_Name("_fraMain_0");
		((Control)_fraMain_0).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("_fraMain_0.RightToLeft")));
		HelpProvider1.SetShowHelp((Control)(object)_fraMain_0, Conversions.ToBoolean(resourceManager.GetObject("_fraMain_0.ShowHelp")));
		GroupBox fraMain_2 = _fraMain_0;
		object? object10 = resourceManager.GetObject("_fraMain_0.Size");
		((Control)fraMain_2).set_Size((object10 != null) ? ((Size)object10) : size);
		((Control)_fraMain_0).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("_fraMain_0.TabIndex")));
		_fraMain_0.set_TabStop(false);
		_fraMain_0.set_Text(resourceManager.GetString("_fraMain_0.Text"));
		ToolTip1.SetToolTip((Control)(object)_fraMain_0, resourceManager.GetString("_fraMain_0.ToolTip"));
		((Control)_fraMain_0).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("_fraMain_0.Visible")));
		((Control)_pctAlias_0).set_AccessibleDescription(resourceManager.GetString("_pctAlias_0.AccessibleDescription"));
		((Control)_pctAlias_0).set_AccessibleName(resourceManager.GetString("_pctAlias_0.AccessibleName"));
		((Control)_pctAlias_0).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("_pctAlias_0.Anchor")));
		((ScrollableControl)_pctAlias_0).set_AutoScroll(Conversions.ToBoolean(resourceManager.GetObject("_pctAlias_0.AutoScroll")));
		Panel pctAlias_ = _pctAlias_0;
		object? object11 = resourceManager.GetObject("_pctAlias_0.AutoScrollMargin");
		((ScrollableControl)pctAlias_).set_AutoScrollMargin((object11 != null) ? ((Size)object11) : size);
		Panel pctAlias_2 = _pctAlias_0;
		object? object12 = resourceManager.GetObject("_pctAlias_0.AutoScrollMinSize");
		((ScrollableControl)pctAlias_2).set_AutoScrollMinSize((object12 != null) ? ((Size)object12) : size);
		((Control)_pctAlias_0).set_BackColor(SystemColors.Control);
		((Control)_pctAlias_0).set_BackgroundImage((Image)resourceManager.GetObject("_pctAlias_0.BackgroundImage"));
		_pctAlias_0.set_BorderStyle((BorderStyle)2);
		((Control)_pctAlias_0).get_Controls().Add((Control)(object)_lvwAlias);
		((Control)_pctAlias_0).set_Cursor(Cursors.get_Default());
		((Control)_pctAlias_0).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("_pctAlias_0.Dock")));
		((Control)_pctAlias_0).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("_pctAlias_0.Enabled")));
		((Control)_pctAlias_0).set_Font((Font)resourceManager.GetObject("_pctAlias_0.Font"));
		((Control)_pctAlias_0).set_ForeColor(SystemColors.ControlText);
		HelpProvider1.SetHelpKeyword((Control)(object)_pctAlias_0, resourceManager.GetString("_pctAlias_0.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)_pctAlias_0, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("_pctAlias_0.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)_pctAlias_0, resourceManager.GetString("_pctAlias_0.HelpString"));
		((Control)_pctAlias_0).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("_pctAlias_0.ImeMode")));
		Panel pctAlias_3 = _pctAlias_0;
		object? object13 = resourceManager.GetObject("_pctAlias_0.Location");
		((Control)pctAlias_3).set_Location((object13 != null) ? ((Point)object13) : point);
		((Control)_pctAlias_0).set_Name("_pctAlias_0");
		((Control)_pctAlias_0).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("_pctAlias_0.RightToLeft")));
		HelpProvider1.SetShowHelp((Control)(object)_pctAlias_0, Conversions.ToBoolean(resourceManager.GetObject("_pctAlias_0.ShowHelp")));
		Panel pctAlias_4 = _pctAlias_0;
		object? object14 = resourceManager.GetObject("_pctAlias_0.Size");
		((Control)pctAlias_4).set_Size((object14 != null) ? ((Size)object14) : size);
		((Control)_pctAlias_0).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("_pctAlias_0.TabIndex")));
		_pctAlias_0.set_TabStop(true);
		_pctAlias_0.set_Text(resourceManager.GetString("_pctAlias_0.Text"));
		ToolTip1.SetToolTip((Control)(object)_pctAlias_0, resourceManager.GetString("_pctAlias_0.ToolTip"));
		((Control)_pctAlias_0).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("_pctAlias_0.Visible")));
		((Control)_lvwAlias).set_AccessibleDescription(resourceManager.GetString("_lvwAlias.AccessibleDescription"));
		((Control)_lvwAlias).set_AccessibleName(resourceManager.GetString("_lvwAlias.AccessibleName"));
		_lvwAlias.set_Alignment((ListViewAlignment)Conversions.ToInteger(resourceManager.GetObject("_lvwAlias.Alignment")));
		_lvwAlias.set_AllowColumnReorder(true);
		((Control)_lvwAlias).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("_lvwAlias.Anchor")));
		((Control)_lvwAlias).set_BackgroundImage((Image)resourceManager.GetObject("_lvwAlias.BackgroundImage"));
		((Control)_lvwAlias).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("_lvwAlias.Dock")));
		((Control)_lvwAlias).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("_lvwAlias.Enabled")));
		((Control)_lvwAlias).set_Font((Font)resourceManager.GetObject("_lvwAlias.Font"));
		HelpProvider1.SetHelpKeyword((Control)(object)_lvwAlias, resourceManager.GetString("_lvwAlias.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)_lvwAlias, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("_lvwAlias.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)_lvwAlias, resourceManager.GetString("_lvwAlias.HelpString"));
		((Control)_lvwAlias).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("_lvwAlias.ImeMode")));
		_lvwAlias.set_LabelWrap(Conversions.ToBoolean(resourceManager.GetObject("_lvwAlias.LabelWrap")));
		ListView obj9 = _lvwAlias;
		object? object15 = resourceManager.GetObject("_lvwAlias.Location");
		((Control)obj9).set_Location((object15 != null) ? ((Point)object15) : point);
		_lvwAlias.set_MultiSelect(false);
		((Control)_lvwAlias).set_Name("_lvwAlias");
		((Control)_lvwAlias).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("_lvwAlias.RightToLeft")));
		HelpProvider1.SetShowHelp((Control)(object)_lvwAlias, Conversions.ToBoolean(resourceManager.GetObject("_lvwAlias.ShowHelp")));
		ListView obj10 = _lvwAlias;
		object? object16 = resourceManager.GetObject("_lvwAlias.Size");
		((Control)obj10).set_Size((object16 != null) ? ((Size)object16) : size);
		_lvwAlias.set_Sorting((SortOrder)1);
		((Control)_lvwAlias).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("_lvwAlias.TabIndex")));
		_lvwAlias.set_Text(resourceManager.GetString("_lvwAlias.Text"));
		ToolTip1.SetToolTip((Control)(object)_lvwAlias, resourceManager.GetString("_lvwAlias.ToolTip"));
		_lvwAlias.set_View((View)1);
		((Control)_lvwAlias).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("_lvwAlias.Visible")));
		((Control)_cmdEdit_0).set_AccessibleDescription(resourceManager.GetString("_cmdEdit_0.AccessibleDescription"));
		((Control)_cmdEdit_0).set_AccessibleName(resourceManager.GetString("_cmdEdit_0.AccessibleName"));
		((Control)_cmdEdit_0).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("_cmdEdit_0.Anchor")));
		((ButtonBase)_cmdEdit_0).set_BackColor(SystemColors.Control);
		((Control)_cmdEdit_0).set_BackgroundImage((Image)resourceManager.GetObject("_cmdEdit_0.BackgroundImage"));
		((Control)_cmdEdit_0).set_Cursor(Cursors.get_Default());
		((Control)_cmdEdit_0).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("_cmdEdit_0.Dock")));
		((Control)_cmdEdit_0).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("_cmdEdit_0.Enabled")));
		((ButtonBase)_cmdEdit_0).set_FlatStyle((FlatStyle)Conversions.ToInteger(resourceManager.GetObject("_cmdEdit_0.FlatStyle")));
		((Control)_cmdEdit_0).set_Font((Font)resourceManager.GetObject("_cmdEdit_0.Font"));
		((Control)_cmdEdit_0).set_ForeColor(SystemColors.ControlText);
		HelpProvider1.SetHelpKeyword((Control)(object)_cmdEdit_0, resourceManager.GetString("_cmdEdit_0.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)_cmdEdit_0, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("_cmdEdit_0.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)_cmdEdit_0, resourceManager.GetString("_cmdEdit_0.HelpString"));
		((ButtonBase)_cmdEdit_0).set_Image((Image)resourceManager.GetObject("_cmdEdit_0.Image"));
		((ButtonBase)_cmdEdit_0).set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("_cmdEdit_0.ImageAlign")));
		((ButtonBase)_cmdEdit_0).set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("_cmdEdit_0.ImageIndex")));
		((ButtonBase)_cmdEdit_0).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("_cmdEdit_0.ImeMode")));
		Button cmdEdit_ = _cmdEdit_0;
		object? object17 = resourceManager.GetObject("_cmdEdit_0.Location");
		((Control)cmdEdit_).set_Location((object17 != null) ? ((Point)object17) : point);
		((Control)_cmdEdit_0).set_Name("_cmdEdit_0");
		((Control)_cmdEdit_0).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("_cmdEdit_0.RightToLeft")));
		HelpProvider1.SetShowHelp((Control)(object)_cmdEdit_0, Conversions.ToBoolean(resourceManager.GetObject("_cmdEdit_0.ShowHelp")));
		Button cmdEdit_2 = _cmdEdit_0;
		object? object18 = resourceManager.GetObject("_cmdEdit_0.Size");
		((Control)cmdEdit_2).set_Size((object18 != null) ? ((Size)object18) : size);
		((Control)_cmdEdit_0).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("_cmdEdit_0.TabIndex")));
		((Control)_cmdEdit_0).set_TabStop(false);
		((ButtonBase)_cmdEdit_0).set_Text(resourceManager.GetString("_cmdEdit_0.Text"));
		((ButtonBase)_cmdEdit_0).set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("_cmdEdit_0.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)_cmdEdit_0, resourceManager.GetString("_cmdEdit_0.ToolTip"));
		((Control)_cmdEdit_0).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("_cmdEdit_0.Visible")));
		((Control)_cmdRemove_0).set_AccessibleDescription(resourceManager.GetString("_cmdRemove_0.AccessibleDescription"));
		((Control)_cmdRemove_0).set_AccessibleName(resourceManager.GetString("_cmdRemove_0.AccessibleName"));
		((Control)_cmdRemove_0).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("_cmdRemove_0.Anchor")));
		((ButtonBase)_cmdRemove_0).set_BackColor(SystemColors.Control);
		((Control)_cmdRemove_0).set_BackgroundImage((Image)resourceManager.GetObject("_cmdRemove_0.BackgroundImage"));
		((Control)_cmdRemove_0).set_Cursor(Cursors.get_Default());
		((Control)_cmdRemove_0).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("_cmdRemove_0.Dock")));
		((Control)_cmdRemove_0).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("_cmdRemove_0.Enabled")));
		((ButtonBase)_cmdRemove_0).set_FlatStyle((FlatStyle)Conversions.ToInteger(resourceManager.GetObject("_cmdRemove_0.FlatStyle")));
		((Control)_cmdRemove_0).set_Font((Font)resourceManager.GetObject("_cmdRemove_0.Font"));
		((Control)_cmdRemove_0).set_ForeColor(SystemColors.ControlText);
		HelpProvider1.SetHelpKeyword((Control)(object)_cmdRemove_0, resourceManager.GetString("_cmdRemove_0.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)_cmdRemove_0, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("_cmdRemove_0.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)_cmdRemove_0, resourceManager.GetString("_cmdRemove_0.HelpString"));
		((ButtonBase)_cmdRemove_0).set_Image((Image)resourceManager.GetObject("_cmdRemove_0.Image"));
		((ButtonBase)_cmdRemove_0).set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("_cmdRemove_0.ImageAlign")));
		((ButtonBase)_cmdRemove_0).set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("_cmdRemove_0.ImageIndex")));
		((ButtonBase)_cmdRemove_0).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("_cmdRemove_0.ImeMode")));
		Button cmdRemove_ = _cmdRemove_0;
		object? object19 = resourceManager.GetObject("_cmdRemove_0.Location");
		((Control)cmdRemove_).set_Location((object19 != null) ? ((Point)object19) : point);
		((Control)_cmdRemove_0).set_Name("_cmdRemove_0");
		((Control)_cmdRemove_0).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("_cmdRemove_0.RightToLeft")));
		HelpProvider1.SetShowHelp((Control)(object)_cmdRemove_0, Conversions.ToBoolean(resourceManager.GetObject("_cmdRemove_0.ShowHelp")));
		Button cmdRemove_2 = _cmdRemove_0;
		object? object20 = resourceManager.GetObject("_cmdRemove_0.Size");
		((Control)cmdRemove_2).set_Size((object20 != null) ? ((Size)object20) : size);
		((Control)_cmdRemove_0).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("_cmdRemove_0.TabIndex")));
		((Control)_cmdRemove_0).set_TabStop(false);
		((ButtonBase)_cmdRemove_0).set_Text(resourceManager.GetString("_cmdRemove_0.Text"));
		((ButtonBase)_cmdRemove_0).set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("_cmdRemove_0.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)_cmdRemove_0, resourceManager.GetString("_cmdRemove_0.ToolTip"));
		((Control)_cmdRemove_0).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("_cmdRemove_0.Visible")));
		((Control)_cmdAdd_0).set_AccessibleDescription(resourceManager.GetString("_cmdAdd_0.AccessibleDescription"));
		((Control)_cmdAdd_0).set_AccessibleName(resourceManager.GetString("_cmdAdd_0.AccessibleName"));
		((Control)_cmdAdd_0).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("_cmdAdd_0.Anchor")));
		((ButtonBase)_cmdAdd_0).set_BackColor(SystemColors.Control);
		((Control)_cmdAdd_0).set_BackgroundImage((Image)resourceManager.GetObject("_cmdAdd_0.BackgroundImage"));
		((Control)_cmdAdd_0).set_Cursor(Cursors.get_Default());
		((Control)_cmdAdd_0).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("_cmdAdd_0.Dock")));
		((Control)_cmdAdd_0).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("_cmdAdd_0.Enabled")));
		((ButtonBase)_cmdAdd_0).set_FlatStyle((FlatStyle)Conversions.ToInteger(resourceManager.GetObject("_cmdAdd_0.FlatStyle")));
		((Control)_cmdAdd_0).set_Font((Font)resourceManager.GetObject("_cmdAdd_0.Font"));
		((Control)_cmdAdd_0).set_ForeColor(SystemColors.ControlText);
		HelpProvider1.SetHelpKeyword((Control)(object)_cmdAdd_0, resourceManager.GetString("_cmdAdd_0.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)_cmdAdd_0, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("_cmdAdd_0.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)_cmdAdd_0, resourceManager.GetString("_cmdAdd_0.HelpString"));
		((ButtonBase)_cmdAdd_0).set_Image((Image)resourceManager.GetObject("_cmdAdd_0.Image"));
		((ButtonBase)_cmdAdd_0).set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("_cmdAdd_0.ImageAlign")));
		((ButtonBase)_cmdAdd_0).set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("_cmdAdd_0.ImageIndex")));
		((ButtonBase)_cmdAdd_0).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("_cmdAdd_0.ImeMode")));
		Button cmdAdd_ = _cmdAdd_0;
		object? object21 = resourceManager.GetObject("_cmdAdd_0.Location");
		((Control)cmdAdd_).set_Location((object21 != null) ? ((Point)object21) : point);
		((Control)_cmdAdd_0).set_Name("_cmdAdd_0");
		((Control)_cmdAdd_0).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("_cmdAdd_0.RightToLeft")));
		HelpProvider1.SetShowHelp((Control)(object)_cmdAdd_0, Conversions.ToBoolean(resourceManager.GetObject("_cmdAdd_0.ShowHelp")));
		Button cmdAdd_2 = _cmdAdd_0;
		object? object22 = resourceManager.GetObject("_cmdAdd_0.Size");
		((Control)cmdAdd_2).set_Size((object22 != null) ? ((Size)object22) : size);
		((Control)_cmdAdd_0).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("_cmdAdd_0.TabIndex")));
		((ButtonBase)_cmdAdd_0).set_Text(resourceManager.GetString("_cmdAdd_0.Text"));
		((ButtonBase)_cmdAdd_0).set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("_cmdAdd_0.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)_cmdAdd_0, resourceManager.GetString("_cmdAdd_0.ToolTip"));
		((Control)_cmdAdd_0).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("_cmdAdd_0.Visible")));
		((Control)_fraMain_1).set_AccessibleDescription(resourceManager.GetString("_fraMain_1.AccessibleDescription"));
		((Control)_fraMain_1).set_AccessibleName(resourceManager.GetString("_fraMain_1.AccessibleName"));
		((Control)_fraMain_1).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("_fraMain_1.Anchor")));
		((Control)_fraMain_1).set_BackColor(SystemColors.Control);
		((Control)_fraMain_1).set_BackgroundImage((Image)resourceManager.GetObject("_fraMain_1.BackgroundImage"));
		((Control)_fraMain_1).get_Controls().Add((Control)(object)_pctAlias_1);
		((Control)_fraMain_1).get_Controls().Add((Control)(object)_cmdEdit_1);
		((Control)_fraMain_1).get_Controls().Add((Control)(object)_cmdAdd_1);
		((Control)_fraMain_1).get_Controls().Add((Control)(object)_cmdRemove_1);
		((Control)_fraMain_1).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("_fraMain_1.Dock")));
		((Control)_fraMain_1).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("_fraMain_1.Enabled")));
		((Control)_fraMain_1).set_Font((Font)resourceManager.GetObject("_fraMain_1.Font"));
		((Control)_fraMain_1).set_ForeColor(SystemColors.ControlText);
		HelpProvider1.SetHelpKeyword((Control)(object)_fraMain_1, resourceManager.GetString("_fraMain_1.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)_fraMain_1, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("_fraMain_1.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)_fraMain_1, resourceManager.GetString("_fraMain_1.HelpString"));
		((Control)_fraMain_1).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("_fraMain_1.ImeMode")));
		GroupBox fraMain_3 = _fraMain_1;
		object? object23 = resourceManager.GetObject("_fraMain_1.Location");
		((Control)fraMain_3).set_Location((object23 != null) ? ((Point)object23) : point);
		((Control)_fraMain_1).set_Name("_fraMain_1");
		((Control)_fraMain_1).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("_fraMain_1.RightToLeft")));
		HelpProvider1.SetShowHelp((Control)(object)_fraMain_1, Conversions.ToBoolean(resourceManager.GetObject("_fraMain_1.ShowHelp")));
		GroupBox fraMain_4 = _fraMain_1;
		object? object24 = resourceManager.GetObject("_fraMain_1.Size");
		((Control)fraMain_4).set_Size((object24 != null) ? ((Size)object24) : size);
		((Control)_fraMain_1).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("_fraMain_1.TabIndex")));
		_fraMain_1.set_TabStop(false);
		_fraMain_1.set_Text(resourceManager.GetString("_fraMain_1.Text"));
		ToolTip1.SetToolTip((Control)(object)_fraMain_1, resourceManager.GetString("_fraMain_1.ToolTip"));
		((Control)_fraMain_1).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("_fraMain_1.Visible")));
		((Control)_pctAlias_1).set_AccessibleDescription(resourceManager.GetString("_pctAlias_1.AccessibleDescription"));
		((Control)_pctAlias_1).set_AccessibleName(resourceManager.GetString("_pctAlias_1.AccessibleName"));
		((Control)_pctAlias_1).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("_pctAlias_1.Anchor")));
		((ScrollableControl)_pctAlias_1).set_AutoScroll(Conversions.ToBoolean(resourceManager.GetObject("_pctAlias_1.AutoScroll")));
		Panel pctAlias_5 = _pctAlias_1;
		object? object25 = resourceManager.GetObject("_pctAlias_1.AutoScrollMargin");
		((ScrollableControl)pctAlias_5).set_AutoScrollMargin((object25 != null) ? ((Size)object25) : size);
		Panel pctAlias_6 = _pctAlias_1;
		object? object26 = resourceManager.GetObject("_pctAlias_1.AutoScrollMinSize");
		((ScrollableControl)pctAlias_6).set_AutoScrollMinSize((object26 != null) ? ((Size)object26) : size);
		((Control)_pctAlias_1).set_BackColor(SystemColors.Control);
		((Control)_pctAlias_1).set_BackgroundImage((Image)resourceManager.GetObject("_pctAlias_1.BackgroundImage"));
		_pctAlias_1.set_BorderStyle((BorderStyle)2);
		((Control)_pctAlias_1).get_Controls().Add((Control)(object)_lvwShell);
		((Control)_pctAlias_1).set_Cursor(Cursors.get_Default());
		((Control)_pctAlias_1).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("_pctAlias_1.Dock")));
		((Control)_pctAlias_1).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("_pctAlias_1.Enabled")));
		((Control)_pctAlias_1).set_Font((Font)resourceManager.GetObject("_pctAlias_1.Font"));
		((Control)_pctAlias_1).set_ForeColor(SystemColors.ControlText);
		HelpProvider1.SetHelpKeyword((Control)(object)_pctAlias_1, resourceManager.GetString("_pctAlias_1.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)_pctAlias_1, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("_pctAlias_1.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)_pctAlias_1, resourceManager.GetString("_pctAlias_1.HelpString"));
		((Control)_pctAlias_1).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("_pctAlias_1.ImeMode")));
		Panel pctAlias_7 = _pctAlias_1;
		object? object27 = resourceManager.GetObject("_pctAlias_1.Location");
		((Control)pctAlias_7).set_Location((object27 != null) ? ((Point)object27) : point);
		((Control)_pctAlias_1).set_Name("_pctAlias_1");
		((Control)_pctAlias_1).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("_pctAlias_1.RightToLeft")));
		HelpProvider1.SetShowHelp((Control)(object)_pctAlias_1, Conversions.ToBoolean(resourceManager.GetObject("_pctAlias_1.ShowHelp")));
		Panel pctAlias_8 = _pctAlias_1;
		object? object28 = resourceManager.GetObject("_pctAlias_1.Size");
		((Control)pctAlias_8).set_Size((object28 != null) ? ((Size)object28) : size);
		((Control)_pctAlias_1).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("_pctAlias_1.TabIndex")));
		_pctAlias_1.set_TabStop(true);
		_pctAlias_1.set_Text(resourceManager.GetString("_pctAlias_1.Text"));
		ToolTip1.SetToolTip((Control)(object)_pctAlias_1, resourceManager.GetString("_pctAlias_1.ToolTip"));
		((Control)_pctAlias_1).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("_pctAlias_1.Visible")));
		((Control)_lvwShell).set_AccessibleDescription(resourceManager.GetString("_lvwShell.AccessibleDescription"));
		((Control)_lvwShell).set_AccessibleName(resourceManager.GetString("_lvwShell.AccessibleName"));
		_lvwShell.set_Alignment((ListViewAlignment)Conversions.ToInteger(resourceManager.GetObject("_lvwShell.Alignment")));
		_lvwShell.set_AllowColumnReorder(true);
		((Control)_lvwShell).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("_lvwShell.Anchor")));
		((Control)_lvwShell).set_BackgroundImage((Image)resourceManager.GetObject("_lvwShell.BackgroundImage"));
		((Control)_lvwShell).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("_lvwShell.Dock")));
		((Control)_lvwShell).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("_lvwShell.Enabled")));
		((Control)_lvwShell).set_Font((Font)resourceManager.GetObject("_lvwShell.Font"));
		HelpProvider1.SetHelpKeyword((Control)(object)_lvwShell, resourceManager.GetString("_lvwShell.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)_lvwShell, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("_lvwShell.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)_lvwShell, resourceManager.GetString("_lvwShell.HelpString"));
		((Control)_lvwShell).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("_lvwShell.ImeMode")));
		_lvwShell.set_LabelWrap(Conversions.ToBoolean(resourceManager.GetObject("_lvwShell.LabelWrap")));
		ListView lvwShell = _lvwShell;
		object? object29 = resourceManager.GetObject("_lvwShell.Location");
		((Control)lvwShell).set_Location((object29 != null) ? ((Point)object29) : point);
		_lvwShell.set_MultiSelect(false);
		((Control)_lvwShell).set_Name("_lvwShell");
		((Control)_lvwShell).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("_lvwShell.RightToLeft")));
		HelpProvider1.SetShowHelp((Control)(object)_lvwShell, Conversions.ToBoolean(resourceManager.GetObject("_lvwShell.ShowHelp")));
		ListView lvwShell2 = _lvwShell;
		object? object30 = resourceManager.GetObject("_lvwShell.Size");
		((Control)lvwShell2).set_Size((object30 != null) ? ((Size)object30) : size);
		_lvwShell.set_Sorting((SortOrder)1);
		((Control)_lvwShell).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("_lvwShell.TabIndex")));
		_lvwShell.set_Text(resourceManager.GetString("_lvwShell.Text"));
		ToolTip1.SetToolTip((Control)(object)_lvwShell, resourceManager.GetString("_lvwShell.ToolTip"));
		_lvwShell.set_View((View)1);
		((Control)_lvwShell).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("_lvwShell.Visible")));
		((Control)_cmdEdit_1).set_AccessibleDescription(resourceManager.GetString("_cmdEdit_1.AccessibleDescription"));
		((Control)_cmdEdit_1).set_AccessibleName(resourceManager.GetString("_cmdEdit_1.AccessibleName"));
		((Control)_cmdEdit_1).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("_cmdEdit_1.Anchor")));
		((ButtonBase)_cmdEdit_1).set_BackColor(SystemColors.Control);
		((Control)_cmdEdit_1).set_BackgroundImage((Image)resourceManager.GetObject("_cmdEdit_1.BackgroundImage"));
		((Control)_cmdEdit_1).set_Cursor(Cursors.get_Default());
		((Control)_cmdEdit_1).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("_cmdEdit_1.Dock")));
		((Control)_cmdEdit_1).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("_cmdEdit_1.Enabled")));
		((ButtonBase)_cmdEdit_1).set_FlatStyle((FlatStyle)Conversions.ToInteger(resourceManager.GetObject("_cmdEdit_1.FlatStyle")));
		((Control)_cmdEdit_1).set_Font((Font)resourceManager.GetObject("_cmdEdit_1.Font"));
		((Control)_cmdEdit_1).set_ForeColor(SystemColors.ControlText);
		HelpProvider1.SetHelpKeyword((Control)(object)_cmdEdit_1, resourceManager.GetString("_cmdEdit_1.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)_cmdEdit_1, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("_cmdEdit_1.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)_cmdEdit_1, resourceManager.GetString("_cmdEdit_1.HelpString"));
		((ButtonBase)_cmdEdit_1).set_Image((Image)resourceManager.GetObject("_cmdEdit_1.Image"));
		((ButtonBase)_cmdEdit_1).set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("_cmdEdit_1.ImageAlign")));
		((ButtonBase)_cmdEdit_1).set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("_cmdEdit_1.ImageIndex")));
		((ButtonBase)_cmdEdit_1).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("_cmdEdit_1.ImeMode")));
		Button cmdEdit_3 = _cmdEdit_1;
		object? object31 = resourceManager.GetObject("_cmdEdit_1.Location");
		((Control)cmdEdit_3).set_Location((object31 != null) ? ((Point)object31) : point);
		((Control)_cmdEdit_1).set_Name("_cmdEdit_1");
		((Control)_cmdEdit_1).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("_cmdEdit_1.RightToLeft")));
		HelpProvider1.SetShowHelp((Control)(object)_cmdEdit_1, Conversions.ToBoolean(resourceManager.GetObject("_cmdEdit_1.ShowHelp")));
		Button cmdEdit_4 = _cmdEdit_1;
		object? object32 = resourceManager.GetObject("_cmdEdit_1.Size");
		((Control)cmdEdit_4).set_Size((object32 != null) ? ((Size)object32) : size);
		((Control)_cmdEdit_1).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("_cmdEdit_1.TabIndex")));
		((Control)_cmdEdit_1).set_Tag((object)"edit an alias");
		((ButtonBase)_cmdEdit_1).set_Text(resourceManager.GetString("_cmdEdit_1.Text"));
		((ButtonBase)_cmdEdit_1).set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("_cmdEdit_1.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)_cmdEdit_1, resourceManager.GetString("_cmdEdit_1.ToolTip"));
		((Control)_cmdEdit_1).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("_cmdEdit_1.Visible")));
		((Control)_cmdAdd_1).set_AccessibleDescription(resourceManager.GetString("_cmdAdd_1.AccessibleDescription"));
		((Control)_cmdAdd_1).set_AccessibleName(resourceManager.GetString("_cmdAdd_1.AccessibleName"));
		((Control)_cmdAdd_1).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("_cmdAdd_1.Anchor")));
		((ButtonBase)_cmdAdd_1).set_BackColor(SystemColors.Control);
		((Control)_cmdAdd_1).set_BackgroundImage((Image)resourceManager.GetObject("_cmdAdd_1.BackgroundImage"));
		((Control)_cmdAdd_1).set_Cursor(Cursors.get_Default());
		((Control)_cmdAdd_1).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("_cmdAdd_1.Dock")));
		((Control)_cmdAdd_1).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("_cmdAdd_1.Enabled")));
		((ButtonBase)_cmdAdd_1).set_FlatStyle((FlatStyle)Conversions.ToInteger(resourceManager.GetObject("_cmdAdd_1.FlatStyle")));
		((Control)_cmdAdd_1).set_Font((Font)resourceManager.GetObject("_cmdAdd_1.Font"));
		((Control)_cmdAdd_1).set_ForeColor(SystemColors.ControlText);
		HelpProvider1.SetHelpKeyword((Control)(object)_cmdAdd_1, resourceManager.GetString("_cmdAdd_1.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)_cmdAdd_1, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("_cmdAdd_1.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)_cmdAdd_1, resourceManager.GetString("_cmdAdd_1.HelpString"));
		((ButtonBase)_cmdAdd_1).set_Image((Image)resourceManager.GetObject("_cmdAdd_1.Image"));
		((ButtonBase)_cmdAdd_1).set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("_cmdAdd_1.ImageAlign")));
		((ButtonBase)_cmdAdd_1).set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("_cmdAdd_1.ImageIndex")));
		((ButtonBase)_cmdAdd_1).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("_cmdAdd_1.ImeMode")));
		Button cmdAdd_3 = _cmdAdd_1;
		object? object33 = resourceManager.GetObject("_cmdAdd_1.Location");
		((Control)cmdAdd_3).set_Location((object33 != null) ? ((Point)object33) : point);
		((Control)_cmdAdd_1).set_Name("_cmdAdd_1");
		((Control)_cmdAdd_1).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("_cmdAdd_1.RightToLeft")));
		HelpProvider1.SetShowHelp((Control)(object)_cmdAdd_1, Conversions.ToBoolean(resourceManager.GetObject("_cmdAdd_1.ShowHelp")));
		Button cmdAdd_4 = _cmdAdd_1;
		object? object34 = resourceManager.GetObject("_cmdAdd_1.Size");
		((Control)cmdAdd_4).set_Size((object34 != null) ? ((Size)object34) : size);
		((Control)_cmdAdd_1).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("_cmdAdd_1.TabIndex")));
		((Control)_cmdAdd_1).set_Tag((object)"add new alias");
		((ButtonBase)_cmdAdd_1).set_Text(resourceManager.GetString("_cmdAdd_1.Text"));
		((ButtonBase)_cmdAdd_1).set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("_cmdAdd_1.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)_cmdAdd_1, resourceManager.GetString("_cmdAdd_1.ToolTip"));
		((Control)_cmdAdd_1).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("_cmdAdd_1.Visible")));
		((Control)_cmdRemove_1).set_AccessibleDescription(resourceManager.GetString("_cmdRemove_1.AccessibleDescription"));
		((Control)_cmdRemove_1).set_AccessibleName(resourceManager.GetString("_cmdRemove_1.AccessibleName"));
		((Control)_cmdRemove_1).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("_cmdRemove_1.Anchor")));
		((ButtonBase)_cmdRemove_1).set_BackColor(SystemColors.Control);
		((Control)_cmdRemove_1).set_BackgroundImage((Image)resourceManager.GetObject("_cmdRemove_1.BackgroundImage"));
		((Control)_cmdRemove_1).set_Cursor(Cursors.get_Default());
		((Control)_cmdRemove_1).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("_cmdRemove_1.Dock")));
		((Control)_cmdRemove_1).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("_cmdRemove_1.Enabled")));
		((ButtonBase)_cmdRemove_1).set_FlatStyle((FlatStyle)Conversions.ToInteger(resourceManager.GetObject("_cmdRemove_1.FlatStyle")));
		((Control)_cmdRemove_1).set_Font((Font)resourceManager.GetObject("_cmdRemove_1.Font"));
		((Control)_cmdRemove_1).set_ForeColor(SystemColors.ControlText);
		HelpProvider1.SetHelpKeyword((Control)(object)_cmdRemove_1, resourceManager.GetString("_cmdRemove_1.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)_cmdRemove_1, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("_cmdRemove_1.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)_cmdRemove_1, resourceManager.GetString("_cmdRemove_1.HelpString"));
		((ButtonBase)_cmdRemove_1).set_Image((Image)resourceManager.GetObject("_cmdRemove_1.Image"));
		((ButtonBase)_cmdRemove_1).set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("_cmdRemove_1.ImageAlign")));
		((ButtonBase)_cmdRemove_1).set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("_cmdRemove_1.ImageIndex")));
		((ButtonBase)_cmdRemove_1).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("_cmdRemove_1.ImeMode")));
		Button cmdRemove_3 = _cmdRemove_1;
		object? object35 = resourceManager.GetObject("_cmdRemove_1.Location");
		((Control)cmdRemove_3).set_Location((object35 != null) ? ((Point)object35) : point);
		((Control)_cmdRemove_1).set_Name("_cmdRemove_1");
		((Control)_cmdRemove_1).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("_cmdRemove_1.RightToLeft")));
		HelpProvider1.SetShowHelp((Control)(object)_cmdRemove_1, Conversions.ToBoolean(resourceManager.GetObject("_cmdRemove_1.ShowHelp")));
		Button cmdRemove_4 = _cmdRemove_1;
		object? object36 = resourceManager.GetObject("_cmdRemove_1.Size");
		((Control)cmdRemove_4).set_Size((object36 != null) ? ((Size)object36) : size);
		((Control)_cmdRemove_1).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("_cmdRemove_1.TabIndex")));
		((Control)_cmdRemove_1).set_Tag((object)"remove an alias");
		((ButtonBase)_cmdRemove_1).set_Text(resourceManager.GetString("_cmdRemove_1.Text"));
		((ButtonBase)_cmdRemove_1).set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("_cmdRemove_1.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)_cmdRemove_1, resourceManager.GetString("_cmdRemove_1.ToolTip"));
		((Control)_cmdRemove_1).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("_cmdRemove_1.Visible")));
		((Control)tbsMain).set_AccessibleDescription(resourceManager.GetString("tbsMain.AccessibleDescription"));
		((Control)tbsMain).set_AccessibleName(resourceManager.GetString("tbsMain.AccessibleName"));
		tbsMain.set_Alignment((TabAlignment)Conversions.ToInteger(resourceManager.GetObject("tbsMain.Alignment")));
		((Control)tbsMain).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("tbsMain.Anchor")));
		tbsMain.set_Appearance((TabAppearance)Conversions.ToInteger(resourceManager.GetObject("tbsMain.Appearance")));
		tbsMain.set_BackgroundImage((Image)resourceManager.GetObject("tbsMain.BackgroundImage"));
		((Control)tbsMain).get_Controls().Add((Control)(object)Tab0);
		((Control)tbsMain).get_Controls().Add((Control)(object)Tab1);
		((Control)tbsMain).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("tbsMain.Dock")));
		((Control)tbsMain).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("tbsMain.Enabled")));
		((Control)tbsMain).set_Font((Font)resourceManager.GetObject("tbsMain.Font"));
		HelpProvider1.SetHelpKeyword((Control)(object)tbsMain, resourceManager.GetString("tbsMain.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)tbsMain, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("tbsMain.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)tbsMain, resourceManager.GetString("tbsMain.HelpString"));
		((Control)tbsMain).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("tbsMain.ImeMode")));
		TabControl obj11 = tbsMain;
		object? object37 = resourceManager.GetObject("tbsMain.ItemSize");
		obj11.set_ItemSize((object37 != null) ? ((Size)object37) : size);
		TabControl obj12 = tbsMain;
		object? object38 = resourceManager.GetObject("tbsMain.Location");
		((Control)obj12).set_Location((object38 != null) ? ((Point)object38) : point);
		((Control)tbsMain).set_Name("tbsMain");
		TabControl obj13 = tbsMain;
		object? object39 = resourceManager.GetObject("tbsMain.Padding");
		obj13.set_Padding((object39 != null) ? ((Point)object39) : point);
		((Control)tbsMain).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("tbsMain.RightToLeft")));
		tbsMain.set_SelectedIndex(0);
		HelpProvider1.SetShowHelp((Control)(object)tbsMain, Conversions.ToBoolean(resourceManager.GetObject("tbsMain.ShowHelp")));
		tbsMain.set_ShowToolTips(Conversions.ToBoolean(resourceManager.GetObject("tbsMain.ShowToolTips")));
		TabControl obj14 = tbsMain;
		object? object40 = resourceManager.GetObject("tbsMain.Size");
		((Control)obj14).set_Size((object40 != null) ? ((Size)object40) : size);
		((Control)tbsMain).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("tbsMain.TabIndex")));
		tbsMain.set_Text(resourceManager.GetString("tbsMain.Text"));
		ToolTip1.SetToolTip((Control)(object)tbsMain, resourceManager.GetString("tbsMain.ToolTip"));
		((Control)tbsMain).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("tbsMain.Visible")));
		((Control)Tab0).set_AccessibleDescription(resourceManager.GetString("Tab0.AccessibleDescription"));
		((Control)Tab0).set_AccessibleName(resourceManager.GetString("Tab0.AccessibleName"));
		Tab0.set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("Tab0.Anchor")));
		((ScrollableControl)Tab0).set_AutoScroll(Conversions.ToBoolean(resourceManager.GetObject("Tab0.AutoScroll")));
		TabPage tab = Tab0;
		object? object41 = resourceManager.GetObject("Tab0.AutoScrollMargin");
		((ScrollableControl)tab).set_AutoScrollMargin((object41 != null) ? ((Size)object41) : size);
		TabPage tab2 = Tab0;
		object? object42 = resourceManager.GetObject("Tab0.AutoScrollMinSize");
		((ScrollableControl)tab2).set_AutoScrollMinSize((object42 != null) ? ((Size)object42) : size);
		((Control)Tab0).set_BackgroundImage((Image)resourceManager.GetObject("Tab0.BackgroundImage"));
		((Control)Tab0).get_Controls().Add((Control)(object)_fraMain_0);
		Tab0.set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("Tab0.Dock")));
		Tab0.set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("Tab0.Enabled")));
		((Control)Tab0).set_Font((Font)resourceManager.GetObject("Tab0.Font"));
		HelpProvider1.SetHelpKeyword((Control)(object)Tab0, resourceManager.GetString("Tab0.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)Tab0, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("Tab0.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)Tab0, resourceManager.GetString("Tab0.HelpString"));
		Tab0.set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("Tab0.ImageIndex")));
		((Control)Tab0).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("Tab0.ImeMode")));
		TabPage tab3 = Tab0;
		object? object43 = resourceManager.GetObject("Tab0.Location");
		tab3.set_Location((object43 != null) ? ((Point)object43) : point);
		((Control)Tab0).set_Name("Tab0");
		((Control)Tab0).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("Tab0.RightToLeft")));
		HelpProvider1.SetShowHelp((Control)(object)Tab0, Conversions.ToBoolean(resourceManager.GetObject("Tab0.ShowHelp")));
		TabPage tab4 = Tab0;
		object? object44 = resourceManager.GetObject("Tab0.Size");
		((Control)tab4).set_Size((object44 != null) ? ((Size)object44) : size);
		Tab0.set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("Tab0.TabIndex")));
		Tab0.set_Text(resourceManager.GetString("Tab0.Text"));
		ToolTip1.SetToolTip((Control)(object)Tab0, resourceManager.GetString("Tab0.ToolTip"));
		Tab0.set_ToolTipText(resourceManager.GetString("Tab0.ToolTipText"));
		Tab0.set_Visible(Conversions.ToBoolean(resourceManager.GetObject("Tab0.Visible")));
		((Control)Tab1).set_AccessibleDescription(resourceManager.GetString("Tab1.AccessibleDescription"));
		((Control)Tab1).set_AccessibleName(resourceManager.GetString("Tab1.AccessibleName"));
		Tab1.set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("Tab1.Anchor")));
		((ScrollableControl)Tab1).set_AutoScroll(Conversions.ToBoolean(resourceManager.GetObject("Tab1.AutoScroll")));
		TabPage tab5 = Tab1;
		object? object45 = resourceManager.GetObject("Tab1.AutoScrollMargin");
		((ScrollableControl)tab5).set_AutoScrollMargin((object45 != null) ? ((Size)object45) : size);
		TabPage tab6 = Tab1;
		object? object46 = resourceManager.GetObject("Tab1.AutoScrollMinSize");
		((ScrollableControl)tab6).set_AutoScrollMinSize((object46 != null) ? ((Size)object46) : size);
		((Control)Tab1).set_BackgroundImage((Image)resourceManager.GetObject("Tab1.BackgroundImage"));
		((Control)Tab1).get_Controls().Add((Control)(object)_fraMain_1);
		Tab1.set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("Tab1.Dock")));
		Tab1.set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("Tab1.Enabled")));
		((Control)Tab1).set_Font((Font)resourceManager.GetObject("Tab1.Font"));
		HelpProvider1.SetHelpKeyword((Control)(object)Tab1, resourceManager.GetString("Tab1.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)Tab1, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("Tab1.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)Tab1, resourceManager.GetString("Tab1.HelpString"));
		Tab1.set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("Tab1.ImageIndex")));
		((Control)Tab1).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("Tab1.ImeMode")));
		TabPage tab7 = Tab1;
		object? object47 = resourceManager.GetObject("Tab1.Location");
		tab7.set_Location((object47 != null) ? ((Point)object47) : point);
		((Control)Tab1).set_Name("Tab1");
		((Control)Tab1).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("Tab1.RightToLeft")));
		HelpProvider1.SetShowHelp((Control)(object)Tab1, Conversions.ToBoolean(resourceManager.GetObject("Tab1.ShowHelp")));
		TabPage tab8 = Tab1;
		object? object48 = resourceManager.GetObject("Tab1.Size");
		((Control)tab8).set_Size((object48 != null) ? ((Size)object48) : size);
		Tab1.set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("Tab1.TabIndex")));
		Tab1.set_Text(resourceManager.GetString("Tab1.Text"));
		ToolTip1.SetToolTip((Control)(object)Tab1, resourceManager.GetString("Tab1.ToolTip"));
		Tab1.set_ToolTipText(resourceManager.GetString("Tab1.ToolTipText"));
		Tab1.set_Visible(Conversions.ToBoolean(resourceManager.GetObject("Tab1.Visible")));
		((Control)lblProgress).set_AccessibleDescription(resourceManager.GetString("lblProgress.AccessibleDescription"));
		((Control)lblProgress).set_AccessibleName(resourceManager.GetString("lblProgress.AccessibleName"));
		((Control)lblProgress).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("lblProgress.Anchor")));
		lblProgress.set_AutoSize(Conversions.ToBoolean(resourceManager.GetObject("lblProgress.AutoSize")));
		((Control)lblProgress).set_BackColor(SystemColors.Control);
		((Control)lblProgress).set_Cursor(Cursors.get_Default());
		((Control)lblProgress).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("lblProgress.Dock")));
		((Control)lblProgress).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("lblProgress.Enabled")));
		((Control)lblProgress).set_Font((Font)resourceManager.GetObject("lblProgress.Font"));
		((Control)lblProgress).set_ForeColor(SystemColors.ControlText);
		HelpProvider1.SetHelpKeyword((Control)(object)lblProgress, resourceManager.GetString("lblProgress.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)lblProgress, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("lblProgress.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)lblProgress, resourceManager.GetString("lblProgress.HelpString"));
		lblProgress.set_Image((Image)resourceManager.GetObject("lblProgress.Image"));
		lblProgress.set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("lblProgress.ImageAlign")));
		lblProgress.set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("lblProgress.ImageIndex")));
		lblProgress.set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("lblProgress.ImeMode")));
		Label obj15 = lblProgress;
		object? object49 = resourceManager.GetObject("lblProgress.Location");
		((Control)obj15).set_Location((object49 != null) ? ((Point)object49) : point);
		((Control)lblProgress).set_Name("lblProgress");
		((Control)lblProgress).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("lblProgress.RightToLeft")));
		HelpProvider1.SetShowHelp((Control)(object)lblProgress, Conversions.ToBoolean(resourceManager.GetObject("lblProgress.ShowHelp")));
		Label obj16 = lblProgress;
		object? object50 = resourceManager.GetObject("lblProgress.Size");
		((Control)obj16).set_Size((object50 != null) ? ((Size)object50) : size);
		((Control)lblProgress).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("lblProgress.TabIndex")));
		lblProgress.set_Text(resourceManager.GetString("lblProgress.Text"));
		lblProgress.set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("lblProgress.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)lblProgress, resourceManager.GetString("lblProgress.ToolTip"));
		((Control)lblProgress).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("lblProgress.Visible")));
		((FileDialog)cdgOpen).set_Filter(resourceManager.GetString("cdgOpen.Filter"));
		((FileDialog)cdgOpen).set_Title(resourceManager.GetString("cdgOpen.Title"));
		((Menu)MainMenu1).get_MenuItems().AddRange((MenuItem[])(object)new MenuItem[3] { mnuFile, mnuEdit, mnuHelp });
		MainMenu1.set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("MainMenu1.RightToLeft")));
		mnuFile.set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("mnuFile.Enabled")));
		mnuFile.set_Index(0);
		((Menu)mnuFile).get_MenuItems().AddRange((MenuItem[])(object)new MenuItem[12]
		{
			mnuFileNew, mnuFileSep1, mnuFileOpen, mnuFileSave, mnuFileSep2, mnuFileImport, mnuFileExport, mnuFileSep3, mnuFileSetup, mnuFilePrint,
			mnuFileSep4, mnuFileExit
		});
		mnuFile.set_Shortcut((Shortcut)Conversions.ToInteger(resourceManager.GetObject("mnuFile.Shortcut")));
		mnuFile.set_ShowShortcut(Conversions.ToBoolean(resourceManager.GetObject("mnuFile.ShowShortcut")));
		mnuFile.set_Text(resourceManager.GetString("mnuFile.Text"));
		mnuFile.set_Visible(Conversions.ToBoolean(resourceManager.GetObject("mnuFile.Visible")));
		mnuFileNew.set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("mnuFileNew.Enabled")));
		mnuFileNew.set_Index(0);
		mnuFileNew.set_Shortcut((Shortcut)Conversions.ToInteger(resourceManager.GetObject("mnuFileNew.Shortcut")));
		mnuFileNew.set_ShowShortcut(Conversions.ToBoolean(resourceManager.GetObject("mnuFileNew.ShowShortcut")));
		mnuFileNew.set_Text(resourceManager.GetString("mnuFileNew.Text"));
		mnuFileNew.set_Visible(Conversions.ToBoolean(resourceManager.GetObject("mnuFileNew.Visible")));
		mnuFileSep1.set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("mnuFileSep1.Enabled")));
		mnuFileSep1.set_Index(1);
		mnuFileSep1.set_Shortcut((Shortcut)Conversions.ToInteger(resourceManager.GetObject("mnuFileSep1.Shortcut")));
		mnuFileSep1.set_ShowShortcut(Conversions.ToBoolean(resourceManager.GetObject("mnuFileSep1.ShowShortcut")));
		mnuFileSep1.set_Text(resourceManager.GetString("mnuFileSep1.Text"));
		mnuFileSep1.set_Visible(Conversions.ToBoolean(resourceManager.GetObject("mnuFileSep1.Visible")));
		mnuFileOpen.set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("mnuFileOpen.Enabled")));
		mnuFileOpen.set_Index(2);
		mnuFileOpen.set_Shortcut((Shortcut)Conversions.ToInteger(resourceManager.GetObject("mnuFileOpen.Shortcut")));
		mnuFileOpen.set_ShowShortcut(Conversions.ToBoolean(resourceManager.GetObject("mnuFileOpen.ShowShortcut")));
		mnuFileOpen.set_Text(resourceManager.GetString("mnuFileOpen.Text"));
		mnuFileOpen.set_Visible(Conversions.ToBoolean(resourceManager.GetObject("mnuFileOpen.Visible")));
		mnuFileSave.set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("mnuFileSave.Enabled")));
		mnuFileSave.set_Index(3);
		mnuFileSave.set_Shortcut((Shortcut)Conversions.ToInteger(resourceManager.GetObject("mnuFileSave.Shortcut")));
		mnuFileSave.set_ShowShortcut(Conversions.ToBoolean(resourceManager.GetObject("mnuFileSave.ShowShortcut")));
		mnuFileSave.set_Text(resourceManager.GetString("mnuFileSave.Text"));
		mnuFileSave.set_Visible(Conversions.ToBoolean(resourceManager.GetObject("mnuFileSave.Visible")));
		mnuFileSep2.set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("mnuFileSep2.Enabled")));
		mnuFileSep2.set_Index(4);
		mnuFileSep2.set_Shortcut((Shortcut)Conversions.ToInteger(resourceManager.GetObject("mnuFileSep2.Shortcut")));
		mnuFileSep2.set_ShowShortcut(Conversions.ToBoolean(resourceManager.GetObject("mnuFileSep2.ShowShortcut")));
		mnuFileSep2.set_Text(resourceManager.GetString("mnuFileSep2.Text"));
		mnuFileSep2.set_Visible(Conversions.ToBoolean(resourceManager.GetObject("mnuFileSep2.Visible")));
		mnuFileImport.set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("mnuFileImport.Enabled")));
		mnuFileImport.set_Index(5);
		mnuFileImport.set_Shortcut((Shortcut)Conversions.ToInteger(resourceManager.GetObject("mnuFileImport.Shortcut")));
		mnuFileImport.set_ShowShortcut(Conversions.ToBoolean(resourceManager.GetObject("mnuFileImport.ShowShortcut")));
		mnuFileImport.set_Text(resourceManager.GetString("mnuFileImport.Text"));
		mnuFileImport.set_Visible(Conversions.ToBoolean(resourceManager.GetObject("mnuFileImport.Visible")));
		mnuFileExport.set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("mnuFileExport.Enabled")));
		mnuFileExport.set_Index(6);
		mnuFileExport.set_Shortcut((Shortcut)Conversions.ToInteger(resourceManager.GetObject("mnuFileExport.Shortcut")));
		mnuFileExport.set_ShowShortcut(Conversions.ToBoolean(resourceManager.GetObject("mnuFileExport.ShowShortcut")));
		mnuFileExport.set_Text(resourceManager.GetString("mnuFileExport.Text"));
		mnuFileExport.set_Visible(Conversions.ToBoolean(resourceManager.GetObject("mnuFileExport.Visible")));
		mnuFileSep3.set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("mnuFileSep3.Enabled")));
		mnuFileSep3.set_Index(7);
		mnuFileSep3.set_Shortcut((Shortcut)Conversions.ToInteger(resourceManager.GetObject("mnuFileSep3.Shortcut")));
		mnuFileSep3.set_ShowShortcut(Conversions.ToBoolean(resourceManager.GetObject("mnuFileSep3.ShowShortcut")));
		mnuFileSep3.set_Text(resourceManager.GetString("mnuFileSep3.Text"));
		mnuFileSep3.set_Visible(Conversions.ToBoolean(resourceManager.GetObject("mnuFileSep3.Visible")));
		mnuFileSetup.set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("mnuFileSetup.Enabled")));
		mnuFileSetup.set_Index(8);
		mnuFileSetup.set_Shortcut((Shortcut)Conversions.ToInteger(resourceManager.GetObject("mnuFileSetup.Shortcut")));
		mnuFileSetup.set_ShowShortcut(Conversions.ToBoolean(resourceManager.GetObject("mnuFileSetup.ShowShortcut")));
		mnuFileSetup.set_Text(resourceManager.GetString("mnuFileSetup.Text"));
		mnuFileSetup.set_Visible(Conversions.ToBoolean(resourceManager.GetObject("mnuFileSetup.Visible")));
		mnuFilePrint.set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("mnuFilePrint.Enabled")));
		mnuFilePrint.set_Index(9);
		mnuFilePrint.set_Shortcut((Shortcut)Conversions.ToInteger(resourceManager.GetObject("mnuFilePrint.Shortcut")));
		mnuFilePrint.set_ShowShortcut(Conversions.ToBoolean(resourceManager.GetObject("mnuFilePrint.ShowShortcut")));
		mnuFilePrint.set_Text(resourceManager.GetString("mnuFilePrint.Text"));
		mnuFilePrint.set_Visible(Conversions.ToBoolean(resourceManager.GetObject("mnuFilePrint.Visible")));
		mnuFileSep4.set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("mnuFileSep4.Enabled")));
		mnuFileSep4.set_Index(10);
		mnuFileSep4.set_Shortcut((Shortcut)Conversions.ToInteger(resourceManager.GetObject("mnuFileSep4.Shortcut")));
		mnuFileSep4.set_ShowShortcut(Conversions.ToBoolean(resourceManager.GetObject("mnuFileSep4.ShowShortcut")));
		mnuFileSep4.set_Text(resourceManager.GetString("mnuFileSep4.Text"));
		mnuFileSep4.set_Visible(Conversions.ToBoolean(resourceManager.GetObject("mnuFileSep4.Visible")));
		mnuFileExit.set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("mnuFileExit.Enabled")));
		mnuFileExit.set_Index(11);
		mnuFileExit.set_Shortcut((Shortcut)Conversions.ToInteger(resourceManager.GetObject("mnuFileExit.Shortcut")));
		mnuFileExit.set_ShowShortcut(Conversions.ToBoolean(resourceManager.GetObject("mnuFileExit.ShowShortcut")));
		mnuFileExit.set_Text(resourceManager.GetString("mnuFileExit.Text"));
		mnuFileExit.set_Visible(Conversions.ToBoolean(resourceManager.GetObject("mnuFileExit.Visible")));
		mnuEdit.set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("mnuEdit.Enabled")));
		mnuEdit.set_Index(1);
		((Menu)mnuEdit).get_MenuItems().AddRange((MenuItem[])(object)new MenuItem[4] { mnuEditAdd, mnuEditRemove, mnuEditSep1, mnuEditEdit });
		mnuEdit.set_Shortcut((Shortcut)Conversions.ToInteger(resourceManager.GetObject("mnuEdit.Shortcut")));
		mnuEdit.set_ShowShortcut(Conversions.ToBoolean(resourceManager.GetObject("mnuEdit.ShowShortcut")));
		mnuEdit.set_Text(resourceManager.GetString("mnuEdit.Text"));
		mnuEdit.set_Visible(Conversions.ToBoolean(resourceManager.GetObject("mnuEdit.Visible")));
		mnuEditAdd.set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("mnuEditAdd.Enabled")));
		mnuEditAdd.set_Index(0);
		mnuEditAdd.set_Shortcut((Shortcut)Conversions.ToInteger(resourceManager.GetObject("mnuEditAdd.Shortcut")));
		mnuEditAdd.set_ShowShortcut(Conversions.ToBoolean(resourceManager.GetObject("mnuEditAdd.ShowShortcut")));
		mnuEditAdd.set_Text(resourceManager.GetString("mnuEditAdd.Text"));
		mnuEditAdd.set_Visible(Conversions.ToBoolean(resourceManager.GetObject("mnuEditAdd.Visible")));
		mnuEditRemove.set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("mnuEditRemove.Enabled")));
		mnuEditRemove.set_Index(1);
		mnuEditRemove.set_Shortcut((Shortcut)Conversions.ToInteger(resourceManager.GetObject("mnuEditRemove.Shortcut")));
		mnuEditRemove.set_ShowShortcut(Conversions.ToBoolean(resourceManager.GetObject("mnuEditRemove.ShowShortcut")));
		mnuEditRemove.set_Text(resourceManager.GetString("mnuEditRemove.Text"));
		mnuEditRemove.set_Visible(Conversions.ToBoolean(resourceManager.GetObject("mnuEditRemove.Visible")));
		mnuEditSep1.set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("mnuEditSep1.Enabled")));
		mnuEditSep1.set_Index(2);
		mnuEditSep1.set_Shortcut((Shortcut)Conversions.ToInteger(resourceManager.GetObject("mnuEditSep1.Shortcut")));
		mnuEditSep1.set_ShowShortcut(Conversions.ToBoolean(resourceManager.GetObject("mnuEditSep1.ShowShortcut")));
		mnuEditSep1.set_Text(resourceManager.GetString("mnuEditSep1.Text"));
		mnuEditSep1.set_Visible(Conversions.ToBoolean(resourceManager.GetObject("mnuEditSep1.Visible")));
		mnuEditEdit.set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("mnuEditEdit.Enabled")));
		mnuEditEdit.set_Index(3);
		mnuEditEdit.set_Shortcut((Shortcut)Conversions.ToInteger(resourceManager.GetObject("mnuEditEdit.Shortcut")));
		mnuEditEdit.set_ShowShortcut(Conversions.ToBoolean(resourceManager.GetObject("mnuEditEdit.ShowShortcut")));
		mnuEditEdit.set_Text(resourceManager.GetString("mnuEditEdit.Text"));
		mnuEditEdit.set_Visible(Conversions.ToBoolean(resourceManager.GetObject("mnuEditEdit.Visible")));
		mnuHelp.set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("mnuHelp.Enabled")));
		mnuHelp.set_Index(2);
		((Menu)mnuHelp).get_MenuItems().AddRange((MenuItem[])(object)new MenuItem[3] { mnuHelpSearch, mnuHelpSep1, mnuHelpAbout });
		mnuHelp.set_Shortcut((Shortcut)Conversions.ToInteger(resourceManager.GetObject("mnuHelp.Shortcut")));
		mnuHelp.set_ShowShortcut(Conversions.ToBoolean(resourceManager.GetObject("mnuHelp.ShowShortcut")));
		mnuHelp.set_Text(resourceManager.GetString("mnuHelp.Text"));
		mnuHelp.set_Visible(Conversions.ToBoolean(resourceManager.GetObject("mnuHelp.Visible")));
		mnuHelpSearch.set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("mnuHelpSearch.Enabled")));
		mnuHelpSearch.set_Index(0);
		mnuHelpSearch.set_Shortcut((Shortcut)Conversions.ToInteger(resourceManager.GetObject("mnuHelpSearch.Shortcut")));
		mnuHelpSearch.set_ShowShortcut(Conversions.ToBoolean(resourceManager.GetObject("mnuHelpSearch.ShowShortcut")));
		mnuHelpSearch.set_Text(resourceManager.GetString("mnuHelpSearch.Text"));
		mnuHelpSearch.set_Visible(Conversions.ToBoolean(resourceManager.GetObject("mnuHelpSearch.Visible")));
		mnuHelpSep1.set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("mnuHelpSep1.Enabled")));
		mnuHelpSep1.set_Index(1);
		mnuHelpSep1.set_Shortcut((Shortcut)Conversions.ToInteger(resourceManager.GetObject("mnuHelpSep1.Shortcut")));
		mnuHelpSep1.set_ShowShortcut(Conversions.ToBoolean(resourceManager.GetObject("mnuHelpSep1.ShowShortcut")));
		mnuHelpSep1.set_Text(resourceManager.GetString("mnuHelpSep1.Text"));
		mnuHelpSep1.set_Visible(Conversions.ToBoolean(resourceManager.GetObject("mnuHelpSep1.Visible")));
		mnuHelpAbout.set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("mnuHelpAbout.Enabled")));
		mnuHelpAbout.set_Index(2);
		mnuHelpAbout.set_Shortcut((Shortcut)Conversions.ToInteger(resourceManager.GetObject("mnuHelpAbout.Shortcut")));
		mnuHelpAbout.set_ShowShortcut(Conversions.ToBoolean(resourceManager.GetObject("mnuHelpAbout.ShowShortcut")));
		mnuHelpAbout.set_Text(resourceManager.GetString("mnuHelpAbout.Text"));
		mnuHelpAbout.set_Visible(Conversions.ToBoolean(resourceManager.GetObject("mnuHelpAbout.Visible")));
		HelpProvider1.set_HelpNamespace(resourceManager.GetString("HelpProvider1.HelpNamespace"));
		((FileDialog)cdgSave).set_Filter(resourceManager.GetString("cdgSave.Filter"));
		((FileDialog)cdgSave).set_Title(resourceManager.GetString("cdgSave.Title"));
		((Control)this).set_AccessibleDescription(resourceManager.GetString("$this.AccessibleDescription"));
		((Control)this).set_AccessibleName(resourceManager.GetString("$this.AccessibleName"));
		object? object51 = resourceManager.GetObject("$this.AutoScaleBaseSize");
		((Form)this).set_AutoScaleBaseSize((object51 != null) ? ((Size)object51) : size);
		((Form)this).set_AutoScroll(Conversions.ToBoolean(resourceManager.GetObject("$this.AutoScroll")));
		object? object52 = resourceManager.GetObject("$this.AutoScrollMargin");
		((ScrollableControl)this).set_AutoScrollMargin((object52 != null) ? ((Size)object52) : size);
		object? object53 = resourceManager.GetObject("$this.AutoScrollMinSize");
		((ScrollableControl)this).set_AutoScrollMinSize((object53 != null) ? ((Size)object53) : size);
		((Form)this).set_BackColor(SystemColors.ControlLight);
		((Control)this).set_BackgroundImage((Image)resourceManager.GetObject("$this.BackgroundImage"));
		object? object54 = resourceManager.GetObject("$this.ClientSize");
		((Form)this).set_ClientSize((object54 != null) ? ((Size)object54) : size);
		((Control)this).get_Controls().Add((Control)(object)cmdOK);
		((Control)this).get_Controls().Add((Control)(object)chkConfirm);
		((Control)this).get_Controls().Add((Control)(object)cmdCancel);
		((Control)this).get_Controls().Add((Control)(object)cmdApply);
		((Control)this).get_Controls().Add((Control)(object)tbsMain);
		((Control)this).get_Controls().Add((Control)(object)lblProgress);
		((Control)this).set_Cursor(Cursors.get_Default());
		((Control)this).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("$this.Enabled")));
		((Control)this).set_Font((Font)resourceManager.GetObject("$this.Font"));
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		HelpProvider1.SetHelpKeyword((Control)(object)this, resourceManager.GetString("$this.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)this, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("$this.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)this, resourceManager.GetString("$this.HelpString"));
		((Form)this).set_Icon((Icon)resourceManager.GetObject("$this.Icon"));
		((Control)this).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("$this.ImeMode")));
		object? object55 = resourceManager.GetObject("$this.Location");
		((Form)this).set_Location((object55 != null) ? ((Point)object55) : point);
		((Form)this).set_MaximizeBox(false);
		object? object56 = resourceManager.GetObject("$this.MaximumSize");
		((Form)this).set_MaximumSize((object56 != null) ? ((Size)object56) : size);
		((Form)this).set_Menu(MainMenu1);
		object? object57 = resourceManager.GetObject("$this.MinimumSize");
		((Form)this).set_MinimumSize((object57 != null) ? ((Size)object57) : size);
		((Control)this).set_Name("frmAlias");
		((Control)this).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("$this.RightToLeft")));
		HelpProvider1.SetShowHelp((Control)(object)this, Conversions.ToBoolean(resourceManager.GetObject("$this.ShowHelp")));
		((Form)this).set_StartPosition((FormStartPosition)Conversions.ToInteger(resourceManager.GetObject("$this.StartPosition")));
		((Form)this).set_Text(resourceManager.GetString("$this.Text"));
		ToolTip1.SetToolTip((Control)(object)this, resourceManager.GetString("$this.ToolTip"));
		((Control)_fraMain_0).ResumeLayout(false);
		((Control)_pctAlias_0).ResumeLayout(false);
		((Control)_fraMain_1).ResumeLayout(false);
		((Control)_pctAlias_1).ResumeLayout(false);
		((Control)tbsMain).ResumeLayout(false);
		((Control)Tab0).ResumeLayout(false);
		((Control)Tab1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	public void StartBrowse(ref bool Import)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Invalid comparison between Unknown and I4
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					string StartFileName;
					if (!Import)
					{
						short num3 = 7;
						if ((Main.nChange & (short)(0u - ((Operators.CompareString(Main.sFname, "", false) != 0) ? 1u : 0u))) != 0)
						{
							string text = resManager.GetString("STR_UNNAMED");
							if (Operators.CompareString(Main.sFileInMemory, "", false) != 0)
							{
								text = Main.sFileInMemory;
							}
							num3 = checked((short)Interaction.MsgBox((object)(resManager.GetString("STR_SAVECHANGES") + text + resManager.GetString("STR_?")), (MsgBoxStyle)291, (object)resManager.GetString("STR_SAVETITLE")));
							if (num3 == 2)
							{
								break;
							}
						}
						if (num3 == 6)
						{
							if (Operators.CompareString(Main.sFileInMemory, "", false) == 0)
							{
								string Filter_Renamed = resManager.GetString("STR_SAVEEXTENSION");
								StartFileName = Main.sACADPGP + "\\acad.pgp";
								Main.sFileInMemory = Main.GetSaveFile(ref Filter_Renamed, ref StartFileName);
								if (Operators.CompareString(Main.sFileInMemory, "", false) == 0)
								{
									break;
								}
								Main.sFname = ((FileDialog)cdgOpen).get_Title();
							}
							bool Suppress = true;
							Main.SavePGP(ref Main.sFileInMemory, ref Main.sFname, ref Suppress);
						}
					}
					string sFileInMemory = Main.sFileInMemory;
					StartFileName = resManager.GetString("STR_SAVEEXTENSION");
					Main.sFileInMemory = Main.GetOpenFile(ref StartFileName, ref Main.sFileInMemory);
					Main.sFname = ((FileDialog)cdgOpen).get_Title();
					if ((Operators.CompareString(Main.sFileInMemory, "", false) == 0) | (Operators.CompareString(sFileInMemory, Main.sFileInMemory, false) == 0))
					{
						Main.sFileInMemory = sFileInMemory;
						break;
					}
					if (Import)
					{
						short num3 = 6;
						if ((int)chkConfirm.get_CheckState() > 0)
						{
							num3 = checked((short)Interaction.MsgBox((object)(resManager.GetString("STR_IMPORT1") + Main.sFileInMemory + resManager.GetString("STR_IMPORT2")), (MsgBoxStyle)68, (object)resManager.GetString("STR_IMPORT3")));
						}
						if (num3 != 6)
						{
							break;
						}
						Main.ParsePGP(ref Main.sFileInMemory, ref Import);
						FillInListView(ref Import);
						Main.nChange = 1;
					}
					else
					{
						Main.sFname = Main.sFileInMemory;
						Main.CleanUpForm();
						Main.ParsePGP(ref Main.sFileInMemory, ref Import);
						FillInListView(ref Import);
					}
					Main.ChkApply();
					break;
				}
				case 571:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto IL_0275;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 571;
				continue;
			}
			break;
			IL_0275:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void StartEdit(ref short Index)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		_ = (ListView)lvwAlias[Index];
		ListViewItem val = null;
		if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(lvwAlias[Index], (Type)null, "SelectedItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
		{
			val = (ListViewItem)NewLateBinding.LateGet(lvwAlias[Index], (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null);
		}
		if (val == null)
		{
			val = (ListViewItem)NewLateBinding.LateGet(lvwAlias[Index], (Type)null, "Items", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null);
		}
		Main.sEditAlias = val.get_Text();
		Main.sEditRep = val.get_SubItems().get_Item(1).get_Text();
		if (Operators.CompareString(Main.sEditAlias, "---", false) == 0)
		{
			Main.sEditAlias = "";
		}
		if (Index == 1)
		{
			Main.sEditPrompt = val.get_SubItems().get_Item(3).get_Text();
			Main.sEditFlag = val.get_SubItems().get_Item(2).get_Text();
		}
		Main.nEdit = 1;
		cmdAdd_Click(RuntimeHelpers.GetObjectValue(cmdAdd[Index]), new EventArgs());
		if (Main.bEditCancel == -1)
		{
			Main.bEditCancel = 0;
			Main.nEdit = 0;
			switch (Index)
			{
			case 0:
				frmNewAlias.DefInstance.txtAlias.set_Text("");
				frmNewAlias.DefInstance.cmbRep.set_Text("");
				break;
			case 1:
				frmNewShell.DefInstance.txtAlias.set_Text("");
				frmNewShell.DefInstance.txtCommand.set_Text("");
				frmNewShell.DefInstance.comboFlag.set_Text("0");
				frmNewShell.DefInstance.txtPrompt.set_Text("");
				break;
			}
		}
		else
		{
			if (Main.nEdit == 1)
			{
				cmdRemove_Click(RuntimeHelpers.GetObjectValue(cmdRemove[Index]), new EventArgs());
			}
			Main.AppendAlias();
			Main.nEdit = 0;
			NewLateBinding.LateCall(lvwAlias[Index], (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	public void StartRemove(ref short Index)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Invalid comparison between Unknown and I4
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		ListViewItem oAliasToRemove = null;
		if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(lvwAlias[Index], (Type)null, "SelectedItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
		{
			oAliasToRemove = (ListViewItem)NewLateBinding.LateGet(lvwAlias[Index], (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null);
		}
		if (oAliasToRemove == null)
		{
			oAliasToRemove = (ListViewItem)NewLateBinding.LateGet(lvwAlias[Index], (Type)null, "Items", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null);
		}
		short num = 6;
		_003F val = chkConfirm.get_CheckState() & (0 - ((Main.nEdit == 0) ? 1 : 0));
		ListViewItem val2 = oAliasToRemove;
		string CapString = val2.get_Text();
		string text = Main.Capitalize(ref CapString);
		val2.set_Text(CapString);
		if ((val & (0 - ((Operators.CompareString(text, "---", false) != 0) ? 1 : 0))) > 0)
		{
			string text2 = oAliasToRemove.get_Text();
			string text3 = oAliasToRemove.get_SubItems().get_Item(1).get_Text();
			if (Operators.CompareString(text3, "", false) != 0)
			{
				text3 = resManager.GetString("STR_FOR") + text3;
			}
			string text4 = resManager.GetString("STR_SUREREMOVE") + text3 + resManager.GetString("STR_?");
			string text5 = resManager.GetString("STR_REMOVE") + text2 + resManager.GetString("STR_?");
			num = checked((short)Interaction.MsgBox((object)text4, (MsgBoxStyle)36, (object)text5));
		}
		checked
		{
			if (Conversions.ToBoolean(Operators.AndObject((object)(num == 6), Operators.CompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(lvwAlias[Index], (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))))
			{
				string text6 = "";
				switch (Index)
				{
				case 0:
					text6 = frmNewAlias.DefInstance.txtAlias.get_Text();
					break;
				case 1:
					text6 = frmNewShell.DefInstance.txtAlias.get_Text();
					break;
				}
				if ((Main.nEdit == 1) & (Operators.CompareString(oAliasToRemove.get_Text(), text6, false) != 0))
				{
					int Index2 = Index;
					Main.RemoveAlias(ref oAliasToRemove, ref Index2, removeFromFile: false, removeFromLV: false);
					Index = (short)Index2;
				}
				else
				{
					int Index2 = Index;
					Main.RemoveAlias(ref oAliasToRemove, ref Index2, removeFromFile: true, removeFromLV: true);
					Index = (short)Index2;
				}
			}
			if (!((Control)cmdApply).get_Enabled())
			{
				Main.ChkApply();
			}
			NewLateBinding.LateCall(lvwAlias[Index], (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void cmdAdd_Click(object sender, EventArgs e)
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		short num = checked((short)cmdAdd.IndexOf(RuntimeHelpers.GetObjectValue(sender)));
		switch (num)
		{
		case 0:
		{
			if (Main.nEdit == 0)
			{
				frmNewAlias defInstance3 = frmNewAlias.DefInstance;
				defInstance3.cmbRep.set_Text("");
				defInstance3.txtAlias.set_Text("");
				((Form)defInstance3).set_Text(resManager.GetString("STR_NEWCOM"));
				defInstance3 = null;
			}
			else
			{
				frmNewAlias defInstance4 = frmNewAlias.DefInstance;
				((Form)defInstance4).set_Text(resManager.GetString("STR_EDITCOM"));
				defInstance4.txtAlias.set_Text(Main.sEditAlias);
				((Control)defInstance4.txtAlias).set_Enabled(true);
				defInstance4.cmbRep.set_Text(Main.sEditRep);
				((TextBoxBase)defInstance4.txtAlias).set_SelectionStart(0);
				((TextBoxBase)defInstance4.txtAlias).set_SelectionLength(Strings.Len(Main.sEditAlias));
				defInstance4 = null;
			}
			((Form)frmNewAlias.DefInstance).ShowDialog((IWin32Window)(object)this);
			string NewString = frmNewAlias.DefInstance.txtAlias.get_Text();
			ListViewItem oAliasToRemove = Main.FindDuplicate(ref NewString);
			if (Main.nEdit == 0 && oAliasToRemove == null)
			{
				Main.AppendAlias();
			}
			else if (Main.nEdit == 0)
			{
				int Index = 0;
				Main.RemoveAlias(ref oAliasToRemove, ref Index, removeFromFile: true, removeFromLV: true);
				Main.AppendAlias();
			}
			break;
		}
		case 1:
		{
			if (Main.nEdit == 0)
			{
				frmNewShell defInstance = frmNewShell.DefInstance;
				((Form)defInstance).set_Text(resManager.GetString("STR_NEWSHELL"));
				defInstance.txtPrompt.set_Text("");
				defInstance.txtAlias.set_Text("");
				((Control)defInstance.txtAlias).set_Enabled(true);
				defInstance.txtCommand.set_Text("");
				defInstance.comboFlag.set_SelectedIndex(0);
				defInstance = null;
			}
			else
			{
				frmNewShell defInstance2 = frmNewShell.DefInstance;
				((Form)defInstance2).set_Text(resManager.GetString("STR_EDITSHELL"));
				defInstance2.txtAlias.set_Text(Main.sEditAlias);
				defInstance2.txtCommand.set_Text(Main.sEditRep);
				defInstance2.txtPrompt.set_Text(Main.sEditPrompt);
				defInstance2.comboFlag.set_Text(Main.sEditFlag);
				((Control)defInstance2.txtAlias).set_Enabled(true);
				((TextBoxBase)defInstance2.txtAlias).set_SelectionStart(0);
				((TextBoxBase)defInstance2.txtAlias).set_SelectionLength(Strings.Len(Main.sEditAlias));
				defInstance2 = null;
			}
			((Form)frmNewShell.DefInstance).ShowDialog((IWin32Window)(object)this);
			string NewString = frmNewShell.DefInstance.txtAlias.get_Text();
			ListViewItem oAliasToRemove = Main.FindDuplicate(ref NewString);
			if (Main.nEdit == 0 && oAliasToRemove == null)
			{
				Main.AppendAlias();
			}
			else if (Main.nEdit == 0)
			{
				int Index = 1;
				Main.RemoveAlias(ref oAliasToRemove, ref Index, removeFromFile: false, removeFromLV: true);
				Main.AppendAlias();
			}
			break;
		}
		case 2:
		{
			object FileName = Strings.Left(Main.sACADPGP, checked(Strings.Len(Main.sACADPGP) - Strings.Len("acad.pgp"))) + "acad.mnu";
			Main.ParseMNU(ref FileName);
			break;
		}
		}
		NewLateBinding.LateCall(lvwAlias[num], (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void cmdApply_Click(object sender, EventArgs e)
	{
		bool Cancel = false;
		StartApply(ref Cancel);
	}

	public void StartApply(ref bool Cancel)
	{
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Invalid comparison between Unknown and I4
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		short num6 = default(short);
		short num7 = default(short);
		string sFileName = default(string);
		string F = default(string);
		bool flag = default(bool);
		string StartFileName = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num4;
				ErrObject val;
				int errVal;
				short num5;
				bool Suppress;
				string Filter_Renamed;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 2;
					goto IL_0008;
				case 1042:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						case 2:
							goto IL_03e4;
						default:
							goto end_IL_0000;
						}
						goto IL_0200;
					}
					IL_0200:
					num4 = num2 + 1;
					goto IL_0218;
					IL_0218:
					num2 = 0;
					switch (num4)
					{
					case 1:
						break;
					case 2:
						goto IL_0008;
					case 3:
						goto IL_0033;
					case 4:
						goto IL_0042;
					case 6:
					case 7:
						goto IL_0056;
					case 8:
						goto IL_0060;
					case 9:
						goto IL_0069;
					case 10:
						goto IL_006f;
					case 11:
						goto IL_0086;
					case 13:
						goto IL_0091;
					case 14:
						goto IL_0095;
					case 15:
						goto IL_00b9;
					case 16:
						goto IL_00da;
					case 17:
					case 18:
						goto IL_0130;
					case 19:
						goto IL_014b;
					case 12:
					case 20:
					case 21:
					case 22:
					case 23:
						goto IL_0151;
					case 24:
						goto IL_0158;
					case 25:
						goto IL_0163;
					case 26:
						goto IL_0173;
					case 27:
					case 28:
						goto IL_017e;
					case 29:
						goto IL_019f;
					case 30:
						goto IL_01b3;
					case 32:
					case 33:
						goto IL_01bf;
					case 35:
						goto IL_01d1;
					case 34:
					case 37:
					case 38:
						goto IL_01de;
					case 39:
						goto IL_01e9;
					case 52:
					case 53:
						goto IL_0206;
					default:
						goto end_IL_0000;
					case 48:
					case 50:
						goto IL_0335;
					case 62:
					case 63:
						goto IL_034c;
					case 47:
					case 51:
					case 54:
					case 55:
					case 58:
					case 61:
					case 64:
					case 65:
					case 66:
						goto IL_036d;
					case 59:
					case 60:
						goto IL_037f;
					case 46:
						goto IL_038a;
					case 44:
					case 45:
						goto IL_03a6;
					case 42:
						goto IL_03cd;
					case 41:
						goto IL_03e4;
					case 0:
					case 49:
						goto end_IL_0000;
					case 5:
					case 31:
					case 36:
					case 40:
					case 43:
					case 56:
					case 57:
					case 67:
						goto end_IL_0000_2;
					}
					goto default;
					IL_03e4:
					num = 41;
					Cursor.set_Current(Cursors.get_Default());
					goto IL_03cd;
					IL_03cd:
					num = 42;
					if (Information.Err().get_Number() == 32755)
					{
						goto end_IL_0000_2;
					}
					goto IL_03a6;
					IL_03a6:
					num = 45;
					val = Information.Err();
					errVal = val.get_Number();
					num5 = ErrorHandler.FileErrors(ref errVal);
					val.set_Number(errVal);
					num6 = num5;
					goto IL_038a;
					IL_038a:
					num = 46;
					switch (num6)
					{
					case 1:
						break;
					case 0:
						goto IL_0335;
					default:
						goto IL_034c;
					case 3:
						goto IL_037f;
					case 2:
						goto end_IL_0000_2;
					}
					goto IL_0206;
					IL_037f:
					num = 60;
					ErrorHandler.ShowError();
					goto IL_036d;
					IL_034c:
					num = 63;
					Interaction.MsgBox((object)resManager.GetString("STR_INTERNALERROR"), (MsgBoxStyle)0, (object)null);
					ProjectData.EndApp();
					goto IL_036d;
					IL_0335:
					num = 50;
					cmdApply_Click(cmdApply, new EventArgs());
					goto IL_036d;
					IL_036d:
					num = 66;
					ProjectData.ClearProjectError();
					if (num2 == 0)
					{
						throw ProjectData.CreateProjectError(-2146828268);
					}
					goto IL_0200;
					IL_01d1:
					num = 35;
					if (num7 == 2)
					{
						goto end_IL_0000_2;
					}
					goto IL_01de;
					IL_0206:
					num = 53;
					ProjectData.ClearProjectError();
					if (num2 != 0)
					{
						num4 = num2;
						goto IL_0218;
					}
					throw ProjectData.CreateProjectError(-2146828268);
					IL_01de:
					num = 38;
					sFileName = Path.GetFileName(sFileName);
					goto IL_01e9;
					IL_01e9:
					num = 39;
					Suppress = false;
					Main.SavePGP(ref F, ref sFileName, ref Suppress);
					goto end_IL_0000_2;
					IL_0008:
					num = 2;
					if ((Main.nChange == 0) & (Operators.CompareString(Strings.LCase(Main.sACADPGP), Strings.LCase(Main.sFileInMemory), false) == 0))
					{
						goto IL_0033;
					}
					goto IL_0056;
					IL_0033:
					num = 3;
					((Control)cmdApply).set_Enabled(false);
					goto IL_0042;
					IL_0042:
					num = 4;
					mnuFileSave.set_Enabled(false);
					goto end_IL_0000_2;
					IL_0056:
					num = 7;
					F = Main.sFileInMemory;
					goto IL_0060;
					IL_0060:
					num = 8;
					sFileName = Main.sFname;
					goto IL_0069;
					IL_0069:
					num = 9;
					flag = false;
					goto IL_006f;
					IL_006f:
					num = 10;
					if (Operators.CompareString(Main.sFileInMemory, "", false) == 0)
					{
						goto IL_0086;
					}
					goto IL_0091;
					IL_0086:
					num = 11;
					flag = true;
					goto IL_0151;
					IL_0091:
					num = 13;
					goto IL_0095;
					IL_0095:
					num = 14;
					if ((chkConfirm.get_CheckState() & (0 - ((Main.nChange > 0) ? 1 : 0))) > 0)
					{
						goto IL_00b9;
					}
					goto IL_0151;
					IL_00b9:
					num = 15;
					if ((Operators.CompareString(F, "", false) != 0) & Main.Exist(ref F))
					{
						goto IL_00da;
					}
					goto IL_0130;
					IL_00da:
					num = 16;
					num7 = checked((short)Interaction.MsgBox((object)(F + "\r\n\r\n" + resManager.GetString("STR_OVERWRITE")), (MsgBoxStyle)307, (object)(resManager.GetString("STR_OVERWRITETITLE") + Main.sFname + resManager.GetString("STR_?"))));
					goto IL_0130;
					IL_0130:
					num = 18;
					if ((num7 == 7) | (Operators.CompareString(F, "", false) == 0))
					{
						goto IL_014b;
					}
					goto IL_0151;
					IL_014b:
					num = 19;
					flag = true;
					goto IL_0151;
					IL_0151:
					num = 23;
					if (flag)
					{
						goto IL_0158;
					}
					goto IL_01d1;
					IL_0158:
					num = 24;
					StartFileName = "";
					goto IL_0163;
					IL_0163:
					num = 25;
					if (Main.Exist(ref Main.sACADPGP))
					{
						goto IL_0173;
					}
					goto IL_017e;
					IL_0173:
					num = 26;
					StartFileName = Main.sACADPGP;
					goto IL_017e;
					IL_017e:
					num = 28;
					Filter_Renamed = resManager.GetString("STR_SAVEFILEFILTER");
					F = Main.GetSaveFile(ref Filter_Renamed, ref StartFileName);
					goto IL_019f;
					IL_019f:
					num = 29;
					if (Operators.CompareString(F, "", false) == 0)
					{
						goto IL_01b3;
					}
					goto IL_01bf;
					IL_01b3:
					num = 30;
					Cancel = true;
					goto end_IL_0000_2;
					IL_01bf:
					num = 33;
					sFileName = ((FileDialog)cdgSave).get_Title();
					goto IL_01de;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 1042;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void cmdOK_Click(object sender, EventArgs e)
	{
		bool Cancel = default(bool);
		StartApply(ref Cancel);
		if (Cancel)
		{
			StartCancel();
		}
		else
		{
			ProjectData.EndApp();
		}
	}

	private void cmdCancel_Click(object sender, EventArgs e)
	{
		StartCancel();
	}

	public void StartCancel()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (Main.nChange > 0)
		{
			short num = checked((short)Interaction.MsgBox((object)resManager.GetString("STR_MADECHANGES"), (MsgBoxStyle)51, (object)(resManager.GetString("STR_SAVECHG") + Main.sFname + resManager.GetString("STR_?"))));
			if (num == 7)
			{
				((Form)this).Close();
			}
			if (num == 6)
			{
				cmdApply_Click(cmdApply, new EventArgs());
			}
			if (num != 2)
			{
			}
		}
		else
		{
			((Form)this).Close();
			ProjectData.EndApp();
		}
	}

	private void cmdEdit_Click(object sender, EventArgs e)
	{
		short num = checked((short)cmdEdit.IndexOf(RuntimeHelpers.GetObjectValue(sender)));
		short Index = num;
		StartEdit(ref Index);
	}

	private void cmdRemove_Click(object sender, EventArgs e)
	{
		short num = checked((short)cmdRemove.IndexOf(RuntimeHelpers.GetObjectValue(sender)));
		short Index = num;
		StartRemove(ref Index);
	}

	private void InitializeListViews()
	{
		_lvwAlias.get_Columns().Add(resManager.GetString("STR_ACOL1"), 80, (HorizontalAlignment)0);
		_lvwAlias.get_Columns().Add(resManager.GetString("STR_ACOL2"), 120, (HorizontalAlignment)0);
		_lvwShell.get_Columns().Add(resManager.GetString("STR_CCOL1"), 80, (HorizontalAlignment)0);
		_lvwShell.get_Columns().Add(resManager.GetString("STR_CCOL2"), 80, (HorizontalAlignment)0);
		_lvwShell.get_Columns().Add(resManager.GetString("STR_CCOL3"), 80, (HorizontalAlignment)0);
		_lvwShell.get_Columns().Add(resManager.GetString("STR_CCOL4"), 80, (HorizontalAlignment)0);
		lvwAlias.Clear();
		lvwAlias.Add(_lvwAlias);
		lvwAlias.Add(_lvwShell);
		fraMain.Clear();
		fraMain.Add(_fraMain_0);
		fraMain.Add(_fraMain_1);
		cmdAdd.Clear();
		cmdAdd.Add(_cmdAdd_0);
		cmdAdd.Add(_cmdAdd_1);
		cmdRemove.Clear();
		cmdRemove.Add(_cmdRemove_0);
		cmdRemove.Add(_cmdRemove_1);
		cmdEdit.Clear();
		cmdEdit.Add(_cmdEdit_0);
		cmdEdit.Add(_cmdEdit_1);
		pctAlias.Clear();
		pctAlias.Add(_pctAlias_0);
		pctAlias.Add(_pctAlias_1);
	}

	private void getProductInfoFromRegistryString(string productReg, ref string prodInfo)
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					char[] separator = new char[1] { '\\' };
					string[] array = productReg.Split(separator, 5);
					if (array.GetLength(0) == 5)
					{
						prodInfo = array[4].Substring(checked(array[4].IndexOf(":") + 1));
					}
					break;
				}
				case 67:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto IL_007b;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 67;
				continue;
			}
			break;
			IL_007b:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void LoadResource()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0000_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						string location = Assembly.GetEntryAssembly()!.Location;
						string path = location.Substring(0, location.LastIndexOf("\\") + 1) + "..\\identity.ini";
						if (!File.Exists(path))
						{
							break;
						}
						StreamReader streamReader = File.OpenText(path);
						string text = streamReader.ReadLine();
						if (!text.Equals("[ProductIdentity]"))
						{
							break;
						}
						text = streamReader.ReadLine();
						streamReader.Close();
						int num3 = text.IndexOf("=");
						if (num3 < 0)
						{
							break;
						}
						string text2 = text.Substring(num3 + 1);
						char[] separator = new char[1] { '\\' };
						string[] array = text2.Split(separator, 5);
						if (array.Length == 5)
						{
							string prodInfo = "";
							getProductInfoFromRegistryString(text2, ref prodInfo);
							if (!(Conversions.ToDouble(prodInfo) > 3.0))
							{
								int culture = int.Parse(prodInfo, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
								Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture, useUserOverride: true);
							}
						}
						break;
					}
					case 263:
						num = -1;
						switch (num2)
						{
						case 2:
							break;
						default:
							goto IL_0141;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 263;
				continue;
			}
			break;
			IL_0141:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void frmAlias_Load(object sender, EventArgs e)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		LoadResource();
		HelpProvider1.set_HelpNamespace(Path.GetDirectoryName(Application.get_ExecutablePath()) + "\\acet.chm");
		InitializeListViews();
		short num = 0;
		checked
		{
			do
			{
				NewLateBinding.LateSetComplex(lvwAlias[num], (Type)null, "Font", new object[1] { (object)new Font("FixedSys", 8f) }, (string[])null, (Type[])null, false, true);
				num = (short)unchecked(num + 1);
			}
			while (num <= 1);
			chkConfirm.set_CheckState((CheckState)Conversions.ToShort(Interaction.GetSetting("Autodesk Applications", "AutoCAD Alias Editor", "Confirm", "1")));
			Cursor.set_Current(Cursors.get_WaitCursor());
			Main.sFileInMemory = Main.GetPath();
			Main.sFname = Main.sFileInMemory;
			Main.CleanUpForm();
			((Control)this).Show();
			NewLateBinding.LateCall(fraMain[0], (Type)null, "BringToFront", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			if (Operators.CompareString(Main.sFileInMemory, "", false) != 0)
			{
				bool Import = false;
				Main.ParsePGP(ref Main.sFileInMemory, ref Import);
				Import = false;
				FillInListView(ref Import);
			}
			else
			{
				bool Import = false;
				StartBrowse(ref Import);
			}
			Main.nChange = 0;
			Cursor.set_Current(Cursors.get_Default());
		}
	}

	public void FillInListView(ref bool Import)
	{
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected O, but got Unknown
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected O, but got Unknown
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		ListViewItem val = default(ListViewItem);
		short num5 = default(short);
		short num6 = default(short);
		short nTotalAlias = default(short);
		ListViewItem val2 = default(ListViewItem);
		short nTotalShell = default(short);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					object obj;
					object[] array;
					object[] array2;
					object obj2;
					object obj3;
					object[] array4;
					object[] array5;
					bool[] array3;
					object obj4;
					object WhichTab;
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0008;
					case 1154:
						{
							num2 = num;
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0008;
							case 3:
								goto IL_0015;
							case 4:
								goto IL_0024;
							case 5:
								goto IL_0031;
							case 6:
								goto IL_0038;
							case 7:
								goto IL_0071;
							case 8:
								goto IL_00aa;
							case 10:
								goto IL_00b1;
							case 11:
								goto IL_00b5;
							case 9:
							case 12:
							case 13:
								goto IL_00f3;
							case 14:
								goto IL_0108;
							case 15:
								goto IL_0124;
							case 16:
								goto IL_012d;
							case 17:
								goto IL_0149;
							case 18:
								goto IL_0166;
							case 19:
							case 20:
								goto IL_01e5;
							case 21:
								goto IL_01f3;
							case 22:
								goto IL_01fe;
							case 23:
								goto IL_020e;
							case 24:
								goto IL_021c;
							case 25:
								goto IL_0224;
							case 27:
								goto IL_0264;
							case 28:
								goto IL_0268;
							case 26:
							case 29:
							case 30:
								goto IL_026e;
							case 31:
								goto IL_0280;
							case 32:
								goto IL_0289;
							case 33:
								goto IL_02a5;
							case 34:
								goto IL_02c2;
							case 35:
								goto IL_02e4;
							case 36:
								goto IL_0301;
							case 37:
								goto IL_0380;
							case 38:
								goto IL_0391;
							case 39:
								goto IL_03a5;
							case 40:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 41:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_02e4:
						num = 35;
						val.get_SubItems().Add(Strings.Trim(Main.sPrompt[num5]));
						goto IL_0301;
						IL_0008:
						num = 2;
						Cursor.set_Current(Cursors.get_WaitCursor());
						goto IL_0015;
						IL_0015:
						num = 3;
						((Control)lblProgress).set_Visible(true);
						goto IL_0024;
						IL_0024:
						num = 4;
						((Control)DefInstance).Refresh();
						goto IL_0031;
						IL_0031:
						num = 5;
						if (!Import)
						{
							goto IL_0038;
						}
						goto IL_00b1;
						IL_0038:
						num = 6;
						NewLateBinding.LateCall(NewLateBinding.LateGet(lvwAlias[0], (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						goto IL_0071;
						IL_0071:
						num = 7;
						NewLateBinding.LateCall(NewLateBinding.LateGet(lvwAlias[1], (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						goto IL_00aa;
						IL_00aa:
						num = 8;
						num6 = 0;
						goto IL_00f3;
						IL_00b1:
						num = 10;
						goto IL_00b5;
						IL_00b5:
						num = 11;
						num6 = Conversions.ToShort(NewLateBinding.LateGet(NewLateBinding.LateGet(lvwAlias[0], (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null));
						goto IL_00f3;
						IL_00f3:
						num = 13;
						nTotalAlias = Main.nTotalAlias;
						num5 = 0;
						goto IL_0100;
						IL_0100:
						if (num5 <= nTotalAlias)
						{
							goto IL_0108;
						}
						goto IL_01f3;
						IL_0108:
						num = 14;
						if (Operators.CompareString(Main.sAlias[num5], "---", false) != 0)
						{
							goto IL_0124;
						}
						goto IL_01e5;
						IL_0124:
						num = 15;
						num6 = (short)(num6 + 1);
						goto IL_012d;
						IL_012d:
						num = 16;
						val2 = new ListViewItem(Strings.Trim(Strings.UCase(Main.sAlias[num5])));
						goto IL_0149;
						IL_0149:
						num = 17;
						val2.get_SubItems().Add(Strings.Trim(Main.sRep[num5]));
						goto IL_0166;
						IL_0166:
						num = 18;
						obj = NewLateBinding.LateGet(lvwAlias[0], (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
						array = new object[1] { val2 };
						array2 = array;
						array3 = new bool[1] { true };
						obj2 = NewLateBinding.LateGet(obj, (Type)null, "Add", array2, (string[])null, (Type[])null, array3);
						if (array3[0])
						{
							val2 = (ListViewItem)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(ListViewItem));
						}
						_ = (ListViewItem)obj2;
						goto IL_01e5;
						IL_0380:
						num = 37;
						num5 = (short)unchecked(num5 + 1);
						goto IL_0389;
						IL_0301:
						num = 36;
						obj3 = NewLateBinding.LateGet(lvwAlias[1], (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
						array4 = new object[1] { val };
						array5 = array4;
						array3 = new bool[1] { true };
						obj4 = NewLateBinding.LateGet(obj3, (Type)null, "Add", array5, (string[])null, (Type[])null, array3);
						if (array3[0])
						{
							val = (ListViewItem)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(ListViewItem));
						}
						_ = (ListViewItem)obj4;
						goto IL_0380;
						IL_01e5:
						num = 20;
						num5 = (short)unchecked(num5 + 1);
						goto IL_0100;
						IL_01f3:
						num = 21;
						Main.SelectAListItem(1, 0);
						goto IL_01fe;
						IL_01fe:
						num = 22;
						((Control)lblProgress).set_Visible(false);
						goto IL_020e;
						IL_020e:
						num = 23;
						((Control)DefInstance).Refresh();
						goto IL_021c;
						IL_021c:
						num = 24;
						if (Import)
						{
							goto IL_0224;
						}
						goto IL_0264;
						IL_0224:
						num = 25;
						num6 = Conversions.ToShort(NewLateBinding.LateGet(NewLateBinding.LateGet(lvwAlias[1], (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null));
						goto IL_026e;
						IL_0264:
						num = 27;
						goto IL_0268;
						IL_0268:
						num = 28;
						num6 = 0;
						goto IL_026e;
						IL_026e:
						num = 30;
						nTotalShell = Main.nTotalShell;
						num5 = 0;
						goto IL_0389;
						IL_0389:
						if (num5 <= nTotalShell)
						{
							goto IL_0280;
						}
						goto IL_0391;
						IL_0391:
						num = 38;
						WhichTab = (short)0;
						Main.CheckForDuplicates(ref WhichTab, ref Import);
						goto IL_03a5;
						IL_03a5:
						num = 39;
						WhichTab = (short)1;
						Main.CheckForDuplicates(ref WhichTab, ref Import);
						break;
						IL_0280:
						num = 31;
						num6 = (short)(num6 + 1);
						goto IL_0289;
						IL_0289:
						num = 32;
						val = new ListViewItem(Strings.Trim(Strings.UCase(Main.sShell[num5])));
						goto IL_02a5;
						IL_02a5:
						num = 33;
						val.get_SubItems().Add(Strings.Trim(Main.sCommand[num5]));
						goto IL_02c2;
						IL_02c2:
						num = 34;
						val.get_SubItems().Add(Strings.Trim(Strings.LCase(Main.sFlag[num5])));
						goto IL_02e4;
						end_IL_0000_2:
						break;
					}
					num = 40;
					Cursor.set_Current(Cursors.get_Default());
					break;
				}
				end_IL_0000:;
			}
			catch (object obj5) when (obj5 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj5);
				try0000_dispatch = 1154;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void frmAlias_Closed(object sender, EventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected I4, but got Unknown
		Interaction.SaveSetting("Autodesk Applications", "AutoCAD Alias Editor", "Confirm", Conversions.ToString((int)chkConfirm.get_CheckState()));
		ProjectData.EndApp();
	}

	private void lvwAlias_AfterLabelEdit(object sender, LabelEditEventArgs e)
	{
		short index = checked((short)lvwAlias.IndexOf(RuntimeHelpers.GetObjectValue(sender)));
		string text = Strings.LCase("");
		Type typeFromHandle = typeof(Strings);
		object[] array = new object[1];
		object obj = lvwAlias[index];
		object[] array2 = new object[0];
		string[] array3 = null;
		array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "SelectedItem", array2, array3, (Type[])null, (bool[])null), (Type)null, "Default", new object[0], (string[])null, (Type[])null, (bool[])null));
		object[] array4 = array;
		bool[] array5 = new bool[1] { true };
		object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "LCase", array4, (string[])null, (Type[])null, array5);
		if (array5[0])
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "SelectedItem", array2, array3, (Type[])null, (bool[])null), (Type)null, "Default", new object[1] { RuntimeHelpers.GetObjectValue(array4[0]) }, (string[])null, (Type[])null, true, true);
		}
		if (Operators.ConditionalCompareObjectNotEqual((object)text, obj2, false))
		{
			cmdRemove_Click(RuntimeHelpers.GetObjectValue(cmdRemove[index]), new EventArgs());
			Main.AppendAlias();
			Main.nEdit = 0;
			NewLateBinding.LateCall(lvwAlias[index], (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	public void lvwAlias_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		short index = checked((short)lvwAlias.IndexOf(RuntimeHelpers.GetObjectValue(sender)));
		ListView val = (ListView)lvwAlias[index];
		Cursor.set_Current(Cursors.get_WaitCursor());
		if ((int)val.get_Sorting() == 1)
		{
			val.set_Sorting((SortOrder)2);
		}
		else
		{
			val.set_Sorting((SortOrder)1);
		}
		ListViewItem val2 = null;
		if (val.get_SelectedItems().get_Count() > 0)
		{
			val2 = val.get_SelectedItems().get_Item(0);
		}
		val.set_ListViewItemSorter((IComparer)new ColumnSort(e.get_Column()));
		if (!Information.IsNothing((object)val2))
		{
			val2.EnsureVisible();
		}
		Cursor.set_Current(Cursors.get_Default());
	}

	private void lvwAlias_DblClick(object sender, EventArgs e)
	{
		short num = checked((short)lvwAlias.IndexOf(RuntimeHelpers.GetObjectValue(sender)));
		short Index = num;
		StartEdit(ref Index);
	}

	private void lvwAlias_Enter(object sender, EventArgs e)
	{
		short index = checked((short)lvwAlias.IndexOf(RuntimeHelpers.GetObjectValue(sender)));
		NewLateBinding.LateSetComplex(cmdEdit[index], (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(cmdRemove[index], (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null, false, true);
	}

	private void lvwAlias_ItemClick(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					short index = checked((short)lvwAlias.IndexOf(RuntimeHelpers.GetObjectValue(sender)));
					ProjectData.ClearProjectError();
					num2 = 2;
					NewLateBinding.LateSetComplex(cmdRemove[index], (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateCall(lvwAlias[index], (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					break;
				}
				case 106:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto IL_00a0;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 106;
				continue;
			}
			break;
			IL_00a0:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void lvwAlias_KeyDownEvent(object sender, KeyEventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Invalid comparison between Unknown and I4
		short index = checked((short)lvwAlias.IndexOf(RuntimeHelpers.GetObjectValue(sender)));
		if ((int)e.get_KeyCode() == 46)
		{
			cmdRemove_Click(RuntimeHelpers.GetObjectValue(cmdRemove[index]), new EventArgs());
		}
		if ((int)e.get_KeyCode() == 32)
		{
			cmdEdit_Click(RuntimeHelpers.GetObjectValue(cmdEdit[index]), new EventArgs());
		}
	}

	private void lvwAlias_Leave(object sender, EventArgs e)
	{
		checked
		{
			_ = (short)lvwAlias.IndexOf(RuntimeHelpers.GetObjectValue(sender));
		}
	}

	public void mnuEditAdd_Popup(object sender, EventArgs e)
	{
		mnuEditAdd_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	public void mnuEditAdd_Click(object sender, EventArgs e)
	{
		cmdAdd_Click(RuntimeHelpers.GetObjectValue(cmdAdd[Main.CurrentTab()]), new EventArgs());
	}

	public void mnuEditEdit_Popup(object sender, EventArgs e)
	{
		mnuEditEdit_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	public void mnuEditEdit_Click(object sender, EventArgs e)
	{
		cmdEdit_Click(RuntimeHelpers.GetObjectValue(cmdEdit[Main.CurrentTab()]), new EventArgs());
	}

	public void mnuEditRemove_Popup(object sender, EventArgs e)
	{
		mnuEditRemove_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	public void mnuEditRemove_Click(object sender, EventArgs e)
	{
		cmdRemove_Click(RuntimeHelpers.GetObjectValue(cmdRemove[Main.CurrentTab()]), new EventArgs());
	}

	public void mnuFileExit_Popup(object sender, EventArgs e)
	{
		mnuFileExit_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	public void mnuFileExit_Click(object sender, EventArgs e)
	{
		cmdCancel_Click(cmdCancel, new EventArgs());
	}

	public void mnuFileExport_Popup(object sender, EventArgs e)
	{
		mnuFileExport_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	public void mnuFileExport_Click(object sender, EventArgs e)
	{
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		short num6 = default(short);
		string text = default(string);
		string StartFileName = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num4;
				ErrObject val;
				int errVal;
				short num5;
				object WS;
				SaveFileDialog val2;
				SaveFileDialog val3;
				string sFileName;
				CheckBox val4;
				bool Suppress;
				short WhichTab;
				string sFilePath;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 2;
					goto IL_0008;
				case 875:
					{
						num2 = num;
						switch (num3)
						{
						case 2:
							break;
						case 1:
							goto IL_0362;
						default:
							goto end_IL_0000;
						}
						goto IL_0289;
					}
					IL_0362:
					num4 = num2 + 1;
					goto IL_017b;
					IL_0289:
					num = 19;
					Cursor.set_Current(Cursors.get_Default());
					goto IL_0262;
					IL_0262:
					num = 20;
					val = Information.Err();
					errVal = val.get_Number();
					num5 = ErrorHandler.FileErrors(ref errVal);
					val.set_Number(errVal);
					num6 = num5;
					goto IL_0243;
					IL_0243:
					num = 21;
					switch (num6)
					{
					case 1:
						break;
					case 0:
						goto IL_02a9;
					default:
						goto IL_0332;
					case 3:
						goto end_IL_0000_2;
					case 2:
						goto end_IL_0000_3;
					}
					goto IL_0231;
					IL_0231:
					num = 29;
					ProjectData.ClearProjectError();
					if (num2 != 0)
					{
						num4 = num2;
						goto IL_017b;
					}
					throw ProjectData.CreateProjectError(-2146828268);
					IL_014e:
					num = 16;
					WS = text;
					Main.WriteOut(ref StartFileName, ref WS);
					text = Conversions.ToString(WS);
					goto IL_0166;
					IL_0166:
					num = 17;
					Cursor.set_Current(Cursors.get_Default());
					goto end_IL_0000_3;
					IL_017b:
					num2 = 0;
					switch (num4)
					{
					case 1:
						break;
					case 2:
						goto IL_0008;
					case 3:
						goto IL_0015;
					case 4:
						goto IL_0022;
					case 5:
						goto IL_0033;
					case 6:
						goto IL_0044;
					case 7:
						goto IL_00ca;
					case 8:
						goto IL_00d3;
					case 9:
						goto IL_00e3;
					case 10:
					case 11:
						goto IL_0108;
					case 12:
						goto IL_0128;
					case 14:
					case 15:
						goto IL_0140;
					case 16:
						goto IL_014e;
					case 17:
						goto IL_0166;
					default:
						goto end_IL_0000;
					case 28:
					case 29:
						goto IL_0231;
					case 21:
						goto IL_0243;
					case 20:
						goto IL_0262;
					case 19:
						goto IL_0289;
					case 0:
					case 24:
						goto end_IL_0000;
					case 23:
					case 25:
						goto IL_02a9;
					case 26:
						goto IL_02bd;
					case 38:
					case 39:
						goto IL_0332;
					case 35:
					case 36:
						goto end_IL_0000_2;
					case 13:
					case 18:
					case 22:
					case 27:
					case 30:
					case 31:
					case 32:
					case 33:
					case 34:
					case 37:
					case 40:
					case 41:
					case 42:
						goto end_IL_0000_3;
					}
					goto default;
					IL_0332:
					num = 39;
					Interaction.MsgBox((object)resManager.GetString("STR_INTERNALERROR"), (MsgBoxStyle)0, (object)null);
					ProjectData.EndApp();
					goto end_IL_0000_3;
					IL_02a9:
					num = 25;
					((CommonDialog)DefInstance.cdgSave).ShowDialog();
					goto IL_02bd;
					IL_02bd:
					num = 26;
					val2 = DefInstance.cdgSave;
					sFilePath = ((FileDialog)val2).get_FileName();
					val3 = DefInstance.cdgSave;
					sFileName = ((FileDialog)val3).get_Title();
					val4 = DefInstance.chkConfirm;
					Suppress = val4.get_Checked();
					Main.SavePGP(ref sFilePath, ref sFileName, ref Suppress);
					val4.set_Checked(Suppress);
					((FileDialog)val3).set_Title(sFileName);
					((FileDialog)val2).set_FileName(sFilePath);
					goto end_IL_0000_3;
					IL_0008:
					num = 2;
					Main.sAliases = "";
					goto IL_0015;
					IL_0015:
					num = 3;
					Main.sShells = "";
					goto IL_0022;
					IL_0022:
					num = 4;
					WhichTab = 0;
					Main.sAliases = Main.PGPString(ref WhichTab);
					goto IL_0033;
					IL_0033:
					num = 5;
					WhichTab = 1;
					Main.sShells = Main.PGPString(ref WhichTab);
					goto IL_0044;
					IL_0044:
					num = 6;
					text = "; This PGP file was created with the AutoCAD Alias Editor.\r\n; Last modified " + Strings.Format((object)DateAndTime.get_Today().ToOADate(), "") + "   " + Conversion.Str((object)DateAndTime.get_TimeOfDay().ToOADate()) + "\r\n\r\n; Use the Alias Editor (ALIASEDIT command) to edit this file.\r\n\r\n; [Operating System Commands]\r\n\r\n" + Main.sShells + "\r\n\r\n; [AutoCAD Command Aliases]\r\n\r\n" + Main.sAliases;
					goto IL_00ca;
					IL_00ca:
					num = 7;
					StartFileName = "";
					goto IL_00d3;
					IL_00d3:
					num = 8;
					if (Strings.Len(Main.sFileInMemory) > 4)
					{
						goto IL_00e3;
					}
					goto IL_0108;
					IL_00e3:
					num = 9;
					StartFileName = Strings.Left(Main.sFileInMemory, checked(Strings.Len(Main.sFileInMemory) - 4)) + ".pgp";
					goto IL_0108;
					IL_0108:
					num = 11;
					sFilePath = resManager.GetString("STR_SAVEEXTENSION");
					StartFileName = Main.GetSaveFile(ref sFilePath, ref StartFileName);
					goto IL_0128;
					IL_0128:
					num = 12;
					if (Operators.CompareString(StartFileName, "", false) == 0)
					{
						goto end_IL_0000_3;
					}
					goto IL_0140;
					IL_0140:
					num = 15;
					Cursor.set_Current(Cursors.get_WaitCursor());
					goto IL_014e;
					end_IL_0000_2:
					break;
				}
				num = 36;
				ErrorHandler.ShowError();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 875;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void mnuFileImport_Popup(object sender, EventArgs e)
	{
		mnuFileImport_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	public void mnuFileImport_Click(object sender, EventArgs e)
	{
		string sFileInMemory = Main.sFileInMemory;
		string sFname = Main.sFname;
		bool Import = true;
		StartBrowse(ref Import);
		Main.sFileInMemory = sFileInMemory;
		Main.sFname = sFname;
		Main.CleanUpForm();
	}

	public void mnuFileNew_Popup(object sender, EventArgs e)
	{
		mnuFileNew_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	public void mnuFileNew_Click(object sender, EventArgs e)
	{
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected I4, but got Unknown
		int try0000_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					int num3 = 7;
					if ((Main.nChange & (short)(0u - ((Operators.CompareString(Main.sFname, "", false) != 0) ? 1u : 0u))) != 0)
					{
						string text = resManager.GetString("STR_UNNAMED");
						if (Operators.CompareString(Main.sFileInMemory, "", false) != 0)
						{
							text = Main.sFileInMemory;
						}
						num3 = (int)Interaction.MsgBox((object)(resManager.GetString("STR_SAVECHG") + text + resManager.GetString("STR_?")), (MsgBoxStyle)291, (object)resManager.GetString("STR_SAVETITLE"));
						if (num3 == 2)
						{
							break;
						}
					}
					if (num3 == 6)
					{
						if (Operators.CompareString(Main.sFileInMemory, "", false) == 0)
						{
							string Filter_Renamed = resManager.GetString("STR_SAVEEXTENSION");
							string StartFileName = Main.sACADPGP + "\\acad.pgp";
							Main.sFileInMemory = Main.GetSaveFile(ref Filter_Renamed, ref StartFileName);
							if (Operators.CompareString(Main.sFileInMemory, "", false) == 0)
							{
								break;
							}
							Main.sFname = ((FileDialog)cdgOpen).get_Title();
						}
						bool Suppress = true;
						Main.SavePGP(ref Main.sFileInMemory, ref Main.sFname, ref Suppress);
					}
					Main.sFileInMemory = "";
					Main.sFname = resManager.GetString("STR_UNNAMED");
					NewLateBinding.LateCall(NewLateBinding.LateGet(lvwAlias[0], (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					NewLateBinding.LateCall(NewLateBinding.LateGet(lvwAlias[1], (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					Main.nChange = 0;
					Main.CleanUpForm();
					break;
				}
				case 448:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto IL_01fa;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 448;
				continue;
			}
			break;
			IL_01fa:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void mnuFileOpen_Popup(object sender, EventArgs e)
	{
		mnuFileOpen_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	public void mnuFileOpen_Click(object sender, EventArgs e)
	{
		bool Import = false;
		StartBrowse(ref Import);
	}

	public void mnuFilePrint_Popup(object sender, EventArgs e)
	{
		mnuFilePrint_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	public void mnuFilePrint_Click(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Invalid comparison between Unknown and I4
		try
		{
			Main.pd.add_PrintPage(new PrintPageEventHandler(Main.PrintMe));
			PrintDialog val = new PrintDialog();
			Main.Index = 0;
			Main.count = 0;
			Main.y = 0;
			Main.nPage = 1;
			val.set_Document(Main.pd);
			val.set_AllowSomePages(false);
			if ((int)((CommonDialog)val).ShowDialog() == 1)
			{
				Main.pd.Print();
			}
		}
		finally
		{
		}
	}

	public void mnuFileSave_Popup(object sender, EventArgs e)
	{
		mnuFileSave_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	public void mnuFileSave_Click(object sender, EventArgs e)
	{
		Main.nChange = 1;
		bool Cancel = false;
		StartApply(ref Cancel);
	}

	public void mnuFileSetup_Popup(object sender, EventArgs e)
	{
		mnuFileSetup_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	public void mnuFileSetup_Click(object sender, EventArgs e)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					PageSetupDlg.set_Document(Main.pd);
					((CommonDialog)PageSetupDlg).ShowDialog();
					break;
				case 39:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto IL_005d;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 39;
				continue;
			}
			break;
			IL_005d:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void mnuHelpAbout_Popup(object sender, EventArgs e)
	{
		mnuHelpAbout_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	public void mnuHelpAbout_Click(object sender, EventArgs e)
	{
		((Control)frmAbout.DefInstance).Show();
	}

	public void mnuHelpSearch_Popup(object sender, EventArgs e)
	{
		mnuHelpSearch_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	public void mnuHelpSearch_Click(object sender, EventArgs e)
	{
		SendKeys.Send("{F1}");
	}

	private void tbsMain_ClickEvent(object sender, EventArgs e)
	{
		short num = Main.CurrentTab();
		NewLateBinding.LateSetComplex(cmdAdd[num], (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(cmdEdit[num], (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(cmdRemove[num], (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(lvwAlias[num], (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(fraMain[num], (Type)null, "BringToFront", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		switch (num)
		{
		case 0:
			NewLateBinding.LateSetComplex(cmdAdd[1], (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(cmdEdit[1], (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(cmdRemove[1], (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(lvwAlias[1], (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
			break;
		case 1:
			NewLateBinding.LateSetComplex(cmdAdd[0], (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(cmdEdit[0], (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(cmdRemove[0], (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(lvwAlias[0], (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
			break;
		}
		NewLateBinding.LateCall(cmdAdd[num], (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}
}
