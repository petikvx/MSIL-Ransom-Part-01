using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class BridgeWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeLiteralCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeLiteralCode()
	{
	}
}
