using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;

namespace ns0;

internal sealed class Class1
{
	internal sealed class Class2
	{
		[SecuritySafeCritical]
		internal static MethodInfo smethod_0<T>(T gparam_0, short short_0, int int_0) where T : Assembly
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			int num = 0;
			MethodInfo result = (((int_0 ^ short_0) - 100) ^ 0) switch
			{
				0 => (MethodInfo)(_MethodBase)Class5.Class10.smethod_0((Assembly)gparam_0, (short)39, 126), 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static string smethod_1<T>(T gparam_0, short short_0, short short_1)
		{
			int num = 0;
			string result = (((short_1 ^ short_0) - 83) ^ 0) switch
			{
				0 => (string)(IConvertible)Class5.smethod_1((object)gparam_0, 959, 954), 
				_ => null, 
			};
			num++;
			return result;
		}
	}

	internal sealed class Class3
	{
		internal sealed class Class4
		{
			[SecuritySafeCritical]
			internal static StringBuilder smethod_0<T>(T gparam_0, char char_0, int int_0, int int_1) where T : StringBuilder
			{
				int num = 0;
				StringBuilder result;
				int num2;
				do
				{
					result = (((int_1 ^ int_0) - 98) ^ num) switch
					{
						0 => (StringBuilder)(ISerializable)Class5.Class8.Class9.smethod_0((StringBuilder)gparam_0, char_0, 569, (short)573), 
						_ => null, 
					};
					num++;
					num2 = char_0 * char_0;
					num2 = char_0 + num2;
				}
				while (num2 % 2 != 0);
				return result;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_0<T>(T gparam_0, char char_0, char char_1) where T : string
	{
		int num = 0;
		do
		{
			switch (((char_0 ^ char_1) - 7) ^ num)
			{
			case 0:
				Class5.Class8.smethod_1((string)gparam_0, (short)218, 153);
				break;
			}
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
	}

	[SecuritySafeCritical]
	internal static object smethod_1<T, U>(T gparam_0, U gparam_1, object[] object_0, short short_0, char char_0) where T : MethodBase
	{
		int num = 0;
		object result;
		do
		{
			result = (((short_0 ^ char_0) - 127) ^ num) switch
			{
				0 => Class5.Class11.smethod_0((MethodBase)gparam_0, (object)gparam_1, object_0, 280, 300), 
				_ => null, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_2(byte[] byte_0, char char_0, int int_0)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		int num = 0;
		Assembly result = (((char_0 ^ int_0) - 61) ^ 0) switch
		{
			0 => (Assembly)(_Assembly)Class5.Class8.smethod_2(byte_0, 558, 622), 
			_ => null, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static void smethod_3<T>(T gparam_0, int int_0, char char_0) where T : Array
	{
		int num = 0;
		do
		{
			switch (((int_0 ^ char_0) - 6) ^ num)
			{
			case 0:
				Class5.Class8.Class9.smethod_1((Array)gparam_0, '\u0316', 887);
				break;
			}
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
	}

	[SecuritySafeCritical]
	internal static byte smethod_4<T>(T gparam_0, char char_0, char char_1) where T : string
	{
		int num = 0;
		byte result;
		int num2;
		do
		{
			result = (((char_1 ^ char_0) - 2) ^ num) switch
			{
				0 => Class5.Class11.smethod_1((string)gparam_0, 347, 'ŕ'), 
				_ => 0, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}
}
