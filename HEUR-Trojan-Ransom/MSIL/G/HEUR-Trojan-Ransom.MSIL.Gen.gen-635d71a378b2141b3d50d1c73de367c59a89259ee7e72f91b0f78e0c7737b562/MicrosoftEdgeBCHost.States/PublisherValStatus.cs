using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PublisherValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		StopLiteralService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopLiteralService()
	{
	}
}
