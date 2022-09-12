using System;
using System.Runtime.CompilerServices;
using ns1;
using ns13;
using ns19;
using ns2;
using ns4;

namespace ns17;

internal class Class141 : Class138
{
	[CompilerGenerated]
	private readonly Class150 class150_0;

	[CompilerGenerated]
	private Func<string, string>? func_1;

	internal readonly Class110<string, CallSite<Func<CallSite, object, object>>> class110_0 = new Class110<string, CallSite<Func<CallSite, object, object>>>((Func<string, CallSite<Func<CallSite, object, object>>>)Class131.smethod_179);

	internal readonly Class110<string, CallSite<Func<CallSite, object, object?, object>>> class110_1 = new Class110<string, CallSite<Func<CallSite, object, object, object>>>((Func<string, CallSite<Func<CallSite, object, object, object>>>)Class131.smethod_710);

	public Class150 Properties
	{
		[CompilerGenerated]
		get
		{
			return class150_0;
		}
	}

	public Func<string, string>? PropertyNameResolver
	{
		[CompilerGenerated]
		get
		{
			return func_1;
		}
		[CompilerGenerated]
		set
		{
			func_1 = value;
		}
	}

	public Class141(Type type_3)
		: base(type_3)
	{
		enum26_0 = Enum26.const_6;
		class150_0 = new Class150(base.UnderlyingType);
	}
}
