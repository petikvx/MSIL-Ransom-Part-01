using System;
using System.Reflection;
using EhdA9I4ntZdCXaNotex;
using HrqeXu48u5BWvM2U05m;
using JAhEyh46uvA1xwWjvIk;
using WGDcIt4rthaVX3IEVJJ;

namespace ATpL2FuEbv0f8NiFwN;

internal class zvFw0omcjX5pctYYen
{
	internal delegate void tjMqnRSwM1JhFJbocj(object o);

	internal static Module nA9JtItZdC;

	private static zvFw0omcjX5pctYYen TaNJNotexj;

	internal static void Ww8JKGIP7A(int int_0)
	{
		int num = 3;
		FieldInfo fieldInfo = default(FieldInfo);
		MethodInfo method = default(MethodInfo);
		int num3 = default(int);
		FieldInfo[] fields = default(FieldInfo[]);
		while (true)
		{
			IL_009e:
			Type type = nA9JtItZdC.ResolveType(33554432 + int_0);
			int num2 = 0;
			if (y0IJ6YuUd9())
			{
				goto IL_000e;
			}
			goto IL_0087;
			IL_0087:
			while (true)
			{
				switch (num2)
				{
				case 2:
					break;
				case 1:
					fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
					num3++;
					goto IL_0046;
				default:
					num3 = 0;
					goto IL_0046;
				case 3:
					goto IL_009e;
					IL_0046:
					if (num3 >= fields.Length)
					{
						return;
					}
					goto IL_004e;
				}
				break;
				IL_004e:
				fieldInfo = fields[num3];
				method = (MethodInfo)ucPJRgbP6S(nA9JtItZdC, fieldInfo.MetadataToken + 100663296);
				num2 = 1;
				if (yYcJ97bqX5() == null)
				{
					continue;
				}
				goto IL_0024;
			}
			goto IL_000e;
			IL_000e:
			fields = type.GetFields();
			num2 = 0;
			if (!y0IJ6YuUd9())
			{
				goto IL_0024;
			}
			goto IL_0087;
			IL_0024:
			num2 = num;
			goto IL_0087;
		}
	}

	public zvFw0omcjX5pctYYen()
	{
		xvSuwU4RhceXCdhSJgI.d012lyPzTwFQy();
		ud9OYc4i7bqX53MRDiY.tvE0cQ1Gob();
		base._002Ector();
	}

	static zvFw0omcjX5pctYYen()
	{
		K1GfMT41V9bS6oPmMyh.cKXl4vhcQo();
		xvSuwU4RhceXCdhSJgI.d012lyPzTwFQy();
		ud9OYc4i7bqX53MRDiY.tvE0cQ1Gob();
		nA9JtItZdC = (Module)OMRJrDiYQh(Type.GetTypeFromHandle(b8EMs849NOuR3KOJSCl.SVK2lyCMuaNuT(33554467)).Assembly);
	}

	internal static object ucPJRgbP6S(object object_0, int int_0)
	{
		return ((Module)object_0).ResolveMethod(int_0);
	}

	internal static bool y0IJ6YuUd9()
	{
		return TaNJNotexj == null;
	}

	internal static zvFw0omcjX5pctYYen yYcJ97bqX5()
	{
		return TaNJNotexj;
	}

	internal static object OMRJrDiYQh(object object_0)
	{
		return ((Assembly)object_0).ManifestModule;
	}
}
