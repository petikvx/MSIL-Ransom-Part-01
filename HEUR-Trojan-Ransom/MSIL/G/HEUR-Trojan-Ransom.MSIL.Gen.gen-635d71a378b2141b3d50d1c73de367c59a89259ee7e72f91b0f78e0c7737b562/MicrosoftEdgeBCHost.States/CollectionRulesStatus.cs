using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CollectionRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		MoveMerchant();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveMerchant()
	{
	}
}
