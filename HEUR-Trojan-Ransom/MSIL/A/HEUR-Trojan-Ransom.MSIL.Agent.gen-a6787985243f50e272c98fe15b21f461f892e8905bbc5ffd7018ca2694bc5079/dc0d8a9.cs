using System;

internal struct dc0d8a9<T> : Interface2
{
	private T ee0e49f4;

	public dc0d8a9(T gparam_0)
	{
		ee0e49f4 = gparam_0;
	}

	public object a421f925()
	{
		return ee0e49f4;
	}

	public Type ea5d1f1f()
	{
		return typeof(T);
	}

	public Interface2 imethod_0()
	{
		return new global::dc0d8a9<T>(ee0e49f4);
	}
}
