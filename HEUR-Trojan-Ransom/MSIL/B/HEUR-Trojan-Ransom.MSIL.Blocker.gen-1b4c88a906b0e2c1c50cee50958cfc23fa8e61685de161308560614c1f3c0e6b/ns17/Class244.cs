using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Bson;
using ns10;

namespace ns17;

internal class Class244 : Class242, IEnumerable<Class242>, IEnumerable
{
	private readonly List<Class242> list_0 = new List<Class242>();

	public override BsonType Type => BsonType.Array;

	public void Add(Class242 token)
	{
		list_0.Add(token);
		token.Parent = this;
	}

	IEnumerator<Class242> IEnumerable<Class242>.GetEnumerator()
	{
		return list_0.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return System_002ECollections_002EGeneric_002EIEnumerable_003Cns10_002EClass242_003E_002EGetEnumerator();
	}
}
