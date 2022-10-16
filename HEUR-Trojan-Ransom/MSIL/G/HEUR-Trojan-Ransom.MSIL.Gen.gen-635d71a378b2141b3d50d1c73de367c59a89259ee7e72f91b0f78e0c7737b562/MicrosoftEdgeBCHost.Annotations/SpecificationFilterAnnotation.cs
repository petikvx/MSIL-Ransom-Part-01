using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class SpecificationFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CountInterfaceDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountInterfaceDefinition()
	{
	}
}
