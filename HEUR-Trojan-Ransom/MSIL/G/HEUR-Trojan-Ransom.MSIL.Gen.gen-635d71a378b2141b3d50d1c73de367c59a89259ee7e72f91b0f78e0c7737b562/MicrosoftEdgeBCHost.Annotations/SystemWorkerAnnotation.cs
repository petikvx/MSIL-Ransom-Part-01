using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class SystemWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		QueryLiteralModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryLiteralModel()
	{
	}
}
