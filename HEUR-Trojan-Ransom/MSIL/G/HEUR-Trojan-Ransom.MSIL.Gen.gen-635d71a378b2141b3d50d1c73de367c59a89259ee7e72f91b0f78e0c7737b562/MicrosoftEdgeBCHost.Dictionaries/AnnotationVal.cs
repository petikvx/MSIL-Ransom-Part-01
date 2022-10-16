using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AnnotationVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationVal()
	{
		WriterPropertyProducer.ResolveStub();
		StopWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopWrapper()
	{
	}
}
