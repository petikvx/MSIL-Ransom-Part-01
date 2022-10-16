using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AnnotationValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SetupConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupConfiguration()
	{
	}
}
