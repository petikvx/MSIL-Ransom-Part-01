using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class BroadcasterFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfaceToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfaceToken()
	{
	}
}
