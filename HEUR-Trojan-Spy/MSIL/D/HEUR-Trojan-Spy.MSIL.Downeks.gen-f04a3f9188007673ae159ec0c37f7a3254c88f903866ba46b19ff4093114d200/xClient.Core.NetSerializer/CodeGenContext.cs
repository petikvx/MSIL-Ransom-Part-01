using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;

namespace xClient.Core.NetSerializer;

public sealed class CodeGenContext
{
	private readonly Dictionary<Type, TypeData> m_typeMap;

	private static CodeGenContext h7X4mjtnpMe8kguPPJ8;

	public MethodInfo SerializerSwitchMethodInfo
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public MethodInfo DeserializerSwitchMethodInfo
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public IDictionary<Type, TypeData> TypeMap => null;

	public CodeGenContext(Dictionary<Type, TypeData> typeMap)
	{
	}

	public MethodInfo GetWriterMethodInfo(Type type)
	{
		return null;
	}

	public MethodInfo GetReaderMethodInfo(Type type)
	{
		return null;
	}

	public bool IsGenerated(Type type)
	{
		return true;
	}

	private bool CanCallDirect(Type type)
	{
		return true;
	}

	public TypeData GetTypeData(Type type)
	{
		return null;
	}

	public TypeData GetTypeDataForCall(Type type)
	{
		return null;
	}

	static CodeGenContext()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}

	internal static bool fdPQqLtUwYoJCn9ihxp()
	{
		return true;
	}

	internal static CodeGenContext Uu1WqStLXZPuVs80oMg()
	{
		return null;
	}

	internal static bool BZL0SPtNrW3VerEQv0r(object object_0)
	{
		return true;
	}

	internal static Type kdB5GDtjPssZrLNfLYr(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return null;
	}
}
