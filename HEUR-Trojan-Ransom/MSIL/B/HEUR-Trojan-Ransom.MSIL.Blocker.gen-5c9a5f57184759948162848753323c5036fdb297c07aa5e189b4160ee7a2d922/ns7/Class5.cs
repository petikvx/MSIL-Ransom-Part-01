using System;
using System.Windows.Controls;
using ns1;

namespace ns7;

internal sealed class Class5 : Page
{
	internal static void smethod_0(Type type_0, out Delegate delegate_0)
	{
		string text = "r";
		Type typeFromHandle = typeof(Class0.Delegate0);
		if (type_0 == null)
		{
			throw new ArgumentNullException("type");
		}
		if (type_0.IsGenericType && type_0.ContainsGenericParameters)
		{
			throw new ArgumentException("type");
		}
		if (text == null)
		{
			throw new ArgumentNullException("method");
		}
		delegate_0 = Delegate.CreateDelegate(typeFromHandle, type_0, text, ignoreCase: false, throwOnBindFailure: false);
	}
}
