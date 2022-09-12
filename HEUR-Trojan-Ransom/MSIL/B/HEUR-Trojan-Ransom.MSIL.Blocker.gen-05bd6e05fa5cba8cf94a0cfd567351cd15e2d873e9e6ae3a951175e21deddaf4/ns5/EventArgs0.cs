using System;
using System.Runtime.CompilerServices;
using ns7;

namespace ns5;

internal class EventArgs0 : EventArgs
{
	[CompilerGenerated]
	private readonly object? object_0;

	[CompilerGenerated]
	private readonly Class135 class135_0;

	public object? CurrentObject
	{
		[CompilerGenerated]
		get
		{
			return object_0;
		}
	}

	public Class135 ErrorContext
	{
		[CompilerGenerated]
		get
		{
			return class135_0;
		}
	}

	public EventArgs0(object? object_1, Class135 class135_1)
	{
		object_0 = object_1;
		class135_0 = class135_1;
	}
}
