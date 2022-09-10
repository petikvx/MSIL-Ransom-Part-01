using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ns0;

internal sealed class Class2
{
	private sealed class Class3
	{
		public static readonly Class3 class3_0;

		internal byte[] byte_0;

		static Class3()
		{
			if (DateTime.Now > new DateTime(635308487596003595L))
			{
				throw new Exception();
			}
			class3_0 = new Class3();
		}

		private Class3()
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(smethod_1());
			if (manifestResourceStream != null)
			{
				byte[] array = (byte_0 = new byte[256]);
				manifestResourceStream.Read(byte_0, 0, byte_0.Length);
			}
		}

		public string method_0(string string_0, int int_0)
		{
			int num = string_0.Length;
			int num2 = int_0 & 0xFF;
			char[] array = string_0.ToCharArray();
			while (--num >= 0)
			{
				array[num] = (char)(array[num] ^ (byte_0[num2] | int_0));
			}
			return string.Intern(new string(array));
		}
	}

	internal sealed class Class4
	{
		private static bool bool_0;
	}

	public static string smethod_0(string string_0, int int_0)
	{
		if (DateTime.Now > new DateTime(635308487597088732L))
		{
			throw new Exception();
		}
		return string.Intern(Class3.class3_0.method_0(string_0, int_0));
	}

	[SpecialName]
	public static string smethod_1()
	{
		return "f2e5abd49a784685a5243a9f9a389c0e";
	}
}
