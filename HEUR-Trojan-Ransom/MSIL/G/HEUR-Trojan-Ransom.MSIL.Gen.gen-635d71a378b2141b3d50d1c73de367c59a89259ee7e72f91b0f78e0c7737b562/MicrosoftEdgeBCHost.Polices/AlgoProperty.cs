using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AlgoProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoProperty()
	{
		WriterPropertyProducer.ResolveStub();
		SearchInterfaceCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchInterfaceCustomer()
	{
	}
}
