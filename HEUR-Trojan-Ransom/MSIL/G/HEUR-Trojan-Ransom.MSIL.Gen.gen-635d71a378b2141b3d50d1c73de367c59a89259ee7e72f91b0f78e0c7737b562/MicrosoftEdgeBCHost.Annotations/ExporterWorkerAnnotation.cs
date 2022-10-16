using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ExporterWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralDatabase()
	{
	}
}
