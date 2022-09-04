using System;
using System.Reflection;

namespace DvfQbBtXitM6sfTVRK;

internal class gq61iOnjBFSR2FfeF9
{
	internal delegate void pCKjnhWc2dPnjv3CXO(object o);

	internal static Module HgaBW8A0r = typeof(gq61iOnjBFSR2FfeF9).Assembly.ManifestModule;

	internal static void vp2yzwyBDA(int typemdt)
	{
		Type type = HgaBW8A0r.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)HgaBW8A0r.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}
}
