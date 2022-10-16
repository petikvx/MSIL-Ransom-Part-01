using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AnnotationFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PublishParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishParser()
	{
	}
}
