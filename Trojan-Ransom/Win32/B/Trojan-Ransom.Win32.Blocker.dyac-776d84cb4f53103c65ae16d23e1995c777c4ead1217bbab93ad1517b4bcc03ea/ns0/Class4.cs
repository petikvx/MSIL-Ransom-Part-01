using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;

namespace ns0;

internal sealed class Class4
{
	private sealed class Class5
	{
		public static readonly Class5 class5_0;

		internal byte[] byte_0;

		static Class5()
		{
			smethod_2();
			if (Class0.smethod_1(Class0.Class1.smethod_0(464, 'ƶ'), new DateTime(635305918290214843L), 10, 104))
			{
				throw new Exception();
			}
			class5_0 = new Class5();
		}

		private Class5()
		{
			Assembly gparam_ = (Assembly)(ICustomAttributeProvider)Class0.smethod_2('ȋ', 605);
			Stream stream = (Stream)(IDisposable)smethod_3(gparam_, smethod_1(), 856, 889);
			if (stream != null)
			{
				byte[] array = (byte_0 = new byte[256]);
				Class12.smethod_0(stream, byte_0, 0, byte_0.Length, 89, 119);
			}
		}

		public string method_0(string string_0, int int_0)
		{
			int num = Class2.smethod_2(string_0, 'ň', 346);
			int num2 = int_0 & 0xFF;
			char[] array = (char[])(Array)Class0.Class1.smethod_1(string_0, 164, '\u00b4');
			while (--num >= 0)
			{
				array[num] = (char)(array[num] ^ (byte_0[num2] | int_0));
			}
			return Class12.smethod_1(new string(array), 298, 'ć');
		}
	}

	private static bool bool_0;

	public static string smethod_0(string string_0, int int_0)
	{
		if (Class0.smethod_1(Class0.Class1.smethod_0(914, 'ϴ'), new DateTime(635305918291601562L), 897, 995))
		{
			throw new Exception();
		}
		return Class12.smethod_1(Class5.class5_0.method_0(string_0, int_0), 56, '\u0015');
	}

	[SpecialName]
	public static string smethod_1()
	{
		return Class6.smethod_0(Class10.smethod_0("ބߗߑߟއߟߐߕߕބޅߒߒރߑߖއߖބߕބބއߕނߑߔߗߗߒߕߟ", 58140), 58520);
	}

	static Class4()
	{
		smethod_2();
	}

	internal static void smethod_2()
	{
		if (bool_0)
		{
			return;
		}
		Type typeFromHandle;
		Class12.Class13.Class14.smethod_0((object)(typeFromHandle = typeof(Class4)), '\u02ea', 'ʰ');
		try
		{
			if (!bool_0)
			{
				bool_0 = true;
				Class12.Class15.smethod_1<ResolveEventHandler, AppDomain>(Class12.Class13.Class14.smethod_1('\u0019', 't'), BabelAttribute.smethod_0, 800, '\u036d');
			}
		}
		finally
		{
			Class12.Class13.Class14.smethod_0((object)typeFromHandle, '¼', 'ç');
		}
	}

	internal static Stream smethod_3<T, U>(T gparam_0, U gparam_1, short short_0, short short_1) where T : Assembly where U : string
	{
		int num = 0;
		Stream result;
		do
		{
			result = (((short_0 ^ short_1) - 33) ^ num) switch
			{
				0 => (Stream)(IDisposable)Class16.smethod_1((Assembly)gparam_0, (string)gparam_1, 935, (short)956), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static object smethod_4<T, U>(U gparam_0, T gparam_1, short short_0, int int_0) where T : string where U : ResourceManager
	{
		int num = 0;
		object result = (((int_0 ^ short_0) - 19) ^ 0) switch
		{
			0 => Class12.Class15.smethod_2((ResourceManager)gparam_0, (string)gparam_1, 285, 346), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static Encoding smethod_5(short short_0, int int_0)
	{
		int num = 0;
		Encoding result = (((int_0 ^ short_0) - 77) ^ 0) switch
		{
			0 => Class12.Class13.Class14.smethod_2('ǈ', 418), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static string[] smethod_6<T>(T gparam_0, int int_0, int int_1) where T : Assembly
	{
		int num = 0;
		string[] result = (((int_0 ^ int_1) - 71) ^ 0) switch
		{
			0 => (string[])(ICollection)Class12.smethod_5((Assembly)gparam_0, 'Ƶ', 'Ǆ'), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static byte[] smethod_7<T, U>(T gparam_0, U gparam_1, int int_0, int int_1) where T : Encoding where U : string
	{
		int num = 0;
		byte[] result = (((int_1 ^ int_0) - 101) ^ 0) switch
		{
			0 => Class12.Class13.Class14.smethod_3((Encoding)gparam_0, (string)gparam_1, 'ǀ', 407), 
			_ => null, 
		};
		num++;
		return result;
	}
}
