using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InterceptorWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PostLiteralListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostLiteralListener()
	{
	}
}
