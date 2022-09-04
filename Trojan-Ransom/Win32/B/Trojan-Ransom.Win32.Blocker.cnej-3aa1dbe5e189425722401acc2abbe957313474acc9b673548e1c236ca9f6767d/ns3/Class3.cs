using System;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using SmartAssembly.MemoryManagement;
using ns1;

namespace ns3;

internal sealed class Class3
{
	static int smethod_0()
	{
		Version version = new Version("6.8.0.121");
		return version.Major;
	}

	static string smethod_1()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class3.smethod_4());
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(Class3.smethod_5());
			}
			if (registryKey == null)
			{
				return null;
			}
			string result = (string)registryKey.GetValue("Path", null);
			registryKey.Close();
			return result;
		}
		catch
		{
			return null;
		}
	}

	unsafe static byte[] smethod_2(string string_0, byte[] byte_0)
	{
		void* ptr = stackalloc byte[16];
		byte[] bytes = Encoding.Default.GetBytes(string_0);
		*(int*)ptr = byte_0[checked(byte_0.Length - 1)] ^ 0x70;
		byte[] array = new byte[checked(byte_0.Length + 1)];
		byte* num = (byte*)ptr + 8;
		*(int*)((byte*)ptr + 12) = checked(byte_0.Length - 1);
		*(int*)num = 0;
		checked
		{
			while (unchecked(*(int*)((byte*)ptr + 8) <= *(int*)((byte*)ptr + 12)))
			{
				array[*unchecked((int*)((byte*)ptr + 8))] = (byte)unchecked(byte_0[*(int*)((byte*)ptr + 8)] ^ *(int*)ptr ^ bytes[*(int*)((byte*)ptr + 4)]);
				if (*unchecked((int*)((byte*)ptr + 4)) == string_0.Length - 1)
				{
					*unchecked((int*)((byte*)ptr + 4)) = 0;
				}
				else
				{
					(*unchecked((int*)((byte*)ptr + 4)))++;
				}
				(*unchecked((int*)((byte*)ptr + 8)))++;
			}
			return (byte[])Utils.CopyArray((Array)array, (Array)new byte[byte_0.Length - 2 + 1]);
		}
	}

	static bool smethod_3()
	{
		return Class2.smethod_0();
	}

	static string smethod_4()
	{
		return "Software\\Red Gate\\" + Class3.smethod_8();
	}

	static string smethod_5()
	{
		return "Software\\Wow6432Node\\Red Gate\\" + Class3.smethod_8();
	}

	static string smethod_6()
	{
		return "SmartAssembly";
	}

	static void smethod_7()
	{
		try
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				MemoryManager.memoryManager_0 = new MemoryManager();
			}
		}
		catch
		{
		}
	}

	static string smethod_8()
	{
		return "SmartAssembly" + " " + Class3.smethod_0();
	}
}
