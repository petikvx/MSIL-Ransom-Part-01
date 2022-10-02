using System.IO;
using System.Reflection;

internal sealed class Class47
{
	private delegate string Delegate3();

	private sealed class Class48
	{
		private static readonly Delegate3 delegate3_0;

		public static readonly Class48 class48_0;

		private byte[] byte_0;

		static Class48()
		{
			delegate3_0 = smethod_1;
			class48_0 = new Class48();
		}

		private Class48()
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(delegate3_0());
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
		return Class48.class48_0.method_0(string_0, int_0);
	}

	public static string smethod_1()
	{
		char[] array = "\u001a:!\u001b9".ToCharArray();
		int num = array.Length;
		while (--num >= 0)
		{
			array[num] = (char)(array[num] ^ 0x6Au);
		}
		return new string(array);
	}

	internal static int smethod_2(int int_0)
	{
		return int_0 switch
		{
			32 => -63, 
			34 => -11, 
			37 => -52, 
			40 => -64, 
			41 => -10, 
			42 => -15, 
			45 => -9, 
			46 => -32, 
			49 => -27, 
			50 => -24, 
			_ => -1, 
		};
	}
}
