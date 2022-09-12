using Newtonsoft.Json.Bson;
using ns10;

namespace ns5;

internal class Class246 : Class242
{
	internal readonly object object_0;

	private readonly BsonType bsonType_0;

	public object Value => object_0;

	public override BsonType Type => bsonType_0;

	public Class246(object object_1, BsonType bsonType_1)
	{
		object_0 = object_1;
		bsonType_0 = bsonType_1;
	}
}
