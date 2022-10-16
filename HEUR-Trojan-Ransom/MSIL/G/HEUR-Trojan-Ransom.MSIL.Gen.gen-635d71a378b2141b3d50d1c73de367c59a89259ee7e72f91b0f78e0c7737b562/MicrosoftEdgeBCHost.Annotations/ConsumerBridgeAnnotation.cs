using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ConsumerBridgeAnnotation : Attribute, _003CModule_003E, ConsumerBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		DefineError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineError()
	{
	}
}
