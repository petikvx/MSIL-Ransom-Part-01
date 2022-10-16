using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class Broadcaster : Attribute, _003CModule_003E, Broadcaster
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Broadcaster()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
