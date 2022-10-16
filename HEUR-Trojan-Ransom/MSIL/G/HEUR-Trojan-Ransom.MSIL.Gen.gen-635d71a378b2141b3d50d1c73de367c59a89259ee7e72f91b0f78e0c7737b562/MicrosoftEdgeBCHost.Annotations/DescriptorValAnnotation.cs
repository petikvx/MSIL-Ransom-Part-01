using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DescriptorValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeInterfaceRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeInterfaceRule()
	{
	}
}
