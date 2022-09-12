using System;

internal struct Struct2<T> : Interface2
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

	public Interface2 imethod_2()
	{
		return new Struct2<T>(gparam_0);
	}
}
