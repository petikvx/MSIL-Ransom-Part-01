using System;
using System.Runtime.CompilerServices;

internal class Class14 : c955c655
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.byte_66;
	}

	public unsafe void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint num = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		Struct3 @struct = fdc40966_0.class58_0.method_0(num--);
		Struct3 struct2 = fdc40966_0.class58_0.method_0(num);
		bool flag = (@struct.method_1() & 0x80000000u) != 0;
		Type type = (Type)fdc40966_0.class2_0.method_0().method_3(@struct.method_1() & 0x7FFFFFFFu);
		if (flag)
		{
			TypedReference typedReference_ = default(TypedReference);
			Class61.smethod_1(struct2.c9550f69(), Struct2.smethod_0(&typedReference_));
			new Class56(typedReference_);
			struct2 = Struct3.smethod_0(struct2.c9550f69(), type);
			fdc40966_0.class58_0.b53f41f9(num, struct2);
		}
		else
		{
			if ((object)type == typeof(object) && struct2.c9550f69() != null)
			{
				type = struct2.c9550f69().GetType();
			}
			struct2 = Struct3.smethod_0(struct2.c9550f69(), type);
			fdc40966_0.class58_0.b53f41f9(num, struct2);
		}
		fdc40966_0.class58_0.method_1(num);
		fdc40966_0.struct3_0[fb3c043f.c55b5391].e63a4aca(num);
		enum0_0 = (Enum0)0;
	}
}
