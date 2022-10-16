using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AnnotationFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotInterpreter()
	{
	}
}
