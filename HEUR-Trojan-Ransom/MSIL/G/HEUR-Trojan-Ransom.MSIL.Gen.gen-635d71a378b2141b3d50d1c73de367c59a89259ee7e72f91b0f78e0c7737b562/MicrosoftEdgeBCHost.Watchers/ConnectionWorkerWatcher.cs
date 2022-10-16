using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ConnectionWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CallInterfaceSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInterfaceSpecification()
	{
	}
}
