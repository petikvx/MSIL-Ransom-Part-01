using System;
using System.IO;
using System.Reflection;

namespace RU;

internal sealed class Class22
{
	private delegate string Delegate0();

	private sealed class Class23
	{
		private static readonly Delegate0 delegate0_0;

		public static readonly Class23 class23_0;

		private byte[] byte_0;

		static Class23()
		{
			if (DateTime.Now > new DateTime(636770065144335093L))
			{
				throw new Exception();
			}
			delegate0_0 = smethod_1;
			class23_0 = new Class23();
		}

		private Class23()
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(delegate0_0());
			if (manifestResourceStream != null || 1 == 0)
			{
				byte_0 = new byte[16];
				manifestResourceStream.Read(byte_0, 0, byte_0.Length);
			}
		}

		public string method_0(string string_0, int int_0)
		{
			int num = string_0.Length;
			char[] array = string_0.ToCharArray();
			while (--num >= 0)
			{
				array[num] = (char)(array[num] ^ (byte_0[int_0 & 0xF] | int_0));
			}
			return new string(array);
		}
	}

	public static string smethod_0(string string_0, int int_0)
	{
		if (DateTime.Now > new DateTime(636770046542446262L))
		{
			throw new Exception();
		}
		return Class23.class23_0.method_0(string_0, int_0);
	}

	public static string smethod_1()
	{
		char[] array = "4\u0016\t.".ToCharArray();
		int num = array.Length;
		while (--num >= 0)
		{
			array[num] = (char)(array[num] ^ 0x64u);
		}
		return new string(array);
	}
}
