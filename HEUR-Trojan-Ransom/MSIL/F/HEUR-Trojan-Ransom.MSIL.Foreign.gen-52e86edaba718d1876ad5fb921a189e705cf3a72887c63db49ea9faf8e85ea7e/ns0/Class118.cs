using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns22;

namespace ns0;

internal sealed class Class118 : Class112
{
	[NonSerialized]
	internal static GetString getString_1;

	public override string PluginName => getString_1(107370527);

	public byte[] method_5(string string_0, byte[] byte_1)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return new byte[0];
		}
		SHA256 sHA = SHA256.Create();
		byte[] bytes = Encoding.UTF8.GetBytes(string_0);
		byte[] array = sHA.ComputeHash(bytes);
		byte[] array2 = sHA.ComputeHash(array);
		byte[] array3 = new byte[array2.Length + byte_1.Length];
		array2.CopyTo(array3, 0);
		byte_1.CopyTo(array3, array2.Length);
		array3 = sHA.ComputeHash(array3);
		byte[] array4 = method_6(array3, array);
		return Encoding.UTF8.GetBytes(BitConverter.ToString(array4).Replace(getString_1(107410864), getString_1(107399418)));
	}

	protected byte[] method_6(byte[] byte_1, byte[] byte_2)
	{
		if (byte_1.Length != byte_2.Length)
		{
			throw new ArrayTypeMismatchException();
		}
		byte[] array = new byte[byte_1.Length];
		for (int i = 0; i < byte_1.Length; i++)
		{
			array[i] = (byte)(byte_1[i] ^ byte_2[i]);
		}
		return array;
	}

	static Class118()
	{
		Strings.CreateGetStringDelegate(typeof(Class118));
	}
}
