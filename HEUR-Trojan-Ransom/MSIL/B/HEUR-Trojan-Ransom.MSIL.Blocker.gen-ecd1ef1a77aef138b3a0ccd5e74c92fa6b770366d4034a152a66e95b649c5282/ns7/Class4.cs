using System;
using System.Collections.Generic;
using System.Linq;

namespace ns7;

internal static class Class4
{
	private static T smethod_0<T>(this IEnumerable<T> list, Random rand)
	{
		//IL_006d: Ignored invalid 'readonly' prefix
		int num = 0;
		T[] array2 = default(T[]);
		T[] array = default(T[]);
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			object obj;
			if (num == 2)
			{
				obj = list.ToArray();
				goto IL_009e;
			}
			goto IL_00a1;
			IL_0079:
			if (num == 4)
			{
				array2 = array;
				num = 5;
			}
			if (num == 5)
			{
				num2 = 0;
				num = 6;
			}
			if (num != 6)
			{
				if (num == 0)
				{
					num = 1;
				}
				if (num == 13)
				{
					break;
				}
				continue;
			}
			goto IL_0067;
			IL_00a1:
			if (num == 10)
			{
				goto IL_0067;
			}
			goto IL_0092;
			IL_0092:
			if (num == 9)
			{
				num2++;
				num = 10;
			}
			if (num == 11)
			{
				if (num3 <= 0)
				{
					break;
				}
				num = 12;
			}
			if (num == 8)
			{
				num3++;
				num = 9;
			}
			if (num != 12)
			{
				if (num == 1)
				{
					obj = list as T[];
					if (obj != null)
					{
						goto IL_009e;
					}
					num = 2;
				}
				if (num == 3)
				{
					num3 = 0;
					num = 4;
				}
				if (num == 7)
				{
					goto IL_006d;
				}
				goto IL_0079;
			}
			return array.ElementAt(rand.Next(array.Count()));
			IL_009e:
			array = (T[])obj;
			num = 3;
			goto IL_00a1;
			IL_0067:
			if (num2 < array2.Length)
			{
				goto IL_006d;
			}
			num = 11;
			goto IL_0092;
			IL_006d:
			num = 8;
			goto IL_0079;
		}
		return default(T);
	}

	private static IEnumerable<T> smethod_1<T>(this IEnumerable<T> source)
	{
		int num = 0;
		do
		{
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 1);
		return source.smethod_2(new Random());
	}

	private static IEnumerable<T> smethod_2<T>(this IEnumerable<T> source, Random rand)
	{
		int num = 0;
		do
		{
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 1);
		List<T> list = source.ToList();
		list.smethod_4(rand);
		return list;
	}

	private static void smethod_3<T>(this IList<T> list)
	{
		int num = 0;
		do
		{
			if (num == 1)
			{
				list.smethod_4(new Random());
				num = 2;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 2);
	}

	private static void smethod_4<T>(this IList<T> list, Random rand)
	{
		int num = 0;
		int count = default(int);
		int index = default(int);
		T value = default(T);
		while (true)
		{
			if (num == 7)
			{
				goto IL_0019;
			}
			goto IL_0049;
			IL_0049:
			if (num == 3)
			{
				goto IL_001d;
			}
			goto IL_003f;
			IL_003f:
			if (num == 5)
			{
				list[count] = list[index];
				num = 6;
			}
			if (num == 1)
			{
				count = list.Count;
				num = 2;
			}
			if (num != 2)
			{
				if (num == 4)
				{
					value = list[count];
					num = 5;
				}
				if (num == 6)
				{
					list[index] = value;
					num = 7;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 8)
				{
					break;
				}
				continue;
			}
			goto IL_0019;
			IL_0019:
			if (count > 1)
			{
				goto IL_001d;
			}
			num = 8;
			goto IL_0049;
			IL_001d:
			index = rand.Next(count--);
			num = 4;
			goto IL_003f;
		}
	}
}
