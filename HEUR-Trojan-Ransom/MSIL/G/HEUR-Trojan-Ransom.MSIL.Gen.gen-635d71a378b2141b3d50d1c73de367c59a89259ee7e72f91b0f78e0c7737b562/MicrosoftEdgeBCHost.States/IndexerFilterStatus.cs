using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class IndexerFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ResetInterfaceReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetInterfaceReader()
	{
	}
}
