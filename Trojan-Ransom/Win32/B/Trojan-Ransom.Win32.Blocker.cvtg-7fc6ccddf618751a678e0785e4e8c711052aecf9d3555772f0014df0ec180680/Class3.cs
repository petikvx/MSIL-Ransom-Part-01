using System;
using System.IO;
using System.Reflection;

internal sealed class Class3
{
	private delegate string Delegate1();

	private sealed class Class4
	{
		private static readonly Delegate1 delegate1_0;

		public static readonly Class4 class4_0;

		private byte[] byte_0;

		static Class4()
		{
			if (DateTime.Now > new DateTime(635217780116159797L))
			{
				throw new Exception();
			}
			if (DateTime.Now > new DateTime(635217525609156941L))
			{
				throw new Exception();
			}
			if (DateTime.Now > new DateTime(635217777608516516L))
			{
				throw new Exception();
			}
			delegate1_0 = smethod_1;
			class4_0 = new Class4();
		}

		private Class4()
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(delegate1_0());
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
		if (DateTime.Now > new DateTime(635217849608896759L))
		{
			throw new Exception();
		}
		return string.Intern(Class4.class4_0.method_0(string_0, int_0));
	}

	public static string smethod_1()
	{
		char[] array = Class5.smethod_0("\ue14c\ue16c\ue154\ue172\ue153", 57694).ToCharArray();
		int num = array.Length;
		while (--num >= 0)
		{
			array[num] = (char)(array[num] ^ 0x67u);
		}
		return new string(array);
	}
}
