using System;
using System.IO;
using System.Reflection;

internal sealed class Class6
{
	private delegate string Delegate0();

	private sealed class Class7
	{
		private static readonly Delegate0 delegate0_0;

		public static readonly Class7 class7_0;

		private byte[] byte_0;

		static Class7()
		{
			if (DateTime.Now > new DateTime(635293720747043423L))
			{
				throw new Exception();
			}
			if (DateTime.Now > new DateTime(635293504746533394L))
			{
				throw new Exception();
			}
			delegate0_0 = smethod_1;
			class7_0 = new Class7();
		}

		private Class7()
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(delegate0_0());
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
		if (DateTime.Now > new DateTime(635293648746623399L))
		{
			throw new Exception();
		}
		return string.Intern(Class7.class7_0.method_0(string_0, int_0));
	}

	public static string smethod_1()
	{
		char[] array = "ËÄÔø".ToCharArray();
		int num = array.Length;
		while (--num >= 0)
		{
			array[num] = (char)(array[num] ^ 0x81u);
		}
		return new string(array);
	}
}
