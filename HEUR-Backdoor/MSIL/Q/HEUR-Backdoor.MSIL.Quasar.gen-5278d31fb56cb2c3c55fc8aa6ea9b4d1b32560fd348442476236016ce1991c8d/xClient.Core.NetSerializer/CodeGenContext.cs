using System;
using System.Collections.Generic;
using System.Reflection;

namespace xClient.Core.NetSerializer;

public sealed class CodeGenContext
{
	private readonly Dictionary<Type, TypeData> m_typeMap;

	public MethodInfo SerializerSwitchMethodInfo { get; private set; }

	public MethodInfo DeserializerSwitchMethodInfo { get; private set; }

	public IDictionary<Type, TypeData> TypeMap => m_typeMap;

	public CodeGenContext(Dictionary<Type, TypeData> typeMap)
	{
		m_typeMap = typeMap;
		TypeData typeData = m_typeMap[typeof(object)];
		SerializerSwitchMethodInfo = typeData.WriterMethodInfo;
		DeserializerSwitchMethodInfo = typeData.ReaderMethodInfo;
	}

	public MethodInfo GetWriterMethodInfo(Type type)
	{
		return m_typeMap[type].WriterMethodInfo;
	}

	public MethodInfo GetReaderMethodInfo(Type type)
	{
		return m_typeMap[type].ReaderMethodInfo;
	}

	public bool IsGenerated(Type type)
	{
		return m_typeMap[type].IsGenerated;
	}

	private bool CanCallDirect(Type type)
	{
		if (type.IsValueType || type.IsArray)
		{
			return true;
		}
		if (type.IsSealed && !IsGenerated(type))
		{
			return true;
		}
		return false;
	}

	public TypeData GetTypeData(Type type)
	{
		return m_typeMap[type];
	}

	public TypeData GetTypeDataForCall(Type type)
	{
		if (!CanCallDirect(type))
		{
			type = typeof(object);
		}
		return GetTypeData(type);
	}
}
