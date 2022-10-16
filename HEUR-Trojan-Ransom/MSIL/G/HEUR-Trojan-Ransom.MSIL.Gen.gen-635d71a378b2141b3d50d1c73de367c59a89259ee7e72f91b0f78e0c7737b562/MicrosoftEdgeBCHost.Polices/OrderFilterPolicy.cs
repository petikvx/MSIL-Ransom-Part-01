using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class OrderFilterPolicy : Attribute, _003CModule_003E, OrderFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		MapError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapError()
	{
	}
}
