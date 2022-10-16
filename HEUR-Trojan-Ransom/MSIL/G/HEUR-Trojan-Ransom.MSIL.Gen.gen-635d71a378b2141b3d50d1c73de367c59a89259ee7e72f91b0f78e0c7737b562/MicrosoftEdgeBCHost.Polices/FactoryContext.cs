using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class FactoryContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryContext()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfacePredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfacePredicate()
	{
	}
}
