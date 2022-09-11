using ns21;
using ns7;
using ns8;

namespace ns12;

internal sealed class Class77
{
	internal string string_0;

	internal string string_1;

	internal bool bool_0;

	internal Class73 class73_0;

	internal Class74 class74_0;

	internal Class61 class61_0;

	internal Class63 class63_0;

	public Class77(Class63 class63_1)
	{
		class63_0 = class63_1;
		method_0(class63_1.Target, class63_1.FilterData, null, bool_1: false);
	}

	public Class77(Class61 class61_1)
	{
		class61_0 = class61_1;
		method_0(class61_1.Target, class61_1.FilterData, class61_1.class74_0, bool_1: true);
	}

	private void method_0(Class38 class38_0, Class73 class73_1, Class74 class74_1, bool bool_1)
	{
		string_0 = class38_0.Schema.Name;
		string_1 = class38_0.Name;
		bool_0 = bool_1;
		class73_0 = class73_1;
		class74_0 = class74_1;
	}
}
