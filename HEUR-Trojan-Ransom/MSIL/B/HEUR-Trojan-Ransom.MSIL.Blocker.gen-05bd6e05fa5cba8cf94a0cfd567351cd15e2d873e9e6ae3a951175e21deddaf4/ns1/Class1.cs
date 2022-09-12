using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ns1;

internal class Class1
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string string_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IList<string> ilist_0;

	public string Email
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	public bool Active
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

	public IList<string> Roles
	{
		[CompilerGenerated]
		get
		{
			return ilist_0;
		}
		[CompilerGenerated]
		set
		{
			ilist_0 = value;
		}
	}
}
