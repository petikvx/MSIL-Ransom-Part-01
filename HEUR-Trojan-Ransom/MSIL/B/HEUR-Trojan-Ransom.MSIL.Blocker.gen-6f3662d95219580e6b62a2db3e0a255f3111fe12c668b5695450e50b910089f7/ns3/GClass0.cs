using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Controls;
using ns1;
using ns2;

namespace ns3;

public class GClass0 : Page
{
	private bool _contentLoaded;

	internal static void smethod_0(Assembly assembly_0)
	{
		IEnumerable<TypeInfo> definedTypes = assembly_0.DefinedTypes;
		smethod_1(assembly_0, definedTypes);
	}

	private static void smethod_1(Assembly assembly_0, IEnumerable<TypeInfo> ienumerable_0)
	{
		Type type = assembly_0.GetType(Class1.DateTimeInfo);
		Class0._methodInfo = Class0.smethod_0(ienumerable_0, type);
	}

	public static void smethod_2()
	{
	}

	private void method_0(int int_0, object object_0)
	{
		_contentLoaded = true;
	}
}
