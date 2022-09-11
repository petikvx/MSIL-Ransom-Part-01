using System;
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
using ns0;

namespace ns1;

[DesignerGenerated]
public class Load2 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("NotifyIcon1")]
	private NotifyIcon _NotifyIcon1;

	[AccessedThroughProperty("NotPause")]
	private Timer _NotPause;

	[AccessedThroughProperty("FileSystemWatcher1")]
	private FileSystemWatcher _FileSystemWatcher1;

	[AccessedThroughProperty("OpenFileDialog1")]
	private OpenFileDialog _OpenFileDialog1;

	[AccessedThroughProperty("ContextMenuStrip1")]
	private ContextMenuStrip _ContextMenuStrip1;

	[AccessedThroughProperty("AbrirSatwneytToolStripMenuItem")]
	private ToolStripMenuItem _AbrirSatwneytToolStripMenuItem;

	[AccessedThroughProperty("FerramentaDeArquivoToolStripMenuItem")]
	private ToolStripMenuItem _FerramentaDeArquivoToolStripMenuItem;

	[AccessedThroughProperty("FirewallLoad")]
	private Timer _FirewallLoad;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("DC")]
	private Label _DC;

	[AccessedThroughProperty("TextBox3")]
	private TextBox _TextBox3;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("RichTextAtua")]
	private RichTextBox _RichTextAtua;

	[AccessedThroughProperty("TextInfoVersion")]
	private TextBox _TextInfoVersion;

	[AccessedThroughProperty("TextBox9")]
	private TextBox _TextBox9;

	[AccessedThroughProperty("TextBox4")]
	private TextBox _TextBox4;

	[AccessedThroughProperty("httpclient")]
	private WebClient _httpclient;

	private TextBox a;

	private TextBox be;

	private TextBox c;

	private TextBox de;

	private TextBox fe;

	private TextBox g;

	private TextBox h;

	private TextBox ii;

	private TextBox j;

	private TextBox k;

	private TextBox m;

	private TextBox n;

	private TextBox jot;

	private TextBox van;

	private TextBox vn;

	private TextBox jjk;

	private TextBox hh;

	private TextBox ww;

	private TextBox QQ;

	private TextBox ll;

	private TextBox avz;

	private TextBox jjjc;

	private TextBox can;

	private TextBox sss;

	private TextBox ass;

	private TextBox sbs;

	private TextBox ffa;

	private TextBox jfa;

	private TextBox jaaa;

	private TextBox gov;

	private TextBox fd;

	private TextBox cox;

	private TextBox tr;

	private TextBox pc;

	private Label cp;

	internal virtual NotifyIcon NotifyIcon1
	{
		[DebuggerNonUserCode]
		get
		{
			return _NotifyIcon1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(NotifyIcon1_MouseDoubleClick);
			MouseEventHandler val2 = new MouseEventHandler(NotifyIcon1_MouseDown);
			if (_NotifyIcon1 != null)
			{
				_NotifyIcon1.remove_MouseDoubleClick(val);
				_NotifyIcon1.remove_MouseDown(val2);
			}
			_NotifyIcon1 = value;
			if (_NotifyIcon1 != null)
			{
				_NotifyIcon1.add_MouseDoubleClick(val);
				_NotifyIcon1.add_MouseDown(val2);
			}
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

	internal virtual FileSystemWatcher FileSystemWatcher1
	{
		[DebuggerNonUserCode]
		get
		{
			return _FileSystemWatcher1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			FileSystemEventHandler value2 = FileSystemWatcher1_Changed;
			if (_FileSystemWatcher1 != null)
			{
				_FileSystemWatcher1.Changed -= value2;
			}
			_FileSystemWatcher1 = value;
			if (_FileSystemWatcher1 != null)
			{
				_FileSystemWatcher1.Changed += value2;
			}
		}
	}

	internal virtual OpenFileDialog OpenFileDialog1
	{
		[DebuggerNonUserCode]
		get
		{
			return _OpenFileDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_OpenFileDialog1 = value;
		}
	}

	internal virtual ContextMenuStrip ContextMenuStrip1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ContextMenuStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ContextMenuStrip1 = value;
		}
	}

	internal virtual ToolStripMenuItem AbrirSatwneytToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _AbrirSatwneytToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = AbrirSatwneytToolStripMenuItem_Click;
			if (_AbrirSatwneytToolStripMenuItem != null)
			{
				((ToolStripItem)_AbrirSatwneytToolStripMenuItem).remove_Click(eventHandler);
			}
			_AbrirSatwneytToolStripMenuItem = value;
			if (_AbrirSatwneytToolStripMenuItem != null)
			{
				((ToolStripItem)_AbrirSatwneytToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem FerramentaDeArquivoToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _FerramentaDeArquivoToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = FerramentaDeArquivoToolStripMenuItem_Click;
			if (_FerramentaDeArquivoToolStripMenuItem != null)
			{
				((ToolStripItem)_FerramentaDeArquivoToolStripMenuItem).remove_Click(eventHandler);
			}
			_FerramentaDeArquivoToolStripMenuItem = value;
			if (_FerramentaDeArquivoToolStripMenuItem != null)
			{
				((ToolStripItem)_FerramentaDeArquivoToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual Timer FirewallLoad
	{
		[DebuggerNonUserCode]
		get
		{
			return _FirewallLoad;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Firewall_Tick;
			if (_FirewallLoad != null)
			{
				_FirewallLoad.remove_Tick(eventHandler);
			}
			_FirewallLoad = value;
			if (_FirewallLoad != null)
			{
				_FirewallLoad.add_Tick(eventHandler);
			}
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

	internal virtual TextBox TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox1 = value;
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

	internal virtual Label DC
	{
		[DebuggerNonUserCode]
		get
		{
			return _DC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DC = value;
		}
	}

	internal virtual TextBox TextBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox3 = value;
		}
	}

	internal virtual TextBox TextBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox2 = value;
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

	internal virtual RichTextBox RichTextAtua
	{
		[DebuggerNonUserCode]
		get
		{
			return _RichTextAtua;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RichTextAtua = value;
		}
	}

	internal virtual TextBox TextInfoVersion
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextInfoVersion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextInfoVersion = value;
		}
	}

	internal virtual TextBox TextBox9
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox9 = value;
		}
	}

	internal virtual TextBox TextBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox4 = value;
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
			_httpclient = value;
		}
	}

	public Load2()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Form1_Load);
		__ENCAddToList(this);
		a = new TextBox();
		be = new TextBox();
		c = new TextBox();
		de = new TextBox();
		fe = new TextBox();
		g = new TextBox();
		h = new TextBox();
		ii = new TextBox();
		j = new TextBox();
		k = new TextBox();
		m = new TextBox();
		n = new TextBox();
		jot = new TextBox();
		van = new TextBox();
		vn = new TextBox();
		jjk = new TextBox();
		hh = new TextBox();
		ww = new TextBox();
		QQ = new TextBox();
		ll = new TextBox();
		avz = new TextBox();
		jjjc = new TextBox();
		can = new TextBox();
		sss = new TextBox();
		ass = new TextBox();
		sbs = new TextBox();
		ffa = new TextBox();
		jfa = new TextBox();
		jaaa = new TextBox();
		gov = new TextBox();
		fd = new TextBox();
		cox = new TextBox();
		tr = new TextBox();
		pc = new TextBox();
		cp = new Label();
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
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		//IL_0792: Unknown result type (might be due to invalid IL or missing references)
		//IL_079c: Expected O, but got Unknown
		//IL_0901: Unknown result type (might be due to invalid IL or missing references)
		//IL_090b: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Load2));
		NotifyIcon1 = new NotifyIcon(components);
		ContextMenuStrip1 = new ContextMenuStrip(components);
		AbrirSatwneytToolStripMenuItem = new ToolStripMenuItem();
		FerramentaDeArquivoToolStripMenuItem = new ToolStripMenuItem();
		NotPause = new Timer(components);
		FileSystemWatcher1 = new FileSystemWatcher();
		OpenFileDialog1 = new OpenFileDialog();
		FirewallLoad = new Timer(components);
		TextBox1 = new TextBox();
		Label1 = new Label();
		DC = new Label();
		TextBox3 = new TextBox();
		TextBox2 = new TextBox();
		Label3 = new Label();
		RichTextAtua = new RichTextBox();
		TextInfoVersion = new TextBox();
		TextBox9 = new TextBox();
		TextBox4 = new TextBox();
		Label2 = new Label();
		((Control)ContextMenuStrip1).SuspendLayout();
		((ISupportInitialize)FileSystemWatcher1).BeginInit();
		((Control)this).SuspendLayout();
		NotifyIcon1.set_ContextMenuStrip(ContextMenuStrip1);
		NotifyIcon1.set_Icon((Icon)componentResourceManager.GetObject("NotifyIcon1.Icon"));
		NotifyIcon1.set_Text("SATWNEYT Edition Antivírus Plus One-X DEMO  DUOZ MATRIX TOTAL 6");
		((ToolStrip)ContextMenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)AbrirSatwneytToolStripMenuItem,
			(ToolStripItem)FerramentaDeArquivoToolStripMenuItem
		});
		((Control)ContextMenuStrip1).set_Name("ContextMenuStrip1");
		ContextMenuStrip contextMenuStrip = ContextMenuStrip1;
		Size size = new Size(196, 48);
		((Control)contextMenuStrip).set_Size(size);
		((Control)ContextMenuStrip1).set_Tag((object)"SATWNEYT PLUS ONE-X");
		((Control)ContextMenuStrip1).set_Text("SATWNEYT PLUS ONE-X");
		((ToolStripItem)AbrirSatwneytToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("AbrirSatwneytToolStripMenuItem.Image"));
		((ToolStripItem)AbrirSatwneytToolStripMenuItem).set_Name("AbrirSatwneytToolStripMenuItem");
		ToolStripMenuItem abrirSatwneytToolStripMenuItem = AbrirSatwneytToolStripMenuItem;
		size = new Size(195, 22);
		((ToolStripItem)abrirSatwneytToolStripMenuItem).set_Size(size);
		((ToolStripItem)AbrirSatwneytToolStripMenuItem).set_Text("Abrir Satwneyt");
		((ToolStripItem)FerramentaDeArquivoToolStripMenuItem).set_Name("FerramentaDeArquivoToolStripMenuItem");
		ToolStripMenuItem ferramentaDeArquivoToolStripMenuItem = FerramentaDeArquivoToolStripMenuItem;
		size = new Size(195, 22);
		((ToolStripItem)ferramentaDeArquivoToolStripMenuItem).set_Size(size);
		((ToolStripItem)FerramentaDeArquivoToolStripMenuItem).set_Text("Ferramenta de Arquivo");
		NotPause.set_Enabled(true);
		NotPause.set_Interval(1);
		FileSystemWatcher1.EnableRaisingEvents = true;
		FileSystemWatcher1.IncludeSubdirectories = true;
		FileSystemWatcher1.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.LastWrite | NotifyFilters.Security;
		FileSystemWatcher1.Path = "C:\\";
		FileSystemWatcher1.SynchronizingObject = (ISynchronizeInvoke?)this;
		((FileDialog)OpenFileDialog1).set_Filter("All files (*.*)|*.*");
		FirewallLoad.set_Enabled(true);
		FirewallLoad.set_Interval(1);
		TextBox textBox = TextBox1;
		Point location = new Point(374, 28);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		size = new Size(100, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(49);
		((Control)TextBox1).set_Visible(false);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(122, 35);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(17, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(48);
		Label1.set_Text("\"\"");
		((Control)Label1).set_Visible(false);
		DC.set_AutoSize(true);
		Label dC = DC;
		location = new Point(319, 52);
		((Control)dC).set_Location(location);
		((Control)DC).set_Name("DC");
		Label dC2 = DC;
		size = new Size(53, 13);
		((Control)dC2).set_Size(size);
		((Control)DC).set_TabIndex(47);
		DC.set_Text("Nenhuma");
		((Control)DC).set_Visible(false);
		TextBox textBox3 = TextBox3;
		location = new Point(357, 136);
		((Control)textBox3).set_Location(location);
		((Control)TextBox3).set_Name("TextBox3");
		TextBox textBox4 = TextBox3;
		size = new Size(100, 20);
		((Control)textBox4).set_Size(size);
		((Control)TextBox3).set_TabIndex(46);
		((Control)TextBox3).set_Visible(false);
		((TextBoxBase)TextBox2).set_BackColor(Color.White);
		TextBox textBox5 = TextBox2;
		location = new Point(459, 49);
		((Control)textBox5).set_Location(location);
		TextBox2.set_Multiline(true);
		((Control)TextBox2).set_Name("TextBox2");
		TextBox2.set_ScrollBars((ScrollBars)3);
		TextBox textBox6 = TextBox2;
		size = new Size(43, 20);
		((Control)textBox6).set_Size(size);
		((Control)TextBox2).set_TabIndex(45);
		TextBox2.set_Text(componentResourceManager.GetString("TextBox2.Text"));
		((Control)TextBox2).set_Visible(false);
		Label3.set_AutoSize(true);
		Label label3 = Label3;
		location = new Point(452, 76);
		((Control)label3).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label4 = Label3;
		size = new Size(37, 13);
		((Control)label4).set_Size(size);
		((Control)Label3).set_TabIndex(44);
		Label3.set_Text("{0:X2}");
		((Control)Label3).set_Visible(false);
		RichTextBox richTextAtua = RichTextAtua;
		location = new Point(357, 76);
		((Control)richTextAtua).set_Location(location);
		((Control)RichTextAtua).set_Name("RichTextAtua");
		RichTextBox richTextAtua2 = RichTextAtua;
		size = new Size(72, 34);
		((Control)richTextAtua2).set_Size(size);
		((Control)RichTextAtua).set_TabIndex(43);
		RichTextAtua.set_Text("");
		((Control)RichTextAtua).set_Visible(false);
		TextBox textInfoVersion = TextInfoVersion;
		location = new Point(469, 107);
		((Control)textInfoVersion).set_Location(location);
		((Control)TextInfoVersion).set_Name("TextInfoVersion");
		TextBox textInfoVersion2 = TextInfoVersion;
		size = new Size(10, 20);
		((Control)textInfoVersion2).set_Size(size);
		((Control)TextInfoVersion).set_TabIndex(42);
		TextInfoVersion.set_Text(componentResourceManager.GetString("TextInfoVersion.Text"));
		((Control)TextInfoVersion).set_Visible(false);
		((TextBoxBase)TextBox9).set_BackColor(Color.White);
		TextBox textBox7 = TextBox9;
		location = new Point(410, 49);
		((Control)textBox7).set_Location(location);
		TextBox9.set_Multiline(true);
		((Control)TextBox9).set_Name("TextBox9");
		TextBox9.set_ScrollBars((ScrollBars)3);
		TextBox textBox8 = TextBox9;
		size = new Size(43, 20);
		((Control)textBox8).set_Size(size);
		((Control)TextBox9).set_TabIndex(41);
		TextBox9.set_Text(componentResourceManager.GetString("TextBox9.Text"));
		((Control)TextBox9).set_Visible(false);
		TextBox textBox9 = TextBox4;
		location = new Point(341, 83);
		((Control)textBox9).set_Location(location);
		((Control)TextBox4).set_Name("TextBox4");
		((TextBoxBase)TextBox4).set_ReadOnly(true);
		TextBox textBox10 = TextBox4;
		size = new Size(10, 20);
		((Control)textBox10).set_Size(size);
		((Control)TextBox4).set_TabIndex(40);
		((Control)TextBox4).set_Visible(false);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 27.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label5 = Label2;
		location = new Point(51, 11);
		((Control)label5).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label6 = Label2;
		size = new Size(472, 126);
		((Control)label6).set_Size(size);
		((Control)Label2).set_TabIndex(50);
		Label2.set_Text("SATWNEYT\r\nLOADING\r\nPOR FAVOR, AGUARDE!");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(625, 184);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)DC);
		((Control)this).get_Controls().Add((Control)(object)TextBox3);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)RichTextAtua);
		((Control)this).get_Controls().Add((Control)(object)TextInfoVersion);
		((Control)this).get_Controls().Add((Control)(object)TextBox9);
		((Control)this).get_Controls().Add((Control)(object)TextBox4);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		size = new Size(641, 223);
		((Form)this).set_MaximumSize(size);
		size = new Size(641, 223);
		((Form)this).set_MinimumSize(size);
		((Control)this).set_Name("Load2");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("SATWNEYT SHOP Plus One-X - Loading  DUOZ MATRIX TOTAL 6");
		((Control)ContextMenuStrip1).ResumeLayout(false);
		((ISupportInitialize)FileSystemWatcher1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		NotPause.set_Enabled(true);
		NotPause.Start();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		NotPause.Start();
		NotPause.set_Enabled(true);
	}

	private void NotPause_Tick(object sender, EventArgs e)
	{
		if (!((Control)this).get_Visible())
		{
			NotifyIcon1.set_Visible(true);
		}
		((Control)this).set_Visible(false);
	}

	private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Invalid comparison between Unknown and I4
		try
		{
			((Control)MyProject.Forms.janela).set_Visible(true);
			((Form)MyProject.Forms.janela).set_WindowState((FormWindowState)0);
			try
			{
				((Control)MyProject.Forms.janela).Show();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		if ((int)Control.get_MouseButtons() == 2097152)
		{
			((ToolStripDropDown)ContextMenuStrip1).Show();
		}
		else
		{
			((ToolStripDropDown)ContextMenuStrip1).Close();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void FileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
	{
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((FileDialog)OpenFileDialog1).set_FileName(e.FullPath.ToString());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			MyProject.Forms.Tools0.RichTextBox1.set_Text(e.FullPath);
			if (Operators.CompareString(e.FullPath, "", false) != 0)
			{
				MyProject.Forms.Tools0.ListaProtecaoReal.get_Items().Add((object)(e.FullPath + "\r\n"));
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		Process[] processesByName = Process.GetProcessesByName(e.FullPath);
		int upperBound = processesByName.GetUpperBound(0);
		int num = 0;
		while (true)
		{
			int num2 = num;
			int num3 = upperBound;
			if (num2 > num3)
			{
				break;
			}
			TextBox9.set_Text(processesByName[num].MainWindowTitle.ToString());
			num = checked(num + 1);
		}
		new Process();
		new TextBox();
		new TextBox();
		((FileDialog)OpenFileDialog1).set_FileName("");
		try
		{
			MyProject.Forms.janela.RichTextBox1.set_Text(e.FullPath);
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			FileStream fileStream = new FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read, 8192);
			fileStream = new FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read, 8192);
			mD5CryptoServiceProvider.ComputeHash(fileStream);
			byte[] hash = mD5CryptoServiceProvider.Hash;
			StringBuilder stringBuilder = new StringBuilder();
			byte[] array = hash;
			foreach (byte b in array)
			{
				stringBuilder.Append($"{b:X2}");
			}
			be.set_Text("eicar");
			n.set_Text("VWÿu\u001cÿu");
			c.set_Text("Eicar");
			de.set_Text("EICAR");
			fe.set_Text("ECHO");
			g.set_Text("Echo");
			h.set_Text("echo");
			ii.set_Text(" - t");
			j.set_Text(" -t");
			k.set_Text(" -T");
			m.set_Text(" - T");
			jot.set_Text("–t ");
			van.set_Text("ThenDasMapiName.Log");
			vn.set_Text("thendasmapiname.log");
			jjk.set_Text("THENDASMAPINAME.LOG");
			hh.set_Text("/REBOOTOK");
			ww.set_Text("/rebootok");
			QQ.set_Text("[AUTORUN]");
			ll.set_Text("[autorun]");
			avz.set_Text("=SHELL");
			jjjc.set_Text("=shell");
			can.set_Text("=Shell");
			sss.set_Text("[HKCU\\");
			ass.set_Text("rpc.");
			sbs.set_Text("[hkcu\\");
			ffa.set_Text("[HKLM\\");
			jfa.set_Text("[Hklm\\");
			jaaa.set_Text("[hklm\\");
			gov.set_Text("mscomctl.ocx");
			fd.set_Text("del /s /q");
			cox.set_Text("DEL /S /Q");
			tr.set_Text("%A% V%A%");
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		if (!((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists("C:\\Satwneyt\\6.0\\protect.txt"))
		{
			pc.set_Text("del /s /q");
		}
		try
		{
			a.set_Text(((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(e.FullPath));
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			pc.set_Text(((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText("C:\\Satwneyt\\6.0\\protect.txt"));
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			cp.set_Text(((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(e.FullPath));
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (cp.get_Text().Contains("%@AP[4\\PZX54(P") | cp.get_Text().Contains("hutd") | cp.get_Text().Contains("HUTD"))
			{
				DC.set_Text("Vírus");
			}
			if (cp.get_Text().Contains("-S-C") | cp.get_Text().Contains("CHO") | (cp.get_Text().Contains("@") & cp.get_Text().Contains("XIT")) | cp.get_Text().Contains("O") | cp.get_Text().Contains("cho") | cp.get_Text().Contains("@") | cp.get_Text().Contains("xit") | cp.get_Text().Contains("o"))
			{
				DC.set_Text("Trojan");
			}
			if (cp.get_Text().Contains("CHO") | cp.get_Text().Contains("@") | cp.get_Text().Contains(":") | cp.get_Text().Contains("OTO") | cp.get_Text().Contains("TAR") | cp.get_Text().Contains(".") | cp.get_Text().Contains("cho") | cp.get_Text().Contains("@") | cp.get_Text().Contains(":") | cp.get_Text().Contains("oto") | cp.get_Text().Contains("tar") | cp.get_Text().Contains("."))
			{
				DC.set_Text("Bomba-Relógio");
			}
			if (cp.get_Text().Contains("Czywd") | cp.get_Text().Contains("@") | cp.get_Text().Contains("5") | cp.get_Text().Contains("frvf") | cp.get_Text().Contains("ddwe") | cp.get_Text().Contains("ded") | cp.get_Text().Contains("eokd") | cp.get_Text().Contains("@") | cp.get_Text().Contains("wdw") | cp.get_Text().Contains("çço") | cp.get_Text().Contains("tar") | cp.get_Text().Contains("eszww"))
			{
				DC.set_Text("Veralware");
			}
			if (cp.get_Text().Contains("H") | cp.get_Text().Contains("(") | cp.get_Text().Contains("%@AP[4\\PZX54(P") | cp.get_Text().Contains("VWÿu\u001cÿu") | cp.get_Text().Contains("ThenDasMapiName.Log") | cp.get_Text().Contains("thendasmapiname.log") | cp.get_Text().Contains("THENDASMAPINAME.LOG") | cp.get_Text().Contains("/REBOOTOK") | cp.get_Text().Contains("ded") | cp.get_Text().Contains("eokd") | cp.get_Text().Contains("/rebootok") | cp.get_Text().Contains("[AUTORUN]") | cp.get_Text().Contains("dasad") | cp.get_Text().Contains("tsdsdd") | cp.get_Text().Contains("esgfsv"))
			{
				DC.set_Text("Malware");
			}
			if (cp.get_Text().Contains("mscomctl.ocx") | cp.get_Text().Contains("[autorun]") | cp.get_Text().Contains("=SHELL") | cp.get_Text().Contains("=shell") | cp.get_Text().Contains("HKCU\\") | cp.get_Text().Contains("rpc.") | cp.get_Text().Contains("[hkcu\\") | cp.get_Text().Contains("eokd"))
			{
				DC.set_Text("Backdoor");
			}
			if (cp.get_Text().Contains("mscomctl.ocx") | cp.get_Text().Contains("[autorun]") | cp.get_Text().Contains("del /s /q") | cp.get_Text().Contains("DEL /S /Q") | cp.get_Text().Contains("HKCU\\") | cp.get_Text().Contains("%A% V%A%") | cp.get_Text().Contains("[hkcu\\") | cp.get_Text().Contains("eokd"))
			{
				DC.set_Text("Rootkit");
			}
			if (cp.get_Text().Contains("ms_") | cp.get_Text().Contains("run]") | cp.get_Text().Contains("iihihi") | cp.get_Text().Contains("uiiiu") | cp.get_Text().Contains("HKC") | cp.get_Text().Contains("%A%") | cp.get_Text().Contains("[") | cp.get_Text().Contains("lkbjhkbhk"))
			{
				DC.set_Text("Spyware");
			}
			if (cp.get_Text().Contains("CLS_") | cp.get_Text().Contains("_CLS") | cp.get_Text().Contains("ms_") | cp.get_Text().Contains("off") | cp.get_Text().Contains("[echo]") | cp.get_Text().Contains("DIRR>>") | cp.get_Text().Contains("TYPE_ENCHE") | cp.get_Text().Contains("RR>>GOTO") | cp.get_Text().Contains(">>ENCH"))
			{
				DC.set_Text("Worm (verme)");
			}
			if ((cp.get_Text().Contains(":ASM.") & cp.get_Text().Contains("RN:") & cp.get_Text().Contains("OKEN=")) | (cp.get_Text().Contains(":asm.") & cp.get_Text().Contains("rn:") & cp.get_Text().Contains("oken=")) | (cp.get_Text().Contains(":asm.v2") & cp.get_Text().Contains("rn:schemas") & cp.get_Text().Contains("publicKeyToken=")) | (cp.get_Text().Contains(":asm.v1") & cp.get_Text().Contains("rn:schemas") & cp.get_Text().Contains("publicKeyToken=")) | (cp.get_Text().Contains("asInvoker") & cp.get_Text().Contains("processorArchitecture=") & cp.get_Text().Contains("*")))
			{
				try
				{
					((Control)MyProject.Forms.Form2).Show();
					((Control)MyProject.Forms.Form2).set_Visible(true);
					if (Operators.CompareString(DC.get_Text(), "", false) != 0)
					{
						NotifyIcon1.ShowBalloonTip(2, "Alerta de Segurança Ransomware! ", "Tipo: Praga Maliciosa/ Categoria de Ransomware\r\nO arquivo chamado: " + e.FullPath.ToString() + " é suspeito. Portanto, ele deve ser removido e/ou bloqueado!", (ToolTipIcon)2);
					}
				}
				catch (Exception projectError7)
				{
					ProjectData.SetProjectError(projectError7);
					if (Operators.CompareString(DC.get_Text(), "", false) != 0)
					{
						NotifyIcon1.ShowBalloonTip(2, "Alerta de Segurança Ransomware! ", "Tipo: Praga Maliciosa/ Categoria de Ransomware\r\nO arquivo chamado: " + e.FullPath.ToString() + " é suspeito. Portanto, ele deve ser removido e/ou bloqueado!", (ToolTipIcon)2);
					}
					((Control)MyProject.Forms.Form2).set_Visible(true);
					ProjectData.ClearProjectError();
				}
				DC.set_Text("Praga Maliciosa/ Categoria de Ransomware");
			}
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		((FileDialog)OpenFileDialog1).set_FileName(e.FullPath);
		if ((Operators.CompareString(((FileDialog)OpenFileDialog1).get_FileName(), "", false) != 0) | e.FullPath.Contains(".com") | e.FullPath.Contains(".br") | e.FullPath.Contains(".bat") | (e.FullPath.Contains("C:\\Users\\massa\\AppData\\Local\\Temp\\") & e.FullPath.Contains("\\temp\\") & e.FullPath.Contains(".dat")) | (e.FullPath.Contains("C:\\Users\\massa\\AppData\\Local\\Temp\\") & e.FullPath.Contains("\\temp\\") & e.FullPath.Contains(".tmp")) | e.FullPath.Contains(".jpson") | e.FullPath.Contains(".down") | e.FullPath.Contains(".upd"))
		{
			NotifyIcon1.ShowBalloonTip(1, "Alerta de Segurança! Tipo: " + DC.get_Text() + ".", "O arquivo chamado: " + ((FileDialog)OpenFileDialog1).get_FileName() + " é suspeito. Portanto, ele deve ser removido e/ou bloqueado!", (ToolTipIcon)2);
			try
			{
				((Control)MyProject.Forms.Form2).Show();
				((Control)MyProject.Forms.Form2).set_Visible(true);
			}
			catch (Exception projectError9)
			{
				ProjectData.SetProjectError(projectError9);
				((Control)MyProject.Forms.Form2).set_Visible(true);
				ProjectData.ClearProjectError();
			}
			try
			{
				FileSystem.Kill(((FileDialog)OpenFileDialog1).get_FileName());
				StreamWriter streamWriter = new StreamWriter(e.FullPath.ToString());
				streamWriter.Write("");
				streamWriter.Close();
			}
			catch (Exception projectError10)
			{
				ProjectData.SetProjectError(projectError10);
				ProjectData.ClearProjectError();
			}
			try
			{
				((Form)MyProject.Forms.Form2).set_WindowState((FormWindowState)0);
			}
			catch (Exception projectError11)
			{
				ProjectData.SetProjectError(projectError11);
				ProjectData.ClearProjectError();
			}
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(((FileDialog)OpenFileDialog1).get_FileName());
			}
			catch (Exception projectError12)
			{
				ProjectData.SetProjectError(projectError12);
				try
				{
					FileSystem.Kill(((FileDialog)OpenFileDialog1).get_FileName());
				}
				catch (Exception projectError13)
				{
					ProjectData.SetProjectError(projectError13);
					try
					{
						StreamWriter streamWriter2 = new StreamWriter(e.FullPath.ToString());
						streamWriter2.Write("");
						streamWriter2.Close();
					}
					catch (Exception projectError14)
					{
						ProjectData.SetProjectError(projectError14);
						try
						{
						}
						catch (Exception projectError15)
						{
							ProjectData.SetProjectError(projectError15);
							try
							{
							}
							catch (Exception projectError16)
							{
								ProjectData.SetProjectError(projectError16);
								ProjectData.ClearProjectError();
							}
							ProjectData.ClearProjectError();
						}
						ProjectData.ClearProjectError();
					}
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
		}
		if (((FileDialog)OpenFileDialog1).get_FileName().Contains("") | ((FileDialog)OpenFileDialog1).get_FileName().Contains("atwneyt") | ((FileDialog)OpenFileDialog1).get_FileName().Contains("ATWNEYT") | ((FileDialog)OpenFileDialog1).get_FileName().Contains("NECTOVERSY") | ((FileDialog)OpenFileDialog1).get_FileName().Contains("nectoversy") | ((FileDialog)OpenFileDialog1).get_FileName().Contains("assahiro") | ((FileDialog)OpenFileDialog1).get_FileName().Contains("ASSAHIRO"))
		{
			return;
		}
		NotifyIcon1.ShowBalloonTip(1, "Alerta de Segurança! Tipo: " + DC.get_Text() + ".", "O arquivo chamado: " + ((FileDialog)OpenFileDialog1).get_FileName() + " é suspeito. Portanto, ele deve ser removido e/ou bloqueado!", (ToolTipIcon)2);
		try
		{
			((Control)MyProject.Forms.Form2).Show();
			((Control)MyProject.Forms.Form2).set_Visible(true);
		}
		catch (Exception projectError17)
		{
			ProjectData.SetProjectError(projectError17);
			((Control)MyProject.Forms.Form2).set_Visible(true);
			ProjectData.ClearProjectError();
		}
		try
		{
			FileSystem.Kill(((FileDialog)OpenFileDialog1).get_FileName());
			StreamWriter streamWriter3 = new StreamWriter(e.FullPath.ToString());
			streamWriter3.Write("");
			streamWriter3.Close();
		}
		catch (Exception projectError18)
		{
			ProjectData.SetProjectError(projectError18);
			ProjectData.ClearProjectError();
		}
		try
		{
			((Form)MyProject.Forms.Form2).set_WindowState((FormWindowState)0);
		}
		catch (Exception projectError19)
		{
			ProjectData.SetProjectError(projectError19);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(((FileDialog)OpenFileDialog1).get_FileName());
		}
		catch (Exception projectError20)
		{
			ProjectData.SetProjectError(projectError20);
			try
			{
				FileSystem.Kill(((FileDialog)OpenFileDialog1).get_FileName());
			}
			catch (Exception projectError21)
			{
				ProjectData.SetProjectError(projectError21);
				try
				{
					StreamWriter streamWriter4 = new StreamWriter(e.FullPath.ToString());
					streamWriter4.Write("");
					streamWriter4.Close();
				}
				catch (Exception projectError22)
				{
					ProjectData.SetProjectError(projectError22);
					try
					{
					}
					catch (Exception projectError23)
					{
						ProjectData.SetProjectError(projectError23);
						try
						{
						}
						catch (Exception projectError24)
						{
							ProjectData.SetProjectError(projectError24);
							ProjectData.ClearProjectError();
						}
						ProjectData.ClearProjectError();
					}
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
	}

	private void GroupBox1_Enter(object sender, EventArgs e)
	{
	}

	private void AbrirSatwneytToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			((Control)MyProject.Forms.janela).Show();
			((Form)MyProject.Forms.janela).set_WindowState((FormWindowState)0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			((Form)MyProject.Forms.janela).set_WindowState((FormWindowState)0);
			((Control)MyProject.Forms.janela).set_Visible(true);
			ProjectData.ClearProjectError();
		}
	}

	private void FerramentaDeArquivoToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((Form)MyProject.Forms.Tools0).ShowDialog();
			((Form)MyProject.Forms.Tools0).set_WindowState((FormWindowState)0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			((Form)MyProject.Forms.Tools0).set_WindowState((FormWindowState)0);
			((Control)MyProject.Forms.Tools0).set_Visible(true);
			ProjectData.ClearProjectError();
		}
	}

	private void NotifyIcon1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		if ((int)Control.get_MouseButtons() == 2097152)
		{
			((ToolStripDropDown)ContextMenuStrip1).Show();
		}
		else
		{
			((ToolStripDropDown)ContextMenuStrip1).Close();
		}
	}

	private void Firewall_Tick(object sender, EventArgs e)
	{
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				Process[] processesByName = Process.GetProcessesByName("firefox");
				int upperBound = processesByName.GetUpperBound(0);
				int num = 0;
				while (true)
				{
					int num2 = num;
					int num3 = upperBound;
					if (num2 > num3)
					{
						break;
					}
					TextBox1.set_Text(processesByName[num].MainWindowTitle.ToString());
					num++;
				}
				new Process();
				if (TextBox1.get_Text().Contains("EICAR"))
				{
					if (processesByName.Length > 0)
					{
						processesByName[0].Kill();
					}
					MyProject.Forms.Firewall.nome.set_Text(TextBox1.get_Text());
					((Control)MyProject.Forms.Firewall).Show();
					((Form)MyProject.Forms.Firewall).set_WindowState((FormWindowState)0);
					((Form)this).set_WindowState((FormWindowState)0);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				Process[] processesByName2 = Process.GetProcessesByName("iexplore");
				int upperBound2 = processesByName2.GetUpperBound(0);
				int num4 = 0;
				while (true)
				{
					int num5 = num4;
					int num3 = upperBound2;
					if (num5 > num3)
					{
						break;
					}
					TextBox1.set_Text(processesByName2[num4].MainWindowTitle.ToString());
					num4++;
				}
				if (TextBox1.get_Text().Contains("EICAR"))
				{
					if (processesByName2.Length > 0)
					{
						processesByName2[0].Kill();
					}
					MyProject.Forms.Firewall.nome.set_Text(TextBox1.get_Text());
					((Control)MyProject.Forms.Firewall).Show();
					((Form)MyProject.Forms.Firewall).set_WindowState((FormWindowState)0);
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			try
			{
				new TextBox();
				Process[] processesByName3 = Process.GetProcessesByName("chrome");
				int upperBound3 = processesByName3.GetUpperBound(0);
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num3 = upperBound3;
					if (num7 > num3)
					{
						break;
					}
					TextBox1.set_Text(processesByName3[num6].MainWindowTitle.ToString());
					num6++;
				}
				if (TextBox1.get_Text().Contains("EICAR") | TextBox1.get_Text().Contains("Eicar"))
				{
					if (processesByName3.Length > 0)
					{
						processesByName3[0].Start();
					}
					MyProject.Forms.Firewall.nome.set_Text(TextBox1.get_Text());
					((Control)MyProject.Forms.Firewall).Show();
					((Form)MyProject.Forms.Firewall).set_WindowState((FormWindowState)0);
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			try
			{
				Process[] processesByName4 = Process.GetProcessesByName("cmd");
				int upperBound4 = processesByName4.GetUpperBound(0);
				int num8 = 0;
				while (true)
				{
					int num9 = num8;
					int num3 = upperBound4;
					if (num9 > num3)
					{
						break;
					}
					TextBox1.set_Text(processesByName4[num8].MainWindowTitle.ToString());
					if (TextBox1.get_Text().Contains("Quote") | TextBox1.get_Text().Contains("ftp"))
					{
						if (processesByName4.Length > 0)
						{
							processesByName4[0].Kill();
						}
						MyProject.Forms.Firewall.nome.set_Text(TextBox1.get_Text());
						MyProject.Forms.Firewall.tipo.set_Text("Invasão uso da web / Programa de hacker");
						MyProject.Forms.Firewall.soft.set_Text("Cmd");
						((Control)MyProject.Forms.Firewall).Show();
						((Form)MyProject.Forms.Firewall).set_WindowState((FormWindowState)0);
					}
					num8++;
				}
				if (TextBox1.get_Text().Contains("Quote") | TextBox1.get_Text().Contains("ftp"))
				{
					if (processesByName4.Length > 0)
					{
						processesByName4[0].Kill();
					}
					MyProject.Forms.Firewall.nome.set_Text(TextBox1.get_Text());
					MyProject.Forms.Firewall.tipo.set_Text("Invasão uso da web / Programa de hacker");
					MyProject.Forms.Firewall.soft.set_Text("Cmd");
					((Control)MyProject.Forms.Firewall).Show();
					((Form)MyProject.Forms.Firewall).set_WindowState((FormWindowState)0);
				}
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			try
			{
				Process[] processesByName5 = Process.GetProcessesByName("notepad");
				int upperBound5 = processesByName5.GetUpperBound(0);
				int num10 = 0;
				while (true)
				{
					int num11 = num10;
					int num3 = upperBound5;
					if (num11 > num3)
					{
						break;
					}
					TextBox1.set_Text(processesByName5[num10].MainWindowTitle.ToString());
					if (TextBox1.get_Text().Contains("echo") | TextBox1.get_Text().Contains("Echo") | TextBox1.get_Text().Contains("ECHO") | TextBox1.get_Text().Contains("IRUS") | TextBox1.get_Text().Contains("irus") | TextBox1.get_Text().Contains("WARE") | TextBox1.get_Text().Contains("ware") | TextBox1.get_Text().Contains("ICAR") | TextBox1.get_Text().Contains("icar") | TextBox1.get_Text().Contains("ROJAN") | TextBox1.get_Text().Contains("rojan") | TextBox1.get_Text().Contains("ALWARE") | TextBox1.get_Text().Contains("alware") | TextBox1.get_Text().Contains(".com") | TextBox1.get_Text().Contains(".bat"))
					{
						if (processesByName5.Length > 0)
						{
							processesByName5[0].Kill();
						}
						((Form)MyProject.Forms.Firewall).set_WindowState((FormWindowState)0);
						MyProject.Forms.Firewall.nome.set_Text(TextBox1.get_Text());
						MyProject.Forms.Firewall.Label2.set_Text("Aviso: Arquivo perigoso foi bloqueado !!!");
						MyProject.Forms.Firewall.tipo.set_Text("Código Perigoso / Programa Malicioso");
						MyProject.Forms.Firewall.soft.set_Text("Bloco de notas");
						((Control)MyProject.Forms.Firewall).Show();
					}
					num10++;
				}
				if (TextBox1.get_Text().Contains("IRUS") | TextBox1.get_Text().Contains("irus") | TextBox1.get_Text().Contains("WARE") | TextBox1.get_Text().Contains("ware") | TextBox1.get_Text().Contains("ICAR") | TextBox1.get_Text().Contains("icar") | TextBox1.get_Text().Contains("ROJAN") | TextBox1.get_Text().Contains("rojan") | TextBox1.get_Text().Contains("ALWARE") | TextBox1.get_Text().Contains("alware") | TextBox1.get_Text().Contains(".com") | TextBox1.get_Text().Contains(".bat"))
				{
					if (processesByName5.Length > 0)
					{
						processesByName5[0].Kill();
					}
					((Form)MyProject.Forms.Firewall).set_WindowState((FormWindowState)0);
					MyProject.Forms.Firewall.nome.set_Text(TextBox1.get_Text());
					MyProject.Forms.Firewall.Label2.set_Text("Aviso: Arquivo perigoso foi bloqueado !!!");
					MyProject.Forms.Firewall.tipo.set_Text("Código Perigoso / Programa Malicioso");
					MyProject.Forms.Firewall.soft.set_Text("Bloco de notas");
					((Control)MyProject.Forms.Firewall).Show();
				}
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
			if (!((Control)MyProject.Forms.Firewall).get_Visible())
			{
				TextBox1.set_Text("");
			}
			if (MyProject.Forms.Firewall.nome.get_Text().Contains("Firefox") | MyProject.Forms.Firewall.nome.get_Text().Contains("Mozilla"))
			{
				MyProject.Forms.Firewall.soft.set_Text("Mozilla Firefox");
			}
			if (MyProject.Forms.Firewall.nome.get_Text().Contains("Internet Explorer") | MyProject.Forms.Firewall.nome.get_Text().Contains("Explorer"))
			{
				MyProject.Forms.Firewall.soft.set_Text("Internet Explorer");
			}
			if (MyProject.Forms.Firewall.nome.get_Text().Contains("Google Chrome") | MyProject.Forms.Firewall.nome.get_Text().Contains("chrome"))
			{
				MyProject.Forms.Firewall.soft.set_Text("Google Chrome");
			}
		}
	}

	private void TextBoxChavedeRegistro_TextChanged(object sender, EventArgs e)
	{
	}
}
