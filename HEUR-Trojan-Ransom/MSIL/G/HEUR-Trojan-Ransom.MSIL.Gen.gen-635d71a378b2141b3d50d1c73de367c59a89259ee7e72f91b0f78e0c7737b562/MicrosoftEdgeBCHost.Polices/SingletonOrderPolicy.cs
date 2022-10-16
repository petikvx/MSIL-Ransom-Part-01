using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SingletonOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeLiteralState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeLiteralState()
	{
	}
}
