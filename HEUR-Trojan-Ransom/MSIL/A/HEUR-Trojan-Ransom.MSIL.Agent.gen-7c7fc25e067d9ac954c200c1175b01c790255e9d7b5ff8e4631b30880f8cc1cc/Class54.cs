using System.Collections.Generic;

internal class Class54
{
	public readonly feeb32c3[] feeb32c3_0 = new feeb32c3[16];

	public readonly Class55 class55_0 = new Class55();

	public readonly Class1 class1_0;

	public readonly List<eec46a6e> d6265297 = new List<eec46a6e>();

	public readonly List<Class51> list_0 = new List<Class51>();

	public Class54(Class1 class1_1)
	{
		class1_0 = class1_1;
	}

	public unsafe byte method_0()
	{
		uint num = feeb32c3_0[c34ccaf0.byte_5].method_0();
		ref feeb32c3 reference = ref feeb32c3_0[c34ccaf0.cb256761];
		ulong num2 = reference.d9a53946();
		reference.b67abfed(num2 + 1L);
		byte* ptr = (byte*)num2;
		byte b = (byte)(*ptr ^ num);
		num = num * 7 + b;
		feeb32c3_0[c34ccaf0.byte_5].method_1(num);
		return b;
	}
}
