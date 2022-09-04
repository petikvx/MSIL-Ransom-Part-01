using System;
using System.IO;
using System.Reflection;

internal sealed class Class1
{
	private delegate string Delegate0();

	private sealed class Class2
	{
		private static readonly Delegate0 delegate0_0;

		public static readonly Class2 class2_0;

		private byte[] byte_0;

		static Class2()
		{
			if (DateTime.Now > new DateTime(635217852116149793L))
			{
				throw new Exception();
			}
			if (DateTime.Now > new DateTime(635217525609156941L))
			{
				throw new Exception();
			}
			if (DateTime.Now > new DateTime(635217597534307337L))
			{
				throw new Exception();
			}
			if (DateTime.Now > new DateTime(635217489533987111L))
			{
				throw new Exception();
			}
			delegate0_0 = smethod_1;
			class2_0 = new Class2();
		}

		private Class2()
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
		if (DateTime.Now > new DateTime(635217489534047160L))
		{
			throw new Exception();
		}
		return string.Intern(Class2.class2_0.method_0(string_0, int_0));
	}

	public static string smethod_1()
	{
		char[] array = Class3.smethod_0(Class5.smethod_0("\u1311ጪጋጒ", 57951), 61917).ToCharArray();
		int num = array.Length;
		while (--num >= 0)
		{
			array[num] = (char)(array[num] ^ 0x73u);
		}
		return new string(array);
	}
}
