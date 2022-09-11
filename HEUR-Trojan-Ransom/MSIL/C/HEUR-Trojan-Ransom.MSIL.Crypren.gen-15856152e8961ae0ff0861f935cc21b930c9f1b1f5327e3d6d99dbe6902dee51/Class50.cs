using System;
using System.Reflection;

internal sealed class Class50 : Interface0
{
	private object object_0;

	private string string_0;

	public Class50(string string_1, object object_1)
	{
		object_0 = object_1;
		string_0 = string_1;
	}

	public object imethod_0(object object_1, object[] object_2)
	{
		return ((Delegate)object_0.GetType().InvokeMember(string_0, BindingFlags.InvokeMethod, null, object_0, new object[1] { object_1 })).DynamicInvoke(object_2);
	}
}
