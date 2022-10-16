using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PropertyFilterPolicy : Attribute, _003CModule_003E, PropertyFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeInstance()
	{
	}
}
