using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SpecificationState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationState()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterfaceProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterfaceProperty()
	{
	}
}
