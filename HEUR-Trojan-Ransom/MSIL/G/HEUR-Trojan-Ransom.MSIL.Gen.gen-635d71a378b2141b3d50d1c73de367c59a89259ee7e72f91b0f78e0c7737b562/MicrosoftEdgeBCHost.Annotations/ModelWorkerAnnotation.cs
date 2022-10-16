using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ModelWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		EnableLiteralStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableLiteralStrategy()
	{
	}
}
