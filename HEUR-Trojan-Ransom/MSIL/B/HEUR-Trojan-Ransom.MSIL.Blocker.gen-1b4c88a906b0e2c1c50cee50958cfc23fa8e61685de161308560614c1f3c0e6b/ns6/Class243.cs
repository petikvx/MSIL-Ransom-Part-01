using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Bson;
using ns10;
using ns8;

namespace ns6;

internal class Class243 : Class242, IEnumerable<Class251>, IEnumerable
{
	internal readonly List<Class251> list_0 = new List<Class251>();

	public override BsonType Type => BsonType.Object;

	IEnumerator<Class251> IEnumerable<Class251>.GetEnumerator()
	{
		return list_0.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return System_002ECollections_002EGeneric_002EIEnumerable_003Cns8_002EClass251_003E_002EGetEnumerator();
	}
}
