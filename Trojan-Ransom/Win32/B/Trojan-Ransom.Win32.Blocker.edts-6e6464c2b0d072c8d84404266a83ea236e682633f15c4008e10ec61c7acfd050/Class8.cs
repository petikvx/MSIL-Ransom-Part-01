using System;
using System.IO;
using System.Reflection;

internal sealed class Class8
{
	private sealed class Class9
	{
		public static readonly Class9 class9_0;

		private byte[] byte_0;

		static Class9()
		{
			if (DateTime.Now > new DateTime(635328237368617325L))
			{
				throw new Exception();
			}
			class9_0 = new Class9();
		}

		private Class9()
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

	public static string String_0 => Class10.smethod_0("\uec0d\uec57\uec5e\uec5d\uec56\uec5a\uec0c\uec58\uec5b\uec0f\uec0d\uec59\uec5a\uec0d\uec5e\uec5c\uec57\uec5a\uec57\uec5e\uec0c\uec5d\uec5c\uec0a\uec5c\uec58\uec0c\uec0b\uec5a\uec5d\uec57\uec0a", 60430);

	public static string smethod_0(string string_0, int int_0)
	{
		if (DateTime.Now > new DateTime(635328237369877397L))
		{
			throw new Exception();
		}
		return string.Intern(Class9.class9_0.method_0(string_0, int_0));
	}
}
