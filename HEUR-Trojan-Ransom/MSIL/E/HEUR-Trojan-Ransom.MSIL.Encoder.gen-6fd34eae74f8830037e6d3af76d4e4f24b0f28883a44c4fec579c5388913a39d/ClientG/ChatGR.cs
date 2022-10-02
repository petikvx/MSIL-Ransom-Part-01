using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ClientG.My;
using ClientG.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ClientG;

[DesignerGenerated]
public class ChatGR : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("ColorDialog1")]
	private ColorDialog _ColorDialog1;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Pic")]
	private PictureBox _Pic;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("INPTXT")]
	private TextBox _INPTXT;

	[AccessedThroughProperty("RCG")]
	private RichTextBox _RCG;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	[AccessedThroughProperty("Timer3")]
	private Timer _Timer3;

	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[AccessedThroughProperty("StatusStrip1")]
	private StatusStrip _StatusStrip1;

	[AccessedThroughProperty("ToolStripSplitButton1")]
	private ToolStripSplitButton _ToolStripSplitButton1;

	[AccessedThroughProperty("ToolStripStatusLabel1")]
	private ToolStripStatusLabel _ToolStripStatusLabel1;

	[AccessedThroughProperty("ToolStripStatusLabel2")]
	private ToolStripStatusLabel _ToolStripStatusLabel2;

	[AccessedThroughProperty("ToolStripStatusLabel3")]
	private ToolStripStatusLabel _ToolStripStatusLabel3;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("Panel4")]
	private Panel _Panel4;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	public int Sock;

	public int B;

	public string MeColorString;

	public Color MeColor;

	public string ClientColorString;

	public Color ClinetColor;

	public string ID;

	public string CID;

	public string FT;

	public string ASS;

	public string CLDP;

	public string ADP;

	public int OS;

	public string Devices;

	public int Q;

	public PictureBox PP;

	public byte[] ByTesS;

	public string LastPicture;

	public string OLDStatus;

	public object LastTyping;

	public Image Old;

	private VideoCaptureDevice FuenteDeVideo;

	private FilterInfoCollection DispositivosDeVideo;

	internal virtual ColorDialog ColorDialog1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColorDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColorDialog1 = value;
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
			EventHandler eventHandler = PictureBox1_DoubleClick;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).remove_DoubleClick(eventHandler);
			}
			_PictureBox1 = value;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).add_DoubleClick(eventHandler);
			}
		}
	}

	internal virtual PictureBox Pic
	{
		[DebuggerNonUserCode]
		get
		{
			return _Pic;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Pic = value;
		}
	}

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

	internal virtual TextBox INPTXT
	{
		[DebuggerNonUserCode]
		get
		{
			return _INPTXT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = INPTXT_TextChanged;
			KeyPressEventHandler val = new KeyPressEventHandler(INPTXT_KeyPress);
			if (_INPTXT != null)
			{
				((Control)_INPTXT).remove_TextChanged(eventHandler);
				((Control)_INPTXT).remove_KeyPress(val);
			}
			_INPTXT = value;
			if (_INPTXT != null)
			{
				((Control)_INPTXT).add_TextChanged(eventHandler);
				((Control)_INPTXT).add_KeyPress(val);
			}
		}
	}

	internal virtual RichTextBox RCG
	{
		[DebuggerNonUserCode]
		get
		{
			return _RCG;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RCG = value;
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
			_Timer2 = value;
		}
	}

	internal virtual Timer Timer3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer3_Tick;
			if (_Timer3 != null)
			{
				_Timer3.remove_Tick(eventHandler);
			}
			_Timer3 = value;
			if (_Timer3 != null)
			{
				_Timer3.add_Tick(eventHandler);
			}
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

	internal virtual StatusStrip StatusStrip1
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_StatusStrip1 = value;
		}
	}

	internal virtual ToolStripSplitButton ToolStripSplitButton1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSplitButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ToolStripSplitButton1_ButtonClick;
			if (_ToolStripSplitButton1 != null)
			{
				_ToolStripSplitButton1.remove_ButtonClick(eventHandler);
			}
			_ToolStripSplitButton1 = value;
			if (_ToolStripSplitButton1 != null)
			{
				_ToolStripSplitButton1.add_ButtonClick(eventHandler);
			}
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
			EventHandler eventHandler = ToolStripStatusLabel1_Click;
			if (_ToolStripStatusLabel1 != null)
			{
				((ToolStripItem)_ToolStripStatusLabel1).remove_Click(eventHandler);
			}
			_ToolStripStatusLabel1 = value;
			if (_ToolStripStatusLabel1 != null)
			{
				((ToolStripItem)_ToolStripStatusLabel1).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ToolStripStatusLabel2_Click;
			if (_ToolStripStatusLabel2 != null)
			{
				((ToolStripItem)_ToolStripStatusLabel2).remove_Click(eventHandler);
			}
			_ToolStripStatusLabel2 = value;
			if (_ToolStripStatusLabel2 != null)
			{
				((ToolStripItem)_ToolStripStatusLabel2).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ToolStripStatusLabel3_Click;
			if (_ToolStripStatusLabel3 != null)
			{
				((ToolStripItem)_ToolStripStatusLabel3).remove_Click(eventHandler);
			}
			_ToolStripStatusLabel3 = value;
			if (_ToolStripStatusLabel3 != null)
			{
				((ToolStripItem)_ToolStripStatusLabel3).add_Click(eventHandler);
			}
		}
	}

	internal virtual PictureBox PictureBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox2_DoubleClick;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).remove_DoubleClick(eventHandler);
			}
			_PictureBox2 = value;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).add_DoubleClick(eventHandler);
			}
		}
	}

	internal virtual Panel Panel4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel4 = value;
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
			EventHandler eventHandler = Button2_ButtonClick;
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

	internal virtual PictureBox PictureBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox4_Click;
			if (_PictureBox4 != null)
			{
				((Control)_PictureBox4).remove_Click(eventHandler);
			}
			_PictureBox4 = value;
			if (_PictureBox4 != null)
			{
				((Control)_PictureBox4).add_Click(eventHandler);
			}
		}
	}

	internal virtual PictureBox PictureBox5
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox5 = value;
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
			EventHandler eventHandler = Label4_Click;
			if (_Label4 != null)
			{
				((Control)_Label4).remove_Click(eventHandler);
			}
			_Label4 = value;
			if (_Label4 != null)
			{
				((Control)_Label4).add_Click(eventHandler);
			}
		}
	}

	public ChatGR()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)CH_Load);
		((Form)this).add_FormClosing(new FormClosingEventHandler(CH_FormClosing));
		__ENCAddToList(this);
		B = 0;
		DispositivosDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
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
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
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
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Expected O, but got Unknown
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected O, but got Unknown
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Expected O, but got Unknown
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Expected O, but got Unknown
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Expected O, but got Unknown
		//IL_06df: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e9: Expected O, but got Unknown
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076f: Expected O, but got Unknown
		//IL_07ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f6: Expected O, but got Unknown
		//IL_0872: Unknown result type (might be due to invalid IL or missing references)
		//IL_087c: Expected O, but got Unknown
		//IL_0adf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae9: Expected O, but got Unknown
		//IL_0b79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b83: Expected O, but got Unknown
		//IL_0c63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6d: Expected O, but got Unknown
		//IL_0ff6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1000: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ChatGR));
		ColorDialog1 = new ColorDialog();
		PictureBox1 = new PictureBox();
		Pic = new PictureBox();
		Panel1 = new Panel();
		PictureBox5 = new PictureBox();
		Label4 = new Label();
		Label3 = new Label();
		PictureBox4 = new PictureBox();
		Button2 = new Button();
		Label2 = new Label();
		Label1 = new Label();
		INPTXT = new TextBox();
		RCG = new RichTextBox();
		Panel2 = new Panel();
		Timer1 = new Timer(components);
		Timer2 = new Timer(components);
		Timer3 = new Timer(components);
		Panel3 = new Panel();
		Button1 = new Button();
		PictureBox2 = new PictureBox();
		StatusStrip1 = new StatusStrip();
		ToolStripSplitButton1 = new ToolStripSplitButton();
		ToolStripStatusLabel1 = new ToolStripStatusLabel();
		ToolStripStatusLabel2 = new ToolStripStatusLabel();
		ToolStripStatusLabel3 = new ToolStripStatusLabel();
		Panel4 = new Panel();
		PictureBox3 = new PictureBox();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)Pic).BeginInit();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)PictureBox5).BeginInit();
		((ISupportInitialize)PictureBox4).BeginInit();
		((Control)Panel2).SuspendLayout();
		((Control)Panel3).SuspendLayout();
		((ISupportInitialize)PictureBox2).BeginInit();
		((Control)StatusStrip1).SuspendLayout();
		((Control)Panel4).SuspendLayout();
		((ISupportInitialize)PictureBox3).BeginInit();
		((Control)this).SuspendLayout();
		PictureBox1.set_BorderStyle((BorderStyle)1);
		PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		PictureBox pictureBox = PictureBox1;
		Point location = new Point(6, 3);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		Size size = new Size(172, 122);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(1);
		PictureBox1.set_TabStop(false);
		((Control)Pic).set_Anchor((AnchorStyles)15);
		((Control)Pic).set_BackColor(Color.Black);
		PictureBox pic = Pic;
		location = new Point(-90, 0);
		((Control)pic).set_Location(location);
		((Control)Pic).set_Name("Pic");
		PictureBox pic2 = Pic;
		size = new Size(682, 239);
		((Control)pic2).set_Size(size);
		Pic.set_SizeMode((PictureBoxSizeMode)1);
		Pic.set_TabIndex(2);
		Pic.set_TabStop(false);
		((Control)Panel1).get_Controls().Add((Control)(object)PictureBox5);
		((Control)Panel1).get_Controls().Add((Control)(object)Label4);
		((Control)Panel1).get_Controls().Add((Control)(object)Label3);
		((Control)Panel1).get_Controls().Add((Control)(object)PictureBox4);
		((Control)Panel1).get_Controls().Add((Control)(object)Button2);
		((Control)Panel1).set_Dock((DockStyle)1);
		Panel panel = Panel1;
		location = new Point(0, 0);
		((Control)panel).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel2 = Panel1;
		size = new Size(783, 89);
		((Control)panel2).set_Size(size);
		((Control)Panel1).set_TabIndex(3);
		((Control)PictureBox5).set_Anchor((AnchorStyles)3);
		((Control)PictureBox5).set_BackColor(Color.FromArgb(0, 0, 0, 0));
		PictureBox5.set_Image((Image)componentResourceManager.GetObject("PictureBox5.Image"));
		PictureBox pictureBox3 = PictureBox5;
		location = new Point(204, 6);
		((Control)pictureBox3).set_Location(location);
		((Control)PictureBox5).set_Name("PictureBox5");
		PictureBox pictureBox4 = PictureBox5;
		size = new Size(50, 38);
		((Control)pictureBox4).set_Size(size);
		PictureBox5.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox5.set_TabIndex(3);
		PictureBox5.set_TabStop(false);
		((Control)Label4).set_Anchor((AnchorStyles)3);
		Label4.set_AutoSize(true);
		((Control)Label4).set_BackColor(Color.Transparent);
		((Control)Label4).set_Font(new Font("Verdana", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label = Label4;
		location = new Point(241, 35);
		((Control)label).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label2 = Label4;
		size = new Size(253, 32);
		((Control)label2).set_Size(size);
		((Control)Label4).set_TabIndex(4);
		Label4.set_Text("imdall Live Chat !");
		((Control)Label3).set_Anchor((AnchorStyles)3);
		Label3.set_AutoSize(true);
		((Control)Label3).set_BackColor(Color.Transparent);
		((Control)Label3).set_Font(new Font("Verdana", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label3 = Label3;
		location = new Point(175, 36);
		((Control)label3).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label4 = Label3;
		size = new Size(51, 32);
		((Control)label4).set_Size(size);
		((Control)Label3).set_TabIndex(2);
		Label3.set_Text("He");
		((Control)PictureBox4).set_Anchor((AnchorStyles)11);
		PictureBox4.set_Image((Image)componentResourceManager.GetObject("PictureBox4.Image"));
		PictureBox pictureBox5 = PictureBox4;
		location = new Point(598, 6);
		((Control)pictureBox5).set_Location(location);
		((Control)PictureBox4).set_Name("PictureBox4");
		PictureBox pictureBox6 = PictureBox4;
		size = new Size(185, 83);
		((Control)pictureBox6).set_Size(size);
		PictureBox4.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox4.set_TabIndex(1);
		PictureBox4.set_TabStop(false);
		((Control)Button2).set_Anchor((AnchorStyles)7);
		((ButtonBase)Button2).set_Image((Image)componentResourceManager.GetObject("Button2.Image"));
		Button button = Button2;
		location = new Point(6, 3);
		((Control)button).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button2 = Button2;
		size = new Size(81, 79);
		((Control)button2).set_Size(size);
		((Control)Button2).set_TabIndex(0);
		((Control)Button2).set_Tag((object)"Start video call");
		((ButtonBase)Button2).set_TextAlign((ContentAlignment)512);
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Verdana", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label5 = Label2;
		location = new Point(2, 164);
		((Control)label5).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label6 = Label2;
		size = new Size(55, 14);
		((Control)label6).set_Size(size);
		((Control)Label2).set_TabIndex(3);
		Label2.set_Text("Statut :");
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Verdana", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label7 = Label1;
		location = new Point(2, 141);
		((Control)label7).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label8 = Label1;
		size = new Size(34, 14);
		((Control)label8).set_Size(size);
		((Control)Label1).set_TabIndex(2);
		Label1.set_Text("ID : ");
		((Control)INPTXT).set_Anchor((AnchorStyles)14);
		((Control)INPTXT).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox iNPTXT = INPTXT;
		location = new Point(8, 38);
		((Control)iNPTXT).set_Location(location);
		((Control)INPTXT).set_Name("INPTXT");
		TextBox iNPTXT2 = INPTXT;
		size = new Size(640, 21);
		((Control)iNPTXT2).set_Size(size);
		((Control)INPTXT).set_TabIndex(4);
		((TextBoxBase)RCG).set_BackColor(Color.White);
		((Control)RCG).set_Dock((DockStyle)2);
		RCG.set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		RichTextBox rCG = RCG;
		location = new Point(0, 248);
		((Control)rCG).set_Location(location);
		((Control)RCG).set_Name("RCG");
		((TextBoxBase)RCG).set_ReadOnly(true);
		RCG.set_ScrollBars((RichTextBoxScrollBars)18);
		RichTextBox rCG2 = RCG;
		size = new Size(596, 93);
		((Control)rCG2).set_Size(size);
		((Control)RCG).set_TabIndex(5);
		RCG.set_Text("");
		((Control)Panel2).set_Anchor((AnchorStyles)15);
		((Control)Panel2).get_Controls().Add((Control)(object)RCG);
		((Control)Panel2).get_Controls().Add((Control)(object)Pic);
		Panel panel3 = Panel2;
		location = new Point(0, 94);
		((Control)panel3).set_Location(location);
		((Control)Panel2).set_Name("Panel2");
		Panel panel4 = Panel2;
		size = new Size(596, 341);
		((Control)panel4).set_Size(size);
		((Control)Panel2).set_TabIndex(6);
		((Control)Panel3).get_Controls().Add((Control)(object)Button1);
		((Control)Panel3).get_Controls().Add((Control)(object)PictureBox2);
		((Control)Panel3).get_Controls().Add((Control)(object)StatusStrip1);
		((Control)Panel3).get_Controls().Add((Control)(object)INPTXT);
		((Control)Panel3).set_Dock((DockStyle)2);
		Panel panel5 = Panel3;
		location = new Point(0, 437);
		((Control)panel5).set_Location(location);
		((Control)Panel3).set_Name("Panel3");
		Panel panel6 = Panel3;
		size = new Size(783, 67);
		((Control)panel6).set_Size(size);
		((Control)Panel3).set_TabIndex(7);
		((Control)Button1).set_Anchor((AnchorStyles)10);
		((Control)Button1).set_Enabled(false);
		((ButtonBase)Button1).set_Image((Image)(object)Resources._1487168630_icons_send);
		Button button3 = Button1;
		location = new Point(651, 38);
		((Control)button3).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button4 = Button1;
		size = new Size(37, 20);
		((Control)button4).set_Size(size);
		((Control)Button1).set_TabIndex(7);
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((Control)PictureBox2).set_Anchor((AnchorStyles)11);
		PictureBox2.set_BorderStyle((BorderStyle)1);
		PictureBox2.set_Image((Image)componentResourceManager.GetObject("PictureBox2.Image"));
		PictureBox pictureBox7 = PictureBox2;
		location = new Point(691, 4);
		((Control)pictureBox7).set_Location(location);
		((Control)PictureBox2).set_Name("PictureBox2");
		PictureBox pictureBox8 = PictureBox2;
		size = new Size(83, 60);
		((Control)pictureBox8).set_Size(size);
		PictureBox2.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox2.set_TabIndex(6);
		PictureBox2.set_TabStop(false);
		((ToolStrip)StatusStrip1).set_AutoSize(false);
		StatusStrip1.set_Dock((DockStyle)0);
		((ToolStrip)StatusStrip1).set_Font(new Font("Segoe UI", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		StatusStrip statusStrip = StatusStrip1;
		size = new Size(20, 20);
		((ToolStrip)statusStrip).set_ImageScalingSize(size);
		((ToolStrip)StatusStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)ToolStripSplitButton1,
			(ToolStripItem)ToolStripStatusLabel1,
			(ToolStripItem)ToolStripStatusLabel2,
			(ToolStripItem)ToolStripStatusLabel3
		});
		StatusStrip statusStrip2 = StatusStrip1;
		location = new Point(12, 4);
		((Control)statusStrip2).set_Location(location);
		((Control)StatusStrip1).set_Name("StatusStrip1");
		StatusStrip1.set_ShowItemToolTips(true);
		StatusStrip statusStrip3 = StatusStrip1;
		size = new Size(676, 31);
		((Control)statusStrip3).set_Size(size);
		((Control)StatusStrip1).set_TabIndex(5);
		((Control)StatusStrip1).set_Text("StatusStrip1");
		((ToolStripItem)ToolStripSplitButton1).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripSplitButton1).set_Image((Image)componentResourceManager.GetObject("ToolStripSplitButton1.Image"));
		((ToolStripItem)ToolStripSplitButton1).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)ToolStripSplitButton1).set_Name("ToolStripSplitButton1");
		ToolStripSplitButton toolStripSplitButton = ToolStripSplitButton1;
		size = new Size(36, 29);
		((ToolStripItem)toolStripSplitButton).set_Size(size);
		((ToolStripItem)ToolStripSplitButton1).set_Text("Buzz!");
		((ToolStripItem)ToolStripStatusLabel1).set_Image((Image)(object)Resources._1487167095_Untitled_2_26);
		((ToolStripItem)ToolStripStatusLabel1).set_Name("ToolStripStatusLabel1");
		ToolStripStatusLabel toolStripStatusLabel = ToolStripStatusLabel1;
		size = new Size(30, 26);
		((ToolStripItem)toolStripStatusLabel).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel1).set_Text(" ");
		((ToolStripItem)ToolStripStatusLabel1).set_TextAlign((ContentAlignment)64);
		((ToolStripItem)ToolStripStatusLabel1).set_TextImageRelation((TextImageRelation)8);
		((ToolStripItem)ToolStripStatusLabel1).set_ToolTipText("Administrator Color");
		ToolStripStatusLabel2.set_BorderStyle((Border3DStyle)8192);
		((ToolStripItem)ToolStripStatusLabel2).set_Image((Image)(object)Resources.Letter_C_blue_icon);
		((ToolStripItem)ToolStripStatusLabel2).set_ImageAlign((ContentAlignment)64);
		((ToolStripItem)ToolStripStatusLabel2).set_ImageScaling((ToolStripItemImageScaling)0);
		((ToolStripItem)ToolStripStatusLabel2).set_Name("ToolStripStatusLabel2");
		ToolStripStatusLabel toolStripStatusLabel2 = ToolStripStatusLabel2;
		size = new Size(34, 26);
		((ToolStripItem)toolStripStatusLabel2).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel2).set_Text(" ");
		((ToolStripItem)ToolStripStatusLabel2).set_TextAlign((ContentAlignment)16);
		((ToolStripItem)ToolStripStatusLabel2).set_TextImageRelation((TextImageRelation)8);
		((ToolStripItem)ToolStripStatusLabel2).set_ToolTipText("Client Color");
		((ToolStripItem)ToolStripStatusLabel3).set_Image((Image)(object)Resources._1487207229_Bring_to_Front);
		((ToolStripItem)ToolStripStatusLabel3).set_Name("ToolStripStatusLabel3");
		ToolStripStatusLabel toolStripStatusLabel3 = ToolStripStatusLabel3;
		size = new Size(80, 26);
		((ToolStripItem)toolStripStatusLabel3).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel3).set_Text(" Top Most");
		((ToolStripItem)ToolStripStatusLabel3).set_TextImageRelation((TextImageRelation)8);
		((ToolStripItem)ToolStripStatusLabel3).set_ToolTipText("Top Most");
		((Control)Panel4).set_Anchor((AnchorStyles)11);
		((Control)Panel4).get_Controls().Add((Control)(object)PictureBox3);
		((Control)Panel4).get_Controls().Add((Control)(object)Label2);
		((Control)Panel4).get_Controls().Add((Control)(object)PictureBox1);
		((Control)Panel4).get_Controls().Add((Control)(object)Label1);
		Panel panel7 = Panel4;
		location = new Point(598, 94);
		((Control)panel7).set_Location(location);
		((Control)Panel4).set_Name("Panel4");
		Panel panel8 = Panel4;
		size = new Size(185, 341);
		((Control)panel8).set_Size(size);
		((Control)Panel4).set_TabIndex(8);
		((Control)PictureBox3).set_BackColor(Color.Transparent);
		PictureBox3.set_Image((Image)(object)Resources._1487204505_pen);
		PictureBox pictureBox9 = PictureBox3;
		location = new Point(156, 159);
		((Control)pictureBox9).set_Location(location);
		((Control)PictureBox3).set_Name("PictureBox3");
		PictureBox pictureBox10 = PictureBox3;
		size = new Size(26, 18);
		((Control)pictureBox10).set_Size(size);
		PictureBox3.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox3.set_TabIndex(4);
		PictureBox3.set_TabStop(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImageLayout((ImageLayout)0);
		size = new Size(783, 504);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Panel4);
		((Control)this).get_Controls().Add((Control)(object)Panel3);
		((Control)this).get_Controls().Add((Control)(object)Panel2);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("ChatGR");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("CHAT");
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)Pic).EndInit();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)PictureBox5).EndInit();
		((ISupportInitialize)PictureBox4).EndInit();
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel3).ResumeLayout(false);
		((Control)Panel3).PerformLayout();
		((ISupportInitialize)PictureBox2).EndInit();
		((Control)StatusStrip1).ResumeLayout(false);
		((Control)StatusStrip1).PerformLayout();
		((Control)Panel4).ResumeLayout(false);
		((Control)Panel4).PerformLayout();
		((ISupportInitialize)PictureBox3).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public void STREAMING(object sender, NewFrameEventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		try
		{
			PP.set_Image((Image)(Bitmap)((Image)e.get_Frame()).Clone());
			while (true)
			{
				Image val = (Image)(Bitmap)PP.get_Image();
				Bitmap val2 = new Bitmap(val);
				try
				{
					Image val3 = (Image)new Bitmap(val);
					EncoderParameters val4 = new EncoderParameters(1);
					val4.get_Param()[0] = new EncoderParameter(Encoder.Quality, (long)Q);
					ImageCodecInfo encoderInfo = GetEncoderInfo("image/jpeg");
					MemoryStream memoryStream = new MemoryStream();
					val3.Save((Stream)memoryStream, encoderInfo, val4);
					val3.Dispose();
					MemoryStream memoryStream2 = new MemoryStream(memoryStream.ToArray());
					LastPicture = MD5(memoryStream.ToArray());
					PictureBox pictureBox = PictureBox2;
					lock (pictureBox)
					{
						PictureBox2.set_Image(Image.FromStream((Stream)memoryStream2));
					}
					ByTesS = memoryStream.ToArray();
					val.Dispose();
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void TT(Color C, string IDF, string T)
	{
		RCG.set_SelectionColor(C);
		((TextBoxBase)RCG).AppendText("[ " + Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.get_Now()))) + " ] - " + IDF + " : " + T + "\r\n");
		((TextBoxBase)RCG).ScrollToCaret();
	}

	public void RC(int Device)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		FuenteDeVideo = new VideoCaptureDevice(DispositivosDeVideo.get_Item(Device).MonikerString);
		FuenteDeVideo.add_NewFrame(new NewFrameEventHandler(STREAMING));
		FuenteDeVideo.Start();
		Timer1.set_Enabled(true);
	}

	private static ImageCodecInfo GetEncoderInfo(string format)
	{
		ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
		int num = imageEncoders.Length;
		int num2 = 0;
		while (true)
		{
			int num3 = num2;
			int num4 = num;
			if (num3 <= num4)
			{
				if (Operators.CompareString(imageEncoders[num2].get_MimeType(), format, false) == 0)
				{
					break;
				}
				num2 = checked(num2 + 1);
				continue;
			}
			return null;
		}
		return imageEncoders[num2];
	}

	public static string MD5(byte[] BB)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		BB = mD5CryptoServiceProvider.ComputeHash(BB);
		string text = "";
		byte[] array = BB;
		foreach (byte b in array)
		{
			text += b.ToString("x2");
		}
		return text;
	}

	public void Finaliza()
	{
		try
		{
			if ((FuenteDeVideo != null && FuenteDeVideo.get_IsRunning()) ? true : false)
			{
				FuenteDeVideo.SignalToStop();
				FuenteDeVideo = null;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Timer1.set_Enabled(false);
	}

	public void SOO(int ZE)
	{
		MyProject.Forms.FrmMAINGR.s.Send(Sock, "CWC" + MyProject.Forms.FrmMAINGR.Key + ZE + MyProject.Forms.FrmMAINGR.Key + Q);
	}

	private void CH_Load(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		((Control)PictureBox3).set_Visible(false);
		PP = new PictureBox();
		if (Operators.CompareString(CLDP, (string)null, false) != 0)
		{
			try
			{
				PictureBox2.set_Image((Image)new Bitmap(Image.FromStream((Stream)new MemoryStream(Convert.FromBase64String(CLDP)))));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(ADP, (string)null, false) != 0)
		{
			try
			{
				PictureBox1.set_Image((Image)new Bitmap(Image.FromStream((Stream)new MemoryStream(Convert.FromBase64String(ADP)))));
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		MyProject.Forms.FrmMAINGR.s.Send(Sock, "OFC" + MyProject.Forms.FrmMAINGR.Key + MeColorString + MyProject.Forms.FrmMAINGR.Key + ClientColorString + MyProject.Forms.FrmMAINGR.Key + ID + MyProject.Forms.FrmMAINGR.Key + CID + MyProject.Forms.FrmMAINGR.Key + FT + MyProject.Forms.FrmMAINGR.Key + ASS);
		OLDStatus = Label2.get_Text();
		((Control)Pic).set_Visible(false);
		((Control)RCG).set_Dock((DockStyle)5);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		try
		{
			MyProject.Forms.FrmMAINGR.s.Send(Sock, "RWCK" + MyProject.Forms.FrmMAINGR.Key + Convert.ToBase64String(ByTesS));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Timer3_Tick(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual((object)INPTXT.get_Text(), LastTyping, false))
		{
			MyProject.Forms.FrmMAINGR.s.Send(Sock, "IsTyping" + MyProject.Forms.FrmMAINGR.Key + "True");
			Timer3.set_Enabled(false);
		}
	}

	private void CH_FormClosing(object sender, FormClosingEventArgs e)
	{
		Finaliza();
		MyProject.Forms.FrmMAINGR.s.Send(Sock, "Stop");
		MyProject.Forms.FrmMAINGR.s.Send(Sock, "Abort");
	}

	private void INPTXT_KeyPress(object sender, KeyPressEventArgs e)
	{
		if ((Operators.CompareString(INPTXT.get_Text(), "", false) != 0 && Operators.CompareString(Conversions.ToString(e.get_KeyChar()), "\r", false) == 0) ? true : false)
		{
			MyProject.Forms.FrmMAINGR.s.Send(Sock, "ET" + MyProject.Forms.FrmMAINGR.Key + Functions.Encode(INPTXT.get_Text()));
			TT(MeColor, Functions.Decode(ID).ToString(), INPTXT.get_Text());
			INPTXT.set_Text("");
			MyProject.Forms.FrmMAINGR.s.Send(Sock, "IsTyping" + MyProject.Forms.FrmMAINGR.Key + "True");
			((TextBoxBase)INPTXT).ScrollToCaret();
			((Control)Button1).set_Enabled(true);
		}
	}

	private void INPTXT_TextChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(INPTXT.get_Text(), "", false) != 0)
		{
			if (!Timer3.get_Enabled())
			{
				Timer3.set_Enabled(true);
			}
			((Control)Button1).set_Enabled(true);
			MyProject.Forms.FrmMAINGR.s.Send(Sock, "IsTyping" + MyProject.Forms.FrmMAINGR.Key + "False");
			LastTyping = INPTXT.get_Text();
		}
		else
		{
			((Control)Button1).set_Enabled(false);
			Label2.set_Text(OLDStatus);
		}
	}

	private void Button2_ButtonClick(object sender, EventArgs e)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(((Control)Button2).get_Tag(), (object)"Start video call", false))
		{
			ChatWGR chatWGR = new ChatWGR();
			((Control)chatWGR).set_Name("WCV" + OS);
			chatWGR.Devices = Devices;
			chatWGR.NOO = OS;
			((Form)chatWGR).ShowDialog();
		}
		else
		{
			((Control)Button2).set_Tag((object)"Start video call");
			Timer1.set_Enabled(false);
			((ButtonBase)Button2).set_Image((Image)(object)Resources.addWebcam);
			((Control)Pic).set_Visible(false);
			((Control)RCG).set_Dock((DockStyle)5);
			Finaliza();
			MyProject.Forms.FrmMAINGR.s.Send(Sock, "Stop");
			PictureBox2.set_Image(Old);
		}
	}

	private void ToolStripSplitButton1_ButtonClick(object sender, EventArgs e)
	{
		MyProject.Forms.FrmMAINGR.s.Send(Sock, "Ping");
		TT(Color.Blue, Functions.Decode(ID).ToString(), "Buzz!!");
	}

	private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)((CommonDialog)ColorDialog1).ShowDialog() == 1)
		{
			MeColorString = ColorDialog1.get_Color().ToArgb().ToString();
			MeColor = Color.FromArgb(int.Parse(MeColorString));
			MyProject.Forms.FrmMAINGR.s.Send(Sock, "Color" + MyProject.Forms.FrmMAINGR.Key + MeColorString + MyProject.Forms.FrmMAINGR.Key + ClientColorString);
		}
	}

	private void ToolStripStatusLabel2_Click(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)((CommonDialog)ColorDialog1).ShowDialog() == 1)
		{
			ClientColorString = ColorDialog1.get_Color().ToArgb().ToString();
			ClinetColor = Color.FromArgb(int.Parse(ClientColorString));
			MyProject.Forms.FrmMAINGR.s.Send(Sock, "Color" + MyProject.Forms.FrmMAINGR.Key + MeColorString + MyProject.Forms.FrmMAINGR.Key + ClientColorString);
		}
	}

	private void ToolStripStatusLabel3_Click(object sender, EventArgs e)
	{
		bool flag;
		if (((ToolStripItem)ToolStripStatusLabel3).get_ForeColor() == Color.Blue)
		{
			flag = false;
			((ToolStripItem)ToolStripStatusLabel3).set_ForeColor(Color.Black);
		}
		else
		{
			flag = true;
			((ToolStripItem)ToolStripStatusLabel3).set_ForeColor(Color.Blue);
		}
		MyProject.Forms.FrmMAINGR.s.Send(Sock, "TOM" + MyProject.Forms.FrmMAINGR.Key + flag);
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		try
		{
			if (Operators.CompareString(INPTXT.get_Text(), "", false) > 0)
			{
				MyProject.Forms.FrmMAINGR.s.Send(Sock, "ET" + MyProject.Forms.FrmMAINGR.Key + Functions.Encode(INPTXT.get_Text()));
				TT(MeColor, Functions.Decode(ID).ToString(), INPTXT.get_Text());
				INPTXT.set_Text("");
				MyProject.Forms.FrmMAINGR.s.Send(Sock, "IsTyping" + MyProject.Forms.FrmMAINGR.Key + "True");
				((TextBoxBase)INPTXT).ScrollToCaret();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void PictureBox2_DoubleClick(object sender, EventArgs e)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(((Control)Button2).get_Tag(), (object)"Stop video call", false))))
		{
			ChatPGR chatPGR = new ChatPGR();
			chatPGR.Sock = Sock;
			chatPGR.NOO = OS;
			chatPGR.MOO = true;
			((Control)chatPGR).set_Name("CP" + OS);
			((Form)chatPGR).ShowDialog();
		}
	}

	private void PictureBox1_DoubleClick(object sender, EventArgs e)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(((Control)Button2).get_Tag(), (object)"Stop video call", false))))
		{
			ChatPGR chatPGR = new ChatPGR();
			chatPGR.Sock = Sock;
			chatPGR.NOO = OS;
			chatPGR.MOO = false;
			((Form)chatPGR).ShowDialog();
		}
	}

	private void Label4_Click(object sender, EventArgs e)
	{
	}

	private void PictureBox4_Click(object sender, EventArgs e)
	{
	}
}
