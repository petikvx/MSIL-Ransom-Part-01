using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DispatcherFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterfaceQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterfaceQueue()
	{
	}
}
