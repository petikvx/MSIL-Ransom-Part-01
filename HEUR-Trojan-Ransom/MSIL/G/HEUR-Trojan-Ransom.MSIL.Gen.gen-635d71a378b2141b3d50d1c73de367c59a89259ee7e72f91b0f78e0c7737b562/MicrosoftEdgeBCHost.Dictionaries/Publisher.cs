using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class Publisher : Attribute, _003CModule_003E, Publisher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Publisher()
	{
		WriterPropertyProducer.ResolveStub();
		QueryObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryObject()
	{
	}
}
