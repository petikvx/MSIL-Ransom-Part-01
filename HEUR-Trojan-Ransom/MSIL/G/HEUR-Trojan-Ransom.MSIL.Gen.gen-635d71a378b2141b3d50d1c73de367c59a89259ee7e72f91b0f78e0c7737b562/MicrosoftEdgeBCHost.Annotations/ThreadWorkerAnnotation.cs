using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ThreadWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ViewLiteralSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewLiteralSchema()
	{
	}
}
