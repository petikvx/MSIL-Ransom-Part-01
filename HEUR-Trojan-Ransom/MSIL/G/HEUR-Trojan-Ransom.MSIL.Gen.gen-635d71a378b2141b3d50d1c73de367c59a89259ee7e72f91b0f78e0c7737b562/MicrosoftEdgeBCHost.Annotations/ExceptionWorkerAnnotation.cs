using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ExceptionWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PatchLiteralMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchLiteralMap()
	{
	}
}
