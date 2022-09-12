using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class7 : bae6a63f
{
	[SpecialName]
	public byte e9bf20d3()
	{
		return Class69.f5af0117;
	}

	public void imethod_0(Class62 class62_0, out Enum1 enum1_0)
	{
		uint num = class62_0.ebd9b488_0[Class69.byte_4].b585a11();
		ebd9b488 ebd9b489 = class62_0.class64_0.method_0(num--);
		ebd9b488 ebd9b490 = class62_0.class64_0.method_0(num);
		if (ebd9b490.ec0d6773() != null)
		{
			MethodInfo methodInfo = (MethodInfo)class62_0.da79a168.de5d16da().method_3(ebd9b489.b585a11());
			Type type = ebd9b490.ec0d6773().GetType();
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
			Class64 class64_ = class62_0.class64_0;
			uint uint_ = num;
			ebd9b488 ebd9b488_ = default(ebd9b488);
			ebd9b488_.eca936fa((ulong)(long)methodInfo2.MethodHandle.GetFunctionPointer());
			class64_.method_1(uint_, ebd9b488_);
		}
		if (ebd9b490.method_0() > 0L)
		{
			uint uint_2 = class62_0.class64_0.method_0(--num).b585a11();
			ulong ulong_ = ebd9b489.method_0();
			Class71 class71_ = class62_0.da79a168.de5d16da().method_5(ebd9b490.b585a11()).class71_0;
			IntPtr intPtr = dcfb16a7.b684a3da(class62_0.da79a168.de5d16da().c5b9baf(), ulong_, uint_2, class71_, ebd9b490.b585a11());
			Class64 class64_2 = class62_0.class64_0;
			uint uint_3 = num;
			ebd9b488 ebd9b488_ = default(ebd9b488);
			ebd9b488_.eca936fa((ulong)(long)intPtr);
			class64_2.method_1(uint_3, ebd9b488_);
		}
		else
		{
			MethodBase methodBase = (MethodBase)class62_0.da79a168.de5d16da().method_3(ebd9b489.b585a11());
			Class64 class64_3 = class62_0.class64_0;
			uint uint_4 = num;
			ebd9b488 ebd9b488_ = default(ebd9b488);
			ebd9b488_.eca936fa((ulong)(long)methodBase.MethodHandle.GetFunctionPointer());
			class64_3.method_1(uint_4, ebd9b488_);
		}
		class62_0.class64_0.method_2(num);
		class62_0.ebd9b488_0[Class69.byte_4].cf774c3c(num);
		enum1_0 = (Enum1)0;
	}
}
