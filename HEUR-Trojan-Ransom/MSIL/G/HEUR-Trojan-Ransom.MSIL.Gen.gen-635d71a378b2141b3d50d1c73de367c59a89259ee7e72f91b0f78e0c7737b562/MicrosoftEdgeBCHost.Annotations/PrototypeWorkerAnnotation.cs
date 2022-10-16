using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PrototypeWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeLiteralDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralDispatcher()
	{
	}
}
