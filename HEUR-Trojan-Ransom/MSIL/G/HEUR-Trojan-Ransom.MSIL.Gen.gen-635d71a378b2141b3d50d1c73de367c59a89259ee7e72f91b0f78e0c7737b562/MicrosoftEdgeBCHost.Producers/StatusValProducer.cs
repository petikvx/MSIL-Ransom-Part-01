using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class StatusValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ManageDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageDispatcher()
	{
	}
}
