using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class QueueFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfaceAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfaceAlgo()
	{
	}
}
