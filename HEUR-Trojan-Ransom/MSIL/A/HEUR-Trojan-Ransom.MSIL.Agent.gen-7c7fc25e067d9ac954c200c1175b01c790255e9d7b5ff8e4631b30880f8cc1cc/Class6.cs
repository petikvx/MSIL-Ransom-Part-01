using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class6 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.d29594d6;
	}

	public void imethod_1(Class54 class54_0, out a0aa499b a0aa499b_0)
	{
		uint num = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
		feeb32c3 feeb32c4 = class54_0.class55_0.ff4c393f(num--);
		feeb32c3 feeb32c5 = class54_0.class55_0.ff4c393f(num);
		if (feeb32c5.cc3408c2() != null)
		{
			MethodInfo methodInfo = (MethodInfo)class54_0.class1_0.method_0().method_2(feeb32c4.method_0());
			Type type = feeb32c5.cc3408c2().GetType();
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
			Class55 class55_ = class54_0.class55_0;
			uint uint_ = num;
			feeb32c3 feeb32c3_ = default(feeb32c3);
			feeb32c3_.b67abfed((ulong)(long)methodInfo2.MethodHandle.GetFunctionPointer());
			class55_.method_0(uint_, feeb32c3_);
		}
		if (feeb32c5.d9a53946() > 0L)
		{
			uint uint_2 = class54_0.class55_0.ff4c393f(--num).method_0();
			ulong ulong_ = feeb32c4.d9a53946();
			Class66 class66_ = class54_0.class1_0.method_0().method_4(feeb32c5.method_0()).class66_0;
			IntPtr intPtr = Class61.smethod_0(class54_0.class1_0.method_0().cb6b0b0e(), ulong_, uint_2, class66_, feeb32c5.method_0());
			Class55 class55_2 = class54_0.class55_0;
			uint uint_3 = num;
			feeb32c3 feeb32c3_ = default(feeb32c3);
			feeb32c3_.b67abfed((ulong)(long)intPtr);
			class55_2.method_0(uint_3, feeb32c3_);
		}
		else
		{
			MethodBase methodBase = (MethodBase)class54_0.class1_0.method_0().method_2(feeb32c4.method_0());
			Class55 class55_3 = class54_0.class55_0;
			uint uint_4 = num;
			feeb32c3 feeb32c3_ = default(feeb32c3);
			feeb32c3_.b67abfed((ulong)(long)methodBase.MethodHandle.GetFunctionPointer());
			class55_3.method_0(uint_4, feeb32c3_);
		}
		class54_0.class55_0.method_1(num);
		class54_0.feeb32c3_0[c34ccaf0.byte_3].method_1(num);
		a0aa499b_0 = (a0aa499b)0;
	}
}
