using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PredicateBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteList()
	{
	}
}
