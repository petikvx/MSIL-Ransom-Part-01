using System;
using System.IO;
using System.Reflection;

internal sealed class Class11
{
	private delegate string Delegate0();

	private sealed class Class12
	{
		private static readonly Delegate0 delegate0_0;

		public static readonly Class12 class12_0;

		private byte[] byte_0;

		static Class12()
		{
			if (DateTime.Now > new DateTime(637618872383014017L))
			{
				throw new Exception();
			}
			delegate0_0 = smethod_1;
			class12_0 = new Class12();
		}

		private Class12()
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
			return string.Intern(new string(array));
		}
	}

	public static string smethod_0(string string_0, int int_0)
	{
		if (DateTime.Now > new DateTime(637618800375394028L))
		{
			throw new Exception();
		}
		return string.Intern(Class12.class12_0.method_0(string_0, int_0));
	}

	public static string smethod_1()
	{
		char[] array = "\u001d\u0012\u000f\u001a\f".ToCharArray();
		int num = array.Length;
		while (--num >= 0)
		{
			array[num] = (char)(array[num] ^ 0x6Bu);
		}
		return new string(array);
	}
}
