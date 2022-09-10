using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace xxx;

[DesignerGenerated]
public class frmWord : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("WizardPage1")]
	private WizardPage _WizardPage1;

	[AccessedThroughProperty("WizardPage3")]
	private WizardPage _WizardPage3;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Wizard1")]
	private Wizard _Wizard1;

	[AccessedThroughProperty("wdljtxt")]
	private TextBoxX _wdljtxt;

	[AccessedThroughProperty("scyjtxt")]
	private TextBoxX _scyjtxt;

	[AccessedThroughProperty("jcbmtxt")]
	private TextBoxX _jcbmtxt;

	[AccessedThroughProperty("jcrtxt")]
	private TextBoxX _jcrtxt;

	[AccessedThroughProperty("LabelX9")]
	private LabelX _LabelX9;

	[AccessedThroughProperty("LabelX8")]
	private LabelX _LabelX8;

	[AccessedThroughProperty("LabelX6")]
	private LabelX _LabelX6;

	[AccessedThroughProperty("LabelX4")]
	private LabelX _LabelX4;

	[AccessedThroughProperty("LabelX2")]
	private LabelX _LabelX2;

	[AccessedThroughProperty("cjbmtxt")]
	private TextBoxX _cjbmtxt;

	[AccessedThroughProperty("cjrtxt")]
	private TextBoxX _cjrtxt;

	[AccessedThroughProperty("smtxt")]
	private TextBoxX _smtxt;

	[AccessedThroughProperty("LabelX7")]
	private LabelX _LabelX7;

	[AccessedThroughProperty("xmtxt")]
	private TextBoxX _xmtxt;

	[AccessedThroughProperty("LabelX5")]
	private LabelX _LabelX5;

	[AccessedThroughProperty("LabelX3")]
	private LabelX _LabelX3;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("jcrq")]
	private DateTimePicker _jcrq;

	[AccessedThroughProperty("WizardPage2")]
	private WizardPage _WizardPage2;

	[AccessedThroughProperty("lbjiegouxingshi")]
	private ListBox _lbjiegouxingshi;

	[AccessedThroughProperty("pathdoc")]
	private TextBoxX _pathdoc;

	[AccessedThroughProperty("openDoc")]
	private ButtonX _openDoc;

	[AccessedThroughProperty("GetOpenFilename")]
	private OpenFileDialog _GetOpenFilename;

	[AccessedThroughProperty("jielunTXT")]
	private TextBoxX _jielunTXT;

	[AccessedThroughProperty("LabelX10")]
	private LabelX _LabelX10;

	[AccessedThroughProperty("GetSaveFilename")]
	private SaveFileDialog _GetSaveFilename;

	[AccessedThroughProperty("liulan")]
	private ButtonX _liulan;

	[AccessedThroughProperty("lbjd")]
	private LabelX _lbjd;

	[AccessedThroughProperty("PBX1")]
	private ProgressBarX _PBX1;

	[AccessedThroughProperty("CBXchuli")]
	private CheckBoxX _CBXchuli;

	[AccessedThroughProperty("CBXlog")]
	private CheckBoxX _CBXlog;

	private string Report;

	private string curstruct;

	private string xn;

	private string p;

	private string p1;

	private string p2;

	private ArrayList arraybj;

	internal virtual WizardPage WizardPage1
	{
		[DebuggerNonUserCode]
		get
		{
			return _WizardPage1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			CancelEventHandler cancelEventHandler = WizardPage1_NextButtonClick;
			if (_WizardPage1 != null)
			{
				_WizardPage1.remove_NextButtonClick(cancelEventHandler);
			}
			_WizardPage1 = value;
			if (_WizardPage1 != null)
			{
				_WizardPage1.add_NextButtonClick(cancelEventHandler);
			}
		}
	}

	internal virtual WizardPage WizardPage3
	{
		[DebuggerNonUserCode]
		get
		{
			return _WizardPage3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WizardPage3 = value;
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

	internal virtual Wizard Wizard1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Wizard1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			CancelEventHandler cancelEventHandler = Wizard1_CancelButtonClick;
			CancelEventHandler cancelEventHandler2 = Wizard1_FinishButtonClick;
			if (_Wizard1 != null)
			{
				_Wizard1.remove_CancelButtonClick(cancelEventHandler);
				_Wizard1.remove_FinishButtonClick(cancelEventHandler2);
			}
			_Wizard1 = value;
			if (_Wizard1 != null)
			{
				_Wizard1.add_CancelButtonClick(cancelEventHandler);
				_Wizard1.add_FinishButtonClick(cancelEventHandler2);
			}
		}
	}

	internal virtual TextBoxX wdljtxt
	{
		[DebuggerNonUserCode]
		get
		{
			return _wdljtxt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_wdljtxt = value;
		}
	}

	internal virtual TextBoxX scyjtxt
	{
		[DebuggerNonUserCode]
		get
		{
			return _scyjtxt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_scyjtxt = value;
		}
	}

	internal virtual TextBoxX jcbmtxt
	{
		[DebuggerNonUserCode]
		get
		{
			return _jcbmtxt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_jcbmtxt = value;
		}
	}

	internal virtual TextBoxX jcrtxt
	{
		[DebuggerNonUserCode]
		get
		{
			return _jcrtxt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_jcrtxt = value;
		}
	}

	internal virtual LabelX LabelX9
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX9 = value;
		}
	}

	internal virtual LabelX LabelX8
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX8 = value;
		}
	}

	internal virtual LabelX LabelX6
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX6 = value;
		}
	}

	internal virtual LabelX LabelX4
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX4 = value;
		}
	}

	internal virtual LabelX LabelX2
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX2 = value;
		}
	}

	internal virtual TextBoxX cjbmtxt
	{
		[DebuggerNonUserCode]
		get
		{
			return _cjbmtxt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cjbmtxt = value;
		}
	}

	internal virtual TextBoxX cjrtxt
	{
		[DebuggerNonUserCode]
		get
		{
			return _cjrtxt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cjrtxt = value;
		}
	}

	internal virtual TextBoxX smtxt
	{
		[DebuggerNonUserCode]
		get
		{
			return _smtxt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_smtxt = value;
		}
	}

	internal virtual LabelX LabelX7
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX7 = value;
		}
	}

	internal virtual TextBoxX xmtxt
	{
		[DebuggerNonUserCode]
		get
		{
			return _xmtxt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_xmtxt = value;
		}
	}

	internal virtual LabelX LabelX5
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX5 = value;
		}
	}

	internal virtual LabelX LabelX3
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX3 = value;
		}
	}

	internal virtual LabelX LabelX1
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX1 = value;
		}
	}

	internal virtual DateTimePicker jcrq
	{
		[DebuggerNonUserCode]
		get
		{
			return _jcrq;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_jcrq = value;
		}
	}

	internal virtual WizardPage WizardPage2
	{
		[DebuggerNonUserCode]
		get
		{
			return _WizardPage2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WizardPage2 = value;
		}
	}

	internal virtual ListBox lbjiegouxingshi
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbjiegouxingshi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbjiegouxingshi = value;
		}
	}

	internal virtual TextBoxX pathdoc
	{
		[DebuggerNonUserCode]
		get
		{
			return _pathdoc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_pathdoc = value;
		}
	}

	internal virtual ButtonX openDoc
	{
		[DebuggerNonUserCode]
		get
		{
			return _openDoc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = openDoc_Click;
			if (_openDoc != null)
			{
				((Control)_openDoc).remove_Click(eventHandler);
			}
			_openDoc = value;
			if (_openDoc != null)
			{
				((Control)_openDoc).add_Click(eventHandler);
			}
		}
	}

	internal virtual OpenFileDialog GetOpenFilename
	{
		[DebuggerNonUserCode]
		get
		{
			return _GetOpenFilename;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GetOpenFilename = value;
		}
	}

	internal virtual TextBoxX jielunTXT
	{
		[DebuggerNonUserCode]
		get
		{
			return _jielunTXT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_jielunTXT = value;
		}
	}

	internal virtual LabelX LabelX10
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX10 = value;
		}
	}

	internal virtual SaveFileDialog GetSaveFilename
	{
		[DebuggerNonUserCode]
		get
		{
			return _GetSaveFilename;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GetSaveFilename = value;
		}
	}

	internal virtual ButtonX liulan
	{
		[DebuggerNonUserCode]
		get
		{
			return _liulan;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = liulan_Click;
			if (_liulan != null)
			{
				((Control)_liulan).remove_Click(eventHandler);
			}
			_liulan = value;
			if (_liulan != null)
			{
				((Control)_liulan).add_Click(eventHandler);
			}
		}
	}

	internal virtual LabelX lbjd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbjd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbjd = value;
		}
	}

	internal virtual ProgressBarX PBX1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PBX1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PBX1 = value;
		}
	}

	internal virtual CheckBoxX CBXchuli
	{
		[DebuggerNonUserCode]
		get
		{
			return _CBXchuli;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CBXchuli_CheckedChanged;
			if (_CBXchuli != null)
			{
				_CBXchuli.remove_CheckedChanged(eventHandler);
			}
			_CBXchuli = value;
			if (_CBXchuli != null)
			{
				_CBXchuli.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual CheckBoxX CBXlog
	{
		[DebuggerNonUserCode]
		get
		{
			return _CBXlog;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CBXlog = value;
		}
	}

	public frmWord()
	{
		((Form)this).add_Load((EventHandler)frmWord_Load);
		arraybj = new ArrayList();
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
			((Office2007Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
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
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected O, but got Unknown
		//IL_0f19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f23: Expected O, but got Unknown
		//IL_111f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1129: Expected O, but got Unknown
		//IL_118e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1198: Expected O, but got Unknown
		//IL_11af: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b9: Expected O, but got Unknown
		//IL_1a67: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a71: Expected O, but got Unknown
		//IL_1abe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac8: Expected O, but got Unknown
		WizardPage1 = new WizardPage();
		liulan = new ButtonX();
		jcrq = new DateTimePicker();
		wdljtxt = new TextBoxX();
		scyjtxt = new TextBoxX();
		jcbmtxt = new TextBoxX();
		jcrtxt = new TextBoxX();
		LabelX9 = new LabelX();
		LabelX8 = new LabelX();
		LabelX6 = new LabelX();
		LabelX4 = new LabelX();
		LabelX2 = new LabelX();
		cjbmtxt = new TextBoxX();
		cjrtxt = new TextBoxX();
		smtxt = new TextBoxX();
		xmtxt = new TextBoxX();
		LabelX5 = new LabelX();
		LabelX3 = new LabelX();
		LabelX1 = new LabelX();
		LabelX7 = new LabelX();
		WizardPage3 = new WizardPage();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Wizard1 = new Wizard();
		WizardPage2 = new WizardPage();
		CBXlog = new CheckBoxX();
		openDoc = new ButtonX();
		lbjd = new LabelX();
		PBX1 = new ProgressBarX();
		jielunTXT = new TextBoxX();
		LabelX10 = new LabelX();
		pathdoc = new TextBoxX();
		lbjiegouxingshi = new ListBox();
		GetOpenFilename = new OpenFileDialog();
		GetSaveFilename = new SaveFileDialog();
		CBXchuli = new CheckBoxX();
		((Control)WizardPage1).SuspendLayout();
		((Control)WizardPage3).SuspendLayout();
		((Control)Wizard1).SuspendLayout();
		((Control)WizardPage2).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)WizardPage1).set_Anchor((AnchorStyles)15);
		WizardPage1.set_BackColor(Color.Transparent);
		((PanelControl)WizardPage1).set_ColorSchemeStyle((eDotNetBarStyle)4);
		((Control)WizardPage1).get_Controls().Add((Control)(object)liulan);
		((Control)WizardPage1).get_Controls().Add((Control)(object)jcrq);
		((Control)WizardPage1).get_Controls().Add((Control)(object)wdljtxt);
		((Control)WizardPage1).get_Controls().Add((Control)(object)scyjtxt);
		((Control)WizardPage1).get_Controls().Add((Control)(object)jcbmtxt);
		((Control)WizardPage1).get_Controls().Add((Control)(object)jcrtxt);
		((Control)WizardPage1).get_Controls().Add((Control)(object)LabelX9);
		((Control)WizardPage1).get_Controls().Add((Control)(object)LabelX8);
		((Control)WizardPage1).get_Controls().Add((Control)(object)LabelX6);
		((Control)WizardPage1).get_Controls().Add((Control)(object)LabelX4);
		((Control)WizardPage1).get_Controls().Add((Control)(object)LabelX2);
		((Control)WizardPage1).get_Controls().Add((Control)(object)cjbmtxt);
		((Control)WizardPage1).get_Controls().Add((Control)(object)cjrtxt);
		((Control)WizardPage1).get_Controls().Add((Control)(object)smtxt);
		((Control)WizardPage1).get_Controls().Add((Control)(object)xmtxt);
		((Control)WizardPage1).get_Controls().Add((Control)(object)LabelX5);
		((Control)WizardPage1).get_Controls().Add((Control)(object)LabelX3);
		((Control)WizardPage1).get_Controls().Add((Control)(object)LabelX1);
		((Control)WizardPage1).get_Controls().Add((Control)(object)LabelX7);
		((Control)WizardPage1).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		WizardPage wizardPage = WizardPage1;
		Point location = new Point(7, 102);
		((Control)wizardPage).set_Location(location);
		((Control)WizardPage1).set_Name("WizardPage1");
		WizardPage1.set_PageTitle("简介信息");
		WizardPage wizardPage2 = WizardPage1;
		Size size = new Size(530, 254);
		((Control)wizardPage2).set_Size(size);
		((PanelControl)WizardPage1).get_Style().set_Class("");
		((PanelControl)WizardPage1).get_Style().set_CornerType((eCornerType)1);
		((PanelControl)WizardPage1).get_StyleMouseDown().set_Class("");
		((PanelControl)WizardPage1).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)WizardPage1).get_StyleMouseOver().set_Class("");
		((PanelControl)WizardPage1).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)WizardPage1).set_TabIndex(10);
		((Control)liulan).set_AccessibleRole((AccessibleRole)43);
		liulan.set_ColorTable((eButtonColor)3);
		ButtonX obj = liulan;
		location = new Point(433, 225);
		((Control)obj).set_Location(location);
		((Control)liulan).set_Name("liulan");
		ButtonX obj2 = liulan;
		size = new Size(63, 25);
		((Control)obj2).set_Size(size);
		((PopupItemControl)liulan).set_Style((eDotNetBarStyle)7);
		((Control)liulan).set_TabIndex(7);
		liulan.set_Text("浏览...");
		DateTimePicker obj3 = jcrq;
		location = new Point(105, 171);
		((Control)obj3).set_Location(location);
		((Control)jcrq).set_Name("jcrq");
		DateTimePicker obj4 = jcrq;
		size = new Size(391, 21);
		((Control)obj4).set_Size(size);
		((Control)jcrq).set_TabIndex(3);
		((Control)jcrq).set_TabStop(false);
		wdljtxt.get_Border().set_Class("TextBoxBorder");
		wdljtxt.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj5 = wdljtxt;
		location = new Point(105, 227);
		((Control)obj5).set_Location(location);
		((Control)wdljtxt).set_Name("wdljtxt");
		((TextBoxBase)wdljtxt).set_ReadOnly(true);
		TextBoxX obj6 = wdljtxt;
		size = new Size(322, 21);
		((Control)obj6).set_Size(size);
		((Control)wdljtxt).set_TabIndex(2);
		((Control)wdljtxt).set_TabStop(false);
		scyjtxt.get_Border().set_Class("TextBoxBorder");
		scyjtxt.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj7 = scyjtxt;
		location = new Point(105, 199);
		((Control)obj7).set_Location(location);
		((Control)scyjtxt).set_Name("scyjtxt");
		TextBoxX obj8 = scyjtxt;
		size = new Size(391, 21);
		((Control)obj8).set_Size(size);
		((Control)scyjtxt).set_TabIndex(6);
		jcbmtxt.get_Border().set_Class("TextBoxBorder");
		jcbmtxt.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj9 = jcbmtxt;
		location = new Point(105, 143);
		((Control)obj9).set_Location(location);
		((Control)jcbmtxt).set_Name("jcbmtxt");
		TextBoxX obj10 = jcbmtxt;
		size = new Size(391, 21);
		((Control)obj10).set_Size(size);
		((Control)jcbmtxt).set_TabIndex(5);
		jcrtxt.get_Border().set_Class("TextBoxBorder");
		jcrtxt.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj11 = jcrtxt;
		location = new Point(105, 115);
		((Control)obj11).set_Location(location);
		((Control)jcrtxt).set_Name("jcrtxt");
		TextBoxX obj12 = jcrtxt;
		size = new Size(391, 21);
		((Control)obj12).set_Size(size);
		((Control)jcrtxt).set_TabIndex(4);
		((BaseItemControl)LabelX9).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX9).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX = LabelX9;
		location = new Point(33, 227);
		((Control)labelX).set_Location(location);
		((Control)LabelX9).set_Name("LabelX9");
		LabelX labelX2 = LabelX9;
		size = new Size(69, 23);
		((Control)labelX2).set_Size(size);
		((Control)LabelX9).set_TabIndex(1);
		LabelX9.set_Text("文档路径：");
		((BaseItemControl)LabelX8).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX8).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX3 = LabelX8;
		location = new Point(20, 199);
		((Control)labelX3).set_Location(location);
		((Control)LabelX8).set_Name("LabelX8");
		LabelX labelX4 = LabelX8;
		size = new Size(79, 23);
		((Control)labelX4).set_Size(size);
		((Control)LabelX8).set_TabIndex(1);
		LabelX8.set_Text("审核人意见：");
		((BaseItemControl)LabelX6).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX6).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX5 = LabelX6;
		location = new Point(30, 171);
		((Control)labelX5).set_Location(location);
		((Control)LabelX6).set_Name("LabelX6");
		LabelX labelX6 = LabelX6;
		size = new Size(69, 23);
		((Control)labelX6).set_Size(size);
		((Control)LabelX6).set_TabIndex(1);
		LabelX6.set_Text("检查日期：\t");
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX7 = LabelX4;
		location = new Point(20, 143);
		((Control)labelX7).set_Location(location);
		((Control)LabelX4).set_Name("LabelX4");
		LabelX labelX8 = LabelX4;
		size = new Size(79, 23);
		((Control)labelX8).set_Size(size);
		((Control)LabelX4).set_TabIndex(1);
		LabelX4.set_Text("检查人部门：");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX9 = LabelX2;
		location = new Point(43, 115);
		((Control)labelX9).set_Location(location);
		((Control)LabelX2).set_Name("LabelX2");
		LabelX labelX10 = LabelX2;
		size = new Size(56, 23);
		((Control)labelX10).set_Size(size);
		((Control)LabelX2).set_TabIndex(1);
		LabelX2.set_Text("检查人：");
		cjbmtxt.get_Border().set_Class("TextBoxBorder");
		cjbmtxt.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj13 = cjbmtxt;
		location = new Point(105, 87);
		((Control)obj13).set_Location(location);
		((Control)cjbmtxt).set_Name("cjbmtxt");
		TextBoxX obj14 = cjbmtxt;
		size = new Size(391, 21);
		((Control)obj14).set_Size(size);
		((Control)cjbmtxt).set_TabIndex(3);
		cjrtxt.get_Border().set_Class("TextBoxBorder");
		cjrtxt.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj15 = cjrtxt;
		location = new Point(105, 59);
		((Control)obj15).set_Location(location);
		((Control)cjrtxt).set_Name("cjrtxt");
		TextBoxX obj16 = cjrtxt;
		size = new Size(391, 21);
		((Control)obj16).set_Size(size);
		((Control)cjrtxt).set_TabIndex(2);
		smtxt.get_Border().set_Class("TextBoxBorder");
		smtxt.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj17 = smtxt;
		location = new Point(105, 31);
		((Control)obj17).set_Location(location);
		((Control)smtxt).set_Name("smtxt");
		TextBoxX obj18 = smtxt;
		size = new Size(391, 21);
		((Control)obj18).set_Size(size);
		((Control)smtxt).set_TabIndex(1);
		xmtxt.get_Border().set_Class("TextBoxBorder");
		xmtxt.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj19 = xmtxt;
		location = new Point(105, 3);
		((Control)obj19).set_Location(location);
		((Control)xmtxt).set_Name("xmtxt");
		TextBoxX obj20 = xmtxt;
		size = new Size(391, 21);
		((Control)obj20).set_Size(size);
		((Control)xmtxt).set_TabIndex(0);
		((BaseItemControl)LabelX5).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX5).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX11 = LabelX5;
		location = new Point(43, 59);
		((Control)labelX11).set_Location(location);
		((Control)LabelX5).set_Name("LabelX5");
		LabelX labelX12 = LabelX5;
		size = new Size(56, 23);
		((Control)labelX12).set_Size(size);
		((Control)LabelX5).set_TabIndex(1);
		LabelX5.set_Text("创建人：");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX13 = LabelX3;
		location = new Point(29, 31);
		((Control)labelX13).set_Location(location);
		((Control)LabelX3).set_Name("LabelX3");
		LabelX labelX14 = LabelX3;
		size = new Size(69, 23);
		((Control)labelX14).set_Size(size);
		((Control)LabelX3).set_TabIndex(1);
		LabelX3.set_Text("项目说明：");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX15 = LabelX1;
		location = new Point(29, 3);
		((Control)labelX15).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX16 = LabelX1;
		size = new Size(69, 23);
		((Control)labelX16).set_Size(size);
		((Control)LabelX1).set_TabIndex(1);
		LabelX1.set_Text("项目名称：");
		((BaseItemControl)LabelX7).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX7).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX17 = LabelX7;
		location = new Point(19, 87);
		((Control)labelX17).set_Location(location);
		((Control)LabelX7).set_Name("LabelX7");
		LabelX labelX18 = LabelX7;
		size = new Size(79, 23);
		((Control)labelX18).set_Size(size);
		((Control)LabelX7).set_TabIndex(1);
		LabelX7.set_Text("创建人部门：");
		((Control)WizardPage3).set_Anchor((AnchorStyles)15);
		WizardPage3.set_BackColor(Color.Transparent);
		((Control)WizardPage3).get_Controls().Add((Control)(object)Label1);
		((Control)WizardPage3).get_Controls().Add((Control)(object)Label2);
		((Control)WizardPage3).get_Controls().Add((Control)(object)Label3);
		WizardPage3.set_InteriorPage(false);
		WizardPage wizardPage3 = WizardPage3;
		location = new Point(0, 0);
		((Control)wizardPage3).set_Location(location);
		((Control)WizardPage3).set_Name("WizardPage3");
		WizardPage wizardPage4 = WizardPage3;
		size = new Size(544, 368);
		((Control)wizardPage4).set_Size(size);
		((PanelControl)WizardPage3).get_Style().set_Class("");
		((PanelControl)WizardPage3).get_Style().set_CornerType((eCornerType)1);
		((PanelControl)WizardPage3).get_StyleMouseDown().set_Class("");
		((PanelControl)WizardPage3).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)WizardPage3).get_StyleMouseOver().set_Class("");
		((PanelControl)WizardPage3).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)WizardPage3).set_TabIndex(9);
		((Control)Label1).set_Anchor((AnchorStyles)13);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_Font(new Font("Tahoma", 16f));
		Label label = Label1;
		location = new Point(210, 18);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(320, 66);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("欢迎使用计算报告生成向导...");
		((Control)Label2).set_Anchor((AnchorStyles)15);
		((Control)Label2).set_BackColor(Color.Transparent);
		Label label3 = Label2;
		location = new Point(210, 100);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(234, 172);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("本向导可以帮助您自动建立\"计算报告\"WORD文件");
		((Control)Label3).set_Anchor((AnchorStyles)6);
		((Control)Label3).set_BackColor(Color.Transparent);
		Label label5 = Label3;
		location = new Point(210, 331);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(234, 15);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(2);
		Label3.set_Text("单击\"下一步\"开始填写基本信息");
		Wizard1.set_BackButtonText("上一步");
		((Control)Wizard1).set_BackColor(Color.FromArgb(205, 229, 253));
		Wizard1.set_ButtonStyle((eWizardStyle)1);
		Wizard1.set_CancelButtonText("取消");
		((Control)Wizard1).set_Cursor(Cursors.get_Default());
		((Control)Wizard1).set_Dock((DockStyle)5);
		Wizard1.set_FinishButtonTabIndex(3);
		Wizard1.set_FinishButtonText("完成");
		((Control)Wizard1).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		Wizard1.get_FooterStyle().set_BackColor(Color.Transparent);
		Wizard1.get_FooterStyle().set_Class("");
		Wizard1.get_FooterStyle().set_CornerType((eCornerType)1);
		((Control)Wizard1).set_ForeColor(Color.FromArgb(15, 57, 129));
		Wizard1.set_HeaderCaptionFont(new Font("宋体", 12f, (FontStyle)1));
		Wizard1.set_HeaderDescriptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		Wizard1.set_HeaderDescriptionIndent(62);
		Wizard1.set_HeaderDescriptionVisible(false);
		Wizard1.set_HeaderHeight(90);
		Wizard1.set_HeaderImageAlignment((eWizardTitleImageAlignment)0);
		Wizard1.set_HeaderImageVisible(false);
		Wizard1.get_HeaderStyle().set_BackColor(Color.Transparent);
		Wizard1.get_HeaderStyle().set_BackColorGradientAngle(90);
		Wizard1.get_HeaderStyle().set_BorderBottom((eStyleBorderType)1);
		Wizard1.get_HeaderStyle().set_BorderBottomColor(Color.FromArgb(121, 157, 182));
		Wizard1.get_HeaderStyle().set_BorderBottomWidth(1);
		Wizard1.get_HeaderStyle().set_BorderColor(SystemColors.Control);
		Wizard1.get_HeaderStyle().set_BorderLeftWidth(1);
		Wizard1.get_HeaderStyle().set_BorderRightWidth(1);
		Wizard1.get_HeaderStyle().set_BorderTopWidth(1);
		Wizard1.get_HeaderStyle().set_Class("");
		Wizard1.get_HeaderStyle().set_CornerType((eCornerType)1);
		Wizard1.get_HeaderStyle().set_TextAlignment((eStyleTextAlignment)1);
		Wizard1.get_HeaderStyle().set_TextColorSchemePart((eColorSchemePart)54);
		Wizard1.set_HeaderTitleIndent(62);
		Wizard1.set_HelpButtonText("帮助");
		Wizard1.set_HelpButtonVisible(false);
		Wizard wizard = Wizard1;
		location = new Point(0, 0);
		((Control)wizard).set_Location(location);
		((Control)Wizard1).set_Name("Wizard1");
		Wizard1.set_NextButtonText("下一步");
		Wizard1.set_PageChangeDisableButtons(false);
		Wizard1.set_PageChangeWaitCursor(false);
		Wizard wizard2 = Wizard1;
		size = new Size(544, 414);
		((Control)wizard2).set_Size(size);
		((Control)Wizard1).set_TabIndex(0);
		Wizard1.get_WizardPages().AddRange((WizardPage[])(object)new WizardPage[3] { WizardPage3, WizardPage1, WizardPage2 });
		((Control)WizardPage2).set_Anchor((AnchorStyles)15);
		((PanelControl)WizardPage2).set_AntiAlias(false);
		WizardPage2.set_BackColor(Color.Transparent);
		((PanelControl)WizardPage2).set_ColorSchemeStyle((eDotNetBarStyle)0);
		((Control)WizardPage2).get_Controls().Add((Control)(object)CBXlog);
		((Control)WizardPage2).get_Controls().Add((Control)(object)openDoc);
		((Control)WizardPage2).get_Controls().Add((Control)(object)lbjd);
		((Control)WizardPage2).get_Controls().Add((Control)(object)PBX1);
		((Control)WizardPage2).get_Controls().Add((Control)(object)jielunTXT);
		((Control)WizardPage2).get_Controls().Add((Control)(object)LabelX10);
		((Control)WizardPage2).get_Controls().Add((Control)(object)pathdoc);
		((Control)WizardPage2).get_Controls().Add((Control)(object)lbjiegouxingshi);
		WizardPage wizardPage5 = WizardPage2;
		location = new Point(7, 102);
		((Control)wizardPage5).set_Location(location);
		((Control)WizardPage2).set_Name("WizardPage2");
		WizardPage2.set_PageTitle("参数信息");
		WizardPage wizardPage6 = WizardPage2;
		size = new Size(530, 254);
		((Control)wizardPage6).set_Size(size);
		((PanelControl)WizardPage2).get_Style().set_Class("");
		((PanelControl)WizardPage2).get_Style().set_CornerType((eCornerType)1);
		((PanelControl)WizardPage2).get_StyleMouseDown().set_Class("");
		((PanelControl)WizardPage2).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)WizardPage2).get_StyleMouseOver().set_Class("");
		((PanelControl)WizardPage2).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)WizardPage2).set_TabIndex(11);
		((BaseItemControl)CBXlog).get_BackgroundStyle().set_Class("");
		((BaseItemControl)CBXlog).get_BackgroundStyle().set_CornerType((eCornerType)1);
		CheckBoxX cBXlog = CBXlog;
		location = new Point(174, 197);
		((Control)cBXlog).set_Location(location);
		((Control)CBXlog).set_Name("CBXlog");
		CheckBoxX cBXlog2 = CBXlog;
		size = new Size(128, 20);
		((Control)cBXlog2).set_Size(size);
		((BaseItemControl)CBXlog).set_Style((eDotNetBarStyle)7);
		((Control)CBXlog).set_TabIndex(1);
		CBXlog.set_Text("追加操作流程信息");
		((Control)openDoc).set_AccessibleRole((AccessibleRole)43);
		openDoc.set_ColorTable((eButtonColor)3);
		ButtonX obj21 = openDoc;
		location = new Point(174, 0);
		((Control)obj21).set_Location(location);
		((Control)openDoc).set_Name("openDoc");
		ButtonX obj22 = openDoc;
		size = new Size(168, 23);
		((Control)obj22).set_Size(size);
		((PopupItemControl)openDoc).set_Style((eDotNetBarStyle)7);
		((Control)openDoc).set_TabIndex(2);
		openDoc.set_Text("指定要插入的性能表WORD...");
		((BaseItemControl)lbjd).get_BackgroundStyle().set_Class("");
		((BaseItemControl)lbjd).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX obj23 = lbjd;
		location = new Point(487, 228);
		((Control)obj23).set_Location(location);
		((Control)lbjd).set_Name("lbjd");
		LabelX obj24 = lbjd;
		size = new Size(38, 23);
		((Control)obj24).set_Size(size);
		((Control)lbjd).set_TabIndex(6);
		lbjd.set_Text("0%");
		((BaseItemControl)PBX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)PBX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		ProgressBarX pBX = PBX1;
		location = new Point(0, 228);
		((Control)pBX).set_Location(location);
		((Control)PBX1).set_Name("PBX1");
		ProgressBarX pBX2 = PBX1;
		size = new Size(481, 23);
		((Control)pBX2).set_Size(size);
		((Control)PBX1).set_TabIndex(5);
		((Control)PBX1).set_Text("ProgressBarX1");
		((TextBox)jielunTXT).set_AcceptsReturn(true);
		jielunTXT.get_Border().set_Class("TextBoxBorder");
		jielunTXT.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj25 = jielunTXT;
		location = new Point(174, 80);
		((Control)obj25).set_Location(location);
		((TextBox)jielunTXT).set_Multiline(true);
		((Control)jielunTXT).set_Name("jielunTXT");
		TextBoxX obj26 = jielunTXT;
		size = new Size(314, 111);
		((Control)obj26).set_Size(size);
		((Control)jielunTXT).set_TabIndex(4);
		((BaseItemControl)LabelX10).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX10).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX19 = LabelX10;
		location = new Point(174, 56);
		((Control)labelX19).set_Location(location);
		((Control)LabelX10).set_Name("LabelX10");
		LabelX labelX20 = LabelX10;
		size = new Size(90, 18);
		((Control)labelX20).set_Size(size);
		((Control)LabelX10).set_TabIndex(3);
		LabelX10.set_Text("结论：");
		pathdoc.get_Border().set_Class("TextBoxBorder");
		pathdoc.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj27 = pathdoc;
		location = new Point(174, 29);
		((Control)obj27).set_Location(location);
		((Control)pathdoc).set_Name("pathdoc");
		TextBoxX obj28 = pathdoc;
		size = new Size(314, 21);
		((Control)obj28).set_Size(size);
		((Control)pathdoc).set_TabIndex(1);
		((ListControl)lbjiegouxingshi).set_FormattingEnabled(true);
		lbjiegouxingshi.set_ItemHeight(12);
		ListBox obj29 = lbjiegouxingshi;
		location = new Point(0, 0);
		((Control)obj29).set_Location(location);
		((Control)lbjiegouxingshi).set_Name("lbjiegouxingshi");
		ListBox obj30 = lbjiegouxingshi;
		size = new Size(168, 220);
		((Control)obj30).set_Size(size);
		((Control)lbjiegouxingshi).set_TabIndex(0);
		((FileDialog)GetOpenFilename).set_FileName("OpenFileDialog1");
		((FileDialog)GetSaveFilename).set_Filter("Word 文档|*.doc");
		((BaseItemControl)CBXchuli).get_BackgroundStyle().set_Class("");
		((BaseItemControl)CBXchuli).get_BackgroundStyle().set_CornerType((eCornerType)1);
		CheckBoxX cBXchuli = CBXchuli;
		location = new Point(7, 362);
		((Control)cBXchuli).set_Location(location);
		((Control)CBXchuli).set_Name("CBXchuli");
		CheckBoxX cBXchuli2 = CBXchuli;
		size = new Size(191, 20);
		((Control)cBXchuli2).set_Size(size);
		((BaseItemControl)CBXchuli).set_Style((eDotNetBarStyle)7);
		((Control)CBXchuli).set_TabIndex(1);
		CBXchuli.set_Text("WORD计算报告生成过程可见");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(544, 414);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)CBXchuli);
		((Control)this).get_Controls().Add((Control)(object)Wizard1);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("frmWord");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("计算报告生成...");
		((Control)WizardPage1).ResumeLayout(false);
		((Control)WizardPage3).ResumeLayout(false);
		((Control)Wizard1).ResumeLayout(false);
		((Control)WizardPage2).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void Wizard1_FinishButtonClick(object sender, CancelEventArgs e)
	{
	}

	public void cs(ref string var)
	{
		DataTable table = new DataTable("VAR");
		ArrayList arrayList = new ArrayList();
		Mod1.lr = new StreamReader(var, Encoding.Default);
		string text = "";
		while (!Information.IsNothing((object)text))
		{
			text = Mod1.lr.ReadLine();
			if (Information.IsNothing((object)text))
			{
				break;
			}
			arrayList.Add(text);
		}
		Mod1.lr.Close();
		Mod1.lr.Dispose();
		table.Columns.Add("参数名");
		table.Columns.Add("参数值");
		table.Columns.Add("备注");
		checked
		{
			int num = arrayList.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				text = Conversions.ToString(arrayList[i]);
				string[] array = text.Split(new char[1] { '!' });
				string text2 = array[0];
				string[] array2 = text2.Split(new char[1] { '=' });
				DataRow dataRow = table.NewRow();
				dataRow[0] = array2[0];
				dataRow[1] = array2[1];
				dataRow[2] = array[1];
				table.Rows.Add(dataRow);
			}
			ModWord.InsertTable(ref table);
		}
	}

	public void Gongkuang(ref string var)
	{
		ArrayList arrayList = new ArrayList();
		Mod1.lr = new StreamReader(var, Encoding.Default);
		string text = "";
		while (!Information.IsNothing((object)text))
		{
			text = Mod1.lr.ReadLine();
			if (Information.IsNothing((object)text))
			{
				break;
			}
			arrayList.Add(text);
		}
		Mod1.lr.Close();
		Mod1.lr.Dispose();
		checked
		{
			int num = arrayList.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				ModWord.InsertText(Conversions.ToString(arrayList[i]));
				ModWord.InsertText("\r\n");
			}
		}
	}

	public void liucheng(ref string log)
	{
		ArrayList arrayList = new ArrayList();
		Mod1.lr = new StreamReader(log, Encoding.Default);
		string text = "";
		while (!Information.IsNothing((object)text))
		{
			text = Mod1.lr.ReadLine();
			if (Information.IsNothing((object)text))
			{
				break;
			}
			arrayList.Add(text);
		}
		Mod1.lr.Close();
		Mod1.lr.Dispose();
		checked
		{
			int num = arrayList.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				ModWord.InsertText(Conversions.ToString(arrayList[i]));
				ModWord.InsertText("\r\n");
			}
		}
	}

	private void openDoc_Click(object sender, EventArgs e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		((FileDialog)GetOpenFilename).set_Filter("test.doc|test.doc");
		if ((int)((CommonDialog)GetOpenFilename).ShowDialog() == 1)
		{
			((TextBox)pathdoc).set_Text(((FileDialog)GetOpenFilename).get_FileName());
		}
	}

	private void frmWord_Load(object sender, EventArgs e)
	{
		if (ModWord.oWordApplic == null)
		{
			Guid clsid = new Guid("000209FF-0000-0000-C000-000000000046");
			ModWord.oWordApplic = (Application)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		}
		if (lbjiegouxingshi.get_Items().get_Count() != 0)
		{
			return;
		}
		string path = Application.get_StartupPath() + "\\config\\装配列表说明.ini";
		Mod1.lr = new StreamReader(path, Encoding.Default);
		string text = "";
		while (true)
		{
			if (!Information.IsNothing((object)text))
			{
				text = Mod1.lr.ReadLine();
				if (!Information.IsNothing((object)text))
				{
					if (Operators.CompareString(Strings.Trim(text), "", false) != 0)
					{
						lbjiegouxingshi.get_Items().Add((object)text);
						continue;
					}
					break;
				}
			}
			Mod1.lr.Close();
			Mod1.lr.Dispose();
			break;
		}
	}

	private void liulan_Click(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)((CommonDialog)GetSaveFilename).ShowDialog() == 1)
		{
			((TextBox)wdljtxt).set_Text(((FileDialog)GetSaveFilename).get_FileName());
		}
	}

	private void WizardPage1_NextButtonClick(object sender, CancelEventArgs e)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(((TextBox)wdljtxt).get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"当前没有选择保存路径，程序会默认保存为：C:\\Temp.doc", (MsgBoxStyle)64, (object)"提示");
			((TextBox)wdljtxt).set_Text("C:\\Temp.doc");
		}
	}

	private void CBXchuli_CheckedChanged(object sender, EventArgs e)
	{
		if (CBXchuli.get_Checked())
		{
			ModWord.oWordApplic.Visible = true;
		}
		else
		{
			ModWord.oWordApplic.Visible = false;
		}
	}

	private void Wizard1_CancelButtonClick(object sender, CancelEventArgs e)
	{
		ModWord.Quit();
	}
}
