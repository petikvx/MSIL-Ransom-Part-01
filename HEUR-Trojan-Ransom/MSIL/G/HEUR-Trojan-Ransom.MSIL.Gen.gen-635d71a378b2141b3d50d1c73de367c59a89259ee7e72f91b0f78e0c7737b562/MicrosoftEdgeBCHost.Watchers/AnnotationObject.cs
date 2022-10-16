using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AnnotationObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationObject()
	{
		WriterPropertyProducer.ResolveStub();
		RunLiteralParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunLiteralParams()
	{
	}
}
