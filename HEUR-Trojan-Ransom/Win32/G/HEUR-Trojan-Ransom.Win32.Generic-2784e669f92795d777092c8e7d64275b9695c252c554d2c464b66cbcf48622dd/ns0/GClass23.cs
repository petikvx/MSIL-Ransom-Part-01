using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace ns0;

public class GClass23
{
	private static object object_0;

	private static object object_1;

	private static object object_2;

	static GClass23()
	{
		while (true)
		{
			object_0 = new RSACryptoServiceProvider();
			smethod_7();
			if (!smethod_6())
			{
				goto IL_0018;
			}
			goto IL_0052;
			IL_0052:
			object_1 = new RSAPKCS1SignatureFormatter((AsymmetricAlgorithm)object_0);
			goto IL_0018;
			IL_0018:
			while (true)
			{
				object_2 = new RSAPKCS1SignatureDeformatter((AsymmetricAlgorithm)object_0);
				if (smethod_6())
				{
					switch (5)
					{
					case 3:
						break;
					default:
						continue;
					case 1:
					case 4:
						goto IL_0052;
					case 5:
						return;
					}
					break;
				}
				return;
			}
		}
	}

	public GClass23()
	{
		smethod_8(this);
		smethod_9(object_0, default(RSAParameters));
	}

	public GClass23(RSAParameters rsaparameters_0)
	{
		smethod_8(this);
		smethod_9(object_0, rsaparameters_0);
	}

	public GClass23(byte[] byte_0)
	{
		smethod_8(this);
		smethod_10(object_0, byte_0);
	}

	[SpecialName]
	public static RSAParameters smethod_0()
	{
		return smethod_11(object_0, bool_0: true);
	}

	[SpecialName]
	public static void smethod_1(RSAParameters rsaparameters_0)
	{
		smethod_9(object_0, rsaparameters_0);
	}

	[SpecialName]
	public static byte[] smethod_2()
	{
		return (byte[])smethod_12(object_0, bool_0: true);
	}

	[SpecialName]
	public static void smethod_3(object object_3)
	{
		smethod_10(object_0, object_3);
	}

	public static bool smethod_4(object object_3, object object_4, object object_5)
	{
		smethod_13(object_2, object_5);
		return smethod_14(object_2, object_3, object_4);
	}

	public static byte[] smethod_5(object object_3, object object_4)
	{
		smethod_15(object_1, object_4);
		return (byte[])smethod_16(object_1, object_3);
	}

	internal static bool smethod_6()
	{
		return true;
	}

	internal static bool smethod_7()
	{
		return false;
	}

	internal static void smethod_8(object object_3)
	{
		object_3._002Ector();
	}

	internal static void smethod_9(object object_3, RSAParameters rsaparameters_0)
	{
		((RSACryptoServiceProvider)object_3).ImportParameters(rsaparameters_0);
	}

	internal static void smethod_10(object object_3, object object_4)
	{
		((RSACryptoServiceProvider)object_3).ImportCspBlob((byte[])object_4);
	}

	internal static RSAParameters smethod_11(object object_3, bool bool_0)
	{
		return ((RSACryptoServiceProvider)object_3).ExportParameters(bool_0);
	}

	internal static object smethod_12(object object_3, bool bool_0)
	{
		return ((RSACryptoServiceProvider)object_3).ExportCspBlob(bool_0);
	}

	internal static void smethod_13(object object_3, object object_4)
	{
		((RSAPKCS1SignatureDeformatter)object_3).SetHashAlgorithm((string)object_4);
	}

	internal static bool smethod_14(object object_3, object object_4, object object_5)
	{
		return ((RSAPKCS1SignatureDeformatter)object_3).VerifySignature((byte[])object_4, (byte[])object_5);
	}

	internal static void smethod_15(object object_3, object object_4)
	{
		((RSAPKCS1SignatureFormatter)object_3).SetHashAlgorithm((string)object_4);
	}

	internal static object smethod_16(object object_3, object object_4)
	{
		return ((RSAPKCS1SignatureFormatter)object_3).CreateSignature((byte[])object_4);
	}
}
