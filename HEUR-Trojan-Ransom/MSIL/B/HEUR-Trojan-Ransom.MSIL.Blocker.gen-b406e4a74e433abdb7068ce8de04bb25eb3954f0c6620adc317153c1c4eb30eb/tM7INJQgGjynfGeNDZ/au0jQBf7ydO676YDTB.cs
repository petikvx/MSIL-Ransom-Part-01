using System;
using System.Reflection;
using h3i1ECwXWt3dwb3P50;

namespace tM7INJQgGjynfGeNDZ;

internal class au0jQBf7ydO676YDTB
{
	internal delegate void JaT5FK5qJtoDsu7I7U(object o);

	internal static Module DlawQVtg4;

	internal static void XtuPQXddI2f3q(int typemdt)
	{
		Type type = DlawQVtg4.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)DlawQVtg4.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public au0jQBf7ydO676YDTB()
	{
		nNnHslUN2ccm7jpXDV.MpUPQXdeOAYR1();
		base._002Ector();
	}

	static au0jQBf7ydO676YDTB()
	{
		nNnHslUN2ccm7jpXDV.MpUPQXdeOAYR1();
		DlawQVtg4 = typeof(au0jQBf7ydO676YDTB).Assembly.ManifestModule;
	}
}
