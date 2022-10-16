using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class CodeBridgeAnnotation : Attribute, _003CModule_003E, CodeBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		RateFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateFactory()
	{
	}
}
