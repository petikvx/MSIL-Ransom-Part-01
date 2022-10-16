using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SingletonValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		NewCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewCandidate()
	{
	}
}
