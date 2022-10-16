using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProccesorWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyLiteralProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyLiteralProducer()
	{
	}
}
