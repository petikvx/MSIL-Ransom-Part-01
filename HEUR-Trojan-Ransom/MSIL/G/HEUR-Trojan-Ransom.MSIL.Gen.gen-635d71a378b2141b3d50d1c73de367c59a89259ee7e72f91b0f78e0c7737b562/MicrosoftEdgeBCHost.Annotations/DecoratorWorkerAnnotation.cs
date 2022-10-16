using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DecoratorWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		DisableLiteralToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableLiteralToken()
	{
	}
}
