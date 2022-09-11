using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace ns0;

[GAttribute0]
internal static class Class8
{
	private static Random random_0;

	static Class8()
	{
		random_0 = new Random();
	}

	[GAttribute0]
	public static T smethod_0<T>(T gparam_0)
	{
		IList list = gparam_0 as IList;
		if (list == null)
		{
			goto IL_0031;
		}
		goto IL_00b1;
		IL_00b1:
		int num = list.Count;
		int num2 = -386782374;
		goto IL_007d;
		IL_007d:
		while (true)
		{
			int num3 = num2;
			uint num4;
			switch ((num4 = (uint)(~(~num3)) ^ 0x93159282u) % 7u)
			{
			case 5u:
				break;
			case 2u:
				goto end_IL_007d;
			case 1u:
				num2 = (int)((num4 * 1376123831) ^ 0x238827CA);
				continue;
			case 0u:
			{
				num--;
				int index = random_0.Next(num + 1);
				object value = list[index];
				list[index] = list[num];
				list[num] = value;
				num2 = -1264810334;
				continue;
			}
			case 4u:
				goto IL_00b1;
			case 3u:
				throw new NotSupportedException();
			default:
				return (T)list;
			}
			int num5;
			if (num > 1)
			{
				num2 = -1236508406;
				num5 = -1236508406;
			}
			else
			{
				num2 = -240395978;
				num5 = -240395978;
			}
			continue;
			end_IL_007d:
			break;
		}
		goto IL_0031;
		IL_0031:
		num2 = -1177490446;
		goto IL_007d;
	}

	[GAttribute0]
	public static int[] smethod_1(int int_0)
	{
		int[] array = new int[int_0];
		int num = 0;
		while (true)
		{
			int num2;
			int num3;
			if (num < int_0)
			{
				num2 = -1588505367;
				num3 = -1588505367;
			}
			else
			{
				num2 = -1050050414;
				num3 = -1050050414;
			}
			while (true)
			{
				int num4 = num2;
				switch ((uint)(~(~(~num4))) % 4u)
				{
				case 2u:
					array[num] = num;
					num++;
					num2 = -1742801880;
					continue;
				case 0u:
					num2 = -1588505367;
					continue;
				case 3u:
					break;
				default:
					return array;
				}
				break;
			}
		}
	}

	[GAttribute0]
	public static int smethod_2(int[] int_0)
	{
		if (int_0.Length != 2)
		{
			throw new InvalidFilterCriteriaException();
		}
		return random_0.Next(int_0[0], int_0[1]);
	}

	[GAttribute0]
	public static List<T> smethod_3<T>(ResourceManager resourceManager_0, CultureInfo cultureInfo_0)
	{
		List<T> list = new List<T>();
		IDictionaryEnumerator enumerator = resourceManager_0.GetResourceSet(cultureInfo_0, createIfNotExists: true, tryParents: true)!.GetEnumerator();
		try
		{
			DictionaryEntry dictionaryEntry = default(DictionaryEntry);
			while (true)
			{
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -1234520100;
					num2 = -1234520100;
				}
				else
				{
					num = -801620987;
					num2 = -801620987;
				}
				while (true)
				{
					int num3 = num;
					uint num4;
					switch ((num4 = (uint)(-(num3 * -806126553) - -1633734561)) % 6u)
					{
					case 5u:
						list.Add((T)dictionaryEntry.Value);
						num = ((int)num4 * -1927326251) ^ -2004538880;
						continue;
					case 3u:
					{
						int num6;
						int num7;
						if ((object)dictionaryEntry.Value!.GetType() == typeof(T))
						{
							num6 = 43815498;
							num7 = 43815498;
						}
						else
						{
							num6 = 451234103;
							num7 = 451234103;
						}
						num = num6 ^ (int)(num4 * 1533521088);
						continue;
					}
					case 1u:
					{
						dictionaryEntry = (DictionaryEntry)enumerator.Current;
						int num5;
						if (dictionaryEntry.Value == null)
						{
							num = 1685815287;
							num5 = 1685815287;
						}
						else
						{
							num = 1094960984;
							num5 = 1094960984;
						}
						continue;
					}
					case 0u:
						num = -1234520100;
						continue;
					case 4u:
						break;
					default:
						return list;
					case 2u:
						return list;
					}
					break;
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable disposable)
			{
				while (true)
				{
					IL_0156:
					int num8 = 1901338439;
					while (true)
					{
						int num3 = num8;
						uint num4;
						switch ((num4 = (uint)(-(num3 * -806126553) - -1633734561)) % 3u)
						{
						case 1u:
							goto IL_0119;
						default:
							goto end_IL_012d;
						case 0u:
							break;
						case 2u:
							goto end_IL_012d;
						}
						goto IL_0156;
						IL_0119:
						disposable.Dispose();
						num8 = (int)((num4 * 1584634609) ^ 0x4815FC0A);
						continue;
						end_IL_012d:
						break;
					}
					break;
				}
			}
		}
	}

	[GAttribute0]
	public static Assembly smethod_4(object object_0)
	{
		if (!(object_0 is byte[] rawAssembly))
		{
			throw new FormatException();
		}
		return Assembly.Load(rawAssembly);
	}
}
