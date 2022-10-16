using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TestsFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		AwakePredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakePredicate()
	{
	}
}
