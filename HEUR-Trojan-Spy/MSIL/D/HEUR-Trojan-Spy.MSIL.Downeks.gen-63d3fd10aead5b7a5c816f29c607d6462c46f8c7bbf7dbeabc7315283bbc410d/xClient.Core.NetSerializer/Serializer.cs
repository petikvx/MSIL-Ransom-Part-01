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

	internal static Serializer PfunrMmgHhOY6WssDdC;

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
		QSR5kwmsYIhltqPWa63();
		yCQsHumJSR6d6pZuB5i();
		Wl1vqHmG52WApOKCeFx();
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

	internal static void qRByupmmhXqfYBuwcAy(object object_0, object object_1, object object_2, object object_3)
	{
	}

	internal static bool yBE0y9mF7Te5rlAvQoI()
	{
		return true;
	}

	internal static Serializer W7GLCLmUNQwY6b9VehY()
	{
		return null;
	}

	internal static object EpJIEAm3BffIBVPsKtS(int int_0)
	{
		return null;
	}

	internal static object XSVqPMmcBypWUPOnKdB(object object_0, object object_1)
	{
		return null;
	}

	internal static void QSR5kwmsYIhltqPWa63()
	{
	}

	internal static void yCQsHumJSR6d6pZuB5i()
	{
	}

	internal static void Wl1vqHmG52WApOKCeFx()
	{
	}
}
