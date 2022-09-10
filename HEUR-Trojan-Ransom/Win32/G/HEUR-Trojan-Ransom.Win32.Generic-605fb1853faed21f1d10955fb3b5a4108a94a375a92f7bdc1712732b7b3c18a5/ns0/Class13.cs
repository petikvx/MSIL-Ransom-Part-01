using System;
using System.IO;
using ns4;
using ns5;

namespace ns0;

internal abstract class Class13
{
	protected internal Class10 class10_0;

	protected internal Class10 class10_1;

	protected internal ushort ushort_0;

	protected IntPtr intptr_0 = IntPtr.Zero;

	protected IntPtr intptr_1 = IntPtr.Zero;

	protected internal int int_0;

	internal Class13()
	{
	}

	internal Class13(IntPtr intptr_2, IntPtr intptr_3, Class10 class10_2, Class10 class10_3, ushort ushort_1, int int_1)
	{
		intptr_0 = intptr_2;
		class10_0 = class10_2;
		class10_1 = class10_3;
		ushort_0 = ushort_1;
		intptr_1 = intptr_3;
		int_0 = int_1;
		Class23.smethod_12(intptr_2, intptr_3, this);
	}

	public virtual void vmethod_0(string string_0)
	{
		Class10 @class = class10_0;
		Class10 class2 = class10_1;
		ushort num = ushort_0;
		Class23.smethod_49(class2, num, string_0, this, @class);
	}

	internal abstract IntPtr vmethod_1(IntPtr intptr_2, IntPtr intptr_3);

	internal abstract void vmethod_2(BinaryWriter binaryWriter_0);

	public virtual void vmethod_3(string string_0)
	{
		Class10 @class = class10_0;
		Class10 class2 = class10_1;
		ushort num = ushort_0;
		Class23.smethod_91(class2, num, this, string_0, @class);
	}

	public virtual void vmethod_4(string string_0)
	{
		Class10 @class = class10_0;
		Class10 class2 = class10_1;
		ushort num = ushort_0;
		Class23.smethod_82(@class, class2, string_0, num);
	}
}
