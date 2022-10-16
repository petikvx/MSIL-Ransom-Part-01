using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PredicateFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SetupPublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupPublisher()
	{
	}
}
