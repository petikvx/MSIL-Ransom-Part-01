using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DicFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CountInterfaceGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountInterfaceGetter()
	{
	}
}
