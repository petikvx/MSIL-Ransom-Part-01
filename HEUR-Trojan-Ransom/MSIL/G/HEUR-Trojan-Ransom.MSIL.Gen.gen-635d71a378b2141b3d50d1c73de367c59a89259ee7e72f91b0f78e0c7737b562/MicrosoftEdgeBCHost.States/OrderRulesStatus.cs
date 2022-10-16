using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class OrderRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CollectReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectReponse()
	{
	}
}
