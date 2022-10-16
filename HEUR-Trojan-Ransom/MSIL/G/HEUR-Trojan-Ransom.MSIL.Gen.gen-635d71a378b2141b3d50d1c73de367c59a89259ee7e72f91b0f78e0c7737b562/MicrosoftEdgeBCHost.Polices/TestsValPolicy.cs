using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TestsValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterInterfaceBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterInterfaceBroadcaster()
	{
	}
}
