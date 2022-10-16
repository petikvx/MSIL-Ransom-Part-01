using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class SpecificationBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotMapping()
	{
	}
}
