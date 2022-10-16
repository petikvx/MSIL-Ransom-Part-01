using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TestsFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		GetInterfaceConnection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetInterfaceConnection()
	{
	}
}
