using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class Indexer : Attribute, _003CModule_003E, Indexer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Indexer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
