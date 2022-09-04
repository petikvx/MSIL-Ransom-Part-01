using System;
using System.IO;
using System.Reflection;

internal sealed class Class6
{
	private sealed class Class7
	{
		public static readonly Class7 class7_0;

		private byte[] byte_0;

		static Class7()
		{
			if (DateTime.Now > new DateTime(635328237010296830L))
			{
				throw new Exception();
			}
			class7_0 = new Class7();
		}

		private Class7()
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

	public static string String_0 => Class8.smethod_0(Class10.smethod_0("ԮԩտԭհԪոԪԩջԭոռչԮտձԩԩԫԫպձվջվռռԩԩԫԭ", 61749), 62681);

	public static string smethod_0(string string_0, int int_0)
	{
		if (DateTime.Now > new DateTime(635328237012616963L))
		{
			throw new Exception();
		}
		return string.Intern(Class7.class7_0.method_0(string_0, int_0));
	}
}
