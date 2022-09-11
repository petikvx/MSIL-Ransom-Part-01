using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns22;

internal class Class113 : Class112
{
	[NonSerialized]
	internal static GetString getString_1;

	public override string PluginName => getString_1(107408062);

	protected override void vmethod_0(byte[] byte_1)
	{
		if (byte_1[^1] == 0)
		{
			byte[] array = new byte[byte_1.Length - 1];
			Buffer.BlockCopy(byte_1, 0, array, 0, byte_1.Length - 1);
			base.vmethod_0(array);
		}
		else
		{
			base.vmethod_0(byte_1);
		}
	}

	protected override byte[] vmethod_4(byte[] byte_1)
	{
		byte[] array = (vmethod_6() ?? new byte[1]) as byte[];
		byte[] array2 = new byte[array.Length - 1];
		Array.Copy(array, 1, array2, 0, array.Length - 1);
		return array2;
	}

	public override object vmethod_6()
	{
		byte[] array = method_5(base.Settings.Password, byte_0);
		if (array != null && array.Length == 1 && array[0] == 0)
		{
			return null;
		}
		return array;
	}

	protected byte[] method_5(string string_0, byte[] byte_1)
	{
		if (string_0.Length == 0)
		{
			return new byte[1];
		}
		SHA1 sHA = SHA1.Create();
		byte[] array = null;
		try
		{
			array = sHA.ComputeHash(base.Encoding.GetBytes(string_0));
		}
		catch (NullReferenceException)
		{
			array = sHA.ComputeHash(Encoding.Default.GetBytes(string_0));
		}
		byte[] array2 = sHA.ComputeHash(array);
		byte[] array3 = new byte[byte_1.Length + array2.Length];
		Array.Copy(byte_1, 0, array3, 0, byte_1.Length);
		Array.Copy(array2, 0, array3, byte_1.Length, array2.Length);
		byte[] array4 = sHA.ComputeHash(array3);
		byte[] array5 = new byte[array4.Length + 1];
		array5[0] = 20;
		Array.Copy(array4, 0, array5, 1, array4.Length);
		for (int i = 1; i < array5.Length; i++)
		{
			array5[i] = (byte)(array5[i] ^ array[i - 1]);
		}
		return array5;
	}

	static Class113()
	{
		Strings.CreateGetStringDelegate(typeof(Class113));
	}
}
