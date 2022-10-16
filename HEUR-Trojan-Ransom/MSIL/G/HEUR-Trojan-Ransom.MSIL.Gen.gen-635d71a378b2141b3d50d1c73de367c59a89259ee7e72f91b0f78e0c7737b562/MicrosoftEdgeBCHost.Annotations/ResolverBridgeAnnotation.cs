using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ResolverBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyParser()
	{
	}
}
