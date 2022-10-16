using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SpecificationProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationProperty()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateInterfaceBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInterfaceBroadcaster()
	{
	}
}
