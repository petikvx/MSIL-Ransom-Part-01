using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ValFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfaceWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfaceWorker()
	{
	}
}
