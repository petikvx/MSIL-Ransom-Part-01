using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class GetterFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PushPredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushPredicate()
	{
	}
}
