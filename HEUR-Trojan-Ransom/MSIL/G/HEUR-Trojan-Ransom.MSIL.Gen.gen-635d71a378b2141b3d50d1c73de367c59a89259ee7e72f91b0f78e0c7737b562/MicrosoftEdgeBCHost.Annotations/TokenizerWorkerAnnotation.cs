using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TokenizerWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ResetLiteralProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetLiteralProxy()
	{
	}
}
