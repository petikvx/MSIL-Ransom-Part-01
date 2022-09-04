using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;

namespace ns0;

internal sealed class Class7
{
	private sealed class Class8
	{
		public static readonly Class8 class8_0;

		internal byte[] byte_0;

		static Class8()
		{
			smethod_2();
			if (Class5.smethod_3(BabelAttribute.Class0.Class1.smethod_1('Σ', 1002), new DateTime(635306814329529373L), 588, 'ȵ'))
			{
				throw new Exception();
			}
			class8_0 = new Class8();
		}

		private Class8()
		{
			Assembly gparam_ = (Assembly)(ISerializable)Class5.smethod_2(333, 383);
			Stream stream = Class5.smethod_4(gparam_, smethod_1(), 'Ŀ', 331);
			if (stream != null)
			{
				byte[] array = (byte_0 = new byte[256]);
				Class9.Class10.smethod_0(stream, byte_0, 0, byte_0.Length, 'Ϧ', 'Σ');
			}
		}

		public string method_0(string string_0, int int_0)
		{
			int num = BabelAttribute.Class0.smethod_2(string_0, 544, 'Ȣ');
			int num2 = int_0 & 0xFF;
			char[] array = BabelAttribute.smethod_2(string_0, 940, 'ά');
			while (--num >= 0)
			{
				array[num] = (char)(array[num] ^ (byte_0[num2] | int_0));
			}
			return Class14.smethod_0(new string(array), 934, 900);
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 400)]
	private struct Struct1
	{
	}

	private static bool bool_0;

	private static readonly object object_0;

	private static readonly object object_1 = new char[200];

	private static readonly object object_2;

	internal static byte byte_0/* Not supported: data(00) */;

	public static string smethod_0(string string_0, int int_0)
	{
		if (Class5.smethod_3(BabelAttribute.Class0.Class1.smethod_1('ʍ', 708), new DateTime(635306814329799550L), 515, 'ɺ'))
		{
			throw new Exception();
		}
		return Class14.smethod_0(Class8.class8_0.method_0(string_0, int_0), 839, 869);
	}

	[SpecialName]
	public static string smethod_1()
	{
		return "34028bfce6934157903af4427b4cb604";
	}

	static Class7()
	{
		char[] array = new char[8];
		array[5] = 'ץ';
		array[4] = 'ᾱ';
		array[1] = 'đ';
		array[2] = '-';
		array[0] = '⺽';
		array[6] = '\u0c63';
		array[7] = '\u05ec';
		array[3] = 'Ǒ';
		object_2 = new string[7];
		object_0 = array;
		smethod_2();
	}

	internal static void smethod_2()
	{
		if (bool_0)
		{
			return;
		}
		Type typeFromHandle;
		Class9.smethod_0((object)(typeFromHandle = typeof(Class7)), 77, (short)110);
		try
		{
			if (!bool_0)
			{
				bool_0 = true;
				Class9.smethod_1<AppDomain, ResolveEventHandler>(Class9.Class10.smethod_1(825, 806), BabelAttribute.smethod_0, 989, 'Ϟ');
			}
		}
		finally
		{
			Class9.smethod_0((object)typeFromHandle, 766, (short)730);
		}
	}

	internal static AppDomain smethod_3(char char_0, int int_0)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		int num = 0;
		AppDomain result = (((char_0 ^ int_0) - 102) ^ 0) switch
		{
			0 => (AppDomain)(IEvidenceFactory)Class9.Class10.smethod_1(512, 543), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static Encoding smethod_4(char char_0, int int_0)
	{
		int num = 0;
		Encoding result = (((int_0 ^ char_0) - 59) ^ 0) switch
		{
			0 => (Encoding)(ICloneable)Class14.Class15.smethod_0(261, 'ģ'), 
			_ => null, 
		};
		num++;
		return result;
	}
}
