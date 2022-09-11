using System;
using System.IO;
using System.Reflection;

internal sealed class Class5
{
	private sealed class Class6
	{
		public static readonly Class6 class6_0;

		private byte[] byte_0;

		static Class6()
		{
			if (DateTime.Now > new DateTime(636869974849516264L))
			{
				throw new Exception();
			}
			class6_0 = new Class6();
		}

		private Class6()
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(String_0);
			if (manifestResourceStream != null)
			{
				byte_0 = new byte[256];
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

	public static string String_0 => "05f1e17cb4224aafa85f56e2cfa3aa95";

	public static string smethod_0(string string_0, int int_0)
	{
		if (DateTime.Now > new DateTime(636869974850863937L))
		{
			throw new Exception();
		}
		return string.Intern(Class6.class6_0.method_0(string_0, int_0));
	}
}
