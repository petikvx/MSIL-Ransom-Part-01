using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ContainerWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceSingleton()
	{
	}
}
