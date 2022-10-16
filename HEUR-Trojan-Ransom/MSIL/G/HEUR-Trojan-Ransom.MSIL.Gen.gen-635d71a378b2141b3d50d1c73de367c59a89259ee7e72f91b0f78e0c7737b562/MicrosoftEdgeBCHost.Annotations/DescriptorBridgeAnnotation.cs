using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DescriptorBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		FillState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillState()
	{
	}
}
