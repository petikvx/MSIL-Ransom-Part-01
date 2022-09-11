using System;
using System.Runtime.CompilerServices;
using ns20;

namespace ns13;

internal sealed class EventArgs4 : EventArgs3
{
	[CompilerGenerated]
	private readonly Exception exception_0;

	[CompilerGenerated]
	private bool bool_0;

	public Exception Exception
	{
		[CompilerGenerated]
		get
		{
			return exception_0;
		}
	}

	public bool Ignore
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	public EventArgs4(Exception exception_1)
	{
		exception_0 = exception_1;
	}
}
