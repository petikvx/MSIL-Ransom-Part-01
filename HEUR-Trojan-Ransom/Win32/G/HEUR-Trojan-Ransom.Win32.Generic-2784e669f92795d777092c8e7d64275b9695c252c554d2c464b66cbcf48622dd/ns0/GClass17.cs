using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;

namespace ns0;

public class GClass17
{
	private static object object_0 = new SHA512CryptoServiceProvider();

	[DebuggerNonUserCode]
	public GClass17()
	{
		smethod_4(this);
	}

	public static byte[] smethod_0(object object_1, long long_0, int int_0)
	{
		_ = 1;
		if (smethod_11())
		{
			if (!smethod_10())
			{
				goto IL_0060;
			}
			switch (2)
			{
			case 0:
			case 5:
				break;
			case 1:
				goto IL_004c;
			case 4:
				goto IL_0058;
			default:
				goto IL_0060;
			case 6:
				goto IL_0066;
			}
		}
		BinaryReader object_2 = new BinaryReader(new FileStream((string)object_1, FileMode.Open, FileAccess.Read));
		goto IL_004c;
		IL_0060:
		smethod_8(object_2);
		goto IL_0066;
		IL_0066:
		byte[] object_3 = default(byte[]);
		return (byte[])smethod_9(object_0, object_3);
		IL_0058:
		object_3 = (byte[])smethod_7(object_2, int_0);
		goto IL_0060;
		IL_004c:
		smethod_6(smethod_5(object_2), long_0);
		goto IL_0058;
	}

	public static byte[] smethod_1(object object_1, long long_0, int int_0)
	{
		_ = 0;
		if (!smethod_10())
		{
			goto IL_000c;
		}
		goto IL_0041;
		IL_000c:
		BinaryReader object_2 = default(BinaryReader);
		byte[] object_3 = default(byte[]);
		while (true)
		{
			smethod_8(object_2);
			if (smethod_10())
			{
				switch (6)
				{
				case 0:
				case 2:
					goto IL_0041;
				case 5:
					goto end_IL_000c;
				case 4:
					goto IL_0054;
				case 6:
					return (byte[])smethod_9(object_0, object_3);
				}
				continue;
			}
			break;
			continue;
			end_IL_000c:
			break;
		}
		goto IL_0048;
		IL_0048:
		smethod_6(smethod_5(object_2), long_0);
		goto IL_0054;
		IL_0054:
		object_3 = (byte[])smethod_7(object_2, int_0);
		goto IL_000c;
		IL_0041:
		object_2 = new BinaryReader((Stream)object_1);
		goto IL_0048;
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
