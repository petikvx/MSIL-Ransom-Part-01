using System;
using System.Reflection;
using NhGuxCR4JrLw4OnYlkG;
using SRo1MyRyNCF0HMnMeRy;
using mqTn2KRuHaeVC7qZfAP;

namespace aRD5vNRtQHyOUXuGvTG;

internal class bD0vX1Rrg6TMdoaioCC
{
	internal delegate void WNqkYZRILvcat5IjTRB(object o);

	internal static Module ior96dIcTA;

	internal static void GKHIH7hhDHeBC(int typemdt)
	{
		Type type = ior96dIcTA.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)ior96dIcTA.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public bD0vX1Rrg6TMdoaioCC()
	{
		h5jVfKRi6h9cyEPcYxd.nviIH7hzRoY0Y();
		base._002Ector();
	}

	static bD0vX1Rrg6TMdoaioCC()
	{
		uOxwGiRTS5ExO0AcR6j.vIHvRlxcnv();
		h5jVfKRi6h9cyEPcYxd.nviIH7hzRoY0Y();
		ior96dIcTA = Type.GetTypeFromHandle(RfHjVHRe7jq1PgnsRwN.zl0IH7UDOAV3O(33554495)).Assembly.ManifestModule;
	}
}
