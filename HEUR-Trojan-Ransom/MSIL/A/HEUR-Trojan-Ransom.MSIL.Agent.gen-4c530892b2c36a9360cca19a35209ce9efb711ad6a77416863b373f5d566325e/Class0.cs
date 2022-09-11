using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

internal class Class0
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Class5 class5_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private List<Class5> list_0;

	public Class5 Class5_0
	{
		[CompilerGenerated]
		get
		{
			return class5_0;
		}
		[CompilerGenerated]
		private set
		{
			class5_0 = value;
		}
	}

	public List<Class5> List_0
	{
		[CompilerGenerated]
		get
		{
			return list_0;
		}
		[CompilerGenerated]
		private set
		{
			list_0 = value;
		}
	}

	public Class0()
	{
		Class5_0 = new Class5(30, 0);
		List_0 = new List<Class5>();
		List_0.Add(new Class5(29, 0));
	}

	public void method_0()
	{
		foreach (Class5 item in List_0)
		{
			_ = item;
		}
	}
}
