using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class7 : d88be11e
{
	[SpecialName]
	public byte b4b1262()
	{
		return b13312b0.cce58e96;
	}

	public void df3f437a(Class58 class58_0, out Enum0 enum0_0)
	{
		uint num = class58_0.a6890f1d[b13312b0.byte_7].df1ed028();
		facef383 facef384 = class58_0.c73f45d8.a9bb6dff(num--);
		facef383 facef385 = class58_0.c73f45d8.a9bb6dff(num);
		if (facef385.method_8() != null)
		{
			MethodInfo methodInfo = (MethodInfo)class58_0.a3d704e3.method_0().method_2(facef384.df1ed028());
			Type type = facef385.method_8().GetType();
			List<Type> list = new List<Type>();
			do
			{
				list.Add(type);
				type = type.BaseType;
			}
			while ((object)type != null && (object)type != methodInfo.DeclaringType);
			list.Reverse();
			MethodInfo methodInfo2 = methodInfo;
			foreach (Type item in list)
			{
				MethodInfo[] methods = item.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				foreach (MethodInfo methodInfo3 in methods)
				{
					if ((object)methodInfo3.GetBaseDefinition() == methodInfo2)
					{
						methodInfo2 = methodInfo3;
						break;
					}
				}
			}
			Class59 c73f45d = class58_0.c73f45d8;
			uint uint_ = num;
			facef383 facef383_ = default(facef383);
			facef383_.method_1((ulong)(long)methodInfo2.MethodHandle.GetFunctionPointer());
			c73f45d.method_0(uint_, facef383_);
		}
		if (facef385.method_0() > 0L)
		{
			uint uint_2 = class58_0.c73f45d8.a9bb6dff(--num).df1ed028();
			ulong ulong_ = facef384.method_0();
			ff656cf5 f8b7206e = class58_0.a3d704e3.method_0().a1cfd364(facef385.df1ed028()).f8b7206e;
			IntPtr intPtr = f7461e6.f3cf900d(class58_0.a3d704e3.method_0().a78dacce(), ulong_, uint_2, f8b7206e, facef385.df1ed028());
			Class59 c73f45d2 = class58_0.c73f45d8;
			uint uint_3 = num;
			facef383 facef383_ = default(facef383);
			facef383_.method_1((ulong)(long)intPtr);
			c73f45d2.method_0(uint_3, facef383_);
		}
		else
		{
			MethodBase methodBase = (MethodBase)class58_0.a3d704e3.method_0().method_2(facef384.df1ed028());
			Class59 c73f45d3 = class58_0.c73f45d8;
			uint uint_4 = num;
			facef383 facef383_ = default(facef383);
			facef383_.method_1((ulong)(long)methodBase.MethodHandle.GetFunctionPointer());
			c73f45d3.method_0(uint_4, facef383_);
		}
		class58_0.c73f45d8.a85b6a89(num);
		class58_0.a6890f1d[b13312b0.byte_7].method_2(num);
		enum0_0 = (Enum0)0;
	}
}
