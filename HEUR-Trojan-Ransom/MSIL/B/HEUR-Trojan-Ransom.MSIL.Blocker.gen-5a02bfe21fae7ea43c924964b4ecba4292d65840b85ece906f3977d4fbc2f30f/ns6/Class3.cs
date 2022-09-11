using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using ns5;

namespace ns6;

internal sealed class Class3
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 232)]
	private struct Struct0
	{
	}

	private static readonly Array d;

	private static readonly Array m = new char[116];

	private static readonly Array R;

	internal static byte Q/* Not supported: data(00) */;

	internal static Func<Type[], Type> smethod_0(TypeInfo typeInfo_0, out Delegate delegate_0, out Type type_0, out string string_0)
	{
		bool num = typeInfo_0.GetMethod("r") == typeof(void);
		type_0 = typeof(GClass0.Delegate0);
		string_0 = "r";
		Func<Type[], Type> result = ((!num) ? new Func<Type[], Type>(Expression.GetFuncType) : new Func<Type[], Type>(Expression.GetActionType));
		if (num)
		{
			delegate_0 = Delegate.CreateDelegate(type_0, typeInfo_0, string_0);
		}
		delegate_0 = null;
		return result;
	}

	static Class3()
	{
		char[] array = new char[8];
		array[6] = '⼅';
		array[7] = '⥸';
		array[2] = '⣙';
		array[4] = '㳍';
		array[1] = 'Ϋ';
		array[5] = 'ⳡ';
		array[3] = 'ㅲ';
		array[0] = '㴟';
		R = new string[7];
		d = array;
	}
}
