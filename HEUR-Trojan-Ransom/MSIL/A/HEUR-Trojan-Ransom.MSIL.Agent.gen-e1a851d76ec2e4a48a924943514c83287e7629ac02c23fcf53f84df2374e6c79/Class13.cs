using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class13 : bae6a63f
{
	[SpecialName]
	public byte e9bf20d3()
	{
		return Class69.byte_58;
	}

	public void imethod_0(Class62 class62_0, out Enum1 enum1_0)
	{
		uint uint_ = class62_0.ebd9b488_0[Class69.byte_4].b585a11();
		ebd9b488 ebd9b488_ = class62_0.class64_0.method_0(uint_);
		MemberInfo memberInfo = class62_0.da79a168.de5d16da().method_3(ebd9b488_.b585a11());
		if (memberInfo is Type)
		{
			ebd9b488_.aa900636(Class68.cbd2da44(((Type)memberInfo).TypeHandle, typeof(RuntimeTypeHandle)));
		}
		else if (memberInfo is MethodBase)
		{
			ebd9b488_.aa900636(Class68.cbd2da44(((MethodBase)memberInfo).MethodHandle, typeof(RuntimeMethodHandle)));
		}
		else if (memberInfo is FieldInfo)
		{
			ebd9b488_.aa900636(Class68.cbd2da44(((FieldInfo)memberInfo).FieldHandle, typeof(RuntimeFieldHandle)));
		}
		class62_0.class64_0.method_1(uint_, ebd9b488_);
		enum1_0 = (Enum1)0;
	}
}
