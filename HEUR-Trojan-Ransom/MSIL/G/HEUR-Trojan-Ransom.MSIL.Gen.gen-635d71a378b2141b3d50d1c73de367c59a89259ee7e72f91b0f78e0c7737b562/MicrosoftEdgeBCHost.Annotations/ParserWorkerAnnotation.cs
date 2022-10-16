using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ParserWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		QueryLiteralFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryLiteralFacade()
	{
	}
}
