using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AnnotationRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		MoveWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveWatcher()
	{
	}
}
