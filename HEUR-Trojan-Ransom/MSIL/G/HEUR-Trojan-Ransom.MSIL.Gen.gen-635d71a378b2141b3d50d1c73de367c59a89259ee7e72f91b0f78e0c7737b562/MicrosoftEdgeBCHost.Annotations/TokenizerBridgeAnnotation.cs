using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TokenizerBridgeAnnotation : Attribute, _003CModule_003E, TokenizerBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InsertIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertIssuer()
	{
	}
}
