using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ServiceWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfaceWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfaceWrapper()
	{
	}
}
