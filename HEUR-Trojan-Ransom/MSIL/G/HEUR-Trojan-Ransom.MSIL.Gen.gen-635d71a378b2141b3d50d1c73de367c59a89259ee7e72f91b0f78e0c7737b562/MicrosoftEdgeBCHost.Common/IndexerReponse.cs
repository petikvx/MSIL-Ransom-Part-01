using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class IndexerReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerReponse()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralWorker()
	{
	}
}
