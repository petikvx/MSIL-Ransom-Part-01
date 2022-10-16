using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PredicateFilterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateFilterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CreateCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateCustomer()
	{
	}
}
