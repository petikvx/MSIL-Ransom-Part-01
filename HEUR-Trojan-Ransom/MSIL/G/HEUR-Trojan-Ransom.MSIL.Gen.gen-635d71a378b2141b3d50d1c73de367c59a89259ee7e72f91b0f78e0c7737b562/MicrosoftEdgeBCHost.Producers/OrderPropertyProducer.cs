using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class OrderPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		VisitLiteralRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitLiteralRepository()
	{
	}
}
