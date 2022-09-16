using System;
using System.Collections.Generic;
using System.IO;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;
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

	internal static Serializer hWUT2xEe7oyaSBlt9bj;

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
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.eY41D0ozvTIAj();
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

	internal static void xGqftZEKSNmarbsTHMH(object object_0, object object_1, object object_2, object object_3)
	{
	}

	internal static bool VOOTfNE2GgSPt6g4UGw()
	{
		return true;
	}

	internal static Serializer I54BUYE0PD0lRvTVymw()
	{
		return null;
	}

	internal static object lceOJuEBT71EpJQV7x5(int int_0)
	{
		return null;
	}
}
