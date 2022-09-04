using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

namespace ns0;

internal sealed class Class2
{
	private sealed class Class3
	{
		public static readonly Class3 class3_0;

		internal byte[] byte_0;

		[SecuritySafeCritical]
		static Class3()
		{
			if (DateTime.Now > new DateTime(634937558763581150L))
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
			Class4.smethod_6();
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

	public Class2()
	{
		Class4.Class6.smethod_8();
	}

	public static string smethod_0(string string_0, int int_0)
	{
		if (DateTime.Now > new DateTime(634937558764049151L))
		{
			throw new Exception();
		}
		string result = string.Intern(Class3.class3_0.method_0(string_0, int_0));
		Class0.smethod_10();
		return result;
	}

	[SpecialName]
	public static string smethod_1()
	{
		Class0.smethod_4();
		return "e1e9da4cb8f8408ba3264b558e1f82d3";
	}
}
