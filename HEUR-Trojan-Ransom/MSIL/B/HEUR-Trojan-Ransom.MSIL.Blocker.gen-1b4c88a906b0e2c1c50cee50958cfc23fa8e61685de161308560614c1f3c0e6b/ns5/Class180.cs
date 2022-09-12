using Newtonsoft.Json.Linq;
using ns15;

namespace ns5;

internal class Class180 : Class179
{
	public Class180(Class180 class180_0)
		: base(class180_0)
	{
	}

	public Class180(object? object_2)
		: base(object_2, JTokenType.Raw)
	{
	}

	internal override JToken vmethod_0()
	{
		return new Class180(this);
	}
}
