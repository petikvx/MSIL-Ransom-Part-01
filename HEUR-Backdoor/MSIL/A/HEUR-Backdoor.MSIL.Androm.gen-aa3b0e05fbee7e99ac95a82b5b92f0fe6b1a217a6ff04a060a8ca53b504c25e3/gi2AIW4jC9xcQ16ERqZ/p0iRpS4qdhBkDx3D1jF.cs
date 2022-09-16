using System;
using System.Reflection;
using HrqeXu48u5BWvM2U05m;
using JAhEyh46uvA1xwWjvIk;
using WGDcIt4rthaVX3IEVJJ;

namespace gi2AIW4jC9xcQ16ERqZ;

internal class p0iRpS4qdhBkDx3D1jF
{
	internal delegate void yTHKL84w7buUVB5J8vt(object o);

	internal static Module YJv0LJnlrX;

	internal static void WZC2lyPPnqE5L(int typemdt)
	{
		Type type = YJv0LJnlrX.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)YJv0LJnlrX.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public p0iRpS4qdhBkDx3D1jF()
	{
		xvSuwU4RhceXCdhSJgI.d012lyPzTwFQy();
		base._002Ector();
	}

	static p0iRpS4qdhBkDx3D1jF()
	{
		K1GfMT41V9bS6oPmMyh.cKXl4vhcQo();
		xvSuwU4RhceXCdhSJgI.d012lyPzTwFQy();
		YJv0LJnlrX = Type.GetTypeFromHandle(b8EMs849NOuR3KOJSCl.SVK2lyCMuaNuT(33554495)).Assembly.ManifestModule;
	}
}
