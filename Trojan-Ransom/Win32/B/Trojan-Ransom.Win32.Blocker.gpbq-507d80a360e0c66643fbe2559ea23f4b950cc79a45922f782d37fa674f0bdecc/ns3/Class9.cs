using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using ns2;

namespace ns3;

internal sealed class Class9
{
	private sealed class Class10
	{
		public static readonly Class10 class10_0;

		private byte[] byte_0;

		static Class10()
		{
			if (Delegate9.delegate9_0(Delegate8.delegate8_0(), new DateTime(635618784852324219L)))
			{
				throw new Exception();
			}
			class10_0 = new Class10();
		}

		private Class10()
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
		if (Delegate9.delegate9_0(Delegate8.delegate8_0(), new DateTime(635618784853281250L)))
		{
			throw new Exception();
		}
		return Delegate21.delegate21_0(Class10.class10_0.method_0(string_0, int_0));
	}

	[SpecialName]
	public static string smethod_1()
	{
		return Class16.smethod_0(962);
	}
}
