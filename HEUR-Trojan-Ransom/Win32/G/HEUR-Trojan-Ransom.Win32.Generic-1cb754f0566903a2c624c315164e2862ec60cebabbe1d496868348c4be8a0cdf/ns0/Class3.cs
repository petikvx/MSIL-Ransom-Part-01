using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

namespace ns0;

internal sealed class Class3
{
	private sealed class Class4
	{
		public static readonly Class4 class4_0;

		internal byte[] byte_0;

		[SecuritySafeCritical]
		static Class4()
		{
			if (DateTime.Now > new DateTime(635031786664372355L))
			{
				throw new Exception();
			}
			class4_0 = new Class4();
		}

		private Class4()
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

	public static string smethod_0(string string_0, int int_0)
	{
		if (DateTime.Now > new DateTime(635031786664712374L))
		{
			throw new Exception();
		}
		return string.Intern(Class4.class4_0.method_0(string_0, int_0));
	}

	[SpecialName]
	public static string smethod_1()
	{
		return "8ec59fc486024b619603ac7219c5a599";
	}
}
