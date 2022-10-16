using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ConnectionWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateInterfaceVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateInterfaceVal()
	{
	}
}
