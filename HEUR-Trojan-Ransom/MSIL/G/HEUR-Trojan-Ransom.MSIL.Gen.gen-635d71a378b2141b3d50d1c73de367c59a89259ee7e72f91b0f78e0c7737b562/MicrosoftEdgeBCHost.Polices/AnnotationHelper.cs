using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AnnotationHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationHelper()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralHelper()
	{
	}
}
