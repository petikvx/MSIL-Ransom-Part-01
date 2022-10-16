using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ExporterFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectInterfaceServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectInterfaceServer()
	{
	}
}
