using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class9 : c955c655
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.byte_60;
	}

	public void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint num = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		Struct3 @struct = fdc40966_0.class58_0.method_0(num--);
		Struct3 struct2 = fdc40966_0.class58_0.method_0(num);
		if (struct2.c9550f69() != null)
		{
			MethodInfo methodInfo = (MethodInfo)fdc40966_0.class2_0.method_0().method_3(@struct.method_1());
			Type type = struct2.c9550f69().GetType();
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
			Class58 class58_ = fdc40966_0.class58_0;
			uint uint_ = num;
			Struct3 struct3_ = default(Struct3);
			struct3_.method_0((ulong)(long)methodInfo2.MethodHandle.GetFunctionPointer());
			class58_.b53f41f9(uint_, struct3_);
		}
		if (struct2.ba535d1d() > 0L)
		{
			uint uint_2 = fdc40966_0.class58_0.method_0(--num).method_1();
			ulong ulong_ = @struct.ba535d1d();
			Class68 b7d = fdc40966_0.class2_0.method_0().method_5(struct2.method_1()).b7d05965;
			IntPtr intPtr = Class63.fcace5b8(fdc40966_0.class2_0.method_0().method_0(), ulong_, uint_2, b7d, struct2.method_1());
			Class58 class58_2 = fdc40966_0.class58_0;
			uint uint_3 = num;
			Struct3 struct3_ = default(Struct3);
			struct3_.method_0((ulong)(long)intPtr);
			class58_2.b53f41f9(uint_3, struct3_);
		}
		else
		{
			MethodBase methodBase = (MethodBase)fdc40966_0.class2_0.method_0().method_3(@struct.method_1());
			Class58 class58_3 = fdc40966_0.class58_0;
			uint uint_4 = num;
			Struct3 struct3_ = default(Struct3);
			struct3_.method_0((ulong)(long)methodBase.MethodHandle.GetFunctionPointer());
			class58_3.b53f41f9(uint_4, struct3_);
		}
		fdc40966_0.class58_0.method_1(num);
		fdc40966_0.struct3_0[fb3c043f.c55b5391].e63a4aca(num);
		enum0_0 = (Enum0)0;
	}
}
