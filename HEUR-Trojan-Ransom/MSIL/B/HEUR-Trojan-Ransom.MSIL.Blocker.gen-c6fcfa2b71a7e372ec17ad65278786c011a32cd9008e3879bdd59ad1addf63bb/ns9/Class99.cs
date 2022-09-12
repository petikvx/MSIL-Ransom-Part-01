using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns0;
using ns5;
using ns7;

namespace ns9;

internal class Class99
{
	[CompilerGenerated]
	internal sealed class Class100
	{
		public Func<object> func_0;

		internal object method_0(object?[] object_0)
		{
			return func_0();
		}
	}

	[CompilerGenerated]
	internal sealed class Class101
	{
		public Delegate1<object, object?> delegate1_0;

		internal object? method_0(object object_0)
		{
			return delegate1_0(object_0);
		}
	}

	[CompilerGenerated]
	internal sealed class Class102
	{
		public Delegate1<object, object?> delegate1_0;

		internal void method_0(object object_0, object? object_1)
		{
			delegate1_0(object_0, object_1);
		}
	}

	[CompilerGenerated]
	private readonly Delegate7<object>? delegate7_0;

	[CompilerGenerated]
	private readonly IDictionary<string, Class98> idictionary_0;

	public Delegate7<object>? Creator
	{
		[CompilerGenerated]
		get
		{
			return delegate7_0;
		}
	}

	public IDictionary<string, Class98> Members
	{
		[CompilerGenerated]
		get
		{
			return idictionary_0;
		}
	}

	internal Class99(Delegate7<object>? delegate7_1)
	{
		idictionary_0 = new Dictionary<string, Class98>();
		delegate7_0 = delegate7_1;
	}
}
