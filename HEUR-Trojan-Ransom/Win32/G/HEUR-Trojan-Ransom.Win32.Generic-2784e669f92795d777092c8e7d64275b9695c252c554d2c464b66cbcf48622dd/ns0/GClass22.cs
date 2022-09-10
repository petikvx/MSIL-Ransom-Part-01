using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace ns0;

public class GClass22
{
	private static object object_0 = new RSACryptoServiceProvider();

	public GClass22()
	{
		smethod_8(this);
		smethod_9(object_0, default(RSAParameters));
	}

	public GClass22(RSAParameters rsaparameters_0)
	{
		smethod_8(this);
		smethod_9(object_0, rsaparameters_0);
	}

	public GClass22(byte[] byte_0)
	{
		smethod_8(this);
		smethod_12(object_0, byte_0);
	}

	[SpecialName]
	public static RSAParameters smethod_0()
	{
		return smethod_13(object_0, bool_0: true);
	}

	[SpecialName]
	public static void smethod_1(RSAParameters rsaparameters_0)
	{
		smethod_9(object_0, rsaparameters_0);
	}

	[SpecialName]
	public static byte[] smethod_2()
	{
		return (byte[])smethod_14(object_0, bool_0: true);
	}

	[SpecialName]
	public static void smethod_3(object object_1)
	{
		smethod_12(object_0, object_1);
	}

	public static byte[] smethod_4(object object_1, bool bool_0)
	{
		return (byte[])smethod_15(object_0, object_1, bool_0);
	}

	public static byte[] smethod_5(object object_1)
	{
		return (byte[])smethod_16(object_0, object_1);
	}

	public static byte[] smethod_6(object object_1, bool bool_0)
	{
		return (byte[])smethod_17(object_0, object_1, bool_0);
	}

	public static byte[] smethod_7(object object_1)
	{
		return (byte[])smethod_18(object_0, object_1);
	}

	internal static void smethod_8(object object_1)
	{
		object_1._002Ector();
	}

	internal static void smethod_9(object object_1, RSAParameters rsaparameters_0)
	{
		((RSACryptoServiceProvider)object_1).ImportParameters(rsaparameters_0);
	}

	internal static bool smethod_10()
	{
		return true;
	}

	internal static bool smethod_11()
	{
		return false;
	}

	internal static void smethod_12(object object_1, object object_2)
	{
		((RSACryptoServiceProvider)object_1).ImportCspBlob((byte[])object_2);
	}

	internal static RSAParameters smethod_13(object object_1, bool bool_0)
	{
		return ((RSACryptoServiceProvider)object_1).ExportParameters(bool_0);
	}

	internal static object smethod_14(object object_1, bool bool_0)
	{
		return ((RSACryptoServiceProvider)object_1).ExportCspBlob(bool_0);
	}

	internal static object smethod_15(object object_1, object object_2, bool bool_0)
	{
		return ((RSACryptoServiceProvider)object_1).Encrypt((byte[])object_2, bool_0);
	}

	internal static object smethod_16(object object_1, object object_2)
	{
		return ((RSACryptoServiceProvider)object_1).EncryptValue((byte[])object_2);
	}

	internal static object smethod_17(object object_1, object object_2, bool bool_0)
	{
		return ((RSACryptoServiceProvider)object_1).Decrypt((byte[])object_2, bool_0);
	}

	internal static object smethod_18(object object_1, object object_2)
	{
		return ((RSACryptoServiceProvider)object_1).DecryptValue((byte[])object_2);
	}
}
