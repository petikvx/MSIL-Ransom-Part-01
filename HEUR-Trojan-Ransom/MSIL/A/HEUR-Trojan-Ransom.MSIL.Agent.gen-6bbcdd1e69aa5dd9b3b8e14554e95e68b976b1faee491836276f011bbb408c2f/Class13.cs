using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class13 : c955c655
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.byte_61;
	}

	public void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint uint_ = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		Struct3 struct3_ = fdc40966_0.class58_0.method_0(uint_);
		MemberInfo memberInfo = fdc40966_0.class2_0.method_0().method_3(struct3_.method_1());
		if (memberInfo is Type)
		{
			struct3_.db2591b4(e6c45616.smethod_0(((Type)memberInfo).TypeHandle, typeof(RuntimeTypeHandle)));
		}
		else if (memberInfo is MethodBase)
		{
			struct3_.db2591b4(e6c45616.smethod_0(((MethodBase)memberInfo).MethodHandle, typeof(RuntimeMethodHandle)));
		}
		else if (memberInfo is FieldInfo)
		{
			struct3_.db2591b4(e6c45616.smethod_0(((FieldInfo)memberInfo).FieldHandle, typeof(RuntimeFieldHandle)));
		}
		fdc40966_0.class58_0.b53f41f9(uint_, struct3_);
		enum0_0 = (Enum0)0;
	}
}
