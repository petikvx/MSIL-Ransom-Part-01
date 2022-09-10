using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;

namespace ns0;

public class GClass18
{
	private static object object_0 = new SHA512Managed();

	[DebuggerNonUserCode]
	public GClass18()
	{
		smethod_4(this);
	}

	public static byte[] smethod_0(object object_1, long long_0, int int_0)
	{
		smethod_11();
		if (smethod_10())
		{
			goto IL_0051;
		}
		goto IL_005f;
		IL_005f:
		BinaryReader object_2 = default(BinaryReader);
		while (true)
		{
			IL_005f_2:
			smethod_6(smethod_5(object_2), long_0);
			while (true)
			{
				byte[] object_3 = (byte[])smethod_7(object_2, int_0);
				while (true)
				{
					smethod_8(object_2);
					if (smethod_11())
					{
					}
					switch (6)
					{
					case 3:
						goto end_IL_0012;
					case 0:
					case 4:
						goto end_IL_0047;
					case 1:
					case 5:
						goto IL_005f_2;
					case 6:
						return (byte[])smethod_9(object_0, object_3);
					}
					continue;
					end_IL_0012:
					break;
				}
				continue;
				end_IL_0047:
				break;
			}
			break;
		}
		goto IL_0051;
		IL_0051:
		object_2 = new BinaryReader(new FileStream((string)object_1, FileMode.Open, FileAccess.Read));
		goto IL_005f;
	}

	public static byte[] smethod_1(object object_1, long long_0, int int_0)
	{
		byte[] object_3 = default(byte[]);
		while (true)
		{
			BinaryReader object_2 = new BinaryReader((Stream)object_1);
			while (true)
			{
				smethod_6(smethod_5(object_2), long_0);
				smethod_11();
				if (smethod_10())
				{
					if (smethod_11())
					{
						break;
					}
					switch (0)
					{
					case 4:
						break;
					case 1:
						goto end_IL_0003;
					case 0:
					case 2:
						object_3 = (byte[])smethod_7(object_2, int_0);
						goto IL_0060;
					default:
						goto IL_0060;
					case 6:
						goto IL_0066;
					}
					continue;
				}
				goto IL_0060;
				IL_0060:
				smethod_8(object_2);
				goto IL_0066;
				IL_0066:
				return (byte[])smethod_9(object_0, object_3);
				continue;
				end_IL_0003:
				break;
			}
		}
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
