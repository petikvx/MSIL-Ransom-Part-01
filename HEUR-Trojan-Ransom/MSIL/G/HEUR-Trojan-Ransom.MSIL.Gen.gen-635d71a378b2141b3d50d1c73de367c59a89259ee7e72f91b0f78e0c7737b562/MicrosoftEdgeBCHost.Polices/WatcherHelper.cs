using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class WatcherHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherHelper()
	{
		WriterPropertyProducer.ResolveStub();
		StopLiteralThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopLiteralThread()
	{
	}
}
