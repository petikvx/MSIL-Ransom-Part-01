using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TestsAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		VisitInterfaceMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitInterfaceMapping()
	{
	}
}
