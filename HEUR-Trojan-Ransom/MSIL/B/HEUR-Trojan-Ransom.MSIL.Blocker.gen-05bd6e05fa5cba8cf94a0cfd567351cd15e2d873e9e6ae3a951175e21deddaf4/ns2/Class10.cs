using System;
using System.Globalization;
using Newtonsoft.Json;
using ns10;
using ns17;
using ns18;
using ns5;
using ns7;

namespace ns2;

internal abstract class Class10<T> : Class9
{
	public sealed override void vmethod_0(Class38 class38_0, object? object_0, Class34 class34_0)
	{
		if (!((object_0 != null) ? (object_0 is T) : Class4.smethod_753(typeof(T))))
		{
			throw new JsonSerializationException("Converter cannot write specified value to JSON. {0} is required.".smethod_1(CultureInfo.InvariantCulture, typeof(T)));
		}
		vmethod_3(class38_0, (T)object_0, class34_0);
	}

	public abstract void vmethod_3(Class38 class38_0, T? gparam_0, Class34 class34_0);

	public sealed override object? vmethod_1(Class29 class29_0, Type type_0, object? object_0, Class34 class34_0)
	{
		bool flag;
		if (!(flag = object_0 == null) && !(object_0 is T))
		{
			throw new JsonSerializationException("Converter cannot read JSON with the specified existing value. {0} is required.".smethod_1(CultureInfo.InvariantCulture, typeof(T)));
		}
		return vmethod_4(class29_0, type_0, flag ? default(T) : ((T)object_0), !flag, class34_0);
	}

	public abstract T? vmethod_4(Class29 class29_0, Type type_0, T? gparam_0, bool bool_0, Class34 class34_0);

	public sealed override bool vmethod_2(Type type_0)
	{
		return typeof(T).IsAssignableFrom(type_0);
	}
}
