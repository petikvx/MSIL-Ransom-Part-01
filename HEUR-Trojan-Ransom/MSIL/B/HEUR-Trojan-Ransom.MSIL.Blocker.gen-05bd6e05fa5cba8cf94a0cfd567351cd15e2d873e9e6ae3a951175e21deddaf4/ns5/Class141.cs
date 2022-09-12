using System;
using System.Runtime.CompilerServices;
using ns0;
using ns10;
using ns11;
using ns2;

namespace ns5;

internal class Class141 : Class138
{
	[CompilerGenerated]
	private readonly Class150 class150_0;

	[CompilerGenerated]
	private Func<string, string>? func_1;

	internal readonly Class111<string, CallSite<Func<CallSite, object, object>>> class111_0 = new Class111<string, CallSite<Func<CallSite, object, object>>>((Func<string, CallSite<Func<CallSite, object, object>>>)Class4.smethod_164);

	internal readonly Class111<string, CallSite<Func<CallSite, object, object?, object>>> class111_1 = new Class111<string, CallSite<Func<CallSite, object, object, object>>>((Func<string, CallSite<Func<CallSite, object, object, object>>>)Class4.smethod_698);

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
