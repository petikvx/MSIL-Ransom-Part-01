using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class11 : d88be11e
{
	[SpecialName]
	public byte b4b1262()
	{
		return b13312b0.byte_69;
	}

	public void df3f437a(Class58 class58_0, out Enum0 enum0_0)
	{
		uint uint_ = class58_0.a6890f1d[b13312b0.byte_7].df1ed028();
		facef383 facef383_ = class58_0.c73f45d8.a9bb6dff(uint_);
		MemberInfo memberInfo = class58_0.a3d704e3.method_0().method_2(facef383_.df1ed028());
		if (memberInfo is Type)
		{
			facef383_.method_9(e94c75e3.f6ace54f(((Type)memberInfo).TypeHandle, typeof(RuntimeTypeHandle)));
		}
		else if (memberInfo is MethodBase)
		{
			facef383_.method_9(e94c75e3.f6ace54f(((MethodBase)memberInfo).MethodHandle, typeof(RuntimeMethodHandle)));
		}
		else if (memberInfo is FieldInfo)
		{
			facef383_.method_9(e94c75e3.f6ace54f(((FieldInfo)memberInfo).FieldHandle, typeof(RuntimeFieldHandle)));
		}
		class58_0.c73f45d8.method_0(uint_, facef383_);
		enum0_0 = (Enum0)0;
	}
}
