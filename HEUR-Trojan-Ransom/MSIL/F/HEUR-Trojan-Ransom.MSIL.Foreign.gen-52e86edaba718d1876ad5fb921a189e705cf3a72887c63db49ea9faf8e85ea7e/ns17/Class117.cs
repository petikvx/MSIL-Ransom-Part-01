using System;
using System.Security.Cryptography;
using System.Text;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns21;
using ns22;
using ns3;

namespace ns17;

internal sealed class Class117 : Class115
{
	internal static Enum54 enum54_0;

	[NonSerialized]
	internal static GetString getString_2;

	public override string PluginName => getString_2(107370718);

	protected override void vmethod_0(byte[] byte_2)
	{
		if (byte_2[^1] == 0)
		{
			byte[] dst = new byte[byte_2.Length - 1];
			Buffer.BlockCopy(byte_2, 0, dst, 0, byte_2.Length - 1);
			base.vmethod_0(dst);
		}
		else
		{
			base.vmethod_0(byte_2);
		}
	}

	protected override byte[] vmethod_4(byte[] byte_2)
	{
		byte_1 = byte_2;
		if (byte_2 == null)
		{
			byte[] array = vmethod_6() as byte[];
			byte[] array2 = new byte[array.Length - 1];
			Array.Copy(array, 1, array2, 0, array.Length - 1);
			return array2;
		}
		if (byte_2[0] == 3)
		{
			enum54_0 = Enum54.const_2;
			return null;
		}
		return method_8();
	}

	protected byte[] method_8()
	{
		if (base.Settings.SslMode != 0)
		{
			enum54_0 = Enum54.const_3;
			byte[] bytes = base.Encoding.GetBytes(base.Settings.Password);
			byte[] array = new byte[bytes.Length + 1];
			Array.Copy(bytes, 0, array, 0, bytes.Length);
			array[bytes.Length] = 0;
			return array;
		}
		if (byte_1 != null && byte_1[0] == 4)
		{
			enum54_0 = Enum54.const_1;
			return new byte[1] { 2 };
		}
		if (!base.Settings.AllowPublicKeyRetrieval)
		{
			throw new MySqlException(Class121.RSAPublicKeyRetrievalNotEnabled);
		}
		enum54_0 = Enum54.const_3;
		byte[] array2 = method_9(base.Settings.Password, byte_0, byte_1);
		if (array2 != null && array2.Length == 1 && array2[0] == 0)
		{
			return null;
		}
		return array2;
	}

	private byte[] method_9(string string_0, byte[] byte_2, byte[] byte_3)
	{
		if (string_0.Length == 0)
		{
			return new byte[1];
		}
		if (byte_1 == null)
		{
			return null;
		}
		byte[] rgb = method_7(Encoding.Default.GetBytes(string_0), byte_2);
		if (base.ServerVersion >= new Version(getString_2(107370628)))
		{
			return (MySqlPemReader.smethod_0(byte_3) ?? throw new MySqlException(Class121.UnableToReadRSAKey)).Encrypt(rgb, fOAEP: true);
		}
		return (MySqlPemReader.smethod_0(byte_3) ?? throw new MySqlException(Class121.UnableToReadRSAKey)).Encrypt(rgb, fOAEP: false);
	}

	public override object vmethod_6()
	{
		enum54_0 = Enum54.const_0;
		if (base.Settings.Password.Length == 0)
		{
			return new byte[1];
		}
		SHA256 sHA = SHA256.Create();
		byte[] array = sHA.ComputeHash(Encoding.Default.GetBytes(base.Settings.Password));
		byte[] array2 = sHA.ComputeHash(array);
		byte[] array3 = new byte[byte_0.Length + array2.Length];
		Array.Copy(array2, 0, array3, 0, array2.Length);
		Array.Copy(byte_0, 0, array3, array2.Length, byte_0.Length);
		byte[] array4 = sHA.ComputeHash(array3);
		byte[] array5 = new byte[array4.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array5[i] = (byte)(array[i] ^ array4[i]);
		}
		byte[] array6 = new byte[array5.Length + 1];
		Array.Copy(array5, 0, array6, 1, array5.Length);
		array6[0] = 32;
		return array6;
	}

	static Class117()
	{
		Strings.CreateGetStringDelegate(typeof(Class117));
	}
}
