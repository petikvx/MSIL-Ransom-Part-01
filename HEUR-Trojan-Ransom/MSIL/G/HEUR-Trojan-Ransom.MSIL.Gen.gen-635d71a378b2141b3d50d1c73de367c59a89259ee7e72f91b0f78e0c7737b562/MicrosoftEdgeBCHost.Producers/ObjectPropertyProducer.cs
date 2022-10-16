using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ObjectPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralSystem()
	{
	}
}
