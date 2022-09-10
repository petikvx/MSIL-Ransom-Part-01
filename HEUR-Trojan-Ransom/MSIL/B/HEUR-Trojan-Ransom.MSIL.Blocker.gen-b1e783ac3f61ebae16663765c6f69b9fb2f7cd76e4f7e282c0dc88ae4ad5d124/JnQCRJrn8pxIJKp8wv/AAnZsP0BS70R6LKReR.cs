using System;
using System.Reflection;
using hU4x3GePSuIEn9q1kR;
using vYQwQOBpQKxv62YWdN;

namespace JnQCRJrn8pxIJKp8wv;

internal class AAnZsP0BS70R6LKReR
{
	internal delegate void SFU4mbT3GMret7THonf(object o);

	internal static Module aX1OwGmdd;

	internal static void PoLpUTCCuOBEf(int typemdt)
	{
		Type type = aX1OwGmdd.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)aX1OwGmdd.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public AAnZsP0BS70R6LKReR()
	{
		Rul53eN1pQAkHhMgbS.OSEpUTCzh4CrB();
		base._002Ector();
	}

	static AAnZsP0BS70R6LKReR()
	{
		Rul53eN1pQAkHhMgbS.OSEpUTCzh4CrB();
		aX1OwGmdd = Type.GetTypeFromHandle(rEFd09n05jxDrTNC6b.ojGpUTgDOUKrm(33554506)).Assembly.ManifestModule;
	}
}
