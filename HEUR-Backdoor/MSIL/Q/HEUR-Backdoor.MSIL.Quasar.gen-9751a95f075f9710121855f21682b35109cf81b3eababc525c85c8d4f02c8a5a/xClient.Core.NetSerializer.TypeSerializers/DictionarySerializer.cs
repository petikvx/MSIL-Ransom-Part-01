using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace xClient.Core.NetSerializer.TypeSerializers;

public class DictionarySerializer : ITypeSerializer, IStaticTypeSerializer
{
	public bool Handles(Type type)
	{
		if (!type.IsGenericType)
		{
			return false;
		}
		return type.GetGenericTypeDefinition() == typeof(Dictionary<, >);
	}

	public IEnumerable<Type> GetSubtypes(Type type)
	{
		Type[] genericArguments = type.GetGenericArguments();
		yield return typeof(KeyValuePair<, >).MakeGenericType(genericArguments).MakeArrayType();
	}

	public void GetStaticMethods(Type type, out MethodInfo writer, out MethodInfo reader)
	{
		if (!type.IsGenericType)
		{
			throw new Exception();
		}
		Type genericTypeDefinition = type.GetGenericTypeDefinition();
		Type type2 = GetType();
		writer = GetGenWriter(type2, genericTypeDefinition);
		reader = GetGenReader(type2, genericTypeDefinition);
		Type[] genericArguments = type.GetGenericArguments();
		writer = writer.MakeGenericMethod(genericArguments);
		reader = reader.MakeGenericMethod(genericArguments);
	}

	private static MethodInfo GetGenWriter(Type containerType, Type genType)
	{
		foreach (MethodInfo item in from mi in containerType.GetMethods(BindingFlags.Static | BindingFlags.Public)
			where mi.IsGenericMethod && mi.Name == "WritePrimitive"
			select mi)
		{
			ParameterInfo[] parameters = item.GetParameters();
			if (parameters.Length != 3 || parameters[1].ParameterType != typeof(Stream))
			{
				continue;
			}
			Type parameterType = parameters[2].ParameterType;
			if (parameterType.IsGenericType)
			{
				Type genericTypeDefinition = parameterType.GetGenericTypeDefinition();
				if (genType == genericTypeDefinition)
				{
					return item;
				}
			}
		}
		return null;
	}

	private static MethodInfo GetGenReader(Type containerType, Type genType)
	{
		foreach (MethodInfo item in from mi in containerType.GetMethods(BindingFlags.Static | BindingFlags.Public)
			where mi.IsGenericMethod && mi.Name == "ReadPrimitive"
			select mi)
		{
			ParameterInfo[] parameters = item.GetParameters();
			if (parameters.Length != 3 || parameters[1].ParameterType != typeof(Stream))
			{
				continue;
			}
			Type parameterType = parameters[2].ParameterType;
			if (!parameterType.IsByRef)
			{
				continue;
			}
			parameterType = parameterType.GetElementType();
			if (parameterType.IsGenericType)
			{
				Type genericTypeDefinition = parameterType.GetGenericTypeDefinition();
				if (genType == genericTypeDefinition)
				{
					return item;
				}
			}
		}
		return null;
	}

	public static void WritePrimitive<TKey, TValue>(Serializer serializer, Stream stream, Dictionary<TKey, TValue> value)
	{
		KeyValuePair<TKey, TValue>[] array = new KeyValuePair<TKey, TValue>[value.Count];
		int num = 0;
		foreach (KeyValuePair<TKey, TValue> item in value)
		{
			array[num++] = item;
		}
		serializer.Serialize(stream, array);
	}

	public static void ReadPrimitive<TKey, TValue>(Serializer serializer, Stream stream, out Dictionary<TKey, TValue> value)
	{
		KeyValuePair<TKey, TValue>[] array = (KeyValuePair<TKey, TValue>[])serializer.Deserialize(stream);
		value = new Dictionary<TKey, TValue>(array.Length);
		KeyValuePair<TKey, TValue>[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			KeyValuePair<TKey, TValue> keyValuePair = array2[i];
			value.Add(keyValuePair.Key, keyValuePair.Value);
		}
	}
}
