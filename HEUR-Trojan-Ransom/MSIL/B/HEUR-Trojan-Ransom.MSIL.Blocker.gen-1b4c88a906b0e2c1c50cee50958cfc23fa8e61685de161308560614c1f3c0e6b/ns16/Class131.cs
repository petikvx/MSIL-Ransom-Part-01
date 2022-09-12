using System.Globalization;
using ns2;
using ns5;
using ns9;

namespace ns16;

internal class Class131 : Interface5
{
	private int int_0;

	public object imethod_0(object object_0, string string_0)
	{
		Class7.smethod_13(this, object_0).method_1(string_0, out var gparam_);
		return gparam_;
	}

	public string imethod_1(object object_0, object object_1)
	{
		Class44<string, object> @class = Class7.smethod_13(this, object_0);
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
		Class7.smethod_13(this, object_0).method_0(string_0, object_1);
	}

	public bool imethod_2(object object_0, object object_1)
	{
		string gparam_;
		return Class7.smethod_13(this, object_0).method_2(object_1, out gparam_);
	}
}
