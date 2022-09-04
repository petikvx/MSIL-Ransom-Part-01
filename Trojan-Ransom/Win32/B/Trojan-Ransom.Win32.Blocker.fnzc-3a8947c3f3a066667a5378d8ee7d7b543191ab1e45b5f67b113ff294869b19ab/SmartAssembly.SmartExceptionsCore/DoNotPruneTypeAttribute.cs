using System;
using System.Security;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface)]
public sealed class DoNotPruneTypeAttribute : Attribute
{
	[SecuritySafeCritical]
	static DoNotPruneTypeAttribute()
	{
		Class32.smethod_1();
	}
}
