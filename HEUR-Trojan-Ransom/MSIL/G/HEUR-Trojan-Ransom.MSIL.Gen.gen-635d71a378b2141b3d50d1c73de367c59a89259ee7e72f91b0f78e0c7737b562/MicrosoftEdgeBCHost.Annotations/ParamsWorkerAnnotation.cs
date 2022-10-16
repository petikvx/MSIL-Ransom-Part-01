using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ParamsWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PrintLiteralIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintLiteralIndexer()
	{
	}
}
