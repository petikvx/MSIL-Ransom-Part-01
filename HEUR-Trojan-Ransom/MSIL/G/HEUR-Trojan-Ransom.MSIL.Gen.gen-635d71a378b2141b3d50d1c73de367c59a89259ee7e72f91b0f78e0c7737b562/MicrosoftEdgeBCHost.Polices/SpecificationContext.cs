using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SpecificationContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationContext()
	{
		WriterPropertyProducer.ResolveStub();
		FlushInterfaceContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushInterfaceContainer()
	{
	}
}
