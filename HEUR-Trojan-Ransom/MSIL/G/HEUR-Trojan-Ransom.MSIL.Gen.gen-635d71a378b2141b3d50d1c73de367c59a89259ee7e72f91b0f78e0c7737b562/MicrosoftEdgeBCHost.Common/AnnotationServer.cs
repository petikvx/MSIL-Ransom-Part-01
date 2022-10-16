using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AnnotationServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationServer()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralClient()
	{
	}
}
