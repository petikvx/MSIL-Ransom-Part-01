using System.Runtime.CompilerServices;
using Newtonsoft.Json.Bson;
using ns17;
using ns18;

namespace ns7;

internal class Class250 : Class242
{
	[CompilerGenerated]
	private Class248 class248_0;

	[CompilerGenerated]
	private Class248 class248_1;

	public Class248 Pattern
	{
		[CompilerGenerated]
		get
		{
			return class248_0;
		}
		[CompilerGenerated]
		set
		{
			class248_0 = value;
		}
	}

	public Class248 Options
	{
		[CompilerGenerated]
		get
		{
			return class248_1;
		}
		[CompilerGenerated]
		set
		{
			class248_1 = value;
		}
	}

	public override BsonType Type => BsonType.Regex;

	public Class250(string string_0, string string_1)
	{
		Pattern = new Class248(string_0, bool_1: false);
		Options = new Class248(string_1, bool_1: false);
	}
}
