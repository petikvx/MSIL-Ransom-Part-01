using System.IO;
using System.Reflection;

internal sealed class Class86
{
	private delegate string Delegate9();

	private sealed class Class87
	{
		private static readonly Delegate9 delegate9_0;

		public static readonly Class87 class87_0;

		private byte[] byte_0;

		static Class87()
		{
			delegate9_0 = smethod_1;
			class87_0 = new Class87();
		}

		private Class87()
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(delegate9_0());
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
		return Class87.class87_0.method_0(string_0, int_0);
	}

	public static string smethod_1()
	{
		char[] array = "(\u0019(:>".ToCharArray();
		int num = array.Length;
		while (--num >= 0)
		{
			array[num] = (char)(array[num] ^ 0x6Au);
		}
		return new string(array);
	}
}
