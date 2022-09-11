using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;

[GAttribute0]
internal static class Class8
{
	private static Random random_0 = new Random();

	[GAttribute0]
	public static T smethod_0<T>(T gparam_0) where T : IList
	{
		int count = gparam_0.Count;
		int index = default(int);
		object value = default(object);
		while (true)
		{
			int num = -2124905255;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(-((~num2 * -1191155581) ^ -1287831604) * 161373957))) % 7u)
				{
				case 5u:
					index = random_0.Next(count + 1);
					value = gparam_0[index];
					num = 997648714;
					continue;
				case 4u:
				{
					int num4;
					if (count-- > 1)
					{
						num = 1566624143;
						num4 = 1566624143;
					}
					else
					{
						num = -474971031;
						num4 = -474971031;
					}
					continue;
				}
				case 3u:
					num = (int)(num3 * 1275091279) ^ -240805693;
					continue;
				case 1u:
					gparam_0[index] = gparam_0[count];
					num = ((int)num3 * -33640924) ^ 0x6BD9C034;
					continue;
				case 0u:
					gparam_0[count] = value;
					num = (int)((num3 * 224492733) ^ 0x5CE73450);
					continue;
				case 2u:
					break;
				default:
					return gparam_0;
				}
				break;
			}
		}
	}

	[GAttribute0]
	public static IEnumerable<T> smethod_1<T>(ResourceManager resourceManager_0, CultureInfo cultureInfo_0)
	{
		//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
		return new Class9<T>(-2)
		{
			resourceManager_1 = resourceManager_0,
			cultureInfo_1 = cultureInfo_0
		};
	}

	[GAttribute0]
	public static Assembly smethod_2(object object_0)
	{
		byte[] array = object_0 as byte[];
		while (true)
		{
			int num = 1352131182;
			while (true)
			{
				int num2 = num;
				uint num3;
				int num4;
				switch ((num3 = (uint)(-(-1853293619 - (num2 - 366921466)) - 928482977)) % 4u)
				{
				case 2u:
				{
					int num5;
					if (array != null)
					{
						num4 = 1069088757;
						num5 = 1069088757;
					}
					else
					{
						num4 = -919721712;
						num5 = -919721712;
					}
					goto IL_0022;
				}
				case 3u:
					break;
				default:
					throw new BadImageFormatException();
				case 1u:
					return Assembly.Load(array);
				}
				break;
				IL_0022:
				num = num4 ^ ((int)num3 * -54565204);
			}
		}
	}

	[GAttribute0]
	public static uint smethod_3(Stream stream_0, int int_0)
	{
		stream_0.Seek(int_0, SeekOrigin.Begin);
		byte[] array = new byte[4];
		while (true)
		{
			int num = -417331199;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(~num2 ^ -1234106496))) % 3u)
				{
				case 1u:
					goto IL_0013;
				case 0u:
					break;
				default:
					return 0u | array[0] | (uint)(array[1] << 8) | (uint)(array[2] << 16) | (uint)(array[3] << 24);
				}
				break;
				IL_0013:
				stream_0.Read(array, 0, array.Length);
				num = ((int)num3 * -329969440) ^ -1769326089;
			}
		}
	}
}
