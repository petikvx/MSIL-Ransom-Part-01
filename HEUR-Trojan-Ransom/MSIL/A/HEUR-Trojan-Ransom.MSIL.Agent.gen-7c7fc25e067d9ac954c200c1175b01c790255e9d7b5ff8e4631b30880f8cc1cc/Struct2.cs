using System;

internal struct Struct2<T> : c8feea0
{
	private T gparam_0;

	public Struct2(T gparam_1)
	{
		gparam_0 = gparam_1;
	}

	public object imethod_0()
	{
		return gparam_0;
	}

	public Type imethod_1()
	{
		return typeof(T);
	}

	public c8feea0 df1630d2()
	{
		return new Struct2<T>(gparam_0);
	}
}
