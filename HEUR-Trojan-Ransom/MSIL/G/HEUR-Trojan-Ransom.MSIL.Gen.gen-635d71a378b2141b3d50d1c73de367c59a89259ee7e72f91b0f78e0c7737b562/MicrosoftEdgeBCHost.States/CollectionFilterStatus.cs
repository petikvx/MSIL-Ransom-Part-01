using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CollectionFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfaceWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfaceWatcher()
	{
	}
}
