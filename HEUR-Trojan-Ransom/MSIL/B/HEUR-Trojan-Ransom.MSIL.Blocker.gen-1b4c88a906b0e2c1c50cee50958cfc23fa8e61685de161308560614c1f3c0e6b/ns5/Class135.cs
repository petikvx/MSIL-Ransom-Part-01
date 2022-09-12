using System;
using System.Runtime.CompilerServices;

namespace ns5;

internal class Class135
{
	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private readonly Exception exception_0;

	[CompilerGenerated]
	private readonly object? object_0;

	[CompilerGenerated]
	private readonly object? object_1;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private bool bool_1;

	internal bool Traced
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

	public Exception Error
	{
		[CompilerGenerated]
		get
		{
			return exception_0;
		}
	}

	public object? OriginalObject
	{
		[CompilerGenerated]
		get
		{
			return object_0;
		}
	}

	public object? Member
	{
		[CompilerGenerated]
		get
		{
			return object_1;
		}
	}

	public string Path
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public bool Handled
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		set
		{
			bool_1 = value;
		}
	}

	internal Class135(object? object_2, object? object_3, string string_1, Exception exception_1)
	{
		object_0 = object_2;
		object_1 = object_3;
		exception_0 = exception_1;
		string_0 = string_1;
	}
}
