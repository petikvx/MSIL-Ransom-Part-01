using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Policy;
using Microsoft.Win32;

namespace ns0;

internal sealed class Class12
{
	internal sealed class Class13
	{
		internal static string smethod_0<T, U>(T gparam_0, U gparam_1, int int_0, char char_0) where T : string where U : string
		{
			int num = 0;
			string result = (((int_0 ^ char_0) - 21) ^ 0) switch
			{
				0 => string.Concat(gparam_0, gparam_1), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static string[] smethod_1<T>(T gparam_0, char char_0, int int_0) where T : Assembly
		{
			int num = 0;
			string[] result;
			int num2;
			do
			{
				result = (((char_0 ^ int_0) - 116) ^ num) switch
				{
					0 => gparam_0.GetManifestResourceNames(), 
					_ => null, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static RegistryKey smethod_2<T, U>(T gparam_0, U gparam_1, bool bool_0, char char_0, short short_0) where T : RegistryKey where U : string
		{
			int num = 0;
			RegistryKey result;
			do
			{
				result = (((short_0 ^ char_0) - 118) ^ num) switch
				{
					0 => (RegistryKey)(MarshalByRefObject)gparam_0.OpenSubKey(gparam_1, bool_0), 
					_ => null, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		internal static void smethod_3<T, U>(U gparam_0, T gparam_1, int int_0, char char_0) where T : ResolveEventHandler where U : AppDomain
		{
			int num = 0;
			int num2;
			do
			{
				switch (((int_0 ^ char_0) - 116) ^ num)
				{
				case 0:
					gparam_0.ResourceResolve += gparam_1;
					break;
				}
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
		}

		internal static void smethod_4<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, short short_0, short short_1) where T : Stream
		{
			int num = 0;
			switch (((short_0 ^ short_1) - 116) ^ 0)
			{
			case 0:
				gparam_0.Write(byte_0, int_0, int_1);
				break;
			}
			num++;
		}

		internal static Assembly smethod_5<T>(byte[] byte_0, byte[] byte_1, T gparam_0, int int_0, short short_0) where T : Evidence
		{
			int num = 0;
			Assembly result = (((short_0 ^ int_0) - 4) ^ 0) switch
			{
				0 => Assembly.Load(byte_0, byte_1, (Evidence)gparam_0), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static int smethod_6<T>(T gparam_0, int int_0, char char_0, int int_1) where T : Array
		{
			int num = 0;
			int result;
			do
			{
				result = (((int_1 ^ char_0) - 15) ^ num) switch
				{
					0 => gparam_0.GetLength(int_0), 
					_ => 15, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 78)]
	private struct Struct6
	{
	}

	private static readonly Array array_0;

	private static readonly object object_0;

	private static readonly object object_1;

	internal static byte byte_0/* Not supported: data(00) */;

	internal static AppDomain smethod_0(short short_0, char char_0)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		int num = 0;
		AppDomain result = (((char_0 ^ short_0) - 48) ^ 0) switch
		{
			0 => (AppDomain)(IEvidenceFactory)AppDomain.CurrentDomain, 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static void smethod_1<T, U>(T gparam_0, U gparam_1, int int_0, int int_1) where T : string where U : string
	{
		int num = 0;
		switch (((int_0 ^ int_1) - 10) ^ 0)
		{
		case 0:
			File.Copy(gparam_0, gparam_1);
			break;
		}
		num++;
	}

	internal static void smethod_2<T>(T gparam_0, int int_0, int int_1) where T : ResourceManager
	{
		int num = 0;
		switch (((int_1 ^ int_0) - 49) ^ 0)
		{
		case 0:
			gparam_0.ReleaseAllResources();
			break;
		}
		num++;
	}

	internal static ParameterInfo[] smethod_3<T>(T gparam_0, char char_0, int int_0) where T : MethodBase
	{
		int num = 0;
		ParameterInfo[] result = (((char_0 ^ int_0) - 91) ^ 0) switch
		{
			0 => gparam_0.GetParameters(), 
			_ => null, 
		};
		num++;
		return result;
	}

	static Class12()
	{
		object_0 = new char[39];
		char[] array = new char[8];
		array[2] = '㔊';
		array[3] = 'Ή';
		array[5] = 'т';
		array[6] = 'ட';
		array[1] = '₈';
		array[7] = 'М';
		array[0] = 'ဢ';
		array[4] = '㊱';
		object_1 = new string[1];
		array_0 = array;
	}
}
