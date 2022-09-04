using System.Net;
using System.Net.Mail;

internal sealed class Class4
{
	private SmtpClient smtpClient_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private string string_3;

	public Class4(string string_4, string string_5, string string_6, string string_7, string string_8, string string_9, string string_10)
	{
		smtpClient_0 = new SmtpClient(string_4);
		smtpClient_0.Credentials = new NetworkCredential(string_5, string_6);
		smtpClient_0.EnableSsl = true;
		string_0 = string_7;
		string_1 = string_8;
		string_2 = string_10;
		string_3 = string_9;
	}

	public void method_0(int int_0)
	{
		MailMessage mailMessage = new MailMessage();
		mailMessage.Subject = string_3;
		mailMessage.To.Add(new MailAddress(string_0));
		mailMessage.From = new MailAddress(string_1, string_1);
		mailMessage.Body = string_2;
		for (int i = 0; i < int_0; i++)
		{
			smtpClient_0.Send(mailMessage);
		}
	}
}
