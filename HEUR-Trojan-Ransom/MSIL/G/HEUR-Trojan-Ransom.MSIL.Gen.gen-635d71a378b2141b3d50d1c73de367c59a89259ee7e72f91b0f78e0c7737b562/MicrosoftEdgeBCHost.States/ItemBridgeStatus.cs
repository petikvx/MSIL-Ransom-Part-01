using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ItemBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		InsertThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertThread()
	{
	}
}
