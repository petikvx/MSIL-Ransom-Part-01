using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;

[GAttribute0]
internal static class Class7
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
			int num = -873361786;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(num2 * 1183784017 * -1361595357) * 1087888685)) % 6u)
				{
				case 5u:
				{
					int num4;
					if (count-- <= 1)
					{
						num = -2005087143;
						num4 = -2005087143;
					}
					else
					{
						num = 1342311682;
						num4 = 1342311682;
					}
					continue;
				}
				case 4u:
					index = random_0.Next(count + 1);
					value = gparam_0[index];
					num = -484787509;
					continue;
				case 2u:
					num = (int)(num3 * 1096934786) ^ -317233379;
					continue;
				case 1u:
					gparam_0[index] = gparam_0[count];
					gparam_0[count] = value;
					num = (int)((num3 * 1874169381) ^ 0x266FB69E);
					continue;
				case 0u:
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
		return new Class8<T>(-2)
		{
			resourceManager_1 = resourceManager_0,
			cultureInfo_1 = cultureInfo_0
		};
	}

	[GAttribute0]
	public static Assembly smethod_2(object object_0)
	{
		if (!(object_0 is byte[] rawAssembly))
		{
			throw new BadImageFormatException();
		}
		return Assembly.Load(rawAssembly);
	}

	[GAttribute0]
	public static uint smethod_3(Stream stream_0, int int_0)
	{
		stream_0.Seek(int_0, SeekOrigin.Begin);
		byte[] array = new byte[4];
		stream_0.Read(array, 0, array.Length);
		return 0u | array[0] | (uint)(array[1] << 8) | (uint)(array[2] << 16) | (uint)(array[3] << 24);
	}
}
