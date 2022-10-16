using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CreatorRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PublishConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishConsumer()
	{
	}
}
