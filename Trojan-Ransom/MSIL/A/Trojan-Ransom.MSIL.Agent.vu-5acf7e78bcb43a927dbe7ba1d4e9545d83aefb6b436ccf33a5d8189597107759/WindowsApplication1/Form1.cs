using System;
using System.ComponentModel;
using System.Diagnostics;
using System.DirectoryServices;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.ServiceProcess;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication1;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[AccessedThroughProperty("CheckBox2")]
	private CheckBox _CheckBox2;

	[AccessedThroughProperty("CheckBox3")]
	private CheckBox _CheckBox3;

	[AccessedThroughProperty("CheckedListBox1")]
	private CheckedListBox _CheckedListBox1;

	[AccessedThroughProperty("CheckedListBox2")]
	private CheckedListBox _CheckedListBox2;

	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

	[AccessedThroughProperty("ComboBox2")]
	private ComboBox _ComboBox2;

	[AccessedThroughProperty("ComboBox3")]
	private ComboBox _ComboBox3;

	[AccessedThroughProperty("ContextMenuStrip1")]
	private ContextMenuStrip _ContextMenuStrip1;

	[AccessedThroughProperty("ContextMenuStrip2")]
	private ContextMenuStrip _ContextMenuStrip2;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("DomainUpDown1")]
	private DomainUpDown _DomainUpDown1;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("GroupBox2")]
	private GroupBox _GroupBox2;

	[AccessedThroughProperty("GroupBox3")]
	private GroupBox _GroupBox3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("FileSystemWatcher1")]
	private FileSystemWatcher _FileSystemWatcher1;

	[AccessedThroughProperty("ToolStripContainer1")]
	private ToolStripContainer _ToolStripContainer1;

	[AccessedThroughProperty("ToolStrip1")]
	private ToolStrip _ToolStrip1;

	[AccessedThroughProperty("SplitContainer1")]
	private SplitContainer _SplitContainer1;

	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

	[AccessedThroughProperty("TabPage1")]
	private TabPage _TabPage1;

	[AccessedThroughProperty("TableLayoutPanel1")]
	private TableLayoutPanel _TableLayoutPanel1;

	[AccessedThroughProperty("TabPage2")]
	private TabPage _TabPage2;

	[AccessedThroughProperty("SaveFileDialog1")]
	private SaveFileDialog _SaveFileDialog1;

	[AccessedThroughProperty("SerialPort1")]
	private SerialPort _SerialPort1;

	[AccessedThroughProperty("ServiceController1")]
	private ServiceController _ServiceController1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("RichTextBox1")]
	private RichTextBox _RichTextBox1;

	[AccessedThroughProperty("RadioButton1")]
	private RadioButton _RadioButton1;

	[AccessedThroughProperty("PropertyGrid1")]
	private PropertyGrid _PropertyGrid1;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("PrintPreviewControl2")]
	private PrintPreviewControl _PrintPreviewControl2;

	[AccessedThroughProperty("PrintPreviewControl1")]
	private PrintPreviewControl _PrintPreviewControl1;

	[AccessedThroughProperty("DomainUpDown2")]
	private DomainUpDown _DomainUpDown2;

	[AccessedThroughProperty("CheckBox10")]
	private CheckBox _CheckBox10;

	[AccessedThroughProperty("CheckBox9")]
	private CheckBox _CheckBox9;

	[AccessedThroughProperty("CheckBox8")]
	private CheckBox _CheckBox8;

	[AccessedThroughProperty("CheckBox7")]
	private CheckBox _CheckBox7;

	[AccessedThroughProperty("CheckBox6")]
	private CheckBox _CheckBox6;

	[AccessedThroughProperty("CheckBox5")]
	private CheckBox _CheckBox5;

	[AccessedThroughProperty("CheckBox4")]
	private CheckBox _CheckBox4;

	[AccessedThroughProperty("Button11")]
	private Button _Button11;

	[AccessedThroughProperty("Button10")]
	private Button _Button10;

	[AccessedThroughProperty("Button9")]
	private Button _Button9;

	[AccessedThroughProperty("Button8")]
	private Button _Button8;

	[AccessedThroughProperty("Button7")]
	private Button _Button7;

	[AccessedThroughProperty("Button6")]
	private Button _Button6;

	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[AccessedThroughProperty("EventLog1")]
	private EventLog _EventLog1;

	[AccessedThroughProperty("ErrorProvider1")]
	private ErrorProvider _ErrorProvider1;

	[AccessedThroughProperty("DirectorySearcher1")]
	private DirectorySearcher _DirectorySearcher1;

	[AccessedThroughProperty("PrintDialog1")]
	private PrintDialog _PrintDialog1;

	[AccessedThroughProperty("PrintDialog2")]
	private PrintDialog _PrintDialog2;

	[AccessedThroughProperty("PrintDocument1")]
	private PrintDocument _PrintDocument1;

	[AccessedThroughProperty("PrintDocument2")]
	private PrintDocument _PrintDocument2;

	[AccessedThroughProperty("PrintPreviewDialog1")]
	private PrintPreviewDialog _PrintPreviewDialog1;

	[AccessedThroughProperty("Process1")]
	private Process _Process1;

	[AccessedThroughProperty("SerialPort2")]
	private SerialPort _SerialPort2;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("MaskedTextBox1")]
	private MaskedTextBox _MaskedTextBox1;

	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[AccessedThroughProperty("MenuStrip1")]
	private MenuStrip _MenuStrip1;

	[AccessedThroughProperty("MenuStrip2")]
	private MenuStrip _MenuStrip2;

	[AccessedThroughProperty("MenuStrip3")]
	private MenuStrip _MenuStrip3;

	[AccessedThroughProperty("MenuStrip4")]
	private MenuStrip _MenuStrip4;

	[AccessedThroughProperty("PrintDialog3")]
	private PrintDialog _PrintDialog3;

	[AccessedThroughProperty("PrintDialog4")]
	private PrintDialog _PrintDialog4;

	[AccessedThroughProperty("Process2")]
	private Process _Process2;

	[AccessedThroughProperty("Process3")]
	private Process _Process3;

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

	internal virtual CheckBox CheckBox1
	{
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox1 = value;
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

	internal virtual CheckBox CheckBox3
	{
		get
		{
			return _CheckBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox3 = value;
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

	internal virtual CheckedListBox CheckedListBox2
	{
		get
		{
			return _CheckedListBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckedListBox2 = value;
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

	internal virtual ComboBox ComboBox3
	{
		get
		{
			return _ComboBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ComboBox3 = value;
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

	internal virtual ContextMenuStrip ContextMenuStrip2
	{
		get
		{
			return _ContextMenuStrip2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ContextMenuStrip2 = value;
		}
	}

	internal virtual Button Button3
	{
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button3 = value;
		}
	}

	internal virtual Button Button4
	{
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button4 = value;
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

	internal virtual GroupBox GroupBox2
	{
		get
		{
			return _GroupBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_GroupBox2 = value;
		}
	}

	internal virtual GroupBox GroupBox3
	{
		get
		{
			return _GroupBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_GroupBox3 = value;
		}
	}

	internal virtual Label Label2
	{
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label2 = value;
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

	internal virtual PrintPreviewControl PrintPreviewControl2
	{
		get
		{
			return _PrintPreviewControl2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PrintPreviewControl2 = value;
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

	internal virtual DomainUpDown DomainUpDown2
	{
		get
		{
			return _DomainUpDown2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_DomainUpDown2 = value;
		}
	}

	internal virtual CheckBox CheckBox10
	{
		get
		{
			return _CheckBox10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox10 = value;
		}
	}

	internal virtual CheckBox CheckBox9
	{
		get
		{
			return _CheckBox9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox9 = value;
		}
	}

	internal virtual CheckBox CheckBox8
	{
		get
		{
			return _CheckBox8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox8 = value;
		}
	}

	internal virtual CheckBox CheckBox7
	{
		get
		{
			return _CheckBox7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox7 = value;
		}
	}

	internal virtual CheckBox CheckBox6
	{
		get
		{
			return _CheckBox6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox6 = value;
		}
	}

	internal virtual CheckBox CheckBox5
	{
		get
		{
			return _CheckBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox5 = value;
		}
	}

	internal virtual CheckBox CheckBox4
	{
		get
		{
			return _CheckBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox4 = value;
		}
	}

	internal virtual Button Button11
	{
		get
		{
			return _Button11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button11 = value;
		}
	}

	internal virtual Button Button10
	{
		get
		{
			return _Button10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button10 = value;
		}
	}

	internal virtual Button Button9
	{
		get
		{
			return _Button9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button9 = value;
		}
	}

	internal virtual Button Button8
	{
		get
		{
			return _Button8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button8 = value;
		}
	}

	internal virtual Button Button7
	{
		get
		{
			return _Button7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button7 = value;
		}
	}

	internal virtual Button Button6
	{
		get
		{
			return _Button6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button6 = value;
		}
	}

	internal virtual Button Button5
	{
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button5 = value;
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

	internal virtual PrintDialog PrintDialog2
	{
		get
		{
			return _PrintDialog2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PrintDialog2 = value;
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

	internal virtual PrintDocument PrintDocument2
	{
		get
		{
			return _PrintDocument2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PrintDocument2 = value;
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

	internal virtual SerialPort SerialPort2
	{
		get
		{
			return _SerialPort2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_SerialPort2 = value;
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

	internal virtual Panel Panel2
	{
		get
		{
			return _Panel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Panel2 = value;
		}
	}

	internal virtual PictureBox PictureBox4
	{
		get
		{
			return _PictureBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PictureBox4 = value;
		}
	}

	internal virtual PictureBox PictureBox3
	{
		get
		{
			return _PictureBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PictureBox3 = value;
		}
	}

	internal virtual PictureBox PictureBox2
	{
		get
		{
			return _PictureBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PictureBox2 = value;
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

	internal virtual MenuStrip MenuStrip2
	{
		get
		{
			return _MenuStrip2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MenuStrip2 = value;
		}
	}

	internal virtual MenuStrip MenuStrip3
	{
		get
		{
			return _MenuStrip3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MenuStrip3 = value;
		}
	}

	internal virtual MenuStrip MenuStrip4
	{
		get
		{
			return _MenuStrip4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MenuStrip4 = value;
		}
	}

	internal virtual PrintDialog PrintDialog3
	{
		get
		{
			return _PrintDialog3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PrintDialog3 = value;
		}
	}

	internal virtual PrintDialog PrintDialog4
	{
		get
		{
			return _PrintDialog4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PrintDialog4 = value;
		}
	}

	internal virtual Process Process2
	{
		get
		{
			return _Process2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Process2 = value;
		}
	}

	internal virtual Process Process3
	{
		get
		{
			return _Process3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Process3 = value;
		}
	}

	public Form1()
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
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected O, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected O, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected O, but got Unknown
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected O, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected O, but got Unknown
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected O, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected O, but got Unknown
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected O, but got Unknown
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected O, but got Unknown
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected O, but got Unknown
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected O, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected O, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected O, but got Unknown
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected O, but got Unknown
		//IL_0d5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcd: Expected O, but got Unknown
		//IL_0ddf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de9: Expected O, but got Unknown
		//IL_0e2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e36: Expected O, but got Unknown
		//IL_0e48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e52: Expected O, but got Unknown
		//IL_0eae: Unknown result type (might be due to invalid IL or missing references)
		//IL_179d: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a7: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Button1 = new Button();
		Button2 = new Button();
		CheckBox1 = new CheckBox();
		CheckBox2 = new CheckBox();
		CheckBox3 = new CheckBox();
		CheckedListBox1 = new CheckedListBox();
		CheckedListBox2 = new CheckedListBox();
		ComboBox1 = new ComboBox();
		ComboBox2 = new ComboBox();
		ComboBox3 = new ComboBox();
		ContextMenuStrip1 = new ContextMenuStrip(components);
		ContextMenuStrip2 = new ContextMenuStrip(components);
		Button3 = new Button();
		Button4 = new Button();
		DomainUpDown1 = new DomainUpDown();
		GroupBox1 = new GroupBox();
		GroupBox2 = new GroupBox();
		GroupBox3 = new GroupBox();
		Label2 = new Label();
		Label1 = new Label();
		FileSystemWatcher1 = new FileSystemWatcher();
		SaveFileDialog1 = new SaveFileDialog();
		SerialPort1 = new SerialPort(components);
		ServiceController1 = new ServiceController();
		SplitContainer1 = new SplitContainer();
		TabControl1 = new TabControl();
		TabPage1 = new TabPage();
		TableLayoutPanel1 = new TableLayoutPanel();
		TabPage2 = new TabPage();
		Timer1 = new Timer(components);
		ToolStrip1 = new ToolStrip();
		ToolStripContainer1 = new ToolStripContainer();
		Button5 = new Button();
		Button6 = new Button();
		Button7 = new Button();
		Button8 = new Button();
		Button9 = new Button();
		Button10 = new Button();
		Button11 = new Button();
		CheckBox4 = new CheckBox();
		CheckBox5 = new CheckBox();
		CheckBox6 = new CheckBox();
		CheckBox7 = new CheckBox();
		CheckBox8 = new CheckBox();
		CheckBox9 = new CheckBox();
		CheckBox10 = new CheckBox();
		EventLog1 = new EventLog();
		DomainUpDown2 = new DomainUpDown();
		ErrorProvider1 = new ErrorProvider(components);
		DirectorySearcher1 = new DirectorySearcher();
		PrintDialog1 = new PrintDialog();
		PrintDialog2 = new PrintDialog();
		PrintDocument1 = new PrintDocument();
		PrintDocument2 = new PrintDocument();
		PrintPreviewControl1 = new PrintPreviewControl();
		PrintPreviewControl2 = new PrintPreviewControl();
		PrintPreviewDialog1 = new PrintPreviewDialog();
		Process1 = new Process();
		ProgressBar1 = new ProgressBar();
		PropertyGrid1 = new PropertyGrid();
		RadioButton1 = new RadioButton();
		RichTextBox1 = new RichTextBox();
		SerialPort2 = new SerialPort(components);
		MenuStrip1 = new MenuStrip();
		MenuStrip2 = new MenuStrip();
		MenuStrip3 = new MenuStrip();
		MenuStrip4 = new MenuStrip();
		ListView1 = new ListView();
		MaskedTextBox1 = new MaskedTextBox();
		PictureBox1 = new PictureBox();
		PictureBox2 = new PictureBox();
		PictureBox3 = new PictureBox();
		PictureBox4 = new PictureBox();
		PrintDialog3 = new PrintDialog();
		PrintDialog4 = new PrintDialog();
		Panel1 = new Panel();
		Panel2 = new Panel();
		Process2 = new Process();
		Process3 = new Process();
		((Control)GroupBox1).SuspendLayout();
		((Control)GroupBox2).SuspendLayout();
		((Control)GroupBox3).SuspendLayout();
		((ISupportInitialize)FileSystemWatcher1).BeginInit();
		((Control)SplitContainer1.get_Panel1()).SuspendLayout();
		((Control)SplitContainer1).SuspendLayout();
		((Control)TabControl1).SuspendLayout();
		((Control)TabPage1).SuspendLayout();
		((Control)ToolStripContainer1).SuspendLayout();
		((ISupportInitialize)EventLog1).BeginInit();
		((ISupportInitialize)ErrorProvider1).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox4).BeginInit();
		((Control)Panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		Button button = Button1;
		Point location = new Point(0, 0);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		Size size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Button button3 = Button2;
		location = new Point(8, 8);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(75, 23);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(1);
		((ButtonBase)Button2).set_Text("Button2");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox1).set_AutoSize(true);
		CheckBox checkBox = CheckBox1;
		location = new Point(16, 16);
		((Control)checkBox).set_Location(location);
		((Control)CheckBox1).set_Name("CheckBox1");
		CheckBox checkBox2 = CheckBox1;
		size = new Size(79, 17);
		((Control)checkBox2).set_Size(size);
		((Control)CheckBox1).set_TabIndex(2);
		((ButtonBase)CheckBox1).set_Text("CheckBox1");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox2).set_AutoSize(true);
		CheckBox checkBox3 = CheckBox2;
		location = new Point(24, 24);
		((Control)checkBox3).set_Location(location);
		((Control)CheckBox2).set_Name("CheckBox2");
		CheckBox checkBox4 = CheckBox2;
		size = new Size(79, 17);
		((Control)checkBox4).set_Size(size);
		((Control)CheckBox2).set_TabIndex(3);
		((ButtonBase)CheckBox2).set_Text("CheckBox2");
		((ButtonBase)CheckBox2).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox3).set_AutoSize(true);
		CheckBox checkBox5 = CheckBox3;
		location = new Point(32, 32);
		((Control)checkBox5).set_Location(location);
		((Control)CheckBox3).set_Name("CheckBox3");
		CheckBox checkBox6 = CheckBox3;
		size = new Size(79, 17);
		((Control)checkBox6).set_Size(size);
		((Control)CheckBox3).set_TabIndex(4);
		((ButtonBase)CheckBox3).set_Text("CheckBox3");
		((ButtonBase)CheckBox3).set_UseVisualStyleBackColor(true);
		((ListControl)CheckedListBox1).set_FormattingEnabled(true);
		CheckedListBox checkedListBox = CheckedListBox1;
		location = new Point(40, 40);
		((Control)checkedListBox).set_Location(location);
		((Control)CheckedListBox1).set_Name("CheckedListBox1");
		CheckedListBox checkedListBox2 = CheckedListBox1;
		size = new Size(120, 94);
		((Control)checkedListBox2).set_Size(size);
		((Control)CheckedListBox1).set_TabIndex(5);
		((ListControl)CheckedListBox2).set_FormattingEnabled(true);
		CheckedListBox checkedListBox3 = CheckedListBox2;
		location = new Point(48, 48);
		((Control)checkedListBox3).set_Location(location);
		((Control)CheckedListBox2).set_Name("CheckedListBox2");
		CheckedListBox checkedListBox4 = CheckedListBox2;
		size = new Size(120, 94);
		((Control)checkedListBox4).set_Size(size);
		((Control)CheckedListBox2).set_TabIndex(6);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		ComboBox comboBox = ComboBox1;
		location = new Point(56, 56);
		((Control)comboBox).set_Location(location);
		((Control)ComboBox1).set_Name("ComboBox1");
		ComboBox comboBox2 = ComboBox1;
		size = new Size(121, 21);
		((Control)comboBox2).set_Size(size);
		((Control)ComboBox1).set_TabIndex(7);
		((ListControl)ComboBox2).set_FormattingEnabled(true);
		ComboBox comboBox3 = ComboBox2;
		location = new Point(64, 64);
		((Control)comboBox3).set_Location(location);
		((Control)ComboBox2).set_Name("ComboBox2");
		ComboBox comboBox4 = ComboBox2;
		size = new Size(121, 21);
		((Control)comboBox4).set_Size(size);
		((Control)ComboBox2).set_TabIndex(8);
		((ListControl)ComboBox3).set_FormattingEnabled(true);
		ComboBox comboBox5 = ComboBox3;
		location = new Point(72, 72);
		((Control)comboBox5).set_Location(location);
		((Control)ComboBox3).set_Name("ComboBox3");
		ComboBox comboBox6 = ComboBox3;
		size = new Size(121, 21);
		((Control)comboBox6).set_Size(size);
		((Control)ComboBox3).set_TabIndex(9);
		((Control)ContextMenuStrip1).set_Name("ContextMenuStrip1");
		ContextMenuStrip contextMenuStrip = ContextMenuStrip1;
		size = new Size(61, 4);
		((Control)contextMenuStrip).set_Size(size);
		((Control)ContextMenuStrip2).set_Name("ContextMenuStrip2");
		ContextMenuStrip contextMenuStrip2 = ContextMenuStrip2;
		size = new Size(61, 4);
		((Control)contextMenuStrip2).set_Size(size);
		Button button5 = Button3;
		location = new Point(0, 0);
		((Control)button5).set_Location(location);
		((Control)Button3).set_Name("Button3");
		Button button6 = Button3;
		size = new Size(75, 23);
		((Control)button6).set_Size(size);
		((Control)Button3).set_TabIndex(12);
		((ButtonBase)Button3).set_Text("Button3");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		Button button7 = Button4;
		location = new Point(8, 8);
		((Control)button7).set_Location(location);
		((Control)Button4).set_Name("Button4");
		Button button8 = Button4;
		size = new Size(75, 23);
		((Control)button8).set_Size(size);
		((Control)Button4).set_TabIndex(13);
		((ButtonBase)Button4).set_Text("Button4");
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		DomainUpDown domainUpDown = DomainUpDown1;
		location = new Point(16, 16);
		((Control)domainUpDown).set_Location(location);
		((Control)DomainUpDown1).set_Name("DomainUpDown1");
		DomainUpDown domainUpDown2 = DomainUpDown1;
		size = new Size(120, 20);
		((Control)domainUpDown2).set_Size(size);
		((Control)DomainUpDown1).set_TabIndex(14);
		((UpDownBase)DomainUpDown1).set_Text("DomainUpDown1");
		((Control)GroupBox1).get_Controls().Add((Control)(object)GroupBox2);
		GroupBox groupBox = GroupBox1;
		location = new Point(24, 24);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox2 = GroupBox1;
		size = new Size(200, 100);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox1).set_TabIndex(15);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("GroupBox1");
		((Control)GroupBox2).get_Controls().Add((Control)(object)GroupBox3);
		GroupBox groupBox3 = GroupBox2;
		location = new Point(3, 16);
		((Control)groupBox3).set_Location(location);
		((Control)GroupBox2).set_Name("GroupBox2");
		GroupBox groupBox4 = GroupBox2;
		size = new Size(200, 100);
		((Control)groupBox4).set_Size(size);
		((Control)GroupBox2).set_TabIndex(0);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("GroupBox2");
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label1);
		GroupBox groupBox5 = GroupBox3;
		location = new Point(3, 16);
		((Control)groupBox5).set_Location(location);
		((Control)GroupBox3).set_Name("GroupBox3");
		GroupBox groupBox6 = GroupBox3;
		size = new Size(200, 100);
		((Control)groupBox6).set_Size(size);
		((Control)GroupBox3).set_TabIndex(0);
		GroupBox3.set_TabStop(false);
		GroupBox3.set_Text("GroupBox3");
		Label2.set_AutoSize(true);
		Label label = Label2;
		location = new Point(11, 24);
		((Control)label).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label2 = Label2;
		size = new Size(38, 13);
		((Control)label2).set_Size(size);
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("Label2");
		Label1.set_AutoSize(true);
		Label label3 = Label1;
		location = new Point(3, 16);
		((Control)label3).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label4 = Label1;
		size = new Size(38, 13);
		((Control)label4).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Label1");
		FileSystemWatcher1.EnableRaisingEvents = true;
		FileSystemWatcher1.SynchronizingObject = (ISynchronizeInvoke?)this;
		SplitContainer splitContainer = SplitContainer1;
		location = new Point(0, 0);
		((Control)splitContainer).set_Location(location);
		((Control)SplitContainer1).set_Name("SplitContainer1");
		((Control)SplitContainer1.get_Panel1()).get_Controls().Add((Control)(object)TabControl1);
		SplitContainer splitContainer2 = SplitContainer1;
		size = new Size(150, 100);
		((Control)splitContainer2).set_Size(size);
		((Control)SplitContainer1).set_TabIndex(16);
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
		((Control)TabControl1).set_TabIndex(0);
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
		ToolStrip toolStrip = ToolStrip1;
		location = new Point(0, 96);
		((Control)toolStrip).set_Location(location);
		((Control)ToolStrip1).set_Name("ToolStrip1");
		ToolStrip toolStrip2 = ToolStrip1;
		size = new Size(284, 25);
		((Control)toolStrip2).set_Size(size);
		((Control)ToolStrip1).set_TabIndex(17);
		((Control)ToolStrip1).set_Text("ToolStrip1");
		ToolStripContentPanel contentPanel = ToolStripContainer1.get_ContentPanel();
		size = new Size(150, 150);
		((Control)contentPanel).set_Size(size);
		ToolStripContainer toolStripContainer = ToolStripContainer1;
		location = new Point(8, 8);
		((Control)toolStripContainer).set_Location(location);
		((Control)ToolStripContainer1).set_Name("ToolStripContainer1");
		ToolStripContainer toolStripContainer2 = ToolStripContainer1;
		size = new Size(150, 175);
		((Control)toolStripContainer2).set_Size(size);
		((Control)ToolStripContainer1).set_TabIndex(18);
		((Control)ToolStripContainer1).set_Text("ToolStripContainer1");
		Button button9 = Button5;
		location = new Point(0, 0);
		((Control)button9).set_Location(location);
		((Control)Button5).set_Name("Button5");
		Button button10 = Button5;
		size = new Size(75, 23);
		((Control)button10).set_Size(size);
		((Control)Button5).set_TabIndex(19);
		((ButtonBase)Button5).set_Text("Button5");
		((ButtonBase)Button5).set_UseVisualStyleBackColor(true);
		Button button11 = Button6;
		location = new Point(8, 8);
		((Control)button11).set_Location(location);
		((Control)Button6).set_Name("Button6");
		Button button12 = Button6;
		size = new Size(75, 23);
		((Control)button12).set_Size(size);
		((Control)Button6).set_TabIndex(20);
		((ButtonBase)Button6).set_Text("Button6");
		((ButtonBase)Button6).set_UseVisualStyleBackColor(true);
		Button button13 = Button7;
		location = new Point(16, 16);
		((Control)button13).set_Location(location);
		((Control)Button7).set_Name("Button7");
		Button button14 = Button7;
		size = new Size(75, 23);
		((Control)button14).set_Size(size);
		((Control)Button7).set_TabIndex(21);
		((ButtonBase)Button7).set_Text("Button7");
		((ButtonBase)Button7).set_UseVisualStyleBackColor(true);
		Button button15 = Button8;
		location = new Point(24, 24);
		((Control)button15).set_Location(location);
		((Control)Button8).set_Name("Button8");
		Button button16 = Button8;
		size = new Size(75, 23);
		((Control)button16).set_Size(size);
		((Control)Button8).set_TabIndex(22);
		((ButtonBase)Button8).set_Text("Button8");
		((ButtonBase)Button8).set_UseVisualStyleBackColor(true);
		Button button17 = Button9;
		location = new Point(32, 32);
		((Control)button17).set_Location(location);
		((Control)Button9).set_Name("Button9");
		Button button18 = Button9;
		size = new Size(75, 23);
		((Control)button18).set_Size(size);
		((Control)Button9).set_TabIndex(23);
		((ButtonBase)Button9).set_Text("Button9");
		((ButtonBase)Button9).set_UseVisualStyleBackColor(true);
		Button button19 = Button10;
		location = new Point(40, 40);
		((Control)button19).set_Location(location);
		((Control)Button10).set_Name("Button10");
		Button button20 = Button10;
		size = new Size(75, 23);
		((Control)button20).set_Size(size);
		((Control)Button10).set_TabIndex(24);
		((ButtonBase)Button10).set_Text("Button10");
		((ButtonBase)Button10).set_UseVisualStyleBackColor(true);
		Button button21 = Button11;
		location = new Point(48, 48);
		((Control)button21).set_Location(location);
		((Control)Button11).set_Name("Button11");
		Button button22 = Button11;
		size = new Size(75, 23);
		((Control)button22).set_Size(size);
		((Control)Button11).set_TabIndex(25);
		((ButtonBase)Button11).set_Text("Button11");
		((ButtonBase)Button11).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox4).set_AutoSize(true);
		CheckBox checkBox7 = CheckBox4;
		location = new Point(56, 56);
		((Control)checkBox7).set_Location(location);
		((Control)CheckBox4).set_Name("CheckBox4");
		CheckBox checkBox8 = CheckBox4;
		size = new Size(79, 17);
		((Control)checkBox8).set_Size(size);
		((Control)CheckBox4).set_TabIndex(26);
		((ButtonBase)CheckBox4).set_Text("CheckBox4");
		((ButtonBase)CheckBox4).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox5).set_AutoSize(true);
		CheckBox checkBox9 = CheckBox5;
		location = new Point(64, 64);
		((Control)checkBox9).set_Location(location);
		((Control)CheckBox5).set_Name("CheckBox5");
		CheckBox checkBox10 = CheckBox5;
		size = new Size(79, 17);
		((Control)checkBox10).set_Size(size);
		((Control)CheckBox5).set_TabIndex(27);
		((ButtonBase)CheckBox5).set_Text("CheckBox5");
		((ButtonBase)CheckBox5).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox6).set_AutoSize(true);
		CheckBox checkBox11 = CheckBox6;
		location = new Point(72, 72);
		((Control)checkBox11).set_Location(location);
		((Control)CheckBox6).set_Name("CheckBox6");
		CheckBox checkBox12 = CheckBox6;
		size = new Size(79, 17);
		((Control)checkBox12).set_Size(size);
		((Control)CheckBox6).set_TabIndex(28);
		((ButtonBase)CheckBox6).set_Text("CheckBox6");
		((ButtonBase)CheckBox6).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox7).set_AutoSize(true);
		CheckBox checkBox13 = CheckBox7;
		location = new Point(80, 80);
		((Control)checkBox13).set_Location(location);
		((Control)CheckBox7).set_Name("CheckBox7");
		CheckBox checkBox14 = CheckBox7;
		size = new Size(79, 17);
		((Control)checkBox14).set_Size(size);
		((Control)CheckBox7).set_TabIndex(29);
		((ButtonBase)CheckBox7).set_Text("CheckBox7");
		((ButtonBase)CheckBox7).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox8).set_AutoSize(true);
		CheckBox checkBox15 = CheckBox8;
		location = new Point(88, 88);
		((Control)checkBox15).set_Location(location);
		((Control)CheckBox8).set_Name("CheckBox8");
		CheckBox checkBox16 = CheckBox8;
		size = new Size(79, 17);
		((Control)checkBox16).set_Size(size);
		((Control)CheckBox8).set_TabIndex(30);
		((ButtonBase)CheckBox8).set_Text("CheckBox8");
		((ButtonBase)CheckBox8).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox9).set_AutoSize(true);
		CheckBox checkBox17 = CheckBox9;
		location = new Point(96, 96);
		((Control)checkBox17).set_Location(location);
		((Control)CheckBox9).set_Name("CheckBox9");
		CheckBox checkBox18 = CheckBox9;
		size = new Size(79, 17);
		((Control)checkBox18).set_Size(size);
		((Control)CheckBox9).set_TabIndex(31);
		((ButtonBase)CheckBox9).set_Text("CheckBox9");
		((ButtonBase)CheckBox9).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox10).set_AutoSize(true);
		CheckBox checkBox19 = CheckBox10;
		location = new Point(104, 104);
		((Control)checkBox19).set_Location(location);
		((Control)CheckBox10).set_Name("CheckBox10");
		CheckBox checkBox20 = CheckBox10;
		size = new Size(85, 17);
		((Control)checkBox20).set_Size(size);
		((Control)CheckBox10).set_TabIndex(32);
		((ButtonBase)CheckBox10).set_Text("CheckBox10");
		((ButtonBase)CheckBox10).set_UseVisualStyleBackColor(true);
		EventLog1.set_SynchronizingObject((ISynchronizeInvoke)this);
		DomainUpDown domainUpDown3 = DomainUpDown2;
		location = new Point(0, 0);
		((Control)domainUpDown3).set_Location(location);
		((Control)DomainUpDown2).set_Name("DomainUpDown2");
		DomainUpDown domainUpDown4 = DomainUpDown2;
		size = new Size(120, 20);
		((Control)domainUpDown4).set_Size(size);
		((Control)DomainUpDown2).set_TabIndex(33);
		((UpDownBase)DomainUpDown2).set_Text("DomainUpDown2");
		ErrorProvider1.set_ContainerControl((ContainerControl)(object)this);
		DirectorySearcher1.set_ClientTimeout(TimeSpan.Parse("-00:00:01"));
		DirectorySearcher1.set_ServerPageTimeLimit(TimeSpan.Parse("-00:00:01"));
		DirectorySearcher1.set_ServerTimeLimit(TimeSpan.Parse("-00:00:01"));
		PrintDialog1.set_UseEXDialog(true);
		PrintDialog2.set_UseEXDialog(true);
		PrintPreviewControl printPreviewControl = PrintPreviewControl1;
		location = new Point(0, 0);
		((Control)printPreviewControl).set_Location(location);
		((Control)PrintPreviewControl1).set_Name("PrintPreviewControl1");
		PrintPreviewControl printPreviewControl2 = PrintPreviewControl1;
		size = new Size(100, 100);
		((Control)printPreviewControl2).set_Size(size);
		((Control)PrintPreviewControl1).set_TabIndex(34);
		PrintPreviewControl printPreviewControl3 = PrintPreviewControl2;
		location = new Point(8, 8);
		((Control)printPreviewControl3).set_Location(location);
		((Control)PrintPreviewControl2).set_Name("PrintPreviewControl2");
		PrintPreviewControl printPreviewControl4 = PrintPreviewControl2;
		size = new Size(100, 100);
		((Control)printPreviewControl4).set_Size(size);
		((Control)PrintPreviewControl2).set_TabIndex(35);
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
		ProgressBar progressBar = ProgressBar1;
		location = new Point(0, 0);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar2 = ProgressBar1;
		size = new Size(100, 23);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(36);
		PropertyGrid propertyGrid = PropertyGrid1;
		location = new Point(8, 8);
		((Control)propertyGrid).set_Location(location);
		((Control)PropertyGrid1).set_Name("PropertyGrid1");
		PropertyGrid propertyGrid2 = PropertyGrid1;
		size = new Size(130, 130);
		((Control)propertyGrid2).set_Size(size);
		((Control)PropertyGrid1).set_TabIndex(37);
		((ButtonBase)RadioButton1).set_AutoSize(true);
		RadioButton radioButton = RadioButton1;
		location = new Point(16, 16);
		((Control)radioButton).set_Location(location);
		((Control)RadioButton1).set_Name("RadioButton1");
		RadioButton radioButton2 = RadioButton1;
		size = new Size(90, 17);
		((Control)radioButton2).set_Size(size);
		((Control)RadioButton1).set_TabIndex(38);
		RadioButton1.set_TabStop(true);
		((ButtonBase)RadioButton1).set_Text("RadioButton1");
		((ButtonBase)RadioButton1).set_UseVisualStyleBackColor(true);
		RichTextBox richTextBox = RichTextBox1;
		location = new Point(24, 24);
		((Control)richTextBox).set_Location(location);
		((Control)RichTextBox1).set_Name("RichTextBox1");
		RichTextBox richTextBox2 = RichTextBox1;
		size = new Size(100, 96);
		((Control)richTextBox2).set_Size(size);
		((Control)RichTextBox1).set_TabIndex(39);
		RichTextBox1.set_Text("");
		MenuStrip menuStrip = MenuStrip1;
		location = new Point(0, 72);
		((Control)menuStrip).set_Location(location);
		((Control)MenuStrip1).set_Name("MenuStrip1");
		MenuStrip menuStrip2 = MenuStrip1;
		size = new Size(284, 24);
		((Control)menuStrip2).set_Size(size);
		((Control)MenuStrip1).set_TabIndex(40);
		((Control)MenuStrip1).set_Text("MenuStrip1");
		MenuStrip menuStrip3 = MenuStrip2;
		location = new Point(0, 48);
		((Control)menuStrip3).set_Location(location);
		((Control)MenuStrip2).set_Name("MenuStrip2");
		MenuStrip menuStrip4 = MenuStrip2;
		size = new Size(284, 24);
		((Control)menuStrip4).set_Size(size);
		((Control)MenuStrip2).set_TabIndex(41);
		((Control)MenuStrip2).set_Text("MenuStrip2");
		MenuStrip menuStrip5 = MenuStrip3;
		location = new Point(0, 24);
		((Control)menuStrip5).set_Location(location);
		((Control)MenuStrip3).set_Name("MenuStrip3");
		MenuStrip menuStrip6 = MenuStrip3;
		size = new Size(284, 24);
		((Control)menuStrip6).set_Size(size);
		((Control)MenuStrip3).set_TabIndex(42);
		((Control)MenuStrip3).set_Text("MenuStrip3");
		MenuStrip menuStrip7 = MenuStrip4;
		location = new Point(0, 0);
		((Control)menuStrip7).set_Location(location);
		((Control)MenuStrip4).set_Name("MenuStrip4");
		MenuStrip menuStrip8 = MenuStrip4;
		size = new Size(284, 24);
		((Control)menuStrip8).set_Size(size);
		((Control)MenuStrip4).set_TabIndex(43);
		((Control)MenuStrip4).set_Text("MenuStrip4");
		ListView listView = ListView1;
		location = new Point(8, 8);
		((Control)listView).set_Location(location);
		((Control)ListView1).set_Name("ListView1");
		ListView listView2 = ListView1;
		size = new Size(121, 97);
		((Control)listView2).set_Size(size);
		((Control)ListView1).set_TabIndex(44);
		ListView1.set_UseCompatibleStateImageBehavior(false);
		MaskedTextBox maskedTextBox = MaskedTextBox1;
		location = new Point(16, 16);
		((Control)maskedTextBox).set_Location(location);
		((Control)MaskedTextBox1).set_Name("MaskedTextBox1");
		MaskedTextBox maskedTextBox2 = MaskedTextBox1;
		size = new Size(100, 20);
		((Control)maskedTextBox2).set_Size(size);
		((Control)MaskedTextBox1).set_TabIndex(45);
		PictureBox pictureBox = PictureBox1;
		location = new Point(24, 24);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(100, 50);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_TabIndex(46);
		PictureBox1.set_TabStop(false);
		PictureBox pictureBox3 = PictureBox2;
		location = new Point(32, 32);
		((Control)pictureBox3).set_Location(location);
		((Control)PictureBox2).set_Name("PictureBox2");
		PictureBox pictureBox4 = PictureBox2;
		size = new Size(100, 50);
		((Control)pictureBox4).set_Size(size);
		PictureBox2.set_TabIndex(47);
		PictureBox2.set_TabStop(false);
		PictureBox pictureBox5 = PictureBox3;
		location = new Point(40, 40);
		((Control)pictureBox5).set_Location(location);
		((Control)PictureBox3).set_Name("PictureBox3");
		PictureBox pictureBox6 = PictureBox3;
		size = new Size(100, 50);
		((Control)pictureBox6).set_Size(size);
		PictureBox3.set_TabIndex(48);
		PictureBox3.set_TabStop(false);
		PictureBox pictureBox7 = PictureBox4;
		location = new Point(48, 48);
		((Control)pictureBox7).set_Location(location);
		((Control)PictureBox4).set_Name("PictureBox4");
		PictureBox pictureBox8 = PictureBox4;
		size = new Size(100, 50);
		((Control)pictureBox8).set_Size(size);
		PictureBox4.set_TabIndex(49);
		PictureBox4.set_TabStop(false);
		PrintDialog3.set_UseEXDialog(true);
		PrintDialog4.set_UseEXDialog(true);
		((Control)Panel1).get_Controls().Add((Control)(object)Panel2);
		Panel panel = Panel1;
		location = new Point(0, 0);
		((Control)panel).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel2 = Panel1;
		size = new Size(200, 100);
		((Control)panel2).set_Size(size);
		((Control)Panel1).set_TabIndex(50);
		Panel panel3 = Panel2;
		location = new Point(0, 0);
		((Control)panel3).set_Location(location);
		((Control)Panel2).set_Name("Panel2");
		Panel panel4 = Panel2;
		size = new Size(200, 100);
		((Control)panel4).set_Size(size);
		((Control)Panel2).set_TabIndex(0);
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
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(284, 262);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox4);
		((Control)this).get_Controls().Add((Control)(object)PictureBox3);
		((Control)this).get_Controls().Add((Control)(object)PictureBox2);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)MaskedTextBox1);
		((Control)this).get_Controls().Add((Control)(object)ListView1);
		((Control)this).get_Controls().Add((Control)(object)RichTextBox1);
		((Control)this).get_Controls().Add((Control)(object)RadioButton1);
		((Control)this).get_Controls().Add((Control)(object)PropertyGrid1);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)PrintPreviewControl2);
		((Control)this).get_Controls().Add((Control)(object)PrintPreviewControl1);
		((Control)this).get_Controls().Add((Control)(object)DomainUpDown2);
		((Control)this).get_Controls().Add((Control)(object)CheckBox10);
		((Control)this).get_Controls().Add((Control)(object)CheckBox9);
		((Control)this).get_Controls().Add((Control)(object)CheckBox8);
		((Control)this).get_Controls().Add((Control)(object)CheckBox7);
		((Control)this).get_Controls().Add((Control)(object)CheckBox6);
		((Control)this).get_Controls().Add((Control)(object)CheckBox5);
		((Control)this).get_Controls().Add((Control)(object)CheckBox4);
		((Control)this).get_Controls().Add((Control)(object)Button11);
		((Control)this).get_Controls().Add((Control)(object)Button10);
		((Control)this).get_Controls().Add((Control)(object)Button9);
		((Control)this).get_Controls().Add((Control)(object)Button8);
		((Control)this).get_Controls().Add((Control)(object)Button7);
		((Control)this).get_Controls().Add((Control)(object)Button6);
		((Control)this).get_Controls().Add((Control)(object)Button5);
		((Control)this).get_Controls().Add((Control)(object)ToolStripContainer1);
		((Control)this).get_Controls().Add((Control)(object)ToolStrip1);
		((Control)this).get_Controls().Add((Control)(object)MenuStrip1);
		((Control)this).get_Controls().Add((Control)(object)MenuStrip2);
		((Control)this).get_Controls().Add((Control)(object)MenuStrip3);
		((Control)this).get_Controls().Add((Control)(object)MenuStrip4);
		((Control)this).get_Controls().Add((Control)(object)SplitContainer1);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)DomainUpDown1);
		((Control)this).get_Controls().Add((Control)(object)Button4);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)ComboBox3);
		((Control)this).get_Controls().Add((Control)(object)ComboBox2);
		((Control)this).get_Controls().Add((Control)(object)ComboBox1);
		((Control)this).get_Controls().Add((Control)(object)CheckedListBox2);
		((Control)this).get_Controls().Add((Control)(object)CheckedListBox1);
		((Control)this).get_Controls().Add((Control)(object)CheckBox3);
		((Control)this).get_Controls().Add((Control)(object)CheckBox2);
		((Control)this).get_Controls().Add((Control)(object)CheckBox1);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Form)this).set_MainMenuStrip(MenuStrip1);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox2).ResumeLayout(false);
		((Control)GroupBox3).ResumeLayout(false);
		((Control)GroupBox3).PerformLayout();
		((ISupportInitialize)FileSystemWatcher1).EndInit();
		((Control)SplitContainer1.get_Panel1()).ResumeLayout(false);
		((Control)SplitContainer1).ResumeLayout(false);
		((Control)TabControl1).ResumeLayout(false);
		((Control)TabPage1).ResumeLayout(false);
		((Control)ToolStripContainer1).ResumeLayout(false);
		((Control)ToolStripContainer1).PerformLayout();
		((ISupportInitialize)EventLog1).EndInit();
		((ISupportInitialize)ErrorProvider1).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox4).EndInit();
		((Control)Panel1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
