using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ManagerValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfaceAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfaceAlgo()
	{
	}
}
