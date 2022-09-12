using System;
using System.Reflection;
using F00TvsIfyXmHgWNUZO;

namespace j2hL0PyHKVya8iRujI;

internal class wDnEF4ty77l2gn00sk
{
	internal delegate void eMdvGU9DWNsPMq2yY1(object o);

	internal static Module qtocJyBI1;

	internal static wDnEF4ty77l2gn00sk ktwfycbNqPiaq0jHHJ;

	internal static void wLQJbxhhmvrS4(int typemdt)
	{
		int num = 4;
		FieldInfo fieldInfo = default(FieldInfo);
		FieldInfo[] fields = default(FieldInfo[]);
		int num3 = default(int);
		while (true)
		{
			Type type = QgOiFu1X4H4vfjY0fL(qtocJyBI1, 33554432 + typemdt);
			int num2 = 3;
			if (!Q9v4SZldUxpXvlHG2m())
			{
				goto IL_0056;
			}
			goto IL_0089;
			IL_0089:
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 7:
					fieldInfo = fields[num3];
					goto case 2;
				case 2:
				{
					MethodInfo object_ = (MethodInfo)YK7wVMullQnNgCxxDi(qtocJyBI1, fieldInfo.MetadataToken + 100663296);
					fieldInfo.SetValue(null, (MulticastDelegate)EFNxB6VGvp1AAG2Joq(type, object_));
					num2 = 0;
					if (Q9v4SZldUxpXvlHG2m())
					{
						continue;
					}
					goto IL_0056;
				}
				case 5:
					if (num3 < fields.Length)
					{
						num2 = 0;
						if (!Q9v4SZldUxpXvlHG2m())
						{
							continue;
						}
						goto case 1;
					}
					return;
				case 3:
					fields = type.GetFields();
					num3 = 0;
					goto case 5;
				default:
					num3++;
					goto case 5;
				case 4:
					break;
				case 6:
					return;
				}
				break;
			}
			continue;
			IL_0056:
			num2 = num;
			goto IL_0089;
		}
	}

	public wDnEF4ty77l2gn00sk()
	{
		RA8qFscBneAZJXRw9y.oapJbxhTeKZ9M();
		base._002Ector();
	}

	static wDnEF4ty77l2gn00sk()
	{
		RA8qFscBneAZJXRw9y.oapJbxhTeKZ9M();
		qtocJyBI1 = jy3yBR7bJV01PDNrQY(typeof(wDnEF4ty77l2gn00sk).TypeHandle).Assembly.ManifestModule;
	}

	internal static Type QgOiFu1X4H4vfjY0fL(object object_0, int int_0)
	{
		return ((Module)object_0).ResolveType(int_0);
	}

	internal static object YK7wVMullQnNgCxxDi(object object_0, int int_0)
	{
		return ((Module)object_0).ResolveMethod(int_0);
	}

	internal static object EFNxB6VGvp1AAG2Joq(Type type_0, object object_0)
	{
		return Delegate.CreateDelegate(type_0, (MethodInfo)object_0);
	}

	internal static bool Q9v4SZldUxpXvlHG2m()
	{
		return ktwfycbNqPiaq0jHHJ == null;
	}

	internal static wDnEF4ty77l2gn00sk ujjSh3a5HknNqfoZtw()
	{
		return ktwfycbNqPiaq0jHHJ;
	}

	internal static Type jy3yBR7bJV01PDNrQY(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
