using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ReaderServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderServer()
	{
		WriterPropertyProducer.ResolveStub();
		CancelLiteralFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelLiteralFacade()
	{
	}
}
