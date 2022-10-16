using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class QueueRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		DefineMerchant();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineMerchant()
	{
	}
}
