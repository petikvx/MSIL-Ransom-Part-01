using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ContainerBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		MoveSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveSingleton()
	{
	}
}
