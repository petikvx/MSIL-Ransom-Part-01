using System.Runtime.CompilerServices;
using Newtonsoft.Json.Bson;
using ns11;

namespace ns7;

internal class Class245 : Class242
{
	public static readonly Class242 class242_1 = new Class245(BsonType.Null);

	public static readonly Class242 class242_2 = new Class245(BsonType.Undefined);

	[CompilerGenerated]
	private readonly BsonType bsonType_0;

	public override BsonType Type
	{
		[CompilerGenerated]
		get
		{
			return bsonType_0;
		}
	}

	private Class245(BsonType bsonType_1)
	{
		bsonType_0 = bsonType_1;
	}
}
