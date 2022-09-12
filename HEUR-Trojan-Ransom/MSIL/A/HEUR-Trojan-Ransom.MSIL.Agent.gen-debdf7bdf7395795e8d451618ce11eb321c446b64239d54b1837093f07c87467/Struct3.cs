using System;

internal struct Struct3<T> : Interface1
{
	private T e0d57019;

	public Struct3(T gparam_0)
	{
		e0d57019 = gparam_0;
	}

	public object imethod_0()
	{
		return e0d57019;
	}

	public Type imethod_1()
	{
		return typeof(T);
	}

	public Interface1 imethod_2()
	{
		return new Struct3<T>(e0d57019);
	}
}
