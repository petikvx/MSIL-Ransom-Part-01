using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class DispatcherReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherReponse()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralWorker()
	{
	}
}
