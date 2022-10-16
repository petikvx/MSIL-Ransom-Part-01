using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AnnotationValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfaceMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfaceMapper()
	{
	}
}
