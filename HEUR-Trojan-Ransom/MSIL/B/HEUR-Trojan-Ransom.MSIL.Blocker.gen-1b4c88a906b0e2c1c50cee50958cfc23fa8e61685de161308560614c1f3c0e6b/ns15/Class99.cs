using System;
using System.Runtime.CompilerServices;

namespace ns15;

internal class Class99
{
	[CompilerGenerated]
	private Type? type_0;

	[CompilerGenerated]
	private Func<object, object?>? func_0;

	[CompilerGenerated]
	private Action<object, object?>? action_0;

	public Type? MemberType
	{
		[CompilerGenerated]
		get
		{
			return type_0;
		}
		[CompilerGenerated]
		set
		{
			type_0 = value;
		}
	}

	public Func<object, object?>? Getter
	{
		[CompilerGenerated]
		get
		{
			return func_0;
		}
		[CompilerGenerated]
		set
		{
			func_0 = value;
		}
	}

	public Action<object, object?>? Setter
	{
		[CompilerGenerated]
		get
		{
			return action_0;
		}
		[CompilerGenerated]
		set
		{
			action_0 = value;
		}
	}
}
