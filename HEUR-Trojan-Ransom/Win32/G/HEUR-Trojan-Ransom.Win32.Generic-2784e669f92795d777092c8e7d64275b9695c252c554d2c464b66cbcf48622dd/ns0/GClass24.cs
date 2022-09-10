using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

public class GClass24
{
	private static object object_0 = new RSACryptoServiceProvider();

	public GClass24()
	{
		smethod_10(this);
		smethod_11(object_0, default(RSAParameters));
	}

	public GClass24(RSAParameters rsaparameters_0)
	{
		smethod_10(this);
		smethod_11(object_0, rsaparameters_0);
	}

	public GClass24(byte[] byte_0)
	{
		smethod_10(this);
		smethod_14(object_0, byte_0);
	}

	[SpecialName]
	public static RSAParameters smethod_0()
	{
		return smethod_15(object_0, bool_0: true);
	}

	[SpecialName]
	public static void smethod_1(RSAParameters rsaparameters_0)
	{
		smethod_11(object_0, rsaparameters_0);
	}

	[SpecialName]
	public static byte[] smethod_2()
	{
		return (byte[])smethod_16(object_0, bool_0: true);
	}

	[SpecialName]
	public static void smethod_3(object object_1)
	{
		smethod_14(object_0, object_1);
	}

	public static bool smethod_4(object object_1, object object_2, object object_3)
	{
		return smethod_17(object_0, object_1, object_2, object_3);
	}

	public static byte[] smethod_5(object object_1, object object_2)
	{
		return (byte[])smethod_20(object_1, smethod_18(0), ((Array)object_1).Length, smethod_19(object_2));
	}

	public static byte[] smethod_6(object object_1, object object_2, long long_0)
	{
		return (byte[])smethod_20(object_1, smethod_21(long_0), ((Array)object_1).Length, smethod_19(object_2));
	}

	public static byte[] smethod_7(object object_1, object object_2, long long_0, int int_0)
	{
		return (byte[])smethod_22(object_0, object_1, checked((int)long_0), int_0, object_2);
	}

	public static bool smethod_8(object object_1, object object_2, object object_3)
	{
		return smethod_23(object_0, object_1, object_2, object_3);
	}

	public static byte[] smethod_9(object object_1, object object_2)
	{
		return (byte[])smethod_24(object_0, object_1, object_2);
	}

	internal static void smethod_10(object object_1)
	{
		object_1._002Ector();
	}

	internal static void smethod_11(object object_1, RSAParameters rsaparameters_0)
	{
		((RSACryptoServiceProvider)object_1).ImportParameters(rsaparameters_0);
	}

	internal static bool smethod_12()
	{
		return true;
	}

	internal static bool smethod_13()
	{
		return false;
	}

	internal static void smethod_14(object object_1, object object_2)
	{
		((RSACryptoServiceProvider)object_1).ImportCspBlob((byte[])object_2);
	}

	internal static RSAParameters smethod_15(object object_1, bool bool_0)
	{
		return ((RSACryptoServiceProvider)object_1).ExportParameters(bool_0);
	}

	internal static object smethod_16(object object_1, bool bool_0)
	{
		return ((RSACryptoServiceProvider)object_1).ExportCspBlob(bool_0);
	}

	internal static bool smethod_17(object object_1, object object_2, object object_3, object object_4)
	{
		return ((RSACryptoServiceProvider)object_1).VerifyData((byte[])object_2, object_3, (byte[])object_4);
	}

	internal static object smethod_18(int int_0)
	{
		return Conversions.ToString(int_0);
	}

	internal static int smethod_19(object object_1)
	{
		return Conversions.ToInteger((string)object_1);
	}

	internal static object smethod_20(object object_1, object object_2, long long_0, int int_0)
	{
		return smethod_7(object_1, object_2, long_0, int_0);
	}

	internal static object smethod_21(long long_0)
	{
		return Conversions.ToString(long_0);
	}

	internal static object smethod_22(object object_1, object object_2, int int_0, int int_1, object object_3)
	{
		return ((RSACryptoServiceProvider)object_1).SignData((byte[])object_2, int_0, int_1, object_3);
	}

	internal static bool smethod_23(object object_1, object object_2, object object_3, object object_4)
	{
		return ((RSACryptoServiceProvider)object_1).VerifyHash((byte[])object_2, (string)object_3, (byte[])object_4);
	}

	internal static object smethod_24(object object_1, object object_2, object object_3)
	{
		return ((RSACryptoServiceProvider)object_1).SignHash((byte[])object_2, (string)object_3);
	}
}
