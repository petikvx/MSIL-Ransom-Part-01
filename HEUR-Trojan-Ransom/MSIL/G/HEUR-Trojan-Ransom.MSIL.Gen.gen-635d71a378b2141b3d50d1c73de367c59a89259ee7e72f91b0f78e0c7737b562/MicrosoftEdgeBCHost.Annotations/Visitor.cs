using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class Visitor : Attribute, _003CModule_003E, Visitor
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Visitor()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
