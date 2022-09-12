using System.Globalization;
using ns0;
using ns13;
using ns15;

namespace ns19;

internal class Class130 : Interface5
{
	private int int_0;

	public object imethod_0(object object_0, string string_0)
	{
		Class131.smethod_473(this, object_0).method_1(string_0, out var gparam_);
		return gparam_;
	}

	public string imethod_1(object object_0, object object_1)
	{
		Class43<string, object> @class = Class131.smethod_473(this, object_0);
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
		Class131.smethod_473(this, object_0).method_0(string_0, object_1);
	}

	public bool imethod_2(object object_0, object object_1)
	{
		string gparam_;
		return Class131.smethod_473(this, object_0).method_2(object_1, out gparam_);
	}
}
