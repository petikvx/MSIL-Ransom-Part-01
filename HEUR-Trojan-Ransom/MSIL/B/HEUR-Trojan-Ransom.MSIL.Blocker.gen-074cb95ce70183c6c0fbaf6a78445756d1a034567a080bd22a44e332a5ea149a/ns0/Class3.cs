using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

namespace ns0;

internal sealed class Class3
{
	private sealed class Class4
	{
		public static readonly Class4 class4_0;

		internal byte[] byte_0;

		static Class4()
		{
			Class7.smethod_2();
			if (Class5.smethod_3(BabelAttribute.Class0.Class1.smethod_1('ś', 274), new DateTime(635306814125964667L), 580, 'Ƚ'))
			{
				throw new Exception();
			}
			class4_0 = new Class4();
		}

		private Class4()
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected O, but got Unknown
			Assembly gparam_ = (Assembly)(IEvidenceFactory)Class5.smethod_2(551, 533);
			Stream stream = (Stream)(MarshalByRefObject)Class5.smethod_4(gparam_, smethod_1(), '\u02c4', 688);
			if (stream != null)
			{
				byte[] array = (byte_0 = new byte[256]);
				Class9.Class10.smethod_0(stream, byte_0, 0, byte_0.Length, '\u0365', '\u0320');
			}
		}

		public string method_0(string string_0, int int_0)
		{
			int num = BabelAttribute.Class0.smethod_2(string_0, 525, 'ȏ');
			int num2 = int_0 & 0xFF;
			char[] array = (char[])(ICloneable)BabelAttribute.smethod_2(string_0, 210, 'Ò');
			while (--num >= 0)
			{
				array[num] = (char)(array[num] ^ (byte_0[num2] | int_0));
			}
			return Class14.smethod_0(new string(array), 771, 801);
		}
	}

	public static string smethod_0(string string_0, int int_0)
	{
		if (Class5.smethod_3(BabelAttribute.Class0.Class1.smethod_1('\u0091', 216), new DateTime(635306814126244852L), 114, '\v'))
		{
			throw new Exception();
		}
		return Class14.smethod_0(Class4.class4_0.method_0(string_0, int_0), 792, 826);
	}

	[SpecialName]
	public static string smethod_1()
	{
		return Class5.smethod_0(Class7.smethod_0("ᣃᢕᣈᣈᣁᢒᢔᣄᣄᣉᣂᣉᣅᣁᢓᣃᢐᢕᢕᣄᢕᢗᣀᣁᢔᣃᣉᣀᣂᢐᢕᣁ", 61981), 59980);
	}
}
