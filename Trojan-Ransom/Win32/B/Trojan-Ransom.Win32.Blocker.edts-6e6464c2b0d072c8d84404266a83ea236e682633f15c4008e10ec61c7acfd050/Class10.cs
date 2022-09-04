using System;
using System.IO;
using System.Reflection;

internal sealed class Class10
{
	private sealed class Class11
	{
		public static readonly Class11 class11_0;

		private byte[] byte_0;

		static Class11()
		{
			if (DateTime.Now > new DateTime(635328237448841914L))
			{
				throw new Exception();
			}
			class11_0 = new Class11();
		}

		private Class11()
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

	public static string String_0 => "fa82cfcf2159420c80f0bcc7bc3a8b66";

	public static string smethod_0(string string_0, int int_0)
	{
		if (DateTime.Now > new DateTime(635328237450562012L))
		{
			throw new Exception();
		}
		return string.Intern(Class11.class11_0.method_0(string_0, int_0));
	}
}
