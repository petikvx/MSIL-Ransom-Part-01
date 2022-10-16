using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class EventBridgeAnnotation : Attribute, _003CModule_003E, EventBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
