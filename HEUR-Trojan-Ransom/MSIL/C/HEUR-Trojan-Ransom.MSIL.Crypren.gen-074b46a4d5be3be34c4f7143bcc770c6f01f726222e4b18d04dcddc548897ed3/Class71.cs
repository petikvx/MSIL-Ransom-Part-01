using System;
using System.Reflection;

internal sealed class Class71
{
	static Class71()
	{
		AppDomain.CurrentDomain.AssemblyResolve += smethod_2;
	}

	internal static Type smethod_0(Class56 class56_0)
	{
		object type = Type.GetType(class56_0.String_1);
		if (type == null && 0 == 0)
		{
			while (true)
			{
				switch (Class52.smethod_4(37))
				{
				default:
					continue;
				case 0:
				{
					type = Type.GetType(class56_0.String_0);
					int num = 1;
					goto case 1;
				}
				case 1:
					if (type != null)
					{
						int num = 2;
					}
					else if (0 == 0 && (class56_0.String_0 != Class72.smethod_0("\uf191\uf1e0\uf1c2\uf1c9\uf1d8\uf1c1\uf1c8\uf193", 61869) || 1 == 0))
					{
						throw new InvalidOperationException(string.Format(Class72.smethod_0("\uee2d\uee2e\uee2d\uee2a\uee23\uee6f\uee22\uee77\uee6f\uee34\uee7f\uee32", 61007), class56_0.String_1));
					}
					break;
				case 2:
					break;
				}
				break;
			}
		}
		return (Type)type;
	}

	internal static Type[] smethod_1(Class56[] class56_0)
	{
		Type[] array = new Type[class56_0.Length];
		int num = default(int);
		while (true)
		{
			switch (Class52.smethod_4(38))
			{
			case 1:
			{
				num = 0;
				int num2 = 2;
				goto case 2;
			}
			case 2:
			{
				if (num == 0)
				{
					goto IL_003b;
				}
				int num2 = 0;
				goto case 0;
			}
			case 3:
				num++;
				goto IL_003b;
			case 0:
				{
					array[num] = smethod_0(class56_0[num]);
					int num2 = 3;
					goto case 3;
				}
				IL_003b:
				if (num >= class56_0.Length)
				{
					return array;
				}
				goto case 0;
			}
		}
	}

	private static Assembly smethod_2(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		Assembly assembly = typeof(Class52).Assembly;
		if (resolveEventArgs_0.Name == assembly.FullName || 1 == 0)
		{
			return assembly;
		}
		return null;
	}
}
