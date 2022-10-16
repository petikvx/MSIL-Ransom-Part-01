using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class StubState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubState()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareInterfaceResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareInterfaceResolver()
	{
	}
}
