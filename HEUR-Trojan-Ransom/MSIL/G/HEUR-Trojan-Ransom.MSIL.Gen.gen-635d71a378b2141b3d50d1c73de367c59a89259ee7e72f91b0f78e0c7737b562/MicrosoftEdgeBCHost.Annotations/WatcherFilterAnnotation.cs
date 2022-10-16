using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class WatcherFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyInterfaceRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyInterfaceRecord()
	{
	}
}
