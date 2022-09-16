using System;
using System.Collections.Generic;
using System.IO;
using dg3ypDAonQcOidMs0w;
using xClient.Core.NetSerializer.TypeSerializers;

namespace xClient.Core.NetSerializer;

public class Serializer
{
	private delegate void SerializerSwitch(Serializer serializer, Stream stream, object ob);

	private delegate void DeserializerSwitch(Serializer serializer, Stream stream, out object ob);

	private Dictionary<Type, ushort> m_typeIDMap;

	private SerializerSwitch m_serializerSwitch;

	private DeserializerSwitch m_deserializerSwitch;

	private static ITypeSerializer[] s_typeSerializers;

	private ITypeSerializer[] m_userTypeSerializers;

	private static Serializer FbC2yGfpDeUMWLa50iP;

	public Serializer(IEnumerable<Type> rootTypes)
	{
	}

	public Serializer(IEnumerable<Type> rootTypes, ITypeSerializer[] userTypeSerializers)
	{
	}

	public void Serialize(Stream stream, object data)
	{
	}

	public object Deserialize(Stream stream)
	{
		return null;
	}

	private Dictionary<Type, TypeData> GenerateTypeData(IEnumerable<Type> rootTypes)
	{
		return null;
	}

	private void GenerateDynamic(Dictionary<Type, TypeData> map)
	{
	}

	private ushort GetTypeID(object ob)
	{
		return 0;
	}

	static Serializer()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		MrHXrqfl7DuSKdGaJC7();
		l2WjvcfgpijdJq1cs84();
		rjFEXKfatDEDSVs0bV9();
		s_typeSerializers = new ITypeSerializer[6]
		{
			new ObjectSerializer(),
			new PrimitivesSerializer(),
			new ArraySerializer(),
			new EnumSerializer(),
			new DictionarySerializer(),
			new GenericSerializer()
		};
	}

	internal static void LBfP6lfYnmprkKn35FN(object object_0, object object_1, object object_2, object object_3)
	{
	}

	internal static bool GmVPJZfVYwVm4v6AW2T()
	{
		return true;
	}

	internal static Serializer dlcDmjfk8NfE9pNc0IA()
	{
		return null;
	}

	internal static object L79A0MfF56xR2xyVXtb(object object_0, object object_1)
	{
		return null;
	}

	internal static void MrHXrqfl7DuSKdGaJC7()
	{
	}

	internal static void l2WjvcfgpijdJq1cs84()
	{
	}

	internal static void rjFEXKfatDEDSVs0bV9()
	{
	}
}
