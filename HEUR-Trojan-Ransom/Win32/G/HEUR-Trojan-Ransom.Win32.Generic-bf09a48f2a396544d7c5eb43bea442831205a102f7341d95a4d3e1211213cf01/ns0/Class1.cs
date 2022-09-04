using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace ns0;

internal sealed class Class1
{
	private sealed class Class2
	{
		public static readonly Class2 class2_0;

		internal byte[] byte_0;

		[SecuritySafeCritical]
		static Class2()
		{
			if (DateTime.Now > new DateTime(635078201247715947L))
			{
				throw new Exception();
			}
			class2_0 = new Class2();
		}

		private Class2()
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(smethod_1());
			if (manifestResourceStream != null)
			{
				byte[] array = (byte_0 = new byte[256]);
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

	internal sealed class Class3
	{
		internal sealed class Class4
		{
			private static bool bool_0;
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 138)]
		private struct Struct1
		{
		}

		private static readonly char[] char_0;

		private static readonly char[] char_1;

		private static readonly string[] string_0;

		internal static byte byte_0/* Not supported: data(00) */;

		static Class3()
		{
			char_1 = new char[69];
			char[] array = new char[8];
			array[3] = 'ᣜ';
			array[6] = 'ᗼ';
			array[0] = '\u05f8';
			array[5] = '⍟';
			array[4] = '᧚';
			array[1] = '〷';
			array[7] = '⍩';
			array[2] = '⓽';
			string_0 = new string[4];
			char_0 = array;
		}
	}

	public static string smethod_0(string string_0, int int_0)
	{
		if (DateTime.Now > new DateTime(635078201250835953L))
		{
			throw new Exception();
		}
		return string.Intern(Class2.class2_0.method_0(string_0, int_0));
	}

	[SpecialName]
	public static string smethod_1()
	{
		return "156ca32f4f93807f";
	}
}
