using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class IteratorBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		NewIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewIterator()
	{
	}
}
