using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ns0;

internal sealed class Class6
{
	private sealed class Class7
	{
		public static readonly Class7 class7_0;

		internal byte[] byte_0;

		static Class7()
		{
			Class4.smethod_2();
			if (Class0.smethod_1(Class0.Class1.smethod_0(642, 'ˤ'), new DateTime(635305919190058593L), 770, 864))
			{
				throw new Exception();
			}
			class7_0 = new Class7();
		}

		private Class7()
		{
			Assembly gparam_ = Class0.smethod_2('è', 190);
			Stream stream = (Stream)(IDisposable)Class4.smethod_3(gparam_, smethod_1(), 284, 317);
			if (stream != null)
			{
				byte[] array = (byte_0 = new byte[256]);
				Class12.smethod_0(stream, byte_0, 0, byte_0.Length, 73, 103);
			}
		}

		public string method_0(string string_0, int int_0)
		{
			int num = Class2.smethod_2(string_0, 'Ƈ', 405);
			int num2 = int_0 & 0xFF;
			char[] array = (char[])(ICloneable)Class0.Class1.smethod_1(string_0, 38, '6');
			while (--num >= 0)
			{
				array[num] = (char)(array[num] ^ (byte_0[num2] | int_0));
			}
			return Class12.smethod_1(new string(array), 830, '\u0313');
		}
	}

	internal sealed class Class8
	{
	}

	internal sealed class Class9
	{
	}

	public static string smethod_0(string string_0, int int_0)
	{
		if (Class0.smethod_1(Class0.Class1.smethod_0(1000, 'Ύ'), new DateTime(635305919192480468L), 763, 665))
		{
			throw new Exception();
		}
		return Class12.smethod_1(Class7.class7_0.method_0(string_0, int_0), 82, '\u007f');
	}

	[SpecialName]
	public static string smethod_1()
	{
		return Class10.smethod_0("\uf3dc\uf3d6\uf3d9\uf3d8\uf3df\uf38e\uf3da\uf3df\uf3da\uf38a\uf38e\uf38d\uf3db\uf38b\uf3de\uf3dd\uf3d6\uf3d8\uf3da\uf38d\uf3db\uf38a\uf3dd\uf3dc\uf3df\uf38b\uf3da\uf3df\uf38c\uf3df\uf3d8\uf3d7", 62316);
	}
}
