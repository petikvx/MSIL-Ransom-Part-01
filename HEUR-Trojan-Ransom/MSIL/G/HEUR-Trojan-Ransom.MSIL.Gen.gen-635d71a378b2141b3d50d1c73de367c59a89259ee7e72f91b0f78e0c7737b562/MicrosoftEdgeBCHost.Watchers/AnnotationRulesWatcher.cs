using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AnnotationRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeGetter()
	{
	}
}
