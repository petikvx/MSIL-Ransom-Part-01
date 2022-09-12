using System.Runtime.CompilerServices;
using Newtonsoft.Json.Bson;
using ns1;

namespace ns10;

internal class Class249 : Class246
{
	[CompilerGenerated]
	private Enum34 enum34_0;

	public Enum34 BinaryType
	{
		[CompilerGenerated]
		get
		{
			return enum34_0;
		}
		[CompilerGenerated]
		set
		{
			enum34_0 = value;
		}
	}

	public Class249(byte[] byte_0, Enum34 enum34_1)
		: base(byte_0, BsonType.Binary)
	{
		BinaryType = enum34_1;
	}
}
