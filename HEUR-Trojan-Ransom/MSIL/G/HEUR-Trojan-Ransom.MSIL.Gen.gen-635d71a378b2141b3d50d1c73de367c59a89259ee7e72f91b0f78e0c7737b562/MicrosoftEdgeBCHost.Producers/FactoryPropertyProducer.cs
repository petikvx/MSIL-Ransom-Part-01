using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class FactoryPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralClass()
	{
	}
}
