using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class db13c435 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.byte_59;
	}

	public void imethod_1(Class49 class49_0, out Enum1 enum1_0)
	{
		uint num = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
		Struct2 @struct = class49_0.ec45936d.a59d7f30(num--);
		Struct2 struct2 = class49_0.ec45936d.a59d7f30(num);
		if (struct2.method_6() != null)
		{
			MethodInfo methodInfo = (MethodInfo)class49_0.class2_0.c73a3276().a9b0159f(@struct.method_2());
			Type type = struct2.method_6().GetType();
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
			a5c16fd5 ec45936d = class49_0.ec45936d;
			uint uint_ = num;
			Struct2 struct2_ = default(Struct2);
			struct2_.method_1((ulong)(long)methodInfo2.MethodHandle.GetFunctionPointer());
			ec45936d.d1cb88cf(uint_, struct2_);
		}
		if (struct2.method_0() > 0L)
		{
			uint uint_2 = class49_0.ec45936d.a59d7f30(--num).method_2();
			ulong ulong_ = @struct.method_0();
			Class61 class61_ = class49_0.class2_0.c73a3276().method_4(struct2.method_2()).class61_0;
			IntPtr intPtr = Class57.smethod_0(class49_0.class2_0.c73a3276().method_0(), ulong_, uint_2, class61_, struct2.method_2());
			a5c16fd5 ec45936d2 = class49_0.ec45936d;
			uint uint_3 = num;
			Struct2 struct2_ = default(Struct2);
			struct2_.method_1((ulong)(long)intPtr);
			ec45936d2.d1cb88cf(uint_3, struct2_);
		}
		else
		{
			MethodBase methodBase = (MethodBase)class49_0.class2_0.c73a3276().a9b0159f(@struct.method_2());
			a5c16fd5 ec45936d3 = class49_0.ec45936d;
			uint uint_4 = num;
			Struct2 struct2_ = default(Struct2);
			struct2_.method_1((ulong)(long)methodBase.MethodHandle.GetFunctionPointer());
			ec45936d3.d1cb88cf(uint_4, struct2_);
		}
		class49_0.ec45936d.method_0(num);
		class49_0.struct2_0[cb1fcba5.byte_8].c85fac38(num);
		enum1_0 = (Enum1)0;
	}
}
