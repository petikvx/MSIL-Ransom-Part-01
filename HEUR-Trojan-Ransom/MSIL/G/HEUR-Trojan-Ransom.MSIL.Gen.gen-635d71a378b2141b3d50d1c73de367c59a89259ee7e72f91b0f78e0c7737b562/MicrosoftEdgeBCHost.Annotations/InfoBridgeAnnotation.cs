using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InfoBridgeAnnotation : Attribute, _003CModule_003E, InfoBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
