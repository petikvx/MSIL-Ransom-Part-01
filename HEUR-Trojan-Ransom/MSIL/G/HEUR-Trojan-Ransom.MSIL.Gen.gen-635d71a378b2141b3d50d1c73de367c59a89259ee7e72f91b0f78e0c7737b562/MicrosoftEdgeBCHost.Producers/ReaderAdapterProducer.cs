using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ReaderAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectLiteralSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectLiteralSetter()
	{
	}
}
