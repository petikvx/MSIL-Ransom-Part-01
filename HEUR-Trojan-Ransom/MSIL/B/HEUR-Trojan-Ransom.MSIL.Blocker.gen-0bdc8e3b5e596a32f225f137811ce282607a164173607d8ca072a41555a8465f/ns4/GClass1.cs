using System;
using System.Windows.Controls;
using ns1;

namespace ns4;

public class GClass1 : Page
{
	public void method_0()
	{
	}

	internal static void smethod_0(Type type_0, out Delegate delegate_0)
	{
		delegate_0 = Delegate.CreateDelegate(typeof(GClass0.Delegate0), type_0, "r");
	}
}
