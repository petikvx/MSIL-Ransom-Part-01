using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ConnectionOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfaceObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfaceObserver()
	{
	}
}
