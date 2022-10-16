using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ValFilterPolicy : Attribute, _003CModule_003E, ValFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
