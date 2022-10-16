using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AnnotationWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteInterfaceAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteInterfaceAdvisor()
	{
	}
}
