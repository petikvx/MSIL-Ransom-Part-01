using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InitializerWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		CallState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallState()
	{
	}
}
