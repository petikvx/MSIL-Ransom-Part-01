using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class OrderFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PostInterfaceWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostInterfaceWorker()
	{
	}
}
