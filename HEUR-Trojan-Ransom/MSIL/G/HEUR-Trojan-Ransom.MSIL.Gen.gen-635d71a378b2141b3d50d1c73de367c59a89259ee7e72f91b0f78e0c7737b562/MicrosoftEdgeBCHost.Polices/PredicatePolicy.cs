using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PredicatePolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicatePolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareInterfaceHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareInterfaceHelper()
	{
	}
}
