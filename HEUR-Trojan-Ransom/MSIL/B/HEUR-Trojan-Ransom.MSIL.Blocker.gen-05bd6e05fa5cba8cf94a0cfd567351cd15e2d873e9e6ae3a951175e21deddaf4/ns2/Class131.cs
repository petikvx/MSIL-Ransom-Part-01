using System.Globalization;
using ns10;
using ns7;
using ns8;

namespace ns2;

internal class Class131 : Interface5
{
	private int int_0;

	public object imethod_0(object object_0, string string_0)
	{
		Class4.smethod_747(object_0, this).method_1(string_0, out var gparam_);
		return gparam_;
	}

	public string imethod_1(object object_0, object object_1)
	{
		Class44<string, object> @class = Class4.smethod_747(object_0, this);
		if (!@class.method_2(object_1, out var gparam_))
		{
			int_0++;
			gparam_ = int_0.ToString(CultureInfo.InvariantCulture);
			@class.method_0(gparam_, object_1);
		}
		return gparam_;
	}

	public void imethod_3(object object_0, string string_0, object object_1)
	{
		Class4.smethod_747(object_0, this).method_0(string_0, object_1);
	}

	public bool imethod_2(object object_0, object object_1)
	{
		string gparam_;
		return Class4.smethod_747(object_0, this).method_2(object_1, out gparam_);
	}
}
