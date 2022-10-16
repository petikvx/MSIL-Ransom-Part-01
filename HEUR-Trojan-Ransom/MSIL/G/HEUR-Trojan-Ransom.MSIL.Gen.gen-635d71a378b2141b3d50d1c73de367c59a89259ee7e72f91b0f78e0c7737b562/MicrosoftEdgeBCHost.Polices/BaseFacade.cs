using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class BaseFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseFacade()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralConsumer()
	{
	}
}
