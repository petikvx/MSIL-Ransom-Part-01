using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;

namespace ns0;

public class GClass16
{
	private static object object_0 = new SHA384Managed();

	[DebuggerNonUserCode]
	public GClass16()
	{
		smethod_4(this);
	}

	public static byte[] smethod_0(object object_1, long long_0, int int_0)
	{
		_ = 1;
		if (smethod_11())
		{
			int num = 2;
			if (!smethod_10())
			{
				goto IL_006f;
			}
			while (true)
			{
				switch (num)
				{
				default:
					num = 5;
					if (smethod_10())
					{
						continue;
					}
					goto IL_005b;
				case 0:
				case 3:
					break;
				case 1:
				case 2:
					goto IL_005b;
				case 4:
					goto IL_0067;
				case 5:
					goto IL_006f;
				case 6:
					goto IL_0075;
				}
				break;
			}
		}
		BinaryReader object_2 = new BinaryReader(new FileStream((string)object_1, FileMode.Open, FileAccess.Read));
		goto IL_005b;
		IL_0067:
		byte[] object_3 = (byte[])smethod_7(object_2, int_0);
		goto IL_006f;
		IL_006f:
		smethod_8(object_2);
		goto IL_0075;
		IL_0075:
		return (byte[])smethod_9(object_0, object_3);
		IL_005b:
		smethod_6(smethod_5(object_2), long_0);
		goto IL_0067;
	}

	public static byte[] smethod_1(object object_1, long long_0, int int_0)
	{
		smethod_11();
		if (!smethod_10())
		{
			if (!smethod_10())
			{
				goto IL_0049;
			}
			switch (5)
			{
			case 0:
			case 4:
				break;
			case 1:
			case 5:
				goto IL_0049;
			case 3:
				goto IL_0055;
			default:
				goto IL_005d;
			case 6:
				goto IL_0063;
			}
		}
		BinaryReader object_2 = new BinaryReader((Stream)object_1);
		goto IL_0049;
		IL_005d:
		smethod_8(object_2);
		goto IL_0063;
		IL_0063:
		byte[] object_3 = default(byte[]);
		return (byte[])smethod_9(object_0, object_3);
		IL_0055:
		object_3 = (byte[])smethod_7(object_2, int_0);
		goto IL_005d;
		IL_0049:
		smethod_6(smethod_5(object_2), long_0);
		goto IL_0055;
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
