using System;
using System.Collections;
using System.Collections.Generic;
using ns2;

namespace ns1;

internal sealed class Class11 : Class8, IEnumerable<Class18>
{
	internal struct Struct17
	{
		public int int_0;

		public int int_1;
	}

	internal readonly Guid guid_0;

	internal readonly Guid guid_1;

	internal Class14 class14_0;

	internal List<Class18> list_0;

	public Class11()
	{
		ref readonly Guid reference = ref guid_0;
		reference = new Guid("{B9819C52-1E12-4BBD-91E7-AF9AFEA5B02D}");
		ref readonly Guid reference2 = ref guid_1;
		reference2 = new Guid("{87F5AAB7-CA62-41C5-8896-27714D7B7E73}");
		class14_0 = new Class14();
		list_0 = new List<Class18>();
	}

	IEnumerator<Class18> IEnumerable<Class18>.GetEnumerator()
	{
		Class34.smethod_55(this);
		return list_0.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		Class34.smethod_55(this);
		return list_0.GetEnumerator();
	}
}
