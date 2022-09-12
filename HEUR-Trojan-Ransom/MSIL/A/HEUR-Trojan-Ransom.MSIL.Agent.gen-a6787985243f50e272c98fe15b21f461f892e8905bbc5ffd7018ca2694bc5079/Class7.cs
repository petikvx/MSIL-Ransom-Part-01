using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class7 : f788ae7e
{
	[SpecialName]
	public byte f998adc2()
	{
		return fae0f10.byte_48;
	}

	public void imethod_0(Class52 class52_0, out a82ced3b a82ced3b_0)
	{
		uint num = class52_0.struct2_0[fae0f10.byte_5].b5683088();
		Struct2 @struct = class52_0.c6a36180_0.f113e6df(num--);
		Struct2 struct2 = class52_0.c6a36180_0.f113e6df(num);
		if (struct2.a90ed1e2() != null)
		{
			MethodInfo methodInfo = (MethodInfo)class52_0.c8dafbc3.method_0().d3f1f142(@struct.b5683088());
			Type type = struct2.a90ed1e2().GetType();
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
			c6a36180 c6a36180_ = class52_0.c6a36180_0;
			uint uint_ = num;
			Struct2 struct2_ = default(Struct2);
			struct2_.f6b2288d((ulong)(long)methodInfo2.MethodHandle.GetFunctionPointer());
			c6a36180_.f43586b2(uint_, struct2_);
		}
		if (struct2.method_0() > 0L)
		{
			uint uint_2 = class52_0.c6a36180_0.f113e6df(--num).b5683088();
			ulong ulong_ = @struct.method_0();
			Class62 b47905ce = class52_0.c8dafbc3.method_0().d92c25c4(struct2.b5683088()).b47905ce;
			IntPtr intPtr = aab2ab46.d19589ed(class52_0.c8dafbc3.method_0().method_0(), ulong_, uint_2, b47905ce, struct2.b5683088());
			c6a36180 c6a36180_2 = class52_0.c6a36180_0;
			uint uint_3 = num;
			Struct2 struct2_ = default(Struct2);
			struct2_.f6b2288d((ulong)(long)intPtr);
			c6a36180_2.f43586b2(uint_3, struct2_);
		}
		else
		{
			MethodBase methodBase = (MethodBase)class52_0.c8dafbc3.method_0().d3f1f142(@struct.b5683088());
			c6a36180 c6a36180_3 = class52_0.c6a36180_0;
			uint uint_4 = num;
			Struct2 struct2_ = default(Struct2);
			struct2_.f6b2288d((ulong)(long)methodBase.MethodHandle.GetFunctionPointer());
			c6a36180_3.f43586b2(uint_4, struct2_);
		}
		class52_0.c6a36180_0.method_0(num);
		class52_0.struct2_0[fae0f10.byte_5].b3579a47(num);
		a82ced3b_0 = (a82ced3b)0;
	}
}
