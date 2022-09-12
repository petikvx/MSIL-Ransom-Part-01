using System;
using System.Globalization;
using Newtonsoft.Json;
using ns1;
using ns13;
using ns3;
using ns9;

namespace ns2;

internal abstract class Class9<T> : Class8
{
	public sealed override void vmethod_0(Class37 class37_0, object? object_0, Class33 class33_0)
	{
		if (!((object_0 != null) ? (object_0 is T) : Class131.smethod_666(typeof(T))))
		{
			throw new JsonSerializationException("Converter cannot write specified value to JSON. {0} is required.".smethod_1(CultureInfo.InvariantCulture, typeof(T)));
		}
		vmethod_3(class37_0, (T)object_0, class33_0);
	}

	public abstract void vmethod_3(Class37 class37_0, T? gparam_0, Class33 class33_0);

	public sealed override object? vmethod_1(Class28 class28_0, Type type_0, object? object_0, Class33 class33_0)
	{
		bool flag;
		if (!(flag = object_0 == null) && !(object_0 is T))
		{
			throw new JsonSerializationException("Converter cannot read JSON with the specified existing value. {0} is required.".smethod_1(CultureInfo.InvariantCulture, typeof(T)));
		}
		return vmethod_4(class28_0, type_0, flag ? default(T) : ((T)object_0), !flag, class33_0);
	}

	public abstract T? vmethod_4(Class28 class28_0, Type type_0, T? gparam_0, bool bool_0, Class33 class33_0);

	public sealed override bool vmethod_2(Type type_0)
	{
		return typeof(T).IsAssignableFrom(type_0);
	}
}
