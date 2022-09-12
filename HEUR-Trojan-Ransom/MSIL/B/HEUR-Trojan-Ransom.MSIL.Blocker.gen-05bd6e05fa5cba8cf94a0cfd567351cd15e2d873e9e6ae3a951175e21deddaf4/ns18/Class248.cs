using System.Runtime.CompilerServices;
using Newtonsoft.Json.Bson;
using ns8;

namespace ns18;

internal class Class248 : Class246
{
	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private readonly bool bool_0;

	public int ByteCount
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
		[CompilerGenerated]
		set
		{
			int_1 = value;
		}
	}

	public bool IncludeLength
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
	}

	public Class248(object object_1, bool bool_1)
		: base(object_1, BsonType.String)
	{
		bool_0 = bool_1;
	}
}
