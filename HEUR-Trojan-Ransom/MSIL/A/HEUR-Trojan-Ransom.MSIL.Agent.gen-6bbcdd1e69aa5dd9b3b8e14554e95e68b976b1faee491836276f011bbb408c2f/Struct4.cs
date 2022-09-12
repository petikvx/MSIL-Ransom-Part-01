using System;

internal struct Struct4<T> : Interface2
{
	private T gparam_0;

	public Struct4(T gparam_1)
	{
		gparam_0 = gparam_1;
	}

	public object bb331190()
	{
		return gparam_0;
	}

	public Type imethod_0()
	{
		return typeof(T);
	}

	public Interface2 imethod_1()
	{
		return new Struct4<T>(gparam_0);
	}
}
