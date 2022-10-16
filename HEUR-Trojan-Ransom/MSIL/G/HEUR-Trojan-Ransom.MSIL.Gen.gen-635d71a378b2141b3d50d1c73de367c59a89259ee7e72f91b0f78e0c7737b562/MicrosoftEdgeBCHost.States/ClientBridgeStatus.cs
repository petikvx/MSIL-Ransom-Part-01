using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ClientBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		InsertCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertCallback()
	{
	}
}
