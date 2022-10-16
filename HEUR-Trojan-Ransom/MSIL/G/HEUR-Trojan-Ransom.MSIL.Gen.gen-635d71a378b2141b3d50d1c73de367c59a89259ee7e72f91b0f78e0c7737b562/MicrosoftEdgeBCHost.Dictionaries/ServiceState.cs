using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ServiceState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceState()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfaceProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfaceProxy()
	{
	}
}
