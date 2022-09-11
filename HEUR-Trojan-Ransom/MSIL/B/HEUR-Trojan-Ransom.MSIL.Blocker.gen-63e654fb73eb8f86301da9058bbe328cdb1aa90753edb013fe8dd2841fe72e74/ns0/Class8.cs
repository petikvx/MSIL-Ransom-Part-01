using System;
using System.Threading;

namespace ns0;

internal sealed class Class8 : Lazy<TimeZone>, Interface4
{
	public Class8()
	{
	}

	public Class8(Func<TimeZone> func_0)
		: base(func_0)
	{
	}

	public Class8(bool bool_0)
		: base(bool_0)
	{
	}

	public Class8(LazyThreadSafetyMode lazyThreadSafetyMode_0)
		: base(lazyThreadSafetyMode_0)
	{
	}

	public Class8(Func<TimeZone> func_0, bool bool_0)
		: base(func_0, bool_0)
	{
	}

	public Class8(Func<TimeZone> func_0, LazyThreadSafetyMode lazyThreadSafetyMode_0)
		: base(func_0, lazyThreadSafetyMode_0)
	{
	}

	public override bool vmethod_0(object object_0)
	{
		return base.Equals(object_0);
	}

	public override int vmethod_1()
	{
		return base.GetHashCode();
	}

	public override string vmethod_2()
	{
		return ToString();
	}
}
