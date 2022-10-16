using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AnnotationValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CountThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountThread()
	{
	}
}
