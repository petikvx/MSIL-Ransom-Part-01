using System.Runtime.CompilerServices;

internal class f746b1ac : efe82791
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.byte_50;
	}

	public void imethod_1(Class49 class49_0, out Enum1 enum1_0)
	{
		uint num = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
		Struct2 @struct = class49_0.ec45936d.a59d7f30(num);
		class49_0.ec45936d.method_0(--num);
		class49_0.struct2_0[cb1fcba5.byte_8].c85fac38(num);
		Interface0 @interface = Class59.smethod_0(@struct.method_4());
		@interface.imethod_1(class49_0, out enum1_0);
	}
}
