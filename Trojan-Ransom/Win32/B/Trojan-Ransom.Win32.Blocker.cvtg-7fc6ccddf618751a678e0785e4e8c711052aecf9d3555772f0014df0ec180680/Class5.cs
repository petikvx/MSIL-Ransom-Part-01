using System;
using System.IO;
using System.Reflection;

internal sealed class Class5
{
	private delegate string Delegate2();

	private sealed class Class6
	{
		private static readonly Delegate2 delegate2_0;

		public static readonly Class6 class6_0;

		private byte[] byte_0;

		static Class6()
		{
			if (DateTime.Now > new DateTime(635217780116169815L))
			{
				throw new Exception();
			}
			if (DateTime.Now > new DateTime(635217744115829585L))
			{
				throw new Exception();
			}
			delegate2_0 = smethod_1;
			class6_0 = new Class6();
		}

		private Class6()
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(delegate2_0());
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
		if (DateTime.Now > new DateTime(635217672115879621L))
		{
			throw new Exception();
		}
		return string.Intern(Class6.class6_0.method_0(string_0, int_0));
	}

	public static string smethod_1()
	{
		char[] array = "!\u001e,3".ToCharArray();
		int num = array.Length;
		while (--num >= 0)
		{
			array[num] = (char)(array[num] ^ 0x69u);
		}
		return new string(array);
	}
}
