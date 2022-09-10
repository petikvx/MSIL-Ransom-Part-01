using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using ns2;
using ns3;

namespace ns1;

internal sealed class Class1
{
	private sealed class Class2
	{
		public static readonly Class2 class2_0;

		private byte[] byte_0;

		static Class2()
		{
			if (Delegate9.delegate9_0(Delegate8.delegate8_0(), new DateTime(635618784357158203L)))
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
				byte_0 = new byte[256];
				manifestResourceStream.Read(byte_0, 0, byte_0.Length);
			}
		}

		public string method_0(string string_0, int int_0)
		{
			int num = Delegate22.delegate22_1(string_0);
			int num2 = int_0 & 0xFF;
			char[] array = Delegate23.delegate23_1(string_0);
			while (--num >= 0)
			{
				array[num] = (char)(array[num] ^ (byte_0[num2] | int_0));
			}
			return Delegate21.delegate21_0(new string(array));
		}
	}

	public static string smethod_0(string string_0, int int_0)
	{
		if (Delegate9.delegate9_0(Delegate8.delegate8_0(), new DateTime(635618784358066406L)))
		{
			throw new Exception();
		}
		return Delegate21.delegate21_0(Class2.class2_0.method_0(string_0, int_0));
	}

	[SpecialName]
	public static string smethod_1()
	{
		return Class3.smethod_0(Class5.smethod_0(Class7.smethod_0(Class9.smethod_0(Class16.smethod_0(442), 61636), 58549), 62463), 59773);
	}
}
