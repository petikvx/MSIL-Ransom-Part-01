using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ComparatorBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		InsertProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertProperty()
	{
	}
}
