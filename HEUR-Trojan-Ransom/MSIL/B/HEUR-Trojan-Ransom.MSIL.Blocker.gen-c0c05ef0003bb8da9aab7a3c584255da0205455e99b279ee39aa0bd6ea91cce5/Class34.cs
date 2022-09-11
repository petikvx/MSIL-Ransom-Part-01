using System;
using System.Reflection;

internal sealed class Class34
{
	static Class34()
	{
		AppDomain.CurrentDomain.AssemblyResolve += smethod_2;
	}

	internal static Type smethod_0(Class19 class19_0)
	{
		object type = Type.GetType(class19_0.String_1);
		if (type == null && 0 == 0)
		{
			type = Type.GetType(class19_0.String_0);
			if (type == null && 0 == 0 && (class19_0.String_0 != Class35.smethod_0("\ue0a3\ue0d2\ue0f0\ue0fb\ue0ea\ue0f3\ue0fa\ue0a1", 57503) || 1 == 0))
			{
				throw new InvalidOperationException(string.Format(Class35.smethod_0("\uf8a4\uf8a7\uf8a4\uf8a3\uf8aa\uf8e6\uf8ab\uf8fe\uf8e6\uf8bd\uf8f6\uf8bb", 63686), class19_0.String_1));
			}
		}
		return (Type)type;
	}

	internal static Type[] smethod_1(Class19[] class19_0)
	{
		Type[] array = new Type[class19_0.Length];
		int num2 = default(int);
		while (true)
		{
			int num = Class41.smethod_0(92);
			while (true)
			{
				switch (num)
				{
				case 1:
					if (num2 != 0)
					{
						goto IL_000e;
					}
					goto IL_003e;
				case 0:
					num2 = 0;
					num = 1;
					goto case 1;
				case 2:
					array[num2] = smethod_0(class19_0[num2]);
					num = 3;
					goto case 3;
				case 3:
					{
						num2++;
						goto IL_003e;
					}
					IL_003e:
					if (num2 >= class19_0.Length)
					{
						return array;
					}
					goto case 2;
				}
				break;
				IL_000e:
				num = Class41.smethod_0(82);
			}
		}
	}

	private static Assembly smethod_2(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		Assembly assembly = typeof(Class15).Assembly;
		if (resolveEventArgs_0.Name == assembly.FullName || 1 == 0)
		{
			return assembly;
		}
		return null;
	}
}
