using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using dg3ypDAonQcOidMs0w;

namespace xClient.Core.NetSerializer.TypeSerializers;

public class DictionarySerializer : ITypeSerializer, IStaticTypeSerializer
{
	internal static DictionarySerializer zvZ9y03idoSJuVUipbe;

	public bool Handles(Type type)
	{
		return true;
	}

	public IEnumerable<Type> GetSubtypes(Type type)
	{
		return null;
	}

	public void GetStaticMethods(Type type, out MethodInfo writer, out MethodInfo reader)
	{
	}

	private static MethodInfo GetGenWriter(Type containerType, Type genType)
	{
		return null;
	}

	private static MethodInfo GetGenReader(Type containerType, Type genType)
	{
		return null;
	}

	public static void WritePrimitive<TKey, TValue>(Serializer serializer, Stream stream, Dictionary<TKey, TValue> value)
	{
	}

	public static void ReadPrimitive<TKey, TValue>(Serializer serializer, Stream stream, out Dictionary<TKey, TValue> value)
	{
	}

	static DictionarySerializer()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		vM2Xah3TRqkJkp2KF6g();
	}

	internal static RuntimeTypeHandle MVBaNq3LLuZb1IH1ANY(int token)
	{
		return (RuntimeTypeHandle)(object)null;
	}

	internal static Type TDtBv43eejryxoqnavG(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return null;
	}

	internal static bool Cp58rO3OW9uWCHkmwCV(Type type_0, Type type_1)
	{
		return true;
	}

	internal static bool NAuj8O3kTKveGOx8KVI()
	{
		return true;
	}

	internal static DictionarySerializer OJM8Bs3SFoOGt7enWsm()
	{
		return null;
	}

	internal static object tAJWMR3WP9S3XO5hnvk(Type containerType, Type genType)
	{
		return null;
	}

	internal static object C3xvMR3VgyTyjf4Ah34(object object_0, object object_1)
	{
		return null;
	}

	internal static object PjpGgC32Hgu91k6DYtg(object object_0)
	{
		return null;
	}

	internal static Type zAgbHk3xAlvFG0xEodu(object object_0)
	{
		return null;
	}

	internal static bool Q3Wm0B3a4NY5f7crcai(Type type_0, Type type_1)
	{
		return true;
	}

	internal static bool Q6PFQ3342bKjoC25ncn(object object_0)
	{
		return true;
	}

	internal static void S6y7aP3b6NmmBYxLtgb(object object_0)
	{
	}

	internal static void bDDnLW3EhfbWgEqmHrt()
	{
	}

	internal static void FN3ONp3BROu1M3lafQE()
	{
	}

	internal static void vM2Xah3TRqkJkp2KF6g()
	{
	}
}
