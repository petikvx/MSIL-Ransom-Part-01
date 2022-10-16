using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ListenerFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyInterfaceAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyInterfaceAdapter()
	{
	}
}
