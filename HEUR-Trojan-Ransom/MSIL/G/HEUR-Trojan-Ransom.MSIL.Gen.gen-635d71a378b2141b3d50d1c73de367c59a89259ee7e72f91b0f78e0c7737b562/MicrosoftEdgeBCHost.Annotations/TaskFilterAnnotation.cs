using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TaskFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfaceQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfaceQueue()
	{
	}
}
