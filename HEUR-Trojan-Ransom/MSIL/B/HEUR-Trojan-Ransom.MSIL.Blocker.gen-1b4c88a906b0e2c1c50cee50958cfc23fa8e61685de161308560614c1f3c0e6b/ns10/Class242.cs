using System.Runtime.CompilerServices;
using Newtonsoft.Json.Bson;

namespace ns10;

internal abstract class Class242
{
	[CompilerGenerated]
	private Class242 class242_0;

	[CompilerGenerated]
	private int int_0;

	public abstract BsonType Type { get; }

	public Class242 Parent
	{
		[CompilerGenerated]
		get
		{
			return class242_0;
		}
		[CompilerGenerated]
		set
		{
			class242_0 = value;
		}
	}

	public int CalculatedSize
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int_0 = value;
		}
	}
}
