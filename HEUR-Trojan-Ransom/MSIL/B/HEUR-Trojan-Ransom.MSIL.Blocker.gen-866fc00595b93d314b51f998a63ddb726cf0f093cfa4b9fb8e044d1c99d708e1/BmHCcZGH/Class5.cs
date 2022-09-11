using System;
using System.Collections.Generic;

namespace BmHCcZGH;

internal sealed class Class5
{
	private delegate void Delegate0(Class6 class6_0);

	private static object object_0 = new object();

	private static readonly List<WeakReference> list_0 = new List<WeakReference>();

	private static int int_0 = 0;

	private const int JNsHDfhXbJhmMNWVZsZJWwlE7jEQrPuWJ99SKKM1eEeRmdOKiIJO9g2wmHofGEoolmdFnDyYDmFdRkvjMWUVHk8izZymqgYs5435Pvx4cPVIyYcl = 100;

	internal static void smethod_0(Class6 class6_0)
	{
		lock (object_0)
		{
			int count = list_0.Count;
			int i = 0;
			int num = 0;
			if (int_0 > 100)
			{
				for (; i < count; i++)
				{
					if (list_0[num].IsAlive)
					{
						num++;
					}
					else
					{
						list_0.RemoveAt(num);
					}
				}
				int_0 = 0;
			}
			list_0.Add(new WeakReference(class6_0));
			int_0++;
		}
	}

	internal static byte[] smethod_1()
	{
		return new byte[24]
		{
			86, 127, 143, 5, 131, 128, 147, 7, 46, 96,
			19, 47, 37, 33, 24, 22, 89, 11, 97, 40,
			142, 167, 140, 118
		};
	}
}
