using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ImporterOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CollectInterfaceInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectInterfaceInvocation()
	{
	}
}
