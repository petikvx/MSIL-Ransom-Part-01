using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class StateValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		RunService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunService()
	{
	}
}
