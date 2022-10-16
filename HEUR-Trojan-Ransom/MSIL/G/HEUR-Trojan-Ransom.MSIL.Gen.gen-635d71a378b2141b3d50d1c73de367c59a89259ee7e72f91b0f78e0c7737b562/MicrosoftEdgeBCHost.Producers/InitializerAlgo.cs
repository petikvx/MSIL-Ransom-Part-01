using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InitializerAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		CollectLiteralConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectLiteralConfiguration()
	{
	}
}
