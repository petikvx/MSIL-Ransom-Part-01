using System;
using System.Reflection;

namespace LqHyLjKQHwjIbZdxED;

internal class NRA9SKPMMWDT1GkAnq
{
	internal delegate void zXoEPr3SvoyxFVymos(object o);

	internal static Module o8dvc21W4P;

	private static NRA9SKPMMWDT1GkAnq JawObArz5qGmZX8M8Dg;

	internal static void RjOZpdWWUi7M6(int typemdt)
	{
		Type type = o8dvc21W4P.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		int num3 = default(int);
		FieldInfo fieldInfo = default(FieldInfo);
		MethodInfo method = default(MethodInfo);
		for (int num = 0; num < fields.Length; num++)
		{
			int num2 = 1;
			if (qU2iwSYgRp8UHNBcWlJ() != null)
			{
				goto IL_0062;
			}
			goto IL_0066;
			IL_0062:
			num2 = num3;
			goto IL_0066;
			IL_0066:
			while (true)
			{
				switch (num2)
				{
				case 1:
					break;
				default:
					goto end_IL_0066;
				}
				fieldInfo = fields[num];
				method = (MethodInfo)o8dvc21W4P.ResolveMethod(fieldInfo.MetadataToken + 100663296);
				num2 = 0;
				if (qU2iwSYgRp8UHNBcWlJ() == null)
				{
					continue;
				}
				goto IL_0062;
				continue;
				end_IL_0066:
				break;
			}
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public NRA9SKPMMWDT1GkAnq()
	{
		R8TayKhW8eikpukIpe.piUZpdWzJZMua();
		base._002Ector();
	}

	static NRA9SKPMMWDT1GkAnq()
	{
		R8TayKhW8eikpukIpe.piUZpdWzJZMua();
		o8dvc21W4P = typeof(NRA9SKPMMWDT1GkAnq).Assembly.ManifestModule;
	}

	internal static bool ILaLYpYfXU6IiVh9qXt()
	{
		return JawObArz5qGmZX8M8Dg == null;
	}

	internal static NRA9SKPMMWDT1GkAnq qU2iwSYgRp8UHNBcWlJ()
	{
		return JawObArz5qGmZX8M8Dg;
	}
}
