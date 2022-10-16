using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ConnectionPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterfaceProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterfaceProcess()
	{
	}
}
