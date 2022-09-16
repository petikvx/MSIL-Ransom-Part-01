using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using dg3ypDAonQcOidMs0w;

namespace xClient.Core.NetSerializer.TypeSerializers;

public class DictionarySerializer : ITypeSerializer, IStaticTypeSerializer
{
	private static DictionarySerializer RGOIvlOrIsyKVNpqOl9;

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
		liJMTbOt9URGJGC170t();
	}

	internal static RuntimeTypeHandle knVxieOim9qXsh1P8FL(int token)
	{
		return (RuntimeTypeHandle)(object)null;
	}

	internal static bool hXIs3jOEwwsrPToccj3()
	{
		return true;
	}

	internal static DictionarySerializer PgqNefOOqpEDRwxLxZr()
	{
		return null;
	}

	internal static Type Kmax9gO94qEcPwtVPXn(object object_0)
	{
		return null;
	}

	internal static object IH1KjwO5f2fEtIpJf3L(Type containerType, Type genType)
	{
		return null;
	}

	internal static object scVex0O4kE242sgxELs(object object_0, object object_1)
	{
		return null;
	}

	internal static object T6X7XoOh4mZ0OdFZYgn(object object_0)
	{
		return null;
	}

	internal static Type HISHbLOwd9bnuYUjAKo(object object_0)
	{
		return null;
	}

	internal static Type du30CZOyUd4NlCMJ8Z1(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return null;
	}

	internal static bool N04Mj4OlEmfObYuQID0(Type type_0, Type type_1)
	{
		return true;
	}

	internal static bool iS45hOOHQGhbo4y0XoO(Type type_0, Type type_1)
	{
		return true;
	}

	internal static bool Y8IQI3OVY8yjB8gYtV9(object object_0)
	{
		return true;
	}

	internal static void VYJOFNOMiXApjyrw2hs(object object_0)
	{
	}

	internal static void liJMTbOt9URGJGC170t()
	{
	}
}
