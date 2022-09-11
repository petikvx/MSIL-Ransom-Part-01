using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.VisualBasic.PowerPacks;
using ns0;

namespace ns1;

[DesignerGenerated]
public class Tools0 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

	[AccessedThroughProperty("TabPage1")]
	private TabPage _TabPage1;

	[AccessedThroughProperty("TabPage2")]
	private TabPage _TabPage2;

	[AccessedThroughProperty("TabPage3")]
	private TabPage _TabPage3;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("PictureBox8")]
	private PictureBox _PictureBox8;

	[AccessedThroughProperty("TabControl2")]
	private TabControl _TabControl2;

	[AccessedThroughProperty("TabPage4")]
	private TabPage _TabPage4;

	[AccessedThroughProperty("TabPage5")]
	private TabPage _TabPage5;

	[AccessedThroughProperty("TabPage6")]
	private TabPage _TabPage6;

	[AccessedThroughProperty("TabControl3")]
	private TabControl _TabControl3;

	[AccessedThroughProperty("TabPage7")]
	private TabPage _TabPage7;

	[AccessedThroughProperty("TabPage8")]
	private TabPage _TabPage8;

	[AccessedThroughProperty("TabPage9")]
	private TabPage _TabPage9;

	[AccessedThroughProperty("detected")]
	private Label _detected;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Luz")]
	private Label _Luz;

	[AccessedThroughProperty("TrackBar1")]
	private TrackBar _TrackBar1;

	[AccessedThroughProperty("MR")]
	private Label _MR;

	[AccessedThroughProperty("total")]
	private Label _total;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Lento")]
	private Label _Lento;

	[AccessedThroughProperty("Ace")]
	private Label _Ace;

	[AccessedThroughProperty("Nor")]
	private Label _Nor;

	[AccessedThroughProperty("GroupBox2")]
	private GroupBox _GroupBox2;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("FolderBrowserDialog1")]
	private FolderBrowserDialog _FolderBrowserDialog1;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("crotime")]
	private Timer _crotime;

	[AccessedThroughProperty("GroupBox3")]
	private GroupBox _GroupBox3;

	[AccessedThroughProperty("ButtonLimparProtecaoReal")]
	private Button _ButtonLimparProtecaoReal;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("RichTextBox1")]
	private RichTextBox _RichTextBox1;

	[AccessedThroughProperty("ListaProtecaoReal")]
	private ListBox _ListaProtecaoReal;

	[AccessedThroughProperty("ListBox2")]
	private ListBox _ListBox2;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	[AccessedThroughProperty("ListBox3")]
	private ListBox _ListBox3;

	[AccessedThroughProperty("GroupBox4")]
	private GroupBox _GroupBox4;

	[AccessedThroughProperty("Button6")]
	private Button _Button6;

	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("TextBoxAgendaAnos")]
	private TextBox _TextBoxAgendaAnos;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("TextBoxAgendaMes")]
	private TextBox _TextBoxAgendaMes;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("TextBoxAgendaDias")]
	private TextBox _TextBoxAgendaDias;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("TextBoxAgendaHoras")]
	private TextBox _TextBoxAgendaHoras;

	[AccessedThroughProperty("TextBoxAgendaMinutos")]
	private TextBox _TextBoxAgendaMinutos;

	[AccessedThroughProperty("TextBoxAgendaSegundos")]
	private TextBox _TextBoxAgendaSegundos;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

	[AccessedThroughProperty("NotPause")]
	private Timer _NotPause;

	[AccessedThroughProperty("Button8")]
	private Button _Button8;

	[AccessedThroughProperty("Button7")]
	private Button _Button7;

	[AccessedThroughProperty("files")]
	private Label _files;

	[AccessedThroughProperty("ProgressBarScanner")]
	private ProgressBar _ProgressBarScanner;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("ShapeContainer1")]
	private ShapeContainer _ShapeContainer1;

	[AccessedThroughProperty("RectangleShape2")]
	private RectangleShape _RectangleShape2;

	[AccessedThroughProperty("RectangleShape1")]
	private RectangleShape _RectangleShape1;

	[AccessedThroughProperty("LabelTextEP")]
	private Label _LabelTextEP;

	[AccessedThroughProperty("LabelTextEC")]
	private Label _LabelTextEC;

	[AccessedThroughProperty("TabPage10")]
	private TabPage _TabPage10;

	[AccessedThroughProperty("Timer1s")]
	private Timer _Timer1s;

	[AccessedThroughProperty("Timer2s")]
	private Timer _Timer2s;

	[AccessedThroughProperty("Label4fc")]
	private Label _Label4fc;

	[AccessedThroughProperty("GroupBox5")]
	private GroupBox _GroupBox5;

	[AccessedThroughProperty("Limped")]
	private ListBox _Limped;

	[AccessedThroughProperty("GroupBox6")]
	private GroupBox _GroupBox6;

	[AccessedThroughProperty("Tar")]
	private Label _Tar;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("totale")]
	private Label _totale;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("PE")]
	private Button _PE;

	[AccessedThroughProperty("CE")]
	private Button _CE;

	[AccessedThroughProperty("ProgressLimpeza")]
	private ProgressBar _ProgressLimpeza;

	[AccessedThroughProperty("FolderBrowserDialog2")]
	private FolderBrowserDialog _FolderBrowserDialog2;

	[AccessedThroughProperty("PanelGerCopy")]
	private Panel _PanelGerCopy;

	[AccessedThroughProperty("cod")]
	private Label _cod;

	[AccessedThroughProperty("NuGer")]
	private NumericUpDown _NuGer;

	[AccessedThroughProperty("G3")]
	private CheckBox _G3;

	[AccessedThroughProperty("G1")]
	private CheckBox _G1;

	[AccessedThroughProperty("G2")]
	private CheckBox _G2;

	[AccessedThroughProperty("PanelGen")]
	private Panel _PanelGen;

	[AccessedThroughProperty("LabelGenStatus")]
	private Label _LabelGenStatus;

	[AccessedThroughProperty("DownTotal")]
	private Label _DownTotal;

	[AccessedThroughProperty("DownBaixado")]
	private Label _DownBaixado;

	[AccessedThroughProperty("LabelId")]
	private Label _LabelId;

	[AccessedThroughProperty("LabelGenTextInfo")]
	private Label _LabelGenTextInfo;

	[AccessedThroughProperty("ProgressCopyGen")]
	private ProgressBar _ProgressCopyGen;

	[AccessedThroughProperty("Label7fc")]
	private Label _Label7fc;

	[AccessedThroughProperty("Label20")]
	private Label _Label20;

	[AccessedThroughProperty("OpenGen1")]
	private Button _OpenGen1;

	[AccessedThroughProperty("Label21")]
	private Label _Label21;

	[AccessedThroughProperty("Label22")]
	private Label _Label22;

	[AccessedThroughProperty("Gentext2")]
	private TextBox _Gentext2;

	[AccessedThroughProperty("GenText1")]
	private TextBox _GenText1;

	[AccessedThroughProperty("DownGen1")]
	private Button _DownGen1;

	[AccessedThroughProperty("MenuStrip1")]
	private MenuStrip _MenuStrip1;

	[AccessedThroughProperty("AtualizarToolStripMenuItem")]
	private ToolStripMenuItem _AtualizarToolStripMenuItem;

	[AccessedThroughProperty("FonteToolStripMenuItem")]
	private ToolStripMenuItem _FonteToolStripMenuItem;

	[AccessedThroughProperty("FecharAplicativoToolStripMenuItem")]
	private ToolStripMenuItem _FecharAplicativoToolStripMenuItem;

	[AccessedThroughProperty("LimparTudoToolStripMenuItem")]
	private ToolStripMenuItem _LimparTudoToolStripMenuItem;

	[AccessedThroughProperty("StatusGeretaref")]
	private StatusStrip _StatusGeretaref;

	[AccessedThroughProperty("ToolStripStatusLabel1")]
	private ToolStripStatusLabel _ToolStripStatusLabel1;

	[AccessedThroughProperty("ToolStripStatusLabelGerenciadorTarefa")]
	private ToolStripStatusLabel _ToolStripStatusLabelGerenciadorTarefa;

	[AccessedThroughProperty("Fontgdtarefa")]
	private FontDialog _Fontgdtarefa;

	[AccessedThroughProperty("TimeFileCopy")]
	private Timer _TimeFileCopy;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("TextBoxScanner")]
	private TextBox _TextBoxScanner;

	[AccessedThroughProperty("ListViewGerenciadorTarefa")]
	private ListView _ListViewGerenciadorTarefa;

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

	[AccessedThroughProperty("TextBoxVarreduradeComportamento")]
	private TextBox _TextBoxVarreduradeComportamento;

	[AccessedThroughProperty("httpclient")]
	private WebClient _httpclient;

	private int hh;

	private int mm;

	private int ss;

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

	internal virtual TabControl TabControl1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabControl1 = value;
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

	internal virtual PictureBox PictureBox8
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox8 = value;
		}
	}

	internal virtual TabControl TabControl2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabControl2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabControl2 = value;
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

	internal virtual TabControl TabControl3
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabControl3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabControl3 = value;
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

	internal virtual TabPage TabPage8
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TabPage8_Click;
			if (_TabPage8 != null)
			{
				((Control)_TabPage8).remove_Click(eventHandler);
			}
			_TabPage8 = value;
			if (_TabPage8 != null)
			{
				((Control)_TabPage8).add_Click(eventHandler);
			}
		}
	}

	internal virtual TabPage TabPage9
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage9 = value;
		}
	}

	internal virtual Label detected
	{
		[DebuggerNonUserCode]
		get
		{
			return _detected;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_detected = value;
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

	internal virtual Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
		}
	}

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
		}
	}

	internal virtual Label Luz
	{
		[DebuggerNonUserCode]
		get
		{
			return _Luz;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Luz = value;
		}
	}

	internal virtual TrackBar TrackBar1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TrackBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TrackBar1_Scroll;
			if (_TrackBar1 != null)
			{
				_TrackBar1.remove_Scroll(eventHandler);
			}
			_TrackBar1 = value;
			if (_TrackBar1 != null)
			{
				_TrackBar1.add_Scroll(eventHandler);
			}
		}
	}

	internal virtual Label MR
	{
		[DebuggerNonUserCode]
		get
		{
			return _MR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MR = value;
		}
	}

	internal virtual Label total
	{
		[DebuggerNonUserCode]
		get
		{
			return _total;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_total = value;
		}
	}

	internal virtual Label Label8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label8 = value;
		}
	}

	internal virtual Label Lento
	{
		[DebuggerNonUserCode]
		get
		{
			return _Lento;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Lento = value;
		}
	}

	internal virtual Label Ace
	{
		[DebuggerNonUserCode]
		get
		{
			return _Ace;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Ace = value;
		}
	}

	internal virtual Label Nor
	{
		[DebuggerNonUserCode]
		get
		{
			return _Nor;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Nor = value;
		}
	}

	internal virtual GroupBox GroupBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox2 = value;
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
			EventHandler eventHandler = Button2_Click;
			if (_Button2 != null)
			{
				((Control)_Button2).remove_Click(eventHandler);
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				((Control)_Button2).add_Click(eventHandler);
			}
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

	internal virtual Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick(eventHandler);
			}
		}
	}

	internal virtual FolderBrowserDialog FolderBrowserDialog1
	{
		[DebuggerNonUserCode]
		get
		{
			return _FolderBrowserDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FolderBrowserDialog1 = value;
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
			EventHandler eventHandler = Button3_Click;
			if (_Button3 != null)
			{
				((Control)_Button3).remove_Click(eventHandler);
			}
			_Button3 = value;
			if (_Button3 != null)
			{
				((Control)_Button3).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7 = value;
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

	internal virtual Timer crotime
	{
		[DebuggerNonUserCode]
		get
		{
			return _crotime;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer2_Tick;
			if (_crotime != null)
			{
				_crotime.remove_Tick(eventHandler);
			}
			_crotime = value;
			if (_crotime != null)
			{
				_crotime.add_Tick(eventHandler);
			}
		}
	}

	internal virtual GroupBox GroupBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox3 = value;
		}
	}

	internal virtual Button ButtonLimparProtecaoReal
	{
		[DebuggerNonUserCode]
		get
		{
			return _ButtonLimparProtecaoReal;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button4_Click;
			if (_ButtonLimparProtecaoReal != null)
			{
				((Control)_ButtonLimparProtecaoReal).remove_Click(eventHandler);
			}
			_ButtonLimparProtecaoReal = value;
			if (_ButtonLimparProtecaoReal != null)
			{
				((Control)_ButtonLimparProtecaoReal).add_Click(eventHandler);
			}
		}
	}

	internal virtual GroupBox GroupBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal virtual RichTextBox RichTextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RichTextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RichTextBox1 = value;
		}
	}

	internal virtual ListBox ListaProtecaoReal
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListaProtecaoReal;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListaProtecaoReal = value;
		}
	}

	internal virtual ListBox ListBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListBox2 = value;
		}
	}

	internal virtual Timer Timer2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer2_Tick_1;
			if (_Timer2 != null)
			{
				_Timer2.remove_Tick(eventHandler);
			}
			_Timer2 = value;
			if (_Timer2 != null)
			{
				_Timer2.add_Tick(eventHandler);
			}
		}
	}

	internal virtual ListBox ListBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListBox3 = value;
		}
	}

	internal virtual GroupBox GroupBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = GroupBox4_Enter;
			if (_GroupBox4 != null)
			{
				((Control)_GroupBox4).remove_Enter(eventHandler);
			}
			_GroupBox4 = value;
			if (_GroupBox4 != null)
			{
				((Control)_GroupBox4).add_Enter(eventHandler);
			}
		}
	}

	internal virtual Button Button6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button6 = value;
		}
	}

	internal virtual Button Button5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button5_Click;
			if (_Button5 != null)
			{
				((Control)_Button5).remove_Click(eventHandler);
			}
			_Button5 = value;
			if (_Button5 != null)
			{
				((Control)_Button5).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label14 = value;
		}
	}

	internal virtual TextBox TextBoxAgendaAnos
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBoxAgendaAnos;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TextBoxAgendaAnos_TextChanged;
			if (_TextBoxAgendaAnos != null)
			{
				((Control)_TextBoxAgendaAnos).remove_TextChanged(eventHandler);
			}
			_TextBoxAgendaAnos = value;
			if (_TextBoxAgendaAnos != null)
			{
				((Control)_TextBoxAgendaAnos).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual Label Label13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label13 = value;
		}
	}

	internal virtual TextBox TextBoxAgendaMes
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBoxAgendaMes;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TextBoxAgendaMes_TextChanged;
			if (_TextBoxAgendaMes != null)
			{
				((Control)_TextBoxAgendaMes).remove_TextChanged(eventHandler);
			}
			_TextBoxAgendaMes = value;
			if (_TextBoxAgendaMes != null)
			{
				((Control)_TextBoxAgendaMes).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual Label Label12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label12 = value;
		}
	}

	internal virtual TextBox TextBoxAgendaDias
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBoxAgendaDias;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TextBoxAgendaDias_TextChanged;
			if (_TextBoxAgendaDias != null)
			{
				((Control)_TextBoxAgendaDias).remove_TextChanged(eventHandler);
			}
			_TextBoxAgendaDias = value;
			if (_TextBoxAgendaDias != null)
			{
				((Control)_TextBoxAgendaDias).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual Label Label11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label11 = value;
		}
	}

	internal virtual Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label10 = value;
		}
	}

	internal virtual Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label9 = value;
		}
	}

	internal virtual TextBox TextBoxAgendaHoras
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBoxAgendaHoras;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TextBoxAgendaHoras_TextChanged;
			if (_TextBoxAgendaHoras != null)
			{
				((Control)_TextBoxAgendaHoras).remove_TextChanged(eventHandler);
			}
			_TextBoxAgendaHoras = value;
			if (_TextBoxAgendaHoras != null)
			{
				((Control)_TextBoxAgendaHoras).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual TextBox TextBoxAgendaMinutos
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBoxAgendaMinutos;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TextBoxAgendaMinutos_TextChanged;
			if (_TextBoxAgendaMinutos != null)
			{
				((Control)_TextBoxAgendaMinutos).remove_TextChanged(eventHandler);
			}
			_TextBoxAgendaMinutos = value;
			if (_TextBoxAgendaMinutos != null)
			{
				((Control)_TextBoxAgendaMinutos).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual TextBox TextBoxAgendaSegundos
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBoxAgendaSegundos;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TextBoxAgendaSegundos_TextChanged;
			if (_TextBoxAgendaSegundos != null)
			{
				((Control)_TextBoxAgendaSegundos).remove_TextChanged(eventHandler);
			}
			_TextBoxAgendaSegundos = value;
			if (_TextBoxAgendaSegundos != null)
			{
				((Control)_TextBoxAgendaSegundos).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual Label Label15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label15 = value;
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

	internal virtual Timer NotPause
	{
		[DebuggerNonUserCode]
		get
		{
			return _NotPause;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = NotPause_Tick;
			if (_NotPause != null)
			{
				_NotPause.remove_Tick(eventHandler);
			}
			_NotPause = value;
			if (_NotPause != null)
			{
				_NotPause.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Button Button8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button8_Click;
			if (_Button8 != null)
			{
				((Control)_Button8).remove_Click(eventHandler);
			}
			_Button8 = value;
			if (_Button8 != null)
			{
				((Control)_Button8).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button7_Click;
			if (_Button7 != null)
			{
				((Control)_Button7).remove_Click(eventHandler);
			}
			_Button7 = value;
			if (_Button7 != null)
			{
				((Control)_Button7).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label files
	{
		[DebuggerNonUserCode]
		get
		{
			return _files;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_files = value;
		}
	}

	internal virtual ProgressBar ProgressBarScanner
	{
		[DebuggerNonUserCode]
		get
		{
			return _ProgressBarScanner;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ProgressBarScanner = value;
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

	internal virtual ShapeContainer ShapeContainer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ShapeContainer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ShapeContainer1 = value;
		}
	}

	internal virtual RectangleShape RectangleShape2
	{
		[DebuggerNonUserCode]
		get
		{
			return _RectangleShape2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RectangleShape2 = value;
		}
	}

	internal virtual RectangleShape RectangleShape1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RectangleShape1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RectangleShape1 = value;
		}
	}

	internal virtual Label LabelTextEP
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelTextEP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelTextEP = value;
		}
	}

	internal virtual Label LabelTextEC
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelTextEC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelTextEC = value;
		}
	}

	internal virtual TabPage TabPage10
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage10 = value;
		}
	}

	internal virtual Timer Timer1s
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer1s;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer1s_Tick;
			if (_Timer1s != null)
			{
				_Timer1s.remove_Tick(eventHandler);
			}
			_Timer1s = value;
			if (_Timer1s != null)
			{
				_Timer1s.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer2s
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer2s;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer2s_Tick;
			if (_Timer2s != null)
			{
				_Timer2s.remove_Tick(eventHandler);
			}
			_Timer2s = value;
			if (_Timer2s != null)
			{
				_Timer2s.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Label Label4fc
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4fc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4fc = value;
		}
	}

	internal virtual GroupBox GroupBox5
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox5 = value;
		}
	}

	internal virtual ListBox Limped
	{
		[DebuggerNonUserCode]
		get
		{
			return _Limped;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Limped = value;
		}
	}

	internal virtual GroupBox GroupBox6
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox6 = value;
		}
	}

	internal virtual Label Tar
	{
		[DebuggerNonUserCode]
		get
		{
			return _Tar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Tar = value;
		}
	}

	internal virtual Label Label16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label16 = value;
		}
	}

	internal virtual Label totale
	{
		[DebuggerNonUserCode]
		get
		{
			return _totale;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_totale = value;
		}
	}

	internal virtual Label Label17
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label17 = value;
		}
	}

	internal virtual Button PE
	{
		[DebuggerNonUserCode]
		get
		{
			return _PE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PE_Click;
			if (_PE != null)
			{
				((Control)_PE).remove_Click(eventHandler);
			}
			_PE = value;
			if (_PE != null)
			{
				((Control)_PE).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button CE
	{
		[DebuggerNonUserCode]
		get
		{
			return _CE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CE_Click;
			if (_CE != null)
			{
				((Control)_CE).remove_Click(eventHandler);
			}
			_CE = value;
			if (_CE != null)
			{
				((Control)_CE).add_Click(eventHandler);
			}
		}
	}

	internal virtual ProgressBar ProgressLimpeza
	{
		[DebuggerNonUserCode]
		get
		{
			return _ProgressLimpeza;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ProgressLimpeza = value;
		}
	}

	internal virtual FolderBrowserDialog FolderBrowserDialog2
	{
		[DebuggerNonUserCode]
		get
		{
			return _FolderBrowserDialog2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FolderBrowserDialog2 = value;
		}
	}

	internal virtual Panel PanelGerCopy
	{
		[DebuggerNonUserCode]
		get
		{
			return _PanelGerCopy;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PanelGerCopy = value;
		}
	}

	internal virtual Label cod
	{
		[DebuggerNonUserCode]
		get
		{
			return _cod;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cod = value;
		}
	}

	internal virtual NumericUpDown NuGer
	{
		[DebuggerNonUserCode]
		get
		{
			return _NuGer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_NuGer = value;
		}
	}

	internal virtual CheckBox G3
	{
		[DebuggerNonUserCode]
		get
		{
			return _G3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_G3 = value;
		}
	}

	internal virtual CheckBox G1
	{
		[DebuggerNonUserCode]
		get
		{
			return _G1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_G1 = value;
		}
	}

	internal virtual CheckBox G2
	{
		[DebuggerNonUserCode]
		get
		{
			return _G2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_G2 = value;
		}
	}

	internal virtual Panel PanelGen
	{
		[DebuggerNonUserCode]
		get
		{
			return _PanelGen;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PanelGen = value;
		}
	}

	internal virtual Label LabelGenStatus
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelGenStatus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelGenStatus = value;
		}
	}

	internal virtual Label DownTotal
	{
		[DebuggerNonUserCode]
		get
		{
			return _DownTotal;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DownTotal = value;
		}
	}

	internal virtual Label DownBaixado
	{
		[DebuggerNonUserCode]
		get
		{
			return _DownBaixado;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DownBaixado = value;
		}
	}

	internal virtual Label LabelId
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelId;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelId = value;
		}
	}

	internal virtual Label LabelGenTextInfo
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelGenTextInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelGenTextInfo = value;
		}
	}

	internal virtual ProgressBar ProgressCopyGen
	{
		[DebuggerNonUserCode]
		get
		{
			return _ProgressCopyGen;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ProgressCopyGen = value;
		}
	}

	internal virtual Label Label7fc
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7fc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7fc = value;
		}
	}

	internal virtual Label Label20
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label20 = value;
		}
	}

	internal virtual Button OpenGen1
	{
		[DebuggerNonUserCode]
		get
		{
			return _OpenGen1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = OpenGen1_Click;
			if (_OpenGen1 != null)
			{
				((Control)_OpenGen1).remove_Click(eventHandler);
			}
			_OpenGen1 = value;
			if (_OpenGen1 != null)
			{
				((Control)_OpenGen1).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label21
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label21 = value;
		}
	}

	internal virtual Label Label22
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label22 = value;
		}
	}

	internal virtual TextBox Gentext2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Gentext2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Gentext2_TextChanged;
			if (_Gentext2 != null)
			{
				((Control)_Gentext2).remove_TextChanged(eventHandler);
			}
			_Gentext2 = value;
			if (_Gentext2 != null)
			{
				((Control)_Gentext2).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual TextBox GenText1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GenText1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = GenText1_TextChanged;
			if (_GenText1 != null)
			{
				((Control)_GenText1).remove_TextChanged(eventHandler);
			}
			_GenText1 = value;
			if (_GenText1 != null)
			{
				((Control)_GenText1).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual Button DownGen1
	{
		[DebuggerNonUserCode]
		get
		{
			return _DownGen1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = DownGen1_Click;
			if (_DownGen1 != null)
			{
				((Control)_DownGen1).remove_Click(eventHandler);
			}
			_DownGen1 = value;
			if (_DownGen1 != null)
			{
				((Control)_DownGen1).add_Click(eventHandler);
			}
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

	internal virtual ToolStripMenuItem AtualizarToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _AtualizarToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = AtualizarToolStripMenuItem_Click;
			if (_AtualizarToolStripMenuItem != null)
			{
				((ToolStripItem)_AtualizarToolStripMenuItem).remove_Click(eventHandler);
			}
			_AtualizarToolStripMenuItem = value;
			if (_AtualizarToolStripMenuItem != null)
			{
				((ToolStripItem)_AtualizarToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem FonteToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _FonteToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = FonteToolStripMenuItem_Click;
			if (_FonteToolStripMenuItem != null)
			{
				((ToolStripItem)_FonteToolStripMenuItem).remove_Click(eventHandler);
			}
			_FonteToolStripMenuItem = value;
			if (_FonteToolStripMenuItem != null)
			{
				((ToolStripItem)_FonteToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem FecharAplicativoToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _FecharAplicativoToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = FecharAplicativoToolStripMenuItem_Click;
			if (_FecharAplicativoToolStripMenuItem != null)
			{
				((ToolStripItem)_FecharAplicativoToolStripMenuItem).remove_Click(eventHandler);
			}
			_FecharAplicativoToolStripMenuItem = value;
			if (_FecharAplicativoToolStripMenuItem != null)
			{
				((ToolStripItem)_FecharAplicativoToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem LimparTudoToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _LimparTudoToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = LimparTudoToolStripMenuItem_Click;
			if (_LimparTudoToolStripMenuItem != null)
			{
				((ToolStripItem)_LimparTudoToolStripMenuItem).remove_Click(eventHandler);
			}
			_LimparTudoToolStripMenuItem = value;
			if (_LimparTudoToolStripMenuItem != null)
			{
				((ToolStripItem)_LimparTudoToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual StatusStrip StatusGeretaref
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusGeretaref;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_StatusGeretaref = value;
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

	internal virtual ToolStripStatusLabel ToolStripStatusLabelGerenciadorTarefa
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabelGerenciadorTarefa;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabelGerenciadorTarefa = value;
		}
	}

	internal virtual FontDialog Fontgdtarefa
	{
		[DebuggerNonUserCode]
		get
		{
			return _Fontgdtarefa;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Fontgdtarefa = value;
		}
	}

	internal virtual Timer TimeFileCopy
	{
		[DebuggerNonUserCode]
		get
		{
			return _TimeFileCopy;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TimeFileCopy_Tick;
			if (_TimeFileCopy != null)
			{
				_TimeFileCopy.remove_Tick(eventHandler);
			}
			_TimeFileCopy = value;
			if (_TimeFileCopy != null)
			{
				_TimeFileCopy.add_Tick(eventHandler);
			}
		}
	}

	internal virtual ListBox ListBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListBox1 = value;
		}
	}

	internal virtual TextBox TextBoxScanner
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBoxScanner;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBoxScanner = value;
		}
	}

	internal virtual ListView ListViewGerenciadorTarefa
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListViewGerenciadorTarefa;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListViewGerenciadorTarefa = value;
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

	internal virtual TextBox TextBoxVarreduradeComportamento
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBoxVarreduradeComportamento;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBoxVarreduradeComportamento = value;
		}
	}

	private virtual WebClient httpclient
	{
		[DebuggerNonUserCode]
		get
		{
			return _httpclient;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			DownloadProgressChangedEventHandler value2 = httpclient_DownloadProgressChanged;
			AsyncCompletedEventHandler value3 = downloadconcluido;
			if (_httpclient != null)
			{
				_httpclient.DownloadProgressChanged -= value2;
				_httpclient.DownloadFileCompleted -= value3;
			}
			_httpclient = value;
			if (_httpclient != null)
			{
				_httpclient.DownloadProgressChanged += value2;
				_httpclient.DownloadFileCompleted += value3;
			}
		}
	}

	[DebuggerNonUserCode]
	public Tools0()
	{
		((Form)this).add_Load((EventHandler)Tools_Load);
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
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected O, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected O, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected O, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected O, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected O, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected O, but got Unknown
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected O, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected O, but got Unknown
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected O, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected O, but got Unknown
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected O, but got Unknown
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected O, but got Unknown
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected O, but got Unknown
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected O, but got Unknown
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected O, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected O, but got Unknown
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected O, but got Unknown
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected O, but got Unknown
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected O, but got Unknown
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected O, but got Unknown
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected O, but got Unknown
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected O, but got Unknown
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected O, but got Unknown
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected O, but got Unknown
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected O, but got Unknown
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected O, but got Unknown
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected O, but got Unknown
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected O, but got Unknown
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected O, but got Unknown
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Expected O, but got Unknown
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected O, but got Unknown
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Expected O, but got Unknown
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Expected O, but got Unknown
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected O, but got Unknown
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected O, but got Unknown
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Expected O, but got Unknown
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected O, but got Unknown
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected O, but got Unknown
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Expected O, but got Unknown
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Expected O, but got Unknown
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Expected O, but got Unknown
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected O, but got Unknown
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Expected O, but got Unknown
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Expected O, but got Unknown
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Expected O, but got Unknown
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Expected O, but got Unknown
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Expected O, but got Unknown
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected O, but got Unknown
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected O, but got Unknown
		//IL_055b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Expected O, but got Unknown
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Expected O, but got Unknown
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Expected O, but got Unknown
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Expected O, but got Unknown
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Expected O, but got Unknown
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected O, but got Unknown
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Expected O, but got Unknown
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Expected O, but got Unknown
		//IL_0b42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4c: Expected O, but got Unknown
		//IL_0bcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd7: Expected O, but got Unknown
		//IL_0ca6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb0: Expected O, but got Unknown
		//IL_0ef8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d0: Expected O, but got Unknown
		//IL_1333: Unknown result type (might be due to invalid IL or missing references)
		//IL_133d: Expected O, but got Unknown
		//IL_13b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_13bc: Expected O, but got Unknown
		//IL_1433: Unknown result type (might be due to invalid IL or missing references)
		//IL_143d: Expected O, but got Unknown
		//IL_14bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c5: Expected O, but got Unknown
		//IL_1543: Unknown result type (might be due to invalid IL or missing references)
		//IL_154d: Expected O, but got Unknown
		//IL_15cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d5: Expected O, but got Unknown
		//IL_1663: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad1: Expected O, but got Unknown
		//IL_1c09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c13: Expected O, but got Unknown
		//IL_1d86: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d90: Expected O, but got Unknown
		//IL_1e24: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e2e: Expected O, but got Unknown
		//IL_1ec2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ecc: Expected O, but got Unknown
		//IL_1f8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_20f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_24c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_27e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_27ed: Expected O, but got Unknown
		//IL_2994: Unknown result type (might be due to invalid IL or missing references)
		//IL_299e: Expected O, but got Unknown
		//IL_2a2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a35: Expected O, but got Unknown
		//IL_2ab9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ac3: Expected O, but got Unknown
		//IL_2b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b52: Expected O, but got Unknown
		//IL_2bd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bdd: Expected O, but got Unknown
		//IL_2d39: Unknown result type (might be due to invalid IL or missing references)
		//IL_2da5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2daf: Expected O, but got Unknown
		//IL_2ed7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ee1: Expected O, but got Unknown
		//IL_2fed: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ff7: Expected O, but got Unknown
		//IL_309a: Unknown result type (might be due to invalid IL or missing references)
		//IL_30a4: Expected O, but got Unknown
		//IL_3131: Unknown result type (might be due to invalid IL or missing references)
		//IL_313b: Expected O, but got Unknown
		//IL_31c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_31d2: Expected O, but got Unknown
		//IL_325f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3269: Expected O, but got Unknown
		//IL_3361: Unknown result type (might be due to invalid IL or missing references)
		//IL_336b: Expected O, but got Unknown
		//IL_34a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_3560: Unknown result type (might be due to invalid IL or missing references)
		//IL_356a: Expected O, but got Unknown
		//IL_379d: Unknown result type (might be due to invalid IL or missing references)
		//IL_37a7: Expected O, but got Unknown
		//IL_3856: Unknown result type (might be due to invalid IL or missing references)
		//IL_3860: Expected O, but got Unknown
		//IL_38a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_38b3: Expected O, but got Unknown
		//IL_38fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_3906: Expected O, but got Unknown
		//IL_3952: Unknown result type (might be due to invalid IL or missing references)
		//IL_395c: Expected O, but got Unknown
		//IL_39de: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4412: Unknown result type (might be due to invalid IL or missing references)
		//IL_4630: Unknown result type (might be due to invalid IL or missing references)
		//IL_47dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_47e7: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Tools0));
		Panel1 = new Panel();
		PanelGerCopy = new Panel();
		cod = new Label();
		NuGer = new NumericUpDown();
		G3 = new CheckBox();
		G1 = new CheckBox();
		G2 = new CheckBox();
		PictureBox8 = new PictureBox();
		Label1 = new Label();
		TabControl1 = new TabControl();
		TabPage1 = new TabPage();
		TextBoxVarreduradeComportamento = new TextBox();
		ProgressBarScanner = new ProgressBar();
		Label7 = new Label();
		Label2 = new Label();
		GroupBox2 = new GroupBox();
		LabelTextEP = new Label();
		LabelTextEC = new Label();
		PictureBox3 = new PictureBox();
		PictureBox1 = new PictureBox();
		Button8 = new Button();
		Button7 = new Button();
		Button2 = new Button();
		Button1 = new Button();
		ShapeContainer1 = new ShapeContainer();
		RectangleShape2 = new RectangleShape();
		RectangleShape1 = new RectangleShape();
		detected = new Label();
		Label3 = new Label();
		Label5 = new Label();
		files = new Label();
		TextBoxScanner = new TextBox();
		Label4 = new Label();
		Label6 = new Label();
		Luz = new Label();
		TrackBar1 = new TrackBar();
		MR = new Label();
		total = new Label();
		Label8 = new Label();
		Lento = new Label();
		Ace = new Label();
		Nor = new Label();
		TabPage2 = new TabPage();
		TabControl2 = new TabControl();
		TabPage4 = new TabPage();
		GroupBox3 = new GroupBox();
		ListaProtecaoReal = new ListBox();
		ButtonLimparProtecaoReal = new Button();
		GroupBox1 = new GroupBox();
		RichTextBox1 = new RichTextBox();
		TabPage5 = new TabPage();
		PanelGen = new Panel();
		LabelGenStatus = new Label();
		DownTotal = new Label();
		DownBaixado = new Label();
		LabelId = new Label();
		LabelGenTextInfo = new Label();
		ProgressCopyGen = new ProgressBar();
		Label7fc = new Label();
		Label20 = new Label();
		OpenGen1 = new Button();
		Label21 = new Label();
		Label22 = new Label();
		Gentext2 = new TextBox();
		GenText1 = new TextBox();
		DownGen1 = new Button();
		TabPage6 = new TabPage();
		Label4fc = new Label();
		GroupBox5 = new GroupBox();
		Limped = new ListBox();
		GroupBox6 = new GroupBox();
		Tar = new Label();
		Label16 = new Label();
		totale = new Label();
		Label17 = new Label();
		PE = new Button();
		CE = new Button();
		ProgressLimpeza = new ProgressBar();
		TabPage10 = new TabPage();
		ListViewGerenciadorTarefa = new ListView();
		ColumnHeader1 = new ColumnHeader();
		ColumnHeader2 = new ColumnHeader();
		ColumnHeader3 = new ColumnHeader();
		ColumnHeader4 = new ColumnHeader();
		ColumnHeader5 = new ColumnHeader();
		StatusGeretaref = new StatusStrip();
		ToolStripStatusLabel1 = new ToolStripStatusLabel();
		ToolStripStatusLabelGerenciadorTarefa = new ToolStripStatusLabel();
		MenuStrip1 = new MenuStrip();
		AtualizarToolStripMenuItem = new ToolStripMenuItem();
		FonteToolStripMenuItem = new ToolStripMenuItem();
		FecharAplicativoToolStripMenuItem = new ToolStripMenuItem();
		LimparTudoToolStripMenuItem = new ToolStripMenuItem();
		TabPage3 = new TabPage();
		TabControl3 = new TabControl();
		TabPage7 = new TabPage();
		GroupBox4 = new GroupBox();
		Label15 = new Label();
		ComboBox1 = new ComboBox();
		Button6 = new Button();
		Button5 = new Button();
		Label14 = new Label();
		TextBoxAgendaAnos = new TextBox();
		Label13 = new Label();
		TextBoxAgendaMes = new TextBox();
		Label12 = new Label();
		TextBoxAgendaDias = new TextBox();
		Label11 = new Label();
		Label10 = new Label();
		Label9 = new Label();
		TextBoxAgendaHoras = new TextBox();
		TextBoxAgendaMinutos = new TextBox();
		TextBoxAgendaSegundos = new TextBox();
		TabPage8 = new TabPage();
		ListBox3 = new ListBox();
		ListBox2 = new ListBox();
		Button3 = new Button();
		TabPage9 = new TabPage();
		ListBox1 = new ListBox();
		Timer1 = new Timer(components);
		FolderBrowserDialog1 = new FolderBrowserDialog();
		crotime = new Timer(components);
		Timer2 = new Timer(components);
		NotPause = new Timer(components);
		Timer1s = new Timer(components);
		Timer2s = new Timer(components);
		FolderBrowserDialog2 = new FolderBrowserDialog();
		Fontgdtarefa = new FontDialog();
		TimeFileCopy = new Timer(components);
		((Control)Panel1).SuspendLayout();
		((Control)PanelGerCopy).SuspendLayout();
		((ISupportInitialize)NuGer).BeginInit();
		((ISupportInitialize)PictureBox8).BeginInit();
		((Control)TabControl1).SuspendLayout();
		((Control)TabPage1).SuspendLayout();
		((Control)GroupBox2).SuspendLayout();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)TrackBar1).BeginInit();
		((Control)TabPage2).SuspendLayout();
		((Control)TabControl2).SuspendLayout();
		((Control)TabPage4).SuspendLayout();
		((Control)GroupBox3).SuspendLayout();
		((Control)GroupBox1).SuspendLayout();
		((Control)TabPage5).SuspendLayout();
		((Control)PanelGen).SuspendLayout();
		((Control)TabPage6).SuspendLayout();
		((Control)GroupBox5).SuspendLayout();
		((Control)GroupBox6).SuspendLayout();
		((Control)TabPage10).SuspendLayout();
		((Control)StatusGeretaref).SuspendLayout();
		((Control)MenuStrip1).SuspendLayout();
		((Control)TabPage3).SuspendLayout();
		((Control)TabControl3).SuspendLayout();
		((Control)TabPage7).SuspendLayout();
		((Control)GroupBox4).SuspendLayout();
		((Control)TabPage8).SuspendLayout();
		((Control)TabPage9).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Panel1).set_BackColor(Color.Black);
		((Control)Panel1).get_Controls().Add((Control)(object)PanelGerCopy);
		((Control)Panel1).get_Controls().Add((Control)(object)PictureBox8);
		((Control)Panel1).get_Controls().Add((Control)(object)Label1);
		((Control)Panel1).set_Dock((DockStyle)1);
		Panel panel = Panel1;
		Point location = new Point(0, 0);
		((Control)panel).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel2 = Panel1;
		Size size = new Size(947, 69);
		((Control)panel2).set_Size(size);
		((Control)Panel1).set_TabIndex(0);
		((Control)PanelGerCopy).set_BackColor(Color.White);
		((Control)PanelGerCopy).get_Controls().Add((Control)(object)cod);
		((Control)PanelGerCopy).get_Controls().Add((Control)(object)NuGer);
		((Control)PanelGerCopy).get_Controls().Add((Control)(object)G3);
		((Control)PanelGerCopy).get_Controls().Add((Control)(object)G1);
		((Control)PanelGerCopy).get_Controls().Add((Control)(object)G2);
		Panel panelGerCopy = PanelGerCopy;
		location = new Point(677, 0);
		((Control)panelGerCopy).set_Location(location);
		((Control)PanelGerCopy).set_Name("PanelGerCopy");
		Panel panelGerCopy2 = PanelGerCopy;
		size = new Size(282, 100);
		((Control)panelGerCopy2).set_Size(size);
		((Control)PanelGerCopy).set_TabIndex(57);
		((Control)PanelGerCopy).set_Visible(false);
		cod.set_AutoSize(true);
		Label obj = cod;
		location = new Point(23, 50);
		((Control)obj).set_Location(location);
		((Control)cod).set_Name("cod");
		Label obj2 = cod;
		size = new Size(154, 13);
		((Control)obj2).set_Size(size);
		((Control)cod).set_TabIndex(53);
		cod.set_Text("SATWNEYT MY DOWNLOAD");
		((Control)cod).set_Visible(false);
		NumericUpDown nuGer = NuGer;
		location = new Point(48, 28);
		((Control)nuGer).set_Location(location);
		((Control)NuGer).set_Name("NuGer");
		NumericUpDown nuGer2 = NuGer;
		size = new Size(26, 20);
		((Control)nuGer2).set_Size(size);
		((Control)NuGer).set_TabIndex(51);
		NumericUpDown nuGer3 = NuGer;
		decimal value = new decimal(new int[4] { 8, 0, 0, 0 });
		nuGer3.set_Value(value);
		((Control)NuGer).set_Visible(false);
		((ButtonBase)G3).set_AutoSize(true);
		G3.set_Checked(true);
		G3.set_CheckState((CheckState)1);
		CheckBox g = G3;
		location = new Point(3, 25);
		((Control)g).set_Location(location);
		((Control)G3).set_Name("G3");
		CheckBox g2 = G3;
		size = new Size(15, 14);
		((Control)g2).set_Size(size);
		((Control)G3).set_TabIndex(50);
		((ButtonBase)G3).set_UseVisualStyleBackColor(true);
		((Control)G3).set_Visible(false);
		((ButtonBase)G1).set_AutoSize(true);
		G1.set_Checked(true);
		G1.set_CheckState((CheckState)1);
		CheckBox g3 = G1;
		location = new Point(59, 8);
		((Control)g3).set_Location(location);
		((Control)G1).set_Name("G1");
		CheckBox g4 = G1;
		size = new Size(15, 14);
		((Control)g4).set_Size(size);
		((Control)G1).set_TabIndex(49);
		((ButtonBase)G1).set_UseVisualStyleBackColor(true);
		((Control)G1).set_Visible(false);
		((ButtonBase)G2).set_AutoSize(true);
		G2.set_Checked(true);
		G2.set_CheckState((CheckState)1);
		CheckBox g5 = G2;
		location = new Point(27, 14);
		((Control)g5).set_Location(location);
		((Control)G2).set_Name("G2");
		CheckBox g6 = G2;
		size = new Size(15, 14);
		((Control)g6).set_Size(size);
		((Control)G2).set_TabIndex(48);
		((ButtonBase)G2).set_UseVisualStyleBackColor(true);
		((Control)G2).set_Visible(false);
		PictureBox8.set_Image((Image)componentResourceManager.GetObject("PictureBox8.Image"));
		PictureBox pictureBox = PictureBox8;
		location = new Point(4, 13);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox8).set_Name("PictureBox8");
		PictureBox pictureBox2 = PictureBox8;
		size = new Size(58, 50);
		((Control)pictureBox2).set_Size(size);
		PictureBox8.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox8.set_TabIndex(2);
		PictureBox8.set_TabStop(false);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.White);
		Label label = Label1;
		location = new Point(68, 25);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(428, 25);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("SATWNEYT ANTIVÍRUS PLUS ONE-X 4");
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage1);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage2);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage3);
		((Control)TabControl1).set_Dock((DockStyle)5);
		((Control)TabControl1).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TabControl tabControl = TabControl1;
		location = new Point(0, 69);
		((Control)tabControl).set_Location(location);
		((Control)TabControl1).set_Name("TabControl1");
		TabControl1.set_SelectedIndex(0);
		TabControl tabControl2 = TabControl1;
		size = new Size(947, 526);
		((Control)tabControl2).set_Size(size);
		((Control)TabControl1).set_TabIndex(1);
		((Control)TabPage1).get_Controls().Add((Control)(object)TextBoxVarreduradeComportamento);
		((Control)TabPage1).get_Controls().Add((Control)(object)ProgressBarScanner);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label7);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label2);
		((Control)TabPage1).get_Controls().Add((Control)(object)GroupBox2);
		((Control)TabPage1).get_Controls().Add((Control)(object)detected);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label3);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label5);
		((Control)TabPage1).get_Controls().Add((Control)(object)files);
		((Control)TabPage1).get_Controls().Add((Control)(object)TextBoxScanner);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label4);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label6);
		((Control)TabPage1).get_Controls().Add((Control)(object)Luz);
		((Control)TabPage1).get_Controls().Add((Control)(object)TrackBar1);
		((Control)TabPage1).get_Controls().Add((Control)(object)MR);
		((Control)TabPage1).get_Controls().Add((Control)(object)total);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label8);
		((Control)TabPage1).get_Controls().Add((Control)(object)Lento);
		((Control)TabPage1).get_Controls().Add((Control)(object)Ace);
		((Control)TabPage1).get_Controls().Add((Control)(object)Nor);
		TabPage tabPage = TabPage1;
		location = new Point(4, 34);
		tabPage.set_Location(location);
		((Control)TabPage1).set_Name("TabPage1");
		TabPage tabPage2 = TabPage1;
		Padding val = default(Padding);
		((Padding)(ref val))._002Ector(3);
		((Control)tabPage2).set_Padding(val);
		TabPage tabPage3 = TabPage1;
		size = new Size(939, 488);
		((Control)tabPage3).set_Size(size);
		TabPage1.set_TabIndex(0);
		TabPage1.set_Text(" VARREDURA E ESCANEAMENTO ");
		TabPage1.set_UseVisualStyleBackColor(true);
		TextBox textBoxVarreduradeComportamento = TextBoxVarreduradeComportamento;
		location = new Point(18, 245);
		((Control)textBoxVarreduradeComportamento).set_Location(location);
		((Control)TextBoxVarreduradeComportamento).set_Name("TextBoxVarreduradeComportamento");
		((TextBoxBase)TextBoxVarreduradeComportamento).set_ReadOnly(true);
		TextBox textBoxVarreduradeComportamento2 = TextBoxVarreduradeComportamento;
		size = new Size(10, 31);
		((Control)textBoxVarreduradeComportamento2).set_Size(size);
		((Control)TextBoxVarreduradeComportamento).set_TabIndex(152);
		((Control)TextBoxVarreduradeComportamento).set_Visible(false);
		((Control)ProgressBarScanner).set_Dock((DockStyle)1);
		ProgressBar progressBarScanner = ProgressBarScanner;
		location = new Point(3, 3);
		((Control)progressBarScanner).set_Location(location);
		((Control)ProgressBarScanner).set_Name("ProgressBarScanner");
		ProgressBar progressBarScanner2 = ProgressBarScanner;
		size = new Size(933, 31);
		((Control)progressBarScanner2).set_Size(size);
		((Control)ProgressBarScanner).set_TabIndex(151);
		Label7.set_AutoSize(true);
		Label label3 = Label7;
		location = new Point(351, 251);
		((Control)label3).set_Location(location);
		((Control)Label7).set_Name("Label7");
		Label label4 = Label7;
		size = new Size(96, 25);
		((Control)label4).set_Size(size);
		((Control)Label7).set_TabIndex(150);
		Label7.set_Text("00:00:00");
		Label2.set_AutoSize(true);
		Label label5 = Label2;
		location = new Point(85, 251);
		((Control)label5).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label6 = Label2;
		size = new Size(260, 25);
		((Control)label6).set_Size(size);
		((Control)Label2).set_TabIndex(149);
		Label2.set_Text("Contagem de cronômetro:");
		((Control)GroupBox2).get_Controls().Add((Control)(object)LabelTextEP);
		((Control)GroupBox2).get_Controls().Add((Control)(object)LabelTextEC);
		((Control)GroupBox2).get_Controls().Add((Control)(object)PictureBox3);
		((Control)GroupBox2).get_Controls().Add((Control)(object)PictureBox1);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Button8);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Button7);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Button2);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Button1);
		((Control)GroupBox2).get_Controls().Add((Control)(object)ShapeContainer1);
		((Control)GroupBox2).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		GroupBox groupBox = GroupBox2;
		location = new Point(8, 40);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox2).set_Name("GroupBox2");
		GroupBox groupBox2 = GroupBox2;
		size = new Size(923, 201);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox2).set_TabIndex(148);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("Opções de varredura");
		LabelTextEP.set_AutoSize(true);
		Label labelTextEP = LabelTextEP;
		location = new Point(89, 101);
		((Control)labelTextEP).set_Location(location);
		((Control)LabelTextEP).set_Name("LabelTextEP");
		Label labelTextEP2 = LabelTextEP;
		size = new Size(588, 96);
		((Control)labelTextEP2).set_Size(size);
		((Control)LabelTextEP).set_TabIndex(16);
		LabelTextEP.set_Text(componentResourceManager.GetString("LabelTextEP.Text"));
		LabelTextEC.set_AutoSize(true);
		Label labelTextEC = LabelTextEC;
		location = new Point(88, 18);
		((Control)labelTextEC).set_Location(location);
		((Control)LabelTextEC).set_Name("LabelTextEC");
		Label labelTextEC2 = LabelTextEC;
		size = new Size(589, 64);
		((Control)labelTextEC2).set_Size(size);
		((Control)LabelTextEC).set_TabIndex(15);
		LabelTextEC.set_Text(componentResourceManager.GetString("LabelTextEC.Text"));
		PictureBox3.set_Image((Image)componentResourceManager.GetObject("PictureBox3.Image"));
		PictureBox pictureBox3 = PictureBox3;
		location = new Point(13, 104);
		((Control)pictureBox3).set_Location(location);
		((Control)PictureBox3).set_Name("PictureBox3");
		PictureBox pictureBox4 = PictureBox3;
		size = new Size(71, 59);
		((Control)pictureBox4).set_Size(size);
		PictureBox3.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox3.set_TabIndex(13);
		PictureBox3.set_TabStop(false);
		PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		PictureBox pictureBox5 = PictureBox1;
		location = new Point(11, 21);
		((Control)pictureBox5).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox6 = PictureBox1;
		size = new Size(71, 59);
		((Control)pictureBox6).set_Size(size);
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(12);
		PictureBox1.set_TabStop(false);
		((Control)Button8).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Button button = Button8;
		location = new Point(823, 114);
		((Control)button).set_Location(location);
		((Control)Button8).set_Name("Button8");
		Button button2 = Button8;
		size = new Size(97, 66);
		((Control)button2).set_Size(size);
		((Control)Button8).set_TabIndex(11);
		((ButtonBase)Button8).set_Text("Info EP");
		((ButtonBase)Button8).set_UseVisualStyleBackColor(true);
		((Control)Button7).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Button button3 = Button7;
		location = new Point(820, 18);
		((Control)button3).set_Location(location);
		((Control)Button7).set_Name("Button7");
		Button button4 = Button7;
		size = new Size(97, 68);
		((Control)button4).set_Size(size);
		((Control)Button7).set_TabIndex(10);
		((ButtonBase)Button7).set_Text("Info EC");
		((ButtonBase)Button7).set_UseVisualStyleBackColor(true);
		((Control)Button2).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Button button5 = Button2;
		location = new Point(696, 114);
		((Control)button5).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button6 = Button2;
		size = new Size(121, 66);
		((Control)button6).set_Size(size);
		((Control)Button2).set_TabIndex(9);
		((ButtonBase)Button2).set_Text("Escaneamento Personalizado");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Button button7 = Button1;
		location = new Point(693, 18);
		((Control)button7).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button8 = Button1;
		size = new Size(122, 68);
		((Control)button8).set_Size(size);
		((Control)Button1).set_TabIndex(2);
		((ButtonBase)Button1).set_Text("Escaneamento Completo");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		ShapeContainer shapeContainer = ShapeContainer1;
		location = new Point(3, 18);
		((Control)shapeContainer).set_Location(location);
		ShapeContainer shapeContainer2 = ShapeContainer1;
		((Padding)(ref val))._002Ector(0);
		((Control)shapeContainer2).set_Margin(val);
		((Control)ShapeContainer1).set_Name("ShapeContainer1");
		ShapeContainer1.get_Shapes().AddRange((Shape[])(object)new Shape[2]
		{
			(Shape)RectangleShape2,
			(Shape)RectangleShape1
		});
		ShapeContainer shapeContainer3 = ShapeContainer1;
		size = new Size(917, 180);
		((Control)shapeContainer3).set_Size(size);
		((Control)ShapeContainer1).set_TabIndex(14);
		((Control)ShapeContainer1).set_TabStop(false);
		RectangleShape rectangleShape = RectangleShape2;
		location = new Point(8, 82);
		((SimpleShape)rectangleShape).set_Location(location);
		((Shape)RectangleShape2).set_Name("RectangleShape2");
		RectangleShape rectangleShape2 = RectangleShape2;
		size = new Size(75, 64);
		((SimpleShape)rectangleShape2).set_Size(size);
		RectangleShape rectangleShape3 = RectangleShape1;
		location = new Point(7, 1);
		((SimpleShape)rectangleShape3).set_Location(location);
		((Shape)RectangleShape1).set_Name("RectangleShape1");
		RectangleShape rectangleShape4 = RectangleShape1;
		size = new Size(73, 64);
		((SimpleShape)rectangleShape4).set_Size(size);
		detected.set_AutoSize(true);
		Label obj3 = detected;
		location = new Point(351, 353);
		((Control)obj3).set_Location(location);
		((Control)detected).set_Name("detected");
		Label obj4 = detected;
		size = new Size(24, 25);
		((Control)obj4).set_Size(size);
		((Control)detected).set_TabIndex(137);
		detected.set_Text("0");
		Label3.set_AutoSize(true);
		Label label7 = Label3;
		location = new Point(165, 321);
		((Control)label7).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label8 = Label3;
		size = new Size(180, 25);
		((Control)label8).set_Size(size);
		((Control)Label3).set_TabIndex(136);
		Label3.set_Text("Objeto verificado:");
		Label5.set_AutoSize(true);
		Label label9 = Label5;
		location = new Point(170, 353);
		((Control)label9).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label10 = Label5;
		size = new Size(175, 25);
		((Control)label10).set_Size(size);
		((Control)Label5).set_TabIndex(138);
		Label5.set_Text("Objeto Infectado:");
		files.set_AutoSize(true);
		Label obj5 = files;
		location = new Point(351, 321);
		((Control)obj5).set_Location(location);
		((Control)files).set_Name("files");
		Label obj6 = files;
		size = new Size(24, 25);
		((Control)obj6).set_Size(size);
		((Control)files).set_TabIndex(135);
		files.set_Text("0");
		((TextBoxBase)TextBoxScanner).set_BackColor(Color.White);
		TextBox textBoxScanner = TextBoxScanner;
		location = new Point(175, 391);
		((Control)textBoxScanner).set_Location(location);
		TextBoxScanner.set_Multiline(true);
		((Control)TextBoxScanner).set_Name("TextBoxScanner");
		((TextBoxBase)TextBoxScanner).set_ReadOnly(true);
		TextBoxScanner.set_ScrollBars((ScrollBars)3);
		TextBox textBoxScanner2 = TextBoxScanner;
		size = new Size(532, 91);
		((Control)textBoxScanner2).set_Size(size);
		((Control)TextBoxScanner).set_TabIndex(134);
		TextBoxScanner.set_Text("C:\\");
		Label4.set_AutoSize(true);
		Label label11 = Label4;
		location = new Point(728, 254);
		((Control)label11).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label12 = Label4;
		size = new Size(166, 50);
		((Control)label12).set_Size(size);
		((Control)Label4).set_TabIndex(147);
		Label4.set_Text("Varredura no \r\ncomportamento:");
		Label6.set_AutoSize(true);
		Label label13 = Label6;
		location = new Point(177, 287);
		((Control)label13).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label14 = Label6;
		size = new Size(168, 25);
		((Control)label14).set_Size(size);
		((Control)Label6).set_TabIndex(139);
		Label6.set_Text("Total de Aquivo:");
		Luz.set_AutoSize(true);
		((Control)Luz).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Luz).set_ForeColor(Color.Gray);
		Label luz = Luz;
		location = new Point(730, 310);
		((Control)luz).set_Location(location);
		((Control)Luz).set_Name("Luz");
		Label luz2 = Luz;
		size = new Size(100, 26);
		((Control)luz2).set_Size(size);
		((Control)Luz).set_TabIndex(146);
		Luz.set_Text("No desempenho do\r\n computador");
		((Control)TrackBar1).set_BackColor(Color.White);
		TrackBar trackBar = TrackBar1;
		location = new Point(831, 307);
		((Control)trackBar).set_Location(location);
		TrackBar1.set_Maximum(4);
		((Control)TrackBar1).set_Name("TrackBar1");
		TrackBar1.set_Orientation((Orientation)1);
		((Control)TrackBar1).set_RightToLeft((RightToLeft)0);
		TrackBar trackBar2 = TrackBar1;
		size = new Size(45, 171);
		((Control)trackBar2).set_Size(size);
		((Control)TrackBar1).set_TabIndex(141);
		TrackBar1.set_TickStyle((TickStyle)1);
		TrackBar1.set_Value(1);
		MR.set_AutoSize(true);
		((Control)MR).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)MR).set_ForeColor(Color.Gray);
		Label mR = MR;
		location = new Point(760, 344);
		((Control)mR).set_Location(location);
		((Control)MR).set_Name("MR");
		Label mR2 = MR;
		size = new Size(65, 13);
		((Control)mR2).set_Size(size);
		((Control)MR).set_TabIndex(145);
		MR.set_Text("Muito rápido");
		total.set_AutoSize(true);
		Label obj7 = total;
		location = new Point(351, 287);
		((Control)obj7).set_Location(location);
		((Control)total).set_Name("total");
		Label obj8 = total;
		size = new Size(24, 25);
		((Control)obj8).set_Size(size);
		((Control)total).set_TabIndex(133);
		total.set_Text("0");
		Label8.set_AutoSize(true);
		Label label15 = Label8;
		location = new Point(78, 391);
		((Control)label15).set_Location(location);
		((Control)Label8).set_Name("Label8");
		Label label16 = Label8;
		size = new Size(91, 25);
		((Control)label16).set_Size(size);
		((Control)Label8).set_TabIndex(140);
		Label8.set_Text("Arquivo:");
		Lento.set_AutoSize(true);
		((Control)Lento).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Lento).set_ForeColor(Color.Gray);
		Label lento = Lento;
		location = new Point(790, 457);
		((Control)lento).set_Location(location);
		((Control)Lento).set_Name("Lento");
		Label lento2 = Lento;
		size = new Size(34, 13);
		((Control)lento2).set_Size(size);
		((Control)Lento).set_TabIndex(142);
		Lento.set_Text("Lento");
		Ace.set_AutoSize(true);
		((Control)Ace).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Ace).set_ForeColor(Color.Gray);
		Label ace = Ace;
		location = new Point(778, 379);
		((Control)ace).set_Location(location);
		((Control)Ace).set_Name("Ace");
		Label ace2 = Ace;
		size = new Size(46, 13);
		((Control)ace2).set_Size(size);
		((Control)Ace).set_TabIndex(143);
		Ace.set_Text("Acelerar");
		Nor.set_AutoSize(true);
		((Control)Nor).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Nor).set_ForeColor(Color.Black);
		Label nor = Nor;
		location = new Point(784, 419);
		((Control)nor).set_Location(location);
		((Control)Nor).set_Name("Nor");
		Label nor2 = Nor;
		size = new Size(40, 13);
		((Control)nor2).set_Size(size);
		((Control)Nor).set_TabIndex(144);
		Nor.set_Text("Normal");
		((Control)TabPage2).get_Controls().Add((Control)(object)TabControl2);
		TabPage tabPage4 = TabPage2;
		location = new Point(4, 34);
		tabPage4.set_Location(location);
		((Control)TabPage2).set_Name("TabPage2");
		TabPage tabPage5 = TabPage2;
		((Padding)(ref val))._002Ector(3);
		((Control)tabPage5).set_Padding(val);
		TabPage tabPage6 = TabPage2;
		size = new Size(939, 488);
		((Control)tabPage6).set_Size(size);
		TabPage2.set_TabIndex(1);
		TabPage2.set_Text(" PROTEÇÃO DE ARQUIVO");
		TabPage2.set_UseVisualStyleBackColor(true);
		((Control)TabControl2).get_Controls().Add((Control)(object)TabPage4);
		((Control)TabControl2).get_Controls().Add((Control)(object)TabPage5);
		((Control)TabControl2).get_Controls().Add((Control)(object)TabPage6);
		((Control)TabControl2).get_Controls().Add((Control)(object)TabPage10);
		((Control)TabControl2).set_Dock((DockStyle)5);
		TabControl tabControl3 = TabControl2;
		location = new Point(3, 3);
		((Control)tabControl3).set_Location(location);
		((Control)TabControl2).set_Name("TabControl2");
		TabControl2.set_SelectedIndex(0);
		TabControl tabControl4 = TabControl2;
		size = new Size(933, 482);
		((Control)tabControl4).set_Size(size);
		((Control)TabControl2).set_TabIndex(0);
		((Control)TabPage4).get_Controls().Add((Control)(object)GroupBox3);
		((Control)TabPage4).get_Controls().Add((Control)(object)GroupBox1);
		TabPage tabPage7 = TabPage4;
		location = new Point(4, 34);
		tabPage7.set_Location(location);
		((Control)TabPage4).set_Name("TabPage4");
		TabPage tabPage8 = TabPage4;
		((Padding)(ref val))._002Ector(3);
		((Control)tabPage8).set_Padding(val);
		TabPage tabPage9 = TabPage4;
		size = new Size(925, 444);
		((Control)tabPage9).set_Size(size);
		TabPage4.set_TabIndex(0);
		TabPage4.set_Text("Arquivo em Proteção Real");
		TabPage4.set_UseVisualStyleBackColor(true);
		((Control)GroupBox3).get_Controls().Add((Control)(object)ListaProtecaoReal);
		((Control)GroupBox3).get_Controls().Add((Control)(object)ButtonLimparProtecaoReal);
		GroupBox groupBox3 = GroupBox3;
		location = new Point(6, 156);
		((Control)groupBox3).set_Location(location);
		((Control)GroupBox3).set_Name("GroupBox3");
		GroupBox groupBox4 = GroupBox3;
		size = new Size(913, 282);
		((Control)groupBox4).set_Size(size);
		((Control)GroupBox3).set_TabIndex(1);
		GroupBox3.set_TabStop(false);
		GroupBox3.set_Text("Lista de itens em Proteção Real");
		((Control)ListaProtecaoReal).set_Dock((DockStyle)5);
		((ListControl)ListaProtecaoReal).set_FormattingEnabled(true);
		ListaProtecaoReal.set_HorizontalScrollbar(true);
		ListaProtecaoReal.set_ItemHeight(25);
		ListBox listaProtecaoReal = ListaProtecaoReal;
		location = new Point(3, 27);
		((Control)listaProtecaoReal).set_Location(location);
		((Control)ListaProtecaoReal).set_Name("ListaProtecaoReal");
		ListBox listaProtecaoReal2 = ListaProtecaoReal;
		size = new Size(907, 216);
		((Control)listaProtecaoReal2).set_Size(size);
		((Control)ListaProtecaoReal).set_TabIndex(1);
		((Control)ButtonLimparProtecaoReal).set_Dock((DockStyle)2);
		Button buttonLimparProtecaoReal = ButtonLimparProtecaoReal;
		location = new Point(3, 243);
		((Control)buttonLimparProtecaoReal).set_Location(location);
		((Control)ButtonLimparProtecaoReal).set_Name("ButtonLimparProtecaoReal");
		Button buttonLimparProtecaoReal2 = ButtonLimparProtecaoReal;
		size = new Size(907, 36);
		((Control)buttonLimparProtecaoReal2).set_Size(size);
		((Control)ButtonLimparProtecaoReal).set_TabIndex(0);
		((ButtonBase)ButtonLimparProtecaoReal).set_Text("Limpar todo processo de arquivo");
		((ButtonBase)ButtonLimparProtecaoReal).set_UseVisualStyleBackColor(true);
		((Control)GroupBox1).get_Controls().Add((Control)(object)RichTextBox1);
		GroupBox groupBox5 = GroupBox1;
		location = new Point(6, 7);
		((Control)groupBox5).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox6 = GroupBox1;
		size = new Size(913, 143);
		((Control)groupBox6).set_Size(size);
		((Control)GroupBox1).set_TabIndex(0);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Arquivo em Proteção Real");
		((TextBoxBase)RichTextBox1).set_BackColor(Color.White);
		RichTextBox richTextBox = RichTextBox1;
		location = new Point(6, 30);
		((Control)richTextBox).set_Location(location);
		((Control)RichTextBox1).set_Name("RichTextBox1");
		((TextBoxBase)RichTextBox1).set_ReadOnly(true);
		RichTextBox1.set_ScrollBars((RichTextBoxScrollBars)19);
		RichTextBox richTextBox2 = RichTextBox1;
		size = new Size(907, 96);
		((Control)richTextBox2).set_Size(size);
		((Control)RichTextBox1).set_TabIndex(0);
		RichTextBox1.set_Text("");
		((Control)TabPage5).get_Controls().Add((Control)(object)PanelGen);
		((Control)TabPage5).get_Controls().Add((Control)(object)Label20);
		((Control)TabPage5).get_Controls().Add((Control)(object)OpenGen1);
		((Control)TabPage5).get_Controls().Add((Control)(object)Label21);
		((Control)TabPage5).get_Controls().Add((Control)(object)Label22);
		((Control)TabPage5).get_Controls().Add((Control)(object)Gentext2);
		((Control)TabPage5).get_Controls().Add((Control)(object)GenText1);
		((Control)TabPage5).get_Controls().Add((Control)(object)DownGen1);
		TabPage tabPage10 = TabPage5;
		location = new Point(4, 34);
		tabPage10.set_Location(location);
		((Control)TabPage5).set_Name("TabPage5");
		TabPage tabPage11 = TabPage5;
		((Padding)(ref val))._002Ector(3);
		((Control)tabPage11).set_Padding(val);
		TabPage tabPage12 = TabPage5;
		size = new Size(925, 444);
		((Control)tabPage12).set_Size(size);
		TabPage5.set_TabIndex(1);
		TabPage5.set_Text("Arquivo Cópia");
		TabPage5.set_UseVisualStyleBackColor(true);
		((Control)PanelGen).get_Controls().Add((Control)(object)LabelGenStatus);
		((Control)PanelGen).get_Controls().Add((Control)(object)DownTotal);
		((Control)PanelGen).get_Controls().Add((Control)(object)DownBaixado);
		((Control)PanelGen).get_Controls().Add((Control)(object)LabelId);
		((Control)PanelGen).get_Controls().Add((Control)(object)LabelGenTextInfo);
		((Control)PanelGen).get_Controls().Add((Control)(object)ProgressCopyGen);
		((Control)PanelGen).get_Controls().Add((Control)(object)Label7fc);
		((Control)PanelGen).set_Dock((DockStyle)5);
		Panel panelGen = PanelGen;
		location = new Point(3, 3);
		((Control)panelGen).set_Location(location);
		((Control)PanelGen).set_Name("PanelGen");
		Panel panelGen2 = PanelGen;
		size = new Size(919, 438);
		((Control)panelGen2).set_Size(size);
		((Control)PanelGen).set_TabIndex(67);
		((Control)PanelGen).set_Visible(false);
		LabelGenStatus.set_AutoSize(true);
		Label labelGenStatus = LabelGenStatus;
		location = new Point(396, 123);
		((Control)labelGenStatus).set_Location(location);
		((Control)LabelGenStatus).set_Name("LabelGenStatus");
		Label labelGenStatus2 = LabelGenStatus;
		size = new Size(43, 25);
		((Control)labelGenStatus2).set_Size(size);
		((Control)LabelGenStatus).set_TabIndex(53);
		LabelGenStatus.set_Text("0%");
		DownTotal.set_AutoSize(true);
		Label downTotal = DownTotal;
		location = new Point(67, 323);
		((Control)downTotal).set_Location(location);
		((Control)DownTotal).set_Name("DownTotal");
		Label downTotal2 = DownTotal;
		size = new Size(118, 25);
		((Control)downTotal2).set_Size(size);
		((Control)DownTotal).set_TabIndex(52);
		DownTotal.set_Text("Total: 0 KB");
		DownBaixado.set_AutoSize(true);
		Label downBaixado = DownBaixado;
		location = new Point(40, 299);
		((Control)downBaixado).set_Location(location);
		((Control)DownBaixado).set_Name("DownBaixado");
		Label downBaixado2 = DownBaixado;
		size = new Size(148, 25);
		((Control)downBaixado2).set_Size(size);
		((Control)DownBaixado).set_TabIndex(51);
		DownBaixado.set_Text("Baixado: 0 KB");
		LabelId.set_AutoSize(true);
		Label labelId = LabelId;
		location = new Point(40, 247);
		((Control)labelId).set_Location(location);
		((Control)LabelId).set_Name("LabelId");
		Label labelId2 = LabelId;
		size = new Size(217, 25);
		((Control)labelId2).set_Size(size);
		((Control)LabelId).set_TabIndex(50);
		LabelId.set_Text("Por Favor, Aguarde...");
		LabelGenTextInfo.set_AutoSize(true);
		((Control)LabelGenTextInfo).set_Font(new Font("Microsoft Sans Serif", 26.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label labelGenTextInfo = LabelGenTextInfo;
		location = new Point(74, 59);
		((Control)labelGenTextInfo).set_Location(location);
		((Control)LabelGenTextInfo).set_Name("LabelGenTextInfo");
		Label labelGenTextInfo2 = LabelGenTextInfo;
		size = new Size(194, 39);
		((Control)labelGenTextInfo2).set_Size(size);
		((Control)LabelGenTextInfo).set_TabIndex(49);
		LabelGenTextInfo.set_Text("Copiando...");
		ProgressBar progressCopyGen = ProgressCopyGen;
		location = new Point(71, 108);
		((Control)progressCopyGen).set_Location(location);
		((Control)ProgressCopyGen).set_Name("ProgressCopyGen");
		ProgressBar progressCopyGen2 = ProgressCopyGen;
		size = new Size(759, 59);
		((Control)progressCopyGen2).set_Size(size);
		((Control)ProgressCopyGen).set_TabIndex(0);
		Label7fc.set_AutoSize(true);
		Label label7fc = Label7fc;
		location = new Point(52, 464);
		((Control)label7fc).set_Location(location);
		((Control)Label7fc).set_Name("Label7fc");
		Label label7fc2 = Label7fc;
		size = new Size(231, 25);
		((Control)label7fc2).set_Size(size);
		((Control)Label7fc).set_TabIndex(6);
		Label7fc.set_Text("C:\\mysoftware\\123.exe");
		((Control)Label7fc).set_Visible(false);
		Label20.set_AutoSize(true);
		Label label17 = Label20;
		location = new Point(253, 82);
		((Control)label17).set_Location(location);
		((Control)Label20).set_Name("Label20");
		Label label18 = Label20;
		size = new Size(371, 25);
		((Control)label18).set_Size(size);
		((Control)Label20).set_TabIndex(66);
		Label20.set_Text("Faça o seu arquivo ter mais cópias !!!");
		((Control)OpenGen1).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Button openGen = OpenGen1;
		location = new Point(794, 205);
		((Control)openGen).set_Location(location);
		((Control)OpenGen1).set_Name("OpenGen1");
		Button openGen2 = OpenGen1;
		size = new Size(83, 35);
		((Control)openGen2).set_Size(size);
		((Control)OpenGen1).set_TabIndex(65);
		((ButtonBase)OpenGen1).set_Text("Abrir");
		((ButtonBase)OpenGen1).set_UseVisualStyleBackColor(true);
		Label21.set_AutoSize(true);
		((Control)Label21).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label19 = Label21;
		location = new Point(270, 186);
		((Control)label19).set_Location(location);
		((Control)Label21).set_Name("Label21");
		Label label20 = Label21;
		size = new Size(214, 24);
		((Control)label20).set_Size(size);
		((Control)Label21).set_TabIndex(64);
		Label21.set_Text("SALVAR NO ARQUIVO:");
		Label22.set_AutoSize(true);
		((Control)Label22).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label21 = Label22;
		location = new Point(269, 122);
		((Control)label21).set_Location(location);
		((Control)Label22).set_Name("Label22");
		Label label22 = Label22;
		size = new Size(376, 24);
		((Control)label22).set_Size(size);
		((Control)Label22).set_TabIndex(63);
		Label22.set_Text("URL Direto:   (que deve existir e verdadeiro)");
		((TextBoxBase)Gentext2).set_BackColor(Color.White);
		((Control)Gentext2).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox gentext = Gentext2;
		location = new Point(44, 211);
		((Control)gentext).set_Location(location);
		((Control)Gentext2).set_Name("Gentext2");
		((TextBoxBase)Gentext2).set_ReadOnly(true);
		TextBox gentext2 = Gentext2;
		size = new Size(733, 29);
		((Control)gentext2).set_Size(size);
		((Control)Gentext2).set_TabIndex(62);
		Gentext2.set_Text("C:\\");
		((Control)GenText1).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox genText = GenText1;
		location = new Point(44, 154);
		((Control)genText).set_Location(location);
		((Control)GenText1).set_Name("GenText1");
		TextBox genText2 = GenText1;
		size = new Size(833, 29);
		((Control)genText2).set_Size(size);
		((Control)GenText1).set_TabIndex(61);
		GenText1.set_Text("http://");
		Button downGen = DownGen1;
		location = new Point(44, 266);
		((Control)downGen).set_Location(location);
		((Control)DownGen1).set_Name("DownGen1");
		Button downGen2 = DownGen1;
		size = new Size(833, 89);
		((Control)downGen2).set_Size(size);
		((Control)DownGen1).set_TabIndex(60);
		((ButtonBase)DownGen1).set_Text("Copiar e Download");
		((ButtonBase)DownGen1).set_UseVisualStyleBackColor(true);
		((Control)TabPage6).get_Controls().Add((Control)(object)Label4fc);
		((Control)TabPage6).get_Controls().Add((Control)(object)GroupBox5);
		((Control)TabPage6).get_Controls().Add((Control)(object)GroupBox6);
		((Control)TabPage6).get_Controls().Add((Control)(object)ProgressLimpeza);
		TabPage tabPage13 = TabPage6;
		location = new Point(4, 34);
		tabPage13.set_Location(location);
		((Control)TabPage6).set_Name("TabPage6");
		TabPage tabPage14 = TabPage6;
		((Padding)(ref val))._002Ector(3);
		((Control)tabPage14).set_Padding(val);
		TabPage tabPage15 = TabPage6;
		size = new Size(925, 444);
		((Control)tabPage15).set_Size(size);
		TabPage6.set_TabIndex(2);
		TabPage6.set_Text("Limpeza Pc");
		TabPage6.set_UseVisualStyleBackColor(true);
		Label4fc.set_AutoSize(true);
		((Control)Label4fc).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label4fc).set_ForeColor(Color.Black);
		Label label4fc = Label4fc;
		location = new Point(218, -25);
		((Control)label4fc).set_Location(location);
		((Control)Label4fc).set_Name("Label4fc");
		Label label4fc2 = Label4fc;
		size = new Size(19, 20);
		((Control)label4fc2).set_Size(size);
		((Control)Label4fc).set_TabIndex(11);
		Label4fc.set_Text("0");
		((Control)GroupBox5).get_Controls().Add((Control)(object)Limped);
		((Control)GroupBox5).set_ForeColor(Color.FromArgb(0, 0, 192));
		GroupBox groupBox7 = GroupBox5;
		location = new Point(3, 45);
		((Control)groupBox7).set_Location(location);
		((Control)GroupBox5).set_Name("GroupBox5");
		GroupBox groupBox8 = GroupBox5;
		size = new Size(916, 264);
		((Control)groupBox8).set_Size(size);
		((Control)GroupBox5).set_TabIndex(16);
		GroupBox5.set_TabStop(false);
		GroupBox5.set_Text("Lista de Erros");
		((Control)Limped).set_Dock((DockStyle)5);
		Limped.set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)Limped).set_FormattingEnabled(true);
		Limped.set_ItemHeight(24);
		ListBox limped = Limped;
		location = new Point(3, 27);
		((Control)limped).set_Location(location);
		((Control)Limped).set_Name("Limped");
		Limped.set_ScrollAlwaysVisible(true);
		ListBox limped2 = Limped;
		size = new Size(910, 234);
		((Control)limped2).set_Size(size);
		((Control)Limped).set_TabIndex(0);
		((Control)GroupBox6).get_Controls().Add((Control)(object)Tar);
		((Control)GroupBox6).get_Controls().Add((Control)(object)Label16);
		((Control)GroupBox6).get_Controls().Add((Control)(object)totale);
		((Control)GroupBox6).get_Controls().Add((Control)(object)Label17);
		((Control)GroupBox6).get_Controls().Add((Control)(object)PE);
		((Control)GroupBox6).get_Controls().Add((Control)(object)CE);
		((Control)GroupBox6).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox6).set_ForeColor(Color.FromArgb(0, 0, 192));
		GroupBox groupBox9 = GroupBox6;
		location = new Point(7, 329);
		((Control)groupBox9).set_Location(location);
		((Control)GroupBox6).set_Name("GroupBox6");
		GroupBox groupBox10 = GroupBox6;
		size = new Size(909, 82);
		((Control)groupBox10).set_Size(size);
		((Control)GroupBox6).set_TabIndex(15);
		GroupBox6.set_TabStop(false);
		GroupBox6.set_Text("Informações");
		Tar.set_AutoSize(true);
		((Control)Tar).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Tar).set_ForeColor(Color.Black);
		Label tar = Tar;
		location = new Point(166, 58);
		((Control)tar).set_Location(location);
		((Control)Tar).set_Name("Tar");
		Label tar2 = Tar;
		size = new Size(19, 20);
		((Control)tar2).set_Size(size);
		((Control)Tar).set_TabIndex(4);
		Tar.set_Text("0");
		Label16.set_AutoSize(true);
		((Control)Label16).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label16).set_ForeColor(Color.Black);
		Label label23 = Label16;
		location = new Point(16, 58);
		((Control)label23).set_Location(location);
		((Control)Label16).set_Name("Label16");
		Label label24 = Label16;
		size = new Size(144, 20);
		((Control)label24).set_Size(size);
		((Control)Label16).set_TabIndex(2);
		Label16.set_Text("Total de Arquivo:");
		totale.set_AutoSize(true);
		((Control)totale).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)totale).set_ForeColor(Color.Black);
		Label obj9 = totale;
		location = new Point(166, 27);
		((Control)obj9).set_Location(location);
		((Control)totale).set_Name("totale");
		Label obj10 = totale;
		size = new Size(19, 20);
		((Control)obj10).set_Size(size);
		((Control)totale).set_TabIndex(1);
		totale.set_Text("0");
		Label17.set_AutoSize(true);
		((Control)Label17).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label17).set_ForeColor(Color.Black);
		Label label25 = Label17;
		location = new Point(33, 27);
		((Control)label25).set_Location(location);
		((Control)Label17).set_Name("Label17");
		Label label26 = Label17;
		size = new Size(127, 20);
		((Control)label26).set_Size(size);
		((Control)Label17).set_TabIndex(0);
		Label17.set_Text("Total de Erros:");
		Button pE = PE;
		location = new Point(489, 30);
		((Control)pE).set_Location(location);
		((Control)PE).set_Name("PE");
		Button pE2 = PE;
		size = new Size(184, 39);
		((Control)pE2).set_Size(size);
		((Control)PE).set_TabIndex(12);
		((ButtonBase)PE).set_Text("Procurar Erros");
		((ButtonBase)PE).set_UseVisualStyleBackColor(true);
		((Control)CE).set_Enabled(false);
		((Control)CE).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Button cE = CE;
		location = new Point(704, 13);
		((Control)cE).set_Location(location);
		((Control)CE).set_Name("CE");
		Button cE2 = CE;
		size = new Size(199, 63);
		((Control)cE2).set_Size(size);
		((Control)CE).set_TabIndex(13);
		((ButtonBase)CE).set_Text("Corrigir os Erro(s)\r\nSelecionado(s)");
		((ButtonBase)CE).set_UseVisualStyleBackColor(true);
		((Control)ProgressLimpeza).set_Dock((DockStyle)1);
		ProgressBar progressLimpeza = ProgressLimpeza;
		location = new Point(3, 3);
		((Control)progressLimpeza).set_Location(location);
		((Control)ProgressLimpeza).set_Name("ProgressLimpeza");
		ProgressBar progressLimpeza2 = ProgressLimpeza;
		size = new Size(919, 36);
		((Control)progressLimpeza2).set_Size(size);
		((Control)ProgressLimpeza).set_TabIndex(14);
		((Control)TabPage10).get_Controls().Add((Control)(object)ListViewGerenciadorTarefa);
		((Control)TabPage10).get_Controls().Add((Control)(object)StatusGeretaref);
		((Control)TabPage10).get_Controls().Add((Control)(object)MenuStrip1);
		TabPage tabPage16 = TabPage10;
		location = new Point(4, 34);
		tabPage16.set_Location(location);
		((Control)TabPage10).set_Name("TabPage10");
		TabPage tabPage17 = TabPage10;
		((Padding)(ref val))._002Ector(3);
		((Control)tabPage17).set_Padding(val);
		TabPage tabPage18 = TabPage10;
		size = new Size(925, 444);
		((Control)tabPage18).set_Size(size);
		TabPage10.set_TabIndex(3);
		TabPage10.set_Text("Gerenciador de Tarefas");
		TabPage10.set_UseVisualStyleBackColor(true);
		ListViewGerenciadorTarefa.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[5] { ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5 });
		((Control)ListViewGerenciadorTarefa).set_Dock((DockStyle)5);
		((Control)ListViewGerenciadorTarefa).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		ListViewGerenciadorTarefa.set_GridLines(true);
		ListView listViewGerenciadorTarefa = ListViewGerenciadorTarefa;
		location = new Point(3, 30);
		((Control)listViewGerenciadorTarefa).set_Location(location);
		ListViewGerenciadorTarefa.set_MultiSelect(false);
		((Control)ListViewGerenciadorTarefa).set_Name("ListViewGerenciadorTarefa");
		ListView listViewGerenciadorTarefa2 = ListViewGerenciadorTarefa;
		size = new Size(919, 389);
		((Control)listViewGerenciadorTarefa2).set_Size(size);
		((Control)ListViewGerenciadorTarefa).set_TabIndex(1000000002);
		ListViewGerenciadorTarefa.set_UseCompatibleStateImageBehavior(false);
		ListViewGerenciadorTarefa.set_View((View)1);
		ColumnHeader1.set_Text("Nome:");
		ColumnHeader1.set_Width(200);
		ColumnHeader2.set_Text("Memória:");
		ColumnHeader2.set_Width(109);
		ColumnHeader3.set_Text("Trabalhar:");
		ColumnHeader3.set_Width(122);
		ColumnHeader4.set_Text("Inicializado e Data:");
		ColumnHeader4.set_Width(183);
		ColumnHeader5.set_Text("ID:");
		ColumnHeader5.set_Width(187);
		((ToolStrip)StatusGeretaref).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolStripStatusLabel1,
			(ToolStripItem)ToolStripStatusLabelGerenciadorTarefa
		});
		StatusStrip statusGeretaref = StatusGeretaref;
		location = new Point(3, 419);
		((Control)statusGeretaref).set_Location(location);
		((Control)StatusGeretaref).set_Name("StatusGeretaref");
		StatusStrip statusGeretaref2 = StatusGeretaref;
		size = new Size(919, 22);
		((Control)statusGeretaref2).set_Size(size);
		((Control)StatusGeretaref).set_TabIndex(1000000001);
		((Control)StatusGeretaref).set_Text("StatusStrip1");
		((ToolStripItem)ToolStripStatusLabel1).set_Name("ToolStripStatusLabel1");
		ToolStripStatusLabel toolStripStatusLabel = ToolStripStatusLabel1;
		size = new Size(97, 17);
		((ToolStripItem)toolStripStatusLabel).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel1).set_Text("Total de Arquivo:");
		((ToolStripItem)ToolStripStatusLabelGerenciadorTarefa).set_Name("ToolStripStatusLabelGerenciadorTarefa");
		ToolStripStatusLabel toolStripStatusLabelGerenciadorTarefa = ToolStripStatusLabelGerenciadorTarefa;
		size = new Size(19, 17);
		((ToolStripItem)toolStripStatusLabelGerenciadorTarefa).set_Size(size);
		((ToolStripItem)ToolStripStatusLabelGerenciadorTarefa).set_Text("00");
		((ToolStrip)MenuStrip1).set_Font(new Font("Times New Roman", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ToolStrip)MenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)AtualizarToolStripMenuItem,
			(ToolStripItem)FonteToolStripMenuItem,
			(ToolStripItem)FecharAplicativoToolStripMenuItem,
			(ToolStripItem)LimparTudoToolStripMenuItem
		});
		MenuStrip menuStrip = MenuStrip1;
		location = new Point(3, 3);
		((Control)menuStrip).set_Location(location);
		((Control)MenuStrip1).set_Name("MenuStrip1");
		MenuStrip menuStrip2 = MenuStrip1;
		size = new Size(919, 27);
		((Control)menuStrip2).set_Size(size);
		((Control)MenuStrip1).set_TabIndex(6);
		((Control)MenuStrip1).set_Text("MenuStrip1");
		((ToolStripItem)AtualizarToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("AtualizarToolStripMenuItem.Image"));
		((ToolStripItem)AtualizarToolStripMenuItem).set_Name("AtualizarToolStripMenuItem");
		ToolStripMenuItem atualizarToolStripMenuItem = AtualizarToolStripMenuItem;
		size = new Size(97, 23);
		((ToolStripItem)atualizarToolStripMenuItem).set_Size(size);
		((ToolStripItem)AtualizarToolStripMenuItem).set_Text("Atualizar");
		((ToolStripItem)FonteToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("FonteToolStripMenuItem.Image"));
		((ToolStripItem)FonteToolStripMenuItem).set_Name("FonteToolStripMenuItem");
		ToolStripMenuItem fonteToolStripMenuItem = FonteToolStripMenuItem;
		size = new Size(75, 23);
		((ToolStripItem)fonteToolStripMenuItem).set_Size(size);
		((ToolStripItem)FonteToolStripMenuItem).set_Text("Fonte");
		((ToolStripItem)FecharAplicativoToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("FecharAplicativoToolStripMenuItem.Image"));
		((ToolStripItem)FecharAplicativoToolStripMenuItem).set_Name("FecharAplicativoToolStripMenuItem");
		ToolStripMenuItem fecharAplicativoToolStripMenuItem = FecharAplicativoToolStripMenuItem;
		size = new Size(153, 23);
		((ToolStripItem)fecharAplicativoToolStripMenuItem).set_Size(size);
		((ToolStripItem)FecharAplicativoToolStripMenuItem).set_Text("Fechar Aplicativo");
		((ToolStripItem)LimparTudoToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("LimparTudoToolStripMenuItem.Image"));
		((ToolStripItem)LimparTudoToolStripMenuItem).set_Name("LimparTudoToolStripMenuItem");
		ToolStripMenuItem limparTudoToolStripMenuItem = LimparTudoToolStripMenuItem;
		size = new Size(122, 23);
		((ToolStripItem)limparTudoToolStripMenuItem).set_Size(size);
		((ToolStripItem)LimparTudoToolStripMenuItem).set_Text("Limpar Tudo");
		((Control)TabPage3).get_Controls().Add((Control)(object)TabControl3);
		TabPage tabPage19 = TabPage3;
		location = new Point(4, 34);
		tabPage19.set_Location(location);
		((Control)TabPage3).set_Name("TabPage3");
		TabPage tabPage20 = TabPage3;
		((Padding)(ref val))._002Ector(3);
		((Control)tabPage20).set_Padding(val);
		TabPage tabPage21 = TabPage3;
		size = new Size(939, 488);
		((Control)tabPage21).set_Size(size);
		TabPage3.set_TabIndex(2);
		TabPage3.set_Text(" AGENDA E QUARENTENA");
		TabPage3.set_UseVisualStyleBackColor(true);
		((Control)TabControl3).get_Controls().Add((Control)(object)TabPage7);
		((Control)TabControl3).get_Controls().Add((Control)(object)TabPage8);
		((Control)TabControl3).get_Controls().Add((Control)(object)TabPage9);
		((Control)TabControl3).set_Dock((DockStyle)5);
		TabControl tabControl5 = TabControl3;
		location = new Point(3, 3);
		((Control)tabControl5).set_Location(location);
		((Control)TabControl3).set_Name("TabControl3");
		TabControl3.set_SelectedIndex(0);
		TabControl tabControl6 = TabControl3;
		size = new Size(933, 482);
		((Control)tabControl6).set_Size(size);
		((Control)TabControl3).set_TabIndex(0);
		((Control)TabPage7).get_Controls().Add((Control)(object)GroupBox4);
		TabPage tabPage22 = TabPage7;
		location = new Point(4, 34);
		tabPage22.set_Location(location);
		((Control)TabPage7).set_Name("TabPage7");
		TabPage tabPage23 = TabPage7;
		((Padding)(ref val))._002Ector(3);
		((Control)tabPage23).set_Padding(val);
		TabPage tabPage24 = TabPage7;
		size = new Size(925, 444);
		((Control)tabPage24).set_Size(size);
		TabPage7.set_TabIndex(0);
		TabPage7.set_Text("Fazer-o Agendamento");
		TabPage7.set_UseVisualStyleBackColor(true);
		((Control)GroupBox4).get_Controls().Add((Control)(object)Label15);
		((Control)GroupBox4).get_Controls().Add((Control)(object)ComboBox1);
		((Control)GroupBox4).get_Controls().Add((Control)(object)Button6);
		((Control)GroupBox4).get_Controls().Add((Control)(object)Button5);
		((Control)GroupBox4).get_Controls().Add((Control)(object)Label14);
		((Control)GroupBox4).get_Controls().Add((Control)(object)TextBoxAgendaAnos);
		((Control)GroupBox4).get_Controls().Add((Control)(object)Label13);
		((Control)GroupBox4).get_Controls().Add((Control)(object)TextBoxAgendaMes);
		((Control)GroupBox4).get_Controls().Add((Control)(object)Label12);
		((Control)GroupBox4).get_Controls().Add((Control)(object)TextBoxAgendaDias);
		((Control)GroupBox4).get_Controls().Add((Control)(object)Label11);
		((Control)GroupBox4).get_Controls().Add((Control)(object)Label10);
		((Control)GroupBox4).get_Controls().Add((Control)(object)Label9);
		((Control)GroupBox4).get_Controls().Add((Control)(object)TextBoxAgendaHoras);
		((Control)GroupBox4).get_Controls().Add((Control)(object)TextBoxAgendaMinutos);
		((Control)GroupBox4).get_Controls().Add((Control)(object)TextBoxAgendaSegundos);
		((Control)GroupBox4).set_Dock((DockStyle)5);
		GroupBox groupBox11 = GroupBox4;
		location = new Point(3, 3);
		((Control)groupBox11).set_Location(location);
		((Control)GroupBox4).set_Name("GroupBox4");
		GroupBox groupBox12 = GroupBox4;
		size = new Size(919, 438);
		((Control)groupBox12).set_Size(size);
		((Control)GroupBox4).set_TabIndex(0);
		GroupBox4.set_TabStop(false);
		GroupBox4.set_Text("Fazer Agendamento");
		Label15.set_AutoSize(true);
		Label label27 = Label15;
		location = new Point(92, 233);
		((Control)label27).set_Location(location);
		((Control)Label15).set_Name("Label15");
		Label label28 = Label15;
		size = new Size(60, 25);
		((Control)label28).set_Size(size);
		((Control)Label15).set_TabIndex(15);
		Label15.set_Text("Tipo:");
		ComboBox1.set_DropDownStyle((ComboBoxStyle)2);
		ComboBox1.set_FlatStyle((FlatStyle)3);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		ComboBox1.get_Items().AddRange(new object[2] { "Fazer Varredura Completa", "Fazer Varredura Personalizada" });
		ComboBox comboBox = ComboBox1;
		location = new Point(169, 230);
		((Control)comboBox).set_Location(location);
		((Control)ComboBox1).set_Name("ComboBox1");
		ComboBox comboBox2 = ComboBox1;
		size = new Size(690, 33);
		((Control)comboBox2).set_Size(size);
		((Control)ComboBox1).set_TabIndex(14);
		Button button9 = Button6;
		location = new Point(285, 311);
		((Control)button9).set_Location(location);
		((Control)Button6).set_Name("Button6");
		Button button10 = Button6;
		size = new Size(259, 51);
		((Control)button10).set_Size(size);
		((Control)Button6).set_TabIndex(13);
		((ButtonBase)Button6).set_Text("Limpar Tudo");
		((ButtonBase)Button6).set_UseVisualStyleBackColor(true);
		Button button11 = Button5;
		location = new Point(565, 311);
		((Control)button11).set_Location(location);
		((Control)Button5).set_Name("Button5");
		Button button12 = Button5;
		size = new Size(259, 51);
		((Control)button12).set_Size(size);
		((Control)Button5).set_TabIndex(12);
		((ButtonBase)Button5).set_Text("Salvar Agora e OK");
		((ButtonBase)Button5).set_UseVisualStyleBackColor(true);
		Label14.set_AutoSize(true);
		Label label29 = Label14;
		location = new Point(487, 172);
		((Control)label29).set_Location(location);
		((Control)Label14).set_Name("Label14");
		Label label30 = Label14;
		size = new Size(61, 25);
		((Control)label30).set_Size(size);
		((Control)Label14).set_TabIndex(11);
		Label14.set_Text("Anos");
		TextBox textBoxAgendaAnos = TextBoxAgendaAnos;
		location = new Point(562, 166);
		((Control)textBoxAgendaAnos).set_Location(location);
		((Control)TextBoxAgendaAnos).set_Name("TextBoxAgendaAnos");
		TextBox textBoxAgendaAnos2 = TextBoxAgendaAnos;
		size = new Size(297, 31);
		((Control)textBoxAgendaAnos2).set_Size(size);
		((Control)TextBoxAgendaAnos).set_TabIndex(10);
		Label13.set_AutoSize(true);
		Label label31 = Label13;
		location = new Point(487, 120);
		((Control)label31).set_Location(location);
		((Control)Label13).set_Name("Label13");
		Label label32 = Label13;
		size = new Size(53, 25);
		((Control)label32).set_Size(size);
		((Control)Label13).set_TabIndex(9);
		Label13.set_Text("Mês");
		TextBox textBoxAgendaMes = TextBoxAgendaMes;
		location = new Point(562, 114);
		((Control)textBoxAgendaMes).set_Location(location);
		((Control)TextBoxAgendaMes).set_Name("TextBoxAgendaMes");
		TextBox textBoxAgendaMes2 = TextBoxAgendaMes;
		size = new Size(297, 31);
		((Control)textBoxAgendaMes2).set_Size(size);
		((Control)TextBoxAgendaMes).set_TabIndex(8);
		Label12.set_AutoSize(true);
		Label label33 = Label12;
		location = new Point(487, 61);
		((Control)label33).set_Location(location);
		((Control)Label12).set_Name("Label12");
		Label label34 = Label12;
		size = new Size(55, 25);
		((Control)label34).set_Size(size);
		((Control)Label12).set_TabIndex(7);
		Label12.set_Text("Dias");
		TextBox textBoxAgendaDias = TextBoxAgendaDias;
		location = new Point(562, 55);
		((Control)textBoxAgendaDias).set_Location(location);
		((Control)TextBoxAgendaDias).set_Name("TextBoxAgendaDias");
		TextBox textBoxAgendaDias2 = TextBoxAgendaDias;
		size = new Size(297, 31);
		((Control)textBoxAgendaDias2).set_Size(size);
		((Control)TextBoxAgendaDias).set_TabIndex(6);
		Label11.set_AutoSize(true);
		Label label35 = Label11;
		location = new Point(83, 171);
		((Control)label35).set_Location(location);
		((Control)Label11).set_Name("Label11");
		Label label36 = Label11;
		size = new Size(69, 25);
		((Control)label36).set_Size(size);
		((Control)Label11).set_TabIndex(5);
		Label11.set_Text("Horas");
		Label10.set_AutoSize(true);
		Label label37 = Label10;
		location = new Point(64, 112);
		((Control)label37).set_Location(location);
		((Control)Label10).set_Name("Label10");
		Label label38 = Label10;
		size = new Size(88, 25);
		((Control)label38).set_Size(size);
		((Control)Label10).set_TabIndex(4);
		Label10.set_Text("Minutos");
		Label9.set_AutoSize(true);
		Label label39 = Label9;
		location = new Point(43, 55);
		((Control)label39).set_Location(location);
		((Control)Label9).set_Name("Label9");
		Label label40 = Label9;
		size = new Size(109, 25);
		((Control)label40).set_Size(size);
		((Control)Label9).set_TabIndex(3);
		Label9.set_Text("Segundos");
		TextBox textBoxAgendaHoras = TextBoxAgendaHoras;
		location = new Point(169, 165);
		((Control)textBoxAgendaHoras).set_Location(location);
		((Control)TextBoxAgendaHoras).set_Name("TextBoxAgendaHoras");
		TextBox textBoxAgendaHoras2 = TextBoxAgendaHoras;
		size = new Size(297, 31);
		((Control)textBoxAgendaHoras2).set_Size(size);
		((Control)TextBoxAgendaHoras).set_TabIndex(2);
		TextBox textBoxAgendaMinutos = TextBoxAgendaMinutos;
		location = new Point(169, 109);
		((Control)textBoxAgendaMinutos).set_Location(location);
		((Control)TextBoxAgendaMinutos).set_Name("TextBoxAgendaMinutos");
		TextBox textBoxAgendaMinutos2 = TextBoxAgendaMinutos;
		size = new Size(297, 31);
		((Control)textBoxAgendaMinutos2).set_Size(size);
		((Control)TextBoxAgendaMinutos).set_TabIndex(1);
		TextBox textBoxAgendaSegundos = TextBoxAgendaSegundos;
		location = new Point(169, 52);
		((Control)textBoxAgendaSegundos).set_Location(location);
		((Control)TextBoxAgendaSegundos).set_Name("TextBoxAgendaSegundos");
		TextBox textBoxAgendaSegundos2 = TextBoxAgendaSegundos;
		size = new Size(297, 31);
		((Control)textBoxAgendaSegundos2).set_Size(size);
		((Control)TextBoxAgendaSegundos).set_TabIndex(0);
		((Control)TabPage8).get_Controls().Add((Control)(object)ListBox3);
		((Control)TabPage8).get_Controls().Add((Control)(object)ListBox2);
		((Control)TabPage8).get_Controls().Add((Control)(object)Button3);
		TabPage tabPage25 = TabPage8;
		location = new Point(4, 34);
		tabPage25.set_Location(location);
		((Control)TabPage8).set_Name("TabPage8");
		TabPage tabPage26 = TabPage8;
		((Padding)(ref val))._002Ector(3);
		((Control)tabPage26).set_Padding(val);
		TabPage tabPage27 = TabPage8;
		size = new Size(925, 444);
		((Control)tabPage27).set_Size(size);
		TabPage8.set_TabIndex(1);
		TabPage8.set_Text("Lista de Vírus na Estrutura de Quarentena");
		TabPage8.set_UseVisualStyleBackColor(true);
		((ListControl)ListBox3).set_FormattingEnabled(true);
		ListBox3.set_ItemHeight(25);
		ListBox listBox = ListBox3;
		location = new Point(16, 317);
		((Control)listBox).set_Location(location);
		((Control)ListBox3).set_Name("ListBox3");
		ListBox listBox2 = ListBox3;
		size = new Size(120, 79);
		((Control)listBox2).set_Size(size);
		((Control)ListBox3).set_TabIndex(4);
		((Control)ListBox3).set_Visible(false);
		((Control)ListBox2).set_Dock((DockStyle)5);
		((ListControl)ListBox2).set_FormattingEnabled(true);
		ListBox2.set_HorizontalScrollbar(true);
		ListBox2.set_ItemHeight(25);
		ListBox listBox3 = ListBox2;
		location = new Point(3, 3);
		((Control)listBox3).set_Location(location);
		((Control)ListBox2).set_Name("ListBox2");
		ListBox2.set_ScrollAlwaysVisible(true);
		ListBox listBox4 = ListBox2;
		size = new Size(919, 393);
		((Control)listBox4).set_Size(size);
		((Control)ListBox2).set_TabIndex(3);
		((Control)Button3).set_Dock((DockStyle)2);
		Button button13 = Button3;
		location = new Point(3, 396);
		((Control)button13).set_Location(location);
		((Control)Button3).set_Name("Button3");
		Button button14 = Button3;
		size = new Size(919, 45);
		((Control)button14).set_Size(size);
		((Control)Button3).set_TabIndex(2);
		((Control)Button3).set_Tag((object)"Remover Agora");
		((ButtonBase)Button3).set_Text("Remover Agora");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		((Control)TabPage9).get_Controls().Add((Control)(object)ListBox1);
		TabPage tabPage28 = TabPage9;
		location = new Point(4, 34);
		tabPage28.set_Location(location);
		((Control)TabPage9).set_Name("TabPage9");
		TabPage tabPage29 = TabPage9;
		((Padding)(ref val))._002Ector(3);
		((Control)tabPage29).set_Padding(val);
		TabPage tabPage30 = TabPage9;
		size = new Size(925, 444);
		((Control)tabPage30).set_Size(size);
		TabPage9.set_TabIndex(2);
		TabPage9.set_Text("Agenda de Eventos");
		TabPage9.set_UseVisualStyleBackColor(true);
		((Control)ListBox1).set_Dock((DockStyle)5);
		((ListControl)ListBox1).set_FormattingEnabled(true);
		ListBox1.set_HorizontalScrollbar(true);
		ListBox1.set_ItemHeight(25);
		ListBox listBox5 = ListBox1;
		location = new Point(3, 3);
		((Control)listBox5).set_Location(location);
		((Control)ListBox1).set_Name("ListBox1");
		ListBox listBox6 = ListBox1;
		size = new Size(919, 438);
		((Control)listBox6).set_Size(size);
		((Control)ListBox1).set_TabIndex(2);
		Timer1.set_Interval(1);
		FolderBrowserDialog1.set_Description("SATWNEYT:  .POR FAVOR, SELECIONE O ARQUIVO CORRETAMENTE E CLIQUE NO BOTÃO CONFIMAR PARA PROGREDIR O PROCESSO DE PERSONALIZADO.");
		crotime.set_Interval(1000);
		Timer2.set_Interval(12);
		NotPause.set_Enabled(true);
		NotPause.set_Interval(1);
		Timer2s.set_Interval(1);
		FolderBrowserDialog2.set_Description("SATWNEYT:  .POR FAVOR, SELECIONE O ARQUIVO CORRETAMENTE E CLIQUE NO BOTÃO CONFIMAR PARA PROGREDIR O PROCESSO DE PERSONALIZADO.");
		TimeFileCopy.set_Interval(2);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(947, 595);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)TabControl1);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		size = new Size(963, 634);
		((Form)this).set_MaximumSize(size);
		size = new Size(963, 634);
		((Form)this).set_MinimumSize(size);
		((Control)this).set_Name("Tools0");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("SATWNEYT FERRAMENTA PLUS ONE-X");
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)PanelGerCopy).ResumeLayout(false);
		((Control)PanelGerCopy).PerformLayout();
		((ISupportInitialize)NuGer).EndInit();
		((ISupportInitialize)PictureBox8).EndInit();
		((Control)TabControl1).ResumeLayout(false);
		((Control)TabPage1).ResumeLayout(false);
		((Control)TabPage1).PerformLayout();
		((Control)GroupBox2).ResumeLayout(false);
		((Control)GroupBox2).PerformLayout();
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)TrackBar1).EndInit();
		((Control)TabPage2).ResumeLayout(false);
		((Control)TabControl2).ResumeLayout(false);
		((Control)TabPage4).ResumeLayout(false);
		((Control)GroupBox3).ResumeLayout(false);
		((Control)GroupBox1).ResumeLayout(false);
		((Control)TabPage5).ResumeLayout(false);
		((Control)TabPage5).PerformLayout();
		((Control)PanelGen).ResumeLayout(false);
		((Control)PanelGen).PerformLayout();
		((Control)TabPage6).ResumeLayout(false);
		((Control)TabPage6).PerformLayout();
		((Control)GroupBox5).ResumeLayout(false);
		((Control)GroupBox6).ResumeLayout(false);
		((Control)GroupBox6).PerformLayout();
		((Control)TabPage10).ResumeLayout(false);
		((Control)TabPage10).PerformLayout();
		((Control)StatusGeretaref).ResumeLayout(false);
		((Control)StatusGeretaref).PerformLayout();
		((Control)MenuStrip1).ResumeLayout(false);
		((Control)MenuStrip1).PerformLayout();
		((Control)TabPage3).ResumeLayout(false);
		((Control)TabControl3).ResumeLayout(false);
		((Control)TabPage7).ResumeLayout(false);
		((Control)GroupBox4).ResumeLayout(false);
		((Control)GroupBox4).PerformLayout();
		((Control)TabPage8).ResumeLayout(false);
		((Control)TabPage9).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	public object GenerateCode()
	{
		int num = 0;
		string text = "";
		string text2 = "1234567890";
		string text3 = "abcdefghijklmnopqrstuvwxyz";
		string text4 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		int result = 1;
		if (G2.get_Checked())
		{
			text += text2;
		}
		if (G1.get_Checked())
		{
			text += text3;
		}
		if (G3.get_Checked())
		{
			text += text4;
		}
		int num2 = Strings.Len(text);
		int.TryParse(NuGer.get_Text(), out result);
		VBMath.Randomize();
		string text5 = "";
		int num3 = result;
		num = 1;
		checked
		{
			while (true)
			{
				int num4 = num;
				int num5 = num3;
				if (num4 > num5)
				{
					break;
				}
				int num6 = (int)Math.Round(Conversion.Int(VBMath.Rnd() * (float)num2) + 1f);
				text5 += Strings.Mid(text, num6, 1);
				num++;
			}
			return text5;
		}
	}

	private void downloadconcluido(object sender, AsyncCompletedEventArgs e)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected I4, but got Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		if (!((ProgressCopyGen.get_Value() == ProgressCopyGen.get_Maximum()) & ((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(Gentext2.get_Text()) & LabelGenStatus.get_Text().Contains("100")))
		{
			return;
		}
		TimeFileCopy.Stop();
		Interaction.MsgBox((object)"Concluído.\r\nArquivo foram copiado com sucesso !!!", (MsgBoxStyle)64, (object)null);
		TimeFileCopy.Stop();
		TimeFileCopy.set_Enabled(false);
		ProgressCopyGen.set_Value(0);
		try
		{
			httpclient.CancelAsync();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		LabelGenStatus.set_Text("0%");
		((Control)PanelGen).set_Visible(false);
		try
		{
			switch (Interaction.MsgBox((object)"Deseja abrir a cópia do seu novo arquivo?", (MsgBoxStyle)68, (object)null) - 1)
			{
			case 0:
			{
				Process process3 = new Process();
				Process process4 = process3;
				process4.StartInfo.FileName = Gentext2.get_Text();
				try
				{
					httpclient.CancelAsync();
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				process4.Start();
				ProgressCopyGen.set_Value(ProgressCopyGen.get_Minimum());
				((Control)PanelGen).set_Visible(false);
				LabelGenStatus.set_Text("0%");
				process4 = null;
				break;
			}
			case 5:
			{
				Process process = new Process();
				Process process2 = process;
				process2.StartInfo.FileName = Gentext2.get_Text();
				process2.Start();
				ProgressCopyGen.set_Value(0);
				((Control)PanelGen).set_Visible(false);
				LabelGenStatus.set_Text("0%");
				try
				{
					httpclient.CancelAsync();
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				process2 = null;
				break;
			}
			case 1:
			case 2:
			case 3:
			case 4:
				break;
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			try
			{
				httpclient.CancelAsync();
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
			TimeFileCopy.Stop();
			((Control)PanelGen).set_Visible(false);
			Interaction.MsgBox((object)("ERROR: " + Conversion.ErrorToString()), (MsgBoxStyle)48, (object)null);
			GenText1.set_Text("");
			Gentext2.set_Text("c:\\");
			ProjectData.ClearProjectError();
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_149c: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d8: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (Operators.CompareString(detected.get_Text(), "0", false) == 0)
			{
				((Control)detected).set_ForeColor(Color.Black);
			}
			else
			{
				((Control)detected).set_ForeColor(Color.Red);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ProgressBarScanner.set_Maximum(Conversions.ToInteger(Conversions.ToString(ListBox1.get_Items().get_Count())));
		total.set_Text(Conversions.ToString(ListBox1.get_Items().get_Count()));
		if ((ProgressBarScanner.get_Value() != ProgressBarScanner.get_Maximum()) | (ProgressBarScanner.get_Value() == ProgressBarScanner.get_Minimum()))
		{
			try
			{
				ListBox listBox = ListBox1;
				listBox.set_SelectedIndex(checked(listBox.get_SelectedIndex() + 1));
				ListBox1.set_MultiColumn(false);
				TextBoxScanner.set_Text(ListBox1.get_SelectedItem().ToString());
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			detected.set_Text(Conversions.ToString(ListBox3.get_Items().get_Count()));
			files.set_Text(Conversions.ToString(ProgressBarScanner.get_Value()));
			try
			{
				ProgressBarScanner.Increment(ListBox1.get_SelectedIndex());
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			try
			{
				TextBox val = new TextBox();
				detected.set_Text(Conversions.ToString(ListBox2.get_Items().get_Count()));
				files.set_Text(Conversions.ToString(ProgressBarScanner.get_Value()));
				MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
				FileStream fileStream = new FileStream(TextBoxScanner.get_Text(), FileMode.Open, FileAccess.Read, FileShare.Read, 8192);
				fileStream = new FileStream(TextBoxScanner.get_Text(), FileMode.Open, FileAccess.Read, FileShare.Read, 8192);
				mD5CryptoServiceProvider.ComputeHash(fileStream);
				byte[] hash = mD5CryptoServiceProvider.Hash;
				StringBuilder stringBuilder = new StringBuilder();
				byte[] array = hash;
				foreach (byte b in array)
				{
					stringBuilder.Append($"{b:X2}");
				}
				TextBox val2 = new TextBox();
				TextBox val3 = new TextBox();
				ListBox1.get_Items().Add((object)TextBoxScanner.get_Text());
				try
				{
					if (!(TextBoxScanner.get_Text().Contains("C:\\windows\\explorer.exe") | TextBoxScanner.get_Text().Contains("atwney") | TextBoxScanner.get_Text().Contains("ATWNEY") | TextBoxScanner.get_Text().Contains("CNext") | TextBoxScanner.get_Text().Contains("Massahiro") | TextBoxScanner.get_Text().Contains("HDFEWAR")))
					{
						val3.set_Text(((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(TextBoxScanner.get_Text()));
					}
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
				if ((val3.get_Text().Contains("-S-C") & val3.get_Text().Contains("CHO") & val3.get_Text().Contains("@") & val3.get_Text().Contains("XIT") & val3.get_Text().Contains("O")) | (val3.get_Text().Contains("cho") & val3.get_Text().Contains("@") & val3.get_Text().Contains("xit") & val3.get_Text().Contains("o")))
				{
					val2.set_Text("Trojan");
					ListBox3.get_Items().Add((object)TextBoxScanner.get_Text());
					try
					{
						if (!ListBox2.get_Items().Contains((object)(TextBoxScanner.get_Text() + " - Arquivo suspeito de " + val2.get_Text())))
						{
							ListBox2.get_Items().Add(Operators.ConcatenateObject(Operators.ConcatenateObject(ListBox1.get_SelectedItem(), (object)" - Arquivo suspeito de "), (object)val2.get_Text()));
						}
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						ProjectData.ClearProjectError();
					}
				}
				if ((val3.get_Text().Contains("CHO") & val3.get_Text().Contains("@") & val3.get_Text().Contains(":") & val3.get_Text().Contains("OTO") & val3.get_Text().Contains("TAR") & val3.get_Text().Contains(".")) | (val3.get_Text().Contains("cho") & val3.get_Text().Contains("@") & val3.get_Text().Contains(":") & val3.get_Text().Contains("oto") & val3.get_Text().Contains("tar") & val3.get_Text().Contains(".")))
				{
					val2.set_Text("Bomba-Relógio");
					ListBox3.get_Items().Add((object)TextBoxScanner.get_Text());
					try
					{
						if (!ListBox2.get_Items().Contains((object)(TextBoxScanner.get_Text() + " - Arquivo suspeito de " + val2.get_Text())))
						{
							ListBox2.get_Items().Add(Operators.ConcatenateObject(Operators.ConcatenateObject(ListBox1.get_SelectedItem(), (object)" - Arquivo suspeito de "), (object)val2.get_Text()));
						}
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						ProjectData.ClearProjectError();
					}
				}
				if (val3.get_Text().Contains("eicar") | val3.get_Text().Contains("EICAR") | (val3.get_Text().Contains("DOWN") & val3.get_Text().Contains("@") & val3.get_Text().Contains(":") & val3.get_Text().Contains("W") & val3.get_Text().Contains("-") & val3.get_Text().Contains("t")))
				{
					val2.set_Text("Malware");
					ListBox3.get_Items().Add((object)TextBoxScanner.get_Text());
					try
					{
						if (!ListBox2.get_Items().Contains((object)(TextBoxScanner.get_Text() + " - Arquivo suspeito de " + val2.get_Text())))
						{
							ListBox2.get_Items().Add(Operators.ConcatenateObject(Operators.ConcatenateObject(ListBox1.get_SelectedItem(), (object)" - Arquivo suspeito de "), (object)val2.get_Text()));
						}
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						ProjectData.ClearProjectError();
					}
				}
				if (!val3.get_Text().Contains("pp") & val3.get_Text().Contains("@e") & val3.get_Text().Contains(".d") & val3.get_Text().Contains("AT") & val3.get_Text().Contains("O") & val3.get_Text().Contains("-") & val3.get_Text().Contains("ll") & val3.get_Text().Contains("t"))
				{
					val2.set_Text("Blackdoor");
					ListBox3.get_Items().Add((object)TextBoxScanner.get_Text());
					try
					{
						if (!ListBox2.get_Items().Contains((object)(TextBoxScanner.get_Text() + " - Arquivo suspeito de " + val2.get_Text())))
						{
							ListBox2.get_Items().Add(Operators.ConcatenateObject(Operators.ConcatenateObject(ListBox1.get_SelectedItem(), (object)" - Arquivo suspeito de "), (object)val2.get_Text()));
						}
					}
					catch (Exception projectError8)
					{
						ProjectData.SetProjectError(projectError8);
						ProjectData.ClearProjectError();
					}
				}
				if ((val3.get_Text().Contains(".msi") & val3.get_Text().Contains(".MSI") & val3.get_Text().Contains("@ec") & val3.get_Text().Contains("-")) | (val3.get_Text().Contains(".q3q") & val3.get_Text().Contains("$360")))
				{
					val2.set_Text("Veralware");
					ListBox3.get_Items().Add((object)TextBoxScanner.get_Text());
					try
					{
						if (!ListBox2.get_Items().Contains((object)(TextBoxScanner.get_Text() + " - Arquivo suspeito de " + val2.get_Text())))
						{
							ListBox2.get_Items().Add(Operators.ConcatenateObject(Operators.ConcatenateObject(ListBox1.get_SelectedItem(), (object)" - Arquivo suspeito de "), (object)val2.get_Text()));
						}
					}
					catch (Exception projectError9)
					{
						ProjectData.SetProjectError(projectError9);
						ProjectData.ClearProjectError();
					}
				}
				if ((val3.get_Text().Contains(":ASM.") & val3.get_Text().Contains("RN:") & val3.get_Text().Contains("OKEN=")) | (val3.get_Text().Contains(":asm.") & val3.get_Text().Contains("rn:") & val3.get_Text().Contains("oken=")) | (val3.get_Text().Contains(":asm.v2") & val3.get_Text().Contains("rn:schemas") & val3.get_Text().Contains("publicKeyToken=")) | (val3.get_Text().Contains(":asm.v1") & val3.get_Text().Contains("rn:schemas") & val3.get_Text().Contains("publicKeyToken=")) | (val3.get_Text().Contains("asInvoker") & val3.get_Text().Contains("processorArchitecture=") & val3.get_Text().Contains("*")))
				{
					val2.set_Text("Ramsonware");
					ListBox3.get_Items().Add((object)TextBoxScanner.get_Text());
					try
					{
						if (!ListBox2.get_Items().Contains((object)(TextBoxScanner.get_Text() + " - Arquivo suspeito de " + val2.get_Text())))
						{
							ListBox2.get_Items().Add(Operators.ConcatenateObject(Operators.ConcatenateObject(ListBox1.get_SelectedItem(), (object)" - Arquivo suspeito de "), (object)val2.get_Text()));
						}
					}
					catch (Exception projectError10)
					{
						ProjectData.SetProjectError(projectError10);
						ProjectData.ClearProjectError();
					}
				}
				if (!val3.get_Text().Contains(".ico") & !val3.get_Text().Contains(".j") & !val3.get_Text().Contains(".p") & val3.get_Text().Contains("y@") & val3.get_Text().Contains("hw") & val3.get_Text().Contains("-s") & val3.get_Text().Contains(".z"))
				{
					val2.set_Text("Cookie");
					ListBox3.get_Items().Add((object)TextBoxScanner.get_Text());
					try
					{
						if (!ListBox2.get_Items().Contains((object)(TextBoxScanner.get_Text() + " - Arquivo suspeito de " + val2.get_Text())))
						{
							ListBox2.get_Items().Add(Operators.ConcatenateObject(Operators.ConcatenateObject(ListBox1.get_SelectedItem(), (object)" - Arquivo suspeito de "), (object)val2.get_Text()));
						}
					}
					catch (Exception projectError11)
					{
						ProjectData.SetProjectError(projectError11);
						ProjectData.ClearProjectError();
					}
				}
				if (val3.get_Text().Contains("5O!P%@AP[4\\P") | val3.get_Text().Contains("%@AP[4\\PZX54(P") | val3.get_Text().Contains("hutd") | val3.get_Text().Contains("HUTD"))
				{
					val2.set_Text("Vírus");
					ListBox3.get_Items().Add((object)TextBoxScanner.get_Text());
					try
					{
						if (!ListBox2.get_Items().Contains((object)(TextBoxScanner.get_Text() + " - Arquivo suspeito de " + val2.get_Text())))
						{
							ListBox2.get_Items().Add(Operators.ConcatenateObject(Operators.ConcatenateObject(ListBox1.get_SelectedItem(), (object)" - Arquivo suspeito de "), (object)val2.get_Text()));
						}
					}
					catch (Exception projectError12)
					{
						ProjectData.SetProjectError(projectError12);
						ProjectData.ClearProjectError();
					}
				}
				if (val3.get_Text().Contains("ms_") | val3.get_Text().Contains("run]") | val3.get_Text().Contains("iihihi") | val3.get_Text().Contains("uiiiu") | val3.get_Text().Contains("HKC") | val3.get_Text().Contains("%A%") | val3.get_Text().Contains("[") | val3.get_Text().Contains("lkbjhkbhk"))
				{
					val2.set_Text("Spyware");
					ListBox3.get_Items().Add((object)TextBoxScanner.get_Text());
					try
					{
						if (!ListBox2.get_Items().Contains((object)(TextBoxScanner.get_Text() + " - Arquivo suspeito de " + val2.get_Text())))
						{
							ListBox2.get_Items().Add(Operators.ConcatenateObject(Operators.ConcatenateObject(ListBox1.get_SelectedItem(), (object)" - Arquivo suspeito de "), (object)val2.get_Text()));
						}
					}
					catch (Exception projectError13)
					{
						ProjectData.SetProjectError(projectError13);
						ProjectData.ClearProjectError();
					}
				}
				if (val3.get_Text().Contains("CLS_") | val3.get_Text().Contains("_CLS") | val3.get_Text().Contains("ms_") | val3.get_Text().Contains("off") | val3.get_Text().Contains("[echo]") | val3.get_Text().Contains("DIRR>>") | val3.get_Text().Contains("TYPE_ENCHE") | val3.get_Text().Contains("RR>>GOTO") | val3.get_Text().Contains(">>ENCH"))
				{
					val2.set_Text("Worm (verme)");
					ListBox3.get_Items().Add((object)TextBoxScanner.get_Text());
					try
					{
						if (!ListBox2.get_Items().Contains((object)(TextBoxScanner.get_Text() + " - Arquivo suspeito de " + val2.get_Text())))
						{
							ListBox2.get_Items().Add(Operators.ConcatenateObject(Operators.ConcatenateObject(ListBox1.get_SelectedItem(), (object)" - Arquivo suspeito de "), (object)val2.get_Text()));
						}
					}
					catch (Exception projectError14)
					{
						ProjectData.SetProjectError(projectError14);
						ProjectData.ClearProjectError();
					}
				}
				if (val3.get_Text().Contains("mscomctl.ocx") | val3.get_Text().Contains("[autorun]") | val3.get_Text().Contains("del /s /q") | val3.get_Text().Contains("DEL /S /Q") | val3.get_Text().Contains("HKCU\\") | val3.get_Text().Contains("%A% V%A%") | val3.get_Text().Contains("[hkcu\\") | val3.get_Text().Contains("eokd"))
				{
					val2.set_Text("Rootkit");
					ListBox3.get_Items().Add((object)TextBoxScanner.get_Text());
					try
					{
						if (!ListBox2.get_Items().Contains((object)(TextBoxScanner.get_Text() + " - Arquivo suspeito de " + val2.get_Text())))
						{
							ListBox2.get_Items().Add(Operators.ConcatenateObject(Operators.ConcatenateObject(ListBox1.get_SelectedItem(), (object)" - Arquivo suspeito de "), (object)val2.get_Text()));
						}
					}
					catch (Exception projectError15)
					{
						ProjectData.SetProjectError(projectError15);
						ProjectData.ClearProjectError();
					}
				}
				if (!val.get_Text().Contains(stringBuilder.ToString()))
				{
					return;
				}
				try
				{
					if (!(ListBox2.get_Items().Contains((object)TextBoxScanner.get_Text()) | ListBox2.get_Items().Contains((object)(TextBoxScanner.get_Text() + " - Arquivo suspeito de " + val2.get_Text()))))
					{
						ListBox3.get_Items().Add((object)TextBoxScanner.get_Text());
						ListBox2.get_Items().Add(RuntimeHelpers.GetObjectValue(ListBox1.get_SelectedItem()));
					}
					return;
				}
				catch (Exception projectError16)
				{
					ProjectData.SetProjectError(projectError16);
					ProjectData.ClearProjectError();
					return;
				}
			}
			catch (Exception projectError17)
			{
				ProjectData.SetProjectError(projectError17);
				ProjectData.ClearProjectError();
				return;
			}
		}
		if ((ProgressBarScanner.get_Value() == ProgressBarScanner.get_Maximum()) | ((Operators.CompareString(Label7.get_Text(), "00:00:04", false) > 0) & (Operators.CompareString(TextBoxScanner.get_Text(), "C:\\", false) == 0)) | ((Operators.CompareString(Label7.get_Text(), "00:00:04", false) > 0) & (Operators.CompareString(TextBoxScanner.get_Text(), "", false) == 0)))
		{
			((Control)Button1).set_Enabled(true);
			((Control)Button2).set_Enabled(true);
			crotime.Stop();
			crotime.set_Enabled(false);
			hh = 0;
			mm = 0;
			ss = 0;
			Timer1.Stop();
			try
			{
				GroupBox2.set_Text("Opções de varredura");
			}
			catch (Exception projectError18)
			{
				ProjectData.SetProjectError(projectError18);
				ProjectData.ClearProjectError();
			}
			try
			{
				StreamWriter streamWriter = new StreamWriter("C:\\Satwneyt\\segundo.inf");
				streamWriter.Write("");
				streamWriter.Close();
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\segundo.inf");
			}
			catch (Exception projectError19)
			{
				ProjectData.SetProjectError(projectError19);
				ProjectData.ClearProjectError();
			}
			try
			{
				StreamWriter streamWriter2 = new StreamWriter("C:\\Satwneyt\\minuto.inf");
				streamWriter2.Write("");
				streamWriter2.Close();
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\minuto.inf");
			}
			catch (Exception projectError20)
			{
				ProjectData.SetProjectError(projectError20);
				ProjectData.ClearProjectError();
			}
			try
			{
				StreamWriter streamWriter3 = new StreamWriter("C:\\Satwneyt\\hora.inf");
				streamWriter3.Write("");
				streamWriter3.Close();
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\hora.inf");
			}
			catch (Exception projectError21)
			{
				ProjectData.SetProjectError(projectError21);
				ProjectData.ClearProjectError();
			}
			try
			{
				StreamWriter streamWriter4 = new StreamWriter("C:\\Satwneyt\\dia.inf");
				streamWriter4.Write("");
				streamWriter4.Close();
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\dia.inf");
			}
			catch (Exception projectError22)
			{
				ProjectData.SetProjectError(projectError22);
				ProjectData.ClearProjectError();
			}
			try
			{
				StreamWriter streamWriter5 = new StreamWriter("C:\\Satwneyt\\mes.inf");
				streamWriter5.Write("");
				streamWriter5.Close();
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\mes.inf");
			}
			catch (Exception projectError23)
			{
				ProjectData.SetProjectError(projectError23);
				ProjectData.ClearProjectError();
			}
			try
			{
				StreamWriter streamWriter6 = new StreamWriter("C:\\Satwneyt\\ano.inf");
				streamWriter6.Write("");
				streamWriter6.Close();
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\ano.inf");
			}
			catch (Exception projectError24)
			{
				ProjectData.SetProjectError(projectError24);
				ProjectData.ClearProjectError();
			}
			try
			{
				StreamWriter streamWriter7 = new StreamWriter("C:\\Satwneyt\\tdv.inf");
				streamWriter7.Write("");
				streamWriter7.Close();
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\tdv.inf");
			}
			catch (Exception projectError25)
			{
				ProjectData.SetProjectError(projectError25);
				ProjectData.ClearProjectError();
			}
			crotime.Start();
			crotime.set_Enabled(true);
			try
			{
				ProgressBarScanner.set_Value(ProgressBarScanner.get_Maximum());
			}
			catch (Exception projectError26)
			{
				ProjectData.SetProjectError(projectError26);
				ProjectData.ClearProjectError();
			}
			try
			{
				((Control)this).set_Enabled(true);
			}
			catch (Exception projectError27)
			{
				ProjectData.SetProjectError(projectError27);
				ProjectData.ClearProjectError();
			}
			((Form)this).set_Text("SATWNEYT Ferramenta Plus One-X Status: Varredura Concluída !");
			crotime.Stop();
			crotime.set_Enabled(false);
			Interaction.MsgBox((object)"Varredura concluída com sucesso !", (MsgBoxStyle)64, (object)null);
			MyProject.Forms.perso.Label1.set_Text("B");
			if (ListBox1.get_Items().get_Count() == 0)
			{
				Interaction.MsgBox((object)"Não há virus nesse computador. Por favor,feche a janela.", (MsgBoxStyle)64, (object)null);
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		((Form)this).set_Text("Por favor, Aguarde...");
		hh = Conversions.ToInteger("00");
		mm = Conversions.ToInteger("00");
		ss = Conversions.ToInteger("00");
		ProgressBarScanner.set_Value(ProgressBarScanner.get_Minimum());
		NotPause.set_Enabled(true);
		NotPause.Start();
		try
		{
			StreamWriter streamWriter = new StreamWriter("C:\\Satwneyt\\segundo.inf");
			streamWriter.Write("");
			streamWriter.Close();
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\segundo.inf");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			StreamWriter streamWriter2 = new StreamWriter("C:\\Satwneyt\\minuto.inf");
			streamWriter2.Write("");
			streamWriter2.Close();
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\minuto.inf");
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			StreamWriter streamWriter3 = new StreamWriter("C:\\Satwneyt\\hora.inf");
			streamWriter3.Write("");
			streamWriter3.Close();
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\hora.inf");
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			StreamWriter streamWriter4 = new StreamWriter("C:\\Satwneyt\\dia.inf");
			streamWriter4.Write("");
			streamWriter4.Close();
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\dia.inf");
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			StreamWriter streamWriter5 = new StreamWriter("C:\\Satwneyt\\mes.inf");
			streamWriter5.Write("");
			streamWriter5.Close();
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\mes.inf");
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			StreamWriter streamWriter6 = new StreamWriter("C:\\Satwneyt\\ano.inf");
			streamWriter6.Write("");
			streamWriter6.Close();
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\ano.inf");
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			StreamWriter streamWriter7 = new StreamWriter("C:\\Satwneyt\\tdv.inf");
			streamWriter7.Write("");
			streamWriter7.Close();
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		Label7.set_Text("00:00:00");
		crotime.Start();
		crotime.set_Enabled(true);
		try
		{
			ProgressBarScanner.set_Value(ProgressBarScanner.get_Minimum());
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		try
		{
			((Control)this).set_Enabled(true);
		}
		catch (Exception projectError9)
		{
			ProjectData.SetProjectError(projectError9);
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(((Form)this).get_Text(), "Por favor, Aguarde...", false) == 0)
		{
			((Control)Button1).set_Enabled(false);
		}
		if (!(!((Control)Button1).get_Enabled() & (Operators.CompareString(((Form)this).get_Text(), "Por favor, Aguarde...", false) == 0)))
		{
			return;
		}
		try
		{
			GroupBox2.set_Text("Fazer completo");
		}
		catch (Exception projectError10)
		{
			ProjectData.SetProjectError(projectError10);
			ProjectData.ClearProjectError();
		}
		try
		{
			detected.set_Text("0");
			((Control)detected).set_ForeColor(Color.Black);
		}
		catch (Exception projectError11)
		{
			ProjectData.SetProjectError(projectError11);
			ProjectData.ClearProjectError();
		}
		((Control)Button2).set_Enabled(false);
		FolderBrowserDialog1.set_SelectedPath("C:\\windows\\");
		checked
		{
			try
			{
				string[] directories = Directory.GetDirectories("C:\\");
				for (int i = 0; i < directories.Length; i++)
				{
					string[] array = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
					foreach (string text in array)
					{
						ListBox1.get_Items().Add((object)text);
					}
				}
			}
			catch (Exception projectError12)
			{
				ProjectData.SetProjectError(projectError12);
				ProjectData.ClearProjectError();
			}
			try
			{
				string[] directories2 = Directory.GetDirectories("C:\\");
				for (int k = 0; k < directories2.Length; k++)
				{
					string[] array2 = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Windows));
					foreach (string text2 in array2)
					{
						ListBox1.get_Items().Add((object)text2);
					}
				}
			}
			catch (Exception projectError13)
			{
				ProjectData.SetProjectError(projectError13);
				ProjectData.ClearProjectError();
			}
			try
			{
				string[] directories3 = Directory.GetDirectories("C:\\");
				for (int m = 0; m < directories3.Length; m++)
				{
					string[] array3 = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Cookies));
					foreach (string text3 in array3)
					{
						ListBox1.get_Items().Add((object)text3);
					}
				}
			}
			catch (Exception projectError14)
			{
				ProjectData.SetProjectError(projectError14);
				ProjectData.ClearProjectError();
			}
			try
			{
				string[] directories4 = Directory.GetDirectories("C:\\");
				for (int num = 0; num < directories4.Length; num++)
				{
					string[] array4 = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Programs));
					foreach (string text4 in array4)
					{
						ListBox1.get_Items().Add((object)text4);
					}
				}
			}
			catch (Exception projectError15)
			{
				ProjectData.SetProjectError(projectError15);
				ProjectData.ClearProjectError();
			}
			try
			{
				string[] directories5 = Directory.GetDirectories("C:\\");
				for (int num3 = 0; num3 < directories5.Length; num3++)
				{
					string[] array5 = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Recent));
					foreach (string text5 in array5)
					{
						ListBox1.get_Items().Add((object)text5);
					}
				}
			}
			catch (Exception projectError16)
			{
				ProjectData.SetProjectError(projectError16);
				ProjectData.ClearProjectError();
			}
			try
			{
				string[] directories6 = Directory.GetDirectories("C:\\");
				for (int num5 = 0; num5 < directories6.Length; num5++)
				{
					string[] array6 = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup));
					foreach (string text6 in array6)
					{
						ListBox1.get_Items().Add((object)text6);
					}
				}
			}
			catch (Exception projectError17)
			{
				ProjectData.SetProjectError(projectError17);
				ProjectData.ClearProjectError();
			}
			try
			{
				string[] directories7 = Directory.GetDirectories("C:\\");
				for (int num7 = 0; num7 < directories7.Length; num7++)
				{
					Directory.GetDirectories("C:\\");
					string[] array7 = Directory.GetFiles(Environment.GetFolderPath(unchecked((Environment.SpecialFolder)Conversions.ToInteger("C:\\progra~2\\"))));
					foreach (string text7 in array7)
					{
						ListBox1.get_Items().Add((object)text7);
					}
				}
			}
			catch (Exception projectError18)
			{
				ProjectData.SetProjectError(projectError18);
				ProjectData.ClearProjectError();
			}
			try
			{
				Timer1.set_Enabled(true);
			}
			catch (Exception projectError19)
			{
				ProjectData.SetProjectError(projectError19);
				Timer1.Start();
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Invalid comparison between Unknown and I4
		ProgressBarScanner.set_Value(ProgressBarScanner.get_Minimum());
		try
		{
			StreamWriter streamWriter = new StreamWriter("C:\\Satwneyt\\segundo.inf");
			streamWriter.Write("");
			streamWriter.Close();
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\segundo.inf");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			StreamWriter streamWriter2 = new StreamWriter("C:\\Satwneyt\\minuto.inf");
			streamWriter2.Write("");
			streamWriter2.Close();
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\minuto.inf");
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			StreamWriter streamWriter3 = new StreamWriter("C:\\Satwneyt\\hora.inf");
			streamWriter3.Write("");
			streamWriter3.Close();
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\hora.inf");
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			StreamWriter streamWriter4 = new StreamWriter("C:\\Satwneyt\\dia.inf");
			streamWriter4.Write("");
			streamWriter4.Close();
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\dia.inf");
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			StreamWriter streamWriter5 = new StreamWriter("C:\\Satwneyt\\mes.inf");
			streamWriter5.Write("");
			streamWriter5.Close();
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\mes.inf");
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			StreamWriter streamWriter6 = new StreamWriter("C:\\Satwneyt\\ano.inf");
			streamWriter6.Write("");
			streamWriter6.Close();
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\ano.inf");
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			StreamWriter streamWriter7 = new StreamWriter("C:\\Satwneyt\\tdv.inf");
			streamWriter7.Write("");
			streamWriter7.Close();
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		ListBox1.get_Items().Clear();
		ListBox2.get_Items().Clear();
		((Control)Button2).set_Enabled(false);
		((Control)Button1).set_Enabled(false);
		try
		{
			ProgressBarScanner.set_Value(ProgressBarScanner.get_Minimum());
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		if ((int)((CommonDialog)FolderBrowserDialog1).ShowDialog() == 1)
		{
			try
			{
				string[] directories = Directory.GetDirectories(FolderBrowserDialog1.get_SelectedPath().ToString());
				foreach (string text in directories)
				{
					string[] array = Directory.GetFiles(text.ToString());
					foreach (string text2 in array)
					{
						ListBox1.get_Items().Add((object)text2);
					}
				}
				crotime.Start();
				crotime.set_Enabled(true);
				Timer1.set_Enabled(true);
				Timer1.Start();
				hh = Conversions.ToInteger("00");
				mm = Conversions.ToInteger("00");
				ss = Conversions.ToInteger("00");
				Label7.set_Text("00:00:00");
				crotime.Start();
				crotime.set_Enabled(true);
				try
				{
					Timer1.set_Enabled(true);
					Timer1.Start();
				}
				catch (Exception projectError9)
				{
					ProjectData.SetProjectError(projectError9);
					Timer1.Start();
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception projectError10)
			{
				ProjectData.SetProjectError(projectError10);
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory("C:\\desativar");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\atencao", (DeleteDirectoryOption)5);
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\atencao", (DeleteDirectoryOption)4);
				}
				catch (Exception projectError11)
				{
					ProjectData.SetProjectError(projectError11);
					ProjectData.ClearProjectError();
				}
				MyProject.Forms.Load2.FileSystemWatcher1.EnableRaisingEvents = false;
				ProjectData.ClearProjectError();
			}
		}
		else
		{
			TextBoxScanner.set_Text("C:\\");
		}
		try
		{
			detected.set_Text("0");
			((Control)detected).set_ForeColor(Color.Black);
		}
		catch (Exception projectError12)
		{
			ProjectData.SetProjectError(projectError12);
			ProjectData.ClearProjectError();
		}
		try
		{
			GroupBox2.set_Text("Fazer personalizado");
		}
		catch (Exception projectError13)
		{
			ProjectData.SetProjectError(projectError13);
			ProjectData.ClearProjectError();
		}
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			ss++;
			if (ss == 59)
			{
				ss = 0;
				mm++;
				if (mm >= 59)
				{
					mm = 0;
					hh++;
				}
			}
			string text = ((hh >= 10) ? Conversions.ToString(hh) : ("0" + Conversions.ToString(hh)));
			string text2 = ((mm >= 10) ? Conversions.ToString(mm) : ("0" + Conversions.ToString(mm)));
			string text3 = ((ss >= 10) ? Conversions.ToString(ss) : ("0" + Conversions.ToString(ss)));
			if (((Operators.CompareString(Label7.get_Text(), "00:00:04", false) > 0) & (Operators.CompareString(TextBoxScanner.get_Text(), "C:\\", false) == 0) & !((Control)MyProject.Forms.perso).get_Visible() & (Operators.CompareString(MySettingsProperty.Settings.Perso.ToString(), "B", false) == 0)) | ((Operators.CompareString(Label7.get_Text(), "00:00:04", false) > 0) & (Operators.CompareString(TextBoxScanner.get_Text(), "", false) == 0) & !((Control)MyProject.Forms.perso).get_Visible() & (Operators.CompareString(MySettingsProperty.Settings.Perso.ToString(), "B", false) == 0)))
			{
				((Control)Button1).set_Enabled(true);
				((Control)Button2).set_Enabled(true);
				crotime.Stop();
				crotime.set_Enabled(false);
				hh = 0;
				mm = 0;
				ss = 0;
				Timer1.Stop();
				try
				{
					StreamWriter streamWriter = new StreamWriter("C:\\Satwneyt\\segundo.inf");
					streamWriter.Write("");
					streamWriter.Close();
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\segundo.inf");
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				try
				{
					StreamWriter streamWriter2 = new StreamWriter("C:\\Satwneyt\\minuto.inf");
					streamWriter2.Write("");
					streamWriter2.Close();
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\minuto.inf");
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				try
				{
					StreamWriter streamWriter3 = new StreamWriter("C:\\Satwneyt\\hora.inf");
					streamWriter3.Write("");
					streamWriter3.Close();
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\hora.inf");
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				try
				{
					StreamWriter streamWriter4 = new StreamWriter("C:\\Satwneyt\\dia.inf");
					streamWriter4.Write("");
					streamWriter4.Close();
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\dia.inf");
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
				try
				{
					StreamWriter streamWriter5 = new StreamWriter("C:\\Satwneyt\\mes.inf");
					streamWriter5.Write("");
					streamWriter5.Close();
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\mes.inf");
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
				}
				try
				{
					StreamWriter streamWriter6 = new StreamWriter("C:\\Satwneyt\\ano.inf");
					streamWriter6.Write("");
					streamWriter6.Close();
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\ano.inf");
				}
				catch (Exception projectError6)
				{
					ProjectData.SetProjectError(projectError6);
					ProjectData.ClearProjectError();
				}
				try
				{
					StreamWriter streamWriter7 = new StreamWriter("C:\\Satwneyt\\tdv.inf");
					streamWriter7.Write("");
					streamWriter7.Close();
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\tdv.inf");
				}
				catch (Exception projectError7)
				{
					ProjectData.SetProjectError(projectError7);
					ProjectData.ClearProjectError();
				}
				Interaction.MsgBox((object)"Error 404 !\r\n Não foi possível fazer varredura personalizada porque o acesso do seu arquivo pessoal foi negado!", (MsgBoxStyle)16, (object)null);
				Label7.set_Text("00:00:00");
			}
			else
			{
				Label7.set_Text(text + ":" + text2 + ":" + text3);
			}
		}
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (ListaProtecaoReal.get_Items().get_Count() == 0)
			{
				Interaction.MsgBox((object)"Error: Não foi possível-se limpar todo arquivo em tempo real!", (MsgBoxStyle)48, (object)null);
			}
			else
			{
				ListaProtecaoReal.get_Items().Clear();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"Error: Não foi possível-se limpar todo arquivo em tempo real!", (MsgBoxStyle)48, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		Timer2.Start();
		Timer2.set_Enabled(true);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Timer2_Tick_1(object sender, EventArgs e)
	{
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (ListBox2.get_Items().get_Count() != 0)
			{
				ListBox listBox = ListBox3;
				listBox.set_SelectedIndex(checked(listBox.get_SelectedIndex() + 1));
				FileSystem.Kill(Conversions.ToString(ListBox3.get_SelectedItem()));
				ListBox3.get_Items().Remove(RuntimeHelpers.GetObjectValue(ListBox3.get_SelectedItem()));
				Timer2.set_Enabled(false);
				Timer2.Stop();
				ListBox2.get_Items().Clear();
				Interaction.MsgBox((object)"Arquivo removido com sucesso!", (MsgBoxStyle)64, (object)null);
				ListBox2.get_Items().Clear();
			}
			else if (ListBox2.get_Items().get_Count() == 0)
			{
				Timer2.set_Enabled(false);
				Timer2.Stop();
				Interaction.MsgBox((object)"Não há nenhum item na lista.", (MsgBoxStyle)48, (object)null);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Timer2.Stop();
			Interaction.MsgBox((object)"ERROR: Não foi possível remover o arquivo.", (MsgBoxStyle)48, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
	}

	private void Tools_Load(object sender, EventArgs e)
	{
		Label7fc.set_Text("C:\\mysoftware\\");
		Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text());
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory("C:\\mysoftware\\");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory("C:\\mysoftware\\");
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		cod.set_Text(Conversions.ToString(GenerateCode()));
		Label7fc.set_Text("C:\\mysoftware\\" + cod.get_Text() + "\\");
		try
		{
			ss = Conversions.ToInteger("00");
			hh = Conversions.ToInteger("00");
			mm = Conversions.ToInteger("00");
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		NotPause.set_Enabled(true);
		NotPause.Start();
		Process process = new Process();
		int num = 0;
		Process[] processes = Process.GetProcesses(((ServerComputer)MyProject.Computer).get_Name());
		checked
		{
			for (int i = 0; i < processes.Length; i++)
			{
				process = processes[i];
				try
				{
					ListViewGerenciadorTarefa.get_Items().Add(process.ProcessName);
					ListViewGerenciadorTarefa.get_Items().get_Item(num).get_SubItems()
						.Add(Strings.FormatNumber((object)Math.Round((double)process.PrivateMemorySize64 / 1024.0), 0, (TriState)(-2), (TriState)(-2), (TriState)(-2)));
					ListViewGerenciadorTarefa.get_Items().get_Item(num).get_SubItems()
						.Add(Conversions.ToString(process.Responding));
					ListViewGerenciadorTarefa.get_Items().get_Item(num).get_SubItems()
						.Add(process.StartTime.ToString().Trim());
					ListViewGerenciadorTarefa.get_Items().get_Item(num).get_SubItems()
						.Add(Conversions.ToString(process.Id));
					num++;
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
			}
			((ToolStripItem)ToolStripStatusLabelGerenciadorTarefa).set_Text("TOTAL: " + Conversions.ToString(ListViewGerenciadorTarefa.get_Items().get_Count()));
		}
	}

	private void TextBoxAgendaSegundos_TextChanged(object sender, EventArgs e)
	{
		try
		{
			if (!(Conversions.ToDouble(TextBoxAgendaSegundos.get_Text()) < 60.0))
			{
				if (TextBoxAgendaSegundos.get_Text().Contains("000"))
				{
					TextBoxAgendaSegundos.set_Text("");
				}
				else
				{
					TextBoxAgendaSegundos.set_Text("");
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			TextBoxAgendaSegundos.set_Text("");
			if (TextBoxAgendaSegundos.get_Text().Contains("000"))
			{
				TextBoxAgendaSegundos.set_Text("");
			}
			ProjectData.ClearProjectError();
		}
	}

	private void TextBoxAgendaMinutos_TextChanged(object sender, EventArgs e)
	{
		try
		{
			if (!(Conversions.ToDouble(TextBoxAgendaMinutos.get_Text()) < 60.0))
			{
				if (TextBoxAgendaMinutos.get_Text().Contains("000"))
				{
					TextBoxAgendaMinutos.set_Text("");
				}
				else
				{
					TextBoxAgendaMinutos.set_Text("");
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			TextBoxAgendaMinutos.set_Text("");
			if (TextBoxAgendaMinutos.get_Text().Contains("000"))
			{
				TextBoxAgendaMinutos.set_Text("");
			}
			ProjectData.ClearProjectError();
		}
	}

	private void TextBoxAgendaHoras_TextChanged(object sender, EventArgs e)
	{
		try
		{
			if (!(Conversions.ToDouble(TextBoxAgendaHoras.get_Text()) < 25.0))
			{
				if (TextBoxAgendaHoras.get_Text().Contains("000"))
				{
					TextBoxAgendaHoras.set_Text("");
				}
				else
				{
					TextBoxAgendaHoras.set_Text("");
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			if (TextBoxAgendaHoras.get_Text().Contains("000"))
			{
				TextBoxAgendaHoras.set_Text("");
			}
			TextBoxAgendaHoras.set_Text("");
			ProjectData.ClearProjectError();
		}
	}

	private void TextBoxAgendaDias_TextChanged(object sender, EventArgs e)
	{
		try
		{
			if (!(Conversions.ToDouble(TextBoxAgendaDias.get_Text()) < 32.0))
			{
				if (TextBoxAgendaDias.get_Text().Contains("000"))
				{
					TextBoxAgendaDias.set_Text("");
				}
				else
				{
					TextBoxAgendaDias.set_Text("");
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			TextBoxAgendaDias.set_Text("");
			if (TextBoxAgendaDias.get_Text().Contains("000"))
			{
				TextBoxAgendaDias.set_Text("");
			}
			ProjectData.ClearProjectError();
		}
	}

	private void TextBoxAgendaMes_TextChanged(object sender, EventArgs e)
	{
		try
		{
			if (!(Conversions.ToDouble(TextBoxAgendaMes.get_Text()) < 13.0))
			{
				if (TextBoxAgendaMes.get_Text().Contains("000"))
				{
					TextBoxAgendaMes.set_Text("");
				}
				else
				{
					TextBoxAgendaMes.set_Text("");
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			TextBoxAgendaMes.set_Text("");
			if (TextBoxAgendaMes.get_Text().Contains("000"))
			{
				TextBoxAgendaMes.set_Text("");
			}
			ProjectData.ClearProjectError();
		}
	}

	private void TextBoxAgendaAnos_TextChanged(object sender, EventArgs e)
	{
		try
		{
			if (!(Conversions.ToDouble(TextBoxAgendaAnos.get_Text()) < 999999999.0))
			{
				if (TextBoxAgendaAnos.get_Text().Contains("000000000"))
				{
					TextBoxAgendaAnos.set_Text("");
				}
				else
				{
					TextBoxAgendaAnos.set_Text("");
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			TextBoxAgendaAnos.set_Text("");
			if (TextBoxAgendaAnos.get_Text().Contains("000000000"))
			{
				TextBoxAgendaAnos.set_Text("");
			}
			ProjectData.ClearProjectError();
		}
	}

	private void NotPause_Tick(object sender, EventArgs e)
	{
		//IL_0922: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MyProject.Forms.Load2.Label1.set_Text(((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText("C:\\satwneyt\\tdv.inf"));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			if ((double)TrackBar1.get_Value() == Conversions.ToDouble("0"))
			{
				try
				{
					Timer1.set_Interval(Conversions.ToInteger("1560"));
					if (((Form)this).get_Text().Contains("Verificando"))
					{
						TextBoxVarreduradeComportamento.set_Text("1");
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				((Control)Lento).set_ForeColor(Color.Black);
				((Control)Nor).set_ForeColor(Color.Gray);
				((Control)Ace).set_ForeColor(Color.Gray);
				((Control)MR).set_ForeColor(Color.Gray);
				((Control)Luz).set_ForeColor(Color.Gray);
			}
			else if ((double)TrackBar1.get_Value() == Conversions.ToDouble("1"))
			{
				try
				{
					Timer1.set_Interval(Conversions.ToInteger("450"));
					if (((Form)this).get_Text().Contains("Verificando"))
					{
						TextBoxVarreduradeComportamento.set_Text("1");
					}
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				((Control)Lento).set_ForeColor(Color.Gray);
				((Control)Nor).set_ForeColor(Color.Black);
				((Control)Ace).set_ForeColor(Color.Gray);
				((Control)MR).set_ForeColor(Color.Gray);
				((Control)Luz).set_ForeColor(Color.Gray);
			}
			else if ((double)TrackBar1.get_Value() == Conversions.ToDouble("2"))
			{
				try
				{
					Timer1.set_Interval(Conversions.ToInteger("70"));
					if (((Form)this).get_Text().Contains("Verificando"))
					{
						TextBoxVarreduradeComportamento.set_Text("2");
					}
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
				((Control)Lento).set_ForeColor(Color.Gray);
				((Control)Nor).set_ForeColor(Color.Gray);
				((Control)Ace).set_ForeColor(Color.Black);
				((Control)MR).set_ForeColor(Color.Gray);
				((Control)Luz).set_ForeColor(Color.Gray);
			}
			else if ((double)TrackBar1.get_Value() == Conversions.ToDouble("3"))
			{
				try
				{
					Timer1.set_Interval(Conversions.ToInteger("30"));
					if (((Form)this).get_Text().Contains("Verificando"))
					{
						TextBoxVarreduradeComportamento.set_Text("3");
					}
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
				}
				((Control)Lento).set_ForeColor(Color.Gray);
				((Control)Nor).set_ForeColor(Color.Gray);
				((Control)Ace).set_ForeColor(Color.Gray);
				((Control)MR).set_ForeColor(Color.Black);
				((Control)Luz).set_ForeColor(Color.Gray);
			}
			else if ((double)TrackBar1.get_Value() == Conversions.ToDouble("4"))
			{
				try
				{
					Timer1.set_Interval(Conversions.ToInteger("1"));
					if (((Form)this).get_Text().Contains("Verificando"))
					{
						TextBoxVarreduradeComportamento.set_Text("4");
					}
				}
				catch (Exception projectError6)
				{
					ProjectData.SetProjectError(projectError6);
					ProjectData.ClearProjectError();
				}
				((Control)Lento).set_ForeColor(Color.Gray);
				((Control)Nor).set_ForeColor(Color.Gray);
				((Control)Ace).set_ForeColor(Color.Gray);
				((Control)MR).set_ForeColor(Color.Gray);
				((Control)Luz).set_ForeColor(Color.Black);
			}
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		checked
		{
			try
			{
				if (Operators.CompareString(MyProject.Forms.Load2.Label1.get_Text(), "Fazer Varredura Completa", false) == 0)
				{
					Timer1.set_Enabled(true);
					Timer1.Start();
					crotime.Start();
					crotime.set_Enabled(true);
					try
					{
						ProgressBarScanner.set_Value(ProgressBarScanner.get_Minimum());
					}
					catch (Exception projectError8)
					{
						ProjectData.SetProjectError(projectError8);
						ProjectData.ClearProjectError();
					}
					((Control)Button1).set_Enabled(false);
					((Control)Button2).set_Enabled(false);
					if (!((Control)Button1).get_Enabled())
					{
						try
						{
							GroupBox2.set_Text("Fazer completo");
						}
						catch (Exception projectError9)
						{
							ProjectData.SetProjectError(projectError9);
							ProjectData.ClearProjectError();
						}
						try
						{
							detected.set_Text("0");
							((Control)detected).set_ForeColor(Color.Black);
						}
						catch (Exception projectError10)
						{
							ProjectData.SetProjectError(projectError10);
							ProjectData.ClearProjectError();
						}
						((Control)Button2).set_Enabled(false);
						FolderBrowserDialog1.set_SelectedPath("C:\\windows\\");
						try
						{
							string[] directories = Directory.GetDirectories("C:\\");
							for (int i = 0; i < directories.Length; i++)
							{
								string[] array = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
								foreach (string text in array)
								{
									ListBox1.get_Items().Add((object)text);
								}
							}
						}
						catch (Exception projectError11)
						{
							ProjectData.SetProjectError(projectError11);
							ProjectData.ClearProjectError();
						}
						try
						{
							string[] directories2 = Directory.GetDirectories("C:\\");
							for (int k = 0; k < directories2.Length; k++)
							{
								string[] array2 = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Windows));
								foreach (string text2 in array2)
								{
									ListBox1.get_Items().Add((object)text2);
								}
							}
						}
						catch (Exception projectError12)
						{
							ProjectData.SetProjectError(projectError12);
							ProjectData.ClearProjectError();
						}
						try
						{
							string[] directories3 = Directory.GetDirectories("C:\\");
							for (int m = 0; m < directories3.Length; m++)
							{
								string[] array3 = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Cookies));
								foreach (string text3 in array3)
								{
									ListBox1.get_Items().Add((object)text3);
								}
							}
						}
						catch (Exception projectError13)
						{
							ProjectData.SetProjectError(projectError13);
							ProjectData.ClearProjectError();
						}
						try
						{
							string[] directories4 = Directory.GetDirectories("C:\\");
							for (int num = 0; num < directories4.Length; num++)
							{
								string[] array4 = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Programs));
								foreach (string text4 in array4)
								{
									ListBox1.get_Items().Add((object)text4);
								}
							}
						}
						catch (Exception projectError14)
						{
							ProjectData.SetProjectError(projectError14);
							ProjectData.ClearProjectError();
						}
						try
						{
							string[] directories5 = Directory.GetDirectories("C:\\");
							for (int num3 = 0; num3 < directories5.Length; num3++)
							{
								string[] array5 = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Recent));
								foreach (string text5 in array5)
								{
									ListBox1.get_Items().Add((object)text5);
								}
							}
						}
						catch (Exception projectError15)
						{
							ProjectData.SetProjectError(projectError15);
							ProjectData.ClearProjectError();
						}
						try
						{
							string[] directories6 = Directory.GetDirectories("C:\\");
							for (int num5 = 0; num5 < directories6.Length; num5++)
							{
								string[] array6 = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup));
								foreach (string text6 in array6)
								{
									ListBox1.get_Items().Add((object)text6);
								}
							}
						}
						catch (Exception projectError16)
						{
							ProjectData.SetProjectError(projectError16);
							ProjectData.ClearProjectError();
						}
						try
						{
							string[] directories7 = Directory.GetDirectories("C:\\");
							for (int num7 = 0; num7 < directories7.Length; num7++)
							{
								Directory.GetDirectories("C:\\");
								string[] array7 = Directory.GetFiles(Environment.GetFolderPath(unchecked((Environment.SpecialFolder)Conversions.ToInteger("C:\\progra~2\\"))));
								foreach (string text7 in array7)
								{
									ListBox1.get_Items().Add((object)text7);
								}
							}
						}
						catch (Exception projectError17)
						{
							ProjectData.SetProjectError(projectError17);
							ProjectData.ClearProjectError();
						}
					}
				}
				if (Operators.CompareString(MyProject.Forms.Load2.Label1.get_Text(), "Fazer Varredura Personalizada", false) != 0)
				{
					return;
				}
				ListBox1.get_Items().Clear();
				ListBox2.get_Items().Clear();
				((Control)Button2).set_Enabled(false);
				((Control)Button1).set_Enabled(false);
				try
				{
					ProgressBarScanner.set_Value(ProgressBarScanner.get_Minimum());
				}
				catch (Exception projectError18)
				{
					ProjectData.SetProjectError(projectError18);
					ProjectData.ClearProjectError();
				}
				try
				{
					MyProject.Forms.perso.Label1.set_Text(MySettingsProperty.Settings.Perso.ToString());
				}
				catch (Exception projectError19)
				{
					ProjectData.SetProjectError(projectError19);
					ProjectData.ClearProjectError();
				}
				if ((Operators.CompareString(MySettingsProperty.Settings.Perso, "B", false) == 0) & ((Control)this).get_Visible())
				{
					((Control)MyProject.Forms.perso).set_Visible(false);
				}
				if (Operators.CompareString(MySettingsProperty.Settings.Perso, "A", false) == 0)
				{
					try
					{
						((Form)MyProject.Forms.perso).ShowDialog();
					}
					catch (Exception projectError20)
					{
						ProjectData.SetProjectError(projectError20);
						((Control)MyProject.Forms.perso).set_Visible(true);
						ProjectData.ClearProjectError();
					}
				}
				try
				{
					detected.set_Text("0");
					((Control)detected).set_ForeColor(Color.Black);
				}
				catch (Exception projectError21)
				{
					ProjectData.SetProjectError(projectError21);
					ProjectData.ClearProjectError();
				}
				((Control)Button1).set_Enabled(false);
				((Control)Button2).set_Enabled(false);
				try
				{
					GroupBox2.set_Text("Fazer personalizado");
				}
				catch (Exception projectError22)
				{
					ProjectData.SetProjectError(projectError22);
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception projectError23)
			{
				ProjectData.SetProjectError(projectError23);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Interaction.MsgBox((object)"SATWNEYT INFORMAÇÃO:\r\nO Escaneamento Completo é aquele que varre e destaca-se em todos os arquivos!\r\nVocê pode selecionar em modo mais rápido para em aumentar velocidade do desempenho,mas muito rápido pode não fazer tarefas corretamente mais justas de ato bem feito.", (MsgBoxStyle)64, (object)null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Button8_Click(object sender, EventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Interaction.MsgBox((object)"SATWNEYT INFORMAÇÃO:\r\nO Escaneamento Personalizado verifica os arquivos escolhido e selecionados para fazer uma promessa de varredura em uso seu escaneamento.\r\nVocê pode selecionar em modo mais rápido para em aumentar velocidade do desempenho,mas muito rápido pode não fazer tarefas corretamente mais justas de ato bem feito.", (MsgBoxStyle)64, (object)null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void GroupBox4_Enter(object sender, EventArgs e)
	{
	}

	private void Timer1s_Tick(object sender, EventArgs e)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		if ((Limped.get_Items().get_Count() == 30) | (Limped.get_Items().get_Count() > 30))
		{
			Limped.set_HorizontalScrollbar(true);
		}
		else
		{
			Limped.set_HorizontalScrollbar(false);
		}
		new OpenFileDialog();
		ProgressLimpeza.set_Maximum(Conversions.ToInteger(Conversions.ToString(Limped.get_Items().get_Count())));
		Tar.set_Text(Conversions.ToString((object)Limped.get_Items().get_Count().ToString()));
		try
		{
			if ((Limped.get_Items().get_Count() == 0) | (Operators.CompareString(totale.get_Text(), "-1", false) == 0))
			{
				totale.set_Text("0");
				Tar.set_Text("0");
			}
			else
			{
				ProgressLimpeza.Increment(Conversions.ToInteger(Limped.get_SelectedIndex().ToString()));
				totale.set_Text(Conversions.ToString(ProgressLimpeza.get_Value()));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		if (ProgressLimpeza.get_Value() != ProgressLimpeza.get_Maximum())
		{
			try
			{
				TextBox val = new TextBox();
				string text = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText("C:\\");
				val.set_Text(text.ToString());
				MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
				FileStream fileStream = new FileStream(((object)Limped.get_Items()).ToString(), FileMode.Open, FileAccess.Read, FileShare.Read, 8192);
				fileStream = new FileStream(((object)Limped.get_Items()).ToString(), FileMode.Open, FileAccess.Read, FileShare.Read, 8192);
				mD5CryptoServiceProvider.ComputeHash(fileStream);
				byte[] hash = mD5CryptoServiceProvider.Hash;
				StringBuilder stringBuilder = new StringBuilder();
				byte[] array = hash;
				foreach (byte b in array)
				{
					stringBuilder.Append($"{b:X2}");
				}
				if (val.get_Text().Contains(stringBuilder.ToString()))
				{
					Limped.get_Items().Add((object)((object)Limped.get_Items()).ToString());
				}
				return;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
				return;
			}
		}
		Timer1s.Stop();
		if (Limped.get_Items().get_Count() == 0)
		{
			((Control)PE).set_Enabled(true);
			Interaction.MsgBox((object)"Nenhum erros foram encontrado !!!", (MsgBoxStyle)64, (object)null);
			((Control)CE).set_Enabled(false);
			((Control)PE).set_Enabled(true);
			totale.set_Text("0");
			Tar.set_Text("0");
			((Control)GroupBox6).set_Enabled(true);
		}
		else
		{
			Interaction.MsgBox((object)"A procuração de erros foram concluído !!!\r\n Só falta corrigir.", (MsgBoxStyle)64, (object)null);
			((Control)CE).set_Enabled(true);
			((Control)PE).set_Enabled(false);
			((Control)GroupBox6).set_Enabled(true);
		}
	}

	private void Button9_Click(object sender, EventArgs e)
	{
	}

	private void Button10_Click(object sender, EventArgs e)
	{
	}

	private void Limped_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void Timer2s_Tick(object sender, EventArgs e)
	{
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		ProgressLimpeza.set_Maximum(Conversions.ToInteger(Conversions.ToString((object)Limped.get_Items().get_Count().ToString())));
		try
		{
			if ((Limped.get_Items().get_Count() != 0) | (Limped.get_Items().get_Count() > 0) | (Limped.get_Items().get_Count() > 1) | (Limped.get_Items().get_Count() == 1))
			{
				Limped.get_Items().RemoveAt(Conversions.ToInteger(Limped.get_SelectedItem()));
				Limped.get_Items().RemoveAt(Conversions.ToInteger(NewLateBinding.LateGet(Limped.get_SelectedItem(), (Type)null, "Item", new object[0], (string[])null, (Type[])null, (bool[])null)));
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(Limped.get_SelectedItem()));
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(NewLateBinding.LateGet(Limped.get_SelectedItem(), (Type)null, "Item", new object[0], (string[])null, (Type[])null, (bool[])null)));
			}
			if (Limped.get_Items().get_Count() == 0)
			{
				Timer2s.Stop();
				Timer2s.set_Enabled(false);
				ProgressLimpeza.set_Value(0);
				((Control)GroupBox6).set_Enabled(true);
				((Control)CE).set_Enabled(false);
				((Control)PE).set_Enabled(true);
				((Control)GroupBox6).set_Enabled(true);
				totale.set_Text("0");
				Tar.set_Text("0");
				Interaction.MsgBox((object)"Removido com sucesso !!!", (MsgBoxStyle)64, (object)null);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Timer2s.Stop();
			ProgressLimpeza.set_Value(0);
			Timer2s.set_Enabled(Operators.CompareString(totale.get_Text(), "0", false) == 0);
			Tar.set_Text("0");
			((Control)GroupBox6).set_Enabled(true);
			((Control)CE).set_Enabled(false);
			((Control)PE).set_Enabled(true);
			((Control)GroupBox6).set_Enabled(true);
			Limped.get_Items().Clear();
			Interaction.MsgBox((object)"Removido com sucesso !!!", (MsgBoxStyle)64, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void PE_Click(object sender, EventArgs e)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		Limped.set_HorizontalScrollbar(true);
		totale.set_Text("0");
		Tar.set_Text("0");
		new FolderBrowserDialog();
		FolderBrowserDialog2.set_SelectedPath("C:/");
		FolderBrowserDialog2.set_Description("É recomendável escolher e selecionar os arquivos para começar a usar.\r\nExemplo: Área de Trabalho.");
		((CommonDialog)FolderBrowserDialog2).ShowDialog();
		try
		{
			string[] directories = Directory.GetDirectories(FolderBrowserDialog2.get_SelectedPath().ToString());
			foreach (string path in directories)
			{
				string[] array = Directory.GetFiles(path);
				foreach (string text in array)
				{
					Limped.get_Items().Add((object)text);
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Timer1s.Start();
		Timer1s.Start();
		((Control)PE).set_Enabled(false);
		if (Operators.CompareString(totale.get_Text(), "100", false) == 0)
		{
			Limped.get_Items().Clear();
		}
		((Control)GroupBox6).set_Enabled(true);
	}

	private void CE_Click(object sender, EventArgs e)
	{
		((Control)GroupBox6).set_Enabled(false);
		Timer2s.Start();
		Timer2s.set_Enabled(true);
		((Control)CE).set_Enabled(false);
		((Control)PE).set_Enabled(false);
	}

	private void OpenGen1_Click(object sender, EventArgs e)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Invalid comparison between Unknown and I4
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory("C:\\mysoftware\\");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory("C:\\mysoftware\\");
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			cod.set_Text(Conversions.ToString(GenerateCode()));
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		FolderBrowserDialog val = new FolderBrowserDialog();
		val.set_Description("Recomendável savar na Área de Trabalho.");
		if ((int)((CommonDialog)val).ShowDialog() != 1)
		{
			return;
		}
		Label7fc.set_Text(val.get_SelectedPath() + "\\");
		try
		{
			if (GenText1.get_Text().Contains(".torrent") | GenText1.get_Text().Contains(".TORRENT"))
			{
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".torrent");
			}
			else if (GenText1.get_Text().Contains(".com") | GenText1.get_Text().Contains(".COM"))
			{
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".com");
			}
			else if (GenText1.get_Text().Contains(".exe") | GenText1.get_Text().Contains(".EXE"))
			{
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".exe");
			}
			else if (GenText1.get_Text().Contains(".ico") | GenText1.get_Text().Contains(".ICO"))
			{
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".ico");
			}
			else if (GenText1.get_Text().Contains(".gif") | GenText1.get_Text().Contains(".GIF"))
			{
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".gif");
			}
			else if (GenText1.get_Text().Contains(".jpg") | GenText1.get_Text().Contains(".JPG"))
			{
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".jpg");
			}
			else if (GenText1.get_Text().Contains(".jpeg") | GenText1.get_Text().Contains(".JPEG"))
			{
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".jpeg");
			}
			else if (GenText1.get_Text().Contains(".png") | GenText1.get_Text().Contains(".PNG"))
			{
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".png");
			}
			else if (GenText1.get_Text().Contains(".lnk") | GenText1.get_Text().Contains(".LNK"))
			{
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".lnk");
			}
			else if (GenText1.get_Text().Contains(".zip") | GenText1.get_Text().Contains(".ZIP"))
			{
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".zip");
			}
			else if (GenText1.get_Text().Contains(".rar") | GenText1.get_Text().Contains(".RAR"))
			{
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".rar");
			}
			else if (GenText1.get_Text().Contains(".txt") | GenText1.get_Text().Contains(".TXT"))
			{
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".txt");
			}
			else if (GenText1.get_Text().Contains(".inf") | GenText1.get_Text().Contains(".INF"))
			{
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".inf");
			}
			else if (GenText1.get_Text().Contains(".bat") | GenText1.get_Text().Contains(".BAT"))
			{
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".bat");
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			Interaction.MsgBox((object)Conversion.ErrorToString(), (MsgBoxStyle)16, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void DownGen1_Click(object sender, EventArgs e)
	{
		//IL_0d40: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (GenText1.get_Text().Contains(".torrent") | GenText1.get_Text().Contains(".TORRENT"))
			{
				((Control)PanelGen).set_Visible(true);
				TimeFileCopy.Start();
				((Control)PanelGen).set_Visible(true);
				((Control)PanelGen).set_Enabled(true);
				((Control)PanelGen).set_Dock((DockStyle)5);
				TimeFileCopy.set_Enabled(true);
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".torrent");
				TimeFileCopy.Start();
				TimeFileCopy.set_Enabled(true);
				ProgressCopyGen.set_Value(0);
				DownBaixado.set_Text("Baixado: 0 KB");
				DownTotal.set_Text("Total: 0 KB");
			}
			else if (GenText1.get_Text().Contains(".com") | GenText1.get_Text().Contains(".COM"))
			{
				((Control)PanelGen).set_Visible(true);
				TimeFileCopy.Start();
				((Control)PanelGen).set_Visible(true);
				((Control)PanelGen).set_Enabled(true);
				((Control)PanelGen).set_Dock((DockStyle)5);
				TimeFileCopy.set_Enabled(true);
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".com");
				TimeFileCopy.Start();
				TimeFileCopy.set_Enabled(true);
				ProgressCopyGen.set_Value(0);
				DownBaixado.set_Text("Baixado: 0 KB");
				DownTotal.set_Text("Total: 0 KB");
			}
			else if (GenText1.get_Text().Contains(".exe") | GenText1.get_Text().Contains(".EXE"))
			{
				((Control)PanelGen).set_Visible(true);
				TimeFileCopy.Start();
				((Control)PanelGen).set_Visible(true);
				((Control)PanelGen).set_Enabled(true);
				((Control)PanelGen).set_Dock((DockStyle)5);
				TimeFileCopy.set_Enabled(true);
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".exe");
				TimeFileCopy.Start();
				TimeFileCopy.set_Enabled(true);
				ProgressCopyGen.set_Value(0);
				DownBaixado.set_Text("Baixado: 0 KB");
				DownTotal.set_Text("Total: 0 KB");
			}
			else if (GenText1.get_Text().Contains(".ico") | GenText1.get_Text().Contains(".ICO"))
			{
				((Control)PanelGen).set_Visible(true);
				TimeFileCopy.Start();
				TimeFileCopy.set_Enabled(true);
				((Control)PanelGen).set_Visible(true);
				((Control)PanelGen).set_Enabled(true);
				((Control)PanelGen).set_Dock((DockStyle)5);
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".ico");
				TimeFileCopy.Start();
				TimeFileCopy.set_Enabled(true);
				ProgressCopyGen.set_Value(0);
				DownBaixado.set_Text("Baixado: 0 KB");
				DownTotal.set_Text("Total: 0 KB");
			}
			else if (GenText1.get_Text().Contains(".gif") | GenText1.get_Text().Contains(".GIF"))
			{
				((Control)PanelGen).set_Visible(true);
				TimeFileCopy.Start();
				TimeFileCopy.set_Enabled(true);
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".gif");
				((Control)PanelGen).set_Visible(true);
				((Control)PanelGen).set_Enabled(true);
				((Control)PanelGen).set_Dock((DockStyle)5);
				TimeFileCopy.Start();
				TimeFileCopy.set_Enabled(true);
				ProgressCopyGen.set_Value(0);
				DownBaixado.set_Text("Baixado: 0 KB");
				DownTotal.set_Text("Total: 0 KB");
			}
			else if (GenText1.get_Text().Contains(".jpg") | GenText1.get_Text().Contains(".JPG"))
			{
				((Control)PanelGen).set_Visible(true);
				TimeFileCopy.Start();
				TimeFileCopy.set_Enabled(true);
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".jpg");
				((Control)PanelGen).set_Visible(true);
				((Control)PanelGen).set_Enabled(true);
				((Control)PanelGen).set_Dock((DockStyle)5);
				TimeFileCopy.Start();
				TimeFileCopy.set_Enabled(true);
				ProgressCopyGen.set_Value(0);
				DownBaixado.set_Text("Baixado: 0 KB");
				DownTotal.set_Text("Total: 0 KB");
			}
			else if (GenText1.get_Text().Contains(".jpeg") | GenText1.get_Text().Contains(".JPEG"))
			{
				((Control)PanelGen).set_Visible(true);
				TimeFileCopy.Start();
				TimeFileCopy.set_Enabled(true);
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".jpeg");
				((Control)PanelGen).set_Visible(true);
				((Control)PanelGen).set_Enabled(true);
				((Control)PanelGen).set_Dock((DockStyle)5);
				TimeFileCopy.Start();
				TimeFileCopy.set_Enabled(true);
				ProgressCopyGen.set_Value(0);
				DownBaixado.set_Text("Baixado: 0 KB");
				DownTotal.set_Text("Total: 0 KB");
			}
			else if (GenText1.get_Text().Contains(".png") | GenText1.get_Text().Contains(".PNG"))
			{
				((Control)PanelGen).set_Visible(true);
				TimeFileCopy.Start();
				TimeFileCopy.set_Enabled(true);
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".png");
				((Control)PanelGen).set_Visible(true);
				((Control)PanelGen).set_Enabled(true);
				((Control)PanelGen).set_Dock((DockStyle)5);
				TimeFileCopy.Start();
				TimeFileCopy.set_Enabled(true);
				ProgressCopyGen.set_Value(0);
				DownBaixado.set_Text("Baixado: 0 KB");
				DownTotal.set_Text("Total: 0 KB");
			}
			else if (GenText1.get_Text().Contains(".lnk") | GenText1.get_Text().Contains(".LNK"))
			{
				((Control)PanelGen).set_Visible(true);
				TimeFileCopy.Start();
				TimeFileCopy.set_Enabled(true);
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".lnk");
				((Control)PanelGen).set_Visible(true);
				((Control)PanelGen).set_Enabled(true);
				((Control)PanelGen).set_Dock((DockStyle)5);
				TimeFileCopy.Start();
				TimeFileCopy.set_Enabled(true);
				ProgressCopyGen.set_Value(0);
				DownBaixado.set_Text("Baixado: 0 KB");
				DownTotal.set_Text("Total: 0 KB");
			}
			else if (GenText1.get_Text().Contains(".zip") | GenText1.get_Text().Contains(".ZIP"))
			{
				((Control)PanelGen).set_Visible(true);
				TimeFileCopy.Start();
				TimeFileCopy.set_Enabled(true);
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".zip");
				((Control)PanelGen).set_Visible(true);
				((Control)PanelGen).set_Enabled(true);
				((Control)PanelGen).set_Dock((DockStyle)5);
				TimeFileCopy.Start();
				TimeFileCopy.set_Enabled(true);
				ProgressCopyGen.set_Value(0);
				DownBaixado.set_Text("Baixado: 0 KB");
				DownTotal.set_Text("Total: 0 KB");
			}
			else if (GenText1.get_Text().Contains(".rar") | GenText1.get_Text().Contains(".RAR"))
			{
				((Control)PanelGen).set_Visible(true);
				TimeFileCopy.Start();
				TimeFileCopy.set_Enabled(true);
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".rar");
				((Control)PanelGen).set_Visible(true);
				((Control)PanelGen).set_Enabled(true);
				((Control)PanelGen).set_Dock((DockStyle)5);
				TimeFileCopy.Start();
				TimeFileCopy.set_Enabled(true);
				ProgressCopyGen.set_Value(0);
				DownBaixado.set_Text("Baixado: 0 KB");
				DownTotal.set_Text("Total: 0 KB");
			}
			else if (GenText1.get_Text().Contains(".txt") | GenText1.get_Text().Contains(".TXT"))
			{
				((Control)PanelGen).set_Visible(true);
				TimeFileCopy.Start();
				TimeFileCopy.set_Enabled(true);
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".txt");
				((Control)PanelGen).set_Visible(true);
				((Control)PanelGen).set_Enabled(true);
				((Control)PanelGen).set_Dock((DockStyle)5);
				TimeFileCopy.Start();
				TimeFileCopy.set_Enabled(true);
				ProgressCopyGen.set_Value(0);
				DownBaixado.set_Text("Baixado: 0 KB");
				DownTotal.set_Text("Total: 0 KB");
			}
			else if (GenText1.get_Text().Contains(".inf") | GenText1.get_Text().Contains(".INF"))
			{
				((Control)PanelGen).set_Visible(true);
				TimeFileCopy.Start();
				TimeFileCopy.set_Enabled(true);
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".inf");
				((Control)PanelGen).set_Visible(true);
				((Control)PanelGen).set_Enabled(true);
				((Control)PanelGen).set_Dock((DockStyle)5);
				TimeFileCopy.Start();
				TimeFileCopy.set_Enabled(true);
				ProgressCopyGen.set_Value(0);
				DownBaixado.set_Text("Baixado: 0 KB");
				DownTotal.set_Text("Total: 0 KB");
			}
			else if (GenText1.get_Text().Contains(".bat") | GenText1.get_Text().Contains(".BAT"))
			{
				((Control)PanelGen).set_Visible(true);
				TimeFileCopy.Start();
				TimeFileCopy.set_Enabled(true);
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".bat");
				((Control)PanelGen).set_Visible(true);
				((Control)PanelGen).set_Enabled(true);
				((Control)PanelGen).set_Dock((DockStyle)5);
				TimeFileCopy.Start();
				TimeFileCopy.set_Enabled(true);
				ProgressCopyGen.set_Value(0);
				DownBaixado.set_Text("Baixado: 0 KB");
				DownTotal.set_Text("Total: 0 KB");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			TimeFileCopy.Stop();
			((Control)PanelGen).set_Visible(false);
			Interaction.MsgBox((object)("ERROR: " + Conversion.ErrorToString()), (MsgBoxStyle)48, (object)null);
			GenText1.set_Text("");
			Gentext2.set_Text("c:\\");
			ProjectData.ClearProjectError();
		}
	}

	private void httpclient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
	{
		DownBaixado.set_Text("Baixado: " + Strings.FormatNumber((object)((double)e.BytesReceived / 1024.0), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2)).ToString() + " KB");
		DownTotal.set_Text("Total:" + Strings.FormatNumber((object)((double)e.TotalBytesToReceive / 1024.0), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2)).ToString() + " KB");
		ProgressCopyGen.set_Value(e.ProgressPercentage);
		ProgressCopyGen.Increment(e.ProgressPercentage);
		LabelGenStatus.set_Text(e.ProgressPercentage + " %");
	}

	private void AtualizarToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Process process = new Process();
		int num = 0;
		Process[] processes = Process.GetProcesses(((ServerComputer)MyProject.Computer).get_Name());
		checked
		{
			for (int i = 0; i < processes.Length; i++)
			{
				process = processes[i];
				try
				{
					process.Refresh();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				try
				{
					ListViewGerenciadorTarefa.get_Items().Add(process.ProcessName);
					ListViewGerenciadorTarefa.get_Items().get_Item(num).get_SubItems()
						.Add(Strings.FormatNumber((object)Math.Round((double)process.PrivateMemorySize64 / 1024.0), 0, (TriState)(-2), (TriState)(-2), (TriState)(-2)));
					ListViewGerenciadorTarefa.get_Items().get_Item(num).get_SubItems()
						.Add(Conversions.ToString(process.Responding));
					ListViewGerenciadorTarefa.get_Items().get_Item(num).get_SubItems()
						.Add(process.StartTime.ToString().Trim());
					ListViewGerenciadorTarefa.get_Items().get_Item(num).get_SubItems()
						.Add(Conversions.ToString(process.Id));
					num++;
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			((ToolStripItem)ToolStripStatusLabelGerenciadorTarefa).set_Text("TOTAL: " + Conversions.ToString(ListViewGerenciadorTarefa.get_Items().get_Count()));
		}
	}

	private void FonteToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if ((int)((CommonDialog)Fontgdtarefa).ShowDialog() == 1)
			{
				((Control)ListViewGerenciadorTarefa).set_Font(Fontgdtarefa.get_Font());
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			((CommonDialog)Fontgdtarefa).ShowDialog();
			ProjectData.ClearProjectError();
		}
	}

	private void FecharAplicativoToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ListViewGerenciadorTarefa.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					Process.GetProcessById(Conversions.ToInteger(val.get_SubItems().get_Item(4).get_Text())).Kill();
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			Tools_Load(null, null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)("ERROR: " + Conversion.ErrorToString()), (MsgBoxStyle)16, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void LimparTudoToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			ListViewGerenciadorTarefa.get_Items().Clear();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void GenText1_TextChanged(object sender, EventArgs e)
	{
		Label7fc.set_Text("C:\\mysoftware\\");
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory("C:\\mysoftware\\");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (GenText1.get_Text().Contains(".torrent") | GenText1.get_Text().Contains(".TORRENT"))
			{
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".torrent");
			}
			else if (GenText1.get_Text().Contains(".com") | GenText1.get_Text().Contains(".COM"))
			{
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".com");
			}
			else if (GenText1.get_Text().Contains(".exe") | GenText1.get_Text().Contains(".EXE"))
			{
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".exe");
			}
			else if (GenText1.get_Text().Contains(".ico") | GenText1.get_Text().Contains(".ICO"))
			{
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".ico");
			}
			else if (GenText1.get_Text().Contains(".gif") | GenText1.get_Text().Contains(".GIF"))
			{
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".gif");
			}
			else if (GenText1.get_Text().Contains(".jpg") | GenText1.get_Text().Contains(".JPG"))
			{
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".jpg");
			}
			else if (GenText1.get_Text().Contains(".jpeg") | GenText1.get_Text().Contains(".JPEG"))
			{
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".jpeg");
			}
			else if (GenText1.get_Text().Contains(".png") | GenText1.get_Text().Contains(".PNG"))
			{
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".png");
			}
			else if (GenText1.get_Text().Contains(".lnk") | GenText1.get_Text().Contains(".LNK"))
			{
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".lnk");
			}
			else if (GenText1.get_Text().Contains(".zip") | GenText1.get_Text().Contains(".ZIP"))
			{
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".zip");
			}
			else if (GenText1.get_Text().Contains(".rar") | GenText1.get_Text().Contains(".RAR"))
			{
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".rar");
			}
			else if (GenText1.get_Text().Contains(".txt") | GenText1.get_Text().Contains(".TXT"))
			{
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".txt");
			}
			else if (GenText1.get_Text().Contains(".inf") | GenText1.get_Text().Contains(".INF"))
			{
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".inf");
			}
			else if (GenText1.get_Text().Contains(".bat") | GenText1.get_Text().Contains(".BAT"))
			{
				Gentext2.set_Text(Label7fc.get_Text() + "\\" + cod.get_Text() + ".bat");
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void TimeFileCopy_Tick(object sender, EventArgs e)
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory("C:\\mysoftware\\");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		string text = GenText1.get_Text();
		string text2 = Gentext2.get_Text();
		try
		{
			WebClient webClient = new WebClient();
			webClient = new WebClient();
			webClient.DownloadProgressChanged += httpclient_DownloadProgressChanged;
			webClient.DownloadFileCompleted += downloadconcluido;
			webClient.DownloadFileAsync(new Uri(text.ToString()), text2.ToString());
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			TimeFileCopy.set_Enabled(false);
			TimeFileCopy.Stop();
			((Control)PanelGen).set_Visible(false);
			Interaction.MsgBox((object)("ERROR: " + Conversion.ErrorToString().ToString() + "\r\nPor favor, tente novamente mais tarde!"), (MsgBoxStyle)48, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void Gentext2_TextChanged(object sender, EventArgs e)
	{
	}

	private void TrackBar1_Scroll(object sender, EventArgs e)
	{
		try
		{
			if ((double)TrackBar1.get_Value() == Conversions.ToDouble("0"))
			{
				try
				{
					Timer1.set_Interval(Conversions.ToInteger("1560"));
					if (((Form)this).get_Text().Contains("Verificando"))
					{
						TextBoxVarreduradeComportamento.set_Text("1");
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				((Control)Lento).set_ForeColor(Color.Black);
				((Control)Nor).set_ForeColor(Color.Gray);
				((Control)Ace).set_ForeColor(Color.Gray);
				((Control)MR).set_ForeColor(Color.Gray);
				((Control)Luz).set_ForeColor(Color.Gray);
			}
			else if ((double)TrackBar1.get_Value() == Conversions.ToDouble("1"))
			{
				try
				{
					Timer1.set_Interval(Conversions.ToInteger("450"));
					if (((Form)this).get_Text().Contains("Verificando"))
					{
						TextBoxVarreduradeComportamento.set_Text("1");
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				((Control)Lento).set_ForeColor(Color.Gray);
				((Control)Nor).set_ForeColor(Color.Black);
				((Control)Ace).set_ForeColor(Color.Gray);
				((Control)MR).set_ForeColor(Color.Gray);
				((Control)Luz).set_ForeColor(Color.Gray);
			}
			else if ((double)TrackBar1.get_Value() == Conversions.ToDouble("2"))
			{
				try
				{
					Timer1.set_Interval(Conversions.ToInteger("70"));
					if (((Form)this).get_Text().Contains("Verificando"))
					{
						TextBoxVarreduradeComportamento.set_Text("2");
					}
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				((Control)Lento).set_ForeColor(Color.Gray);
				((Control)Nor).set_ForeColor(Color.Gray);
				((Control)Ace).set_ForeColor(Color.Black);
				((Control)MR).set_ForeColor(Color.Gray);
				((Control)Luz).set_ForeColor(Color.Gray);
			}
			else if ((double)TrackBar1.get_Value() == Conversions.ToDouble("3"))
			{
				try
				{
					Timer1.set_Interval(Conversions.ToInteger("30"));
					if (((Form)this).get_Text().Contains("Verificando"))
					{
						TextBoxVarreduradeComportamento.set_Text("3");
					}
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
				((Control)Lento).set_ForeColor(Color.Gray);
				((Control)Nor).set_ForeColor(Color.Gray);
				((Control)Ace).set_ForeColor(Color.Gray);
				((Control)MR).set_ForeColor(Color.Black);
				((Control)Luz).set_ForeColor(Color.Gray);
			}
			else
			{
				if ((double)TrackBar1.get_Value() != Conversions.ToDouble("4"))
				{
					return;
				}
				try
				{
					Timer1.set_Interval(Conversions.ToInteger("1"));
					if (((Form)this).get_Text().Contains("Verificando"))
					{
						TextBoxVarreduradeComportamento.set_Text("4");
					}
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
				}
				((Control)Lento).set_ForeColor(Color.Gray);
				((Control)Nor).set_ForeColor(Color.Gray);
				((Control)Ace).set_ForeColor(Color.Gray);
				((Control)MR).set_ForeColor(Color.Gray);
				((Control)Luz).set_ForeColor(Color.Black);
			}
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
	}

	private void TabPage8_Click(object sender, EventArgs e)
	{
	}
}
