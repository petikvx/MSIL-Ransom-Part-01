using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ParameterWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeLiteralRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralRequest()
	{
	}
}
