using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ComparatorWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeInterfaceDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeInterfaceDispatcher()
	{
	}
}
