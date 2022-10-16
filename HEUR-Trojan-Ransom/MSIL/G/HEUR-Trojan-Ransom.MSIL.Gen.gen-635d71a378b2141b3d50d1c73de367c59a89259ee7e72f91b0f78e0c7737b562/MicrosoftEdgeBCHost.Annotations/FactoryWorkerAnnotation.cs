using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class FactoryWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PostLiteralPrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostLiteralPrototype()
	{
	}
}
