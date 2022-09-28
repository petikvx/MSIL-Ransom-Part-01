using System;
using System.Collections.Generic;

public interface GInterface2
{
	GInterface3 GInterface3_0 { get; }

	GInterface2 imethod_0(GEnum3 genum3_0);

	GInterface2 imethod_1(GEnum3 genum3_0);

	GInterface2 imethod_2(params GEnum3[] genum3_0);

	GInterface2 imethod_3(GEnum3 genum3_0);

	GInterface2 imethod_4(IEnumerable<GEnum3> ienumerable_0, IEnumerable<GEnum3> ienumerable_1);

	GInterface2 imethod_5(IEnumerable<GEnum3> ienumerable_0, GEnum3 genum3_0);

	GInterface2 imethod_6(GEnum3 genum3_0, IEnumerable<GEnum3> ienumerable_0);

	GInterface2 imethod_7(GEnum3 genum3_0, GEnum3 genum3_1);

	GInterface2 imethod_8(string string_0);

	GInterface2 imethod_9(char char_0);

	GInterface2 imethod_10(int int_0);

	GInterface2 imethod_11(TimeSpan timeSpan_0);
}
