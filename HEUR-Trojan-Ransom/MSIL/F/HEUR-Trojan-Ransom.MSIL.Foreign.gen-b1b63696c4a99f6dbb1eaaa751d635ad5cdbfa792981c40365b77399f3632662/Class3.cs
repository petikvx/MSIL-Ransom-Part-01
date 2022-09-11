using System;
using System.IO;
using System.Reflection;

internal sealed class Class3
{
	private delegate string Delegate0();

	private sealed class Class4
	{
		private static readonly Delegate0 delegate0_0;

		public static readonly Class4 class4_0;

		private byte[] byte_0;

		static Class4()
		{
			delegate0_0 = smethod_1;
			class4_0 = new Class4();
		}

		private Class4()
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
		DateTime dateTime = default(DateTime).AddYears(2018).AddMonths(2).AddDays(0.902152777777778);
		if ((dateTime - DateTime.Now).TotalDays >= 0.0)
		{
		}
		return Class4.class4_0.method_0(string_0, int_0);
	}

	public static string smethod_1()
	{
		char[] array = Class5.smethod_0("\ue848\ue861\ue87e\ue84e\ue866", 59522).ToCharArray();
		int num = array.Length;
		while (--num >= 0)
		{
			array[num] = (char)(array[num] ^ 0x81u);
		}
		return new string(array);
	}
}
