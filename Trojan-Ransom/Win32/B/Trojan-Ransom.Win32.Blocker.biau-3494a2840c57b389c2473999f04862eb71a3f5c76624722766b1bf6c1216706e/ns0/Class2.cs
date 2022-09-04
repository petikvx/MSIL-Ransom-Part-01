using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ns0;

internal sealed class Class2
{
	private delegate string Delegate0();

	private sealed class Class3
	{
		private static readonly Delegate0 delegate0_0;

		public static readonly Class3 class3_0;

		internal byte[] byte_0;

		static Class3()
		{
			if (DateTime.Now > new DateTime(635075501244860026L))
			{
				throw new Exception();
			}
			if (DateTime.Now > new DateTime(635075357244610012L))
			{
				throw new Exception();
			}
			delegate0_0 = smethod_1;
			class3_0 = new Class3();
		}

		private Class3()
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(delegate0_0());
			if (manifestResourceStream != null || 1 == 0)
			{
				byte[] array = (byte_0 = new byte[16]);
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

	internal sealed class Class4
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 154)]
		private struct Struct1
		{
		}

		private static readonly char[] char_0;

		private static readonly char[] char_1;

		private static readonly string[] string_0;

		internal static byte byte_0/* Not supported: data(00) */;

		static Class4()
		{
			char_1 = new char[77];
			char[] array = new char[8];
			array[5] = '㲌';
			array[2] = '㡉';
			array[4] = '⧙';
			array[0] = '⺧';
			array[3] = '㏾';
			array[1] = '\u1c8c';
			array[6] = '\u17b8';
			array[7] = '㪱';
			string_0 = new string[6];
			char_0 = array;
		}
	}

	internal sealed class Class5
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
		private struct Struct2
		{
		}

		private static readonly char[] char_0;

		private static readonly char[] char_1;

		private static readonly string[] string_0;

		internal static byte byte_0/* Not supported: data(00) */;

		static Class5()
		{
			char_1 = new char[8];
			char[] array = new char[8];
			array[1] = '⊰';
			array[0] = '㬤';
			array[2] = '⌔';
			array[3] = '᭷';
			array[5] = 'ɝ';
			array[6] = 'Ⴊ';
			array[4] = '⦙';
			array[7] = 'ḉ';
			string_0 = new string[1];
			char_0 = array;
		}
	}

	public static string smethod_0(string string_0, int int_0)
	{
		if (DateTime.Now > new DateTime(635075357244640013L))
		{
			throw new Exception();
		}
		return string.Intern(Class3.class3_0.method_0(string_0, int_0));
	}

	public static string smethod_1()
	{
		char[] array = "\u0016\u0015\u0014\v/".ToCharArray();
		int num = array.Length;
		while (--num >= 0)
		{
			array[num] = (char)(array[num] ^ 0x64u);
		}
		return new string(array);
	}
}
