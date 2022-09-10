using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;

namespace ns0;

public class GClass15
{
	private static object object_0 = new SHA384CryptoServiceProvider();

	[DebuggerNonUserCode]
	public GClass15()
	{
		smethod_4(this);
	}

	public static byte[] smethod_0(object object_1, long long_0, int int_0)
	{
		smethod_10();
		if (smethod_11())
		{
			if (!smethod_10())
			{
				goto IL_0064;
			}
			switch (2)
			{
			case 0:
			case 4:
				break;
			case 1:
			case 2:
				goto IL_0050;
			case 3:
				goto IL_005c;
			default:
				goto IL_0064;
			case 6:
				goto IL_006a;
			}
		}
		BinaryReader object_2 = new BinaryReader(new FileStream((string)object_1, FileMode.Open, FileAccess.Read));
		goto IL_0050;
		IL_0064:
		smethod_8(object_2);
		goto IL_006a;
		IL_006a:
		byte[] object_3 = default(byte[]);
		return (byte[])smethod_9(object_0, object_3);
		IL_005c:
		object_3 = (byte[])smethod_7(object_2, int_0);
		goto IL_0064;
		IL_0050:
		smethod_6(smethod_5(object_2), long_0);
		goto IL_005c;
	}

	public static byte[] smethod_1(object object_1, long long_0, int int_0)
	{
		_ = 0;
		BinaryReader object_2 = default(BinaryReader);
		byte[] object_3 = default(byte[]);
		if (smethod_10())
		{
			object_2 = new BinaryReader((Stream)object_1);
			smethod_6(smethod_5(object_2), long_0);
			object_3 = (byte[])smethod_7(object_2, int_0);
		}
		smethod_8(object_2);
		return (byte[])smethod_9(object_0, object_3);
	}

	public static byte[] smethod_2(object object_1, long long_0, int int_0)
	{
		return (byte[])smethod_12(object_0, object_1, checked((int)long_0), int_0);
	}

	public static byte[] smethod_3(object object_1)
	{
		return (byte[])smethod_9(object_0, object_1);
	}

	internal static void smethod_4(object object_1)
	{
		object_1._002Ector();
	}

	internal static object smethod_5(object object_1)
	{
		return ((BinaryReader)object_1).BaseStream;
	}

	internal static void smethod_6(object object_1, long long_0)
	{
		((Stream)object_1).Position = long_0;
	}

	internal static object smethod_7(object object_1, int int_0)
	{
		return ((BinaryReader)object_1).ReadBytes(int_0);
	}

	internal static void smethod_8(object object_1)
	{
		((BinaryReader)object_1).Close();
	}

	internal static object smethod_9(object object_1, object object_2)
	{
		return ((HashAlgorithm)object_1).ComputeHash((byte[])object_2);
	}

	internal static bool smethod_10()
	{
		return true;
	}

	internal static bool smethod_11()
	{
		return false;
	}

	internal static object smethod_12(object object_1, object object_2, int int_0, int int_1)
	{
		return ((HashAlgorithm)object_1).ComputeHash((byte[])object_2, int_0, int_1);
	}
}
