using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ConnectionProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionProperty()
	{
		WriterPropertyProducer.ResolveStub();
		RevertInterfaceAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertInterfaceAlgo()
	{
	}
}
