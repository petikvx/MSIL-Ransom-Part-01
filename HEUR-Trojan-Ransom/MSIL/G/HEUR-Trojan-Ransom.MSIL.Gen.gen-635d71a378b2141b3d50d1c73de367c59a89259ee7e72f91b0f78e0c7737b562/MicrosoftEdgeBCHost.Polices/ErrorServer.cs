using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ErrorServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorServer()
	{
		WriterPropertyProducer.ResolveStub();
		CollectLiteralFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectLiteralFacade()
	{
	}
}
