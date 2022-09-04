using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.ApplicationServices;
using ns0;

namespace ns1;

internal sealed class Class2
{
	internal sealed class Class3
	{
		unsafe bool object.Equals(object obj)
		{
			void* ptr = stackalloc byte[2];
			*(bool*)ptr = base.Equals(RuntimeHelpers.GetObjectValue(obj));
			((byte*)ptr)[1] = *(byte*)ptr;
			return ((byte*)ptr)[1] != 0;
		}

		unsafe int object.GetHashCode()
		{
			void* ptr = stackalloc byte[8];
			*(int*)ptr = base.GetHashCode();
			*(int*)((byte*)ptr + 4) = *(int*)ptr;
			return *(int*)((byte*)ptr + 4);
		}

		string object.ToString()
		{
			return base.ToString();
		}
	}

	internal sealed class Class4<T> where T : new()
	{
		[ThreadStatic]
		private static T gparam_0;

		[SpecialName]
		internal T method_0()
		{
			if (gparam_0 == null)
			{
				gparam_0 = new T();
			}
			return gparam_0;
		}
	}

	private static readonly Class4<Class1> class4_0 = new Class4<Class1>();

	private static readonly Class4<Class0> class4_1 = new Class4<Class0>();

	private static readonly Class4<User> class4_2 = new Class4<User>();

	private static readonly Class4<Class3> class4_3 = new Class4<Class3>();

	[SpecialName]
	internal static Class1 smethod_0()
	{
		return class4_0.method_0();
	}
}
