using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AnnotationClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationClass()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfaceReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfaceReponse()
	{
	}
}
